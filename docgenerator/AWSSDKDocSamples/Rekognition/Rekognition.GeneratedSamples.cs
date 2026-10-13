using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Rekognition;
using Amazon.Rekognition.Model;

namespace AWSSDKDocSamples.Amazon.Rekognition.Generated
{
    class RekognitionSamples : ISample
    {
        public void RekognitionAssociateFaces()
        {
            #region AssociateFaces-1

            var client = new AmazonRekognitionClient();
            var response = client.AssociateFaces(new AssociateFacesRequest
            {
                ClientRequestToken = "550e8400-e29b-41d4-a716-446655440002",
                CollectionId = "MyCollection",
                FaceIds = new List<string> {
                    "f5817d37-94f6-4335-bfee-6cf79a3d806e",
                    "851cb847-dccc-4fea-9309-9f4805967855",
                    "35ebbb41-7f67-4263-908d-dd0ecba05ab9"
                },
                UserId = "DemoUser",
                UserMatchThreshold = 70
            });

            List<AssociatedFace> associatedFaces = response.AssociatedFaces;
            List<UnsuccessfulFaceAssociation> unsuccessfulFaceAssociations = response.UnsuccessfulFaceAssociations;
            UserStatus userStatus = response.UserStatus;

            #endregion
        }

        public void RekognitionCompareFaces()
        {
            #region CompareFaces-1

            var client = new AmazonRekognitionClient();
            var response = client.CompareFaces(new CompareFacesRequest
            {
                SimilarityThreshold = 90,
                SourceImage = new Image { S3Object = new S3Object {
                    Bucket = "mybucket",
                    Name = "mysourceimage"
                } },
                TargetImage = new Image { S3Object = new S3Object {
                    Bucket = "mybucket",
                    Name = "mytargetimage"
                } }
            });

            List<CompareFacesMatch> faceMatches = response.FaceMatches;
            ComparedSourceImageFace sourceImageFace = response.SourceImageFace;

            #endregion
        }

        public void RekognitionCopyProjectVersion()
        {
            #region CopyProjectVersion-1

            var client = new AmazonRekognitionClient();
            var response = client.CopyProjectVersion(new CopyProjectVersionRequest
            {
                DestinationProjectArn = "arn:aws:rekognition:us-east-1:555555555555:project/DestinationProject/1656705098765",
                KmsKeyId = "arn:1234abcd-12ab-34cd-56ef-1234567890ab",
                OutputConfig = new OutputConfig {
                    S3Bucket = "bucket-name",
                    S3KeyPrefix = "path_to_folder"
                },
                SourceProjectArn = "arn:aws:rekognition:us-east-1:111122223333:project/SourceProject/16565123456",
                SourceProjectVersionArn = "arn:aws:rekognition:us-east-1:111122223333:project/SourceProject/version/model_1/1656611123456",
                Tags = new Dictionary<string, string> {
                    { "key1", "val1" }
                },
                VersionName = "DestinationVersionName_cross_account"
            });

            string projectVersionArn = response.ProjectVersionArn;

            #endregion
        }

        public void RekognitionCreateCollection()
        {
            #region CreateCollection-1

            var client = new AmazonRekognitionClient();
            var response = client.CreateCollection(new CreateCollectionRequest
            {
                CollectionId = "myphotos"
            });

            string collectionArn = response.CollectionArn;
            int? statusCode = response.StatusCode;

            #endregion
        }

        public void RekognitionCreateDataset()
        {
            #region CreateDataset-1

            var client = new AmazonRekognitionClient();
            var response = client.CreateDataset(new CreateDatasetRequest
            {
                DatasetSource = new DatasetSource { GroundTruthManifest = new GroundTruthManifest { S3Object = new S3Object {
                    Bucket = "my-bucket",
                    Name = "datasets/flowers_training/manifests/output/output.manifest"
                } } },
                DatasetType = "TRAIN",
                ProjectArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-project/1690474772815"
            });

            string datasetArn = response.DatasetArn;

            #endregion
        }

