using System;
using System.Collections.Generic;
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
            #region associatefaces-1686181269281

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
            string userStatus = response.UserStatus;

            #endregion
        }

        public void RekognitionCompareFaces()
        {
            #region to-compare-two-images-1482181985581

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
            #region copyprojectversion-1658203943815

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
            #region to-create-a-collection-1481833313674

            var client = new AmazonRekognitionClient();
            var response = client.CreateCollection(new CreateCollectionRequest 
            {
                CollectionId = "myphotos"
            });

            string collectionArn = response.CollectionArn;
            int statusCode = response.StatusCode;

            #endregion
        }

        public void RekognitionCreateUser()
        {
            #region createuser-1686181562299

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
            #region to-delete-a-collection-1481838179973

            var client = new AmazonRekognitionClient();
            var response = client.DeleteCollection(new DeleteCollectionRequest 
            {
                CollectionId = "myphotos"
            });

            int statusCode = response.StatusCode;

            #endregion
        }

        public void RekognitionDeleteFaces()
        {
            #region to-delete-a-face-1482182799377

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

        public void RekognitionDeleteProjectPolicy()
        {
            #region deleteprojectpolicy-1658204413810

            var client = new AmazonRekognitionClient();
            var response = client.DeleteProjectPolicy(new DeleteProjectPolicyRequest 
            {
                PolicyName = "testPolicy1",
                PolicyRevisionId = "3b274c25e9203a56a99e00e3ff205fbc",
                ProjectArn = "arn:aws:rekognition:us-east-1:111122223333:project/SourceProject/1656557123456"
            });


            #endregion
        }

        public void RekognitionDeleteUser()
        {
            #region deleteuser-1686181913475

            var client = new AmazonRekognitionClient();
            var response = client.DeleteUser(new DeleteUserRequest 
            {
                ClientRequestToken = "550e8400-e29b-41d4-a716-446655440001",
                CollectionId = "MyCollection",
                UserId = "DemoUser"
            });


            #endregion
        }

        public void RekognitionDetectFaces()
        {
            #region to-detect-faces-in-an-image-1481841782793

            var client = new AmazonRekognitionClient();
            var response = client.DetectFaces(new DetectFacesRequest 
            {
                Image = new Image { S3Object = new S3Object {
                    Bucket = "mybucket",
                    Name = "myphoto"
                } }
            });

            List<FaceDetail> faceDetails = response.FaceDetails;
            string orientationCorrection = response.OrientationCorrection;

            #endregion
        }

        public void RekognitionDetectLabels()
        {
            #region to-detect-labels-1481834255770

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
            #region disassociatefaces-1686182627295

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
            string userStatus = response.UserStatus;

            #endregion
        }

        public void RekognitionIndexFaces()
        {
            #region to-add-a-face-to-a-collection-1482179542923

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
            string orientationCorrection = response.OrientationCorrection;

            #endregion
        }

        public void RekognitionListCollections()
        {
            #region to-list-the-collections-1482179199088

            var client = new AmazonRekognitionClient();
            var response = client.ListCollections(new ListCollectionsRequest 
            {
            });

            List<string> collectionIds = response.CollectionIds;

            #endregion
        }

        public void RekognitionListFaces()
        {
            #region to-list-the-faces-in-a-collection-1482181416530

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

        public void RekognitionListProjectPolicies()
        {
            #region listprojectpolicies-1658202290173

            var client = new AmazonRekognitionClient();
            var response = client.ListProjectPolicies(new ListProjectPoliciesRequest 
            {
                MaxResults = 5,
                NextToken = "",
                ProjectArn = "arn:aws:rekognition:us-east-1:111122223333:project/my-sdk-project/1656557051929"
            });

            string nextToken = response.NextToken;
            List<ProjectPolicy> projectPolicies = response.ProjectPolicies;

            #endregion
        }

        public void RekognitionListUsers()
        {
            #region listusers-1686182360075

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
            #region putprojectpolicy-1658201727623

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
            #region to-delete-a-face-1482182799377

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
            #region to-search-for-faces-matching-a-supplied-image-1482175994491

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
            float searchedFaceConfidence = response.SearchedFaceConfidence;

            #endregion
        }

        public void RekognitionSearchUsers()
        {
            #region searchusers-1686182912030

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
            #region searchusersbyimage-1686183178610

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

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}