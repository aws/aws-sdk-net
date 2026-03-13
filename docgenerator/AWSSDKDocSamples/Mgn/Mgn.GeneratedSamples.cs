using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Mgn;
using Amazon.Mgn.Model;

namespace AWSSDKDocSamples.Amazon.Mgn.Generated
{
    class MgnSamples : ISample
    {
        public void MgnCreateNetworkMigrationDefinition()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.CreateNetworkMigrationDefinition(new CreateNetworkMigrationDefinitionRequest 
            {
                Name = "network1",
                Description = "network 1 description",
                SourceConfigurations = new List<SourceConfiguration> {
                    new SourceConfiguration {
                        SourceEnvironment = "NSX",
                        SourceS3Configuration = new SourceS3Configuration {
                            S3Bucket = "source_bucket",
                            S3BucketOwner = "012345678901",
                            S3Key = "source_key"
                        }
                    }
                },
                TargetDeployment = "SINGLE_ACCOUNT",
                TargetNetwork = new TargetNetwork {
                    InboundCidr = "192.168.1.0/24",
                    Topology = "ISOLATED_VPC"
                },
                TargetS3Configuration = new TargetS3Configuration {
                    S3Bucket = "target_bucket",
                    S3BucketOwner = "012345678901"
                }
            });

            string name = response.Name;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string networkMigrationDefinitionID = response.NetworkMigrationDefinitionID;
            List<SourceConfiguration> sourceConfigurations = response.SourceConfigurations;
            Dictionary<string, string> tags = response.Tags;
            TargetNetwork targetNetwork = response.TargetNetwork;
            TargetS3Configuration targets3Configuration = response.TargetS3Configuration;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void MgnDeleteNetworkMigrationDefinition()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.DeleteNetworkMigrationDefinition(new DeleteNetworkMigrationDefinitionRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567"
            });


