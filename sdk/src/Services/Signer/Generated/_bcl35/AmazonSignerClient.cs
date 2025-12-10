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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Signer.Model;
using Amazon.Signer.Model.Internal.MarshallTransformations;
using Amazon.Signer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Signer
{
    /// <summary>
    /// <para>Implementation for accessing Signer</para>
    ///
    /// AWS Signer is a fully managed code-signing service to help you ensure the trust and
    /// integrity of your code. 
    /// 
    ///  
    /// <para>
    /// Signer supports the following applications:
    /// </para>
    ///  
    /// <para>
    /// With code signing for AWS Lambda, you can sign <a href="http://docs.aws.amazon.com/lambda/latest/dg/">AWS
    /// Lambda</a> deployment packages. Integrated support is provided for <a href="http://docs.aws.amazon.com/AmazonS3/latest/gsg/">Amazon
    /// S3</a>, <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/">Amazon
    /// CloudWatch</a>, and <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/">AWS
    /// CloudTrail</a>. In order to sign code, you create a signing profile and then use Signer
    /// to sign Lambda zip files in S3. 
    /// </para>
    ///  
    /// <para>
    /// With code signing for IoT, you can sign code for any IoT device that is supported
    /// by AWS. IoT code signing is available for <a href="http://docs.aws.amazon.com/freertos/latest/userguide/">Amazon
    /// FreeRTOS</a> and <a href="http://docs.aws.amazon.com/iot/latest/developerguide/">AWS
    /// IoT Device Management</a>, and is integrated with <a href="http://docs.aws.amazon.com/acm/latest/userguide/">AWS
    /// Certificate Manager (ACM)</a>. In order to sign code, you import a third-party code-signing
    /// certificate using ACM, and use that to sign updates in Amazon FreeRTOS and AWS IoT
    /// Device Management. 
    /// </para>
    ///  
    /// <para>
    /// With Signer and the Notation CLI from the <a href="https://notaryproject.dev/">Notary&#x2028;
    /// Project</a>, you can sign container images stored in a container registry such as
    /// Amazon Elastic Container Registry (ECR). The signatures are stored in the registry
    /// alongside the images, where they are available for verifying image authenticity and
    /// integrity.
    /// </para>
    ///  
    /// <para>
    /// For more information about Signer, see the <a href="http://docs.aws.amazon.com/signer/latest/developerguide/Welcome.html">AWS
    /// Signer Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonSignerClient : AmazonServiceClient, IAmazonSigner
    {
        private static IServiceMetadata serviceMetadata = new AmazonSignerMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ISignerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISignerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SignerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonSignerClient with the credentials loaded from the application's
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
        public AmazonSignerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSignerConfig()) { }

        /// <summary>
        /// Constructs AmazonSignerClient with the credentials loaded from the application's
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
        public AmazonSignerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSignerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSignerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(AmazonSignerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonSignerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSignerClient(AWSCredentials credentials)
            : this(credentials, new AmazonSignerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSignerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Credentials and an
        /// AmazonSignerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(AWSCredentials credentials, AmazonSignerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSignerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSignerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSignerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSignerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSignerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSignerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSignerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSignerConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSignerEndpointResolver());
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


        #region  AddProfilePermission

        /// <summary>
        /// Adds cross-account permissions to a signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddProfilePermission service method.</param>
        /// 
        /// <returns>The response from the AddProfilePermission service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ConflictException">
        /// The resource encountered a conflicting state.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ServiceLimitExceededException">
        /// The client is making a request that exceeds service limits.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/AddProfilePermission">REST API Reference for AddProfilePermission Operation</seealso>
        public virtual AddProfilePermissionResponse AddProfilePermission(AddProfilePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddProfilePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddProfilePermissionResponseUnmarshaller.Instance;

            return Invoke<AddProfilePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddProfilePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddProfilePermission operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddProfilePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/AddProfilePermission">REST API Reference for AddProfilePermission Operation</seealso>
        public virtual IAsyncResult BeginAddProfilePermission(AddProfilePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddProfilePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddProfilePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddProfilePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddProfilePermission.</param>
        /// 
        /// <returns>Returns a  AddProfilePermissionResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/AddProfilePermission">REST API Reference for AddProfilePermission Operation</seealso>
        public virtual AddProfilePermissionResponse EndAddProfilePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<AddProfilePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelSigningProfile

        /// <summary>
        /// Changes the state of an <c>ACTIVE</c> signing profile to <c>CANCELED</c>. A canceled
        /// profile is still viewable with the <c>ListSigningProfiles</c> operation, but it cannot
        /// perform new signing jobs. See <a href="https://docs.aws.amazon.com/signer/latest/developerguide/retention.html">Data
        /// Retention</a> for more information on scheduled deletion of a canceled signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSigningProfile service method.</param>
        /// 
        /// <returns>The response from the CancelSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/CancelSigningProfile">REST API Reference for CancelSigningProfile Operation</seealso>
        public virtual CancelSigningProfileResponse CancelSigningProfile(CancelSigningProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSigningProfileResponseUnmarshaller.Instance;

            return Invoke<CancelSigningProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSigningProfile operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSigningProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/CancelSigningProfile">REST API Reference for CancelSigningProfile Operation</seealso>
        public virtual IAsyncResult BeginCancelSigningProfile(CancelSigningProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSigningProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSigningProfile.</param>
        /// 
        /// <returns>Returns a  CancelSigningProfileResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/CancelSigningProfile">REST API Reference for CancelSigningProfile Operation</seealso>
        public virtual CancelSigningProfileResponse EndCancelSigningProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelSigningProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSigningJob

        /// <summary>
        /// Returns information about a specific code signing job. You specify the job by using
        /// the <c>jobId</c> value that is returned by the <a>StartSigningJob</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSigningJob service method.</param>
        /// 
        /// <returns>The response from the DescribeSigningJob service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/DescribeSigningJob">REST API Reference for DescribeSigningJob Operation</seealso>
        public virtual DescribeSigningJobResponse DescribeSigningJob(DescribeSigningJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSigningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSigningJobResponseUnmarshaller.Instance;

            return Invoke<DescribeSigningJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSigningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSigningJob operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSigningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/DescribeSigningJob">REST API Reference for DescribeSigningJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeSigningJob(DescribeSigningJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSigningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSigningJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSigningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSigningJob.</param>
        /// 
        /// <returns>Returns a  DescribeSigningJobResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/DescribeSigningJob">REST API Reference for DescribeSigningJob Operation</seealso>
        public virtual DescribeSigningJobResponse EndDescribeSigningJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSigningJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRevocationStatus

        /// <summary>
        /// Retrieves the revocation status of one or more of the signing profile, signing job,
        /// and signing certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevocationStatus service method.</param>
        /// 
        /// <returns>The response from the GetRevocationStatus service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetRevocationStatus">REST API Reference for GetRevocationStatus Operation</seealso>
        public virtual GetRevocationStatusResponse GetRevocationStatus(GetRevocationStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevocationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevocationStatusResponseUnmarshaller.Instance;

            return Invoke<GetRevocationStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRevocationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRevocationStatus operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRevocationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetRevocationStatus">REST API Reference for GetRevocationStatus Operation</seealso>
        public virtual IAsyncResult BeginGetRevocationStatus(GetRevocationStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevocationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevocationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRevocationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRevocationStatus.</param>
        /// 
        /// <returns>Returns a  GetRevocationStatusResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetRevocationStatus">REST API Reference for GetRevocationStatus Operation</seealso>
        public virtual GetRevocationStatusResponse EndGetRevocationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRevocationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSigningPlatform

        /// <summary>
        /// Returns information on a specific signing platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSigningPlatform service method.</param>
        /// 
        /// <returns>The response from the GetSigningPlatform service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningPlatform">REST API Reference for GetSigningPlatform Operation</seealso>
        public virtual GetSigningPlatformResponse GetSigningPlatform(GetSigningPlatformRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSigningPlatformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningPlatformResponseUnmarshaller.Instance;

            return Invoke<GetSigningPlatformResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningPlatform operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningPlatform operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSigningPlatform
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningPlatform">REST API Reference for GetSigningPlatform Operation</seealso>
        public virtual IAsyncResult BeginGetSigningPlatform(GetSigningPlatformRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSigningPlatformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningPlatformResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSigningPlatform operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSigningPlatform.</param>
        /// 
        /// <returns>Returns a  GetSigningPlatformResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningPlatform">REST API Reference for GetSigningPlatform Operation</seealso>
        public virtual GetSigningPlatformResponse EndGetSigningPlatform(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSigningPlatformResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSigningProfile

        /// <summary>
        /// Returns information on a specific signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSigningProfile service method.</param>
        /// 
        /// <returns>The response from the GetSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningProfile">REST API Reference for GetSigningProfile Operation</seealso>
        public virtual GetSigningProfileResponse GetSigningProfile(GetSigningProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningProfileResponseUnmarshaller.Instance;

            return Invoke<GetSigningProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningProfile operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSigningProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningProfile">REST API Reference for GetSigningProfile Operation</seealso>
        public virtual IAsyncResult BeginGetSigningProfile(GetSigningProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSigningProfile.</param>
        /// 
        /// <returns>Returns a  GetSigningProfileResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningProfile">REST API Reference for GetSigningProfile Operation</seealso>
        public virtual GetSigningProfileResponse EndGetSigningProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSigningProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProfilePermissions

        /// <summary>
        /// Lists the cross-account permissions associated with a signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfilePermissions service method.</param>
        /// 
        /// <returns>The response from the ListProfilePermissions service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListProfilePermissions">REST API Reference for ListProfilePermissions Operation</seealso>
        public virtual ListProfilePermissionsResponse ListProfilePermissions(ListProfilePermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfilePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilePermissionsResponseUnmarshaller.Instance;

            return Invoke<ListProfilePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfilePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfilePermissions operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfilePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListProfilePermissions">REST API Reference for ListProfilePermissions Operation</seealso>
        public virtual IAsyncResult BeginListProfilePermissions(ListProfilePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfilePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfilePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfilePermissions.</param>
        /// 
        /// <returns>Returns a  ListProfilePermissionsResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListProfilePermissions">REST API Reference for ListProfilePermissions Operation</seealso>
        public virtual ListProfilePermissionsResponse EndListProfilePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProfilePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSigningJobs

        /// <summary>
        /// Lists all your signing jobs. You can use the <c>maxResults</c> parameter to limit
        /// the number of signing jobs that are returned in the response. If additional jobs remain
        /// to be listed, AWS Signer returns a <c>nextToken</c> value. Use this value in subsequent
        /// calls to <c>ListSigningJobs</c> to fetch the remaining values. You can continue calling
        /// <c>ListSigningJobs</c> with your <c>maxResults</c> parameter and with new values that
        /// Signer returns in the <c>nextToken</c> parameter until all of your signing jobs have
        /// been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningJobs service method.</param>
        /// 
        /// <returns>The response from the ListSigningJobs service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningJobs">REST API Reference for ListSigningJobs Operation</seealso>
        public virtual ListSigningJobsResponse ListSigningJobs(ListSigningJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSigningJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningJobsResponseUnmarshaller.Instance;

            return Invoke<ListSigningJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningJobs operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSigningJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningJobs">REST API Reference for ListSigningJobs Operation</seealso>
        public virtual IAsyncResult BeginListSigningJobs(ListSigningJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSigningJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSigningJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningJobs.</param>
        /// 
        /// <returns>Returns a  ListSigningJobsResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningJobs">REST API Reference for ListSigningJobs Operation</seealso>
        public virtual ListSigningJobsResponse EndListSigningJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSigningJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSigningPlatforms

        /// <summary>
        /// Lists all signing platforms available in AWS Signer that match the request parameters.
        /// If additional jobs remain to be listed, Signer returns a <c>nextToken</c> value. Use
        /// this value in subsequent calls to <c>ListSigningJobs</c> to fetch the remaining values.
        /// You can continue calling <c>ListSigningJobs</c> with your <c>maxResults</c> parameter
        /// and with new values that Signer returns in the <c>nextToken</c> parameter until all
        /// of your signing jobs have been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningPlatforms service method.</param>
        /// 
        /// <returns>The response from the ListSigningPlatforms service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningPlatforms">REST API Reference for ListSigningPlatforms Operation</seealso>
        public virtual ListSigningPlatformsResponse ListSigningPlatforms(ListSigningPlatformsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSigningPlatformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningPlatformsResponseUnmarshaller.Instance;

            return Invoke<ListSigningPlatformsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningPlatforms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningPlatforms operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSigningPlatforms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningPlatforms">REST API Reference for ListSigningPlatforms Operation</seealso>
        public virtual IAsyncResult BeginListSigningPlatforms(ListSigningPlatformsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSigningPlatformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningPlatformsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSigningPlatforms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningPlatforms.</param>
        /// 
        /// <returns>Returns a  ListSigningPlatformsResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningPlatforms">REST API Reference for ListSigningPlatforms Operation</seealso>
        public virtual ListSigningPlatformsResponse EndListSigningPlatforms(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSigningPlatformsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSigningProfiles

        /// <summary>
        /// Lists all available signing profiles in your AWS account. Returns only profiles with
        /// an <c>ACTIVE</c> status unless the <c>includeCanceled</c> request field is set to
        /// <c>true</c>. If additional jobs remain to be listed, AWS Signer returns a <c>nextToken</c>
        /// value. Use this value in subsequent calls to <c>ListSigningJobs</c> to fetch the remaining
        /// values. You can continue calling <c>ListSigningJobs</c> with your <c>maxResults</c>
        /// parameter and with new values that Signer returns in the <c>nextToken</c> parameter
        /// until all of your signing jobs have been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningProfiles service method.</param>
        /// 
        /// <returns>The response from the ListSigningProfiles service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningProfiles">REST API Reference for ListSigningProfiles Operation</seealso>
        public virtual ListSigningProfilesResponse ListSigningProfiles(ListSigningProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSigningProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningProfilesResponseUnmarshaller.Instance;

            return Invoke<ListSigningProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningProfiles operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSigningProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningProfiles">REST API Reference for ListSigningProfiles Operation</seealso>
        public virtual IAsyncResult BeginListSigningProfiles(ListSigningProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSigningProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSigningProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningProfiles.</param>
        /// 
        /// <returns>Returns a  ListSigningProfilesResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningProfiles">REST API Reference for ListSigningProfiles Operation</seealso>
        public virtual ListSigningProfilesResponse EndListSigningProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSigningProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of the tags associated with a signing profile resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.BadRequestException">
        /// The request contains invalid parameters for the ARN or tags. This exception also occurs
        /// when you call a tagging API on a cancelled signing profile.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.NotFoundException">
        /// The signing profile was not found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutSigningProfile

        /// <summary>
        /// Creates a signing profile. A signing profile is a code-signing template that can be
        /// used to carry out a pre-defined signing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSigningProfile service method.</param>
        /// 
        /// <returns>The response from the PutSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/PutSigningProfile">REST API Reference for PutSigningProfile Operation</seealso>
        public virtual PutSigningProfileResponse PutSigningProfile(PutSigningProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSigningProfileResponseUnmarshaller.Instance;

            return Invoke<PutSigningProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSigningProfile operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSigningProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/PutSigningProfile">REST API Reference for PutSigningProfile Operation</seealso>
        public virtual IAsyncResult BeginPutSigningProfile(PutSigningProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSigningProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSigningProfile.</param>
        /// 
        /// <returns>Returns a  PutSigningProfileResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/PutSigningProfile">REST API Reference for PutSigningProfile Operation</seealso>
        public virtual PutSigningProfileResponse EndPutSigningProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSigningProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveProfilePermission

        /// <summary>
        /// Removes cross-account permissions from a signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveProfilePermission service method.</param>
        /// 
        /// <returns>The response from the RemoveProfilePermission service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ConflictException">
        /// The resource encountered a conflicting state.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RemoveProfilePermission">REST API Reference for RemoveProfilePermission Operation</seealso>
        public virtual RemoveProfilePermissionResponse RemoveProfilePermission(RemoveProfilePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveProfilePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveProfilePermissionResponseUnmarshaller.Instance;

            return Invoke<RemoveProfilePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveProfilePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveProfilePermission operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveProfilePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RemoveProfilePermission">REST API Reference for RemoveProfilePermission Operation</seealso>
        public virtual IAsyncResult BeginRemoveProfilePermission(RemoveProfilePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveProfilePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveProfilePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveProfilePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveProfilePermission.</param>
        /// 
        /// <returns>Returns a  RemoveProfilePermissionResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RemoveProfilePermission">REST API Reference for RemoveProfilePermission Operation</seealso>
        public virtual RemoveProfilePermissionResponse EndRemoveProfilePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveProfilePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeSignature

        /// <summary>
        /// Changes the state of a signing job to <c>REVOKED</c>. This indicates that the signature
        /// is no longer valid.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSignature service method.</param>
        /// 
        /// <returns>The response from the RevokeSignature service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RevokeSignature">REST API Reference for RevokeSignature Operation</seealso>
        public virtual RevokeSignatureResponse RevokeSignature(RevokeSignatureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeSignatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSignatureResponseUnmarshaller.Instance;

            return Invoke<RevokeSignatureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSignature operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSignature operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeSignature
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RevokeSignature">REST API Reference for RevokeSignature Operation</seealso>
        public virtual IAsyncResult BeginRevokeSignature(RevokeSignatureRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeSignatureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSignatureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSignature operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSignature.</param>
        /// 
        /// <returns>Returns a  RevokeSignatureResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RevokeSignature">REST API Reference for RevokeSignature Operation</seealso>
        public virtual RevokeSignatureResponse EndRevokeSignature(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeSignatureResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeSigningProfile

        /// <summary>
        /// Changes the state of a signing profile to <c>REVOKED</c>. This indicates that signatures
        /// generated using the signing profile after an effective start date are no longer valid.
        /// A revoked profile is still viewable with the <c>ListSigningProfiles</c> operation,
        /// but it cannot perform new signing jobs. See <a href="https://docs.aws.amazon.com/signer/latest/developerguide/retention.html">Data
        /// Retention</a> for more information on scheduled deletion of a revoked signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSigningProfile service method.</param>
        /// 
        /// <returns>The response from the RevokeSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RevokeSigningProfile">REST API Reference for RevokeSigningProfile Operation</seealso>
        public virtual RevokeSigningProfileResponse RevokeSigningProfile(RevokeSigningProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSigningProfileResponseUnmarshaller.Instance;

            return Invoke<RevokeSigningProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSigningProfile operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeSigningProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RevokeSigningProfile">REST API Reference for RevokeSigningProfile Operation</seealso>
        public virtual IAsyncResult BeginRevokeSigningProfile(RevokeSigningProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSigningProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSigningProfile.</param>
        /// 
        /// <returns>Returns a  RevokeSigningProfileResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RevokeSigningProfile">REST API Reference for RevokeSigningProfile Operation</seealso>
        public virtual RevokeSigningProfileResponse EndRevokeSigningProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeSigningProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  SignPayload

        /// <summary>
        /// Signs a binary payload and returns a signature envelope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignPayload service method.</param>
        /// 
        /// <returns>The response from the SignPayload service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/SignPayload">REST API Reference for SignPayload Operation</seealso>
        public virtual SignPayloadResponse SignPayload(SignPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SignPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignPayloadResponseUnmarshaller.Instance;

            return Invoke<SignPayloadResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SignPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignPayload operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSignPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/SignPayload">REST API Reference for SignPayload Operation</seealso>
        public virtual IAsyncResult BeginSignPayload(SignPayloadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SignPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignPayloadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SignPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignPayload.</param>
        /// 
        /// <returns>Returns a  SignPayloadResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/SignPayload">REST API Reference for SignPayload Operation</seealso>
        public virtual SignPayloadResponse EndSignPayload(IAsyncResult asyncResult)
        {
            return EndInvoke<SignPayloadResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSigningJob

        /// <summary>
        /// Initiates a signing job to be performed on the code provided. Signing jobs are viewable
        /// by the <c>ListSigningJobs</c> operation. Note the following requirements: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  You must create an Amazon S3 source bucket. For more information, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/gsg/CreatingABucket.html">Creating
        /// a Bucket</a> in the <i>Amazon S3 Getting Started Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your S3 source bucket must be version enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must create an S3 destination bucket. AWS Signer uses your S3 destination bucket
        /// to write your signed code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specify the name of the source and destination buckets when calling the <c>StartSigningJob</c>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must ensure the S3 buckets are from the same Region as the signing profile. Cross-Region
        /// signing isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must also specify a request token that identifies your request to Signer.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can call the <a>DescribeSigningJob</a> and the <a>ListSigningJobs</a> actions
        /// after you call <c>StartSigningJob</c>.
        /// </para>
        ///  
        /// <para>
        /// For a Java example that shows how to use this action, see <a href="https://docs.aws.amazon.com/signer/latest/developerguide/api-startsigningjob.html">StartSigningJob</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSigningJob service method.</param>
        /// 
        /// <returns>The response from the StartSigningJob service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// Instead of this error, <c>TooManyRequestsException</c> should be used.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/StartSigningJob">REST API Reference for StartSigningJob Operation</seealso>
        public virtual StartSigningJobResponse StartSigningJob(StartSigningJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSigningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSigningJobResponseUnmarshaller.Instance;

            return Invoke<StartSigningJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSigningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSigningJob operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSigningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/StartSigningJob">REST API Reference for StartSigningJob Operation</seealso>
        public virtual IAsyncResult BeginStartSigningJob(StartSigningJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSigningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSigningJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSigningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSigningJob.</param>
        /// 
        /// <returns>Returns a  StartSigningJobResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/StartSigningJob">REST API Reference for StartSigningJob Operation</seealso>
        public virtual StartSigningJobResponse EndStartSigningJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSigningJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tags to a signing profile. Tags are labels that you can use to identify
        /// and organize your AWS resources. Each tag consists of a key and an optional value.
        /// To specify the signing profile, use its Amazon Resource Name (ARN). To specify the
        /// tag, use a key-value pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.BadRequestException">
        /// The request contains invalid parameters for the ARN or tags. This exception also occurs
        /// when you call a tagging API on a cancelled signing profile.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.NotFoundException">
        /// The signing profile was not found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from a signing profile. To remove the tags, specify a list
        /// of tag keys.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.BadRequestException">
        /// The request contains invalid parameters for the ARN or tags. This exception also occurs
        /// when you call a tagging API on a cancelled signing profile.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.NotFoundException">
        /// The signing profile was not found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSignerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Signer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonSignerEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}