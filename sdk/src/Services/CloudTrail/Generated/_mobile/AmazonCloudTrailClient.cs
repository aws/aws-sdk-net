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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudTrail.Model;
using Amazon.CloudTrail.Model.Internal.MarshallTransformations;
using Amazon.CloudTrail.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudTrail
{
    /// <summary>
    /// Implementation for accessing CloudTrail
    ///
    /// AWS CloudTrail 
    /// <para>
    /// This is the CloudTrail API Reference. It provides descriptions of actions, data types,
    /// common parameters, and common errors for CloudTrail.
    /// </para>
    ///  
    /// <para>
    /// CloudTrail is a web service that records AWS API calls for your AWS account and delivers
    /// log files to an Amazon S3 bucket. The recorded information includes the identity of
    /// the user, the start time of the AWS API call, the source IP address, the request parameters,
    /// and the response elements returned by the service.
    /// </para>
    ///  <note> 
    /// <para>
    /// As an alternative to the API, you can use one of the AWS SDKs, which consist of libraries
    /// and sample code for various programming languages and platforms (Java, Ruby, .NET,
    /// iOS, Android, etc.). The SDKs provide a convenient way to create programmatic access
    /// to AWSCloudTrail. For example, the SDKs take care of cryptographically signing requests,
    /// managing errors, and retrying requests automatically. For information about the AWS
    /// SDKs, including how to download and install them, see the <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services page</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// See the <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-user-guide.html">AWS
    /// CloudTrail User Guide</a> for information about the data that is included with each
    /// AWS API call listed in the log files.
    /// </para>
    /// </summary>
    public partial class AmazonCloudTrailClient : AmazonServiceClient, IAmazonCloudTrail
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudTrailMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        public AmazonCloudTrailClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudTrailConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        public AmazonCloudTrailClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudTrailConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(AmazonCloudTrailConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudTrailClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudTrailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudTrailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Credentials and an
        /// AmazonCloudTrailClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(AWSCredentials credentials, AmazonCloudTrailConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudTrailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudTrailConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudTrailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudTrailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudTrailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudTrailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudTrailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudTrailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudTrailClient Configuration Object</param>
        public AmazonCloudTrailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudTrailConfig clientConfig)
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


        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrail

        internal virtual CreateTrailResponse CreateTrail(CreateTrailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrailResponseUnmarshaller.Instance;

            return Invoke<CreateTrailResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateTrail">REST API Reference for CreateTrail Operation</seealso>
        public virtual Task<CreateTrailResponse> CreateTrailAsync(CreateTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrailResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrail

        internal virtual DeleteTrailResponse DeleteTrail(DeleteTrailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrailResponseUnmarshaller.Instance;

            return Invoke<DeleteTrailResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteTrail">REST API Reference for DeleteTrail Operation</seealso>
        public virtual Task<DeleteTrailResponse> DeleteTrailAsync(DeleteTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrailResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrails

        internal virtual DescribeTrailsResponse DescribeTrails()
        {
            return DescribeTrails(new DescribeTrailsRequest());
        }
        internal virtual DescribeTrailsResponse DescribeTrails(DescribeTrailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrailsResponseUnmarshaller.Instance;

            return Invoke<DescribeTrailsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves settings for the trail associated with the current region for your account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        public virtual Task<DescribeTrailsResponse> DescribeTrailsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeTrailsAsync(new DescribeTrailsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        public virtual Task<DescribeTrailsResponse> DescribeTrailsAsync(DescribeTrailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrailsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEventSelectors

        internal virtual GetEventSelectorsResponse GetEventSelectors(GetEventSelectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventSelectorsResponseUnmarshaller.Instance;

            return Invoke<GetEventSelectorsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEventSelectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventSelectors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventSelectors">REST API Reference for GetEventSelectors Operation</seealso>
        public virtual Task<GetEventSelectorsResponse> GetEventSelectorsAsync(GetEventSelectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventSelectorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventSelectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTrailStatus

        internal virtual GetTrailStatusResponse GetTrailStatus(GetTrailStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrailStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrailStatusResponseUnmarshaller.Instance;

            return Invoke<GetTrailStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrailStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrailStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrailStatus">REST API Reference for GetTrailStatus Operation</seealso>
        public virtual Task<GetTrailStatusResponse> GetTrailStatusAsync(GetTrailStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrailStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrailStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrailStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPublicKeys

        internal virtual ListPublicKeysResponse ListPublicKeys(ListPublicKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListPublicKeysResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual Task<ListPublicKeysResponse> ListPublicKeysAsync(ListPublicKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListPublicKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  LookupEvents

        internal virtual LookupEventsResponse LookupEvents(LookupEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LookupEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupEventsResponseUnmarshaller.Instance;

            return Invoke<LookupEventsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the LookupEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LookupEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/LookupEvents">REST API Reference for LookupEvents Operation</seealso>
        public virtual Task<LookupEventsResponse> LookupEventsAsync(LookupEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LookupEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupEventsResponseUnmarshaller.Instance;

            return InvokeAsync<LookupEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEventSelectors

        internal virtual PutEventSelectorsResponse PutEventSelectors(PutEventSelectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventSelectorsResponseUnmarshaller.Instance;

            return Invoke<PutEventSelectorsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutEventSelectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventSelectors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutEventSelectors">REST API Reference for PutEventSelectors Operation</seealso>
        public virtual Task<PutEventSelectorsResponse> PutEventSelectorsAsync(PutEventSelectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventSelectorsResponseUnmarshaller.Instance;

            return InvokeAsync<PutEventSelectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartLogging

        internal virtual StartLoggingResponse StartLogging(StartLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLoggingResponseUnmarshaller.Instance;

            return Invoke<StartLoggingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartLogging">REST API Reference for StartLogging Operation</seealso>
        public virtual Task<StartLoggingResponse> StartLoggingAsync(StartLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<StartLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopLogging

        internal virtual StopLoggingResponse StopLogging(StopLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLoggingResponseUnmarshaller.Instance;

            return Invoke<StopLoggingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopLogging">REST API Reference for StopLogging Operation</seealso>
        public virtual Task<StopLoggingResponse> StopLoggingAsync(StopLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<StopLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrail

        internal virtual UpdateTrailResponse UpdateTrail(UpdateTrailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrailResponseUnmarshaller.Instance;

            return Invoke<UpdateTrailResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateTrail">REST API Reference for UpdateTrail Operation</seealso>
        public virtual Task<UpdateTrailResponse> UpdateTrailAsync(UpdateTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrailResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}