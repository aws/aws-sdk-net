using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.CodePipeline;
using Amazon.CodePipeline.Model;

namespace AWSSDKDocSamples.Amazon.CodePipeline.Generated
{
    class CodePipelineSamples : ISample
    {
        static IAmazonCodePipeline client = new AmazonCodePipelineClient();
        public void CodePipelineAcknowledgeJob()
        {
            #region acknowledge-a-job-for-a-custom-action-1449100979484

            var response = client.AcknowledgeJob(new AcknowledgeJobRequest 
            {
                JobId = "11111111-abcd-1111-abcd-111111abcdef", // Use the PollforJobs API to determine the ID of the job.
                Nonce = "3" // Use the PollforJobs API to determine the nonce for the job.
            });

            string status = response.Status; // Valid values include Created, Queued, Dispatched, InProgress, TimedOut, Suceeded, and Failed. Completed jobs are removed from the system after a short period of time.

            #endregion
        }

        public void CodePipelineCreateCustomActionType()
        {
            #region create-a-custom-action-1449103500903

            var response = client.CreateCustomActionType(new CreateCustomActionTypeRequest 
            {
                Version = "1", // A new custom action always has a version of 1. This is required.
                Category = "Build",
                ConfigurationProperties = new List<ActionConfigurationProperty> {
                    new ActionConfigurationProperty {
                        Name = "MyJenkinsExampleBuildProject",
                        Type = "String",
                        Required = true,
                        Key = true,
                        Description = "The name of the build project must be provided when this action is added to the pipeline.",
                        Queryable = false,
                        Secret = false
                    }
                }, // The text in description will be displayed to your users, and can contain a maximum of 2048 characters. The value for name in configurationProperties is the name of the project, if any.  In this example, this is the name of the build project on the Jenkins server
                InputArtifactDetails = new ArtifactDetails {
                    MaximumCount = 1,
                    MinimumCount = 0
                }, // This is the minimum and maximum number of artifacts allowed as inputs for the action. For more information about input and output artifacts, see Pipeline Structure Reference in the AWS CodePipeline User Guide.
                OutputArtifactDetails = new ArtifactDetails {
                    MaximumCount = 1,
                    MinimumCount = 0
                }, // This is the minimum and maximum number of artifacts allowed as outputs for the action. For more information about input and output artifacts, see Pipeline Structure Reference in the AWS CodePipeline User Guide.
                Provider = "MyBuild-ProviderName", // In this example, this is the name given to the provider field when configuring the AWS CodePipeline Plugin for Jenkins. For more information, see the Four-Stage Pipeline Tutorial in the AWS CodePipeline User Guide.
                Settings = new ActionTypeSettings {
                    EntityUrlTemplate = "https://192.0.2.4/job/{Config:ProjectName}/",
                    ExecutionUrlTemplate = "https://192.0.2.4/job/{Config:ProjectName}/lastSuccessfulBuild/{ExternalExecutionId}/",
                    RevisionUrlTemplate = "none"
                } // entityUrlTemplate is the static link that provides information about the service provider for the action. In the example, the build system includes a static link to the Jenkins build project at the specific server address.  Similarly, executionUrlTemplate is the dynamic link that will be updated with information about the current or most recent run of the action.
            });

            ActionType actionType = response.ActionType;

            #endregion
        }

