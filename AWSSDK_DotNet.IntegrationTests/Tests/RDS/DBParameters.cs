using System;       
using System.Collections.Generic;
using Amazon.RDS;
using Amazon.RDS.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests.RDS
{
    [TestClass]
    public class DBParameters : TestBase<AmazonRDSClient>
    {
        [TestMethod]
        [TestCategory("RDS")]
        public void TestDBParameterOperations()
        {
            const string engine = "mysql5.1";
            var parameterGroupName = "dotnet-test-param-group-" + DateTime.Now.Ticks;
            DBParameterGroup parameterGroup = null;
            DBParameterGroup parameterGroup2 = null;

            try
            {
                // Create a parameter group
                parameterGroup = Client.CreateDBParameterGroup(
                    new CreateDBParameterGroupRequest
                    {
                        DBParameterGroupName = parameterGroupName,
                        Description = "description",
                        DBParameterGroupFamily = engine
                    }).DBParameterGroup;
                Assert.AreEqual(parameterGroupName, parameterGroup.DBParameterGroupName);
                Assert.AreEqual("description", parameterGroup.Description);
                Assert.IsTrue(parameterGroup.DBParameterGroupFamily.StartsWith("mysql"));

                // Describe it
                var dbParameterGroups = Client.DescribeDBParameterGroups(
                    new DescribeDBParameterGroupsRequest
                    {
                        DBParameterGroupName = parameterGroupName,
                        MaxRecords = 20
                    }
                    ).DBParameterGroups;

                Assert.AreEqual(1, dbParameterGroups.Count);
                Assert.AreEqual(parameterGroupName, dbParameterGroups[0].DBParameterGroupName);
                Assert.AreEqual("description", dbParameterGroups[0].Description);
                Assert.IsTrue(dbParameterGroups[0].DBParameterGroupFamily.StartsWith("mysql"));


                // Describe the params in a group
                var parameters = Client.DescribeDBParameters(
                    new DescribeDBParametersRequest
                    {
                        DBParameterGroupName = parameterGroupName,
                        MaxRecords = 20
                    }
                    ).Parameters;
                // We can't request a specific parameter, so we rely on the fact that most
                // parameters will have the following fields populated.
                assertValidParameter(parameters[0]);


                // Describe the defaults for an engine
                var engineDefaultParameters = Client.DescribeEngineDefaultParameters(
                    new DescribeEngineDefaultParametersRequest
                    {
                        DBParameterGroupFamily = engine,
                        MaxRecords = 20
                    }).EngineDefaults;
                Assert.AreEqual(engine, engineDefaultParameters.DBParameterGroupFamily);
                Assert.IsFalse(engineDefaultParameters.Parameters.Count == 0);
                assertValidParameter(engineDefaultParameters.Parameters[0]);


                // Reset the parameter group
                var resetParameterGroupName = Client.ResetDBParameterGroup(
                    new ResetDBParameterGroupRequest
                    {
                        DBParameterGroupName = parameterGroupName,
                        ResetAllParameters = true
                    }
                    ).DBParameterGroupName;
                Assert.AreEqual(parameterGroupName, resetParameterGroupName);


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
                var modifiedParameterGroupName = Client.ModifyDBParameterGroup(modifyDbParameterGroupRequest)
                    .DBParameterGroupName;
                Assert.AreEqual(parameterGroupName, modifiedParameterGroupName);

                // Copy the parameter group
                parameterGroup2 = Client.CopyDBParameterGroup(new CopyDBParameterGroupRequest
                {
                    SourceDBParameterGroupIdentifier = parameterGroupName,
                    TargetDBParameterGroupIdentifier = parameterGroupName + "copy",
                    TargetDBParameterGroupDescription = "Copy of " + parameterGroupName
                }).DBParameterGroup;
                Assert.AreEqual(parameterGroupName + "copy", parameterGroup2.DBParameterGroupName);
                Assert.AreEqual("Copy of " + parameterGroupName, parameterGroup2.Description);
                Assert.IsTrue(parameterGroup2.DBParameterGroupFamily.StartsWith("mysql"));
            }
            finally
            {
                if (parameterGroup != null)
                {
                    Client.DeleteDBParameterGroup(new DeleteDBParameterGroupRequest
                    {
                        DBParameterGroupName = parameterGroup.DBParameterGroupName
                    });
                }
                if (parameterGroup2 != null)
                {
                    Client.DeleteDBParameterGroup(new DeleteDBParameterGroupRequest
                    {
                        DBParameterGroupName = parameterGroup2.DBParameterGroupName
                    });
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
            Assert.IsNotNull(s);
            Assert.IsTrue(s.Length > 0);
        }
    }
}
