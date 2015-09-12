using System;       
using System.Collections.Generic;
using Amazon.RDS;
using Amazon.RDS.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace AWSSDK_DotNet.IntegrationTests.Tests.RDS
{
    
    public class DBParameters : TestBase<AmazonRDSClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"RDS")]
        public void TestDBParameterOperations()
        {
            const string engine = "mysql5.1";
            var parameterGroupName = "dotnet-test-param-group-" + DateTime.Now.Ticks;
            DBParameterGroup parameterGroup = null;
            DBParameterGroup parameterGroup2 = null;

            try
            {
                // Create a parameter group
                parameterGroup = Client.CreateDBParameterGroupAsync(
                    new CreateDBParameterGroupRequest
                    {
                        DBParameterGroupName = parameterGroupName,
                        Description = "description",
                        DBParameterGroupFamily = engine
                    }).Result.DBParameterGroup;
                Assert.Equal(parameterGroupName, parameterGroup.DBParameterGroupName);
                Assert.Equal("description", parameterGroup.Description);
                Assert.True(parameterGroup.DBParameterGroupFamily.StartsWith("mysql"));

                // Describe it
                var dbParameterGroups = Client.DescribeDBParameterGroupsAsync(
                    new DescribeDBParameterGroupsRequest
                    {
                        DBParameterGroupName = parameterGroupName,
                        MaxRecords = 20
                    }).Result.DBParameterGroups;

                Assert.Equal(1, dbParameterGroups.Count);
                Assert.Equal(parameterGroupName, dbParameterGroups[0].DBParameterGroupName);
                Assert.Equal("description", dbParameterGroups[0].Description);
                Assert.True(dbParameterGroups[0].DBParameterGroupFamily.StartsWith("mysql"));


                // Describe the params in a group
                var parameters = Client.DescribeDBParametersAsync(
                    new DescribeDBParametersRequest
                    {
                        DBParameterGroupName = parameterGroupName,
                        MaxRecords = 20
                    }).Result.Parameters;
                // We can't request a specific parameter, so we rely on the fact that most
                // parameters will have the following fields populated.
                assertValidParameter(parameters[0]);


                // Describe the defaults for an engine
                var engineDefaultParameters = Client.DescribeEngineDefaultParametersAsync(
                    new DescribeEngineDefaultParametersRequest
                    {
                        DBParameterGroupFamily = engine,
                        MaxRecords = 20
                    }).Result.EngineDefaults;
                Assert.Equal(engine, engineDefaultParameters.DBParameterGroupFamily);
                Assert.False(engineDefaultParameters.Parameters.Count == 0);
                assertValidParameter(engineDefaultParameters.Parameters[0]);


                // Reset the parameter group
                var resetParameterGroupName = Client.ResetDBParameterGroupAsync(
                    new ResetDBParameterGroupRequest
                    {
                        DBParameterGroupName = parameterGroupName,
                        ResetAllParameters = true
                    }).Result.DBParameterGroupName;
                Assert.Equal(parameterGroupName, resetParameterGroupName);


                // Modify the parameter group
                var newParameter = new Parameter
                {
                    ParameterName = "character_set_client",
                    ParameterValue = "ascii",
                    ApplyMethod = "immediate"
                };

                var modifyDbParameterGroupRequest = new ModifyDBParameterGroupRequest
                {
                    DBParameterGroupName = parameterGroupName,
                };
                modifyDbParameterGroupRequest.Parameters.Add(newParameter);
                var modifiedParameterGroupName = Client.ModifyDBParameterGroupAsync(modifyDbParameterGroupRequest)
                    .Result.DBParameterGroupName;
                Assert.Equal(parameterGroupName, modifiedParameterGroupName);

                // Copy the parameter group
                parameterGroup2 = Client.CopyDBParameterGroupAsync(new CopyDBParameterGroupRequest
                {
                    SourceDBParameterGroupIdentifier = parameterGroupName,
                    TargetDBParameterGroupIdentifier = parameterGroupName + "copy",
                    TargetDBParameterGroupDescription = "Copy of " + parameterGroupName
                }).Result.DBParameterGroup;
                Assert.Equal(parameterGroupName + "copy", parameterGroup2.DBParameterGroupName);
                Assert.Equal("Copy of " + parameterGroupName, parameterGroup2.Description);
                Assert.True(parameterGroup2.DBParameterGroupFamily.StartsWith("mysql"));
            }
            finally
            {
                if (parameterGroup != null)
                {
                    Client.DeleteDBParameterGroupAsync(new DeleteDBParameterGroupRequest
                    {
                        DBParameterGroupName = parameterGroup.DBParameterGroupName
                    }).Wait();
                }
                if (parameterGroup2 != null)
                {
                    Client.DeleteDBParameterGroupAsync(new DeleteDBParameterGroupRequest
                    {
                        DBParameterGroupName = parameterGroup2.DBParameterGroupName
                    }).Wait();
                }
            }
        }

        /**
         * Sanity checks a parameter to assert that the basic fields are populated.
         * If any missing data is found, this method will fail the current test.
         *
         * @param parameter
         *            The parameter to check.
         */
        void assertValidParameter(Parameter parameter)
        {
            assertNotEmpty(parameter.AllowedValues);
            assertNotEmpty(parameter.ApplyType);
            assertNotEmpty(parameter.DataType);
            assertNotEmpty(parameter.Description);
            assertNotEmpty(parameter.ParameterName);
            assertNotEmpty(parameter.Source);
        }

        void assertNotEmpty(String s)
        {
            Assert.NotNull(s);
            Assert.True(s.Length > 0);
        }
    }
}
