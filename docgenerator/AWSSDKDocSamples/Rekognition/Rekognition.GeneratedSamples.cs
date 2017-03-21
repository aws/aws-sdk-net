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
        static IAmazonRekognition client = new AmazonRekognitionClient();
        public void RekognitionCompareFaces()
        {
            #region to-compare-two-images-1482181985581

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

        public void RekognitionCreateCollection()
        {
            #region to-create-a-collection-1481833313674

            var response = client.CreateCollection(new CreateCollectionRequest 
            {
                CollectionId = "myphotos"
            });

            string collectionArn = response.CollectionArn;
            integer statusCode = response.StatusCode;

            #endregion
        }

        public void RekognitionDeleteCollection()
        {
            #region to-delete-a-collection-1481838179973

            var response = client.DeleteCollection(new DeleteCollectionRequest 
            {
                CollectionId = "myphotos"
            });

            integer statusCode = response.StatusCode;

            #endregion
        }

        public void RekognitionDeleteFaces()
        {
            #region to-delete-a-face-1482182799377

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

        public void RekognitionDetectFaces()
        {
            #region to-detect-faces-in-an-image-1481841782793

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

        public void RekognitionIndexFaces()
        {
            #region to-add-a-face-to-a-collection-1482179542923

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

            var response = client.ListCollections(new ListCollectionsRequest 
            {
            });

            List<string> collectionIds = response.CollectionIds;

            #endregion
        }

        public void RekognitionListFaces()
        {
            #region to-list-the-faces-in-a-collection-1482181416530

            var response = client.ListFaces(new ListFacesRequest 
            {
                CollectionId = "myphotos",
                MaxResults = 20
            });

            List<Face> faces = response.Faces;

            #endregion
        }

        public void RekognitionSearchFaces()
        {
            #region to-delete-a-face-1482182799377

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

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}