        public void RekognitionCreateProject()
        {
            #region CreateProject-1

            var client = new AmazonRekognitionClient();
            var response = client.CreateProject(new CreateProjectRequest
            {
                ProjectName = "my-project"
            });

            string projectArn = response.ProjectArn;

            #endregion
        }

        public void RekognitionCreateProjectVersion()
        {
            #region CreateProjectVersion-1

            var client = new AmazonRekognitionClient();
            var response = client.CreateProjectVersion(new CreateProjectVersionRequest
            {
                OutputConfig = new OutputConfig {
                    S3Bucket = "output_bucket",
                    S3KeyPrefix = "output_folder"
                },
                ProjectArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-project/1690474772815",
                VersionName = "1"
            });

            string projectVersionArn = response.ProjectVersionArn;

            #endregion
        }

        public void RekognitionCreateUser()
        {
            #region CreateUser-1

            var client = new AmazonRekognitionClient();
            var response = client.CreateUser(new CreateUserRequest
            {
                CollectionId = "MyCollection",
                UserId = "DemoUser"
            });


            #endregion
        }

        public void RekognitionDeleteCollection()
        {
            #region DeleteCollection-1

            var client = new AmazonRekognitionClient();
            var response = client.DeleteCollection(new DeleteCollectionRequest
            {
                CollectionId = "myphotos"
            });

            int? statusCode = response.StatusCode;

            #endregion
        }

        public void RekognitionDeleteDataset()
        {
            #region DeleteDataset-1

            var client = new AmazonRekognitionClient();
            var response = client.DeleteDataset(new DeleteDatasetRequest
            {
                DatasetArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-project/dataset/test/1690556733321"
            });


            #endregion
        }

        public void RekognitionDeleteFaces()
        {
            #region DeleteFaces-1

            var client = new AmazonRekognitionClient();
            var response = client.DeleteFaces(new DeleteFacesRequest
            {
                CollectionId = "myphotos",
                FaceIds = new List<string> {
                    "ff43d742-0c13-5d16-a3e8-03d3f58e980b"
                }
            });

            List<string> deletedFaces = response.DeletedFaces;

            #endregion
        }

        public void RekognitionDeleteProject()
        {
            #region DeleteProject-1

            var client = new AmazonRekognitionClient();
            var response = client.DeleteProject(new DeleteProjectRequest
            {
                ProjectArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-project/1690405809285"
            });

            ProjectStatus status = response.Status;

            #endregion
        }

        public void RekognitionDeleteProjectPolicy()
        {
            #region DeleteProjectPolicy-1

            var client = new AmazonRekognitionClient();
            var response = client.DeleteProjectPolicy(new DeleteProjectPolicyRequest
            {
                PolicyName = "testPolicy1",
                PolicyRevisionId = "3b274c25e9203a56a99e00e3ff205fbc",
                ProjectArn = "arn:aws:rekognition:us-east-1:111122223333:project/SourceProject/1656557123456"
            });


            #endregion
        }

        public void RekognitionDeleteProjectVersion()
        {
            #region DeleteProjectVersion-1

            var client = new AmazonRekognitionClient();
            var response = client.DeleteProjectVersion(new DeleteProjectVersionRequest
            {
                ProjectVersionArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-project/version/1/1690556751958"
            });

            ProjectVersionStatus status = response.Status;

            #endregion
        }

        public void RekognitionDeleteUser()
        {
            #region DeleteUser-1

            var client = new AmazonRekognitionClient();
            var response = client.DeleteUser(new DeleteUserRequest
            {
                ClientRequestToken = "550e8400-e29b-41d4-a716-446655440001",
                CollectionId = "MyCollection",
                UserId = "DemoUser"
            });


            #endregion
        }

