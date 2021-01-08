/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Rekognition.Model;
using Amazon.Rekognition.Model.Internal.MarshallTransformations;
using Amazon.Rekognition.Internal;
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
        private static IServiceMetadata serviceMetadata = new AmazonRekognitionMetadata();

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

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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
        /// Compares a face in the <i>source</i> input image with each of the 100 largest faces
        /// detected in the <i>target</i> input image. 
        /// 
        ///  <note> 
        /// <para>
        ///  If the source image contains multiple faces, the service detects the largest face
        /// and compares it with each face detected in the target image. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You pass the input and target images either as base64-encoded image bytes or as references
        /// to images in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes isn't supported. The image must be formatted as a
        /// PNG or JPEG file. 
        /// </para>
        ///  
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
        /// The <code>QualityFilter</code> input parameter allows you to filter out detected faces
        /// that don’t meet a required quality bar. The quality bar is based on a variety of common
        /// use cases. Use <code>QualityFilter</code> to set the quality bar by specifying <code>LOW</code>,
        /// <code>MEDIUM</code>, or <code>HIGH</code>. If you do not want to filter detected faces,
        /// specify <code>NONE</code>. The default value is <code>NONE</code>. 
        /// </para>
        ///  
        /// <para>
        /// If the image doesn't contain Exif metadata, <code>CompareFaces</code> returns orientation
        /// information for the source and target images. Use these values to display the images
        /// with the correct image orientation.
        /// </para>
        ///  
        /// <para>
        /// If no faces are detected in the source or target images, <code>CompareFaces</code>
        /// returns an <code>InvalidParameterException</code> error. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This is a stateless API operation. That is, data returned by this operation doesn't
        /// persist.
        /// </para>
        ///  </note> 
        /// <para>
        /// For an example, see Comparing Faces in Images in the Amazon Rekognition Developer
        /// Guide.
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
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
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
        public virtual CompareFacesResponse CompareFaces(CompareFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompareFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompareFacesResponseUnmarshaller.Instance;

            return Invoke<CompareFacesResponse>(request, options);
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
        public virtual IAsyncResult BeginCompareFaces(CompareFacesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompareFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompareFacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CompareFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompareFaces.</param>
        /// 
        /// <returns>Returns a  CompareFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CompareFaces">REST API Reference for CompareFaces Operation</seealso>
        public virtual CompareFacesResponse EndCompareFaces(IAsyncResult asyncResult)
        {
            return EndInvoke<CompareFacesResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCollection

        /// <summary>
        /// Creates a collection in an AWS Region. You can add faces to the collection using the
        /// <a>IndexFaces</a> operation. 
        /// 
        ///  
        /// <para>
        /// For example, you might create collections, one for each of your application users.
        /// A user can then index faces using the <code>IndexFaces</code> operation and persist
        /// results in a specific collection. Then, a user can search the collection for faces
        /// in the user-specific container. 
        /// </para>
        ///  
        /// <para>
        /// When you create a collection, it is associated with the latest version of the face
        /// model version.
        /// </para>
        ///  <note> 
        /// <para>
        /// Collection names are case-sensitive.
        /// </para>
        ///  </note> 
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
        public virtual CreateCollectionResponse CreateCollection(CreateCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return Invoke<CreateCollectionResponse>(request, options);
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
        public virtual IAsyncResult BeginCreateCollection(CreateCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCollection.</param>
        /// 
        /// <returns>Returns a  CreateCollectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        public virtual CreateCollectionResponse EndCreateCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProject

        /// <summary>
        /// Creates a new Amazon Rekognition Custom Labels project. A project is a logical grouping
        /// of resources (images, Labels, models) and operations (training, evaluation and detection).
        /// 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:CreateProject</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse EndCreateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProjectVersion

        /// <summary>
        /// Creates a new version of a model and begins training. Models are managed as part of
        /// an Amazon Rekognition Custom Labels project. You can specify one training dataset
        /// and one testing dataset. The response from <code>CreateProjectVersion</code> is an
        /// Amazon Resource Name (ARN) for the version of the model. 
        /// 
        ///  
        /// <para>
        /// Training takes a while to complete. You can get the current status by calling <a>DescribeProjectVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// Once training has successfully completed, call <a>DescribeProjectVersions</a> to get
        /// the training results and evaluate the model. 
        /// </para>
        ///  
        /// <para>
        /// After evaluating the model, you start the model by calling <a>StartProjectVersion</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:CreateProjectVersion</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectVersion service method.</param>
        /// 
        /// <returns>The response from the CreateProjectVersion service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateProjectVersion">REST API Reference for CreateProjectVersion Operation</seealso>
        public virtual CreateProjectVersionResponse CreateProjectVersion(CreateProjectVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectVersionResponseUnmarshaller.Instance;

            return Invoke<CreateProjectVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProjectVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectVersion operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProjectVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateProjectVersion">REST API Reference for CreateProjectVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateProjectVersion(CreateProjectVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProjectVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProjectVersion.</param>
        /// 
        /// <returns>Returns a  CreateProjectVersionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateProjectVersion">REST API Reference for CreateProjectVersion Operation</seealso>
        public virtual CreateProjectVersionResponse EndCreateProjectVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProjectVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStreamProcessor

        /// <summary>
        /// Creates an Amazon Rekognition stream processor that you can use to detect and recognize
        /// faces in a streaming video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video is a consumer of live video from Amazon Kinesis Video Streams.
        /// Amazon Rekognition Video sends analysis results to Amazon Kinesis Data Streams.
        /// </para>
        ///  
        /// <para>
        /// You provide as input a Kinesis video stream (<code>Input</code>) and a Kinesis data
        /// stream (<code>Output</code>) stream. You also specify the face recognition criteria
        /// in <code>Settings</code>. For example, the collection containing faces that you want
        /// to recognize. Use <code>Name</code> to assign an identifier for the stream processor.
        /// You use <code>Name</code> to manage the stream processor. For example, you can start
        /// processing the source video by calling <a>StartStreamProcessor</a> with the <code>Name</code>
        /// field. 
        /// </para>
        ///  
        /// <para>
        /// After you have finished analyzing a streaming video, use <a>StopStreamProcessor</a>
        /// to stop processing. You can delete the stream processor by calling <a>DeleteStreamProcessor</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamProcessor service method.</param>
        /// 
        /// <returns>The response from the CreateStreamProcessor service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateStreamProcessor">REST API Reference for CreateStreamProcessor Operation</seealso>
        public virtual CreateStreamProcessorResponse CreateStreamProcessor(CreateStreamProcessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<CreateStreamProcessorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamProcessor operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamProcessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateStreamProcessor">REST API Reference for CreateStreamProcessor Operation</seealso>
        public virtual IAsyncResult BeginCreateStreamProcessor(CreateStreamProcessorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamProcessorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamProcessor.</param>
        /// 
        /// <returns>Returns a  CreateStreamProcessorResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateStreamProcessor">REST API Reference for CreateStreamProcessor Operation</seealso>
        public virtual CreateStreamProcessorResponse EndCreateStreamProcessor(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStreamProcessorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCollection

        /// <summary>
        /// Deletes the specified collection. Note that this operation removes all faces in the
        /// collection. For an example, see <a>delete-collection-procedure</a>.
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public virtual DeleteCollectionResponse DeleteCollection(DeleteCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return Invoke<DeleteCollectionResponse>(request, options);
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
        public virtual IAsyncResult BeginDeleteCollection(DeleteCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCollection.</param>
        /// 
        /// <returns>Returns a  DeleteCollectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public virtual DeleteCollectionResponse EndDeleteCollection(IAsyncResult asyncResult)
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteFaces">REST API Reference for DeleteFaces Operation</seealso>
        public virtual DeleteFacesResponse DeleteFaces(DeleteFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacesResponseUnmarshaller.Instance;

            return Invoke<DeleteFacesResponse>(request, options);
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
        public virtual IAsyncResult BeginDeleteFaces(DeleteFacesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFaces.</param>
        /// 
        /// <returns>Returns a  DeleteFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteFaces">REST API Reference for DeleteFaces Operation</seealso>
        public virtual DeleteFacesResponse EndDeleteFaces(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFacesResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProject

        /// <summary>
        /// Deletes an Amazon Rekognition Custom Labels project. To delete a project you must
        /// first delete all models associated with the project. To delete a model, see <a>DeleteProjectVersion</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DeleteProject</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProjectVersion

        /// <summary>
        /// Deletes an Amazon Rekognition Custom Labels model. 
        /// 
        ///  
        /// <para>
        /// You can't delete a model if it is running or if it is training. To check the status
        /// of a model, use the <code>Status</code> field returned from <a>DescribeProjectVersions</a>.
        /// To stop a running model call <a>StopProjectVersion</a>. If the model is training,
        /// wait until it finishes.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DeleteProjectVersion</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteProjectVersion service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteProjectVersion">REST API Reference for DeleteProjectVersion Operation</seealso>
        public virtual DeleteProjectVersionResponse DeleteProjectVersion(DeleteProjectVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProjectVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectVersion operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProjectVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteProjectVersion">REST API Reference for DeleteProjectVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteProjectVersion(DeleteProjectVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProjectVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProjectVersion.</param>
        /// 
        /// <returns>Returns a  DeleteProjectVersionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteProjectVersion">REST API Reference for DeleteProjectVersion Operation</seealso>
        public virtual DeleteProjectVersionResponse EndDeleteProjectVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProjectVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStreamProcessor

        /// <summary>
        /// Deletes the stream processor identified by <code>Name</code>. You assign the value
        /// for <code>Name</code> when you create the stream processor with <a>CreateStreamProcessor</a>.
        /// You might not be able to use the same name for a stream processor for a few seconds
        /// after calling <code>DeleteStreamProcessor</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamProcessor service method.</param>
        /// 
        /// <returns>The response from the DeleteStreamProcessor service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteStreamProcessor">REST API Reference for DeleteStreamProcessor Operation</seealso>
        public virtual DeleteStreamProcessorResponse DeleteStreamProcessor(DeleteStreamProcessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamProcessorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamProcessor operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStreamProcessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteStreamProcessor">REST API Reference for DeleteStreamProcessor Operation</seealso>
        public virtual IAsyncResult BeginDeleteStreamProcessor(DeleteStreamProcessorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamProcessorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStreamProcessor.</param>
        /// 
        /// <returns>Returns a  DeleteStreamProcessorResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteStreamProcessor">REST API Reference for DeleteStreamProcessor Operation</seealso>
        public virtual DeleteStreamProcessorResponse EndDeleteStreamProcessor(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStreamProcessorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCollection

        /// <summary>
        /// Describes the specified collection. You can use <code>DescribeCollection</code> to
        /// get information, such as the number of faces indexed into a collection and the version
        /// of the model used by the collection for face detection.
        /// 
        ///  
        /// <para>
        /// For more information, see Describing a Collection in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCollection service method.</param>
        /// 
        /// <returns>The response from the DescribeCollection service method, as returned by Rekognition.</returns>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeCollection">REST API Reference for DescribeCollection Operation</seealso>
        public virtual DescribeCollectionResponse DescribeCollection(DescribeCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCollectionResponseUnmarshaller.Instance;

            return Invoke<DescribeCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCollection operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeCollection">REST API Reference for DescribeCollection Operation</seealso>
        public virtual IAsyncResult BeginDescribeCollection(DescribeCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCollection.</param>
        /// 
        /// <returns>Returns a  DescribeCollectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeCollection">REST API Reference for DescribeCollection Operation</seealso>
        public virtual DescribeCollectionResponse EndDescribeCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProjects

        /// <summary>
        /// Lists and gets information about your Amazon Rekognition Custom Labels projects.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DescribeProjects</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProjects service method.</param>
        /// 
        /// <returns>The response from the DescribeProjects service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeProjects">REST API Reference for DescribeProjects Operation</seealso>
        public virtual DescribeProjectsResponse DescribeProjects(DescribeProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectsResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProjects operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeProjects">REST API Reference for DescribeProjects Operation</seealso>
        public virtual IAsyncResult BeginDescribeProjects(DescribeProjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProjects.</param>
        /// 
        /// <returns>Returns a  DescribeProjectsResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeProjects">REST API Reference for DescribeProjects Operation</seealso>
        public virtual DescribeProjectsResponse EndDescribeProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProjectVersions

        /// <summary>
        /// Lists and describes the models in an Amazon Rekognition Custom Labels project. You
        /// can specify up to 10 model versions in <code>ProjectVersionArns</code>. If you don't
        /// specify a value, descriptions for all models are returned.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DescribeProjectVersions</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProjectVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeProjectVersions service method, as returned by Rekognition.</returns>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeProjectVersions">REST API Reference for DescribeProjectVersions Operation</seealso>
        public virtual DescribeProjectVersionsResponse DescribeProjectVersions(DescribeProjectVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProjectVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProjectVersions operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProjectVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeProjectVersions">REST API Reference for DescribeProjectVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeProjectVersions(DescribeProjectVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProjectVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProjectVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProjectVersions.</param>
        /// 
        /// <returns>Returns a  DescribeProjectVersionsResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeProjectVersions">REST API Reference for DescribeProjectVersions Operation</seealso>
        public virtual DescribeProjectVersionsResponse EndDescribeProjectVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProjectVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStreamProcessor

        /// <summary>
        /// Provides information about a stream processor created by <a>CreateStreamProcessor</a>.
        /// You can get information about the input and output streams, the input parameters for
        /// the face recognition being performed, and the current status of the stream processor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamProcessor service method.</param>
        /// 
        /// <returns>The response from the DescribeStreamProcessor service method, as returned by Rekognition.</returns>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeStreamProcessor">REST API Reference for DescribeStreamProcessor Operation</seealso>
        public virtual DescribeStreamProcessorResponse DescribeStreamProcessor(DescribeStreamProcessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamProcessorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamProcessor operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStreamProcessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeStreamProcessor">REST API Reference for DescribeStreamProcessor Operation</seealso>
        public virtual IAsyncResult BeginDescribeStreamProcessor(DescribeStreamProcessorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamProcessorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStreamProcessor.</param>
        /// 
        /// <returns>Returns a  DescribeStreamProcessorResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeStreamProcessor">REST API Reference for DescribeStreamProcessor Operation</seealso>
        public virtual DescribeStreamProcessorResponse EndDescribeStreamProcessor(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStreamProcessorResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectCustomLabels

        /// <summary>
        /// Detects custom labels in a supplied image by using an Amazon Rekognition Custom Labels
        /// model. 
        /// 
        ///  
        /// <para>
        /// You specify which version of a model version to use by using the <code>ProjectVersionArn</code>
        /// input parameter. 
        /// </para>
        ///  
        /// <para>
        /// You pass the input image as base64-encoded image bytes or as a reference to an image
        /// in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
        /// passing image bytes is not supported. The image must be either a PNG or JPEG formatted
        /// file. 
        /// </para>
        ///  
        /// <para>
        ///  For each object that the model version detects on an image, the API returns a (<code>CustomLabel</code>)
        /// object in an array (<code>CustomLabels</code>). Each <code>CustomLabel</code> object
        /// provides the label name (<code>Name</code>), the level of confidence that the image
        /// contains the object (<code>Confidence</code>), and object location information, if
        /// it exists, for the label on the image (<code>Geometry</code>). 
        /// </para>
        ///  
        /// <para>
        /// During training model calculates a threshold value that determines if a prediction
        /// for a label is true. By default, <code>DetectCustomLabels</code> doesn't return labels
        /// whose confidence value is below the model's calculated threshold value. To filter
        /// labels that are returned, specify a value for <code>MinConfidence</code> that is higher
        /// than the model's calculated threshold. You can get the model's calculated threshold
        /// from the model's training results shown in the Amazon Rekognition Custom Labels console.
        /// To get all labels, regardless of confidence, specify a <code>MinConfidence</code>
        /// value of 0. 
        /// </para>
        ///  
        /// <para>
        /// You can also add the <code>MaxResults</code> parameter to limit the number of labels
        /// returned. 
        /// </para>
        ///  
        /// <para>
        /// This is a stateless API operation. That is, the operation does not persist any data.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DetectCustomLabels</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectCustomLabels service method.</param>
        /// 
        /// <returns>The response from the DetectCustomLabels service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
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
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotReadyException">
        /// The requested resource isn't ready. For example, this exception occurs when you call
        /// <code>DetectCustomLabels</code> with a model version that isn't deployed.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectCustomLabels">REST API Reference for DetectCustomLabels Operation</seealso>
        public virtual DetectCustomLabelsResponse DetectCustomLabels(DetectCustomLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectCustomLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectCustomLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectCustomLabelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectCustomLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectCustomLabels operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectCustomLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectCustomLabels">REST API Reference for DetectCustomLabels Operation</seealso>
        public virtual IAsyncResult BeginDetectCustomLabels(DetectCustomLabelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectCustomLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectCustomLabelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectCustomLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectCustomLabels.</param>
        /// 
        /// <returns>Returns a  DetectCustomLabelsResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectCustomLabels">REST API Reference for DetectCustomLabels Operation</seealso>
        public virtual DetectCustomLabelsResponse EndDetectCustomLabels(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectCustomLabelsResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectFaces

        /// <summary>
        /// Detects faces within an image that is provided as input.
        /// 
        ///  
        /// <para>
        ///  <code>DetectFaces</code> detects the 100 largest faces in the image. For each face
        /// detected, the operation returns face details. These details include a bounding box
        /// of the face, a confidence value (that the bounding box contains a face), and a fixed
        /// set of attributes such as facial landmarks (for example, coordinates of eye and mouth),
        /// presence of beard, sunglasses, and so on. 
        /// </para>
        ///  
        /// <para>
        /// The face-detection algorithm is most effective on frontal faces. For non-frontal or
        /// obscured faces, the algorithm might not detect the faces or might detect faces with
        /// lower confidence. 
        /// </para>
        ///  
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes is not supported. The image must be either a PNG or
        /// JPEG formatted file. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This is a stateless API operation. That is, the operation does not persist any data.
        /// </para>
        ///  </note> 
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
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
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
        public virtual DetectFacesResponse DetectFaces(DetectFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectFacesResponseUnmarshaller.Instance;

            return Invoke<DetectFacesResponse>(request, options);
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
        public virtual IAsyncResult BeginDetectFaces(DetectFacesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectFacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectFaces.</param>
        /// 
        /// <returns>Returns a  DetectFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectFaces">REST API Reference for DetectFaces Operation</seealso>
        public virtual DetectFacesResponse EndDetectFaces(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectFacesResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectLabels

        /// <summary>
        /// Detects instances of real-world entities within an image (JPEG or PNG) provided as
        /// input. This includes objects like flower, tree, and table; events like wedding, graduation,
        /// and birthday party; and concepts like landscape, evening, and nature. 
        /// 
        ///  
        /// <para>
        /// For an example, see Analyzing Images Stored in an Amazon S3 Bucket in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>DetectLabels</code> does not support the detection of activities. However,
        /// activity detection is supported for label detection in videos. For more information,
        /// see StartLabelDetection in the Amazon Rekognition Developer Guide.
        /// </para>
        ///  </note> 
        /// <para>
        /// You pass the input image as base64-encoded image bytes or as a reference to an image
        /// in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
        /// passing image bytes is not supported. The image must be either a PNG or JPEG formatted
        /// file. 
        /// </para>
        ///  
        /// <para>
        ///  For each object, scene, and concept the API returns one or more labels. Each label
        /// provides the object name, and the level of confidence that the image contains the
        /// object. For example, suppose the input image has a lighthouse, the sea, and a rock.
        /// The response includes all three labels, one for each object. 
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
        /// In the preceding example, the operation returns one label for each of the three objects.
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
        /// In response, the API returns an array of labels. In addition, the response also includes
        /// the orientation correction. Optionally, you can specify <code>MinConfidence</code>
        /// to control the confidence threshold for the labels returned. The default is 55%. You
        /// can also add the <code>MaxLabels</code> parameter to limit the number of labels returned.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the object detected is a person, the operation doesn't provide the same facial
        /// details that the <a>DetectFaces</a> operation provides.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <code>DetectLabels</code> returns bounding boxes for instances of common object labels
        /// in an array of <a>Instance</a> objects. An <code>Instance</code> object contains a
        /// <a>BoundingBox</a> object, for the location of the label on the image. It also includes
        /// the confidence by which the bounding box was detected.
        /// </para>
        ///  
        /// <para>
        ///  <code>DetectLabels</code> also returns a hierarchical taxonomy of detected labels.
        /// For example, a detected car might be assigned the label <i>car</i>. The label <i>car</i>
        /// has two parent labels: <i>Vehicle</i> (its parent) and <i>Transportation</i> (its
        /// grandparent). The response returns the entire list of ancestors for a label. Each
        /// ancestor is a unique label in the response. In the previous example, <i>Car</i>, <i>Vehicle</i>,
        /// and <i>Transportation</i> are returned as unique labels in the response. 
        /// </para>
        ///  
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
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
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
        public virtual DetectLabelsResponse DetectLabels(DetectLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectLabelsResponse>(request, options);
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
        public virtual IAsyncResult BeginDetectLabels(DetectLabelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectLabelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectLabels.</param>
        /// 
        /// <returns>Returns a  DetectLabelsResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectLabels">REST API Reference for DetectLabels Operation</seealso>
        public virtual DetectLabelsResponse EndDetectLabels(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectLabelsResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectModerationLabels

        /// <summary>
        /// Detects unsafe content in a specified JPEG or PNG format image. Use <code>DetectModerationLabels</code>
        /// to moderate images depending on your requirements. For example, you might want to
        /// filter images that contain nudity, but not images containing suggestive content.
        /// 
        ///  
        /// <para>
        /// To filter images, use the labels returned by <code>DetectModerationLabels</code> to
        /// determine which types of content are appropriate.
        /// </para>
        ///  
        /// <para>
        /// For information about moderation labels, see Detecting Unsafe Content in the Amazon
        /// Rekognition Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes is not supported. The image must be either a PNG or
        /// JPEG formatted file. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectModerationLabels service method.</param>
        /// 
        /// <returns>The response from the DetectModerationLabels service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.HumanLoopQuotaExceededException">
        /// The number of in-progress human reviews you have has exceeded the number allowed.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
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
        public virtual DetectModerationLabelsResponse DetectModerationLabels(DetectModerationLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectModerationLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectModerationLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectModerationLabelsResponse>(request, options);
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
        public virtual IAsyncResult BeginDetectModerationLabels(DetectModerationLabelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectModerationLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectModerationLabelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectModerationLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectModerationLabels.</param>
        /// 
        /// <returns>Returns a  DetectModerationLabelsResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectModerationLabels">REST API Reference for DetectModerationLabels Operation</seealso>
        public virtual DetectModerationLabelsResponse EndDetectModerationLabels(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectModerationLabelsResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectProtectiveEquipment

        /// <summary>
        /// Detects Personal Protective Equipment (PPE) worn by people detected in an image. Amazon
        /// Rekognition can detect the following types of PPE.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Face cover
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Hand cover
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Head cover
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You pass the input image as base64-encoded image bytes or as a reference to an image
        /// in an Amazon S3 bucket. The image must be either a PNG or JPG formatted file. 
        /// </para>
        ///  
        /// <para>
        ///  <code>DetectProtectiveEquipment</code> detects PPE worn by up to 15 persons detected
        /// in an image.
        /// </para>
        ///  
        /// <para>
        /// For each person detected in the image the API returns an array of body parts (face,
        /// head, left-hand, right-hand). For each body part, an array of detected items of PPE
        /// is returned, including an indicator of whether or not the PPE covers the body part.
        /// The API returns the confidence it has in each detection (person, PPE, body part and
        /// body part coverage). It also returns a bounding box (<a>BoundingBox</a>) for each
        /// detected person and each detected item of PPE. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally request a summary of detected PPE items with the <code>SummarizationAttributes</code>
        /// input parameter. The summary provides the following information. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The persons detected as wearing all of the types of PPE that you specify.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The persons detected as not wearing all of the types PPE that you specify.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The persons detected where PPE adornment could not be determined. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This is a stateless API operation. That is, the operation does not persist any data.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DetectProtectiveEquipment</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectProtectiveEquipment service method.</param>
        /// 
        /// <returns>The response from the DetectProtectiveEquipment service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectProtectiveEquipment">REST API Reference for DetectProtectiveEquipment Operation</seealso>
        public virtual DetectProtectiveEquipmentResponse DetectProtectiveEquipment(DetectProtectiveEquipmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectProtectiveEquipmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectProtectiveEquipmentResponseUnmarshaller.Instance;

            return Invoke<DetectProtectiveEquipmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectProtectiveEquipment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectProtectiveEquipment operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectProtectiveEquipment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectProtectiveEquipment">REST API Reference for DetectProtectiveEquipment Operation</seealso>
        public virtual IAsyncResult BeginDetectProtectiveEquipment(DetectProtectiveEquipmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectProtectiveEquipmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectProtectiveEquipmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectProtectiveEquipment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectProtectiveEquipment.</param>
        /// 
        /// <returns>Returns a  DetectProtectiveEquipmentResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectProtectiveEquipment">REST API Reference for DetectProtectiveEquipment Operation</seealso>
        public virtual DetectProtectiveEquipmentResponse EndDetectProtectiveEquipment(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectProtectiveEquipmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectText

        /// <summary>
        /// Detects text in the input image and converts it into machine-readable text.
        /// 
        ///  
        /// <para>
        /// Pass the input image as base64-encoded image bytes or as a reference to an image in
        /// an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
        /// you must pass it as a reference to an image in an Amazon S3 bucket. For the AWS CLI,
        /// passing image bytes is not supported. The image must be either a .png or .jpeg formatted
        /// file. 
        /// </para>
        ///  
        /// <para>
        /// The <code>DetectText</code> operation returns text in an array of <a>TextDetection</a>
        /// elements, <code>TextDetections</code>. Each <code>TextDetection</code> element provides
        /// information about a single word or line of text that was detected in the image. 
        /// </para>
        ///  
        /// <para>
        /// A word is one or more ISO basic latin script characters that are not separated by
        /// spaces. <code>DetectText</code> can detect up to 50 words in an image.
        /// </para>
        ///  
        /// <para>
        /// A line is a string of equally spaced words. A line isn't necessarily a complete sentence.
        /// For example, a driver's license number is detected as a line. A line ends when there
        /// is no aligned text after it. Also, a line ends when there is a large gap between words,
        /// relative to the length of the words. This means, depending on the gap between words,
        /// Amazon Rekognition may detect multiple lines in text aligned in the same direction.
        /// Periods don't represent the end of a line. If a sentence spans multiple lines, the
        /// <code>DetectText</code> operation returns multiple lines.
        /// </para>
        ///  
        /// <para>
        /// To determine whether a <code>TextDetection</code> element is a line of text or a word,
        /// use the <code>TextDetection</code> object <code>Type</code> field. 
        /// </para>
        ///  
        /// <para>
        /// To be detected, text must be within +/- 90 degrees orientation of the horizontal axis.
        /// </para>
        ///  
        /// <para>
        /// For more information, see DetectText in the Amazon Rekognition Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectText service method.</param>
        /// 
        /// <returns>The response from the DetectText service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectText">REST API Reference for DetectText Operation</seealso>
        public virtual DetectTextResponse DetectText(DetectTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectTextResponseUnmarshaller.Instance;

            return Invoke<DetectTextResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectText operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectText
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectText">REST API Reference for DetectText Operation</seealso>
        public virtual IAsyncResult BeginDetectText(DetectTextRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectTextResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectText.</param>
        /// 
        /// <returns>Returns a  DetectTextResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectText">REST API Reference for DetectText Operation</seealso>
        public virtual DetectTextResponse EndDetectText(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectTextResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCelebrityInfo

        /// <summary>
        /// Gets the name and additional information about a celebrity based on his or her Amazon
        /// Rekognition ID. The additional information is returned as an array of URLs. If there
        /// is no additional information about the celebrity, this list is empty.
        /// 
        ///  
        /// <para>
        /// For more information, see Recognizing Celebrities in an Image in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityInfo">REST API Reference for GetCelebrityInfo Operation</seealso>
        public virtual GetCelebrityInfoResponse GetCelebrityInfo(GetCelebrityInfoRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCelebrityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityInfoResponseUnmarshaller.Instance;

            return Invoke<GetCelebrityInfoResponse>(request, options);
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
        public virtual IAsyncResult BeginGetCelebrityInfo(GetCelebrityInfoRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCelebrityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityInfoResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCelebrityInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCelebrityInfo.</param>
        /// 
        /// <returns>Returns a  GetCelebrityInfoResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityInfo">REST API Reference for GetCelebrityInfo Operation</seealso>
        public virtual GetCelebrityInfoResponse EndGetCelebrityInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCelebrityInfoResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCelebrityRecognition

        /// <summary>
        /// Gets the celebrity recognition results for a Amazon Rekognition Video analysis started
        /// by <a>StartCelebrityRecognition</a>.
        /// 
        ///  
        /// <para>
        /// Celebrity recognition in a video is an asynchronous operation. Analysis is started
        /// by a call to <a>StartCelebrityRecognition</a> which returns a job identifier (<code>JobId</code>).
        /// When the celebrity recognition operation finishes, Amazon Rekognition Video publishes
        /// a completion status to the Amazon Simple Notification Service topic registered in
        /// the initial call to <code>StartCelebrityRecognition</code>. To get the results of
        /// the celebrity recognition analysis, first check that the status value published to
        /// the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <code>GetCelebrityDetection</code>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartCelebrityDetection</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Working With Stored Videos in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetCelebrityRecognition</code> returns detected celebrities and the time(s)
        /// they are detected in an array (<code>Celebrities</code>) of <a>CelebrityRecognition</a>
        /// objects. Each <code>CelebrityRecognition</code> contains information about the celebrity
        /// in a <a>CelebrityDetail</a> object and the time, <code>Timestamp</code>, the celebrity
        /// was detected. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>GetCelebrityRecognition</code> only returns the default facial attributes (<code>BoundingBox</code>,
        /// <code>Confidence</code>, <code>Landmarks</code>, <code>Pose</code>, and <code>Quality</code>).
        /// The other facial attributes listed in the <code>Face</code> object of the following
        /// response syntax are not returned. For more information, see FaceDetail in the Amazon
        /// Rekognition Developer Guide. 
        /// </para>
        ///  </note> 
        /// <para>
        /// By default, the <code>Celebrities</code> array is sorted by time (milliseconds from
        /// the start of the video). You can also sort the array by celebrity by specifying the
        /// value <code>ID</code> in the <code>SortBy</code> input parameter.
        /// </para>
        ///  
        /// <para>
        /// The <code>CelebrityDetail</code> object includes the celebrity identifer and additional
        /// information urls. If you don't store the additional information urls, you can get
        /// them later by calling <a>GetCelebrityInfo</a> with the celebrity identifer.
        /// </para>
        ///  
        /// <para>
        /// No information is returned for faces not recognized as celebrities.
        /// </para>
        ///  
        /// <para>
        /// Use MaxResults parameter to limit the number of labels returned. If there are more
        /// results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <code>GetCelebrityDetection</code>
        /// and populate the <code>NextToken</code> request parameter with the token value returned
        /// from the previous call to <code>GetCelebrityRecognition</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityRecognition service method.</param>
        /// 
        /// <returns>The response from the GetCelebrityRecognition service method, as returned by Rekognition.</returns>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityRecognition">REST API Reference for GetCelebrityRecognition Operation</seealso>
        public virtual GetCelebrityRecognitionResponse GetCelebrityRecognition(GetCelebrityRecognitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityRecognitionResponseUnmarshaller.Instance;

            return Invoke<GetCelebrityRecognitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCelebrityRecognition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityRecognition operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCelebrityRecognition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityRecognition">REST API Reference for GetCelebrityRecognition Operation</seealso>
        public virtual IAsyncResult BeginGetCelebrityRecognition(GetCelebrityRecognitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityRecognitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCelebrityRecognition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCelebrityRecognition.</param>
        /// 
        /// <returns>Returns a  GetCelebrityRecognitionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityRecognition">REST API Reference for GetCelebrityRecognition Operation</seealso>
        public virtual GetCelebrityRecognitionResponse EndGetCelebrityRecognition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCelebrityRecognitionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContentModeration

        /// <summary>
        /// Gets the unsafe content analysis results for a Amazon Rekognition Video analysis started
        /// by <a>StartContentModeration</a>.
        /// 
        ///  
        /// <para>
        /// Unsafe content analysis of a video is an asynchronous operation. You start analysis
        /// by calling <a>StartContentModeration</a> which returns a job identifier (<code>JobId</code>).
        /// When analysis finishes, Amazon Rekognition Video publishes a completion status to
        /// the Amazon Simple Notification Service topic registered in the initial call to <code>StartContentModeration</code>.
        /// To get the results of the unsafe content analysis, first check that the status value
        /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <code>GetContentModeration</code>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartContentModeration</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Working with Stored Videos in the Amazon Rekognition Devlopers
        /// Guide.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetContentModeration</code> returns detected unsafe content labels, and the
        /// time they are detected, in an array, <code>ModerationLabels</code>, of <a>ContentModerationDetection</a>
        /// objects. 
        /// </para>
        ///  
        /// <para>
        /// By default, the moderated labels are returned sorted by time, in milliseconds from
        /// the start of the video. You can also sort them by moderated label by specifying <code>NAME</code>
        /// for the <code>SortBy</code> input parameter. 
        /// </para>
        ///  
        /// <para>
        /// Since video analysis can return a large number of results, use the <code>MaxResults</code>
        /// parameter to limit the number of labels returned in a single call to <code>GetContentModeration</code>.
        /// If there are more results than specified in <code>MaxResults</code>, the value of
        /// <code>NextToken</code> in the operation response contains a pagination token for getting
        /// the next set of results. To get the next page of results, call <code>GetContentModeration</code>
        /// and populate the <code>NextToken</code> request parameter with the value of <code>NextToken</code>
        /// returned from the previous call to <code>GetContentModeration</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting Unsafe Content in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContentModeration service method.</param>
        /// 
        /// <returns>The response from the GetContentModeration service method, as returned by Rekognition.</returns>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetContentModeration">REST API Reference for GetContentModeration Operation</seealso>
        public virtual GetContentModerationResponse GetContentModeration(GetContentModerationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentModerationResponseUnmarshaller.Instance;

            return Invoke<GetContentModerationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContentModeration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContentModeration operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContentModeration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetContentModeration">REST API Reference for GetContentModeration Operation</seealso>
        public virtual IAsyncResult BeginGetContentModeration(GetContentModerationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentModerationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContentModeration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContentModeration.</param>
        /// 
        /// <returns>Returns a  GetContentModerationResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetContentModeration">REST API Reference for GetContentModeration Operation</seealso>
        public virtual GetContentModerationResponse EndGetContentModeration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContentModerationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFaceDetection

        /// <summary>
        /// Gets face detection results for a Amazon Rekognition Video analysis started by <a>StartFaceDetection</a>.
        /// 
        ///  
        /// <para>
        /// Face detection with Amazon Rekognition Video is an asynchronous operation. You start
        /// face detection by calling <a>StartFaceDetection</a> which returns a job identifier
        /// (<code>JobId</code>). When the face detection operation finishes, Amazon Rekognition
        /// Video publishes a completion status to the Amazon Simple Notification Service topic
        /// registered in the initial call to <code>StartFaceDetection</code>. To get the results
        /// of the face detection operation, first check that the status value published to the
        /// Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetFaceDetection</a> and
        /// pass the job identifier (<code>JobId</code>) from the initial call to <code>StartFaceDetection</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetFaceDetection</code> returns an array of detected faces (<code>Faces</code>)
        /// sorted by the time the faces were detected. 
        /// </para>
        ///  
        /// <para>
        /// Use MaxResults parameter to limit the number of labels returned. If there are more
        /// results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <code>GetFaceDetection</code> and populate
        /// the <code>NextToken</code> request parameter with the token value returned from the
        /// previous call to <code>GetFaceDetection</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFaceDetection service method.</param>
        /// 
        /// <returns>The response from the GetFaceDetection service method, as returned by Rekognition.</returns>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceDetection">REST API Reference for GetFaceDetection Operation</seealso>
        public virtual GetFaceDetectionResponse GetFaceDetection(GetFaceDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceDetectionResponseUnmarshaller.Instance;

            return Invoke<GetFaceDetectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFaceDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFaceDetection operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFaceDetection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceDetection">REST API Reference for GetFaceDetection Operation</seealso>
        public virtual IAsyncResult BeginGetFaceDetection(GetFaceDetectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceDetectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFaceDetection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFaceDetection.</param>
        /// 
        /// <returns>Returns a  GetFaceDetectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceDetection">REST API Reference for GetFaceDetection Operation</seealso>
        public virtual GetFaceDetectionResponse EndGetFaceDetection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFaceDetectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFaceSearch

        /// <summary>
        /// Gets the face search results for Amazon Rekognition Video face search started by <a>StartFaceSearch</a>.
        /// The search returns faces in a collection that match the faces of persons detected
        /// in a video. It also includes the time(s) that faces are matched in the video.
        /// 
        ///  
        /// <para>
        /// Face search in a video is an asynchronous operation. You start face search by calling
        /// to <a>StartFaceSearch</a> which returns a job identifier (<code>JobId</code>). When
        /// the search operation finishes, Amazon Rekognition Video publishes a completion status
        /// to the Amazon Simple Notification Service topic registered in the initial call to
        /// <code>StartFaceSearch</code>. To get the search results, first check that the status
        /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <code>GetFaceSearch</code>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartFaceSearch</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Searching Faces in a Collection in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// The search results are retured in an array, <code>Persons</code>, of <a>PersonMatch</a>
        /// objects. Each<code>PersonMatch</code> element contains details about the matching
        /// faces in the input collection, person information (facial attributes, bounding boxes,
        /// and person identifer) for the matched person, and the time the person was matched
        /// in the video.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>GetFaceSearch</code> only returns the default facial attributes (<code>BoundingBox</code>,
        /// <code>Confidence</code>, <code>Landmarks</code>, <code>Pose</code>, and <code>Quality</code>).
        /// The other facial attributes listed in the <code>Face</code> object of the following
        /// response syntax are not returned. For more information, see FaceDetail in the Amazon
        /// Rekognition Developer Guide. 
        /// </para>
        ///  </note> 
        /// <para>
        /// By default, the <code>Persons</code> array is sorted by the time, in milliseconds
        /// from the start of the video, persons are matched. You can also sort by persons by
        /// specifying <code>INDEX</code> for the <code>SORTBY</code> input parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFaceSearch service method.</param>
        /// 
        /// <returns>The response from the GetFaceSearch service method, as returned by Rekognition.</returns>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceSearch">REST API Reference for GetFaceSearch Operation</seealso>
        public virtual GetFaceSearchResponse GetFaceSearch(GetFaceSearchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceSearchResponseUnmarshaller.Instance;

            return Invoke<GetFaceSearchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFaceSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFaceSearch operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFaceSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceSearch">REST API Reference for GetFaceSearch Operation</seealso>
        public virtual IAsyncResult BeginGetFaceSearch(GetFaceSearchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceSearchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFaceSearch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFaceSearch.</param>
        /// 
        /// <returns>Returns a  GetFaceSearchResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceSearch">REST API Reference for GetFaceSearch Operation</seealso>
        public virtual GetFaceSearchResponse EndGetFaceSearch(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFaceSearchResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLabelDetection

        /// <summary>
        /// Gets the label detection results of a Amazon Rekognition Video analysis started by
        /// <a>StartLabelDetection</a>. 
        /// 
        ///  
        /// <para>
        /// The label detection operation is started by a call to <a>StartLabelDetection</a> which
        /// returns a job identifier (<code>JobId</code>). When the label detection operation
        /// finishes, Amazon Rekognition publishes a completion status to the Amazon Simple Notification
        /// Service topic registered in the initial call to <code>StartlabelDetection</code>.
        /// To get the results of the label detection operation, first check that the status value
        /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetLabelDetection</a>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartLabelDetection</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetLabelDetection</code> returns an array of detected labels (<code>Labels</code>)
        /// sorted by the time the labels were detected. You can also sort by the label name by
        /// specifying <code>NAME</code> for the <code>SortBy</code> input parameter.
        /// </para>
        ///  
        /// <para>
        /// The labels returned include the label name, the percentage confidence in the accuracy
        /// of the detected label, and the time the label was detected in the video.
        /// </para>
        ///  
        /// <para>
        /// The returned labels also include bounding box information for common objects, a hierarchical
        /// taxonomy of detected labels, and the version of the label model used for detection.
        /// </para>
        ///  
        /// <para>
        /// Use MaxResults parameter to limit the number of labels returned. If there are more
        /// results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <code>GetlabelDetection</code> and
        /// populate the <code>NextToken</code> request parameter with the token value returned
        /// from the previous call to <code>GetLabelDetection</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLabelDetection service method.</param>
        /// 
        /// <returns>The response from the GetLabelDetection service method, as returned by Rekognition.</returns>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetLabelDetection">REST API Reference for GetLabelDetection Operation</seealso>
        public virtual GetLabelDetectionResponse GetLabelDetection(GetLabelDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLabelDetectionResponseUnmarshaller.Instance;

            return Invoke<GetLabelDetectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLabelDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLabelDetection operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLabelDetection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetLabelDetection">REST API Reference for GetLabelDetection Operation</seealso>
        public virtual IAsyncResult BeginGetLabelDetection(GetLabelDetectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLabelDetectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLabelDetection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLabelDetection.</param>
        /// 
        /// <returns>Returns a  GetLabelDetectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetLabelDetection">REST API Reference for GetLabelDetection Operation</seealso>
        public virtual GetLabelDetectionResponse EndGetLabelDetection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLabelDetectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPersonTracking

        /// <summary>
        /// Gets the path tracking results of a Amazon Rekognition Video analysis started by <a>StartPersonTracking</a>.
        /// 
        ///  
        /// <para>
        /// The person path tracking operation is started by a call to <code>StartPersonTracking</code>
        /// which returns a job identifier (<code>JobId</code>). When the operation finishes,
        /// Amazon Rekognition Video publishes a completion status to the Amazon Simple Notification
        /// Service topic registered in the initial call to <code>StartPersonTracking</code>.
        /// </para>
        ///  
        /// <para>
        /// To get the results of the person path tracking operation, first check that the status
        /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetPersonTracking</a>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartPersonTracking</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetPersonTracking</code> returns an array, <code>Persons</code>, of tracked
        /// persons and the time(s) their paths were tracked in the video. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>GetPersonTracking</code> only returns the default facial attributes (<code>BoundingBox</code>,
        /// <code>Confidence</code>, <code>Landmarks</code>, <code>Pose</code>, and <code>Quality</code>).
        /// The other facial attributes listed in the <code>Face</code> object of the following
        /// response syntax are not returned. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see FaceDetail in the Amazon Rekognition Developer Guide.
        /// </para>
        ///  </note> 
        /// <para>
        /// By default, the array is sorted by the time(s) a person's path is tracked in the video.
        /// You can sort by tracked persons by specifying <code>INDEX</code> for the <code>SortBy</code>
        /// input parameter.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>MaxResults</code> parameter to limit the number of items returned. If
        /// there are more results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <code>GetPersonTracking</code> and
        /// populate the <code>NextToken</code> request parameter with the token value returned
        /// from the previous call to <code>GetPersonTracking</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPersonTracking service method.</param>
        /// 
        /// <returns>The response from the GetPersonTracking service method, as returned by Rekognition.</returns>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetPersonTracking">REST API Reference for GetPersonTracking Operation</seealso>
        public virtual GetPersonTrackingResponse GetPersonTracking(GetPersonTrackingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersonTrackingResponseUnmarshaller.Instance;

            return Invoke<GetPersonTrackingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPersonTracking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPersonTracking operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPersonTracking
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetPersonTracking">REST API Reference for GetPersonTracking Operation</seealso>
        public virtual IAsyncResult BeginGetPersonTracking(GetPersonTrackingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersonTrackingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPersonTracking operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPersonTracking.</param>
        /// 
        /// <returns>Returns a  GetPersonTrackingResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetPersonTracking">REST API Reference for GetPersonTracking Operation</seealso>
        public virtual GetPersonTrackingResponse EndGetPersonTracking(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPersonTrackingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegmentDetection

        /// <summary>
        /// Gets the segment detection results of a Amazon Rekognition Video analysis started
        /// by <a>StartSegmentDetection</a>.
        /// 
        ///  
        /// <para>
        /// Segment detection with Amazon Rekognition Video is an asynchronous operation. You
        /// start segment detection by calling <a>StartSegmentDetection</a> which returns a job
        /// identifier (<code>JobId</code>). When the segment detection operation finishes, Amazon
        /// Rekognition publishes a completion status to the Amazon Simple Notification Service
        /// topic registered in the initial call to <code>StartSegmentDetection</code>. To get
        /// the results of the segment detection operation, first check that the status value
        /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. if so, call <code>GetSegmentDetection</code>
        /// and pass the job identifier (<code>JobId</code>) from the initial call of <code>StartSegmentDetection</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetSegmentDetection</code> returns detected segments in an array (<code>Segments</code>)
        /// of <a>SegmentDetection</a> objects. <code>Segments</code> is sorted by the segment
        /// types specified in the <code>SegmentTypes</code> input parameter of <code>StartSegmentDetection</code>.
        /// Each element of the array includes the detected segment, the precentage confidence
        /// in the acuracy of the detected segment, the type of the segment, and the frame in
        /// which the segment was detected.
        /// </para>
        ///  
        /// <para>
        /// Use <code>SelectedSegmentTypes</code> to find out the type of segment detection requested
        /// in the call to <code>StartSegmentDetection</code>.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>MaxResults</code> parameter to limit the number of segment detections
        /// returned. If there are more results than specified in <code>MaxResults</code>, the
        /// value of <code>NextToken</code> in the operation response contains a pagination token
        /// for getting the next set of results. To get the next page of results, call <code>GetSegmentDetection</code>
        /// and populate the <code>NextToken</code> request parameter with the token value returned
        /// from the previous call to <code>GetSegmentDetection</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting Video Segments in Stored Video in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentDetection service method.</param>
        /// 
        /// <returns>The response from the GetSegmentDetection service method, as returned by Rekognition.</returns>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetSegmentDetection">REST API Reference for GetSegmentDetection Operation</seealso>
        public virtual GetSegmentDetectionResponse GetSegmentDetection(GetSegmentDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentDetectionResponseUnmarshaller.Instance;

            return Invoke<GetSegmentDetectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentDetection operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentDetection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetSegmentDetection">REST API Reference for GetSegmentDetection Operation</seealso>
        public virtual IAsyncResult BeginGetSegmentDetection(GetSegmentDetectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSegmentDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentDetectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentDetection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentDetection.</param>
        /// 
        /// <returns>Returns a  GetSegmentDetectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetSegmentDetection">REST API Reference for GetSegmentDetection Operation</seealso>
        public virtual GetSegmentDetectionResponse EndGetSegmentDetection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentDetectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTextDetection

        /// <summary>
        /// Gets the text detection results of a Amazon Rekognition Video analysis started by
        /// <a>StartTextDetection</a>.
        /// 
        ///  
        /// <para>
        /// Text detection with Amazon Rekognition Video is an asynchronous operation. You start
        /// text detection by calling <a>StartTextDetection</a> which returns a job identifier
        /// (<code>JobId</code>) When the text detection operation finishes, Amazon Rekognition
        /// publishes a completion status to the Amazon Simple Notification Service topic registered
        /// in the initial call to <code>StartTextDetection</code>. To get the results of the
        /// text detection operation, first check that the status value published to the Amazon
        /// SNS topic is <code>SUCCEEDED</code>. if so, call <code>GetTextDetection</code> and
        /// pass the job identifier (<code>JobId</code>) from the initial call of <code>StartLabelDetection</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetTextDetection</code> returns an array of detected text (<code>TextDetections</code>)
        /// sorted by the time the text was detected, up to 50 words per frame of video.
        /// </para>
        ///  
        /// <para>
        /// Each element of the array includes the detected text, the precentage confidence in
        /// the acuracy of the detected text, the time the text was detected, bounding box information
        /// for where the text was located, and unique identifiers for words and their lines.
        /// </para>
        ///  
        /// <para>
        /// Use MaxResults parameter to limit the number of text detections returned. If there
        /// are more results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <code>GetTextDetection</code> and populate
        /// the <code>NextToken</code> request parameter with the token value returned from the
        /// previous call to <code>GetTextDetection</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTextDetection service method.</param>
        /// 
        /// <returns>The response from the GetTextDetection service method, as returned by Rekognition.</returns>
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetTextDetection">REST API Reference for GetTextDetection Operation</seealso>
        public virtual GetTextDetectionResponse GetTextDetection(GetTextDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTextDetectionResponseUnmarshaller.Instance;

            return Invoke<GetTextDetectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTextDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTextDetection operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTextDetection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetTextDetection">REST API Reference for GetTextDetection Operation</seealso>
        public virtual IAsyncResult BeginGetTextDetection(GetTextDetectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTextDetectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTextDetection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTextDetection.</param>
        /// 
        /// <returns>Returns a  GetTextDetectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetTextDetection">REST API Reference for GetTextDetection Operation</seealso>
        public virtual GetTextDetectionResponse EndGetTextDetection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTextDetectionResponse>(asyncResult);
        }

        #endregion
        
        #region  IndexFaces

        /// <summary>
        /// Detects faces in the input image and adds them to the specified collection. 
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition doesn't save the actual faces that are detected. Instead, the underlying
        /// detection algorithm first detects the faces in the input image. For each face, the
        /// algorithm extracts facial features into a feature vector, and stores it in the backend
        /// database. Amazon Rekognition uses feature vectors when it performs face match and
        /// search operations using the <a>SearchFaces</a> and <a>SearchFacesByImage</a> operations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Adding Faces to a Collection in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// To get the number of faces in a collection, call <a>DescribeCollection</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you're using version 1.0 of the face detection model, <code>IndexFaces</code> indexes
        /// the 15 largest faces in the input image. Later versions of the face detection model
        /// index the 100 largest faces in the input image. 
        /// </para>
        ///  
        /// <para>
        /// If you're using version 4 or later of the face model, image orientation information
        /// is not returned in the <code>OrientationCorrection</code> field. 
        /// </para>
        ///  
        /// <para>
        /// To determine which version of the model you're using, call <a>DescribeCollection</a>
        /// and supply the collection ID. You can also get the model version from the value of
        /// <code>FaceModelVersion</code> in the response from <code>IndexFaces</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Model Versioning in the Amazon Rekognition Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// If you provide the optional <code>ExternalImageId</code> for the input image you provided,
        /// Amazon Rekognition associates this ID with all faces that it detects. When you call
        /// the <a>ListFaces</a> operation, the response returns the external ID. You can use
        /// this external image ID to create a client-side index to associate the faces with each
        /// image. You can then use the index to find all faces in an image.
        /// </para>
        ///  
        /// <para>
        /// You can specify the maximum number of faces to index with the <code>MaxFaces</code>
        /// input parameter. This is useful when you want to index the largest faces in an image
        /// and don't want to index smaller faces, such as those belonging to people standing
        /// in the background.
        /// </para>
        ///  
        /// <para>
        /// The <code>QualityFilter</code> input parameter allows you to filter out detected faces
        /// that don’t meet a required quality bar. The quality bar is based on a variety of common
        /// use cases. By default, <code>IndexFaces</code> chooses the quality bar that's used
        /// to filter faces. You can also explicitly choose the quality bar. Use <code>QualityFilter</code>,
        /// to set the quality bar by specifying <code>LOW</code>, <code>MEDIUM</code>, or <code>HIGH</code>.
        /// If you do not want to filter detected faces, specify <code>NONE</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To use quality filtering, you need a collection associated with version 3 of the face
        /// model or higher. To get the version of the face model associated with a collection,
        /// call <a>DescribeCollection</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Information about faces detected in an image, but not indexed, is returned in an array
        /// of <a>UnindexedFace</a> objects, <code>UnindexedFaces</code>. Faces aren't indexed
        /// for reasons such as:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The number of faces detected exceeds the value of the <code>MaxFaces</code> request
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The face is too small compared to the image dimensions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The face is too blurry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The image is too dark.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The face has an extreme pose.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The face doesn’t have enough detail to be suitable for face search.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In response, the <code>IndexFaces</code> operation returns an array of metadata for
        /// all detected faces, <code>FaceRecords</code>. This includes: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The bounding box, <code>BoundingBox</code>, of the detected face. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A confidence value, <code>Confidence</code>, which indicates the confidence that the
        /// bounding box contains a face.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A face ID, <code>FaceId</code>, assigned by the service for each face that's detected
        /// and stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An image ID, <code>ImageId</code>, assigned by the service for the input image.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you request all facial attributes (by using the <code>detectionAttributes</code>
        /// parameter), Amazon Rekognition returns detailed facial attributes, such as facial
        /// landmarks (for example, location of eye and mouth) and other facial attributes. If
        /// you provide the same image, specify the same collection, and use the same external
        /// ID in the <code>IndexFaces</code> operation, Amazon Rekognition doesn't save duplicate
        /// face metadata.
        /// </para>
        ///   
        /// <para>
        /// The input image is passed either as base64-encoded image bytes, or as a reference
        /// to an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes isn't supported. The image must be formatted as a
        /// PNG or JPEG file. 
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
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ServiceQuotaExceededException">
        /// The size of the collection exceeds the allowed limit. For more information, see Limits
        /// in Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/IndexFaces">REST API Reference for IndexFaces Operation</seealso>
        public virtual IndexFacesResponse IndexFaces(IndexFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IndexFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IndexFacesResponseUnmarshaller.Instance;

            return Invoke<IndexFacesResponse>(request, options);
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
        public virtual IAsyncResult BeginIndexFaces(IndexFacesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IndexFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IndexFacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  IndexFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIndexFaces.</param>
        /// 
        /// <returns>Returns a  IndexFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/IndexFaces">REST API Reference for IndexFaces Operation</seealso>
        public virtual IndexFacesResponse EndIndexFaces(IAsyncResult asyncResult)
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
        /// For an example, see Listing Collections in the Amazon Rekognition Developer Guide.
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public virtual ListCollectionsResponse ListCollections(ListCollectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return Invoke<ListCollectionsResponse>(request, options);
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
        public virtual IAsyncResult BeginListCollections(ListCollectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollections.</param>
        /// 
        /// <returns>Returns a  ListCollectionsResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public virtual ListCollectionsResponse EndListCollections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFaces

        /// <summary>
        /// Returns metadata for faces in the specified collection. This metadata includes information
        /// such as the bounding box coordinates, the confidence (that the bounding box contains
        /// a face), and face ID. For an example, see Listing Faces in a Collection in the Amazon
        /// Rekognition Developer Guide.
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListFaces">REST API Reference for ListFaces Operation</seealso>
        public virtual ListFacesResponse ListFaces(ListFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacesResponseUnmarshaller.Instance;

            return Invoke<ListFacesResponse>(request, options);
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
        public virtual IAsyncResult BeginListFaces(ListFacesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFaces.</param>
        /// 
        /// <returns>Returns a  ListFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListFaces">REST API Reference for ListFaces Operation</seealso>
        public virtual ListFacesResponse EndListFaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFacesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStreamProcessors

        /// <summary>
        /// Gets a list of stream processors that you have created with <a>CreateStreamProcessor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamProcessors service method.</param>
        /// 
        /// <returns>The response from the ListStreamProcessors service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListStreamProcessors">REST API Reference for ListStreamProcessors Operation</seealso>
        public virtual ListStreamProcessorsResponse ListStreamProcessors(ListStreamProcessorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamProcessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamProcessorsResponseUnmarshaller.Instance;

            return Invoke<ListStreamProcessorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamProcessors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamProcessors operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreamProcessors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListStreamProcessors">REST API Reference for ListStreamProcessors Operation</seealso>
        public virtual IAsyncResult BeginListStreamProcessors(ListStreamProcessorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamProcessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamProcessorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamProcessors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamProcessors.</param>
        /// 
        /// <returns>Returns a  ListStreamProcessorsResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListStreamProcessors">REST API Reference for ListStreamProcessors Operation</seealso>
        public virtual ListStreamProcessorsResponse EndListStreamProcessors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStreamProcessorsResponse>(asyncResult);
        }

        #endregion
        
        #region  RecognizeCelebrities

        /// <summary>
        /// Returns an array of celebrities recognized in the input image. For more information,
        /// see Recognizing Celebrities in the Amazon Rekognition Developer Guide. 
        /// 
        ///  
        /// <para>
        ///  <code>RecognizeCelebrities</code> returns the 64 largest faces in the image. It lists
        /// recognized celebrities in the <code>CelebrityFaces</code> array and unrecognized faces
        /// in the <code>UnrecognizedFaces</code> array. <code>RecognizeCelebrities</code> doesn't
        /// return celebrities whose faces aren't among the largest 64 faces in the image.
        /// </para>
        ///  
        /// <para>
        /// For each celebrity recognized, <code>RecognizeCelebrities</code> returns a <code>Celebrity</code>
        /// object. The <code>Celebrity</code> object contains the celebrity name, ID, URL links
        /// to additional information, match confidence, and a <code>ComparedFace</code> object
        /// that you can use to locate the celebrity's face on the image.
        /// </para>
        ///  
        /// <para>
        /// Amazon Rekognition doesn't retain information about which images a celebrity has been
        /// recognized in. Your application must store this information and use the <code>Celebrity</code>
        /// ID property as a unique identifier for the celebrity. If you don't store the celebrity
        /// name or additional information URLs returned by <code>RecognizeCelebrities</code>,
        /// you will need the ID to identify the celebrity in a call to the <a>GetCelebrityInfo</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes is not supported. The image must be either a PNG or
        /// JPEG formatted file. 
        /// </para>
        ///  
        /// <para>
        /// For an example, see Recognizing Celebrities in an Image in the Amazon Rekognition
        /// Developer Guide.
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
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/RecognizeCelebrities">REST API Reference for RecognizeCelebrities Operation</seealso>
        public virtual RecognizeCelebritiesResponse RecognizeCelebrities(RecognizeCelebritiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecognizeCelebritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecognizeCelebritiesResponseUnmarshaller.Instance;

            return Invoke<RecognizeCelebritiesResponse>(request, options);
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
        public virtual IAsyncResult BeginRecognizeCelebrities(RecognizeCelebritiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecognizeCelebritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecognizeCelebritiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RecognizeCelebrities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecognizeCelebrities.</param>
        /// 
        /// <returns>Returns a  RecognizeCelebritiesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/RecognizeCelebrities">REST API Reference for RecognizeCelebrities Operation</seealso>
        public virtual RecognizeCelebritiesResponse EndRecognizeCelebrities(IAsyncResult asyncResult)
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
        /// For an example, see Searching for a Face Using Its Face ID in the Amazon Rekognition
        /// Developer Guide.
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFaces">REST API Reference for SearchFaces Operation</seealso>
        public virtual SearchFacesResponse SearchFaces(SearchFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesResponseUnmarshaller.Instance;

            return Invoke<SearchFacesResponse>(request, options);
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
        public virtual IAsyncResult BeginSearchFaces(SearchFacesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchFaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchFaces.</param>
        /// 
        /// <returns>Returns a  SearchFacesResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFaces">REST API Reference for SearchFaces Operation</seealso>
        public virtual SearchFacesResponse EndSearchFaces(IAsyncResult asyncResult)
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
        /// To search for all faces in an input image, you might first call the <a>IndexFaces</a>
        /// operation, and then use the face IDs returned in subsequent calls to the <a>SearchFaces</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        ///  You can also call the <code>DetectFaces</code> operation and use the bounding boxes
        /// in the response to make face crops, which then you can pass in to the <code>SearchFacesByImage</code>
        /// operation. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes is not supported. The image must be either a PNG or
        /// JPEG formatted file. 
        /// </para>
        ///  
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
        /// For an example, Searching for a Face Using an Image in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// The <code>QualityFilter</code> input parameter allows you to filter out detected faces
        /// that don’t meet a required quality bar. The quality bar is based on a variety of common
        /// use cases. Use <code>QualityFilter</code> to set the quality bar for filtering by
        /// specifying <code>LOW</code>, <code>MEDIUM</code>, or <code>HIGH</code>. If you do
        /// not want to filter detected faces, specify <code>NONE</code>. The default value is
        /// <code>NONE</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use quality filtering, you need a collection associated with version 3 of the face
        /// model or higher. To get the version of the face model associated with a collection,
        /// call <a>DescribeCollection</a>. 
        /// </para>
        ///  </note> 
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
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
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
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFacesByImage">REST API Reference for SearchFacesByImage Operation</seealso>
        public virtual SearchFacesByImageResponse SearchFacesByImage(SearchFacesByImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFacesByImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesByImageResponseUnmarshaller.Instance;

            return Invoke<SearchFacesByImageResponse>(request, options);
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
        public virtual IAsyncResult BeginSearchFacesByImage(SearchFacesByImageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFacesByImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesByImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchFacesByImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchFacesByImage.</param>
        /// 
        /// <returns>Returns a  SearchFacesByImageResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFacesByImage">REST API Reference for SearchFacesByImage Operation</seealso>
        public virtual SearchFacesByImageResponse EndSearchFacesByImage(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchFacesByImageResponse>(asyncResult);
        }

        #endregion
        
        #region  StartCelebrityRecognition

        /// <summary>
        /// Starts asynchronous recognition of celebrities in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect celebrities in a video must be stored in an Amazon
        /// S3 bucket. Use <a>Video</a> to specify the bucket name and the filename of the video.
        /// <code>StartCelebrityRecognition</code> returns a job identifier (<code>JobId</code>)
        /// which you use to get the results of the analysis. When celebrity recognition analysis
        /// is finished, Amazon Rekognition Video publishes a completion status to the Amazon
        /// Simple Notification Service topic that you specify in <code>NotificationChannel</code>.
        /// To get the results of the celebrity recognition analysis, first check that the status
        /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetCelebrityRecognition</a>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartCelebrityRecognition</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Recognizing Celebrities in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCelebrityRecognition service method.</param>
        /// 
        /// <returns>The response from the StartCelebrityRecognition service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartCelebrityRecognition">REST API Reference for StartCelebrityRecognition Operation</seealso>
        public virtual StartCelebrityRecognitionResponse StartCelebrityRecognition(StartCelebrityRecognitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCelebrityRecognitionResponseUnmarshaller.Instance;

            return Invoke<StartCelebrityRecognitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCelebrityRecognition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCelebrityRecognition operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCelebrityRecognition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartCelebrityRecognition">REST API Reference for StartCelebrityRecognition Operation</seealso>
        public virtual IAsyncResult BeginStartCelebrityRecognition(StartCelebrityRecognitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCelebrityRecognitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCelebrityRecognition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCelebrityRecognition.</param>
        /// 
        /// <returns>Returns a  StartCelebrityRecognitionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartCelebrityRecognition">REST API Reference for StartCelebrityRecognition Operation</seealso>
        public virtual StartCelebrityRecognitionResponse EndStartCelebrityRecognition(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCelebrityRecognitionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartContentModeration

        /// <summary>
        /// Starts asynchronous detection of unsafe content in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can moderate content in a video stored in an Amazon S3 bucket.
        /// Use <a>Video</a> to specify the bucket name and the filename of the video. <code>StartContentModeration</code>
        /// returns a job identifier (<code>JobId</code>) which you use to get the results of
        /// the analysis. When unsafe content analysis is finished, Amazon Rekognition Video publishes
        /// a completion status to the Amazon Simple Notification Service topic that you specify
        /// in <code>NotificationChannel</code>.
        /// </para>
        ///  
        /// <para>
        /// To get the results of the unsafe content analysis, first check that the status value
        /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetContentModeration</a>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartContentModeration</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting Unsafe Content in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContentModeration service method.</param>
        /// 
        /// <returns>The response from the StartContentModeration service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartContentModeration">REST API Reference for StartContentModeration Operation</seealso>
        public virtual StartContentModerationResponse StartContentModeration(StartContentModerationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContentModerationResponseUnmarshaller.Instance;

            return Invoke<StartContentModerationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartContentModeration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartContentModeration operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartContentModeration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartContentModeration">REST API Reference for StartContentModeration Operation</seealso>
        public virtual IAsyncResult BeginStartContentModeration(StartContentModerationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContentModerationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartContentModeration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartContentModeration.</param>
        /// 
        /// <returns>Returns a  StartContentModerationResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartContentModeration">REST API Reference for StartContentModeration Operation</seealso>
        public virtual StartContentModerationResponse EndStartContentModeration(IAsyncResult asyncResult)
        {
            return EndInvoke<StartContentModerationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFaceDetection

        /// <summary>
        /// Starts asynchronous detection of faces in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect faces in a video stored in an Amazon S3 bucket.
        /// Use <a>Video</a> to specify the bucket name and the filename of the video. <code>StartFaceDetection</code>
        /// returns a job identifier (<code>JobId</code>) that you use to get the results of the
        /// operation. When face detection is finished, Amazon Rekognition Video publishes a completion
        /// status to the Amazon Simple Notification Service topic that you specify in <code>NotificationChannel</code>.
        /// To get the results of the face detection operation, first check that the status value
        /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetFaceDetection</a>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartFaceDetection</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting Faces in a Stored Video in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFaceDetection service method.</param>
        /// 
        /// <returns>The response from the StartFaceDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceDetection">REST API Reference for StartFaceDetection Operation</seealso>
        public virtual StartFaceDetectionResponse StartFaceDetection(StartFaceDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceDetectionResponseUnmarshaller.Instance;

            return Invoke<StartFaceDetectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFaceDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFaceDetection operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFaceDetection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceDetection">REST API Reference for StartFaceDetection Operation</seealso>
        public virtual IAsyncResult BeginStartFaceDetection(StartFaceDetectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceDetectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartFaceDetection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFaceDetection.</param>
        /// 
        /// <returns>Returns a  StartFaceDetectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceDetection">REST API Reference for StartFaceDetection Operation</seealso>
        public virtual StartFaceDetectionResponse EndStartFaceDetection(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFaceDetectionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFaceSearch

        /// <summary>
        /// Starts the asynchronous search for faces in a collection that match the faces of persons
        /// detected in a stored video.
        /// 
        ///  
        /// <para>
        /// The video must be stored in an Amazon S3 bucket. Use <a>Video</a> to specify the bucket
        /// name and the filename of the video. <code>StartFaceSearch</code> returns a job identifier
        /// (<code>JobId</code>) which you use to get the search results once the search has completed.
        /// When searching is finished, Amazon Rekognition Video publishes a completion status
        /// to the Amazon Simple Notification Service topic that you specify in <code>NotificationChannel</code>.
        /// To get the search results, first check that the status value published to the Amazon
        /// SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetFaceSearch</a> and pass the
        /// job identifier (<code>JobId</code>) from the initial call to <code>StartFaceSearch</code>.
        /// For more information, see <a>procedure-person-search-videos</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFaceSearch service method.</param>
        /// 
        /// <returns>The response from the StartFaceSearch service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceSearch">REST API Reference for StartFaceSearch Operation</seealso>
        public virtual StartFaceSearchResponse StartFaceSearch(StartFaceSearchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceSearchResponseUnmarshaller.Instance;

            return Invoke<StartFaceSearchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFaceSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFaceSearch operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFaceSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceSearch">REST API Reference for StartFaceSearch Operation</seealso>
        public virtual IAsyncResult BeginStartFaceSearch(StartFaceSearchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceSearchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartFaceSearch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFaceSearch.</param>
        /// 
        /// <returns>Returns a  StartFaceSearchResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceSearch">REST API Reference for StartFaceSearch Operation</seealso>
        public virtual StartFaceSearchResponse EndStartFaceSearch(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFaceSearchResponse>(asyncResult);
        }

        #endregion
        
        #region  StartLabelDetection

        /// <summary>
        /// Starts asynchronous detection of labels in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect labels in a video. Labels are instances of real-world
        /// entities. This includes objects like flower, tree, and table; events like wedding,
        /// graduation, and birthday party; concepts like landscape, evening, and nature; and
        /// activities like a person getting out of a car or a person skiing.
        /// </para>
        ///  
        /// <para>
        /// The video must be stored in an Amazon S3 bucket. Use <a>Video</a> to specify the bucket
        /// name and the filename of the video. <code>StartLabelDetection</code> returns a job
        /// identifier (<code>JobId</code>) which you use to get the results of the operation.
        /// When label detection is finished, Amazon Rekognition Video publishes a completion
        /// status to the Amazon Simple Notification Service topic that you specify in <code>NotificationChannel</code>.
        /// </para>
        ///  
        /// <para>
        /// To get the results of the label detection operation, first check that the status value
        /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetLabelDetection</a>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartLabelDetection</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLabelDetection service method.</param>
        /// 
        /// <returns>The response from the StartLabelDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartLabelDetection">REST API Reference for StartLabelDetection Operation</seealso>
        public virtual StartLabelDetectionResponse StartLabelDetection(StartLabelDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLabelDetectionResponseUnmarshaller.Instance;

            return Invoke<StartLabelDetectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartLabelDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLabelDetection operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartLabelDetection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartLabelDetection">REST API Reference for StartLabelDetection Operation</seealso>
        public virtual IAsyncResult BeginStartLabelDetection(StartLabelDetectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLabelDetectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartLabelDetection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartLabelDetection.</param>
        /// 
        /// <returns>Returns a  StartLabelDetectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartLabelDetection">REST API Reference for StartLabelDetection Operation</seealso>
        public virtual StartLabelDetectionResponse EndStartLabelDetection(IAsyncResult asyncResult)
        {
            return EndInvoke<StartLabelDetectionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartPersonTracking

        /// <summary>
        /// Starts the asynchronous tracking of a person's path in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can track the path of people in a video stored in an Amazon
        /// S3 bucket. Use <a>Video</a> to specify the bucket name and the filename of the video.
        /// <code>StartPersonTracking</code> returns a job identifier (<code>JobId</code>) which
        /// you use to get the results of the operation. When label detection is finished, Amazon
        /// Rekognition publishes a completion status to the Amazon Simple Notification Service
        /// topic that you specify in <code>NotificationChannel</code>. 
        /// </para>
        ///  
        /// <para>
        /// To get the results of the person detection operation, first check that the status
        /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <a>GetPersonTracking</a>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartPersonTracking</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPersonTracking service method.</param>
        /// 
        /// <returns>The response from the StartPersonTracking service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartPersonTracking">REST API Reference for StartPersonTracking Operation</seealso>
        public virtual StartPersonTrackingResponse StartPersonTracking(StartPersonTrackingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPersonTrackingResponseUnmarshaller.Instance;

            return Invoke<StartPersonTrackingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartPersonTracking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPersonTracking operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPersonTracking
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartPersonTracking">REST API Reference for StartPersonTracking Operation</seealso>
        public virtual IAsyncResult BeginStartPersonTracking(StartPersonTrackingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPersonTrackingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartPersonTracking operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPersonTracking.</param>
        /// 
        /// <returns>Returns a  StartPersonTrackingResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartPersonTracking">REST API Reference for StartPersonTracking Operation</seealso>
        public virtual StartPersonTrackingResponse EndStartPersonTracking(IAsyncResult asyncResult)
        {
            return EndInvoke<StartPersonTrackingResponse>(asyncResult);
        }

        #endregion
        
        #region  StartProjectVersion

        /// <summary>
        /// Starts the running of the version of a model. Starting a model takes a while to complete.
        /// To check the current state of the model, use <a>DescribeProjectVersions</a>.
        /// 
        ///  
        /// <para>
        /// Once the model is running, you can detect custom labels in new images by calling <a>DetectCustomLabels</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You are charged for the amount of time that the model is running. To stop a running
        /// model, call <a>StopProjectVersion</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:StartProjectVersion</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProjectVersion service method.</param>
        /// 
        /// <returns>The response from the StartProjectVersion service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartProjectVersion">REST API Reference for StartProjectVersion Operation</seealso>
        public virtual StartProjectVersionResponse StartProjectVersion(StartProjectVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProjectVersionResponseUnmarshaller.Instance;

            return Invoke<StartProjectVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartProjectVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartProjectVersion operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartProjectVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartProjectVersion">REST API Reference for StartProjectVersion Operation</seealso>
        public virtual IAsyncResult BeginStartProjectVersion(StartProjectVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartProjectVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartProjectVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartProjectVersion.</param>
        /// 
        /// <returns>Returns a  StartProjectVersionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartProjectVersion">REST API Reference for StartProjectVersion Operation</seealso>
        public virtual StartProjectVersionResponse EndStartProjectVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<StartProjectVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSegmentDetection

        /// <summary>
        /// Starts asynchronous detection of segment detection in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect segments in a video stored in an Amazon S3 bucket.
        /// Use <a>Video</a> to specify the bucket name and the filename of the video. <code>StartSegmentDetection</code>
        /// returns a job identifier (<code>JobId</code>) which you use to get the results of
        /// the operation. When segment detection is finished, Amazon Rekognition Video publishes
        /// a completion status to the Amazon Simple Notification Service topic that you specify
        /// in <code>NotificationChannel</code>.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>Filters</code> (<a>StartSegmentDetectionFilters</a>) input parameter
        /// to specify the minimum detection confidence returned in the response. Within <code>Filters</code>,
        /// use <code>ShotFilter</code> (<a>StartShotDetectionFilter</a>) to filter detected shots.
        /// Use <code>TechnicalCueFilter</code> (<a>StartTechnicalCueDetectionFilter</a>) to filter
        /// technical cues. 
        /// </para>
        ///  
        /// <para>
        /// To get the results of the segment detection operation, first check that the status
        /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. if so, call <a>GetSegmentDetection</a>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartSegmentDetection</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting Video Segments in Stored Video in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSegmentDetection service method.</param>
        /// 
        /// <returns>The response from the StartSegmentDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartSegmentDetection">REST API Reference for StartSegmentDetection Operation</seealso>
        public virtual StartSegmentDetectionResponse StartSegmentDetection(StartSegmentDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSegmentDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSegmentDetectionResponseUnmarshaller.Instance;

            return Invoke<StartSegmentDetectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSegmentDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSegmentDetection operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSegmentDetection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartSegmentDetection">REST API Reference for StartSegmentDetection Operation</seealso>
        public virtual IAsyncResult BeginStartSegmentDetection(StartSegmentDetectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSegmentDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSegmentDetectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSegmentDetection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSegmentDetection.</param>
        /// 
        /// <returns>Returns a  StartSegmentDetectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartSegmentDetection">REST API Reference for StartSegmentDetection Operation</seealso>
        public virtual StartSegmentDetectionResponse EndStartSegmentDetection(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSegmentDetectionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartStreamProcessor

        /// <summary>
        /// Starts processing a stream processor. You create a stream processor by calling <a>CreateStreamProcessor</a>.
        /// To tell <code>StartStreamProcessor</code> which stream processor to start, use the
        /// value of the <code>Name</code> field specified in the call to <code>CreateStreamProcessor</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStreamProcessor service method.</param>
        /// 
        /// <returns>The response from the StartStreamProcessor service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartStreamProcessor">REST API Reference for StartStreamProcessor Operation</seealso>
        public virtual StartStreamProcessorResponse StartStreamProcessor(StartStreamProcessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<StartStreamProcessorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStreamProcessor operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartStreamProcessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartStreamProcessor">REST API Reference for StartStreamProcessor Operation</seealso>
        public virtual IAsyncResult BeginStartStreamProcessor(StartStreamProcessorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamProcessorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartStreamProcessor.</param>
        /// 
        /// <returns>Returns a  StartStreamProcessorResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartStreamProcessor">REST API Reference for StartStreamProcessor Operation</seealso>
        public virtual StartStreamProcessorResponse EndStartStreamProcessor(IAsyncResult asyncResult)
        {
            return EndInvoke<StartStreamProcessorResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTextDetection

        /// <summary>
        /// Starts asynchronous detection of text in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect text in a video stored in an Amazon S3 bucket.
        /// Use <a>Video</a> to specify the bucket name and the filename of the video. <code>StartTextDetection</code>
        /// returns a job identifier (<code>JobId</code>) which you use to get the results of
        /// the operation. When text detection is finished, Amazon Rekognition Video publishes
        /// a completion status to the Amazon Simple Notification Service topic that you specify
        /// in <code>NotificationChannel</code>.
        /// </para>
        ///  
        /// <para>
        /// To get the results of the text detection operation, first check that the status value
        /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. if so, call <a>GetTextDetection</a>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartTextDetection</code>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTextDetection service method.</param>
        /// 
        /// <returns>The response from the StartTextDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 10GB. The maximum duration is 6 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartTextDetection">REST API Reference for StartTextDetection Operation</seealso>
        public virtual StartTextDetectionResponse StartTextDetection(StartTextDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTextDetectionResponseUnmarshaller.Instance;

            return Invoke<StartTextDetectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTextDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTextDetection operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTextDetection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartTextDetection">REST API Reference for StartTextDetection Operation</seealso>
        public virtual IAsyncResult BeginStartTextDetection(StartTextDetectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTextDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTextDetectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTextDetection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTextDetection.</param>
        /// 
        /// <returns>Returns a  StartTextDetectionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartTextDetection">REST API Reference for StartTextDetection Operation</seealso>
        public virtual StartTextDetectionResponse EndStartTextDetection(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTextDetectionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopProjectVersion

        /// <summary>
        /// Stops a running model. The operation might take a while to complete. To check the
        /// current status, call <a>DescribeProjectVersions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopProjectVersion service method.</param>
        /// 
        /// <returns>The response from the StopProjectVersion service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopProjectVersion">REST API Reference for StopProjectVersion Operation</seealso>
        public virtual StopProjectVersionResponse StopProjectVersion(StopProjectVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopProjectVersionResponseUnmarshaller.Instance;

            return Invoke<StopProjectVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopProjectVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopProjectVersion operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopProjectVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopProjectVersion">REST API Reference for StopProjectVersion Operation</seealso>
        public virtual IAsyncResult BeginStopProjectVersion(StopProjectVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopProjectVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopProjectVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopProjectVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopProjectVersion.</param>
        /// 
        /// <returns>Returns a  StopProjectVersionResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopProjectVersion">REST API Reference for StopProjectVersion Operation</seealso>
        public virtual StopProjectVersionResponse EndStopProjectVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<StopProjectVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopStreamProcessor

        /// <summary>
        /// Stops a running stream processor that was created by <a>CreateStreamProcessor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStreamProcessor service method.</param>
        /// 
        /// <returns>The response from the StopStreamProcessor service method, as returned by Rekognition.</returns>
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
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// The specified resource is already being used.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopStreamProcessor">REST API Reference for StopStreamProcessor Operation</seealso>
        public virtual StopStreamProcessorResponse StopStreamProcessor(StopStreamProcessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<StopStreamProcessorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStreamProcessor operation on AmazonRekognitionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopStreamProcessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopStreamProcessor">REST API Reference for StopStreamProcessor Operation</seealso>
        public virtual IAsyncResult BeginStopStreamProcessor(StopStreamProcessorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamProcessorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopStreamProcessor.</param>
        /// 
        /// <returns>Returns a  StopStreamProcessorResult from Rekognition.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopStreamProcessor">REST API Reference for StopStreamProcessor Operation</seealso>
        public virtual StopStreamProcessorResponse EndStopStreamProcessor(IAsyncResult asyncResult)
        {
            return EndInvoke<StopStreamProcessorResponse>(asyncResult);
        }

        #endregion
        
    }
}