using Dapper;
using EHR.Core.Contracts;
using EHR.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EHR.Application.Data;

namespace EHR.Infrastructure.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DatabaseContext _context;
        public PatientRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task AddNewPatient(Patient patient)
        {
            var query1 = "SELECT * FROM Patients where Email = @Email";
            var parameters = new DynamicParameters();
            parameters.Add("Email", patient.Email, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                connection.Open();
                var patientCheck = await connection.QueryAsync<Patient>(query1);
                if (patientCheck == null)
                {
                    var query2 = "INSERT INTO Patients(LastName, FirstName, HomeAddress, WorkAddress,Email, DOB, sex, MaritalStatus, Religion, Ethnic, BloodGroup,Genotype, Occupation," +
                        "PhoneNumber,Picture,NkSurname,NkFirstName, NkHomeAddress,NkWorkAddress, NkEmail, NkPhoneNumber, Balance,WardId, CreatedBy,CreatedDate) VALUES (@LastName,@FirstName,@HomeAddress,@WorkAddress,@Email,@DOB,@sex,@MaritalStatus, @Religion,@Ethnic, @BloodGroup,@Genotype, @Occupation,@PhoneNumber,@Picture,@NkSurname,@NkFirstName, @NkHomeAddress,@NkWorkAddress, @NkEmail, @NkPhoneNumber, @Balance,@WardId,@CreatedBy,@CreatedDate)";
                    var parameters2 = new DynamicParameters();
                    parameters2.Add("LastName", patient.LastName, DbType.String);
                    parameters2.Add("FirstName", patient.FirstName, DbType.String);
                    parameters2.Add("HomeAddress", patient.HomeAddress, DbType.String);
                    parameters2.Add("WorkAddress", patient.WorkAddress, DbType.String);
                    parameters2.Add("Email", patient.Email, DbType.String);
                    parameters2.Add("DOB", patient.DOB, DbType.String);
                    parameters2.Add("sex", patient.sex, DbType.String);
                    parameters2.Add("MaritalStatus", patient.MaritalStatus, DbType.String);
                    parameters2.Add("Religion", patient.Religion, DbType.String);
                    parameters2.Add("Ethnic", patient.Ethnic, DbType.String);
                    parameters2.Add("BloodGroup", patient.BloodGroup, DbType.String);
                    parameters2.Add("Genotype", patient.Genotype, DbType.String);
                    parameters2.Add("Occupation", patient.Occupation, DbType.String);
                    parameters2.Add("PhoneNumber", patient.PhoneNumber, DbType.String);
                    parameters2.Add("Picture", patient.Picture, DbType.String);
                    parameters2.Add("NkSurname", patient.NkSurname, DbType.String);
                    parameters2.Add("NkFirstName", patient.NkFirstName, DbType.String);
                    parameters2.Add("NkHomeAddress", patient.NkHomeAddress, DbType.String);
                    parameters2.Add("NkWorkAddress", patient.NkWorkAddress, DbType.String);
                    parameters2.Add("NkEmail", patient.NkEmail, DbType.String);
                    parameters2.Add("NkPhoneNumber", patient.NkPhoneNumber, DbType.String);
                    parameters2.Add("Balance", patient.Balance, DbType.Int32);
                    parameters2.Add("WardId", patient.WardId, DbType.Int32);
                    parameters2.Add("CreatedBy", patient.CreatedBy, DbType.DateTime);
                    parameters2.Add("CreatedDate", patient.CreatedDate, DbType.DateTime);

                    await connection.ExecuteAsync(query2, parameters2);

                }

            }
        }
    }
}