        public void RekognitionDetectCustomLabels()
        {
            #region DetectCustomLabels-1

            var client = new AmazonRekognitionClient();
            var response = client.DetectCustomLabels(new DetectCustomLabelsRequest
            {
                Image = new Image { S3Object = new S3Object {
                    Bucket = "custom-labels-console-us-east-1-1111111111",
                    Name = "assets/flowers_1_test_dataset/camellia4.jpg"
                } },
                MaxResults = 100,
                MinConfidence = 50,
                ProjectVersionArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-project/version/my-project.2023-07-31T11.49.37/1690829378219"
            });

            List<CustomLabel> customLabels = response.CustomLabels;

            #endregion
        }

        public void RekognitionDetectFaces()
        {
            #region DetectFaces-1

            var client = new AmazonRekognitionClient();
            var response = client.DetectFaces(new DetectFacesRequest
            {
                Image = new Image { S3Object = new S3Object {
                    Bucket = "mybucket",
                    Name = "myphoto"
                } }
            });

            List<FaceDetail> faceDetails = response.FaceDetails;
            OrientationCorrection orientationCorrection = response.OrientationCorrection;

            #endregion
        }

        public void RekognitionDetectLabels()
        {
            #region DetectLabels-1

            var client = new AmazonRekognitionClient();
            var response = client.DetectLabels(new DetectLabelsRequest
            {
                Image = new Image { S3Object = new S3Object {
                    Bucket = "mybucket",
                    Name = "myphoto"
                } },
                MaxLabels = 123,
                MinConfidence = 70
            });

            List<Label> labels = response.Labels;

            #endregion
        }

        public void RekognitionDisassociateFaces()
        {
            #region DisassociateFaces-1

            var client = new AmazonRekognitionClient();
            var response = client.DisassociateFaces(new DisassociateFacesRequest
            {
                ClientRequestToken = "550e8400-e29b-41d4-a716-446655440003",
                CollectionId = "MyCollection",
                FaceIds = new List<string> {
                    "f5817d37-94f6-4335-bfee-6cf79a3d806e",
                    "c92265d4-5f9c-43af-a58e-12be0ce02bc3"
                },
                UserId = "DemoUser"
            });

            List<DisassociatedFace> disassociatedFaces = response.DisassociatedFaces;
            List<UnsuccessfulFaceDisassociation> unsuccessfulFaceDisassociations = response.UnsuccessfulFaceDisassociations;
            UserStatus userStatus = response.UserStatus;

            #endregion
        }

        public void RekognitionDistributeDatasetEntries()
        {
            #region DistributeDatasetEntries-1

            var client = new AmazonRekognitionClient();
            var response = client.DistributeDatasetEntries(new DistributeDatasetEntriesRequest
            {
                Datasets = new List<DistributeDataset> {
                    new DistributeDataset { Arn = "arn:aws:rekognition:us-east-1:111122223333:project/my-proj-2/dataset/train/1690564858106" },
                    new DistributeDataset { Arn = "arn:aws:rekognition:us-east-1:111122223333:project/my-proj-2/dataset/test/1690564858106" }
                }
            });


            #endregion
        }

        public void RekognitionIndexFaces()
        {
            #region IndexFaces-1

            var client = new AmazonRekognitionClient();
            var response = client.IndexFaces(new IndexFacesRequest
            {
                CollectionId = "myphotos",
                DetectionAttributes = new List<string> {
                },
                ExternalImageId = "myphotoid",
                Image = new Image { S3Object = new S3Object {
                    Bucket = "mybucket",
                    Name = "myphoto"
                } }
            });

            List<FaceRecord> faceRecords = response.FaceRecords;
            OrientationCorrection orientationCorrection = response.OrientationCorrection;

            #endregion
        }

        public void RekognitionListCollections()
        {
            #region ListCollections-1

            var client = new AmazonRekognitionClient();
            var response = client.ListCollections(new ListCollectionsRequest
            {
            });

            List<string> collectionIds = response.CollectionIds;

            #endregion
        }