            #endregion
        }

        public void MgnGetNetworkMigrationDefinition()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.GetNetworkMigrationDefinition(new GetNetworkMigrationDefinitionRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567"
            });

            string name = response.Name;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string networkMigrationDefinitionID = response.NetworkMigrationDefinitionID;
            List<SourceConfiguration> sourceConfigurations = response.SourceConfigurations;
            Dictionary<string, string> tags = response.Tags;
            TargetNetwork targetNetwork = response.TargetNetwork;
            TargetS3Configuration targets3Configuration = response.TargetS3Configuration;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void MgnGetNetworkMigrationMapperSegmentConstruct()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.GetNetworkMigrationMapperSegmentConstruct(new GetNetworkMigrationMapperSegmentConstructRequest 
            {
                ConstructID = "abc45678-abcd-abcd-efab-012345678abc",
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab",
                SegmentID = "12345678-abcd-abcd-efab-0123456789ab"
            });

            NetworkMigrationMapperSegmentConstruct construct = response.Construct;

            #endregion
        }

        public void MgnListImportFileEnrichments()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListImportFileEnrichments(new ListImportFileEnrichmentsRequest 
            {
                Filters = new ListImportFileEnrichmentsFilters { JobIDs = new List<string> {
                    "01234567-abcd-abcd-efab-0123456789ab"
                } },
                MaxResults = 10
            });

            List<ImportFileEnrichment> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationAnalyses()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationAnalyses(new ListNetworkMigrationAnalysesRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            List<NetworkMigrationAnalysisJobDetails> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationAnalysisResults()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationAnalysisResults(new ListNetworkMigrationAnalysisResultsRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            List<NetworkMigrationAnalysisResult> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationCodeGenerations()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationCodeGenerations(new ListNetworkMigrationCodeGenerationsRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            List<NetworkMigrationCodeGenerationJobDetails> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationCodeGenerationSegments()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationCodeGenerationSegments(new ListNetworkMigrationCodeGenerationSegmentsRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            List<NetworkMigrationCodeGenerationSegment> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationDefinitions()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationDefinitions(new ListNetworkMigrationDefinitionsRequest 
            {
                Filters = new ListNetworkMigrationDefinitionsRequestFilters { NetworkMigrationDefinitionIDs = new List<string> {
                    "nmd-01234567891234567"
                } }
            });

            List<NetworkMigrationDefinitionSummary> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationDeployedStacks()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationDeployedStacks(new ListNetworkMigrationDeployedStacksRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            List<NetworkMigrationDeployedStackDetails> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationDeployments()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationDeployments(new ListNetworkMigrationDeploymentsRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            List<NetworkMigrationDeployerJobDetails> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationExecutions()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationExecutions(new ListNetworkMigrationExecutionsRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567"
            });

            List<NetworkMigrationExecution> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationMapperSegmentConstructs()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationMapperSegmentConstructs(new ListNetworkMigrationMapperSegmentConstructsRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab",
                SegmentID = "12345678-abcd-abcd-efab-0123456789ab"
            });

            List<NetworkMigrationMapperSegmentConstruct> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationMapperSegmentConstructs()
        {
            #region example-2

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationMapperSegmentConstructs(new ListNetworkMigrationMapperSegmentConstructsRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab",
                SegmentID = "12345678-abcd-abcd-efab-0123456789ab"
            });

            List<NetworkMigrationMapperSegmentConstruct> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationMapperSegments()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationMapperSegments(new ListNetworkMigrationMapperSegmentsRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            List<NetworkMigrationMapperSegment> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationMappings()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationMappings(new ListNetworkMigrationMappingsRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            List<NetworkMigrationMappingJobDetails> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnListNetworkMigrationMappingUpdates()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.ListNetworkMigrationMappingUpdates(new ListNetworkMigrationMappingUpdatesRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            List<NetworkMigrationMappingUpdateJobDetails> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MgnStartImportFileEnrichment()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.StartImportFileEnrichment(new StartImportFileEnrichmentRequest 
            {
                IpAssignmentStrategy = "STATIC",
                S3BucketSource = new EnrichmentSourceS3Configuration {
                    S3Bucket = "my-source-bucket",
                    S3BucketOwner = "123456789012",
                    S3Key = "imports/source-file.csv"
                },
                S3BucketTarget = new EnrichmentTargetS3Configuration {
                    S3Bucket = "my-target-bucket",
                    S3BucketOwner = "123456789012",
                    S3Key = "enriched/output.csv"
                }
            });

            string jobid = response.JobID;

            #endregion
        }

        public void MgnStartNetworkMigrationAnalysis()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.StartNetworkMigrationAnalysis(new StartNetworkMigrationAnalysisRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            string jobid = response.JobID;

            #endregion
        }

        public void MgnStartNetworkMigrationCodeGeneration()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.StartNetworkMigrationCodeGeneration(new StartNetworkMigrationCodeGenerationRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            string jobid = response.JobID;

            #endregion
        }

        public void MgnStartNetworkMigrationDeployment()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.StartNetworkMigrationDeployment(new StartNetworkMigrationDeploymentRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            string jobid = response.JobID;

            #endregion
        }

        public void MgnStartNetworkMigrationMapping()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.StartNetworkMigrationMapping(new StartNetworkMigrationMappingRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab"
            });

            string jobid = response.JobID;

            #endregion
        }

        public void MgnStartNetworkMigrationMappingUpdate()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.StartNetworkMigrationMappingUpdate(new StartNetworkMigrationMappingUpdateRequest 
            {
                Constructs = new List<StartNetworkMigrationMappingUpdateConstruct> {
                    new StartNetworkMigrationMappingUpdateConstruct {
                        ConstructID = "abc45678-abcd-abcd-efab-012345678abc",
                        ConstructType = "AWS::EC2::VPC",
                        Operation = new OperationUnion { Update = new UpdateOperation { Properties = new Dictionary<string, string> {
                            { "CidrBlock", "10.31.0.0/22" }
                        } } },
                        SegmentID = "12345678-abcd-abcd-efab-0123456789ab"
                    }
                },
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab",
                Segments = new List<StartNetworkMigrationMappingUpdateSegment> {
                    new StartNetworkMigrationMappingUpdateSegment {
                        ScopeTags = new Dictionary<string, string> {
                            { "key1", "val1" },
                            { "key2", "val2" }
                        },
                        SegmentID = "12345678-abcd-abcd-efab-0123456789ab",
                        TargetAccount = "234567890123"
                    }
                }
            });

            string jobid = response.JobID;

            #endregion
        }

        public void MgnUpdateNetworkMigrationDefinition()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.UpdateNetworkMigrationDefinition(new UpdateNetworkMigrationDefinitionRequest 
            {
                Name = "network1",
                Description = "network 1 description",
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                SourceConfigurations = new List<SourceConfiguration> {
                    new SourceConfiguration {
                        SourceEnvironment = "NSX",
                        SourceS3Configuration = new SourceS3Configuration {
                            S3Bucket = "source_bucket",
                            S3BucketOwner = "012345678901",
                            S3Key = "source_key"
                        }
                    }
                },
                TargetNetwork = new TargetNetworkUpdate {
                    InboundCidr = "192.168.1.0/24",
                    Topology = "ISOLATED_VPC"
                },
                TargetS3Configuration = new TargetS3ConfigurationUpdate {
                    S3Bucket = "target_bucket",
                    S3BucketOwner = "012345678901"
                }
            });

            string name = response.Name;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string networkMigrationDefinitionID = response.NetworkMigrationDefinitionID;
            List<SourceConfiguration> sourceConfigurations = response.SourceConfigurations;
            Dictionary<string, string> tags = response.Tags;
            TargetNetwork targetNetwork = response.TargetNetwork;
            TargetS3Configuration targets3Configuration = response.TargetS3Configuration;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void MgnUpdateNetworkMigrationMapperSegment()
        {
            #region example-1

            var client = new AmazonMgnClient();
            var response = client.UpdateNetworkMigrationMapperSegment(new UpdateNetworkMigrationMapperSegmentRequest 
            {
                NetworkMigrationDefinitionID = "nmd-01234567891234567",
                NetworkMigrationExecutionID = "01234567-abcd-abcd-abcd-0123456789ab",
                SegmentID = "12345678-abcd-abcd-efab-0123456789ab"
            });

            string name = response.Name;
            Checksum checksum = response.Checksum;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string jobid = response.JobID;
            string logicalid = response.LogicalID;
            string networkMigrationDefinitionID = response.NetworkMigrationDefinitionID;
            string networkMigrationExecutionID = response.NetworkMigrationExecutionID;
            S3Configuration outputs3Configuration = response.OutputS3Configuration;
            string segmentid = response.SegmentID;
            string segmentType = response.SegmentType;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}