        public void CodePipelineCreatePipeline()
        {
            #region create-a-pipeline-1449162214392

            var response = client.CreatePipeline(new CreatePipelineRequest 
            {
                Pipeline = new PipelineDeclaration {
                    Version = 1,
                    Name = "MySecondPipeline",
                    ArtifactStore = new ArtifactStore {
                        Type = "S3",
                        Location = "codepipeline-us-east-1-11EXAMPLE11"
                    },
                    RoleArn = "arn:aws:iam::111111111111:role/AWS-CodePipeline-Service",
                    Stages = new List<StageDeclaration> {
                        new StageDeclaration {
                            Name = "Source",
                            Actions = new List<ActionDeclaration> {
                                new ActionDeclaration {
                                    Name = "Source",
                                    ActionTypeId = new ActionTypeId {
                                        Version = "1",
                                        Category = "Source",
                                        Owner = "AWS",
                                        Provider = "S3"
                                    },
                                    Configuration = new Dictionary<string, string> {
                                        { "S3Bucket", "awscodepipeline-demo-bucket" },
                                        { "S3ObjectKey", "aws-codepipeline-s3-aws-codedeploy_linux.zip" }
                                    },
                                    InputArtifacts = new List<InputArtifact> {
                                        
                                    },
                                    OutputArtifacts = new List<OutputArtifact> {
                                        new OutputArtifact { Name = "MyApp" }
                                    },
                                    RunOrder = 1
                                }
                            }
                        },
                        new StageDeclaration {
                            Name = "Beta",
                            Actions = new List<ActionDeclaration> {
                                new ActionDeclaration {
                                    Name = "CodePipelineDemoFleet",
                                    ActionTypeId = new ActionTypeId {
                                        Version = "1",
                                        Category = "Deploy",
                                        Owner = "AWS",
                                        Provider = "CodeDeploy"
                                    },
                                    Configuration = new Dictionary<string, string> {
                                        { "ApplicationName", "CodePipelineDemoApplication" },
                                        { "DeploymentGroupName", "CodePipelineDemoFleet" }
                                    },
                                    InputArtifacts = new List<InputArtifact> {
                                        new InputArtifact { Name = "MyApp" }
                                    },
                                    OutputArtifacts = new List<OutputArtifact> {
                                        
                                    },
                                    RunOrder = 1
                                }
                            }
                        }
                    }
                }
            });

            PipelineDeclaration pipeline = response.Pipeline;

            #endregion
        }

        public void CodePipelineDeleteCustomActionType()
        {
            #region delete-a-custom-action-1449163239567

            var response = client.DeleteCustomActionType(new DeleteCustomActionTypeRequest 
            {
                Version = "1", // This is the current version number of the custom action.
                Category = "Build", // This is the type of action that the custom action is, for example build or test.
                Provider = "MyJenkinsProviderName" // This is the provider of the service used in the custom action. In this example, the custom action is for a Jenkins build, and the name of the provider is the one configured in the AWS CodePipeline Plugin for Jenkins
            });


            #endregion
        }

        public void CodePipelineDeletePipeline()
        {
            #region delete-a-pipeline-1449163893541

            var response = client.DeletePipeline(new DeletePipelineRequest 
            {
                Name = "MySecondPipeline" // The name of the pipeline to delete.
            });


            #endregion
        }

        public void CodePipelineDisableStageTransition()
        {
            #region disable-transitions-into-or-out-of-a-stage-1449164517291

            var response = client.DisableStageTransition(new DisableStageTransitionRequest 
            {
                PipelineName = "MyFirstPipeline",
                Reason = "An example reason",
                StageName = "Beta",
                TransitionType = "Inbound" // Valid values are Inbound, which prevents artifacts from transitioning into the stage and being processed by the actions in that stage, or Outbound, which prevents artifacts from transitioning out of the stage after they have been processed by the actions in that stage.
            });


            #endregion
        }

        public void CodePipelineEnableStageTransition()
        {
            #region enable-transitions-into-or-out-of-a-stage-1449164924423

            var response = client.EnableStageTransition(new EnableStageTransitionRequest 
            {
                PipelineName = "MyFirstPipeline",
                StageName = "Beta",
                TransitionType = "Inbound" // Valid values are Inbound, which allows artifacts to transition into the stage and be processed by the actions in that stage, or Outbound, which allows artifacts to transition out of the stage after they have been processed by the actions in that stage.
            });


            #endregion
        }

        public void CodePipelineGetJobDetails()
        {
            #region get-the-details-of-a-job-1449183680273

            var response = client.GetJobDetails(new GetJobDetailsRequest 
            {
                JobId = "11111111-abcd-1111-abcd-111111abcdef"
            });

            JobDetails jobDetails = response.JobDetails;

            #endregion
        }

        public void CodePipelineGetPipeline()
        {
            #region view-the-structure-of-a-pipeline-1449184156329

            var response = client.GetPipeline(new GetPipelineRequest 
            {
                Version = 123, // This is an optional parameter. If you do not specify a version, the most current version of the pipeline structure is returned.
                Name = "MyFirstPipeline"
            });

            PipelineDeclaration pipeline = response.Pipeline;

            #endregion
        }

        public void CodePipelineGetPipelineState()
        {
            #region view-information-about-the-state-of-a-pipeline-1449184486550

            var response = client.GetPipelineState(new GetPipelineStateRequest 
            {
                Name = "MyFirstPipeline"
            });

            DateTime created = response.Created; // The value for created and all other time- and date-related information such as lastStatusChange, is returned in timestamp format.
            string pipelineName = response.PipelineName;
            integer pipelineVersion = response.PipelineVersion;
            List<StageState> stageStates = response.StageStates;
            DateTime updated = response.Updated;

            #endregion
        }

