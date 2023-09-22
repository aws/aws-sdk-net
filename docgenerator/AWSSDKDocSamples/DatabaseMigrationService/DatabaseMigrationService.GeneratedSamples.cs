using System;
using System.Collections.Generic;
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
            #region add-tags-to-resource-1481744141435

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.AddTagsToResource(new AddTagsToResourceRequest 
            {
                ResourceArn = "arn:aws:dms:us-east-1:123456789012:endpoint:ASXWXJZLNWNT5HTWCGV2BUJQ7E", // Required. Use the ARN of the resource you want to tag.
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Acount",
                        Value = "1633456"
                    }
                } // Required. Use the Key/Value pair format.
            });


            #endregion
        }

        public void DatabaseMigrationServiceCreateDataProvider()
        {
            #region create-data-provider-1689726511871

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CreateDataProvider(new CreateDataProviderRequest 
            {
                DataProviderName = "sqlServer-dev",
                Description = "description",
                Engine = "sqlserver",
                Settings = new DataProviderSettings { MicrosoftSqlServerSettings = new MicrosoftSqlServerDataProviderSettings {
                    DatabaseName = "DatabaseName",
                    Port = 11112,
                    ServerName = "ServerName2",
                    SslMode = "none"
                } },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "access",
                        Value = "authorizedusers"
                    }
                }
            });

            DataProvider dataProvider = response.DataProvider;

            #endregion
        }

        public void DatabaseMigrationServiceCreateEndpoint()
        {
            #region create-endpoint-1481746254348

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
            #region create-instance-profile-1689716070633

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CreateInstanceProfile(new CreateInstanceProfileRequest 
            {
                Description = "Description",
                InstanceProfileName = "my-instance-profile",
                KmsKeyArn = "arn:aws:kms:us-east-1:012345678901:key/01234567-89ab-cdef-0123-456789abcdef",
                NetworkType = "DUAL",
                PubliclyAccessible = true,
                SubnetGroupIdentifier = "my-subnet-group",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "access",
                        Value = "authorizedusers"
                    }
                }
            });

            InstanceProfile instanceProfile = response.InstanceProfile;

            #endregion
        }

        public void DatabaseMigrationServiceCreateMigrationProject()
        {
            #region create-migration-project-1689716672685

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CreateMigrationProject(new CreateMigrationProjectRequest 
            {
                Description = "description",
                InstanceProfileIdentifier = "ip-au-17",
                MigrationProjectName = "my-migration-project",
                SchemaConversionApplicationAttributes = new SCApplicationAttributes {
                    S3BucketPath = "arn:aws:s3:::mylogin-bucket",
                    S3BucketRoleArn = "arn:aws:iam::012345678901:role/Admin"
                },
                SourceDataProviderDescriptors = new List<DataProviderDescriptorDefinition> {
                    new DataProviderDescriptorDefinition {
                        DataProviderIdentifier = "arn:aws:dms:us-east-1:012345678901:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345",
                        SecretsManagerAccessRoleArn = "arn:aws:iam::012345678901:role/myuser-admin-access",
                        SecretsManagerSecretId = "arn:aws:secretsmanager:us-east-1:012345678901:secret:myorg/example1/ALL.SOURCE.ORACLE_12-A1B2C3"
                    }
                },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "access",
                        Value = "authorizedusers"
                    }
                },
                TargetDataProviderDescriptors = new List<DataProviderDescriptorDefinition> {
                    new DataProviderDescriptorDefinition {
                        DataProviderIdentifier = "arn:aws:dms:us-east-1:012345678901:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345",
                        SecretsManagerAccessRoleArn = "arn:aws:iam::012345678901:role/myuser-admin-access",
                        SecretsManagerSecretId = "arn:aws:secretsmanager:us-east-1:012345678901:secret:myorg/example1/TARGET.postgresql-A1B2C3"
                    }
                },
                TransformationRules = "{\"key0\":\"value0\",\"key1\":\"value1\",\"key2\":\"value2\"}"
            });

            MigrationProject migrationProject = response.MigrationProject;

            #endregion
        }

        public void DatabaseMigrationServiceCreateReplicationInstance()
        {
            #region create-replication-instance-1481746705295

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
            #region create-replication-subnet-group-1481747297930

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
            #region create-replication-task-1481747646288

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.CreateReplicationTask(new CreateReplicationTaskRequest 
            {
                CdcStartTime = new DateTime(2016, 12, 14, 6, 25, 43, DateTimeKind.Utc),
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
            #region delete-certificate-1481751957981

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
            #region delete-connection-1481751957981

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
            #region delete-data-provider-1689724476356

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteDataProvider(new DeleteDataProviderRequest 
            {
                DataProviderIdentifier = "arn:aws:dms:us-east-1:012345678901:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345"
            });

            DataProvider dataProvider = response.DataProvider;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteEndpoint()
        {
            #region delete-endpoint-1481752425530

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
            #region delete-instance-profile-1689716924105

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteInstanceProfile(new DeleteInstanceProfileRequest 
            {
                InstanceProfileIdentifier = "arn:aws:dms:us-east-1:012345678901:instance-profile:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345"
            });

            InstanceProfile instanceProfile = response.InstanceProfile;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteMigrationProject()
        {
            #region delete-migration-project-1689717217454

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteMigrationProject(new DeleteMigrationProjectRequest 
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345"
            });

            MigrationProject migrationProject = response.MigrationProject;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteReplicationInstance()
        {
            #region delete-replication-instance-1481752552839

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
            #region delete-replication-subnet-group-1481752728597

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DeleteReplicationSubnetGroup(new DeleteReplicationSubnetGroupRequest 
            {
                ReplicationSubnetGroupIdentifier = "us-west-2ab-vpc-215ds366"
            });


            #endregion
        }

        public void DatabaseMigrationServiceDeleteReplicationTask()
        {
            #region delete-replication-task-1481752903506

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
            #region describe-acount-attributes-1481753085663

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeAccountAttributes(new DescribeAccountAttributesRequest 
            {
            });

            List<AccountQuota> accountQuotas = response.AccountQuotas;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeCertificates()
        {
            #region describe-certificates-1481753186244

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
            #region describe-connections-1481754477953

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
            #region describe-conversion-configuration-1689717690907

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeConversionConfiguration(new DescribeConversionConfigurationRequest 
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345"
            });

            string conversionConfiguration = response.ConversionConfiguration;
            string migrationProjectIdentifier = response.MigrationProjectIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeDataProviders()
        {
            #region describe-data-providers-1689725897156

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeDataProviders(new DescribeDataProvidersRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "data-provider-identifier",
                        Values = new List<string> {
                            "arn:aws:dms:us-east-1:012345678901:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345"
                        }
                    }
                },
                Marker = "EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345",
                MaxRecords = 20
            });

            List<DataProvider> dataProviders = response.DataProviders;
            string marker = response.Marker;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeEndpoints()
        {
            #region describe-endpoints-1481754926060

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
            #region describe-endpoint-types-1481754742591

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
            #region describe-extension-pack-associations-1689718322580

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeExtensionPackAssociations(new DescribeExtensionPackAssociationsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "instance-profile-identifier",
                        Values = new List<string> {
                            "arn:aws:dms:us-east-1:012345678901:instance-profile:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345"
                        }
                    }
                },
                Marker = "0123456789abcdefghijklmnopqrs",
                MaxRecords = 20,
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012"
            });

            string marker = response.Marker;
            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeInstanceProfiles()
        {
            #region describe-instance-profiles-1689718406840

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeInstanceProfiles(new DescribeInstanceProfilesRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "instance-profile-identifier",
                        Values = new List<string> {
                            "arn:aws:dms:us-east-1:012345678901:instance-profile:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345"
                        }
                    }
                },
                Marker = "0123456789abcdefghijklmnopqrs",
                MaxRecords = 20
            });

            List<InstanceProfile> instanceProfiles = response.InstanceProfiles;
            string marker = response.Marker;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelAssessments()
        {
            #region describe-metadata-model-assessments-1689718702303

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelAssessments(new DescribeMetadataModelAssessmentsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "my-migration-project",
                        Values = new List<string> {
                            "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012"
                        }
                    }
                },
                Marker = "0123456789abcdefghijklmnopqrs",
                MaxRecords = 20,
                MigrationProjectIdentifier = ""
            });

            string marker = response.Marker;
            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelConversions()
        {
            #region describe-metadata-model-conversions-1689719021495

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelConversions(new DescribeMetadataModelConversionsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "request-id",
                        Values = new List<string> {
                            "01234567-89ab-cdef-0123-456789abcdef"
                        }
                    }
                },
                Marker = "EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ123456",
                MaxRecords = 123,
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345"
            });

            string marker = response.Marker;
            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelExportsAsScript()
        {
            #region describe-metadata-model-exports-as-script-1689719253938

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelExportsAsScript(new DescribeMetadataModelExportsAsScriptRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "request-id",
                        Values = new List<string> {
                            "01234567-89ab-cdef-0123-456789abcdef"
                        }
                    }
                },
                Marker = "0123456789abcdefghijklmnopqrs",
                MaxRecords = 20,
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012"
            });

            string marker = response.Marker;
            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelExportsToTarget()
        {
            #region describe-metadata-model-exports-to-target-1689719484750

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelExportsToTarget(new DescribeMetadataModelExportsToTargetRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "request-id",
                        Values = new List<string> {
                            "01234567-89ab-cdef-0123-456789abcdef"
                        }
                    }
                },
                Marker = "0123456789abcdefghijklmnopqrs",
                MaxRecords = 20,
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012"
            });

            string marker = response.Marker;
            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMetadataModelImports()
        {
            #region describe-metadata-model-imports-1689719771322

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMetadataModelImports(new DescribeMetadataModelImportsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "request-id",
                        Values = new List<string> {
                            "01234567-89ab-cdef-0123-456789abcdef"
                        }
                    }
                },
                Marker = "0123456789abcdefghijklmnopqrs",
                MaxRecords = 20,
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012"
            });

            string marker = response.Marker;
            List<SchemaConversionRequest> requests = response.Requests;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeMigrationProjects()
        {
            #region describe-migration-projects-1689719912075

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.DescribeMigrationProjects(new DescribeMigrationProjectsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "migration-project-identifier",
                        Values = new List<string> {
                            "arn:aws:dms:us-east-1:012345678901:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ12345678901"
                        }
                    }
                },
                Marker = "EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ123456",
                MaxRecords = 20
            });

            string marker = response.Marker;
            List<MigrationProject> migrationProjects = response.MigrationProjects;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeOrderableReplicationInstances()
        {
            #region describe-orderable-replication-instances-1481755123669

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
            #region describe-refresh-schema-status-1481755303497

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
            #region describe-replication-instances-1481755443952

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
            #region describe-replication-subnet-groups-1481755621284

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
            #region describe-replication-tasks-1481755777563

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
            #region describe-schemas-1481755933924

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
            #region describe-table-statistics-1481756071890

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
            #region export-metadata-model-assessment-1689720309558

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ExportMetadataModelAssessment(new ExportMetadataModelAssessmentRequest 
            {
                AssessmentReportTypes = new List<string> {
                    "pdf"
                },
                FileName = "file",
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012",
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\",\"rule-id\": \"1\",\"rule-name\": \"1\",\"object-locator\": {\"server-name\": \"aurora-pg.cluster-a1b2c3d4e5f6.us-east-1.rds.amazonaws.com\", \"schema-name\": \"schema1\", \"table-name\": \"Cities\"},\"rule-action\": \"explicit\"} ]}"
            });

            ExportMetadataModelAssessmentResultEntry csvReport = response.CsvReport;
            ExportMetadataModelAssessmentResultEntry pdfReport = response.PdfReport;

            #endregion
        }

        public void DatabaseMigrationServiceImportCertificate()
        {
            #region import-certificate-1481756197206

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
            #region list-tags-for-resource-1481761095501

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
            #region modify-conversion-configuration-1689720529855

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ModifyConversionConfiguration(new ModifyConversionConfigurationRequest 
            {
                ConversionConfiguration = "{\"Common project settings\":{\"ShowSeverityLevelInSql\":\"CRITICAL\"},\"ORACLE_TO_POSTGRESQL\" : {\"ToTimeZone\":false,\"LastDayBuiltinFunctionOracle\":false,   \"NextDayBuiltinFunctionOracle\":false,\"ConvertProceduresToFunction\":false,\"NvlBuiltinFunctionOracle\":false,\"DbmsAssertBuiltinFunctionOracle\":false}}",
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012"
            });

            string migrationProjectIdentifier = response.MigrationProjectIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceModifyDataProvider()
        {
            #region modify-data-provider-1689720700567

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ModifyDataProvider(new ModifyDataProviderRequest 
            {
                DataProviderIdentifier = "arn:aws:dms:us-east-1:012345678901:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345",
                DataProviderName = "new-name",
                Description = "description",
                Engine = "sqlserver",
                Settings = new DataProviderSettings { MicrosoftSqlServerSettings = new MicrosoftSqlServerDataProviderSettings {
                    DatabaseName = "DatabaseName",
                    Port = 11112,
                    ServerName = "ServerName2",
                    SslMode = "none"
                } }
            });

            DataProvider dataProvider = response.DataProvider;

            #endregion
        }

        public void DatabaseMigrationServiceModifyEndpoint()
        {
            #region modify-endpoint-1481761649937

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
            #region modify-instance-profile-1689724223329

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ModifyInstanceProfile(new ModifyInstanceProfileRequest 
            {
                AvailabilityZone = "",
                Description = "",
                InstanceProfileIdentifier = "",
                InstanceProfileName = "",
                KmsKeyArn = "",
                NetworkType = "",
                PubliclyAccessible = true,
                SubnetGroupIdentifier = "",
                VpcSecurityGroups = new List<string> {
                    
                }
            });

            InstanceProfile instanceProfile = response.InstanceProfile;

            #endregion
        }

        public void DatabaseMigrationServiceModifyMigrationProject()
        {
            #region modify-migration-project-1689721117475

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.ModifyMigrationProject(new ModifyMigrationProjectRequest 
            {
                Description = "description",
                InstanceProfileIdentifier = "my-instance-profile",
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345",
                MigrationProjectName = "new-name",
                SchemaConversionApplicationAttributes = new SCApplicationAttributes {
                    S3BucketPath = "arn:aws:s3:::myuser-bucket",
                    S3BucketRoleArn = "arn:aws:iam::012345678901:role/Admin"
                },
                SourceDataProviderDescriptors = new List<DataProviderDescriptorDefinition> {
                    new DataProviderDescriptorDefinition {
                        DataProviderIdentifier = "arn:aws:dms:us-east-1:012345678901:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345",
                        SecretsManagerAccessRoleArn = "arn:aws:iam::012345678901:role/myuser-admin-access",
                        SecretsManagerSecretId = "arn:aws:secretsmanager:us-east-1:012345678901:secret:myorg/myuser/ALL.SOURCE.ORACLE_12-A1B2C3"
                    }
                },
                TargetDataProviderDescriptors = new List<DataProviderDescriptorDefinition> {
                    new DataProviderDescriptorDefinition {
                        DataProviderIdentifier = "arn:aws:dms:us-east-1:012345678901:data-provider:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345",
                        SecretsManagerAccessRoleArn = "arn:aws:iam::012345678901:role/myuser-admin-access",
                        SecretsManagerSecretId = "arn:aws:secretsmanager:us-east-1:012345678901:secret:myorg/myuser/TARGET.postgresql-A1B2C3"
                    }
                }
            });

            MigrationProject migrationProject = response.MigrationProject;

            #endregion
        }

        public void DatabaseMigrationServiceModifyReplicationInstance()
        {
            #region modify-replication-instance-1481761784746

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
            #region modify-replication-subnet-group-1481762275392

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
            #region refresh-schema-1481762399111

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
            #region remove-tags-from-resource-1481762571330

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
            #region start-extension-pack-association-1689721897266

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartExtensionPackAssociation(new StartExtensionPackAssociationRequest 
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartMetadataModelAssessment()
        {
            #region start-metadata-model-assessment-1689722322596

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartMetadataModelAssessment(new StartMetadataModelAssessmentRequest 
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012",
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\",\"rule-id\": \"1\",\"rule-name\": \"1\",\"object-locator\": {\"server-name\": \"aurora-pg.cluster-0a1b2c3d4e5f.us-east-1.rds.amazonaws.com\", \"schema-name\": \"schema1\", \"table-name\": \"Cities\"},\"rule-action\": \"explicit\"} ]}"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartMetadataModelConversion()
        {
            #region start-metadata-model-conversion-1689722427798

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartMetadataModelConversion(new StartMetadataModelConversionRequest 
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012",
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\",\"rule-id\": \"1\",\"rule-name\": \"1\",\"object-locator\": {\"server-name\": \"aurora-pg.cluster-0a1b2c3d4e5f.us-east-1.rds.amazonaws.com\", \"schema-name\": \"schema1\", \"table-name\": \"Cities\"},\"rule-action\": \"explicit\"} ]}"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartMetadataModelExportAsScript()
        {
            #region start-metadata-model-export-as-script-1689722681469

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartMetadataModelExportAsScript(new StartMetadataModelExportAsScriptRequest 
            {
                FileName = "FILE",
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012",
                Origin = "SOURCE",
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\",\"rule-id\": \"1\",\"rule-name\": \"1\",\"object-locator\": {\"server-name\": \"aurora-pg.cluster-0a1b2c3d4e5f.us-east-1.rds.amazonaws.com\", \"schema-name\": \"schema1\", \"table-name\": \"Cities\"},\"rule-action\": \"explicit\"} ]}"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartMetadataModelExportToTarget()
        {
            #region start-metadata-model-export-to-target-1689783666835

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartMetadataModelExportToTarget(new StartMetadataModelExportToTargetRequest 
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:EXAMPLEABCDEFGHIJKLMNOPQRSTUVWXYZ012345",
                OverwriteExtensionPack = true,
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\",\"rule-id\": \"1\",\"rule-name\": \"1\",\"object-locator\": {\"server-name\": \"aurora-pg.cluster-a1b2c3d4e5f6.us-east-1.rds.amazonaws.com\", \"schema-name\": \"schema1\", \"table-name\": \"Cities\"},\"rule-action\": \"explicit\"} ]}"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartMetadataModelImport()
        {
            #region start-metadata-model-import-1689723124259

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartMetadataModelImport(new StartMetadataModelImportRequest 
            {
                MigrationProjectIdentifier = "arn:aws:dms:us-east-1:012345678901:migration-project:0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ012",
                Origin = "SOURCE",
                Refresh = false,
                SelectionRules = "{\"rules\": [{\"rule-type\": \"selection\",\"rule-id\": \"1\",\"rule-name\": \"1\",\"object-locator\": {\"server-name\": \"aurora-pg.cluster-0a1b2c3d4e5f.us-east-1.rds.amazonaws.com\", \"schema-name\": \"schema1\", \"table-name\": \"Cities\"},\"rule-action\": \"explicit\"} ]}"
            });

            string requestIdentifier = response.RequestIdentifier;

            #endregion
        }

        public void DatabaseMigrationServiceStartReplicationTask()
        {
            #region start-replication-task-1481762706778

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.StartReplicationTask(new StartReplicationTaskRequest 
            {
                CdcStartTime = new DateTime(2016, 12, 14, 1, 33, 20, DateTimeKind.Utc),
                ReplicationTaskArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ",
                StartReplicationTaskType = "start-replication"
            });

            ReplicationTask replicationTask = response.ReplicationTask;

            #endregion
        }

        public void DatabaseMigrationServiceStopReplicationTask()
        {
            #region stop-replication-task-1481762924947

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
            #region test-conection-1481763017636

            var client = new AmazonDatabaseMigrationServiceClient();
            var response = client.TestConnection(new TestConnectionRequest 
            {
                EndpointArn = "arn:aws:dms:us-east-1:123456789012:endpoint:RAAR3R22XSH46S3PWLC3NJAWKM",
                ReplicationInstanceArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ"
            });

            Connection connection = response.Connection;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}