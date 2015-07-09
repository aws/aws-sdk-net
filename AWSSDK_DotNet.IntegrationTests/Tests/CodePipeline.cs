using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.CodePipeline;
using Amazon.CodePipeline.Model;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CodePipeline : TestBase<AmazonCodePipelineClient>
    {
        [TestMethod]
        public void TestListActionTypes()
        {
            Client.ListActionTypes();
        }

        [TestMethod]
        public void TestCreatePipeline()
        {
            var iam = new AmazonIdentityManagementServiceClient();

            Client.CreatePipeline(
                new PipelineDeclaration
                { 
                    Name = "net-test-pipeline",
                    RoleArn = "arn:aws:iam::599169622985:role/cprole",
                    ArtifactStore = new ArtifactStore
                    {
                        Location = "jimfluploads-pipeline",
                        Type = ArtifactStoreType.S3
                    },
                    Stages =
                    {
                        new StageDeclaration 
                        {
                            Name = "Source",
                            Actions = 
                            {
                                new ActionDeclaration
                                {
                                    Name = "SourceAction",
                                    ActionTypeId = new ActionTypeId 
                                    { 
                                        Category = ActionCategory.Source, 
                                        Owner = ActionOwner.AWS, 
                                        Provider = "S3", 
                                        Version = "1"
                                    },
                                    Configuration = { {"S3Bucket","jimflupload"}, {"S3ObjectKey","one/two"}},
                                    OutputArtifacts = {
                                        new OutputArtifact { Name = "MyOutput" }
                                    },
                                    RunOrder = 1
                                }
                            }
                        },
                        new StageDeclaration 
                        {
                            Name = "Deploy",
                            Actions = 
                            {
                                new ActionDeclaration
                                {
                                    Name = "DeployAction",
                                    ActionTypeId = new ActionTypeId 
                                    { 
                                        Category = ActionCategory.Deploy, 
                                        Owner = ActionOwner.AWS, 
                                        Provider = "CodeDeploy", 
                                        Version = "1"
                                    },
                                    Configuration = {{"ApplicationName", "FooApp"}, {"DeploymentGroupName", "FooGroup"}},
                                    InputArtifacts = 
                                    {
                                        new InputArtifact { Name = "MyOutput" }
                                    },
                                    RunOrder = 2
                                }
                            }
                        },
                    }
                    
                }
            );
        }

    }
}