        public void CodePipelineListActionTypes()
        {
            #region view-a-summary-of-all-action-types-associated-with-your-account-1455218918202

            var response = client.ListActionTypes(new ListActionTypesRequest 
            {
                ActionOwnerFilter = "Custom",
                NextToken = ""
            });

            List<ActionType> actionTypes = response.ActionTypes;
            string nextToken = response.NextToken; // nextToken is optional. Its operation is reserved for future use.

            #endregion
        }

        public void CodePipelineListPipelines()
        {
            #region view-a-summary-of-all-pipelines-associated-with-your-account-1449185747807

            var response = client.ListPipelines(new ListPipelinesRequest 
            {
            });

            string nextToken = response.NextToken;
            List<PipelineSummary> pipelines = response.Pipelines; // Date and time information returned in the pipeline blocks, such as the values for created or updated, are in timestamp format.

            #endregion
        }

        public void CodePipelinePollForJobs()
        {
            #region view-any-available-jobs-1449186054484

            var response = client.PollForJobs(new PollForJobsRequest 
            {
                ActionTypeId = new ActionTypeId {
                    Version = "1",
                    Category = "Test",
                    Owner = "Custom",
                    Provider = "MyJenkinsProviderName"
                },
                MaxBatchSize = 5,
                QueryParam = new Dictionary<string, string> {
                    { "ProjectName", "MyJenkinsTestProj" }
                }
            });

            List<Job> jobs = response.Jobs;

            #endregion
        }

        public void CodePipelineStartPipelineExecution()
        {
            #region run-the-latest-revision-through-a-pipeline-1449186732433

            var response = client.StartPipelineExecution(new StartPipelineExecutionRequest 
            {
                Name = "MyFirstPipeline"
            });

            string pipelineExecutionId = response.PipelineExecutionId;

            #endregion
        }

        public void CodePipelineUpdatePipeline()
        {
            #region update-the-structure-of-a-pipeline-1449186881322

            var response = client.UpdatePipeline(new UpdatePipelineRequest 
            {
                Pipeline = new PipelineDeclaration {
                    Version = 2,
                    Name = "MyFirstPipeline",
                    ArtifactStore = new ArtifactStore {
                        Type = "S3",
                        Location = "codepipeline-us-east-1-11EXAMPLE11"
                    },
                    RoleArn = "arn:aws:iam::111111111111:role/AWS-CodePipeline-Service",
                    Stages = new List<StageDeclaration> {
                        new StageDeclaration {
                            Name = "Source",
                            Actions = new List<ActionDeclaration> {
                                new ActionDeclaration {
                                    Name = "Source",
                                    ActionTypeId = new ActionTypeId {
                                        Version = "1",
                                        Category = "Source",
                                        Owner = "AWS",
                                        Provider = "S3"
                                    },
                                    Configuration = new Dictionary<string, string> {
                                        { "S3Bucket", "awscodepipeline-demo-bucket2" },
                                        { "S3ObjectKey", "aws-codepipeline-s3-aws-codedeploy_linux.zip" }
                                    },
                                    InputArtifacts = new List<InputArtifact> {
                                        
                                    },
                                    OutputArtifacts = new List<OutputArtifact> {
                                        new OutputArtifact { Name = "MyApp" }
                                    },
                                    RunOrder = 1
                                }
                            }
                        },
                        new StageDeclaration {
                            Name = "Beta",
                            Actions = new List<ActionDeclaration> {
                                new ActionDeclaration {
                                    Name = "CodePipelineDemoFleet",
                                    ActionTypeId = new ActionTypeId {
                                        Version = "1",
                                        Category = "Deploy",
                                        Owner = "AWS",
                                        Provider = "CodeDeploy"
                                    },
                                    Configuration = new Dictionary<string, string> {
                                        { "ApplicationName", "CodePipelineDemoApplication" },
                                        { "DeploymentGroupName", "CodePipelineDemoFleet" }
                                    },
                                    InputArtifacts = new List<InputArtifact> {
                                        new InputArtifact { Name = "MyApp" }
                                    },
                                    OutputArtifacts = new List<OutputArtifact> {
                                        
                                    },
                                    RunOrder = 1
                                }
                            }
                        }
                    }
                }
            });

            PipelineDeclaration pipeline = response.Pipeline;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}