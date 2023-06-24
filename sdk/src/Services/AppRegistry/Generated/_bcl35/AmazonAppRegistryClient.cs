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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.AppRegistry.Model;
using Amazon.AppRegistry.Model.Internal.MarshallTransformations;
using Amazon.AppRegistry.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AppRegistry
{
    /// <summary>
    /// Implementation for accessing AppRegistry
    ///
    /// Amazon Web Services Service Catalog AppRegistry enables organizations to understand
    /// the application context of their Amazon Web Services resources. AppRegistry provides
    /// a repository of your applications, their resources, and the application metadata that
    /// you use within your enterprise.
    /// </summary>
    public partial class AmazonAppRegistryClient : AmazonServiceClient, IAmazonAppRegistry
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppRegistryMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IAppRegistryPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAppRegistryPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AppRegistryPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppRegistryClient with the credentials loaded from the application's
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
        public AmazonAppRegistryClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppRegistryConfig()) { }

        /// <summary>
        /// Constructs AmazonAppRegistryClient with the credentials loaded from the application's
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
        public AmazonAppRegistryClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppRegistryConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppRegistryClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppRegistryClient Configuration Object</param>
        public AmazonAppRegistryClient(AmazonAppRegistryConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAppRegistryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppRegistryClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppRegistryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppRegistryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppRegistryClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppRegistryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppRegistryClient with AWS Credentials and an
        /// AmazonAppRegistryClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppRegistryClient Configuration Object</param>
        public AmazonAppRegistryClient(AWSCredentials credentials, AmazonAppRegistryConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppRegistryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppRegistryClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppRegistryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppRegistryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppRegistryClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppRegistryConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppRegistryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppRegistryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppRegistryClient Configuration Object</param>
        public AmazonAppRegistryClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppRegistryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppRegistryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppRegistryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppRegistryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppRegistryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppRegistryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppRegistryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppRegistryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppRegistryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppRegistryClient Configuration Object</param>
        public AmazonAppRegistryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppRegistryConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppRegistryEndpointResolver());
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


        #region  AssociateAttributeGroup

        /// <summary>
        /// Associates an attribute group with an application to augment the application's metadata
        /// with the group's attributes. This feature enables applications to be described with
        /// user-defined details that are machine-readable, such as third-party integrations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the AssociateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/AssociateAttributeGroup">REST API Reference for AssociateAttributeGroup Operation</seealso>
        public virtual AssociateAttributeGroupResponse AssociateAttributeGroup(AssociateAttributeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAttributeGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateAttributeGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAttributeGroup operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAttributeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/AssociateAttributeGroup">REST API Reference for AssociateAttributeGroup Operation</seealso>
        public virtual IAsyncResult BeginAssociateAttributeGroup(AssociateAttributeGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAttributeGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAttributeGroup.</param>
        /// 
        /// <returns>Returns a  AssociateAttributeGroupResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/AssociateAttributeGroup">REST API Reference for AssociateAttributeGroup Operation</seealso>
        public virtual AssociateAttributeGroupResponse EndAssociateAttributeGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAttributeGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateResource

        /// <summary>
        /// Associates a resource with an application. The resource can be specified by its ARN
        /// or name. The application can be specified by ARN, ID, or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResource service method.</param>
        /// 
        /// <returns>The response from the AssociateResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ThrottlingException">
        /// The maximum number of API requests has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/AssociateResource">REST API Reference for AssociateResource Operation</seealso>
        public virtual AssociateResourceResponse AssociateResource(AssociateResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResource operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/AssociateResource">REST API Reference for AssociateResource Operation</seealso>
        public virtual IAsyncResult BeginAssociateResource(AssociateResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateResource.</param>
        /// 
        /// <returns>Returns a  AssociateResourceResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/AssociateResource">REST API Reference for AssociateResource Operation</seealso>
        public virtual AssociateResourceResponse EndAssociateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApplication

        /// <summary>
        /// Creates a new application that is the top-level node in a hierarchy of related cloud
        /// resource abstractions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ThrottlingException">
        /// The maximum number of API requests has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAttributeGroup

        /// <summary>
        /// Creates a new attribute group as a container for user-defined attributes. This feature
        /// enables users to have full control over their cloud application's metadata in a rich
        /// machine-readable format to facilitate integration with automated workflows and third-party
        /// tools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the CreateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/CreateAttributeGroup">REST API Reference for CreateAttributeGroup Operation</seealso>
        public virtual CreateAttributeGroupResponse CreateAttributeGroup(CreateAttributeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAttributeGroupResponseUnmarshaller.Instance;

            return Invoke<CreateAttributeGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAttributeGroup operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAttributeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/CreateAttributeGroup">REST API Reference for CreateAttributeGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateAttributeGroup(CreateAttributeGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAttributeGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAttributeGroup.</param>
        /// 
        /// <returns>Returns a  CreateAttributeGroupResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/CreateAttributeGroup">REST API Reference for CreateAttributeGroup Operation</seealso>
        public virtual CreateAttributeGroupResponse EndCreateAttributeGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAttributeGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplication

        /// <summary>
        /// Deletes an application that is specified either by its application ID, name, or ARN.
        /// All associated attribute groups and resources must be disassociated from it before
        /// deleting an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAttributeGroup

        /// <summary>
        /// Deletes an attribute group, specified either by its attribute group ID, name, or ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DeleteAttributeGroup">REST API Reference for DeleteAttributeGroup Operation</seealso>
        public virtual DeleteAttributeGroupResponse DeleteAttributeGroup(DeleteAttributeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttributeGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteAttributeGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributeGroup operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAttributeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DeleteAttributeGroup">REST API Reference for DeleteAttributeGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteAttributeGroup(DeleteAttributeGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttributeGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttributeGroup.</param>
        /// 
        /// <returns>Returns a  DeleteAttributeGroupResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DeleteAttributeGroup">REST API Reference for DeleteAttributeGroup Operation</seealso>
        public virtual DeleteAttributeGroupResponse EndDeleteAttributeGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAttributeGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateAttributeGroup

        /// <summary>
        /// Disassociates an attribute group from an application to remove the extra attributes
        /// contained in the attribute group from the application's metadata. This operation reverts
        /// <code>AssociateAttributeGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DisassociateAttributeGroup">REST API Reference for DisassociateAttributeGroup Operation</seealso>
        public virtual DisassociateAttributeGroupResponse DisassociateAttributeGroup(DisassociateAttributeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAttributeGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateAttributeGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAttributeGroup operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAttributeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DisassociateAttributeGroup">REST API Reference for DisassociateAttributeGroup Operation</seealso>
        public virtual IAsyncResult BeginDisassociateAttributeGroup(DisassociateAttributeGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAttributeGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAttributeGroup.</param>
        /// 
        /// <returns>Returns a  DisassociateAttributeGroupResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DisassociateAttributeGroup">REST API Reference for DisassociateAttributeGroup Operation</seealso>
        public virtual DisassociateAttributeGroupResponse EndDisassociateAttributeGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAttributeGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateResource

        /// <summary>
        /// Disassociates a resource from application. Both the resource and the application can
        /// be specified either by ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ThrottlingException">
        /// The maximum number of API requests has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DisassociateResource">REST API Reference for DisassociateResource Operation</seealso>
        public virtual DisassociateResourceResponse DisassociateResource(DisassociateResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResource operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DisassociateResource">REST API Reference for DisassociateResource Operation</seealso>
        public virtual IAsyncResult BeginDisassociateResource(DisassociateResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateResource.</param>
        /// 
        /// <returns>Returns a  DisassociateResourceResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DisassociateResource">REST API Reference for DisassociateResource Operation</seealso>
        public virtual DisassociateResourceResponse EndDisassociateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplication

        /// <summary>
        /// Retrieves metadata information about one of your applications. The application can
        /// be specified by its ARN, ID, or name (which is unique within one account in one region
        /// at a given point in time). Specify by ARN or ID in automated workflows if you want
        /// to make sure that the exact same application is returned or a <code>ResourceNotFoundException</code>
        /// is thrown, avoiding the ABA addressing problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplication operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual IAsyncResult BeginGetApplication(GetApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplication.</param>
        /// 
        /// <returns>Returns a  GetApplicationResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse EndGetApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssociatedResource

        /// <summary>
        /// Gets the resource associated with the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedResource service method.</param>
        /// 
        /// <returns>The response from the GetAssociatedResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetAssociatedResource">REST API Reference for GetAssociatedResource Operation</seealso>
        public virtual GetAssociatedResourceResponse GetAssociatedResource(GetAssociatedResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssociatedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssociatedResourceResponseUnmarshaller.Instance;

            return Invoke<GetAssociatedResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssociatedResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedResource operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssociatedResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetAssociatedResource">REST API Reference for GetAssociatedResource Operation</seealso>
        public virtual IAsyncResult BeginGetAssociatedResource(GetAssociatedResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssociatedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssociatedResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssociatedResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssociatedResource.</param>
        /// 
        /// <returns>Returns a  GetAssociatedResourceResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetAssociatedResource">REST API Reference for GetAssociatedResource Operation</seealso>
        public virtual GetAssociatedResourceResponse EndGetAssociatedResource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssociatedResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAttributeGroup

        /// <summary>
        /// Retrieves an attribute group by its ARN, ID, or name. The attribute group can be
        /// specified by its ARN, ID, or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the GetAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetAttributeGroup">REST API Reference for GetAttributeGroup Operation</seealso>
        public virtual GetAttributeGroupResponse GetAttributeGroup(GetAttributeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttributeGroupResponseUnmarshaller.Instance;

            return Invoke<GetAttributeGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAttributeGroup operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAttributeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetAttributeGroup">REST API Reference for GetAttributeGroup Operation</seealso>
        public virtual IAsyncResult BeginGetAttributeGroup(GetAttributeGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttributeGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAttributeGroup.</param>
        /// 
        /// <returns>Returns a  GetAttributeGroupResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetAttributeGroup">REST API Reference for GetAttributeGroup Operation</seealso>
        public virtual GetAttributeGroupResponse EndGetAttributeGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAttributeGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfiguration

        /// <summary>
        /// Retrieves a <code>TagKey</code> configuration from an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        public virtual GetConfigurationResponse GetConfiguration(GetConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetConfiguration(GetConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguration.</param>
        /// 
        /// <returns>Returns a  GetConfigurationResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        public virtual GetConfigurationResponse EndGetConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplications

        /// <summary>
        /// Retrieves a list of all of your applications. Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse EndListApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociatedAttributeGroups

        /// <summary>
        /// Lists all attribute groups that are associated with specified application. Results
        /// are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedAttributeGroups service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedAttributeGroups service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAssociatedAttributeGroups">REST API Reference for ListAssociatedAttributeGroups Operation</seealso>
        public virtual ListAssociatedAttributeGroupsResponse ListAssociatedAttributeGroups(ListAssociatedAttributeGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedAttributeGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedAttributeGroupsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedAttributeGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedAttributeGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedAttributeGroups operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociatedAttributeGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAssociatedAttributeGroups">REST API Reference for ListAssociatedAttributeGroups Operation</seealso>
        public virtual IAsyncResult BeginListAssociatedAttributeGroups(ListAssociatedAttributeGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedAttributeGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedAttributeGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociatedAttributeGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociatedAttributeGroups.</param>
        /// 
        /// <returns>Returns a  ListAssociatedAttributeGroupsResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAssociatedAttributeGroups">REST API Reference for ListAssociatedAttributeGroups Operation</seealso>
        public virtual ListAssociatedAttributeGroupsResponse EndListAssociatedAttributeGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociatedAttributeGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociatedResources

        /// <summary>
        /// Lists all of the resources that are associated with the specified application. Results
        /// are paginated. 
        /// 
        ///  <note> 
        /// <para>
        ///  If you share an application, and a consumer account associates a tag query to the
        /// application, all of the users who can access the application can also view the tag
        /// values in all accounts that are associated with it using this API. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedResources service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedResources service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAssociatedResources">REST API Reference for ListAssociatedResources Operation</seealso>
        public virtual ListAssociatedResourcesResponse ListAssociatedResources(ListAssociatedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedResources operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociatedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAssociatedResources">REST API Reference for ListAssociatedResources Operation</seealso>
        public virtual IAsyncResult BeginListAssociatedResources(ListAssociatedResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociatedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociatedResources.</param>
        /// 
        /// <returns>Returns a  ListAssociatedResourcesResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAssociatedResources">REST API Reference for ListAssociatedResources Operation</seealso>
        public virtual ListAssociatedResourcesResponse EndListAssociatedResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociatedResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttributeGroups

        /// <summary>
        /// Lists all attribute groups which you have access to. Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttributeGroups service method.</param>
        /// 
        /// <returns>The response from the ListAttributeGroups service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAttributeGroups">REST API Reference for ListAttributeGroups Operation</seealso>
        public virtual ListAttributeGroupsResponse ListAttributeGroups(ListAttributeGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttributeGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttributeGroupsResponseUnmarshaller.Instance;

            return Invoke<ListAttributeGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttributeGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttributeGroups operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttributeGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAttributeGroups">REST API Reference for ListAttributeGroups Operation</seealso>
        public virtual IAsyncResult BeginListAttributeGroups(ListAttributeGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttributeGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttributeGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttributeGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttributeGroups.</param>
        /// 
        /// <returns>Returns a  ListAttributeGroupsResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAttributeGroups">REST API Reference for ListAttributeGroups Operation</seealso>
        public virtual ListAttributeGroupsResponse EndListAttributeGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttributeGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttributeGroupsForApplication

        /// <summary>
        /// Lists the details of all attribute groups associated with a specific application.
        /// The results display in pages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttributeGroupsForApplication service method.</param>
        /// 
        /// <returns>The response from the ListAttributeGroupsForApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAttributeGroupsForApplication">REST API Reference for ListAttributeGroupsForApplication Operation</seealso>
        public virtual ListAttributeGroupsForApplicationResponse ListAttributeGroupsForApplication(ListAttributeGroupsForApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttributeGroupsForApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttributeGroupsForApplicationResponseUnmarshaller.Instance;

            return Invoke<ListAttributeGroupsForApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttributeGroupsForApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttributeGroupsForApplication operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttributeGroupsForApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAttributeGroupsForApplication">REST API Reference for ListAttributeGroupsForApplication Operation</seealso>
        public virtual IAsyncResult BeginListAttributeGroupsForApplication(ListAttributeGroupsForApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttributeGroupsForApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttributeGroupsForApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttributeGroupsForApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttributeGroupsForApplication.</param>
        /// 
        /// <returns>Returns a  ListAttributeGroupsForApplicationResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAttributeGroupsForApplication">REST API Reference for ListAttributeGroupsForApplication Operation</seealso>
        public virtual ListAttributeGroupsForApplicationResponse EndListAttributeGroupsForApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttributeGroupsForApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all of the tags on the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutConfiguration

        /// <summary>
        /// Associates a <code>TagKey</code> configuration to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutConfiguration service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/PutConfiguration">REST API Reference for PutConfiguration Operation</seealso>
        public virtual PutConfigurationResponse PutConfiguration(PutConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfiguration operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/PutConfiguration">REST API Reference for PutConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutConfiguration(PutConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfiguration.</param>
        /// 
        /// <returns>Returns a  PutConfigurationResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/PutConfiguration">REST API Reference for PutConfiguration Operation</seealso>
        public virtual PutConfigurationResponse EndPutConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  SyncResource

        /// <summary>
        /// Syncs the resource with current AppRegistry records.
        /// 
        ///  
        /// <para>
        /// Specifically, the resource’s AppRegistry system tags sync with its associated application.
        /// We remove the resource's AppRegistry system tags if it does not associate with the
        /// application. The caller must have permissions to read and update the resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SyncResource service method.</param>
        /// 
        /// <returns>The response from the SyncResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ThrottlingException">
        /// The maximum number of API requests has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/SyncResource">REST API Reference for SyncResource Operation</seealso>
        public virtual SyncResourceResponse SyncResource(SyncResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SyncResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SyncResourceResponseUnmarshaller.Instance;

            return Invoke<SyncResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SyncResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SyncResource operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSyncResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/SyncResource">REST API Reference for SyncResource Operation</seealso>
        public virtual IAsyncResult BeginSyncResource(SyncResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SyncResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SyncResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SyncResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSyncResource.</param>
        /// 
        /// <returns>Returns a  SyncResourceResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/SyncResource">REST API Reference for SyncResource Operation</seealso>
        public virtual SyncResourceResponse EndSyncResource(IAsyncResult asyncResult)
        {
            return EndInvoke<SyncResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a tag with the same key is already
        /// associated with the resource, this action updates its value.
        /// </para>
        ///  
        /// <para>
        /// This operation returns an empty response if the call was successful.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a resource.
        /// 
        ///  
        /// <para>
        /// This operation returns an empty response if the call was successful.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplication

        /// <summary>
        /// Updates an existing application with new attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ThrottlingException">
        /// The maximum number of API requests has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAttributeGroup

        /// <summary>
        /// Updates an existing attribute group with new details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAttributeGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UpdateAttributeGroup">REST API Reference for UpdateAttributeGroup Operation</seealso>
        public virtual UpdateAttributeGroupResponse UpdateAttributeGroup(UpdateAttributeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAttributeGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateAttributeGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAttributeGroup operation on AmazonAppRegistryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAttributeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UpdateAttributeGroup">REST API Reference for UpdateAttributeGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateAttributeGroup(UpdateAttributeGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAttributeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAttributeGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAttributeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAttributeGroup.</param>
        /// 
        /// <returns>Returns a  UpdateAttributeGroupResult from AppRegistry.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UpdateAttributeGroup">REST API Reference for UpdateAttributeGroup Operation</seealso>
        public virtual UpdateAttributeGroupResponse EndUpdateAttributeGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAttributeGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}