        public void RekognitionListDatasetEntries()
        {
            #region ListDatasetEntries-1

            var client = new AmazonRekognitionClient();
            var response = client.ListDatasetEntries(new ListDatasetEntriesRequest
            {
                ContainsLabels = new List<string> {
                    "camellia"
                },
                DatasetArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-proj-2/dataset/train/1690564858106",
                HasErrors = true,
                Labeled = true,
                MaxResults = 100,
                NextToken = "",
                SourceRefContains = "camellia4.jpg"
            });

            List<string> datasetEntries = response.DatasetEntries;
            string nextToken = response.NextToken;

            #endregion
        }

        public void RekognitionListDatasetLabels()
        {
            #region ListDatasetLabels-1

            var client = new AmazonRekognitionClient();
            var response = client.ListDatasetLabels(new ListDatasetLabelsRequest
            {
                DatasetArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-proj-2/dataset/train/1690564858106",
                MaxResults = 100,
                NextToken = ""
            });

            List<DatasetLabelDescription> datasetLabelDescriptions = response.DatasetLabelDescriptions;

            #endregion
        }

        public void RekognitionListFaces()
        {
            #region ListFaces-1

            var client = new AmazonRekognitionClient();
            var response = client.ListFaces(new ListFacesRequest
            {
                CollectionId = "myphotos",
                MaxResults = 20
            });

            string faceModelVersion = response.FaceModelVersion;
            List<Face> faces = response.Faces;

            #endregion
        }

        public void RekognitionListUsers()
        {
            #region ListUsers-1

            var client = new AmazonRekognitionClient();
            var response = client.ListUsers(new ListUsersRequest
            {
                CollectionId = "MyCollection"
            });

            string nextToken = response.NextToken;
            List<User> users = response.Users;

            #endregion
        }

        public void RekognitionPutProjectPolicy()
        {
            #region PutProjectPolicy-1

            var client = new AmazonRekognitionClient();
            var response = client.PutProjectPolicy(new PutProjectPolicyRequest
            {
                PolicyDocument = "'{\"Version\":\"2012-10-17\",\"Statement\":[{\"Effect\":\"ALLOW\",\"Principal\":{\"AWS\":\"principal\"},\"Action\":\"rekognition:CopyProjectVersion\",\"Resource\":\"arn:aws:rekognition:us-east-1:123456789012:project/my-sdk-project/version/DestinationVersionName/1627045542080\"}]}'",
                PolicyName = "SamplePolicy",
                PolicyRevisionId = "0123456789abcdef",
                ProjectArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-sdk-project/1656557051929"
            });

            string policyRevisionId = response.PolicyRevisionId;

            #endregion
        }

        public void RekognitionSearchFaces()
        {
            #region SearchFaces-1

            var client = new AmazonRekognitionClient();
            var response = client.SearchFaces(new SearchFacesRequest
            {
                CollectionId = "myphotos",
                FaceId = "70008e50-75e4-55d0-8e80-363fb73b3a14",
                FaceMatchThreshold = 90,
                MaxFaces = 10
            });

            List<FaceMatch> faceMatches = response.FaceMatches;
            string searchedFaceId = response.SearchedFaceId;

            #endregion
        }

        public void RekognitionSearchFacesByImage()
        {
            #region SearchFacesByImage-1

            var client = new AmazonRekognitionClient();
            var response = client.SearchFacesByImage(new SearchFacesByImageRequest
            {
                CollectionId = "myphotos",
                FaceMatchThreshold = 95,
                Image = new Image { S3Object = new S3Object {
                    Bucket = "mybucket",
                    Name = "myphoto"
                } },
                MaxFaces = 5
            });

            List<FaceMatch> faceMatches = response.FaceMatches;
            BoundingBox searchedFaceBoundingBox = response.SearchedFaceBoundingBox;
            float? searchedFaceConfidence = response.SearchedFaceConfidence;

            #endregion
        }

