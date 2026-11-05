using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DatabaseMigrationService;
using Amazon.DatabaseMigrationService.Model;

namespace AWSSDKDocSamples.Amazon.DatabaseMigrationService.Generated
{
    class DatabaseMigrationServiceSamples : ISample
    {
        public void DatabaseMigrationServiceAddTagsToResource()
        {
            #region AddTagsToResource-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.AddTagsToResource(new AddTagsToResourceRequest
            {
                ResourceArn = "arn:aws:dms:us-east-1:123456789012:endpoint:ASXWXJZLNWNT5HTWCGV2BUJQ7E",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Acount",
                        Value = "1633456"
                    }
                }
            });


            #endregion
        }

        public void DatabaseMigrationServiceCancelMetadataModelConversion()
        {
            #region CancelMetadataModelConversion-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CancelMetadataModelConversion(new CancelMetadataModelConversionRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                RequestIdentifier = "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });

            SchemaConversionRequest request = response.Request;

            #endregion
        }

        public void DatabaseMigrationServiceCancelMetadataModelCreation()
        {
            #region CancelMetadataModelCreation-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CancelMetadataModelCreation(new CancelMetadataModelCreationRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                RequestIdentifier = "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });

            SchemaConversionRequest request = response.Request;

            #endregion
        }

        public void DatabaseMigrationServiceCreateDataProvider()
        {
            #region CreateDataProvider-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CreateDataProvider(new CreateDataProviderRequest
            {
                DataProviderName = "example-data-provider",
                Description = "Example data provider for documentation",
                Engine = "sqlserver",
                Settings = new DataProviderSettings { MicrosoftSqlServerSettings = new MicrosoftSqlServerDataProviderSettings {
                    CertificateArn = "arn:aws:dms:us-east-1:111122223333:cert:EXAMPLEABCDEFGHIJKLMNOPQRS",
                    DatabaseName = "ExampleDatabase",
                    Port = 1433,
                    ServerName = "example-source-server.us-east-1.rds.amazonaws.com",
                    SslMode = "verify-full"
                } }
            });

            DataProvider dataProvider = response.DataProvider;

            #endregion
        }

        public void DatabaseMigrationServiceCreateEndpoint()
        {
            #region CreateEndpoint-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CreateEndpoint(new CreateEndpointRequest
            {
                CertificateArn = "",
                DatabaseName = "testdb",
                EndpointIdentifier = "test-endpoint-1",
                EndpointType = "source",
                EngineName = "mysql",
                ExtraConnectionAttributes = "",
                KmsKeyId = "arn:aws:kms:us-east-1:123456789012:key/4c1731d6-5435-ed4d-be13-d53411a7cfbd",
                Password = "pasword",
                Port = 3306,
                ServerName = "mydb.cx1llnox7iyx.us-west-2.rds.amazonaws.com",
                SslMode = "require",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Acount",
                        Value = "143327655"
                    }
                },
                Username = "username"
            });

            Endpoint endpoint = response.Endpoint;

            #endregion
        }

        public void DatabaseMigrationServiceCreateInstanceProfile()
        {
            #region CreateInstanceProfile-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CreateInstanceProfile(new CreateInstanceProfileRequest
            {
                Description = "Example instance profile for documentation",
                InstanceProfileName = "example-instance-profile",
                KmsKeyArn = "arn:aws:kms:us-east-1:111122223333:key/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                NetworkType = "IPV4",
                PubliclyAccessible = false,
                SubnetGroupIdentifier = "example-replication-subnet-group",
                VpcSecurityGroups = new List<string> {
                    "sg-0123456789abcdef0"
                }
            });

            InstanceProfile instanceProfile = response.InstanceProfile;

            #endregion
        }

        public void DatabaseMigrationServiceCreateMigrationProject()
        {
            #region CreateMigrationProject-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CreateMigrationProject(new CreateMigrationProjectRequest
            {
                Description = "Example migration project for documentation",
                InstanceProfileIdentifier = "arn:aws:dms:us-east-1:111122223333:instance-profile:EXAMPLEABCDEFGHIJKLMNOPQRS",
                MigrationProjectName = "example-migration-project",
                SchemaConversionApplicationAttributes = new SCApplicationAttributes {
                    S3BucketPath = "s3://amzn-s3-demo-bucket",
                    S3BucketRoleArn = "arn:aws:iam::111122223333:role/example-s3-access-role"
                },
                SourceDataProviderDescriptors = new List<DataProviderDescriptorDefinition> {
                    new DataProviderDescriptorDefinition {
                        DataProviderIdentifier = "arn:aws:dms:us-east-1:111122223333:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRS",
                        SecretsManagerAccessRoleArn = "arn:aws:iam::111122223333:role/example-secrets-manager-role",
                        SecretsManagerSecretId = "arn:aws:secretsmanager:us-east-1:111122223333:secret:example-source-secret-A1B2C3"
                    }
                },
                TargetDataProviderDescriptors = new List<DataProviderDescriptorDefinition> {
                    new DataProviderDescriptorDefinition {
                        DataProviderIdentifier = "arn:aws:dms:us-east-1:111122223333:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRS",
                        SecretsManagerAccessRoleArn = "arn:aws:iam::111122223333:role/example-secrets-manager-role",
                        SecretsManagerSecretId = "arn:aws:secretsmanager:us-east-1:111122223333:secret:example-target-secret-A1B2C3"
                    }
                },
                TransformationRules = "{\"rules\":[{\"rule-type\":\"transformation\",\"rule-id\":\"1\",\"rule-name\":\"1\",\"rule-target\":\"schema\",\"rule-action\":\"rename\",\"object-locator\":{\"schema-name\":\"ExampleSchema\"},\"value\":\"TargetSchema\"}]}"
            });

            MigrationProject migrationProject = response.MigrationProject;

            #endregion
        }

        public void DatabaseMigrationServiceCreateReplicationInstance()
        {
            #region CreateReplicationInstance-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CreateReplicationInstance(new CreateReplicationInstanceRequest
            {
                AllocatedStorage = 123,
                AutoMinorVersionUpgrade = true,
                AvailabilityZone = "",
                EngineVersion = "",
                KmsKeyId = "",
                MultiAZ = true,
                PreferredMaintenanceWindow = "",
                PubliclyAccessible = true,
                ReplicationInstanceClass = "",
                ReplicationInstanceIdentifier = "",
                ReplicationSubnetGroupIdentifier = "",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "string",
                        Value = "string"
                    }
                },
                VpcSecurityGroupIds = new List<string> {
                }
            });

            ReplicationInstance replicationInstance = response.ReplicationInstance;

            #endregion
        }

        public void DatabaseMigrationServiceCreateReplicationSubnetGroup()
        {
            #region CreateReplicationSubnetGroup-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CreateReplicationSubnetGroup(new CreateReplicationSubnetGroupRequest
            {
                ReplicationSubnetGroupDescription = "US West subnet group",
                ReplicationSubnetGroupIdentifier = "us-west-2ab-vpc-215ds366",
                SubnetIds = new List<string> {
                    "subnet-e145356n",
                    "subnet-58f79200"
                },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Acount",
                        Value = "145235"
                    }
                }
            });

            ReplicationSubnetGroup replicationSubnetGroup = response.ReplicationSubnetGroup;

            #endregion
        }

        public void DatabaseMigrationServiceCreateReplicationTask()
        {
            #region CreateReplicationTask-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CreateReplicationTask(new CreateReplicationTaskRequest
            {
                CdcStartTime = new DateTime(2016, 12, 14, 18, 25, 43, DateTimeKind.Utc),
                MigrationType = "full-load",
                ReplicationInstanceArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ",
                ReplicationTaskIdentifier = "task1",
                ReplicationTaskSettings = "",
                SourceEndpointArn = "arn:aws:dms:us-east-1:123456789012:endpoint:ZW5UAN6P4E77EC7YWHK4RZZ3BE",
                TableMappings = "file://mappingfile.json",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Acount",
                        Value = "24352226"
                    }
                },
                TargetEndpointArn = "arn:aws:dms:us-east-1:123456789012:endpoint:ASXWXJZLNWNT5HTWCGV2BUJQ7E"
            });

            ReplicationTask replicationTask = response.ReplicationTask;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteCertificate()
        {
            #region DeleteCertificate-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteCertificate(new DeleteCertificateRequest
            {
                CertificateArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUSM457DE6XFJCJQ"
            });

            Certificate certificate = response.Certificate;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteConnection()
        {
            #region DeleteConnection-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteConnection(new DeleteConnectionRequest
            {
                EndpointArn = "arn:aws:dms:us-east-1:123456789012:endpoint:RAAR3R22XSH46S3PWLC3NJAWKM",
                ReplicationInstanceArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ"
            });

            Connection connection = response.Connection;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteDataProvider()
        {
            #region DeleteDataProvider-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteDataProvider(new DeleteDataProviderRequest
            {
                DataProviderIdentifier = "arn:aws:dms:us-east-1:111122223333:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            DataProvider dataProvider = response.DataProvider;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteEndpoint()
        {
            #region DeleteEndpoint-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteEndpoint(new DeleteEndpointRequest
            {
                EndpointArn = "arn:aws:dms:us-east-1:123456789012:endpoint:RAAR3R22XSH46S3PWLC3NJAWKM"
            });

            Endpoint endpoint = response.Endpoint;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteInstanceProfile()
        {
            #region DeleteInstanceProfile-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteInstanceProfile(new DeleteInstanceProfileRequest
            {
                InstanceProfileIdentifier = "arn:aws:dms:us-east-1:111122223333:instance-profile:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            InstanceProfile instanceProfile = response.InstanceProfile;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteMigrationProject()
        {
            #region DeleteMigrationProject-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteMigrationProject(new DeleteMigrationProjectRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            MigrationProject migrationProject = response.MigrationProject;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteReplicationInstance()
        {
            #region DeleteReplicationInstance-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteReplicationInstance(new DeleteReplicationInstanceRequest
            {
                ReplicationInstanceArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ"
            });

            ReplicationInstance replicationInstance = response.ReplicationInstance;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteReplicationSubnetGroup()
        {
            #region DeleteReplicationSubnetGroup-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteReplicationSubnetGroup(new DeleteReplicationSubnetGroupRequest
            {
                ReplicationSubnetGroupIdentifier = "us-west-2ab-vpc-215ds366"
            });


            #endregion
        }

        public void DatabaseMigrationServiceDeleteReplicationTask()
        {
            #region DeleteReplicationTask-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteReplicationTask(new DeleteReplicationTaskRequest
            {
                ReplicationTaskArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ"
            });

            ReplicationTask replicationTask = response.ReplicationTask;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeAccountAttributes()
        {
            #region DescribeAccountAttributes-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeAccountAttributes(new DescribeAccountAttributesRequest
            {
            });

            List<AccountQuota> accountQuotas = response.AccountQuotas;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeCertificates()
        {
            #region DescribeCertificates-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeCertificates(new DescribeCertificatesRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            List<Certificate> certificates = response.Certificates;
            string marker = response.Marker;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeConnections()
        {
            #region DescribeConnections-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeConnections(new DescribeConnectionsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            List<Connection> connections = response.Connections;
            string marker = response.Marker;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeConversionConfiguration()
        {
            #region DescribeConversionConfiguration-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeConversionConfiguration(new DescribeConversionConfigurationRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            string conversionConfiguration = response.ConversionConfiguration;
            string migrationProjectIdentifier = response.MigrationProjectIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeDataProviders()
        {
            #region DescribeDataProviders-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeDataProviders(new DescribeDataProvidersRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "data-provider-identifier",
                        Values = new List<string> {
                            "arn:aws:dms:us-east-1:111122223333:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRS"
                        }
                    }
                }
            });

            List<DataProvider> dataProviders = response.DataProviders;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeEndpoints()
        {
            #region DescribeEndpoints-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeEndpoints(new DescribeEndpointsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            List<Endpoint> endpoints = response.Endpoints;
            string marker = response.Marker;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeEndpointTypes()
        {
            #region DescribeEndpointTypes-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeEndpointTypes(new DescribeEndpointTypesRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<SupportedEndpointType> supportedEndpointTypes = response.SupportedEndpointTypes;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeExtensionPackAssociations()
        {
            #region DescribeExtensionPackAssociations-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeExtensionPackAssociations(new DescribeExtensionPackAssociationsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "request-id",
                        Values = new List<string> {
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE22222",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE33333"
                        }
                    }
                },
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeInstanceProfiles()
        {
            #region DescribeInstanceProfiles-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeInstanceProfiles(new DescribeInstanceProfilesRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "instance-profile-identifier",
                        Values = new List<string> {
                            "arn:aws:dms:us-east-1:111122223333:instance-profile:EXAMPLEABCDEFGHIJKLMNOPQRS"
                        }
                    }
                }
            });

            List<InstanceProfile> instanceProfiles = response.InstanceProfiles;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModel()
        {
            #region DescribeMetadataModel-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModel(new DescribeMetadataModelRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                Origin = "SOURCE",
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\", \"rule-id\": \"1\", \"rule-name\": \"1\", \"object-locator\": {\"server-name\": \"example-source-server.us-east-1.rds.amazonaws.com\", \"schema-name\": \"ExampleSchema\", \"table-name\": \"ExampleTable\"}, \"rule-action\": \"explicit\"}]}"
            });

            string definition = response.Definition;
            string metadataModelName = response.MetadataModelName;
            string metadataModelType = response.MetadataModelType;
            List<MetadataModelReference> targetMetadataModels = response.TargetMetadataModels;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelAssessments()
        {
            #region DescribeMetadataModelAssessments-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelAssessments(new DescribeMetadataModelAssessmentsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "request-id",
                        Values = new List<string> {
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE22222",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE33333"
                        }
                    }
                },
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelChildren()
        {
            #region DescribeMetadataModelChildren-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelChildren(new DescribeMetadataModelChildrenRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                Origin = "SOURCE",
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\", \"rule-id\": \"1\", \"rule-name\": \"1\", \"object-locator\": {\"server-name\": \"example-source-server.us-east-1.rds.amazonaws.com\", \"schema-name\": \"ExampleSchema\"}, \"rule-action\": \"explicit\"}]}"
            });

            List<MetadataModelReference> metadataModelChildren = response.MetadataModelChildren;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelConversions()
        {
            #region DescribeMetadataModelConversions-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelConversions(new DescribeMetadataModelConversionsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "request-id",
                        Values = new List<string> {
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE22222",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE33333"
                        }
                    }
                },
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelCreations()
        {
            #region DescribeMetadataModelCreations-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelCreations(new DescribeMetadataModelCreationsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "request-id",
                        Values = new List<string> {
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE22222",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE33333"
                        }
                    }
                },
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelExportsAsScript()
        {
            #region DescribeMetadataModelExportsAsScript-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelExportsAsScript(new DescribeMetadataModelExportsAsScriptRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "request-id",
                        Values = new List<string> {
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE22222",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE33333"
                        }
                    }
                },
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelExportsToTarget()
        {
            #region DescribeMetadataModelExportsToTarget-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelExportsToTarget(new DescribeMetadataModelExportsToTargetRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "request-id",
                        Values = new List<string> {
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE22222",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE33333"
                        }
                    }
                },
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelImports()
        {
            #region DescribeMetadataModelImports-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelImports(new DescribeMetadataModelImportsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "request-id",
                        Values = new List<string> {
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE22222",
                            "a1b2c3d4-5678-90ab-cdef-EXAMPLE33333"
                        }
                    }
                },
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMigrationProjects()
        {
            #region DescribeMigrationProjects-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMigrationProjects(new DescribeMigrationProjectsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "migration-project-identifier",
                        Values = new List<string> {
                            "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
                        }
                    }
                }
            });

            List<MigrationProject> migrationProjects = response.MigrationProjects;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeOrderableReplicationInstances()
        {
            #region DescribeOrderableReplicationInstances-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeOrderableReplicationInstances(new DescribeOrderableReplicationInstancesRequest
            {
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<OrderableReplicationInstance> orderableReplicationInstances = response.OrderableReplicationInstances;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeRefreshSchemasStatus()
        {
            #region DescribeRefreshSchemasStatus-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeRefreshSchemasStatus(new DescribeRefreshSchemasStatusRequest
            {
                EndpointArn = ""
            });

            RefreshSchemasStatus refreshSchemasStatus = response.RefreshSchemasStatus;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeReplicationInstances()
        {
            #region DescribeReplicationInstances-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeReplicationInstances(new DescribeReplicationInstancesRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<ReplicationInstance> replicationInstances = response.ReplicationInstances;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeReplicationSubnetGroups()
        {
            #region DescribeReplicationSubnetGroups-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeReplicationSubnetGroups(new DescribeReplicationSubnetGroupsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<ReplicationSubnetGroup> replicationSubnetGroups = response.ReplicationSubnetGroups;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeReplicationTasks()
        {
            #region DescribeReplicationTasks-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeReplicationTasks(new DescribeReplicationTasksRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<ReplicationTask> replicationTasks = response.ReplicationTasks;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeSchemas()
        {
            #region DescribeSchemas-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeSchemas(new DescribeSchemasRequest
            {
                EndpointArn = "",
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<string> schemas = response.Schemas;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeTableStatistics()
        {
            #region DescribeTableStatistics-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeTableStatistics(new DescribeTableStatisticsRequest
            {
                Marker = "",
                MaxRecords = 123,
                ReplicationTaskArn = ""
            });

            string marker = response.Marker;
            string replicationTaskArn = response.ReplicationTaskArn;
            List<TableStatistics> tableStatistics = response.TableStatistics;

            #endregion
        }

        public void DatabaseMigrationServiceExportMetadataModelAssessment()
        {
            #region ExportMetadataModelAssessment-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ExportMetadataModelAssessment(new ExportMetadataModelAssessmentRequest
            {
                AssessmentReportTypes = new List<string> {
                    "pdf",
                    "csv"
                },
                FileName = "example-assessment-report",
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\", \"rule-id\": \"1\", \"rule-name\": \"1\", \"object-locator\": {\"server-name\": \"example-source-server.us-east-1.rds.amazonaws.com\", \"schema-name\": \"ExampleSchema\"}, \"rule-action\": \"explicit\"}]}"
            });

            ExportMetadataModelAssessmentResultEntry csvReport = response.CsvReport;
            ExportMetadataModelAssessmentResultEntry pdfReport = response.PdfReport;

            #endregion
        }

        public void DatabaseMigrationServiceGetTargetSelectionRules()
        {
            #region GetTargetSelectionRules-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.GetTargetSelectionRules(new GetTargetSelectionRulesRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\", \"rule-id\": \"1\", \"rule-name\": \"1\", \"object-locator\": {\"server-name\": \"example-source-server.us-east-1.rds.amazonaws.com\", \"database-name\": \"ExampleDatabase\", \"schema-name\": \"ExampleSchema\", \"table-name\": \"ExampleTable\"}, \"rule-action\": \"explicit\"}]}"
            });

            string targetSelectionRules = response.TargetSelectionRules;

            #endregion
        }

        public void DatabaseMigrationServiceImportCertificate()
        {
            #region ImportCertificate-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ImportCertificate(new ImportCertificateRequest
            {
                CertificateIdentifier = "",
                CertificatePem = ""
            });

            Certificate certificate = response.Certificate;

            #endregion
        }

        public void DatabaseMigrationServiceListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = ""
            });

            List<Tag> tagList = response.TagList;

            #endregion
        }

        public void DatabaseMigrationServiceModifyConversionConfiguration()
        {
            #region ModifyConversionConfiguration-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ModifyConversionConfiguration(new ModifyConversionConfigurationRequest
            {
                ConversionConfiguration = "{\"Common project settings\":{\"EnableGenAiConversion\":true},\"MSSQL_TO_AURORA_POSTGRESQL\":{\"ConvertProceduresToFunction\":false}}",
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            string migrationProjectIdentifier = response.MigrationProjectIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceModifyDataProvider()
        {
            #region ModifyDataProvider-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ModifyDataProvider(new ModifyDataProviderRequest
            {
                DataProviderIdentifier = "arn:aws:dms:us-east-1:111122223333:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRS",
                Description = "Updated data provider description",
                Engine = "sqlserver",
                Settings = new DataProviderSettings { MicrosoftSqlServerSettings = new MicrosoftSqlServerDataProviderSettings { ServerName = "new-source-server.us-east-1.rds.amazonaws.com" } }
            });

            DataProvider dataProvider = response.DataProvider;

            #endregion
        }

        public void DatabaseMigrationServiceModifyEndpoint()
        {
            #region ModifyEndpoint-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ModifyEndpoint(new ModifyEndpointRequest
            {
                CertificateArn = "",
                DatabaseName = "",
                EndpointArn = "",
                EndpointIdentifier = "",
                EndpointType = "source",
                EngineName = "",
                ExtraConnectionAttributes = "",
                Password = "",
                Port = 123,
                ServerName = "",
                SslMode = "require",
                Username = ""
            });

            Endpoint endpoint = response.Endpoint;

            #endregion
        }

        public void DatabaseMigrationServiceModifyInstanceProfile()
        {
            #region ModifyInstanceProfile-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ModifyInstanceProfile(new ModifyInstanceProfileRequest
            {
                Description = "Updated instance profile description",
                InstanceProfileIdentifier = "arn:aws:dms:us-east-1:111122223333:instance-profile:EXAMPLEABCDEFGHIJKLMNOPQRS",
                NetworkType = "DUAL"
            });

            InstanceProfile instanceProfile = response.InstanceProfile;

            #endregion
        }

        public void DatabaseMigrationServiceModifyMigrationProject()
        {
            #region ModifyMigrationProject-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ModifyMigrationProject(new ModifyMigrationProjectRequest
            {
                Description = "Updated migration project description",
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                SourceDataProviderDescriptors = new List<DataProviderDescriptorDefinition> {
                    new DataProviderDescriptorDefinition { DataProviderIdentifier = "arn:aws:dms:us-east-1:111122223333:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRS" }
                }
            });

            MigrationProject migrationProject = response.MigrationProject;

            #endregion
        }

        public void DatabaseMigrationServiceModifyReplicationInstance()
        {
            #region ModifyReplicationInstance-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ModifyReplicationInstance(new ModifyReplicationInstanceRequest
            {
                AllocatedStorage = 123,
                AllowMajorVersionUpgrade = true,
                ApplyImmediately = true,
                AutoMinorVersionUpgrade = true,
                EngineVersion = "1.5.0",
                MultiAZ = true,
                PreferredMaintenanceWindow = "sun:06:00-sun:14:00",
                ReplicationInstanceArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ",
                ReplicationInstanceClass = "dms.t2.micro",
                ReplicationInstanceIdentifier = "test-rep-1",
                VpcSecurityGroupIds = new List<string> {
                }
            });

            ReplicationInstance replicationInstance = response.ReplicationInstance;

            #endregion
        }

        public void DatabaseMigrationServiceModifyReplicationSubnetGroup()
        {
            #region ModifyReplicationSubnetGroup-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ModifyReplicationSubnetGroup(new ModifyReplicationSubnetGroupRequest
            {
                ReplicationSubnetGroupDescription = "",
                ReplicationSubnetGroupIdentifier = "",
                SubnetIds = new List<string> {
                }
            });

            ReplicationSubnetGroup replicationSubnetGroup = response.ReplicationSubnetGroup;

            #endregion
        }

        public void DatabaseMigrationServiceRefreshSchemas()
        {
            #region RefreshSchemas-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.RefreshSchemas(new RefreshSchemasRequest
            {
                EndpointArn = "",
                ReplicationInstanceArn = ""
            });

            RefreshSchemasStatus refreshSchemasStatus = response.RefreshSchemasStatus;

            #endregion
        }

        public void DatabaseMigrationServiceRemoveTagsFromResource()
        {
            #region RemoveTagsFromResource-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.RemoveTagsFromResource(new RemoveTagsFromResourceRequest
            {
                ResourceArn = "arn:aws:dms:us-east-1:123456789012:endpoint:ASXWXJZLNWNT5HTWCGV2BUJQ7E",
                TagKeys = new List<string> {
                }
            });


            #endregion
        }

        public void DatabaseMigrationServiceStartExtensionPackAssociation()
        {
            #region StartExtensionPackAssociation-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartExtensionPackAssociation(new StartExtensionPackAssociationRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartMetadataModelAssessment()
        {
            #region StartMetadataModelAssessment-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartMetadataModelAssessment(new StartMetadataModelAssessmentRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\",\"rule-id\": \"1\",\"rule-name\": \"1\",\"object-locator\": {\"server-name\": \"example-source-server.us-east-1.rds.amazonaws.com\", \"schema-name\": \"ExampleSchema\"},\"rule-action\": \"explicit\"}]}"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartMetadataModelConversion()
        {
            #region StartMetadataModelConversion-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartMetadataModelConversion(new StartMetadataModelConversionRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\",\"rule-id\": \"1\",\"rule-name\": \"1\",\"object-locator\": {\"server-name\": \"example-source-server.us-east-1.rds.amazonaws.com\", \"schema-name\": \"ExampleSchema\"},\"rule-action\": \"explicit\"}]}"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartMetadataModelCreation()
        {
            #region StartMetadataModelCreation-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartMetadataModelCreation(new StartMetadataModelCreationRequest
            {
                MetadataModelName = "ExampleStatement",
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                Properties = new MetadataModelProperties { StatementProperties = new StatementProperties { Definition = "SELECT * FROM ExampleTable;" } },
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\", \"rule-id\": \"1\", \"rule-name\": \"1\", \"object-locator\": {\"server-name\": \"example-source-server.us-east-1.rds.amazonaws.com\", \"database-name\": \"ExampleDatabase\", \"schema-name\": \"ExampleSchema\"}, \"rule-action\": \"explicit\"}]}"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartMetadataModelExportAsScript()
        {
            #region StartMetadataModelExportAsScript-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartMetadataModelExportAsScript(new StartMetadataModelExportAsScriptRequest
            {
                FileName = "ExampleScript",
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                Origin = "TARGET",
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\",\"rule-id\": \"1\",\"rule-name\": \"1\",\"object-locator\": {\"server-name\": \"example-target-server.us-east-1.rds.amazonaws.com\", \"schema-name\": \"ExampleSchema\"},\"rule-action\": \"explicit\"}]}"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartMetadataModelExportToTarget()
        {
            #region StartMetadataModelExportToTarget-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartMetadataModelExportToTarget(new StartMetadataModelExportToTargetRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                OverwriteExtensionPack = true,
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\",\"rule-id\": \"1\",\"rule-name\": \"1\",\"object-locator\": {\"server-name\": \"example-target-server.us-east-1.rds.amazonaws.com\", \"schema-name\": \"ExampleSchema\"},\"rule-action\": \"explicit\"}]}"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartMetadataModelImport()
        {
            #region StartMetadataModelImport-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartMetadataModelImport(new StartMetadataModelImportRequest
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:111122223333:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRS",
                Origin = "SOURCE",
                Refresh = false,
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\",\"rule-id\": \"1\",\"rule-name\": \"1\",\"object-locator\": {\"server-name\": \"example-source-server.us-east-1.rds.amazonaws.com\", \"schema-name\": \"ExampleSchema\"},\"rule-action\": \"explicit\"}]}"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartReplicationTask()
        {
            #region StartReplicationTask-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartReplicationTask(new StartReplicationTaskRequest
            {
                CdcStartTime = new DateTime(2016, 12, 14, 13, 33, 20, DateTimeKind.Utc),
                ReplicationTaskArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ",
                StartReplicationTaskType = "start-replication"
            });

            ReplicationTask replicationTask = response.ReplicationTask;

            #endregion
        }

        public void DatabaseMigrationServiceStopReplicationTask()
        {
            #region StopReplicationTask-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StopReplicationTask(new StopReplicationTaskRequest
            {
                ReplicationTaskArn = "arn:aws:dms:us-east-1:123456789012:endpoint:ASXWXJZLNWNT5HTWCGV2BUJQ7E"
            });

            ReplicationTask replicationTask = response.ReplicationTask;

            #endregion
        }

        public void DatabaseMigrationServiceTestConnection()
        {
            #region TestConnection-1

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.TestConnection(new TestConnectionRequest
            {
                EndpointArn = "arn:aws:dms:us-east-1:123456789012:endpoint:RAAR3R22XSH46S3PWLC3NJAWKM",
                ReplicationInstanceArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ"
            });

            Connection connection = response.Connection;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
