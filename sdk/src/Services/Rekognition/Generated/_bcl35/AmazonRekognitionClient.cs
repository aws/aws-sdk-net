/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Rekognition.Model;
using Amazon.Rekognition.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Rekognition
{
    /// <summary>
    /// Implementation for accessing Rekognition
    ///
    /// This is the Amazon Rekognition API reference.
    /// </summary>
    public partial class AmazonRekognitionClient : AmazonServiceClient, IAmazonRekognition
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonRekognitionClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRekognitionClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRekognitionConfig()) { }

        /// <summary>
        /// Constructs AmazonRekognitionClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRekognitionConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRekognitionClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(AmazonRekognitionConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRekognitionClient(AWSCredentials credentials)
            : this(credentials, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRekognitionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials and an
        /// AmazonRekognitionClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(AWSCredentials credentials, AmazonRekognitionConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRekognitionConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRekognitionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRekognitionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRekognitionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRekognitionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRekognitionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CompareFaces

        /// <summary>
        /// Compares a face in the <i>source</i> input image with each face detected in the <i>target</i>
        /// input image. 
        /// 
        ///  <note> 
        /// <para>
        ///  If the source image contains multiple faces, the service detects the largest face
        /// and compares it with each face detected in the target image. 
        /// </para>
        ///  </note> 
        /// <para>
        /// In response, the operation returns an array of face matches ordered by similarity
        /// score in descending order. For each face match, the response provides a bounding box
        /// of the face, facial landmarks, pose details (pitch, role, and yaw), quality (brightness
        /// and sharpness), and confidence value (indicating the level of confidence that the
        /// bounding box contains a face). The response also provides a similarity score, which
        /// indicates how closely the faces match. 
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, only faces with a similarity score of greater than or equal to 80% are
        /// returned in the response. You can change this value by specifying the <code>SimilarityThreshold</code>
        /// parameter.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <code>CompareFaces</code> also returns an array of faces that don't match the source
        /// image. For each face, it returns a bounding box, confidence value, landmarks, pose
        /// details, and quality. The response also returns information about the face in the
        /// source image, including the bounding box of the face and confidence value.
        /// </para>
        ///  
        /// <para>
        /// If the image doesn't contain Exif metadata, <code>CompareFaces</code> returns orientation
        /// information for the source and target images. Use these values to display the images
        /// with the correct image orientation.
        /// </para>
        ///  <note> 
        /// <para>
        ///  This is a stateless API operation. That is, data returned by this operation doesn't
        /// persist.
        /// </para>
        ///  </note> 
        /// <para>
        /// For an example, see <a>get-started-exercise-compare-faces</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:CompareFaces</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompareFaces service method.</param>
        /// 
        /// <returns>The response from the CompareFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see <a>limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CompareFaces">REST API Reference for CompareFaces Operation</seealso>
        public CompareFacesResponse CompareFaces(CompareFacesRequest request)
        {
            var marshaller = new CompareFacesRequestMarshaller();
            var unmarshaller = CompareFacesResponseUnmarshaller.Instance;

            return Invoke<CompareFacesRequest,CompareFacesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CompareFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompareFaces operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCompareFaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CompareFaces">REST API Reference for CompareFaces Operation</seealso>
        public IAsyncResult BeginCompareFaces(CompareFacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CompareFacesRequestMarshaller();
            var unmarshaller = CompareFacesResponseUnmarshaller.Instance;

            return BeginInvoke<CompareFacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CompareFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompareFaces.</param>
        /// 
        /// <returns>Returns a  CompareFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CompareFaces">REST API Reference for CompareFaces Operation</seealso>
        public  CompareFacesResponse EndCompareFaces(IAsyncResult asyncResult)
        {
            return EndInvoke<CompareFacesResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCollection

        /// <summary>
        /// Creates a collection in an AWS Region. You can add faces to the collection using the
        /// operation. 
        /// 
        ///  
        /// <para>
        /// For example, you might create collections, one for each of your application users.
        /// A user can then index faces using the <code>IndexFaces</code> operation and persist
        /// results in a specific collection. Then, a user can search the collection for faces
        /// in the user-specific container. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Collection names are case-sensitive.
        /// </para>
        ///  </note> 
        /// <para>
        /// For an example, see <a>example1</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:CreateCollection</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollection service method.</param>
        /// 
        /// <returns>The response from the CreateCollection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceAlreadyExistsException">
        /// A collection with the specified ID already exists.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        public CreateCollectionResponse CreateCollection(CreateCollectionRequest request)
        {
            var marshaller = new CreateCollectionRequestMarshaller();
            var unmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return Invoke<CreateCollectionRequest,CreateCollectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCollection operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        public IAsyncResult BeginCreateCollection(CreateCollectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateCollectionRequestMarshaller();
            var unmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCollectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCollection.</param>
        /// 
        /// <returns>Returns a  CreateCollectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        public  CreateCollectionResponse EndCreateCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCollection

        /// <summary>
        /// Deletes the specified collection. Note that this operation removes all faces in the
        /// collection. For an example, see <a>example1</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DeleteCollection</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollection service method.</param>
        /// 
        /// <returns>The response from the DeleteCollection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// Collection specified in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public DeleteCollectionResponse DeleteCollection(DeleteCollectionRequest request)
        {
            var marshaller = new DeleteCollectionRequestMarshaller();
            var unmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return Invoke<DeleteCollectionRequest,DeleteCollectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollection operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public IAsyncResult BeginDeleteCollection(DeleteCollectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteCollectionRequestMarshaller();
            var unmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteCollectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCollection.</param>
        /// 
        /// <returns>Returns a  DeleteCollectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public  DeleteCollectionResponse EndDeleteCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFaces

        /// <summary>
        /// Deletes faces from a collection. You specify a collection ID and an array of face
        /// IDs to remove from the collection.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DeleteFaces</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaces service method.</param>
        /// 
        /// <returns>The response from the DeleteFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// Collection specified in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteFaces">REST API Reference for DeleteFaces Operation</seealso>
        public DeleteFacesResponse DeleteFaces(DeleteFacesRequest request)
        {
            var marshaller = new DeleteFacesRequestMarshaller();
            var unmarshaller = DeleteFacesResponseUnmarshaller.Instance;

            return Invoke<DeleteFacesRequest,DeleteFacesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaces operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteFaces">REST API Reference for DeleteFaces Operation</seealso>
        public IAsyncResult BeginDeleteFaces(DeleteFacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteFacesRequestMarshaller();
            var unmarshaller = DeleteFacesResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteFacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFaces.</param>
        /// 
        /// <returns>Returns a  DeleteFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteFaces">REST API Reference for DeleteFaces Operation</seealso>
        public  DeleteFacesResponse EndDeleteFaces(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFacesResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectFaces

        /// <summary>
        /// Detects faces within an image (JPEG or PNG) that is provided as input.
        /// 
        ///  
        /// <para>
        ///  For each face detected, the operation returns face details including a bounding box
        /// of the face, a confidence value (that the bounding box contains a face), and a fixed
        /// set of attributes such as facial landmarks (for example, coordinates of eye and mouth),
        /// gender, presence of beard, sunglasses, etc. 
        /// </para>
        ///  
        /// <para>
        /// The face-detection algorithm is most effective on frontal faces. For non-frontal or
        /// obscured faces, the algorithm may not detect the faces or might detect faces with
        /// lower confidence. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This is a stateless API operation. That is, the operation does not persist any data.
        /// </para>
        ///  </note> 
        /// <para>
        /// For an example, see <a>get-started-exercise-detect-faces</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DetectFaces</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectFaces service method.</param>
        /// 
        /// <returns>The response from the DetectFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see <a>limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectFaces">REST API Reference for DetectFaces Operation</seealso>
        public DetectFacesResponse DetectFaces(DetectFacesRequest request)
        {
            var marshaller = new DetectFacesRequestMarshaller();
            var unmarshaller = DetectFacesResponseUnmarshaller.Instance;

            return Invoke<DetectFacesRequest,DetectFacesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectFaces operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectFaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectFaces">REST API Reference for DetectFaces Operation</seealso>
        public IAsyncResult BeginDetectFaces(DetectFacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetectFacesRequestMarshaller();
            var unmarshaller = DetectFacesResponseUnmarshaller.Instance;

            return BeginInvoke<DetectFacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectFaces.</param>
        /// 
        /// <returns>Returns a  DetectFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectFaces">REST API Reference for DetectFaces Operation</seealso>
        public  DetectFacesResponse EndDetectFaces(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectFacesResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectLabels

        /// <summary>
        /// Detects instances of real-world labels within an image (JPEG or PNG) provided as input.
        /// This includes objects like flower, tree, and table; events like wedding, graduation,
        /// and birthday party; and concepts like landscape, evening, and nature. For an example,
        /// see <a>get-started-exercise-detect-labels</a>.
        /// 
        ///  
        /// <para>
        ///  For each object, scene, and concept the API returns one or more labels. Each label
        /// provides the object name, and the level of confidence that the image contains the
        /// object. For example, suppose the input image has a lighthouse, the sea, and a rock.
        /// The response will include all three labels, one for each object. 
        /// </para>
        ///  
        /// <para>
        ///  <code>{Name: lighthouse, Confidence: 98.4629}</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>{Name: rock,Confidence: 79.2097}</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> {Name: sea,Confidence: 75.061}</code> 
        /// </para>
        ///  
        /// <para>
        ///  In the preceding example, the operation returns one label for each of the three objects.
        /// The operation can also return multiple labels for the same object in the image. For
        /// example, if the input image shows a flower (for example, a tulip), the operation might
        /// return the following three labels. 
        /// </para>
        ///  
        /// <para>
        ///  <code>{Name: flower,Confidence: 99.0562}</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>{Name: plant,Confidence: 99.0562}</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>{Name: tulip,Confidence: 99.0562}</code> 
        /// </para>
        ///  
        /// <para>
        /// In this example, the detection algorithm more precisely identifies the flower as a
        /// tulip.
        /// </para>
        ///  
        /// <para>
        /// You can provide the input image as an S3 object or as base64-encoded bytes. In response,
        /// the API returns an array of labels. In addition, the response also includes the orientation
        /// correction. Optionally, you can specify <code>MinConfidence</code> to control the
        /// confidence threshold for the labels returned. The default is 50%. You can also add
        /// the <code>MaxLabels</code> parameter to limit the number of labels returned. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the object detected is a person, the operation doesn't provide the same facial
        /// details that the <a>DetectFaces</a> operation provides.
        /// </para>
        ///  </note> 
        /// <para>
        /// This is a stateless API operation. That is, the operation does not persist any data.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DetectLabels</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectLabels service method.</param>
        /// 
        /// <returns>The response from the DetectLabels service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see <a>limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectLabels">REST API Reference for DetectLabels Operation</seealso>
        public DetectLabelsResponse DetectLabels(DetectLabelsRequest request)
        {
            var marshaller = new DetectLabelsRequestMarshaller();
            var unmarshaller = DetectLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectLabelsRequest,DetectLabelsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectLabels operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectLabels">REST API Reference for DetectLabels Operation</seealso>
        public IAsyncResult BeginDetectLabels(DetectLabelsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetectLabelsRequestMarshaller();
            var unmarshaller = DetectLabelsResponseUnmarshaller.Instance;

            return BeginInvoke<DetectLabelsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectLabels.</param>
        /// 
        /// <returns>Returns a  DetectLabelsResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectLabels">REST API Reference for DetectLabels Operation</seealso>
        public  DetectLabelsResponse EndDetectLabels(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectLabelsResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectModerationLabels

        /// <summary>
        /// Detects explicit or suggestive adult content in a specified JPEG or PNG format image.
        /// Use <code>DetectModerationLabels</code> to moderate images depending on your requirements.
        /// For example, you might want to filter images that contain nudity, but not images containing
        /// suggestive content.
        /// 
        ///  
        /// <para>
        /// To filter images, use the labels returned by <code>DetectModerationLabels</code> to
        /// determine which types of content are appropriate. For information about moderation
        /// labels, see <a>image-moderation</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectModerationLabels service method.</param>
        /// 
        /// <returns>The response from the DetectModerationLabels service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see <a>limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectModerationLabels">REST API Reference for DetectModerationLabels Operation</seealso>
        public DetectModerationLabelsResponse DetectModerationLabels(DetectModerationLabelsRequest request)
        {
            var marshaller = new DetectModerationLabelsRequestMarshaller();
            var unmarshaller = DetectModerationLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectModerationLabelsRequest,DetectModerationLabelsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectModerationLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectModerationLabels operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectModerationLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectModerationLabels">REST API Reference for DetectModerationLabels Operation</seealso>
        public IAsyncResult BeginDetectModerationLabels(DetectModerationLabelsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetectModerationLabelsRequestMarshaller();
            var unmarshaller = DetectModerationLabelsResponseUnmarshaller.Instance;

            return BeginInvoke<DetectModerationLabelsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectModerationLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectModerationLabels.</param>
        /// 
        /// <returns>Returns a  DetectModerationLabelsResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectModerationLabels">REST API Reference for DetectModerationLabels Operation</seealso>
        public  DetectModerationLabelsResponse EndDetectModerationLabels(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectModerationLabelsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCelebrityInfo

        /// <summary>
        /// Gets the name and additional information about a celebrity based on his or her Rekognition
        /// ID. The additional information is returned as an array of URLs. If there is no additional
        /// information about the celebrity, this list is empty. For more information, see <a>celebrity-recognition</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:GetCelebrityInfo</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityInfo service method.</param>
        /// 
        /// <returns>The response from the GetCelebrityInfo service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// Collection specified in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityInfo">REST API Reference for GetCelebrityInfo Operation</seealso>
        public GetCelebrityInfoResponse GetCelebrityInfo(GetCelebrityInfoRequest request)
        {
            var marshaller = new GetCelebrityInfoRequestMarshaller();
            var unmarshaller = GetCelebrityInfoResponseUnmarshaller.Instance;

            return Invoke<GetCelebrityInfoRequest,GetCelebrityInfoResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCelebrityInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityInfo operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCelebrityInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityInfo">REST API Reference for GetCelebrityInfo Operation</seealso>
        public IAsyncResult BeginGetCelebrityInfo(GetCelebrityInfoRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetCelebrityInfoRequestMarshaller();
            var unmarshaller = GetCelebrityInfoResponseUnmarshaller.Instance;

            return BeginInvoke<GetCelebrityInfoRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCelebrityInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCelebrityInfo.</param>
        /// 
        /// <returns>Returns a  GetCelebrityInfoResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityInfo">REST API Reference for GetCelebrityInfo Operation</seealso>
        public  GetCelebrityInfoResponse EndGetCelebrityInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCelebrityInfoResponse>(asyncResult);
        }

        #endregion
        
        #region  IndexFaces

        /// <summary>
        /// Detects faces in the input image and adds them to the specified collection. 
        /// 
        ///  
        /// <para>
        ///  Amazon Rekognition does not save the actual faces detected. Instead, the underlying
        /// detection algorithm first detects the faces in the input image, and for each face
        /// extracts facial features into a feature vector, and stores it in the back-end database.
        /// Amazon Rekognition uses feature vectors when performing face match and search operations
        /// using the and operations. 
        /// </para>
        ///  
        /// <para>
        /// If you provide the optional <code>externalImageID</code> for the input image you provided,
        /// Amazon Rekognition associates this ID with all faces that it detects. When you call
        /// the operation, the response returns the external ID. You can use this external image
        /// ID to create a client-side index to associate the faces with each image. You can then
        /// use the index to find all faces in an image. 
        /// </para>
        ///  
        /// <para>
        /// In response, the operation returns an array of metadata for all detected faces. This
        /// includes, the bounding box of the detected face, confidence value (indicating the
        /// bounding box contains a face), a face ID assigned by the service for each face that
        /// is detected and stored, and an image ID assigned by the service for the input image.
        /// If you request all facial attributes (using the <code>detectionAttributes</code> parameter,
        /// Amazon Rekognition returns detailed facial attributes such as facial landmarks (for
        /// example, location of eye and mount) and other facial attributes such gender. If you
        /// provide the same image, specify the same collection, and use the same external ID
        /// in the <code>IndexFaces</code> operation, Amazon Rekognition doesn't save duplicate
        /// face metadata. 
        /// </para>
        ///  
        /// <para>
        /// For an example, see <a>example2</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:IndexFaces</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IndexFaces service method.</param>
        /// 
        /// <returns>The response from the IndexFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see <a>limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// Collection specified in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/IndexFaces">REST API Reference for IndexFaces Operation</seealso>
        public IndexFacesResponse IndexFaces(IndexFacesRequest request)
        {
            var marshaller = new IndexFacesRequestMarshaller();
            var unmarshaller = IndexFacesResponseUnmarshaller.Instance;

            return Invoke<IndexFacesRequest,IndexFacesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the IndexFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IndexFaces operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIndexFaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/IndexFaces">REST API Reference for IndexFaces Operation</seealso>
        public IAsyncResult BeginIndexFaces(IndexFacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new IndexFacesRequestMarshaller();
            var unmarshaller = IndexFacesResponseUnmarshaller.Instance;

            return BeginInvoke<IndexFacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  IndexFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIndexFaces.</param>
        /// 
        /// <returns>Returns a  IndexFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/IndexFaces">REST API Reference for IndexFaces Operation</seealso>
        public  IndexFacesResponse EndIndexFaces(IAsyncResult asyncResult)
        {
            return EndInvoke<IndexFacesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollections

        /// <summary>
        /// Returns list of collection IDs in your account. If the result is truncated, the response
        /// also provides a <code>NextToken</code> that you can use in the subsequent request
        /// to fetch the next set of collection IDs.
        /// 
        ///  
        /// <para>
        /// For an example, see <a>example1</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:ListCollections</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollections service method.</param>
        /// 
        /// <returns>The response from the ListCollections service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// Collection specified in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public ListCollectionsResponse ListCollections(ListCollectionsRequest request)
        {
            var marshaller = new ListCollectionsRequestMarshaller();
            var unmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return Invoke<ListCollectionsRequest,ListCollectionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollections operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public IAsyncResult BeginListCollections(ListCollectionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListCollectionsRequestMarshaller();
            var unmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListCollectionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollections.</param>
        /// 
        /// <returns>Returns a  ListCollectionsResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public  ListCollectionsResponse EndListCollections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFaces

        /// <summary>
        /// Returns metadata for faces in the specified collection. This metadata includes information
        /// such as the bounding box coordinates, the confidence (that the bounding box contains
        /// a face), and face ID. For an example, see <a>example3</a>. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:ListFaces</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFaces service method.</param>
        /// 
        /// <returns>The response from the ListFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// Collection specified in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListFaces">REST API Reference for ListFaces Operation</seealso>
        public ListFacesResponse ListFaces(ListFacesRequest request)
        {
            var marshaller = new ListFacesRequestMarshaller();
            var unmarshaller = ListFacesResponseUnmarshaller.Instance;

            return Invoke<ListFacesRequest,ListFacesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFaces operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListFaces">REST API Reference for ListFaces Operation</seealso>
        public IAsyncResult BeginListFaces(ListFacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListFacesRequestMarshaller();
            var unmarshaller = ListFacesResponseUnmarshaller.Instance;

            return BeginInvoke<ListFacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFaces.</param>
        /// 
        /// <returns>Returns a  ListFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListFaces">REST API Reference for ListFaces Operation</seealso>
        public  ListFacesResponse EndListFaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFacesResponse>(asyncResult);
        }

        #endregion
        
        #region  RecognizeCelebrities

        /// <summary>
        /// Returns an array of celebrities recognized in the input image. The image is passed
        /// either as base64-encoded image bytes or as a reference to an image in an Amazon S3
        /// bucket. The image must be either a PNG or JPEG formatted file. For more information,
        /// see <a>celebrity-recognition</a>. 
        /// 
        ///  
        /// <para>
        ///  <code>RecognizeCelebrities</code> returns the 15 largest faces in the image. It lists
        /// recognized celebrities in the <code>CelebrityFaces</code> list and unrecognized faces
        /// in the <code>UnrecognizedFaces</code> list. The operation doesn't return celebrities
        /// whose face sizes are smaller than the largest 15 faces in the image.
        /// </para>
        ///  
        /// <para>
        /// For each celebrity recognized, the API returns a <code>Celebrity</code> object. The
        /// <code>Celebrity</code> object contains the celebrity name, ID, URL links to additional
        /// information, match confidence, and a <code>ComparedFace</code> object that you can
        /// use to locate the celebrity's face on the image.
        /// </para>
        ///  
        /// <para>
        /// Rekognition does not retain information about which images a celebrity has been recognized
        /// in. Your application must store this information and use the <code>Celebrity</code>
        /// ID property as a unique identifier for the celebrity. If you don't store the celebrity
        /// name or additional information URLs returned by <code>RecognizeCelebrities</code>,
        /// you will need the ID to identify the celebrity in a call to the operation.
        /// </para>
        ///  
        /// <para>
        /// For an example, see <a>recognize-celebrities-tutorial</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:RecognizeCelebrities</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecognizeCelebrities service method.</param>
        /// 
        /// <returns>The response from the RecognizeCelebrities service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see <a>limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/RecognizeCelebrities">REST API Reference for RecognizeCelebrities Operation</seealso>
        public RecognizeCelebritiesResponse RecognizeCelebrities(RecognizeCelebritiesRequest request)
        {
            var marshaller = new RecognizeCelebritiesRequestMarshaller();
            var unmarshaller = RecognizeCelebritiesResponseUnmarshaller.Instance;

            return Invoke<RecognizeCelebritiesRequest,RecognizeCelebritiesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RecognizeCelebrities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecognizeCelebrities operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecognizeCelebrities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/RecognizeCelebrities">REST API Reference for RecognizeCelebrities Operation</seealso>
        public IAsyncResult BeginRecognizeCelebrities(RecognizeCelebritiesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RecognizeCelebritiesRequestMarshaller();
            var unmarshaller = RecognizeCelebritiesResponseUnmarshaller.Instance;

            return BeginInvoke<RecognizeCelebritiesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RecognizeCelebrities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecognizeCelebrities.</param>
        /// 
        /// <returns>Returns a  RecognizeCelebritiesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/RecognizeCelebrities">REST API Reference for RecognizeCelebrities Operation</seealso>
        public  RecognizeCelebritiesResponse EndRecognizeCelebrities(IAsyncResult asyncResult)
        {
            return EndInvoke<RecognizeCelebritiesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchFaces

        /// <summary>
        /// For a given input face ID, searches for matching faces in the collection the face
        /// belongs to. You get a face ID when you add a face to the collection using the <a>IndexFaces</a>
        /// operation. The operation compares the features of the input face with faces in the
        /// specified collection. 
        /// 
        ///  <note> 
        /// <para>
        /// You can also search faces without indexing faces by using the <code>SearchFacesByImage</code>
        /// operation.
        /// </para>
        ///  </note> 
        /// <para>
        ///  The operation response returns an array of faces that match, ordered by similarity
        /// score with the highest similarity first. More specifically, it is an array of metadata
        /// for each face match that is found. Along with the metadata, the response also includes
        /// a <code>confidence</code> value for each face match, indicating the confidence that
        /// the specific face matches the input face. 
        /// </para>
        ///  
        /// <para>
        /// For an example, see <a>example3</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:SearchFaces</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFaces service method.</param>
        /// 
        /// <returns>The response from the SearchFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// Collection specified in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFaces">REST API Reference for SearchFaces Operation</seealso>
        public SearchFacesResponse SearchFaces(SearchFacesRequest request)
        {
            var marshaller = new SearchFacesRequestMarshaller();
            var unmarshaller = SearchFacesResponseUnmarshaller.Instance;

            return Invoke<SearchFacesRequest,SearchFacesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFaces operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchFaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFaces">REST API Reference for SearchFaces Operation</seealso>
        public IAsyncResult BeginSearchFaces(SearchFacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SearchFacesRequestMarshaller();
            var unmarshaller = SearchFacesResponseUnmarshaller.Instance;

            return BeginInvoke<SearchFacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchFaces.</param>
        /// 
        /// <returns>Returns a  SearchFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFaces">REST API Reference for SearchFaces Operation</seealso>
        public  SearchFacesResponse EndSearchFaces(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchFacesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchFacesByImage

        /// <summary>
        /// For a given input image, first detects the largest face in the image, and then searches
        /// the specified collection for matching faces. The operation compares the features of
        /// the input face with faces in the specified collection. 
        /// 
        ///  <note> 
        /// <para>
        ///  To search for all faces in an input image, you might first call the operation, and
        /// then use the face IDs returned in subsequent calls to the operation. 
        /// </para>
        ///  
        /// <para>
        ///  You can also call the <code>DetectFaces</code> operation and use the bounding boxes
        /// in the response to make face crops, which then you can pass in to the <code>SearchFacesByImage</code>
        /// operation. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  The response returns an array of faces that match, ordered by similarity score with
        /// the highest similarity first. More specifically, it is an array of metadata for each
        /// face match found. Along with the metadata, the response also includes a <code>similarity</code>
        /// indicating how similar the face is to the input face. In the response, the operation
        /// also returns the bounding box (and a confidence level that the bounding box contains
        /// a face) of the face that Amazon Rekognition used for the input image. 
        /// </para>
        ///  
        /// <para>
        /// For an example, see <a>example3</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:SearchFacesByImage</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFacesByImage service method.</param>
        /// 
        /// <returns>The response from the SearchFacesByImage service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see <a>limits</a>.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// Collection specified in the request is not found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFacesByImage">REST API Reference for SearchFacesByImage Operation</seealso>
        public SearchFacesByImageResponse SearchFacesByImage(SearchFacesByImageRequest request)
        {
            var marshaller = new SearchFacesByImageRequestMarshaller();
            var unmarshaller = SearchFacesByImageResponseUnmarshaller.Instance;

            return Invoke<SearchFacesByImageRequest,SearchFacesByImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchFacesByImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFacesByImage operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchFacesByImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFacesByImage">REST API Reference for SearchFacesByImage Operation</seealso>
        public IAsyncResult BeginSearchFacesByImage(SearchFacesByImageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SearchFacesByImageRequestMarshaller();
            var unmarshaller = SearchFacesByImageResponseUnmarshaller.Instance;

            return BeginInvoke<SearchFacesByImageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchFacesByImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchFacesByImage.</param>
        /// 
        /// <returns>Returns a  SearchFacesByImageResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFacesByImage">REST API Reference for SearchFacesByImage Operation</seealso>
        public  SearchFacesByImageResponse EndSearchFacesByImage(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchFacesByImageResponse>(asyncResult);
        }

        #endregion
        
    }
}