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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DirectoryService.Model;
using Amazon.DirectoryService.Model.Internal.MarshallTransformations;
using Amazon.DirectoryService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.DirectoryService
{
    /// <summary>
    /// <para>Implementation for accessing DirectoryService</para>
    ///
    /// Directory Service 
    /// <para>
    /// Directory Service is a web service that makes it easy for you to setup and run directories
    /// in the Amazon Web Services cloud, or connect your Amazon Web Services resources with
    /// an existing self-managed Microsoft Active Directory. This guide provides detailed
    /// information about Directory Service operations, data types, parameters, and errors.
    /// For information about Directory Services features, see <a href="https://aws.amazon.com/directoryservice/">Directory
    /// Service</a> and the <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/what_is.html">Directory
    /// Service Administration Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Web Services provides SDKs that consist of libraries and sample code for various
    /// programming languages and platforms (Java, Ruby, .Net, iOS, Android, etc.). The SDKs
    /// provide a convenient way to create programmatic access to Directory Service and other
    /// Amazon Web Services services. For more information about the Amazon Web Services SDKs,
    /// including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonDirectoryServiceClient : AmazonServiceClient, IAmazonDirectoryService
    {
        private static IServiceMetadata serviceMetadata = new AmazonDirectoryServiceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IDirectoryServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDirectoryServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DirectoryServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with the credentials loaded from the application's
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
        public AmazonDirectoryServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectoryServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with the credentials loaded from the application's
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
        public AmazonDirectoryServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectoryServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(AmazonDirectoryServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDirectoryServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonDirectoryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDirectoryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Credentials and an
        /// AmazonDirectoryServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(AWSCredentials credentials, AmazonDirectoryServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectoryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectoryServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectoryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDirectoryServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectoryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectoryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectoryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDirectoryServiceConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDirectoryServiceEndpointResolver());
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


        #region  AcceptSharedDirectory

        /// <summary>
        /// Accepts a directory sharing request that was sent from the directory owner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptSharedDirectory service method.</param>
        /// 
        /// <returns>The response from the AcceptSharedDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryAlreadySharedException">
        /// The specified directory has already been shared with this Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AcceptSharedDirectory">REST API Reference for AcceptSharedDirectory Operation</seealso>
        public virtual AcceptSharedDirectoryResponse AcceptSharedDirectory(AcceptSharedDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSharedDirectoryResponseUnmarshaller.Instance;

            return Invoke<AcceptSharedDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptSharedDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptSharedDirectory operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptSharedDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AcceptSharedDirectory">REST API Reference for AcceptSharedDirectory Operation</seealso>
        public virtual IAsyncResult BeginAcceptSharedDirectory(AcceptSharedDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSharedDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptSharedDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptSharedDirectory.</param>
        /// 
        /// <returns>Returns a  AcceptSharedDirectoryResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AcceptSharedDirectory">REST API Reference for AcceptSharedDirectory Operation</seealso>
        public virtual AcceptSharedDirectoryResponse EndAcceptSharedDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptSharedDirectoryResponse>(asyncResult);
        }

        #endregion
        
        #region  AddIpRoutes

        /// <summary>
        /// If the DNS server for your self-managed domain uses a publicly addressable IP address,
        /// you must add a CIDR address block to correctly route traffic to and from your Microsoft
        /// AD on Amazon Web Services. <i>AddIpRoutes</i> adds this address block. You can also
        /// use <i>AddIpRoutes</i> to facilitate routing traffic that uses public IP ranges from
        /// your Microsoft AD on Amazon Web Services to a peer VPC. 
        /// 
        ///  
        /// <para>
        /// Before you call <i>AddIpRoutes</i>, ensure that all of the required permissions have
        /// been explicitly granted through a policy. For details about what permissions are required
        /// to run the <i>AddIpRoutes</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">Directory
        /// Service API Permissions: Actions, Resources, and Conditions Reference</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddIpRoutes service method.</param>
        /// 
        /// <returns>The response from the AddIpRoutes service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.IpRouteLimitExceededException">
        /// The maximum allowed number of IP addresses was exceeded. The default limit is 100
        /// IP address blocks.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddIpRoutes">REST API Reference for AddIpRoutes Operation</seealso>
        public virtual AddIpRoutesResponse AddIpRoutes(AddIpRoutesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddIpRoutesResponseUnmarshaller.Instance;

            return Invoke<AddIpRoutesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddIpRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddIpRoutes operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddIpRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddIpRoutes">REST API Reference for AddIpRoutes Operation</seealso>
        public virtual IAsyncResult BeginAddIpRoutes(AddIpRoutesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddIpRoutesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddIpRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddIpRoutes.</param>
        /// 
        /// <returns>Returns a  AddIpRoutesResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddIpRoutes">REST API Reference for AddIpRoutes Operation</seealso>
        public virtual AddIpRoutesResponse EndAddIpRoutes(IAsyncResult asyncResult)
        {
            return EndInvoke<AddIpRoutesResponse>(asyncResult);
        }

        #endregion
        
        #region  AddRegion

        /// <summary>
        /// Adds two domain controllers in the specified Region for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRegion service method.</param>
        /// 
        /// <returns>The response from the AddRegion service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryAlreadyInRegionException">
        /// The Region you specified is the same Region where the Managed Microsoft AD directory
        /// was created. Specify a different Region and try again.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.RegionLimitExceededException">
        /// You have reached the limit for maximum number of simultaneous Region replications
        /// per directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddRegion">REST API Reference for AddRegion Operation</seealso>
        public virtual AddRegionResponse AddRegion(AddRegionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRegionResponseUnmarshaller.Instance;

            return Invoke<AddRegionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRegion operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddRegion">REST API Reference for AddRegion Operation</seealso>
        public virtual IAsyncResult BeginAddRegion(AddRegionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRegionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddRegion.</param>
        /// 
        /// <returns>Returns a  AddRegionResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddRegion">REST API Reference for AddRegion Operation</seealso>
        public virtual AddRegionResponse EndAddRegion(IAsyncResult asyncResult)
        {
            return EndInvoke<AddRegionResponse>(asyncResult);
        }

        #endregion
        
        #region  AddTagsToResource

        /// <summary>
        /// Adds or overwrites one or more tags for the specified directory. Each directory can
        /// have a maximum of 50 tags. Each tag consists of a key and optional value. Tag keys
        /// must be unique to each resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.TagLimitExceededException">
        /// The maximum allowed number of tags was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddTagsToResourceResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse EndAddTagsToResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsToResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelSchemaExtension

        /// <summary>
        /// Cancels an in-progress schema extension to a Microsoft AD directory. Once a schema
        /// extension has started replicating to all domain controllers, the task can no longer
        /// be canceled. A schema extension can be canceled during any of the following states;
        /// <c>Initializing</c>, <c>CreatingSnapshot</c>, and <c>UpdatingSchema</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSchemaExtension service method.</param>
        /// 
        /// <returns>The response from the CancelSchemaExtension service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CancelSchemaExtension">REST API Reference for CancelSchemaExtension Operation</seealso>
        public virtual CancelSchemaExtensionResponse CancelSchemaExtension(CancelSchemaExtensionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSchemaExtensionResponseUnmarshaller.Instance;

            return Invoke<CancelSchemaExtensionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSchemaExtension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSchemaExtension operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSchemaExtension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CancelSchemaExtension">REST API Reference for CancelSchemaExtension Operation</seealso>
        public virtual IAsyncResult BeginCancelSchemaExtension(CancelSchemaExtensionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSchemaExtensionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSchemaExtension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSchemaExtension.</param>
        /// 
        /// <returns>Returns a  CancelSchemaExtensionResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CancelSchemaExtension">REST API Reference for CancelSchemaExtension Operation</seealso>
        public virtual CancelSchemaExtensionResponse EndCancelSchemaExtension(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelSchemaExtensionResponse>(asyncResult);
        }

        #endregion
        
        #region  ConnectDirectory

        /// <summary>
        /// Creates an AD Connector to connect to a self-managed directory.
        /// 
        ///  
        /// <para>
        /// Before you call <c>ConnectDirectory</c>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <c>ConnectDirectory</c> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">Directory
        /// Service API Permissions: Actions, Resources, and Conditions Reference</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectDirectory service method.</param>
        /// 
        /// <returns>The response from the ConnectDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryLimitExceededException">
        /// The maximum number of directories in the region has been reached. You can use the
        /// <a>GetDirectoryLimits</a> operation to determine your directory limits in the region.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ConnectDirectory">REST API Reference for ConnectDirectory Operation</seealso>
        public virtual ConnectDirectoryResponse ConnectDirectory(ConnectDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConnectDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectDirectoryResponseUnmarshaller.Instance;

            return Invoke<ConnectDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConnectDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConnectDirectory operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConnectDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ConnectDirectory">REST API Reference for ConnectDirectory Operation</seealso>
        public virtual IAsyncResult BeginConnectDirectory(ConnectDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ConnectDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConnectDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConnectDirectory.</param>
        /// 
        /// <returns>Returns a  ConnectDirectoryResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ConnectDirectory">REST API Reference for ConnectDirectory Operation</seealso>
        public virtual ConnectDirectoryResponse EndConnectDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<ConnectDirectoryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAlias

        /// <summary>
        /// Creates an alias for a directory and assigns the alias to the directory. The alias
        /// is used to construct the access URL for the directory, such as <c>http://&lt;alias&gt;.awsapps.com</c>.
        /// 
        ///  <important> 
        /// <para>
        /// After an alias has been created, it cannot be deleted or reused, so this operation
        /// should only be used when absolutely necessary.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual IAsyncResult BeginCreateAlias(CreateAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlias.</param>
        /// 
        /// <returns>Returns a  CreateAliasResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse EndCreateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateComputer

        /// <summary>
        /// Creates an Active Directory computer object in the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputer service method.</param>
        /// 
        /// <returns>The response from the CreateComputer service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AuthenticationFailedException">
        /// An authentication error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateComputer">REST API Reference for CreateComputer Operation</seealso>
        public virtual CreateComputerResponse CreateComputer(CreateComputerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComputerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputerResponseUnmarshaller.Instance;

            return Invoke<CreateComputerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComputer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComputer operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComputer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateComputer">REST API Reference for CreateComputer Operation</seealso>
        public virtual IAsyncResult BeginCreateComputer(CreateComputerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComputerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComputer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComputer.</param>
        /// 
        /// <returns>Returns a  CreateComputerResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateComputer">REST API Reference for CreateComputer Operation</seealso>
        public virtual CreateComputerResponse EndCreateComputer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateComputerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConditionalForwarder

        /// <summary>
        /// Creates a conditional forwarder associated with your Amazon Web Services directory.
        /// Conditional forwarders are required in order to set up a trust relationship with another
        /// domain. The conditional forwarder points to the trusted domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConditionalForwarder service method.</param>
        /// 
        /// <returns>The response from the CreateConditionalForwarder service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateConditionalForwarder">REST API Reference for CreateConditionalForwarder Operation</seealso>
        public virtual CreateConditionalForwarderResponse CreateConditionalForwarder(CreateConditionalForwarderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<CreateConditionalForwarderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConditionalForwarder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConditionalForwarder operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConditionalForwarder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateConditionalForwarder">REST API Reference for CreateConditionalForwarder Operation</seealso>
        public virtual IAsyncResult BeginCreateConditionalForwarder(CreateConditionalForwarderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConditionalForwarderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConditionalForwarder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConditionalForwarder.</param>
        /// 
        /// <returns>Returns a  CreateConditionalForwarderResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateConditionalForwarder">REST API Reference for CreateConditionalForwarder Operation</seealso>
        public virtual CreateConditionalForwarderResponse EndCreateConditionalForwarder(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConditionalForwarderResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDirectory

        /// <summary>
        /// Creates a Simple AD directory. For more information, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/directory_simple_ad.html">Simple
        /// Active Directory</a> in the <i>Directory Service Admin Guide</i>.
        /// 
        ///  
        /// <para>
        /// Before you call <c>CreateDirectory</c>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <c>CreateDirectory</c> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">Directory
        /// Service API Permissions: Actions, Resources, and Conditions Reference</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory service method.</param>
        /// 
        /// <returns>The response from the CreateDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryLimitExceededException">
        /// The maximum number of directories in the region has been reached. You can use the
        /// <a>GetDirectoryLimits</a> operation to determine your directory limits in the region.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public virtual CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public virtual IAsyncResult BeginCreateDirectory(CreateDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectory.</param>
        /// 
        /// <returns>Returns a  CreateDirectoryResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public virtual CreateDirectoryResponse EndCreateDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDirectoryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateHybridAD

        /// <summary>
        /// Creates a hybrid directory that connects your self-managed Active Directory (AD) infrastructure
        /// and Amazon Web Services.
        /// 
        ///  
        /// <para>
        /// You must have a successful directory assessment using <a>StartADAssessment</a> to
        /// validate your environment compatibility before you use this operation.
        /// </para>
        ///  
        /// <para>
        /// Updates are applied asynchronously. Use <a>DescribeDirectories</a> to monitor the
        /// progress of directory creation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHybridAD service method.</param>
        /// 
        /// <returns>The response from the CreateHybridAD service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ADAssessmentLimitExceededException">
        /// A directory assessment is automatically created when you create a hybrid directory.
        /// There are two types of assessments: <c>CUSTOMER</c> and <c>SYSTEM</c>. Your Amazon
        /// Web Services account has a limit of 100 <c>CUSTOMER</c> directory assessments.
        /// 
        ///  
        /// <para>
        /// If you attempt to create a hybrid directory; and you already have 100 <c>CUSTOMER</c>
        /// directory assessments;, you will encounter an error. Delete assessments to free up
        /// capacity before trying again.
        /// </para>
        ///  
        /// <para>
        /// You can request an increase to your <c>CUSTOMER</c> directory assessment quota by
        /// contacting customer support or delete existing CUSTOMER directory assessments; to
        /// free up capacity.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryLimitExceededException">
        /// The maximum number of directories in the region has been reached. You can use the
        /// <a>GetDirectoryLimits</a> operation to determine your directory limits in the region.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateHybridAD">REST API Reference for CreateHybridAD Operation</seealso>
        public virtual CreateHybridADResponse CreateHybridAD(CreateHybridADRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHybridADRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHybridADResponseUnmarshaller.Instance;

            return Invoke<CreateHybridADResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHybridAD operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHybridAD operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHybridAD
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateHybridAD">REST API Reference for CreateHybridAD Operation</seealso>
        public virtual IAsyncResult BeginCreateHybridAD(CreateHybridADRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHybridADRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHybridADResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHybridAD operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHybridAD.</param>
        /// 
        /// <returns>Returns a  CreateHybridADResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateHybridAD">REST API Reference for CreateHybridAD Operation</seealso>
        public virtual CreateHybridADResponse EndCreateHybridAD(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHybridADResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLogSubscription

        /// <summary>
        /// Creates a subscription to forward real-time Directory Service domain controller security
        /// logs to the specified Amazon CloudWatch log group in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateLogSubscription service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InsufficientPermissionsException">
        /// The account does not have sufficient permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateLogSubscription">REST API Reference for CreateLogSubscription Operation</seealso>
        public virtual CreateLogSubscriptionResponse CreateLogSubscription(CreateLogSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateLogSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLogSubscription operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLogSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateLogSubscription">REST API Reference for CreateLogSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateLogSubscription(CreateLogSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLogSubscription.</param>
        /// 
        /// <returns>Returns a  CreateLogSubscriptionResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateLogSubscription">REST API Reference for CreateLogSubscription Operation</seealso>
        public virtual CreateLogSubscriptionResponse EndCreateLogSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLogSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMicrosoftAD

        /// <summary>
        /// Creates a Microsoft AD directory in the Amazon Web Services Cloud. For more information,
        /// see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/directory_microsoft_ad.html">Managed
        /// Microsoft AD</a> in the <i>Directory Service Admin Guide</i>.
        /// 
        ///  
        /// <para>
        /// Before you call <i>CreateMicrosoftAD</i>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <i>CreateMicrosoftAD</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">Directory
        /// Service API Permissions: Actions, Resources, and Conditions Reference</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrosoftAD service method.</param>
        /// 
        /// <returns>The response from the CreateMicrosoftAD service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryLimitExceededException">
        /// The maximum number of directories in the region has been reached. You can use the
        /// <a>GetDirectoryLimits</a> operation to determine your directory limits in the region.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateMicrosoftAD">REST API Reference for CreateMicrosoftAD Operation</seealso>
        public virtual CreateMicrosoftADResponse CreateMicrosoftAD(CreateMicrosoftADRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMicrosoftADRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrosoftADResponseUnmarshaller.Instance;

            return Invoke<CreateMicrosoftADResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMicrosoftAD operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrosoftAD operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMicrosoftAD
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateMicrosoftAD">REST API Reference for CreateMicrosoftAD Operation</seealso>
        public virtual IAsyncResult BeginCreateMicrosoftAD(CreateMicrosoftADRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMicrosoftADRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrosoftADResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMicrosoftAD operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMicrosoftAD.</param>
        /// 
        /// <returns>Returns a  CreateMicrosoftADResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateMicrosoftAD">REST API Reference for CreateMicrosoftAD Operation</seealso>
        public virtual CreateMicrosoftADResponse EndCreateMicrosoftAD(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMicrosoftADResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSnapshot

        /// <summary>
        /// Creates a snapshot of a Simple AD or Microsoft AD directory in the Amazon Web Services
        /// cloud.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot take snapshots of AD Connector directories.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.SnapshotLimitExceededException">
        /// The maximum number of manual snapshots for the directory has been reached. You can
        /// use the <a>GetSnapshotLimits</a> operation to determine the snapshot limits for a
        /// directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTrust

        /// <summary>
        /// Directory Service for Microsoft Active Directory allows you to configure trust relationships.
        /// For example, you can establish a trust between your Managed Microsoft AD directory,
        /// and your existing self-managed Microsoft Active Directory. This would allow you to
        /// provide users and groups access to resources in either domain, with a single set of
        /// credentials.
        /// 
        ///  
        /// <para>
        /// This action initiates the creation of the Amazon Web Services side of a trust relationship
        /// between an Managed Microsoft AD directory and an external domain. You can create either
        /// a forest trust or an external trust.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrust service method.</param>
        /// 
        /// <returns>The response from the CreateTrust service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateTrust">REST API Reference for CreateTrust Operation</seealso>
        public virtual CreateTrustResponse CreateTrust(CreateTrustRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustResponseUnmarshaller.Instance;

            return Invoke<CreateTrustResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrust operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrust operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrust
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateTrust">REST API Reference for CreateTrust Operation</seealso>
        public virtual IAsyncResult BeginCreateTrust(CreateTrustRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrust operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrust.</param>
        /// 
        /// <returns>Returns a  CreateTrustResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateTrust">REST API Reference for CreateTrust Operation</seealso>
        public virtual CreateTrustResponse EndCreateTrust(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTrustResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteADAssessment

        /// <summary>
        /// Deletes a directory assessment and all associated data. This operation permanently
        /// removes the assessment results, validation reports, and configuration information.
        /// 
        ///  
        /// <para>
        /// You cannot delete system-initiated assessments. You can delete customer-created assessments
        /// even if they are in progress.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteADAssessment service method.</param>
        /// 
        /// <returns>The response from the DeleteADAssessment service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteADAssessment">REST API Reference for DeleteADAssessment Operation</seealso>
        public virtual DeleteADAssessmentResponse DeleteADAssessment(DeleteADAssessmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteADAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteADAssessmentResponseUnmarshaller.Instance;

            return Invoke<DeleteADAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteADAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteADAssessment operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteADAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteADAssessment">REST API Reference for DeleteADAssessment Operation</seealso>
        public virtual IAsyncResult BeginDeleteADAssessment(DeleteADAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteADAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteADAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteADAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteADAssessment.</param>
        /// 
        /// <returns>Returns a  DeleteADAssessmentResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteADAssessment">REST API Reference for DeleteADAssessment Operation</seealso>
        public virtual DeleteADAssessmentResponse EndDeleteADAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteADAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConditionalForwarder

        /// <summary>
        /// Deletes a conditional forwarder that has been set up for your Amazon Web Services
        /// directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConditionalForwarder service method.</param>
        /// 
        /// <returns>The response from the DeleteConditionalForwarder service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteConditionalForwarder">REST API Reference for DeleteConditionalForwarder Operation</seealso>
        public virtual DeleteConditionalForwarderResponse DeleteConditionalForwarder(DeleteConditionalForwarderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<DeleteConditionalForwarderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConditionalForwarder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConditionalForwarder operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConditionalForwarder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteConditionalForwarder">REST API Reference for DeleteConditionalForwarder Operation</seealso>
        public virtual IAsyncResult BeginDeleteConditionalForwarder(DeleteConditionalForwarderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConditionalForwarderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConditionalForwarder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConditionalForwarder.</param>
        /// 
        /// <returns>Returns a  DeleteConditionalForwarderResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteConditionalForwarder">REST API Reference for DeleteConditionalForwarder Operation</seealso>
        public virtual DeleteConditionalForwarderResponse EndDeleteConditionalForwarder(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConditionalForwarderResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDirectory

        /// <summary>
        /// Deletes an Directory Service directory.
        /// 
        ///  
        /// <para>
        /// Before you call <c>DeleteDirectory</c>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <c>DeleteDirectory</c> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">Directory
        /// Service API Permissions: Actions, Resources, and Conditions Reference</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public virtual DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public virtual IAsyncResult BeginDeleteDirectory(DeleteDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectory.</param>
        /// 
        /// <returns>Returns a  DeleteDirectoryResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public virtual DeleteDirectoryResponse EndDeleteDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDirectoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLogSubscription

        /// <summary>
        /// Deletes the specified log subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteLogSubscription service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteLogSubscription">REST API Reference for DeleteLogSubscription Operation</seealso>
        public virtual DeleteLogSubscriptionResponse DeleteLogSubscription(DeleteLogSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteLogSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogSubscription operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLogSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteLogSubscription">REST API Reference for DeleteLogSubscription Operation</seealso>
        public virtual IAsyncResult BeginDeleteLogSubscription(DeleteLogSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLogSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteLogSubscriptionResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteLogSubscription">REST API Reference for DeleteLogSubscription Operation</seealso>
        public virtual DeleteLogSubscriptionResponse EndDeleteLogSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLogSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSnapshot

        /// <summary>
        /// Deletes a directory snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTrust

        /// <summary>
        /// Deletes an existing trust relationship between your Managed Microsoft AD directory
        /// and an external domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrust service method.</param>
        /// 
        /// <returns>The response from the DeleteTrust service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteTrust">REST API Reference for DeleteTrust Operation</seealso>
        public virtual DeleteTrustResponse DeleteTrust(DeleteTrustRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustResponseUnmarshaller.Instance;

            return Invoke<DeleteTrustResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrust operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrust operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrust
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteTrust">REST API Reference for DeleteTrust Operation</seealso>
        public virtual IAsyncResult BeginDeleteTrust(DeleteTrustRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrust operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrust.</param>
        /// 
        /// <returns>Returns a  DeleteTrustResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteTrust">REST API Reference for DeleteTrust Operation</seealso>
        public virtual DeleteTrustResponse EndDeleteTrust(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTrustResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterCertificate

        /// <summary>
        /// Deletes from the system the certificate that was registered for secure LDAP or client
        /// certificate authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterCertificate service method.</param>
        /// 
        /// <returns>The response from the DeregisterCertificate service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.CertificateDoesNotExistException">
        /// The certificate is not present in the system for describe or deregister activities.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.CertificateInUseException">
        /// The certificate is being used for the LDAP security connection and cannot be removed
        /// without disabling LDAP security.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeregisterCertificate">REST API Reference for DeregisterCertificate Operation</seealso>
        public virtual DeregisterCertificateResponse DeregisterCertificate(DeregisterCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterCertificateResponseUnmarshaller.Instance;

            return Invoke<DeregisterCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterCertificate operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeregisterCertificate">REST API Reference for DeregisterCertificate Operation</seealso>
        public virtual IAsyncResult BeginDeregisterCertificate(DeregisterCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterCertificate.</param>
        /// 
        /// <returns>Returns a  DeregisterCertificateResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeregisterCertificate">REST API Reference for DeregisterCertificate Operation</seealso>
        public virtual DeregisterCertificateResponse EndDeregisterCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterEventTopic

        /// <summary>
        /// Removes the specified directory as a publisher to the specified Amazon SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterEventTopic service method.</param>
        /// 
        /// <returns>The response from the DeregisterEventTopic service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeregisterEventTopic">REST API Reference for DeregisterEventTopic Operation</seealso>
        public virtual DeregisterEventTopicResponse DeregisterEventTopic(DeregisterEventTopicRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterEventTopicResponseUnmarshaller.Instance;

            return Invoke<DeregisterEventTopicResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterEventTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterEventTopic operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterEventTopic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeregisterEventTopic">REST API Reference for DeregisterEventTopic Operation</seealso>
        public virtual IAsyncResult BeginDeregisterEventTopic(DeregisterEventTopicRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterEventTopicResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterEventTopic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterEventTopic.</param>
        /// 
        /// <returns>Returns a  DeregisterEventTopicResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeregisterEventTopic">REST API Reference for DeregisterEventTopic Operation</seealso>
        public virtual DeregisterEventTopicResponse EndDeregisterEventTopic(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterEventTopicResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeADAssessment

        /// <summary>
        /// Retrieves detailed information about a directory assessment, including its current
        /// status, validation results, and configuration details. Use this operation to monitor
        /// assessment progress and review results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeADAssessment service method.</param>
        /// 
        /// <returns>The response from the DescribeADAssessment service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeADAssessment">REST API Reference for DescribeADAssessment Operation</seealso>
        public virtual DescribeADAssessmentResponse DescribeADAssessment(DescribeADAssessmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeADAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeADAssessmentResponseUnmarshaller.Instance;

            return Invoke<DescribeADAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeADAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeADAssessment operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeADAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeADAssessment">REST API Reference for DescribeADAssessment Operation</seealso>
        public virtual IAsyncResult BeginDescribeADAssessment(DescribeADAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeADAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeADAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeADAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeADAssessment.</param>
        /// 
        /// <returns>Returns a  DescribeADAssessmentResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeADAssessment">REST API Reference for DescribeADAssessment Operation</seealso>
        public virtual DescribeADAssessmentResponse EndDescribeADAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeADAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCAEnrollmentPolicy

        /// <summary>
        /// Retrieves detailed information about the certificate authority (CA) enrollment policy
        /// for the specified directory. This policy determines how client certificates are automatically
        /// enrolled and managed through Amazon Web Services Private Certificate Authority.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCAEnrollmentPolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeCAEnrollmentPolicy service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeCAEnrollmentPolicy">REST API Reference for DescribeCAEnrollmentPolicy Operation</seealso>
        public virtual DescribeCAEnrollmentPolicyResponse DescribeCAEnrollmentPolicy(DescribeCAEnrollmentPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCAEnrollmentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCAEnrollmentPolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeCAEnrollmentPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCAEnrollmentPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCAEnrollmentPolicy operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCAEnrollmentPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeCAEnrollmentPolicy">REST API Reference for DescribeCAEnrollmentPolicy Operation</seealso>
        public virtual IAsyncResult BeginDescribeCAEnrollmentPolicy(DescribeCAEnrollmentPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCAEnrollmentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCAEnrollmentPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCAEnrollmentPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCAEnrollmentPolicy.</param>
        /// 
        /// <returns>Returns a  DescribeCAEnrollmentPolicyResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeCAEnrollmentPolicy">REST API Reference for DescribeCAEnrollmentPolicy Operation</seealso>
        public virtual DescribeCAEnrollmentPolicyResponse EndDescribeCAEnrollmentPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCAEnrollmentPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCertificate

        /// <summary>
        /// Displays information about the certificate registered for secure LDAP or client certificate
        /// authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.CertificateDoesNotExistException">
        /// The certificate is not present in the system for describe or deregister activities.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual IAsyncResult BeginDescribeCertificate(DescribeCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCertificate.</param>
        /// 
        /// <returns>Returns a  DescribeCertificateResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual DescribeCertificateResponse EndDescribeCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClientAuthenticationSettings

        /// <summary>
        /// Retrieves information about the type of client authentication for the specified directory,
        /// if the type is specified. If no type is specified, information about all client authentication
        /// types that are supported for the specified directory is retrieved. Currently, only
        /// <c>SmartCard</c> is supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientAuthenticationSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeClientAuthenticationSettings service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeClientAuthenticationSettings">REST API Reference for DescribeClientAuthenticationSettings Operation</seealso>
        public virtual DescribeClientAuthenticationSettingsResponse DescribeClientAuthenticationSettings(DescribeClientAuthenticationSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClientAuthenticationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientAuthenticationSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeClientAuthenticationSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClientAuthenticationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientAuthenticationSettings operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClientAuthenticationSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeClientAuthenticationSettings">REST API Reference for DescribeClientAuthenticationSettings Operation</seealso>
        public virtual IAsyncResult BeginDescribeClientAuthenticationSettings(DescribeClientAuthenticationSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClientAuthenticationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientAuthenticationSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClientAuthenticationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClientAuthenticationSettings.</param>
        /// 
        /// <returns>Returns a  DescribeClientAuthenticationSettingsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeClientAuthenticationSettings">REST API Reference for DescribeClientAuthenticationSettings Operation</seealso>
        public virtual DescribeClientAuthenticationSettingsResponse EndDescribeClientAuthenticationSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClientAuthenticationSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConditionalForwarders

        /// <summary>
        /// Obtains information about the conditional forwarders for this account.
        /// 
        ///  
        /// <para>
        /// If no input parameters are provided for RemoteDomainNames, this request describes
        /// all conditional forwarders for the specified directory ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConditionalForwarders service method.</param>
        /// 
        /// <returns>The response from the DescribeConditionalForwarders service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeConditionalForwarders">REST API Reference for DescribeConditionalForwarders Operation</seealso>
        public virtual DescribeConditionalForwardersResponse DescribeConditionalForwarders(DescribeConditionalForwardersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConditionalForwardersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConditionalForwardersResponseUnmarshaller.Instance;

            return Invoke<DescribeConditionalForwardersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConditionalForwarders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConditionalForwarders operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConditionalForwarders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeConditionalForwarders">REST API Reference for DescribeConditionalForwarders Operation</seealso>
        public virtual IAsyncResult BeginDescribeConditionalForwarders(DescribeConditionalForwardersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConditionalForwardersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConditionalForwardersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConditionalForwarders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConditionalForwarders.</param>
        /// 
        /// <returns>Returns a  DescribeConditionalForwardersResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeConditionalForwarders">REST API Reference for DescribeConditionalForwarders Operation</seealso>
        public virtual DescribeConditionalForwardersResponse EndDescribeConditionalForwarders(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConditionalForwardersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDirectories

        /// <summary>
        /// Obtains information about the directories that belong to this account.
        /// 
        ///  
        /// <para>
        /// You can retrieve information about specific directories by passing the directory identifiers
        /// in the <c>DirectoryIds</c> parameter. Otherwise, all directories that belong to the
        /// current account are returned.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>DescribeDirectoriesResult.NextToken</c>
        /// member contains a token that you pass in the next call to <a>DescribeDirectories</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <c>Limit</c> parameter.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDirectories service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectories">REST API Reference for DescribeDirectories Operation</seealso>
        public virtual DescribeDirectoriesResponse DescribeDirectories()
        {
            return DescribeDirectories(new DescribeDirectoriesRequest());
        }

        /// <summary>
        /// Obtains information about the directories that belong to this account.
        /// 
        ///  
        /// <para>
        /// You can retrieve information about specific directories by passing the directory identifiers
        /// in the <c>DirectoryIds</c> parameter. Otherwise, all directories that belong to the
        /// current account are returned.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>DescribeDirectoriesResult.NextToken</c>
        /// member contains a token that you pass in the next call to <a>DescribeDirectories</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <c>Limit</c> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectories service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectories service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectories">REST API Reference for DescribeDirectories Operation</seealso>
        public virtual DescribeDirectoriesResponse DescribeDirectories(DescribeDirectoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectories operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDirectories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectories">REST API Reference for DescribeDirectories Operation</seealso>
        public virtual IAsyncResult BeginDescribeDirectories(DescribeDirectoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDirectories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDirectories.</param>
        /// 
        /// <returns>Returns a  DescribeDirectoriesResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectories">REST API Reference for DescribeDirectories Operation</seealso>
        public virtual DescribeDirectoriesResponse EndDescribeDirectories(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDirectoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDirectoryDataAccess

        /// <summary>
        /// Obtains status of directory data access enablement through the Directory Service Data
        /// API for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectoryDataAccess service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectoryDataAccess service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectoryDataAccess">REST API Reference for DescribeDirectoryDataAccess Operation</seealso>
        public virtual DescribeDirectoryDataAccessResponse DescribeDirectoryDataAccess(DescribeDirectoryDataAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDirectoryDataAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoryDataAccessResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectoryDataAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectoryDataAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectoryDataAccess operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDirectoryDataAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectoryDataAccess">REST API Reference for DescribeDirectoryDataAccess Operation</seealso>
        public virtual IAsyncResult BeginDescribeDirectoryDataAccess(DescribeDirectoryDataAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDirectoryDataAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoryDataAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDirectoryDataAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDirectoryDataAccess.</param>
        /// 
        /// <returns>Returns a  DescribeDirectoryDataAccessResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectoryDataAccess">REST API Reference for DescribeDirectoryDataAccess Operation</seealso>
        public virtual DescribeDirectoryDataAccessResponse EndDescribeDirectoryDataAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDirectoryDataAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDomainControllers

        /// <summary>
        /// Provides information about any domain controllers in your directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainControllers service method.</param>
        /// 
        /// <returns>The response from the DescribeDomainControllers service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDomainControllers">REST API Reference for DescribeDomainControllers Operation</seealso>
        public virtual DescribeDomainControllersResponse DescribeDomainControllers(DescribeDomainControllersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainControllersResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainControllersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomainControllers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainControllers operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomainControllers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDomainControllers">REST API Reference for DescribeDomainControllers Operation</seealso>
        public virtual IAsyncResult BeginDescribeDomainControllers(DescribeDomainControllersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainControllersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomainControllers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomainControllers.</param>
        /// 
        /// <returns>Returns a  DescribeDomainControllersResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDomainControllers">REST API Reference for DescribeDomainControllers Operation</seealso>
        public virtual DescribeDomainControllersResponse EndDescribeDomainControllers(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDomainControllersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventTopics

        /// <summary>
        /// Obtains information about which Amazon SNS topics receive status messages from the
        /// specified directory.
        /// 
        ///  
        /// <para>
        /// If no input parameters are provided, such as DirectoryId or TopicName, this request
        /// describes all of the associations in the account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTopics service method.</param>
        /// 
        /// <returns>The response from the DescribeEventTopics service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeEventTopics">REST API Reference for DescribeEventTopics Operation</seealso>
        public virtual DescribeEventTopicsResponse DescribeEventTopics(DescribeEventTopicsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTopicsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventTopicsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventTopics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTopics operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventTopics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeEventTopics">REST API Reference for DescribeEventTopics Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventTopics(DescribeEventTopicsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTopicsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventTopics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventTopics.</param>
        /// 
        /// <returns>Returns a  DescribeEventTopicsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeEventTopics">REST API Reference for DescribeEventTopics Operation</seealso>
        public virtual DescribeEventTopicsResponse EndDescribeEventTopics(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventTopicsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHybridADUpdate

        /// <summary>
        /// Retrieves information about update activities for a hybrid directory. This operation
        /// provides details about configuration changes, administrator account updates, and self-managed
        /// instance settings (IDs and DNS IPs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHybridADUpdate service method.</param>
        /// 
        /// <returns>The response from the DescribeHybridADUpdate service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeHybridADUpdate">REST API Reference for DescribeHybridADUpdate Operation</seealso>
        public virtual DescribeHybridADUpdateResponse DescribeHybridADUpdate(DescribeHybridADUpdateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeHybridADUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHybridADUpdateResponseUnmarshaller.Instance;

            return Invoke<DescribeHybridADUpdateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHybridADUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHybridADUpdate operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHybridADUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeHybridADUpdate">REST API Reference for DescribeHybridADUpdate Operation</seealso>
        public virtual IAsyncResult BeginDescribeHybridADUpdate(DescribeHybridADUpdateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeHybridADUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHybridADUpdateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHybridADUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHybridADUpdate.</param>
        /// 
        /// <returns>Returns a  DescribeHybridADUpdateResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeHybridADUpdate">REST API Reference for DescribeHybridADUpdate Operation</seealso>
        public virtual DescribeHybridADUpdateResponse EndDescribeHybridADUpdate(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHybridADUpdateResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLDAPSSettings

        /// <summary>
        /// Describes the status of LDAP security for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLDAPSSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeLDAPSSettings service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeLDAPSSettings">REST API Reference for DescribeLDAPSSettings Operation</seealso>
        public virtual DescribeLDAPSSettingsResponse DescribeLDAPSSettings(DescribeLDAPSSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLDAPSSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLDAPSSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeLDAPSSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLDAPSSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLDAPSSettings operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLDAPSSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeLDAPSSettings">REST API Reference for DescribeLDAPSSettings Operation</seealso>
        public virtual IAsyncResult BeginDescribeLDAPSSettings(DescribeLDAPSSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLDAPSSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLDAPSSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLDAPSSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLDAPSSettings.</param>
        /// 
        /// <returns>Returns a  DescribeLDAPSSettingsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeLDAPSSettings">REST API Reference for DescribeLDAPSSettings Operation</seealso>
        public virtual DescribeLDAPSSettingsResponse EndDescribeLDAPSSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLDAPSSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRegions

        /// <summary>
        /// Provides information about the Regions that are configured for multi-Region replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions service method.</param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        public virtual DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        public virtual IAsyncResult BeginDescribeRegions(DescribeRegionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRegions.</param>
        /// 
        /// <returns>Returns a  DescribeRegionsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        public virtual DescribeRegionsResponse EndDescribeRegions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRegionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSettings

        /// <summary>
        /// Retrieves information about the configurable settings for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeSettings service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSettings">REST API Reference for DescribeSettings Operation</seealso>
        public virtual DescribeSettingsResponse DescribeSettings(DescribeSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSettings operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSettings">REST API Reference for DescribeSettings Operation</seealso>
        public virtual IAsyncResult BeginDescribeSettings(DescribeSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSettings.</param>
        /// 
        /// <returns>Returns a  DescribeSettingsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSettings">REST API Reference for DescribeSettings Operation</seealso>
        public virtual DescribeSettingsResponse EndDescribeSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSharedDirectories

        /// <summary>
        /// Returns the shared directories in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSharedDirectories service method.</param>
        /// 
        /// <returns>The response from the DescribeSharedDirectories service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSharedDirectories">REST API Reference for DescribeSharedDirectories Operation</seealso>
        public virtual DescribeSharedDirectoriesResponse DescribeSharedDirectories(DescribeSharedDirectoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSharedDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSharedDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeSharedDirectoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSharedDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSharedDirectories operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSharedDirectories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSharedDirectories">REST API Reference for DescribeSharedDirectories Operation</seealso>
        public virtual IAsyncResult BeginDescribeSharedDirectories(DescribeSharedDirectoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSharedDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSharedDirectoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSharedDirectories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSharedDirectories.</param>
        /// 
        /// <returns>Returns a  DescribeSharedDirectoriesResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSharedDirectories">REST API Reference for DescribeSharedDirectories Operation</seealso>
        public virtual DescribeSharedDirectoriesResponse EndDescribeSharedDirectories(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSharedDirectoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSnapshots

        /// <summary>
        /// Obtains information about the directory snapshots that belong to this account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> request and
        /// response parameters. If more results are available, the <i>DescribeSnapshots.NextToken</i>
        /// member contains a token that you pass in the next call to <a>DescribeSnapshots</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <i>Limit</i> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual IAsyncResult BeginDescribeSnapshots(DescribeSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual DescribeSnapshotsResponse EndDescribeSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTrusts

        /// <summary>
        /// Obtains information about the trust relationships for this account.
        /// 
        ///  
        /// <para>
        /// If no input parameters are provided, such as DirectoryId or TrustIds, this request
        /// describes all the trust relationships belonging to the account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrusts service method.</param>
        /// 
        /// <returns>The response from the DescribeTrusts service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeTrusts">REST API Reference for DescribeTrusts Operation</seealso>
        public virtual DescribeTrustsResponse DescribeTrusts(DescribeTrustsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTrustsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrustsResponseUnmarshaller.Instance;

            return Invoke<DescribeTrustsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrusts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrusts operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrusts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeTrusts">REST API Reference for DescribeTrusts Operation</seealso>
        public virtual IAsyncResult BeginDescribeTrusts(DescribeTrustsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTrustsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrustsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrusts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrusts.</param>
        /// 
        /// <returns>Returns a  DescribeTrustsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeTrusts">REST API Reference for DescribeTrusts Operation</seealso>
        public virtual DescribeTrustsResponse EndDescribeTrusts(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTrustsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUpdateDirectory

        /// <summary>
        /// Describes the updates of a directory for a particular update type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUpdateDirectory service method.</param>
        /// 
        /// <returns>The response from the DescribeUpdateDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeUpdateDirectory">REST API Reference for DescribeUpdateDirectory Operation</seealso>
        public virtual DescribeUpdateDirectoryResponse DescribeUpdateDirectory(DescribeUpdateDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUpdateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUpdateDirectoryResponseUnmarshaller.Instance;

            return Invoke<DescribeUpdateDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUpdateDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUpdateDirectory operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUpdateDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeUpdateDirectory">REST API Reference for DescribeUpdateDirectory Operation</seealso>
        public virtual IAsyncResult BeginDescribeUpdateDirectory(DescribeUpdateDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUpdateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUpdateDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUpdateDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUpdateDirectory.</param>
        /// 
        /// <returns>Returns a  DescribeUpdateDirectoryResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeUpdateDirectory">REST API Reference for DescribeUpdateDirectory Operation</seealso>
        public virtual DescribeUpdateDirectoryResponse EndDescribeUpdateDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUpdateDirectoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableCAEnrollmentPolicy

        /// <summary>
        /// Disables the certificate authority (CA) enrollment policy for the specified directory.
        /// This stops automatic certificate enrollment and management for domain-joined clients,
        /// but does not affect existing certificates.
        /// 
        ///  <important> 
        /// <para>
        /// Disabling the CA enrollment policy prevents new certificates from being automatically
        /// enrolled, but existing certificates remain valid and functional until they expire.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableCAEnrollmentPolicy service method.</param>
        /// 
        /// <returns>The response from the DisableCAEnrollmentPolicy service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DisableAlreadyInProgressException">
        /// A disable operation for CA enrollment policy is already in progress for this directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableCAEnrollmentPolicy">REST API Reference for DisableCAEnrollmentPolicy Operation</seealso>
        public virtual DisableCAEnrollmentPolicyResponse DisableCAEnrollmentPolicy(DisableCAEnrollmentPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableCAEnrollmentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableCAEnrollmentPolicyResponseUnmarshaller.Instance;

            return Invoke<DisableCAEnrollmentPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableCAEnrollmentPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableCAEnrollmentPolicy operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableCAEnrollmentPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableCAEnrollmentPolicy">REST API Reference for DisableCAEnrollmentPolicy Operation</seealso>
        public virtual IAsyncResult BeginDisableCAEnrollmentPolicy(DisableCAEnrollmentPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableCAEnrollmentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableCAEnrollmentPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableCAEnrollmentPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableCAEnrollmentPolicy.</param>
        /// 
        /// <returns>Returns a  DisableCAEnrollmentPolicyResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableCAEnrollmentPolicy">REST API Reference for DisableCAEnrollmentPolicy Operation</seealso>
        public virtual DisableCAEnrollmentPolicyResponse EndDisableCAEnrollmentPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableCAEnrollmentPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableClientAuthentication

        /// <summary>
        /// Disables alternative client authentication methods for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableClientAuthentication service method.</param>
        /// 
        /// <returns>The response from the DisableClientAuthentication service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidClientAuthStatusException">
        /// Client authentication is already enabled.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableClientAuthentication">REST API Reference for DisableClientAuthentication Operation</seealso>
        public virtual DisableClientAuthenticationResponse DisableClientAuthentication(DisableClientAuthenticationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableClientAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableClientAuthenticationResponseUnmarshaller.Instance;

            return Invoke<DisableClientAuthenticationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableClientAuthentication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableClientAuthentication operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableClientAuthentication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableClientAuthentication">REST API Reference for DisableClientAuthentication Operation</seealso>
        public virtual IAsyncResult BeginDisableClientAuthentication(DisableClientAuthenticationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableClientAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableClientAuthenticationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableClientAuthentication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableClientAuthentication.</param>
        /// 
        /// <returns>Returns a  DisableClientAuthenticationResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableClientAuthentication">REST API Reference for DisableClientAuthentication Operation</seealso>
        public virtual DisableClientAuthenticationResponse EndDisableClientAuthentication(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableClientAuthenticationResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableDirectoryDataAccess

        /// <summary>
        /// Deactivates access to directory data via the Directory Service Data API for the specified
        /// directory. For more information, see <a href="https://docs.aws.amazon.com/directoryservicedata/latest/DirectoryServiceDataAPIReference/Welcome.html">Directory
        /// Service Data API Reference</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDirectoryDataAccess service method.</param>
        /// 
        /// <returns>The response from the DisableDirectoryDataAccess service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryInDesiredStateException">
        /// The directory is already updated to desired update type settings.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableDirectoryDataAccess">REST API Reference for DisableDirectoryDataAccess Operation</seealso>
        public virtual DisableDirectoryDataAccessResponse DisableDirectoryDataAccess(DisableDirectoryDataAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDirectoryDataAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDirectoryDataAccessResponseUnmarshaller.Instance;

            return Invoke<DisableDirectoryDataAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableDirectoryDataAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDirectoryDataAccess operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableDirectoryDataAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableDirectoryDataAccess">REST API Reference for DisableDirectoryDataAccess Operation</seealso>
        public virtual IAsyncResult BeginDisableDirectoryDataAccess(DisableDirectoryDataAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDirectoryDataAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDirectoryDataAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableDirectoryDataAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableDirectoryDataAccess.</param>
        /// 
        /// <returns>Returns a  DisableDirectoryDataAccessResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableDirectoryDataAccess">REST API Reference for DisableDirectoryDataAccess Operation</seealso>
        public virtual DisableDirectoryDataAccessResponse EndDisableDirectoryDataAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableDirectoryDataAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableLDAPS

        /// <summary>
        /// Deactivates LDAP secure calls for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableLDAPS service method.</param>
        /// 
        /// <returns>The response from the DisableLDAPS service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidLDAPSStatusException">
        /// The LDAP activities could not be performed because they are limited by the LDAPS status.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableLDAPS">REST API Reference for DisableLDAPS Operation</seealso>
        public virtual DisableLDAPSResponse DisableLDAPS(DisableLDAPSRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableLDAPSRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableLDAPSResponseUnmarshaller.Instance;

            return Invoke<DisableLDAPSResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableLDAPS operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableLDAPS operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableLDAPS
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableLDAPS">REST API Reference for DisableLDAPS Operation</seealso>
        public virtual IAsyncResult BeginDisableLDAPS(DisableLDAPSRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableLDAPSRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableLDAPSResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableLDAPS operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableLDAPS.</param>
        /// 
        /// <returns>Returns a  DisableLDAPSResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableLDAPS">REST API Reference for DisableLDAPS Operation</seealso>
        public virtual DisableLDAPSResponse EndDisableLDAPS(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableLDAPSResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableRadius

        /// <summary>
        /// Disables multi-factor authentication (MFA) with the Remote Authentication Dial In
        /// User Service (RADIUS) server for an AD Connector or Microsoft AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRadius service method.</param>
        /// 
        /// <returns>The response from the DisableRadius service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableRadius">REST API Reference for DisableRadius Operation</seealso>
        public virtual DisableRadiusResponse DisableRadius(DisableRadiusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRadiusResponseUnmarshaller.Instance;

            return Invoke<DisableRadiusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableRadius operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableRadius operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableRadius
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableRadius">REST API Reference for DisableRadius Operation</seealso>
        public virtual IAsyncResult BeginDisableRadius(DisableRadiusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRadiusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableRadius operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableRadius.</param>
        /// 
        /// <returns>Returns a  DisableRadiusResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableRadius">REST API Reference for DisableRadius Operation</seealso>
        public virtual DisableRadiusResponse EndDisableRadius(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableRadiusResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableSso

        /// <summary>
        /// Disables single-sign on for a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSso service method.</param>
        /// 
        /// <returns>The response from the DisableSso service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AuthenticationFailedException">
        /// An authentication error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InsufficientPermissionsException">
        /// The account does not have sufficient permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableSso">REST API Reference for DisableSso Operation</seealso>
        public virtual DisableSsoResponse DisableSso(DisableSsoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSsoResponseUnmarshaller.Instance;

            return Invoke<DisableSsoResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSso operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSso operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableSso
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableSso">REST API Reference for DisableSso Operation</seealso>
        public virtual IAsyncResult BeginDisableSso(DisableSsoRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSsoResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableSso operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableSso.</param>
        /// 
        /// <returns>Returns a  DisableSsoResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableSso">REST API Reference for DisableSso Operation</seealso>
        public virtual DisableSsoResponse EndDisableSso(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableSsoResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableCAEnrollmentPolicy

        /// <summary>
        /// Enables certificate authority (CA) enrollment policy for the specified directory.
        /// This allows domain-joined clients to automatically request and receive certificates
        /// from the specified Amazon Web Services Private Certificate Authority.
        /// 
        ///  <note> 
        /// <para>
        /// Before enabling CA enrollment, ensure that the PCA connector is properly configured
        /// and accessible from the directory. The connector must be in an active state and have
        /// the necessary permissions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableCAEnrollmentPolicy service method.</param>
        /// 
        /// <returns>The response from the EnableCAEnrollmentPolicy service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EnableAlreadyInProgressException">
        /// An enable operation for CA enrollment policy is already in progress for this directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableCAEnrollmentPolicy">REST API Reference for EnableCAEnrollmentPolicy Operation</seealso>
        public virtual EnableCAEnrollmentPolicyResponse EnableCAEnrollmentPolicy(EnableCAEnrollmentPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableCAEnrollmentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableCAEnrollmentPolicyResponseUnmarshaller.Instance;

            return Invoke<EnableCAEnrollmentPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableCAEnrollmentPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableCAEnrollmentPolicy operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableCAEnrollmentPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableCAEnrollmentPolicy">REST API Reference for EnableCAEnrollmentPolicy Operation</seealso>
        public virtual IAsyncResult BeginEnableCAEnrollmentPolicy(EnableCAEnrollmentPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableCAEnrollmentPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableCAEnrollmentPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableCAEnrollmentPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableCAEnrollmentPolicy.</param>
        /// 
        /// <returns>Returns a  EnableCAEnrollmentPolicyResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableCAEnrollmentPolicy">REST API Reference for EnableCAEnrollmentPolicy Operation</seealso>
        public virtual EnableCAEnrollmentPolicyResponse EndEnableCAEnrollmentPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableCAEnrollmentPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableClientAuthentication

        /// <summary>
        /// Enables alternative client authentication methods for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableClientAuthentication service method.</param>
        /// 
        /// <returns>The response from the EnableClientAuthentication service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidClientAuthStatusException">
        /// Client authentication is already enabled.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.NoAvailableCertificateException">
        /// Client authentication setup could not be completed because at least one valid certificate
        /// must be registered in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableClientAuthentication">REST API Reference for EnableClientAuthentication Operation</seealso>
        public virtual EnableClientAuthenticationResponse EnableClientAuthentication(EnableClientAuthenticationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableClientAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableClientAuthenticationResponseUnmarshaller.Instance;

            return Invoke<EnableClientAuthenticationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableClientAuthentication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableClientAuthentication operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableClientAuthentication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableClientAuthentication">REST API Reference for EnableClientAuthentication Operation</seealso>
        public virtual IAsyncResult BeginEnableClientAuthentication(EnableClientAuthenticationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableClientAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableClientAuthenticationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableClientAuthentication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableClientAuthentication.</param>
        /// 
        /// <returns>Returns a  EnableClientAuthenticationResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableClientAuthentication">REST API Reference for EnableClientAuthentication Operation</seealso>
        public virtual EnableClientAuthenticationResponse EndEnableClientAuthentication(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableClientAuthenticationResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableDirectoryDataAccess

        /// <summary>
        /// Enables access to directory data via the Directory Service Data API for the specified
        /// directory. For more information, see <a href="https://docs.aws.amazon.com/directoryservicedata/latest/DirectoryServiceDataAPIReference/Welcome.html">Directory
        /// Service Data API Reference</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDirectoryDataAccess service method.</param>
        /// 
        /// <returns>The response from the EnableDirectoryDataAccess service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryInDesiredStateException">
        /// The directory is already updated to desired update type settings.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableDirectoryDataAccess">REST API Reference for EnableDirectoryDataAccess Operation</seealso>
        public virtual EnableDirectoryDataAccessResponse EnableDirectoryDataAccess(EnableDirectoryDataAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDirectoryDataAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDirectoryDataAccessResponseUnmarshaller.Instance;

            return Invoke<EnableDirectoryDataAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableDirectoryDataAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDirectoryDataAccess operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableDirectoryDataAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableDirectoryDataAccess">REST API Reference for EnableDirectoryDataAccess Operation</seealso>
        public virtual IAsyncResult BeginEnableDirectoryDataAccess(EnableDirectoryDataAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDirectoryDataAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDirectoryDataAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableDirectoryDataAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableDirectoryDataAccess.</param>
        /// 
        /// <returns>Returns a  EnableDirectoryDataAccessResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableDirectoryDataAccess">REST API Reference for EnableDirectoryDataAccess Operation</seealso>
        public virtual EnableDirectoryDataAccessResponse EndEnableDirectoryDataAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableDirectoryDataAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableLDAPS

        /// <summary>
        /// Activates the switch for the specific directory to always use LDAP secure calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableLDAPS service method.</param>
        /// 
        /// <returns>The response from the EnableLDAPS service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidLDAPSStatusException">
        /// The LDAP activities could not be performed because they are limited by the LDAPS status.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.NoAvailableCertificateException">
        /// Client authentication setup could not be completed because at least one valid certificate
        /// must be registered in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableLDAPS">REST API Reference for EnableLDAPS Operation</seealso>
        public virtual EnableLDAPSResponse EnableLDAPS(EnableLDAPSRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableLDAPSRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableLDAPSResponseUnmarshaller.Instance;

            return Invoke<EnableLDAPSResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableLDAPS operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableLDAPS operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableLDAPS
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableLDAPS">REST API Reference for EnableLDAPS Operation</seealso>
        public virtual IAsyncResult BeginEnableLDAPS(EnableLDAPSRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableLDAPSRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableLDAPSResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableLDAPS operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableLDAPS.</param>
        /// 
        /// <returns>Returns a  EnableLDAPSResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableLDAPS">REST API Reference for EnableLDAPS Operation</seealso>
        public virtual EnableLDAPSResponse EndEnableLDAPS(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableLDAPSResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableRadius

        /// <summary>
        /// Enables multi-factor authentication (MFA) with the Remote Authentication Dial In User
        /// Service (RADIUS) server for an AD Connector or Microsoft AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRadius service method.</param>
        /// 
        /// <returns>The response from the EnableRadius service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// The specified entity already exists.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableRadius">REST API Reference for EnableRadius Operation</seealso>
        public virtual EnableRadiusResponse EnableRadius(EnableRadiusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRadiusResponseUnmarshaller.Instance;

            return Invoke<EnableRadiusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableRadius operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableRadius operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableRadius
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableRadius">REST API Reference for EnableRadius Operation</seealso>
        public virtual IAsyncResult BeginEnableRadius(EnableRadiusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRadiusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableRadius operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableRadius.</param>
        /// 
        /// <returns>Returns a  EnableRadiusResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableRadius">REST API Reference for EnableRadius Operation</seealso>
        public virtual EnableRadiusResponse EndEnableRadius(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableRadiusResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableSso

        /// <summary>
        /// Enables single sign-on for a directory. Single sign-on allows users in your directory
        /// to access certain Amazon Web Services services from a computer joined to the directory
        /// without having to enter their credentials separately.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSso service method.</param>
        /// 
        /// <returns>The response from the EnableSso service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AuthenticationFailedException">
        /// An authentication error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InsufficientPermissionsException">
        /// The account does not have sufficient permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableSso">REST API Reference for EnableSso Operation</seealso>
        public virtual EnableSsoResponse EnableSso(EnableSsoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSsoResponseUnmarshaller.Instance;

            return Invoke<EnableSsoResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSso operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSso operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableSso
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableSso">REST API Reference for EnableSso Operation</seealso>
        public virtual IAsyncResult BeginEnableSso(EnableSsoRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSsoResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableSso operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableSso.</param>
        /// 
        /// <returns>Returns a  EnableSsoResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableSso">REST API Reference for EnableSso Operation</seealso>
        public virtual EnableSsoResponse EndEnableSso(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableSsoResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDirectoryLimits

        /// <summary>
        /// Obtains directory limit information for the current Region.
        /// </summary>
        /// 
        /// <returns>The response from the GetDirectoryLimits service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetDirectoryLimits">REST API Reference for GetDirectoryLimits Operation</seealso>
        public virtual GetDirectoryLimitsResponse GetDirectoryLimits()
        {
            return GetDirectoryLimits(new GetDirectoryLimitsRequest());
        }

        /// <summary>
        /// Obtains directory limit information for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryLimits service method.</param>
        /// 
        /// <returns>The response from the GetDirectoryLimits service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetDirectoryLimits">REST API Reference for GetDirectoryLimits Operation</seealso>
        public virtual GetDirectoryLimitsResponse GetDirectoryLimits(GetDirectoryLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDirectoryLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDirectoryLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryLimits operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDirectoryLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetDirectoryLimits">REST API Reference for GetDirectoryLimits Operation</seealso>
        public virtual IAsyncResult BeginGetDirectoryLimits(GetDirectoryLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDirectoryLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDirectoryLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDirectoryLimits.</param>
        /// 
        /// <returns>Returns a  GetDirectoryLimitsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetDirectoryLimits">REST API Reference for GetDirectoryLimits Operation</seealso>
        public virtual GetDirectoryLimitsResponse EndGetDirectoryLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDirectoryLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSnapshotLimits

        /// <summary>
        /// Obtains the manual snapshot limits for a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotLimits service method.</param>
        /// 
        /// <returns>The response from the GetSnapshotLimits service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetSnapshotLimits">REST API Reference for GetSnapshotLimits Operation</seealso>
        public virtual GetSnapshotLimitsResponse GetSnapshotLimits(GetSnapshotLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSnapshotLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotLimitsResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSnapshotLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotLimits operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSnapshotLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetSnapshotLimits">REST API Reference for GetSnapshotLimits Operation</seealso>
        public virtual IAsyncResult BeginGetSnapshotLimits(GetSnapshotLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSnapshotLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSnapshotLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSnapshotLimits.</param>
        /// 
        /// <returns>Returns a  GetSnapshotLimitsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetSnapshotLimits">REST API Reference for GetSnapshotLimits Operation</seealso>
        public virtual GetSnapshotLimitsResponse EndGetSnapshotLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSnapshotLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListADAssessments

        /// <summary>
        /// Retrieves a list of directory assessments for the specified directory or all assessments
        /// in your account. Use this operation to monitor assessment status and manage multiple
        /// assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListADAssessments service method.</param>
        /// 
        /// <returns>The response from the ListADAssessments service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListADAssessments">REST API Reference for ListADAssessments Operation</seealso>
        public virtual ListADAssessmentsResponse ListADAssessments(ListADAssessmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListADAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListADAssessmentsResponseUnmarshaller.Instance;

            return Invoke<ListADAssessmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListADAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListADAssessments operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListADAssessments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListADAssessments">REST API Reference for ListADAssessments Operation</seealso>
        public virtual IAsyncResult BeginListADAssessments(ListADAssessmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListADAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListADAssessmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListADAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListADAssessments.</param>
        /// 
        /// <returns>Returns a  ListADAssessmentsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListADAssessments">REST API Reference for ListADAssessments Operation</seealso>
        public virtual ListADAssessmentsResponse EndListADAssessments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListADAssessmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCertificates

        /// <summary>
        /// For the specified directory, lists all the certificates registered for a secure LDAP
        /// or client certificate authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual ListCertificatesResponse ListCertificates(ListCertificatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual IAsyncResult BeginListCertificates(ListCertificatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCertificates.</param>
        /// 
        /// <returns>Returns a  ListCertificatesResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual ListCertificatesResponse EndListCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIpRoutes

        /// <summary>
        /// Lists the address blocks that you have added to a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIpRoutes service method.</param>
        /// 
        /// <returns>The response from the ListIpRoutes service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListIpRoutes">REST API Reference for ListIpRoutes Operation</seealso>
        public virtual ListIpRoutesResponse ListIpRoutes(ListIpRoutesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIpRoutesResponseUnmarshaller.Instance;

            return Invoke<ListIpRoutesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIpRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIpRoutes operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIpRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListIpRoutes">REST API Reference for ListIpRoutes Operation</seealso>
        public virtual IAsyncResult BeginListIpRoutes(ListIpRoutesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIpRoutesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIpRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIpRoutes.</param>
        /// 
        /// <returns>Returns a  ListIpRoutesResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListIpRoutes">REST API Reference for ListIpRoutes Operation</seealso>
        public virtual ListIpRoutesResponse EndListIpRoutes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIpRoutesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLogSubscriptions

        /// <summary>
        /// Lists the active log subscriptions for the Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListLogSubscriptions service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListLogSubscriptions">REST API Reference for ListLogSubscriptions Operation</seealso>
        public virtual ListLogSubscriptionsResponse ListLogSubscriptions(ListLogSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListLogSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLogSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLogSubscriptions operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLogSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListLogSubscriptions">REST API Reference for ListLogSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginListLogSubscriptions(ListLogSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLogSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLogSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListLogSubscriptionsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListLogSubscriptions">REST API Reference for ListLogSubscriptions Operation</seealso>
        public virtual ListLogSubscriptionsResponse EndListLogSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLogSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSchemaExtensions

        /// <summary>
        /// Lists all schema extensions applied to a Microsoft AD Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaExtensions service method.</param>
        /// 
        /// <returns>The response from the ListSchemaExtensions service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListSchemaExtensions">REST API Reference for ListSchemaExtensions Operation</seealso>
        public virtual ListSchemaExtensionsResponse ListSchemaExtensions(ListSchemaExtensionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaExtensionsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaExtensionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemaExtensions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaExtensions operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemaExtensions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListSchemaExtensions">REST API Reference for ListSchemaExtensions Operation</seealso>
        public virtual IAsyncResult BeginListSchemaExtensions(ListSchemaExtensionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaExtensionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemaExtensions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemaExtensions.</param>
        /// 
        /// <returns>Returns a  ListSchemaExtensionsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListSchemaExtensions">REST API Reference for ListSchemaExtensions Operation</seealso>
        public virtual ListSchemaExtensionsResponse EndListSchemaExtensions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSchemaExtensionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags on a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterCertificate

        /// <summary>
        /// Registers a certificate for a secure LDAP or client certificate authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificate service method.</param>
        /// 
        /// <returns>The response from the RegisterCertificate service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.CertificateAlreadyExistsException">
        /// The certificate has already been registered into the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.CertificateLimitExceededException">
        /// The certificate could not be added because the certificate limit has been reached.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidCertificateException">
        /// The certificate PEM that was provided has incorrect encoding.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RegisterCertificate">REST API Reference for RegisterCertificate Operation</seealso>
        public virtual RegisterCertificateResponse RegisterCertificate(RegisterCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCertificateResponseUnmarshaller.Instance;

            return Invoke<RegisterCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificate operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RegisterCertificate">REST API Reference for RegisterCertificate Operation</seealso>
        public virtual IAsyncResult BeginRegisterCertificate(RegisterCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterCertificate.</param>
        /// 
        /// <returns>Returns a  RegisterCertificateResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RegisterCertificate">REST API Reference for RegisterCertificate Operation</seealso>
        public virtual RegisterCertificateResponse EndRegisterCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterEventTopic

        /// <summary>
        /// Associates a directory with an Amazon SNS topic. This establishes the directory as
        /// a publisher to the specified Amazon SNS topic. You can then receive email or text
        /// (SMS) messages when the status of your directory changes. You get notified if your
        /// directory goes from an Active status to an Impaired or Inoperable status. You also
        /// receive a notification when the directory returns to an Active status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterEventTopic service method.</param>
        /// 
        /// <returns>The response from the RegisterEventTopic service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RegisterEventTopic">REST API Reference for RegisterEventTopic Operation</seealso>
        public virtual RegisterEventTopicResponse RegisterEventTopic(RegisterEventTopicRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterEventTopicResponseUnmarshaller.Instance;

            return Invoke<RegisterEventTopicResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterEventTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterEventTopic operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterEventTopic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RegisterEventTopic">REST API Reference for RegisterEventTopic Operation</seealso>
        public virtual IAsyncResult BeginRegisterEventTopic(RegisterEventTopicRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterEventTopicResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterEventTopic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterEventTopic.</param>
        /// 
        /// <returns>Returns a  RegisterEventTopicResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RegisterEventTopic">REST API Reference for RegisterEventTopic Operation</seealso>
        public virtual RegisterEventTopicResponse EndRegisterEventTopic(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterEventTopicResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectSharedDirectory

        /// <summary>
        /// Rejects a directory sharing request that was sent from the directory owner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSharedDirectory service method.</param>
        /// 
        /// <returns>The response from the RejectSharedDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryAlreadySharedException">
        /// The specified directory has already been shared with this Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RejectSharedDirectory">REST API Reference for RejectSharedDirectory Operation</seealso>
        public virtual RejectSharedDirectoryResponse RejectSharedDirectory(RejectSharedDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSharedDirectoryResponseUnmarshaller.Instance;

            return Invoke<RejectSharedDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectSharedDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectSharedDirectory operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectSharedDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RejectSharedDirectory">REST API Reference for RejectSharedDirectory Operation</seealso>
        public virtual IAsyncResult BeginRejectSharedDirectory(RejectSharedDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSharedDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectSharedDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectSharedDirectory.</param>
        /// 
        /// <returns>Returns a  RejectSharedDirectoryResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RejectSharedDirectory">REST API Reference for RejectSharedDirectory Operation</seealso>
        public virtual RejectSharedDirectoryResponse EndRejectSharedDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectSharedDirectoryResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveIpRoutes

        /// <summary>
        /// Removes IP address blocks from a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveIpRoutes service method.</param>
        /// 
        /// <returns>The response from the RemoveIpRoutes service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveIpRoutes">REST API Reference for RemoveIpRoutes Operation</seealso>
        public virtual RemoveIpRoutesResponse RemoveIpRoutes(RemoveIpRoutesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveIpRoutesResponseUnmarshaller.Instance;

            return Invoke<RemoveIpRoutesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveIpRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveIpRoutes operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveIpRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveIpRoutes">REST API Reference for RemoveIpRoutes Operation</seealso>
        public virtual IAsyncResult BeginRemoveIpRoutes(RemoveIpRoutesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveIpRoutesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveIpRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveIpRoutes.</param>
        /// 
        /// <returns>Returns a  RemoveIpRoutesResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveIpRoutes">REST API Reference for RemoveIpRoutes Operation</seealso>
        public virtual RemoveIpRoutesResponse EndRemoveIpRoutes(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveIpRoutesResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveRegion

        /// <summary>
        /// Stops all replication and removes the domain controllers from the specified Region.
        /// You cannot remove the primary Region with this operation. Instead, use the <c>DeleteDirectory</c>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRegion service method.</param>
        /// 
        /// <returns>The response from the RemoveRegion service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveRegion">REST API Reference for RemoveRegion Operation</seealso>
        public virtual RemoveRegionResponse RemoveRegion(RemoveRegionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRegionResponseUnmarshaller.Instance;

            return Invoke<RemoveRegionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRegion operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveRegion">REST API Reference for RemoveRegion Operation</seealso>
        public virtual IAsyncResult BeginRemoveRegion(RemoveRegionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRegionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRegion.</param>
        /// 
        /// <returns>Returns a  RemoveRegionResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveRegion">REST API Reference for RemoveRegion Operation</seealso>
        public virtual RemoveRegionResponse EndRemoveRegion(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveRegionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        /// <summary>
        /// Removes tags from a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromResourceResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse EndRemoveTagsFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsFromResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetUserPassword

        /// <summary>
        /// Resets the password for any user in your Managed Microsoft AD or Simple AD directory.
        /// Disabled users will become enabled and can be authenticated following the API call.
        /// 
        ///  
        /// <para>
        /// You can reset the password for any user in your directory with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Simple AD, you cannot reset the password for any user that is a member of either
        /// the <b>Domain Admins</b> or <b>Enterprise Admins</b> group except for the administrator
        /// user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Managed Microsoft AD, you can only reset the password for a user that is in an
        /// OU based off of the NetBIOS name that you typed when you created your directory. For
        /// example, you cannot reset the password for a user in the <b>Amazon Web Services Reserved</b>
        /// OU. For more information about the OU structure for an Managed Microsoft AD directory,
        /// see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ms_ad_getting_started_what_gets_created.html">What
        /// Gets Created</a> in the <i>Directory Service Administration Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetUserPassword service method.</param>
        /// 
        /// <returns>The response from the ResetUserPassword service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidPasswordException">
        /// The new password provided by the user does not meet the password complexity requirements
        /// defined in your directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UserDoesNotExistException">
        /// The user provided a username that does not exist in your directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ResetUserPassword">REST API Reference for ResetUserPassword Operation</seealso>
        public virtual ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<ResetUserPasswordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetUserPassword operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetUserPassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ResetUserPassword">REST API Reference for ResetUserPassword Operation</seealso>
        public virtual IAsyncResult BeginResetUserPassword(ResetUserPasswordRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetUserPasswordResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetUserPassword.</param>
        /// 
        /// <returns>Returns a  ResetUserPasswordResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ResetUserPassword">REST API Reference for ResetUserPassword Operation</seealso>
        public virtual ResetUserPasswordResponse EndResetUserPassword(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetUserPasswordResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreFromSnapshot

        /// <summary>
        /// Restores a directory using an existing directory snapshot.
        /// 
        ///  
        /// <para>
        /// When you restore a directory from a snapshot, any changes made to the directory after
        /// the snapshot date are overwritten.
        /// </para>
        ///  
        /// <para>
        /// This action returns as soon as the restore operation is initiated. You can monitor
        /// the progress of the restore operation by calling the <a>DescribeDirectories</a> operation
        /// with the directory identifier. When the <b>DirectoryDescription.Stage</b> value changes
        /// to <c>Active</c>, the restore operation is complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreFromSnapshot service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        public virtual RestoreFromSnapshotResponse RestoreFromSnapshot(RestoreFromSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        public virtual IAsyncResult BeginRestoreFromSnapshot(RestoreFromSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreFromSnapshotResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        public virtual RestoreFromSnapshotResponse EndRestoreFromSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreFromSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  ShareDirectory

        /// <summary>
        /// Shares a specified directory (<c>DirectoryId</c>) in your Amazon Web Services account
        /// (directory owner) with another Amazon Web Services account (directory consumer). With
        /// this operation you can use your directory from any Amazon Web Services account and
        /// from any Amazon VPC within an Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// When you share your Managed Microsoft AD directory, Directory Service creates a shared
        /// directory in the directory consumer account. This shared directory contains the metadata
        /// to provide access to the directory within the directory owner account. The shared
        /// directory is visible in all VPCs in the directory consumer account.
        /// </para>
        ///  
        /// <para>
        /// The <c>ShareMethod</c> parameter determines whether the specified directory can be
        /// shared between Amazon Web Services accounts inside the same Amazon Web Services organization
        /// (<c>ORGANIZATIONS</c>). It also determines whether you can share the directory with
        /// any other Amazon Web Services account either inside or outside of the organization
        /// (<c>HANDSHAKE</c>).
        /// </para>
        ///  
        /// <para>
        /// The <c>ShareNotes</c> parameter is only used when <c>HANDSHAKE</c> is called, which
        /// sends a directory sharing request to the directory consumer. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ShareDirectory service method.</param>
        /// 
        /// <returns>The response from the ShareDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryAlreadySharedException">
        /// The specified directory has already been shared with this Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidTargetException">
        /// The specified shared target is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.OrganizationsException">
        /// Exception encountered while trying to access your Amazon Web Services organization.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ShareLimitExceededException">
        /// The maximum number of Amazon Web Services accounts that you can share with this directory
        /// has been reached.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ShareDirectory">REST API Reference for ShareDirectory Operation</seealso>
        public virtual ShareDirectoryResponse ShareDirectory(ShareDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ShareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShareDirectoryResponseUnmarshaller.Instance;

            return Invoke<ShareDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ShareDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ShareDirectory operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndShareDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ShareDirectory">REST API Reference for ShareDirectory Operation</seealso>
        public virtual IAsyncResult BeginShareDirectory(ShareDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ShareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShareDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ShareDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginShareDirectory.</param>
        /// 
        /// <returns>Returns a  ShareDirectoryResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ShareDirectory">REST API Reference for ShareDirectory Operation</seealso>
        public virtual ShareDirectoryResponse EndShareDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<ShareDirectoryResponse>(asyncResult);
        }

        #endregion
        
        #region  StartADAssessment

        /// <summary>
        /// Initiates a directory assessment to validate your self-managed AD environment for
        /// hybrid domain join. The assessment checks compatibility and connectivity of the self-managed
        /// AD environment.
        /// 
        ///  
        /// <para>
        /// A directory assessment is automatically created when you create a hybrid directory.
        /// There are two types of assessments: <c>CUSTOMER</c> and <c>SYSTEM</c>. Your Amazon
        /// Web Services account has a limit of 100 <c>CUSTOMER</c> directory assessments.
        /// </para>
        ///  
        /// <para>
        /// The assessment process typically takes 30 minutes or more to complete. The assessment
        /// process is asynchronous and you can monitor it with <c>DescribeADAssessment</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>InstanceIds</c> must have a one-to-one correspondence with <c>CustomerDnsIps</c>,
        /// meaning that if the IP address for instance i-10243410 is 10.24.34.100 and the IP
        /// address for instance i-10243420 is 10.24.34.200, then the input arrays must maintain
        /// the same order relationship, either [10.24.34.100, 10.24.34.200] paired with [i-10243410,
        /// i-10243420] or [10.24.34.200, 10.24.34.100] paired with [i-10243420, i-10243410].
        /// </para>
        ///  
        /// <para>
        /// Note: You must provide exactly one <c>DirectoryId</c> or <c>AssessmentConfiguration</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartADAssessment service method.</param>
        /// 
        /// <returns>The response from the StartADAssessment service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ADAssessmentLimitExceededException">
        /// A directory assessment is automatically created when you create a hybrid directory.
        /// There are two types of assessments: <c>CUSTOMER</c> and <c>SYSTEM</c>. Your Amazon
        /// Web Services account has a limit of 100 <c>CUSTOMER</c> directory assessments.
        /// 
        ///  
        /// <para>
        /// If you attempt to create a hybrid directory; and you already have 100 <c>CUSTOMER</c>
        /// directory assessments;, you will encounter an error. Delete assessments to free up
        /// capacity before trying again.
        /// </para>
        ///  
        /// <para>
        /// You can request an increase to your <c>CUSTOMER</c> directory assessment quota by
        /// contacting customer support or delete existing CUSTOMER directory assessments; to
        /// free up capacity.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/StartADAssessment">REST API Reference for StartADAssessment Operation</seealso>
        public virtual StartADAssessmentResponse StartADAssessment(StartADAssessmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartADAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartADAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartADAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartADAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartADAssessment operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartADAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/StartADAssessment">REST API Reference for StartADAssessment Operation</seealso>
        public virtual IAsyncResult BeginStartADAssessment(StartADAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartADAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartADAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartADAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartADAssessment.</param>
        /// 
        /// <returns>Returns a  StartADAssessmentResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/StartADAssessment">REST API Reference for StartADAssessment Operation</seealso>
        public virtual StartADAssessmentResponse EndStartADAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<StartADAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSchemaExtension

        /// <summary>
        /// Applies a schema extension to a Microsoft AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSchemaExtension service method.</param>
        /// 
        /// <returns>The response from the StartSchemaExtension service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.SnapshotLimitExceededException">
        /// The maximum number of manual snapshots for the directory has been reached. You can
        /// use the <a>GetSnapshotLimits</a> operation to determine the snapshot limits for a
        /// directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/StartSchemaExtension">REST API Reference for StartSchemaExtension Operation</seealso>
        public virtual StartSchemaExtensionResponse StartSchemaExtension(StartSchemaExtensionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaExtensionResponseUnmarshaller.Instance;

            return Invoke<StartSchemaExtensionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSchemaExtension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSchemaExtension operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSchemaExtension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/StartSchemaExtension">REST API Reference for StartSchemaExtension Operation</seealso>
        public virtual IAsyncResult BeginStartSchemaExtension(StartSchemaExtensionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaExtensionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSchemaExtension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSchemaExtension.</param>
        /// 
        /// <returns>Returns a  StartSchemaExtensionResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/StartSchemaExtension">REST API Reference for StartSchemaExtension Operation</seealso>
        public virtual StartSchemaExtensionResponse EndStartSchemaExtension(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSchemaExtensionResponse>(asyncResult);
        }

        #endregion
        
        #region  UnshareDirectory

        /// <summary>
        /// Stops the directory sharing between the directory owner and consumer accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnshareDirectory service method.</param>
        /// 
        /// <returns>The response from the UnshareDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryNotSharedException">
        /// The specified directory has not been shared with this Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidTargetException">
        /// The specified shared target is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UnshareDirectory">REST API Reference for UnshareDirectory Operation</seealso>
        public virtual UnshareDirectoryResponse UnshareDirectory(UnshareDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnshareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnshareDirectoryResponseUnmarshaller.Instance;

            return Invoke<UnshareDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnshareDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnshareDirectory operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnshareDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UnshareDirectory">REST API Reference for UnshareDirectory Operation</seealso>
        public virtual IAsyncResult BeginUnshareDirectory(UnshareDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnshareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnshareDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnshareDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnshareDirectory.</param>
        /// 
        /// <returns>Returns a  UnshareDirectoryResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UnshareDirectory">REST API Reference for UnshareDirectory Operation</seealso>
        public virtual UnshareDirectoryResponse EndUnshareDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<UnshareDirectoryResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConditionalForwarder

        /// <summary>
        /// Updates a conditional forwarder that has been set up for your Amazon Web Services
        /// directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConditionalForwarder service method.</param>
        /// 
        /// <returns>The response from the UpdateConditionalForwarder service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateConditionalForwarder">REST API Reference for UpdateConditionalForwarder Operation</seealso>
        public virtual UpdateConditionalForwarderResponse UpdateConditionalForwarder(UpdateConditionalForwarderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<UpdateConditionalForwarderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConditionalForwarder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConditionalForwarder operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConditionalForwarder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateConditionalForwarder">REST API Reference for UpdateConditionalForwarder Operation</seealso>
        public virtual IAsyncResult BeginUpdateConditionalForwarder(UpdateConditionalForwarderRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConditionalForwarderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConditionalForwarder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConditionalForwarder.</param>
        /// 
        /// <returns>Returns a  UpdateConditionalForwarderResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateConditionalForwarder">REST API Reference for UpdateConditionalForwarder Operation</seealso>
        public virtual UpdateConditionalForwarderResponse EndUpdateConditionalForwarder(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConditionalForwarderResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDirectorySetup

        /// <summary>
        /// Updates the directory for a particular update type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectorySetup service method.</param>
        /// 
        /// <returns>The response from the UpdateDirectorySetup service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryInDesiredStateException">
        /// The directory is already updated to desired update type settings.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.SnapshotLimitExceededException">
        /// The maximum number of manual snapshots for the directory has been reached. You can
        /// use the <a>GetSnapshotLimits</a> operation to determine the snapshot limits for a
        /// directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateDirectorySetup">REST API Reference for UpdateDirectorySetup Operation</seealso>
        public virtual UpdateDirectorySetupResponse UpdateDirectorySetup(UpdateDirectorySetupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDirectorySetupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDirectorySetupResponseUnmarshaller.Instance;

            return Invoke<UpdateDirectorySetupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDirectorySetup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectorySetup operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDirectorySetup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateDirectorySetup">REST API Reference for UpdateDirectorySetup Operation</seealso>
        public virtual IAsyncResult BeginUpdateDirectorySetup(UpdateDirectorySetupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDirectorySetupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDirectorySetupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDirectorySetup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDirectorySetup.</param>
        /// 
        /// <returns>Returns a  UpdateDirectorySetupResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateDirectorySetup">REST API Reference for UpdateDirectorySetup Operation</seealso>
        public virtual UpdateDirectorySetupResponse EndUpdateDirectorySetup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDirectorySetupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateHybridAD

        /// <summary>
        /// Updates the configuration of an existing hybrid directory. You can recover hybrid
        /// directory administrator account or modify self-managed instance settings.
        /// 
        ///  
        /// <para>
        /// Updates are applied asynchronously. Use <a>DescribeHybridADUpdate</a> to monitor the
        /// progress of configuration changes.
        /// </para>
        ///  
        /// <para>
        /// The <c>InstanceIds</c> must have a one-to-one correspondence with <c>CustomerDnsIps</c>,
        /// meaning that if the IP address for instance i-10243410 is 10.24.34.100 and the IP
        /// address for instance i-10243420 is 10.24.34.200, then the input arrays must maintain
        /// the same order relationship, either [10.24.34.100, 10.24.34.200] paired with [i-10243410,
        /// i-10243420] or [10.24.34.200, 10.24.34.100] paired with [i-10243420, i-10243410].
        /// </para>
        ///  <note> 
        /// <para>
        /// You must provide at least one update to <a>UpdateHybridADRequest$HybridAdministratorAccountUpdate</a>
        /// or <a>UpdateHybridADRequest$SelfManagedInstancesSettings</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHybridAD service method.</param>
        /// 
        /// <returns>The response from the UpdateHybridAD service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ADAssessmentLimitExceededException">
        /// A directory assessment is automatically created when you create a hybrid directory.
        /// There are two types of assessments: <c>CUSTOMER</c> and <c>SYSTEM</c>. Your Amazon
        /// Web Services account has a limit of 100 <c>CUSTOMER</c> directory assessments.
        /// 
        ///  
        /// <para>
        /// If you attempt to create a hybrid directory; and you already have 100 <c>CUSTOMER</c>
        /// directory assessments;, you will encounter an error. Delete assessments to free up
        /// capacity before trying again.
        /// </para>
        ///  
        /// <para>
        /// You can request an increase to your <c>CUSTOMER</c> directory assessment quota by
        /// contacting customer support or delete existing CUSTOMER directory assessments; to
        /// free up capacity.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateHybridAD">REST API Reference for UpdateHybridAD Operation</seealso>
        public virtual UpdateHybridADResponse UpdateHybridAD(UpdateHybridADRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHybridADRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHybridADResponseUnmarshaller.Instance;

            return Invoke<UpdateHybridADResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHybridAD operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHybridAD operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHybridAD
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateHybridAD">REST API Reference for UpdateHybridAD Operation</seealso>
        public virtual IAsyncResult BeginUpdateHybridAD(UpdateHybridADRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateHybridADRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHybridADResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHybridAD operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHybridAD.</param>
        /// 
        /// <returns>Returns a  UpdateHybridADResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateHybridAD">REST API Reference for UpdateHybridAD Operation</seealso>
        public virtual UpdateHybridADResponse EndUpdateHybridAD(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateHybridADResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNumberOfDomainControllers

        /// <summary>
        /// Adds or removes domain controllers to or from the directory. Based on the difference
        /// between current value and new value (provided through this API call), domain controllers
        /// will be added or removed. It may take up to 45 minutes for any new domain controllers
        /// to become fully active once the requested number of domain controllers is updated.
        /// During this time, you cannot make another update request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNumberOfDomainControllers service method.</param>
        /// 
        /// <returns>The response from the UpdateNumberOfDomainControllers service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DomainControllerLimitExceededException">
        /// The maximum allowed number of domain controllers per directory was exceeded. The default
        /// limit per directory is 20 domain controllers.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateNumberOfDomainControllers">REST API Reference for UpdateNumberOfDomainControllers Operation</seealso>
        public virtual UpdateNumberOfDomainControllersResponse UpdateNumberOfDomainControllers(UpdateNumberOfDomainControllersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNumberOfDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNumberOfDomainControllersResponseUnmarshaller.Instance;

            return Invoke<UpdateNumberOfDomainControllersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNumberOfDomainControllers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNumberOfDomainControllers operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNumberOfDomainControllers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateNumberOfDomainControllers">REST API Reference for UpdateNumberOfDomainControllers Operation</seealso>
        public virtual IAsyncResult BeginUpdateNumberOfDomainControllers(UpdateNumberOfDomainControllersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNumberOfDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNumberOfDomainControllersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNumberOfDomainControllers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNumberOfDomainControllers.</param>
        /// 
        /// <returns>Returns a  UpdateNumberOfDomainControllersResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateNumberOfDomainControllers">REST API Reference for UpdateNumberOfDomainControllers Operation</seealso>
        public virtual UpdateNumberOfDomainControllersResponse EndUpdateNumberOfDomainControllers(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNumberOfDomainControllersResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRadius

        /// <summary>
        /// Updates the Remote Authentication Dial In User Service (RADIUS) server information
        /// for an AD Connector or Microsoft AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRadius service method.</param>
        /// 
        /// <returns>The response from the UpdateRadius service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateRadius">REST API Reference for UpdateRadius Operation</seealso>
        public virtual UpdateRadiusResponse UpdateRadius(UpdateRadiusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRadiusResponseUnmarshaller.Instance;

            return Invoke<UpdateRadiusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRadius operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRadius operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRadius
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateRadius">REST API Reference for UpdateRadius Operation</seealso>
        public virtual IAsyncResult BeginUpdateRadius(UpdateRadiusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRadiusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRadius operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRadius.</param>
        /// 
        /// <returns>Returns a  UpdateRadiusResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateRadius">REST API Reference for UpdateRadius Operation</seealso>
        public virtual UpdateRadiusResponse EndUpdateRadius(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRadiusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSettings

        /// <summary>
        /// Updates the configurable settings for the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateSettings service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryDoesNotExistException">
        /// The specified directory does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.IncompatibleSettingsException">
        /// The specified directory setting is not compatible with other settings.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedSettingsException">
        /// The specified directory setting is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateSettings">REST API Reference for UpdateSettings Operation</seealso>
        public virtual UpdateSettingsResponse UpdateSettings(UpdateSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSettings operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateSettings">REST API Reference for UpdateSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateSettings(UpdateSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSettings.</param>
        /// 
        /// <returns>Returns a  UpdateSettingsResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateSettings">REST API Reference for UpdateSettings Operation</seealso>
        public virtual UpdateSettingsResponse EndUpdateSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTrust

        /// <summary>
        /// Updates the trust that has been set up between your Managed Microsoft AD directory
        /// and an self-managed Active Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrust service method.</param>
        /// 
        /// <returns>The response from the UpdateTrust service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateTrust">REST API Reference for UpdateTrust Operation</seealso>
        public virtual UpdateTrustResponse UpdateTrust(UpdateTrustRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustResponseUnmarshaller.Instance;

            return Invoke<UpdateTrustResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrust operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrust operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrust
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateTrust">REST API Reference for UpdateTrust Operation</seealso>
        public virtual IAsyncResult BeginUpdateTrust(UpdateTrustRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrust operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrust.</param>
        /// 
        /// <returns>Returns a  UpdateTrustResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateTrust">REST API Reference for UpdateTrust Operation</seealso>
        public virtual UpdateTrustResponse EndUpdateTrust(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTrustResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyTrust

        /// <summary>
        /// Directory Service for Microsoft Active Directory allows you to configure and verify
        /// trust relationships.
        /// 
        ///  
        /// <para>
        /// This action verifies a trust relationship between your Managed Microsoft AD directory
        /// and an external domain.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyTrust service method.</param>
        /// 
        /// <returns>The response from the VerifyTrust service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/VerifyTrust">REST API Reference for VerifyTrust Operation</seealso>
        public virtual VerifyTrustResponse VerifyTrust(VerifyTrustRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyTrustResponseUnmarshaller.Instance;

            return Invoke<VerifyTrustResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyTrust operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyTrust operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyTrust
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/VerifyTrust">REST API Reference for VerifyTrust Operation</seealso>
        public virtual IAsyncResult BeginVerifyTrust(VerifyTrustRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyTrustResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyTrust operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyTrust.</param>
        /// 
        /// <returns>Returns a  VerifyTrustResult from DirectoryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/VerifyTrust">REST API Reference for VerifyTrust Operation</seealso>
        public virtual VerifyTrustResponse EndVerifyTrust(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyTrustResponse>(asyncResult);
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
            var resolver = new AmazonDirectoryServiceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}