using CommonTests.Framework;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Util;

namespace CommonTests.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        private static void ConfigureContext()
        {
            var currentStatusPropertyConfig = new PropertyConfig("CurrentStatus")
            {
                Converter = typeof(StatusConverter)
            };

            var employeeMapping = new TypeMapping(typeof(Employee), "HashRangeTable");
            employeeMapping.AddProperty(new PropertyConfig("ManagerName") { Attribute = "Manager" });
            employeeMapping.AddProperty(new PropertyConfig("CompanyName") { Attribute = "Company" });
            employeeMapping.AddProperty(new PropertyConfig("InternalId") { Ignore = true });
            employeeMapping.AddProperty(currentStatusPropertyConfig);

            var employee2Mapping = new TypeMapping(typeof(Employee2), "HashRangeTable");
            employee2Mapping.AddProperty(currentStatusPropertyConfig);

            var employee3Mapping = new TypeMapping(typeof(Employee3), "HashRangeTable");
            employee3Mapping.AddProperty(currentStatusPropertyConfig);

            var versionedEmployeeMapping = new TypeMapping(typeof(VersionedEmployee), "FakeTable");
            versionedEmployeeMapping.AddProperty(new PropertyConfig("Version") { Ignore = true });

            var context = AWSConfigsDynamoDB.Context;
            context.TableAliases["FakeTable"] = "HashRangeTable";
            context.AddMapping(versionedEmployeeMapping);
            context.AddMapping(employeeMapping);
            context.AddMapping(employee2Mapping);
            context.AddMapping(employee3Mapping);
        }
    }
}
