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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.DirectoryService.Model;
using Amazon.DirectoryService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DirectoryService
{
    /// <summary>
    /// Implementation for accessing DirectoryService
    ///
    /// AWS Directory Service 
    /// <para>
    /// AWS Directory Service is a web service that makes it easy for you to setup and run
    /// directories in the AWS cloud, or connect your AWS resources with an existing on-premises
    /// Microsoft Active Directory. This guide provides detailed information about AWS Directory
    /// Service operations, data types, parameters, and errors. For information about AWS
    /// Directory Services features, see <a href="https://aws.amazon.com/directoryservice/">AWS
    /// Directory Service</a> and the <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/what_is.html">AWS
    /// Directory Service Administration Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .Net, iOS, Android, etc.). The SDKs provide a
    /// convenient way to create programmatic access to AWS Directory Service and other AWS
    /// services. For more information about the AWS SDKs, including how to download and install
    /// them, see <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonDirectoryServiceClient : AmazonServiceClient, IAmazonDirectoryService
    {
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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

        
        #region  AddIpRoutes

        /// <summary>
        /// If the DNS server for your on-premises domain uses a publicly addressable IP address,
        /// you must add a CIDR address block to correctly route traffic to and from your Microsoft
        /// AD on Amazon Web Services. <i>AddIpRoutes</i> adds this address block. You can also
        /// use <i>AddIpRoutes</i> to facilitate routing traffic that uses public IP ranges from
        /// your Microsoft AD on AWS to a peer VPC. 
        /// 
        ///  
        /// <para>
        /// Before you call <i>AddIpRoutes</i>, ensure that all of the required permissions have
        /// been explicitly granted through a policy. For details about what permissions are required
        /// to run the <i>AddIpRoutes</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
        /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddIpRoutes service method.</param>
        /// 
        /// <returns>The response from the AddIpRoutes service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddIpRoutes">REST API Reference for AddIpRoutes Operation</seealso>
        public virtual AddIpRoutesResponse AddIpRoutes(AddIpRoutesRequest request)
        {
            var marshaller = AddIpRoutesRequestMarshaller.Instance;
            var unmarshaller = AddIpRoutesResponseUnmarshaller.Instance;

            return Invoke<AddIpRoutesRequest,AddIpRoutesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddIpRoutesRequestMarshaller.Instance;
            var unmarshaller = AddIpRoutesResponseUnmarshaller.Instance;

            return BeginInvoke<AddIpRoutesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.TagLimitExceededException">
        /// The maximum allowed number of tags was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return BeginInvoke<AddTagsToResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// <code>Initializing</code>, <code>CreatingSnapshot</code>, and <code>UpdatingSchema</code>.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CancelSchemaExtension">REST API Reference for CancelSchemaExtension Operation</seealso>
        public virtual CancelSchemaExtensionResponse CancelSchemaExtension(CancelSchemaExtensionRequest request)
        {
            var marshaller = CancelSchemaExtensionRequestMarshaller.Instance;
            var unmarshaller = CancelSchemaExtensionResponseUnmarshaller.Instance;

            return Invoke<CancelSchemaExtensionRequest,CancelSchemaExtensionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CancelSchemaExtensionRequestMarshaller.Instance;
            var unmarshaller = CancelSchemaExtensionResponseUnmarshaller.Instance;

            return BeginInvoke<CancelSchemaExtensionRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Creates an AD Connector to connect to an on-premises directory.
        /// 
        ///  
        /// <para>
        /// Before you call <i>ConnectDirectory</i>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <i>ConnectDirectory</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
        /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ConnectDirectory">REST API Reference for ConnectDirectory Operation</seealso>
        public virtual ConnectDirectoryResponse ConnectDirectory(ConnectDirectoryRequest request)
        {
            var marshaller = ConnectDirectoryRequestMarshaller.Instance;
            var unmarshaller = ConnectDirectoryResponseUnmarshaller.Instance;

            return Invoke<ConnectDirectoryRequest,ConnectDirectoryResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ConnectDirectoryRequestMarshaller.Instance;
            var unmarshaller = ConnectDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke<ConnectDirectoryRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// is used to construct the access URL for the directory, such as <code>http://&lt;alias&gt;.awsapps.com</code>.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var marshaller = CreateAliasRequestMarshaller.Instance;
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasRequest,CreateAliasResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateAliasRequestMarshaller.Instance;
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Creates a computer account in the specified directory, and joins the computer to the
        /// directory.
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
        /// The specified directory is unavailable or could not be found.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateComputer">REST API Reference for CreateComputer Operation</seealso>
        public virtual CreateComputerResponse CreateComputer(CreateComputerRequest request)
        {
            var marshaller = CreateComputerRequestMarshaller.Instance;
            var unmarshaller = CreateComputerResponseUnmarshaller.Instance;

            return Invoke<CreateComputerRequest,CreateComputerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateComputerRequestMarshaller.Instance;
            var unmarshaller = CreateComputerResponseUnmarshaller.Instance;

            return BeginInvoke<CreateComputerRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Creates a conditional forwarder associated with your AWS directory. Conditional forwarders
        /// are required in order to set up a trust relationship with another domain. The conditional
        /// forwarder points to the trusted domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConditionalForwarder service method.</param>
        /// 
        /// <returns>The response from the CreateConditionalForwarder service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateConditionalForwarder">REST API Reference for CreateConditionalForwarder Operation</seealso>
        public virtual CreateConditionalForwarderResponse CreateConditionalForwarder(CreateConditionalForwarderRequest request)
        {
            var marshaller = CreateConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = CreateConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<CreateConditionalForwarderRequest,CreateConditionalForwarderResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = CreateConditionalForwarderResponseUnmarshaller.Instance;

            return BeginInvoke<CreateConditionalForwarderRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Creates a Simple AD directory.
        /// 
        ///  
        /// <para>
        /// Before you call <i>CreateDirectory</i>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <i>CreateDirectory</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
        /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public virtual CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var marshaller = CreateDirectoryRequestMarshaller.Instance;
            var unmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryRequest,CreateDirectoryResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateDirectoryRequestMarshaller.Instance;
            var unmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDirectoryRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  CreateMicrosoftAD

        /// <summary>
        /// Creates a Microsoft AD in the AWS cloud.
        /// 
        ///  
        /// <para>
        /// Before you call <i>CreateMicrosoftAD</i>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <i>CreateMicrosoftAD</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
        /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateMicrosoftAD">REST API Reference for CreateMicrosoftAD Operation</seealso>
        public virtual CreateMicrosoftADResponse CreateMicrosoftAD(CreateMicrosoftADRequest request)
        {
            var marshaller = CreateMicrosoftADRequestMarshaller.Instance;
            var unmarshaller = CreateMicrosoftADResponseUnmarshaller.Instance;

            return Invoke<CreateMicrosoftADRequest,CreateMicrosoftADResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateMicrosoftADRequestMarshaller.Instance;
            var unmarshaller = CreateMicrosoftADResponseUnmarshaller.Instance;

            return BeginInvoke<CreateMicrosoftADRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Creates a snapshot of a Simple AD or Microsoft AD directory in the AWS cloud.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.SnapshotLimitExceededException">
        /// The maximum number of manual snapshots for the directory has been reached. You can
        /// use the <a>GetSnapshotLimits</a> operation to determine the snapshot limits for a
        /// directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var marshaller = CreateSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// AWS Directory Service for Microsoft Active Directory allows you to configure trust
        /// relationships. For example, you can establish a trust between your Microsoft AD in
        /// the AWS cloud, and your existing on-premises Microsoft Active Directory. This would
        /// allow you to provide users and groups access to resources in either domain, with a
        /// single set of credentials.
        /// 
        ///  
        /// <para>
        /// This action initiates the creation of the AWS side of a trust relationship between
        /// a Microsoft AD in the AWS cloud and an external domain.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateTrust">REST API Reference for CreateTrust Operation</seealso>
        public virtual CreateTrustResponse CreateTrust(CreateTrustRequest request)
        {
            var marshaller = CreateTrustRequestMarshaller.Instance;
            var unmarshaller = CreateTrustResponseUnmarshaller.Instance;

            return Invoke<CreateTrustRequest,CreateTrustResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateTrustRequestMarshaller.Instance;
            var unmarshaller = CreateTrustResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTrustRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  DeleteConditionalForwarder

        /// <summary>
        /// Deletes a conditional forwarder that has been set up for your AWS directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConditionalForwarder service method.</param>
        /// 
        /// <returns>The response from the DeleteConditionalForwarder service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteConditionalForwarder">REST API Reference for DeleteConditionalForwarder Operation</seealso>
        public virtual DeleteConditionalForwarderResponse DeleteConditionalForwarder(DeleteConditionalForwarderRequest request)
        {
            var marshaller = DeleteConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = DeleteConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<DeleteConditionalForwarderRequest,DeleteConditionalForwarderResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = DeleteConditionalForwarderResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteConditionalForwarderRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Deletes an AWS Directory Service directory.
        /// 
        ///  
        /// <para>
        /// Before you call <i>DeleteDirectory</i>, ensure that all of the required permissions
        /// have been explicitly granted through a policy. For details about what permissions
        /// are required to run the <i>DeleteDirectory</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">AWS
        /// Directory Service API Permissions: Actions, Resources, and Conditions Reference</a>.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public virtual DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var marshaller = DeleteDirectoryRequestMarshaller.Instance;
            var unmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryRequest,DeleteDirectoryResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteDirectoryRequestMarshaller.Instance;
            var unmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDirectoryRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var marshaller = DeleteSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotRequest,DeleteSnapshotResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Deletes an existing trust relationship between your Microsoft AD in the AWS cloud
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteTrust">REST API Reference for DeleteTrust Operation</seealso>
        public virtual DeleteTrustResponse DeleteTrust(DeleteTrustRequest request)
        {
            var marshaller = DeleteTrustRequestMarshaller.Instance;
            var unmarshaller = DeleteTrustResponseUnmarshaller.Instance;

            return Invoke<DeleteTrustRequest,DeleteTrustResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteTrustRequestMarshaller.Instance;
            var unmarshaller = DeleteTrustResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTrustRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  DeregisterEventTopic

        /// <summary>
        /// Removes the specified directory as a publisher to the specified SNS topic.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeregisterEventTopic">REST API Reference for DeregisterEventTopic Operation</seealso>
        public virtual DeregisterEventTopicResponse DeregisterEventTopic(DeregisterEventTopicRequest request)
        {
            var marshaller = DeregisterEventTopicRequestMarshaller.Instance;
            var unmarshaller = DeregisterEventTopicResponseUnmarshaller.Instance;

            return Invoke<DeregisterEventTopicRequest,DeregisterEventTopicResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeregisterEventTopicRequestMarshaller.Instance;
            var unmarshaller = DeregisterEventTopicResponseUnmarshaller.Instance;

            return BeginInvoke<DeregisterEventTopicRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeConditionalForwarders">REST API Reference for DescribeConditionalForwarders Operation</seealso>
        public virtual DescribeConditionalForwardersResponse DescribeConditionalForwarders(DescribeConditionalForwardersRequest request)
        {
            var marshaller = DescribeConditionalForwardersRequestMarshaller.Instance;
            var unmarshaller = DescribeConditionalForwardersResponseUnmarshaller.Instance;

            return Invoke<DescribeConditionalForwardersRequest,DescribeConditionalForwardersResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeConditionalForwardersRequestMarshaller.Instance;
            var unmarshaller = DescribeConditionalForwardersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeConditionalForwardersRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// in the <i>DirectoryIds</i> parameter. Otherwise, all directories that belong to the
        /// current account are returned.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> request and
        /// response parameters. If more results are available, the <i>DescribeDirectoriesResult.NextToken</i>
        /// member contains a token that you pass in the next call to <a>DescribeDirectories</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <i>Limit</i> parameter.
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
        /// The <i>NextToken</i> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
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
        /// in the <i>DirectoryIds</i> parameter. Otherwise, all directories that belong to the
        /// current account are returned.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> request and
        /// response parameters. If more results are available, the <i>DescribeDirectoriesResult.NextToken</i>
        /// member contains a token that you pass in the next call to <a>DescribeDirectories</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <i>Limit</i> parameter.
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
        /// The <i>NextToken</i> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectories">REST API Reference for DescribeDirectories Operation</seealso>
        public virtual DescribeDirectoriesResponse DescribeDirectories(DescribeDirectoriesRequest request)
        {
            var marshaller = DescribeDirectoriesRequestMarshaller.Instance;
            var unmarshaller = DescribeDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectoriesRequest,DescribeDirectoriesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeDirectoriesRequestMarshaller.Instance;
            var unmarshaller = DescribeDirectoriesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDirectoriesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The <i>NextToken</i> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDomainControllers">REST API Reference for DescribeDomainControllers Operation</seealso>
        public virtual DescribeDomainControllersResponse DescribeDomainControllers(DescribeDomainControllersRequest request)
        {
            var marshaller = DescribeDomainControllersRequestMarshaller.Instance;
            var unmarshaller = DescribeDomainControllersResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainControllersRequest,DescribeDomainControllersResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeDomainControllersRequestMarshaller.Instance;
            var unmarshaller = DescribeDomainControllersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDomainControllersRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Obtains information about which SNS topics receive status messages from the specified
        /// directory.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeEventTopics">REST API Reference for DescribeEventTopics Operation</seealso>
        public virtual DescribeEventTopicsResponse DescribeEventTopics(DescribeEventTopicsRequest request)
        {
            var marshaller = DescribeEventTopicsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventTopicsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventTopicsRequest,DescribeEventTopicsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeEventTopicsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventTopicsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEventTopicsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The <i>NextToken</i> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var marshaller = DescribeSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsRequest,DescribeSnapshotsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSnapshotsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The <i>NextToken</i> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeTrusts">REST API Reference for DescribeTrusts Operation</seealso>
        public virtual DescribeTrustsResponse DescribeTrusts(DescribeTrustsRequest request)
        {
            var marshaller = DescribeTrustsRequestMarshaller.Instance;
            var unmarshaller = DescribeTrustsResponseUnmarshaller.Instance;

            return Invoke<DescribeTrustsRequest,DescribeTrustsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeTrustsRequestMarshaller.Instance;
            var unmarshaller = DescribeTrustsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTrustsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  DisableRadius

        /// <summary>
        /// Disables multi-factor authentication (MFA) with the Remote Authentication Dial In
        /// User Service (RADIUS) server for an AD Connector directory.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableRadius">REST API Reference for DisableRadius Operation</seealso>
        public virtual DisableRadiusResponse DisableRadius(DisableRadiusRequest request)
        {
            var marshaller = DisableRadiusRequestMarshaller.Instance;
            var unmarshaller = DisableRadiusResponseUnmarshaller.Instance;

            return Invoke<DisableRadiusRequest,DisableRadiusResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DisableRadiusRequestMarshaller.Instance;
            var unmarshaller = DisableRadiusResponseUnmarshaller.Instance;

            return BeginInvoke<DisableRadiusRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableSso">REST API Reference for DisableSso Operation</seealso>
        public virtual DisableSsoResponse DisableSso(DisableSsoRequest request)
        {
            var marshaller = DisableSsoRequestMarshaller.Instance;
            var unmarshaller = DisableSsoResponseUnmarshaller.Instance;

            return Invoke<DisableSsoRequest,DisableSsoResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DisableSsoRequestMarshaller.Instance;
            var unmarshaller = DisableSsoResponseUnmarshaller.Instance;

            return BeginInvoke<DisableSsoRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  EnableRadius

        /// <summary>
        /// Enables multi-factor authentication (MFA) with the Remote Authentication Dial In User
        /// Service (RADIUS) server for an AD Connector directory.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableRadius">REST API Reference for EnableRadius Operation</seealso>
        public virtual EnableRadiusResponse EnableRadius(EnableRadiusRequest request)
        {
            var marshaller = EnableRadiusRequestMarshaller.Instance;
            var unmarshaller = EnableRadiusResponseUnmarshaller.Instance;

            return Invoke<EnableRadiusRequest,EnableRadiusResponse>(request, marshaller, unmarshaller);
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
            var marshaller = EnableRadiusRequestMarshaller.Instance;
            var unmarshaller = EnableRadiusResponseUnmarshaller.Instance;

            return BeginInvoke<EnableRadiusRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Enables single sign-on for a directory.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableSso">REST API Reference for EnableSso Operation</seealso>
        public virtual EnableSsoResponse EnableSso(EnableSsoRequest request)
        {
            var marshaller = EnableSsoRequestMarshaller.Instance;
            var unmarshaller = EnableSsoResponseUnmarshaller.Instance;

            return Invoke<EnableSsoRequest,EnableSsoResponse>(request, marshaller, unmarshaller);
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
            var marshaller = EnableSsoRequestMarshaller.Instance;
            var unmarshaller = EnableSsoResponseUnmarshaller.Instance;

            return BeginInvoke<EnableSsoRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Obtains directory limit information for the current region.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetDirectoryLimits">REST API Reference for GetDirectoryLimits Operation</seealso>
        public virtual GetDirectoryLimitsResponse GetDirectoryLimits()
        {
            return GetDirectoryLimits(new GetDirectoryLimitsRequest());
        }

        /// <summary>
        /// Obtains directory limit information for the current region.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetDirectoryLimits">REST API Reference for GetDirectoryLimits Operation</seealso>
        public virtual GetDirectoryLimitsResponse GetDirectoryLimits(GetDirectoryLimitsRequest request)
        {
            var marshaller = GetDirectoryLimitsRequestMarshaller.Instance;
            var unmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryLimitsRequest,GetDirectoryLimitsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetDirectoryLimitsRequestMarshaller.Instance;
            var unmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return BeginInvoke<GetDirectoryLimitsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetSnapshotLimits">REST API Reference for GetSnapshotLimits Operation</seealso>
        public virtual GetSnapshotLimitsResponse GetSnapshotLimits(GetSnapshotLimitsRequest request)
        {
            var marshaller = GetSnapshotLimitsRequestMarshaller.Instance;
            var unmarshaller = GetSnapshotLimitsResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotLimitsRequest,GetSnapshotLimitsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSnapshotLimitsRequestMarshaller.Instance;
            var unmarshaller = GetSnapshotLimitsResponseUnmarshaller.Instance;

            return BeginInvoke<GetSnapshotLimitsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The <i>NextToken</i> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListIpRoutes">REST API Reference for ListIpRoutes Operation</seealso>
        public virtual ListIpRoutesResponse ListIpRoutes(ListIpRoutesRequest request)
        {
            var marshaller = ListIpRoutesRequestMarshaller.Instance;
            var unmarshaller = ListIpRoutesResponseUnmarshaller.Instance;

            return Invoke<ListIpRoutesRequest,ListIpRoutesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListIpRoutesRequestMarshaller.Instance;
            var unmarshaller = ListIpRoutesResponseUnmarshaller.Instance;

            return BeginInvoke<ListIpRoutesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The <i>NextToken</i> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListSchemaExtensions">REST API Reference for ListSchemaExtensions Operation</seealso>
        public virtual ListSchemaExtensionsResponse ListSchemaExtensions(ListSchemaExtensionsRequest request)
        {
            var marshaller = ListSchemaExtensionsRequestMarshaller.Instance;
            var unmarshaller = ListSchemaExtensionsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaExtensionsRequest,ListSchemaExtensionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListSchemaExtensionsRequestMarshaller.Instance;
            var unmarshaller = ListSchemaExtensionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListSchemaExtensionsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The <i>NextToken</i> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  RegisterEventTopic

        /// <summary>
        /// Associates a directory with an SNS topic. This establishes the directory as a publisher
        /// to the specified SNS topic. You can then receive email or text (SMS) messages when
        /// the status of your directory changes. You get notified if your directory goes from
        /// an Active status to an Impaired or Inoperable status. You also receive a notification
        /// when the directory returns to an Active status.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RegisterEventTopic">REST API Reference for RegisterEventTopic Operation</seealso>
        public virtual RegisterEventTopicResponse RegisterEventTopic(RegisterEventTopicRequest request)
        {
            var marshaller = RegisterEventTopicRequestMarshaller.Instance;
            var unmarshaller = RegisterEventTopicResponseUnmarshaller.Instance;

            return Invoke<RegisterEventTopicRequest,RegisterEventTopicResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RegisterEventTopicRequestMarshaller.Instance;
            var unmarshaller = RegisterEventTopicResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterEventTopicRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveIpRoutes">REST API Reference for RemoveIpRoutes Operation</seealso>
        public virtual RemoveIpRoutesResponse RemoveIpRoutes(RemoveIpRoutesRequest request)
        {
            var marshaller = RemoveIpRoutesRequestMarshaller.Instance;
            var unmarshaller = RemoveIpRoutesResponseUnmarshaller.Instance;

            return Invoke<RemoveIpRoutesRequest,RemoveIpRoutesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RemoveIpRoutesRequestMarshaller.Instance;
            var unmarshaller = RemoveIpRoutesResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveIpRoutesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveTagsFromResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Resets the password for any user in your AWS Managed Microsoft AD or Simple AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetUserPassword service method.</param>
        /// 
        /// <returns>The response from the ResetUserPassword service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidPasswordException">
        /// The new password provided by the user does not meet the password complexity requirements
        /// defined in your directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
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
            var marshaller = ResetUserPasswordRequestMarshaller.Instance;
            var unmarshaller = ResetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<ResetUserPasswordRequest,ResetUserPasswordResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ResetUserPasswordRequestMarshaller.Instance;
            var unmarshaller = ResetUserPasswordResponseUnmarshaller.Instance;

            return BeginInvoke<ResetUserPasswordRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// to <code>Active</code>, the restore operation is complete.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        public virtual RestoreFromSnapshotResponse RestoreFromSnapshot(RestoreFromSnapshotRequest request)
        {
            var marshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            var unmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromSnapshotRequest,RestoreFromSnapshotResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            var unmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<RestoreFromSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.SnapshotLimitExceededException">
        /// The maximum number of manual snapshots for the directory has been reached. You can
        /// use the <a>GetSnapshotLimits</a> operation to determine the snapshot limits for a
        /// directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/StartSchemaExtension">REST API Reference for StartSchemaExtension Operation</seealso>
        public virtual StartSchemaExtensionResponse StartSchemaExtension(StartSchemaExtensionRequest request)
        {
            var marshaller = StartSchemaExtensionRequestMarshaller.Instance;
            var unmarshaller = StartSchemaExtensionResponseUnmarshaller.Instance;

            return Invoke<StartSchemaExtensionRequest,StartSchemaExtensionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartSchemaExtensionRequestMarshaller.Instance;
            var unmarshaller = StartSchemaExtensionResponseUnmarshaller.Instance;

            return BeginInvoke<StartSchemaExtensionRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  UpdateConditionalForwarder

        /// <summary>
        /// Updates a conditional forwarder that has been set up for your AWS directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConditionalForwarder service method.</param>
        /// 
        /// <returns>The response from the UpdateConditionalForwarder service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// The specified directory is unavailable or could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateConditionalForwarder">REST API Reference for UpdateConditionalForwarder Operation</seealso>
        public virtual UpdateConditionalForwarderResponse UpdateConditionalForwarder(UpdateConditionalForwarderRequest request)
        {
            var marshaller = UpdateConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = UpdateConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<UpdateConditionalForwarderRequest,UpdateConditionalForwarderResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = UpdateConditionalForwarderResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateConditionalForwarderRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The specified directory is unavailable or could not be found.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateNumberOfDomainControllers">REST API Reference for UpdateNumberOfDomainControllers Operation</seealso>
        public virtual UpdateNumberOfDomainControllersResponse UpdateNumberOfDomainControllers(UpdateNumberOfDomainControllersRequest request)
        {
            var marshaller = UpdateNumberOfDomainControllersRequestMarshaller.Instance;
            var unmarshaller = UpdateNumberOfDomainControllersResponseUnmarshaller.Instance;

            return Invoke<UpdateNumberOfDomainControllersRequest,UpdateNumberOfDomainControllersResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateNumberOfDomainControllersRequestMarshaller.Instance;
            var unmarshaller = UpdateNumberOfDomainControllersResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateNumberOfDomainControllersRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// for an AD Connector directory.
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateRadius">REST API Reference for UpdateRadius Operation</seealso>
        public virtual UpdateRadiusResponse UpdateRadius(UpdateRadiusRequest request)
        {
            var marshaller = UpdateRadiusRequestMarshaller.Instance;
            var unmarshaller = UpdateRadiusResponseUnmarshaller.Instance;

            return Invoke<UpdateRadiusRequest,UpdateRadiusResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateRadiusRequestMarshaller.Instance;
            var unmarshaller = UpdateRadiusResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateRadiusRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  VerifyTrust

        /// <summary>
        /// AWS Directory Service for Microsoft Active Directory allows you to configure and verify
        /// trust relationships.
        /// 
        ///  
        /// <para>
        /// This action verifies a trust relationship between your Microsoft AD in the AWS cloud
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
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/VerifyTrust">REST API Reference for VerifyTrust Operation</seealso>
        public virtual VerifyTrustResponse VerifyTrust(VerifyTrustRequest request)
        {
            var marshaller = VerifyTrustRequestMarshaller.Instance;
            var unmarshaller = VerifyTrustResponseUnmarshaller.Instance;

            return Invoke<VerifyTrustRequest,VerifyTrustResponse>(request, marshaller, unmarshaller);
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
            var marshaller = VerifyTrustRequestMarshaller.Instance;
            var unmarshaller = VerifyTrustResponseUnmarshaller.Instance;

            return BeginInvoke<VerifyTrustRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
    }
}