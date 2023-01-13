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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ResourceGroups.Model;
using Amazon.ResourceGroups.Model.Internal.MarshallTransformations;
using Amazon.ResourceGroups.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ResourceGroups
{
    /// <summary>
    /// Implementation for accessing ResourceGroups
    ///
    /// Resource Groups lets you organize Amazon Web Services resources such as Amazon Elastic
    /// Compute Cloud instances, Amazon Relational Database Service databases, and Amazon
    /// Simple Storage Service buckets into groups using criteria that you define as tags.
    /// A resource group is a collection of resources that match the resource types specified
    /// in a query, and share one or more tags or portions of tags. You can create a group
    /// of resources based on their roles in your cloud infrastructure, lifecycle stages,
    /// regions, application layers, or virtually any criteria. Resource Groups enable you
    /// to automate management tasks, such as those in Amazon Web Services Systems Manager
    /// Automation documents, on tag-related resources in Amazon Web Services Systems Manager.
    /// Groups of tagged resources also let you quickly view a custom console in Amazon Web
    /// Services Systems Manager that shows Config compliance and other monitoring data about
    /// member resources.
    /// 
    ///  
    /// <para>
    /// To create a resource group, build a resource query, and specify tags that identify
    /// the criteria that members of the group have in common. Tags are key-value pairs.
    /// </para>
    ///  
    /// <para>
    /// For more information about Resource Groups, see the <a href="https://docs.aws.amazon.com/ARG/latest/userguide/welcome.html">Resource
    /// Groups User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// Resource Groups uses a REST-compliant API that you can use to perform the following
    /// types of operations.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Create, Read, Update, and Delete (CRUD) operations on resource groups and resource
    /// query entities
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Applying, editing, and removing tags from resource groups
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Resolving resource group member ARNs so they can be returned as search results
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Getting data about resources that are members of a group
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Searching Amazon Web Services resources based on a resource query
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonResourceGroupsClient : AmazonServiceClient, IAmazonResourceGroups
    {
        private static IServiceMetadata serviceMetadata = new AmazonResourceGroupsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IResourceGroupsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IResourceGroupsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ResourceGroupsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with the credentials loaded from the application's
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
        public AmazonResourceGroupsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonResourceGroupsConfig()) { }

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with the credentials loaded from the application's
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
        public AmazonResourceGroupsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonResourceGroupsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonResourceGroupsClient Configuration Object</param>
        public AmazonResourceGroupsClient(AmazonResourceGroupsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonResourceGroupsClient(AWSCredentials credentials)
            : this(credentials, new AmazonResourceGroupsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceGroupsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonResourceGroupsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with AWS Credentials and an
        /// AmazonResourceGroupsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonResourceGroupsClient Configuration Object</param>
        public AmazonResourceGroupsClient(AWSCredentials credentials, AmazonResourceGroupsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonResourceGroupsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResourceGroupsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceGroupsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResourceGroupsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResourceGroupsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonResourceGroupsClient Configuration Object</param>
        public AmazonResourceGroupsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonResourceGroupsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonResourceGroupsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResourceGroupsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceGroupsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResourceGroupsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceGroupsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResourceGroupsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonResourceGroupsClient Configuration Object</param>
        public AmazonResourceGroupsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonResourceGroupsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonResourceGroupsEndpointResolver());
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


        #region  CreateGroup

        /// <summary>
        /// Creates a resource group with the specified name and description. You can optionally
        /// include either a resource query or a service configuration. For more information about
        /// constructing a resource query, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/getting_started-query.html">Build
        /// queries and groups in Resource Groups</a> in the <i>Resource Groups User Guide</i>.
        /// For more information about service-linked groups and service configurations, see <a
        /// href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
        /// configurations for Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:CreateGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroup

        /// <summary>
        /// Deletes the specified resource group. Deleting a resource group does not delete any
        /// resources that are members of the group; it only deletes the group structure.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:DeleteGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountSettings

        /// <summary>
        /// Retrieves the current status of optional features in Resource Groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual IAsyncResult BeginGetAccountSettings(GetAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSettings.</param>
        /// 
        /// <returns>Returns a  GetAccountSettingsResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse EndGetAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroup

        /// <summary>
        /// Returns information about a specified resource group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse EndGetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroupConfiguration

        /// <summary>
        /// Retrieves the service configuration associated with the specified resource group.
        /// For details about the service configuration syntax, see <a href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
        /// configurations for Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetGroupConfiguration</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetGroupConfiguration service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupConfiguration">REST API Reference for GetGroupConfiguration Operation</seealso>
        public virtual GetGroupConfigurationResponse GetGroupConfiguration(GetGroupConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetGroupConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupConfiguration operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupConfiguration">REST API Reference for GetGroupConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetGroupConfiguration(GetGroupConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupConfiguration.</param>
        /// 
        /// <returns>Returns a  GetGroupConfigurationResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupConfiguration">REST API Reference for GetGroupConfiguration Operation</seealso>
        public virtual GetGroupConfigurationResponse EndGetGroupConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroupQuery

        /// <summary>
        /// Retrieves the resource query associated with the specified resource group. For more
        /// information about resource queries, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html#gettingstarted-query-cli-tag">Create
        /// a tag-based group in Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetGroupQuery</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupQuery service method.</param>
        /// 
        /// <returns>The response from the GetGroupQuery service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupQuery">REST API Reference for GetGroupQuery Operation</seealso>
        public virtual GetGroupQueryResponse GetGroupQuery(GetGroupQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupQueryResponseUnmarshaller.Instance;

            return Invoke<GetGroupQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupQuery operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupQuery">REST API Reference for GetGroupQuery Operation</seealso>
        public virtual IAsyncResult BeginGetGroupQuery(GetGroupQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupQuery.</param>
        /// 
        /// <returns>Returns a  GetGroupQueryResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetGroupQuery">REST API Reference for GetGroupQuery Operation</seealso>
        public virtual GetGroupQueryResponse EndGetGroupQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupQueryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTags

        /// <summary>
        /// Returns a list of tags that are associated with a resource group, specified by an
        /// ARN.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GetTags</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual GetTagsResponse GetTags(GetTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTags operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual IAsyncResult BeginGetTags(GetTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTags.</param>
        /// 
        /// <returns>Returns a  GetTagsResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual GetTagsResponse EndGetTags(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  GroupResources

        /// <summary>
        /// Adds the specified resources to the specified group.
        /// 
        ///  <important> 
        /// <para>
        /// You can use this operation with only resource groups that are configured with the
        /// following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AWS::EC2::HostManagement</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::EC2::CapacityReservationPool</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Other resource group type and resource types aren't currently supported by this operation.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:GroupResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GroupResources service method.</param>
        /// 
        /// <returns>The response from the GroupResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GroupResources">REST API Reference for GroupResources Operation</seealso>
        public virtual GroupResourcesResponse GroupResources(GroupResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GroupResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GroupResourcesResponseUnmarshaller.Instance;

            return Invoke<GroupResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GroupResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GroupResources operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGroupResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GroupResources">REST API Reference for GroupResources Operation</seealso>
        public virtual IAsyncResult BeginGroupResources(GroupResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GroupResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GroupResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GroupResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGroupResources.</param>
        /// 
        /// <returns>Returns a  GroupResourcesResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/GroupResources">REST API Reference for GroupResources Operation</seealso>
        public virtual GroupResourcesResponse EndGroupResources(IAsyncResult asyncResult)
        {
            return EndInvoke<GroupResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroupResources

        /// <summary>
        /// Returns a list of ARNs of the resources that are members of a specified resource group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:ListGroupResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:DescribeStacks</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:ListStackResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag:GetResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupResources service method.</param>
        /// 
        /// <returns>The response from the ListGroupResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        public virtual ListGroupResourcesResponse ListGroupResources(ListGroupResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupResourcesResponseUnmarshaller.Instance;

            return Invoke<ListGroupResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupResources operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        public virtual IAsyncResult BeginListGroupResources(ListGroupResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupResources.</param>
        /// 
        /// <returns>Returns a  ListGroupResourcesResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        public virtual ListGroupResourcesResponse EndListGroupResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Returns a list of existing Resource Groups in your account.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:ListGroups</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutGroupConfiguration

        /// <summary>
        /// Attaches a service configuration to the specified group. This occurs asynchronously,
        /// and can take time to complete. You can use <a>GetGroupConfiguration</a> to check the
        /// status of the update.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:PutGroupConfiguration</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutGroupConfiguration service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/PutGroupConfiguration">REST API Reference for PutGroupConfiguration Operation</seealso>
        public virtual PutGroupConfigurationResponse PutGroupConfiguration(PutGroupConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGroupConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGroupConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutGroupConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGroupConfiguration operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutGroupConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/PutGroupConfiguration">REST API Reference for PutGroupConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutGroupConfiguration(PutGroupConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutGroupConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGroupConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutGroupConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGroupConfiguration.</param>
        /// 
        /// <returns>Returns a  PutGroupConfigurationResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/PutGroupConfiguration">REST API Reference for PutGroupConfiguration Operation</seealso>
        public virtual PutGroupConfigurationResponse EndPutGroupConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutGroupConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchResources

        /// <summary>
        /// Returns a list of Amazon Web Services resource identifiers that matches the specified
        /// query. The query uses the same format as a resource query in a <a>CreateGroup</a>
        /// or <a>UpdateGroupQuery</a> operation.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:SearchResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:DescribeStacks</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cloudformation:ListStackResources</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag:GetResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchResources service method.</param>
        /// 
        /// <returns>The response from the SearchResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/SearchResources">REST API Reference for SearchResources Operation</seealso>
        public virtual SearchResourcesResponse SearchResources(SearchResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResourcesResponseUnmarshaller.Instance;

            return Invoke<SearchResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchResources operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/SearchResources">REST API Reference for SearchResources Operation</seealso>
        public virtual IAsyncResult BeginSearchResources(SearchResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchResources.</param>
        /// 
        /// <returns>Returns a  SearchResourcesResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/SearchResources">REST API Reference for SearchResources Operation</seealso>
        public virtual SearchResourcesResponse EndSearchResources(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  Tag

        /// <summary>
        /// Adds tags to a resource group with the specified ARN. Existing tags on a resource
        /// group are not changed if they are not specified in the request parameters.
        /// 
        ///  <important> 
        /// <para>
        /// Do not store personally identifiable information (PII) or other confidential or sensitive
        /// information in tags. We use tags to provide you with billing and administration services.
        /// Tags are not intended to be used for private or sensitive data.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:Tag</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Tag service method.</param>
        /// 
        /// <returns>The response from the Tag service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Tag">REST API Reference for Tag Operation</seealso>
        public virtual TagResponse Tag(TagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResponseUnmarshaller.Instance;

            return Invoke<TagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Tag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Tag operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Tag">REST API Reference for Tag Operation</seealso>
        public virtual IAsyncResult BeginTag(TagRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Tag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTag.</param>
        /// 
        /// <returns>Returns a  TagResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Tag">REST API Reference for Tag Operation</seealso>
        public virtual TagResponse EndTag(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResponse>(asyncResult);
        }

        #endregion
        
        #region  UngroupResources

        /// <summary>
        /// Removes the specified resources from the specified group. This operation works only
        /// with static groups that you populated using the <a>GroupResources</a> operation. It
        /// doesn't work with any resource groups that are automatically populated by tag-based
        /// or CloudFormation stack-based queries.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:UngroupResources</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UngroupResources service method.</param>
        /// 
        /// <returns>The response from the UngroupResources service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UngroupResources">REST API Reference for UngroupResources Operation</seealso>
        public virtual UngroupResourcesResponse UngroupResources(UngroupResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UngroupResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UngroupResourcesResponseUnmarshaller.Instance;

            return Invoke<UngroupResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UngroupResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UngroupResources operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUngroupResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UngroupResources">REST API Reference for UngroupResources Operation</seealso>
        public virtual IAsyncResult BeginUngroupResources(UngroupResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UngroupResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UngroupResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UngroupResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUngroupResources.</param>
        /// 
        /// <returns>Returns a  UngroupResourcesResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UngroupResources">REST API Reference for UngroupResources Operation</seealso>
        public virtual UngroupResourcesResponse EndUngroupResources(IAsyncResult asyncResult)
        {
            return EndInvoke<UngroupResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  Untag

        /// <summary>
        /// Deletes tags from a specified resource group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:Untag</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Untag service method.</param>
        /// 
        /// <returns>The response from the Untag service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Untag">REST API Reference for Untag Operation</seealso>
        public virtual UntagResponse Untag(UntagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResponseUnmarshaller.Instance;

            return Invoke<UntagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Untag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Untag operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntag
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Untag">REST API Reference for Untag Operation</seealso>
        public virtual IAsyncResult BeginUntag(UntagRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Untag operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntag.</param>
        /// 
        /// <returns>Returns a  UntagResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/Untag">REST API Reference for Untag Operation</seealso>
        public virtual UntagResponse EndUntag(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccountSettings

        /// <summary>
        /// Turns on or turns off optional features in Resource Groups.
        /// 
        ///  
        /// <para>
        /// The preceding example shows that the request to turn on group lifecycle events is
        /// <code>IN_PROGRESS</code>. You can call the <a>GetAccountSettings</a> operation to
        /// check for completion by looking for <code>GroupLifecycleEventsStatus</code> to change
        /// to <code>ACTIVE</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccountSettings(UpdateAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountSettings.</param>
        /// 
        /// <returns>Returns a  UpdateAccountSettingsResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual UpdateAccountSettingsResponse EndUpdateAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGroup

        /// <summary>
        /// Updates the description for an existing group. You cannot update the name of a resource
        /// group.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:UpdateGroup</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGroupQuery

        /// <summary>
        /// Updates the resource query of a group. For more information about resource queries,
        /// see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html#gettingstarted-query-cli-tag">Create
        /// a tag-based group in Resource Groups</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-groups:UpdateGroupQuery</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupQuery service method.</param>
        /// 
        /// <returns>The response from the UpdateGroupQuery service method, as returned by ResourceGroups.</returns>
        /// <exception cref="Amazon.ResourceGroups.Model.BadRequestException">
        /// The request includes one or more parameters that violate validation rules.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.ForbiddenException">
        /// The caller isn't authorized to make the request. Check permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.InternalServerErrorException">
        /// An internal error occurred while processing the request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.MethodNotAllowedException">
        /// The request uses an HTTP method that isn't allowed for the specified resource.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.NotFoundException">
        /// One or more of the specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroups.Model.TooManyRequestsException">
        /// You've exceeded throttling limits by making too many requests in a period of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroupQuery">REST API Reference for UpdateGroupQuery Operation</seealso>
        public virtual UpdateGroupQueryResponse UpdateGroupQuery(UpdateGroupQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupQueryResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroupQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupQuery operation on AmazonResourceGroupsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroupQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroupQuery">REST API Reference for UpdateGroupQuery Operation</seealso>
        public virtual IAsyncResult BeginUpdateGroupQuery(UpdateGroupQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroupQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroupQuery.</param>
        /// 
        /// <returns>Returns a  UpdateGroupQueryResult from ResourceGroups.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-groups-2017-11-27/UpdateGroupQuery">REST API Reference for UpdateGroupQuery Operation</seealso>
        public virtual UpdateGroupQueryResponse EndUpdateGroupQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupQueryResponse>(asyncResult);
        }

        #endregion
        
    }
}