        public void RekognitionSearchUsers()
        {
            #region SearchUsers-1

            var client = new AmazonRekognitionClient();
            var response = client.SearchUsers(new SearchUsersRequest
            {
                CollectionId = "MyCollection",
                MaxUsers = 2,
                UserId = "DemoUser",
                UserMatchThreshold = 70
            });

            string faceModelVersion = response.FaceModelVersion;
            SearchedUser searchedUser = response.SearchedUser;
            List<UserMatch> userMatches = response.UserMatches;

            #endregion
        }

        public void RekognitionSearchUsersByImage()
        {
            #region SearchUsersByImage-1

            var client = new AmazonRekognitionClient();
            var response = client.SearchUsersByImage(new SearchUsersByImageRequest
            {
                CollectionId = "MyCollection",
                Image = new Image { S3Object = new S3Object {
                    Bucket = "bucket",
                    Name = "input.jpg"
                } },
                MaxUsers = 2,
                QualityFilter = "MEDIUM",
                UserMatchThreshold = 70
            });

            string faceModelVersion = response.FaceModelVersion;
            SearchedFaceDetails searchedFace = response.SearchedFace;
            List<UnsearchedFace> unsearchedFaces = response.UnsearchedFaces;
            List<UserMatch> userMatches = response.UserMatches;

            #endregion
        }

        public void RekognitionStartMediaAnalysisJob()
        {
            #region StartMediaAnalysisJob-1

            var client = new AmazonRekognitionClient();
            var response = client.StartMediaAnalysisJob(new StartMediaAnalysisJobRequest
            {
                Input = new MediaAnalysisInput { S3Object = new S3Object {
                    Bucket = "input-bucket",
                    Name = "input-manifest.json"
                } },
                JobName = "job-name",
                OperationsConfig = new MediaAnalysisOperationsConfig { DetectModerationLabels = new MediaAnalysisDetectModerationLabelsConfig {
                    MinConfidence = 50,
                    ProjectVersion = "arn:aws:rekognition:us-east-1:111122223333:project/my-project/version/1/1690556751958"
                } },
                OutputConfig = new MediaAnalysisOutputConfig {
                    S3Bucket = "output-bucket",
                    S3KeyPrefix = "output-location"
                }
            });

            string jobId = response.JobId;

            #endregion
        }

        public void RekognitionStartProjectVersion()
        {
            #region StartProjectVersion-1

            var client = new AmazonRekognitionClient();
            var response = client.StartProjectVersion(new StartProjectVersionRequest
            {
                MaxInferenceUnits = 1,
                MinInferenceUnits = 1,
                ProjectVersionArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-project/version/1/1690556751958"
            });

            ProjectVersionStatus status = response.Status;

            #endregion
        }

        public void RekognitionStopProjectVersion()
        {
            #region StopProjectVersion-1

            var client = new AmazonRekognitionClient();
            var response = client.StopProjectVersion(new StopProjectVersionRequest
            {
                ProjectVersionArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-project/version/1/1690556751958"
            });

            ProjectVersionStatus status = response.Status;

            #endregion
        }

        public void RekognitionUpdateDatasetEntries()
        {
            #region UpdateDatasetEntries-1

            var client = new AmazonRekognitionClient();
            var response = client.UpdateDatasetEntries(new UpdateDatasetEntriesRequest
            {
                Changes = new DatasetChanges { GroundTruth = new MemoryStream({"source-ref":"s3://custom-labels-console-us-east-1-111111111/assets/flowers_1_test_dataset/mediterranean_spurge4.jpg","mediterranean_spurge":1,"mediterranean_spurge-metadata":{"confidence":1,"job-name":"labeling-job/mediterranean_spurge","class-name":"mediterranean_spurge","human-annotated":"yes","creation-date":"2021-07-11T03:33:42.025Z","type":"groundtruth/image-classification"},"with_leaves":1,"with_leaves-metadata":{"confidence":1,"job-name":"labeling-job/with_leaves","class-name":"with_leaves","human-annotated":"yes","creation-date":"2021-07-11T03:33:42.025Z","type":"groundtruth/image-classification"}}) },
                DatasetArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-proj-2/dataset/train/1690564858106"
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
