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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ResourceExplorer2.Model;
using Amazon.ResourceExplorer2.Model.Internal.MarshallTransformations;
using Amazon.ResourceExplorer2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ResourceExplorer2
{
    /// <summary>
    /// Implementation for accessing ResourceExplorer2
    ///
    /// Amazon Web Services Resource Explorer is a resource search and discovery service.
    /// By using Resource Explorer, you can explore your resources using an internet search
    /// engine-like experience. Examples of resources include Amazon Relational Database Service
    /// (Amazon RDS) instances, Amazon Simple Storage Service (Amazon S3) buckets, or Amazon
    /// DynamoDB tables. You can search for your resources using resource metadata like names,
    /// tags, and IDs. Resource Explorer can search across all of the Amazon Web Services
    /// Regions in your account in which you turn the service on, to simplify your cross-Region
    /// workloads.
    /// 
    ///  
    /// <para>
    /// Resource Explorer scans the resources in each of the Amazon Web Services Regions in
    /// your Amazon Web Services account in which you turn on Resource Explorer. Resource
    /// Explorer <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/getting-started-terms-and-concepts.html#term-index">creates
    /// and maintains an index</a> in each Region, with the details of that Region's resources.
    /// </para>
    ///  
    /// <para>
    /// You can <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-aggregator-region.html">search
    /// across all of the indexed Regions in your account</a> by designating one of your Amazon
    /// Web Services Regions to contain the aggregator index for the account. When you <a
    /// href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-aggregator-region-turn-on.html">promote
    /// a local index in a Region to become the aggregator index for the account</a>, Resource
    /// Explorer automatically replicates the index information from all local indexes in
    /// the other Regions to the aggregator index. Therefore, the Region with the aggregator
    /// index has a copy of all resource information for all Regions in the account where
    /// you turned on Resource Explorer. As a result, views in the aggregator index Region
    /// include resources from all of the indexed Regions in your account.
    /// </para>
    ///  
    /// <para>
    /// For more information about Amazon Web Services Resource Explorer, including how to
    /// enable and configure the service, see the <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/">Amazon
    /// Web Services Resource Explorer User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonResourceExplorer2Client : AmazonServiceClient, IAmazonResourceExplorer2
    {
        private static IServiceMetadata serviceMetadata = new AmazonResourceExplorer2Metadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IResourceExplorer2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IResourceExplorer2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ResourceExplorer2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with the credentials loaded from the application's
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
        public AmazonResourceExplorer2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonResourceExplorer2Config()) { }

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with the credentials loaded from the application's
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
        public AmazonResourceExplorer2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonResourceExplorer2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonResourceExplorer2Client Configuration Object</param>
        public AmazonResourceExplorer2Client(AmazonResourceExplorer2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonResourceExplorer2Client(AWSCredentials credentials)
            : this(credentials, new AmazonResourceExplorer2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceExplorer2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonResourceExplorer2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with AWS Credentials and an
        /// AmazonResourceExplorer2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonResourceExplorer2Client Configuration Object</param>
        public AmazonResourceExplorer2Client(AWSCredentials credentials, AmazonResourceExplorer2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonResourceExplorer2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResourceExplorer2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceExplorer2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResourceExplorer2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResourceExplorer2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonResourceExplorer2Client Configuration Object</param>
        public AmazonResourceExplorer2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonResourceExplorer2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonResourceExplorer2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResourceExplorer2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResourceExplorer2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResourceExplorer2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResourceExplorer2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResourceExplorer2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonResourceExplorer2Client Configuration Object</param>
        public AmazonResourceExplorer2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonResourceExplorer2Config clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonResourceExplorer2EndpointResolver());
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


        #region  AssociateDefaultView

        /// <summary>
        /// Sets the specified view as the default for the Amazon Web Services Region in which
        /// you call this operation. When a user performs a <a>Search</a> that doesn't explicitly
        /// specify which view to use, then Amazon Web Services Resource Explorer automatically
        /// chooses this default view for searches performed in this Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// If an Amazon Web Services Region doesn't have a default view configured, then users
        /// must explicitly specify a view with every <code>Search</code> operation performed
        /// in that Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDefaultView service method.</param>
        /// 
        /// <returns>The response from the AssociateDefaultView service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ResourceNotFoundException">
        /// You specified a resource that doesn't exist. Check the ID or ARN that you used to
        /// identity the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/AssociateDefaultView">REST API Reference for AssociateDefaultView Operation</seealso>
        public virtual AssociateDefaultViewResponse AssociateDefaultView(AssociateDefaultViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDefaultViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDefaultViewResponseUnmarshaller.Instance;

            return Invoke<AssociateDefaultViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDefaultView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDefaultView operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDefaultView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/AssociateDefaultView">REST API Reference for AssociateDefaultView Operation</seealso>
        public virtual IAsyncResult BeginAssociateDefaultView(AssociateDefaultViewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDefaultViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDefaultViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDefaultView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDefaultView.</param>
        /// 
        /// <returns>Returns a  AssociateDefaultViewResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/AssociateDefaultView">REST API Reference for AssociateDefaultView Operation</seealso>
        public virtual AssociateDefaultViewResponse EndAssociateDefaultView(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDefaultViewResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetView

        /// <summary>
        /// Retrieves details about a list of views.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetView service method.</param>
        /// 
        /// <returns>The response from the BatchGetView service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.UnauthorizedException">
        /// The principal making the request isn't permitted to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/BatchGetView">REST API Reference for BatchGetView Operation</seealso>
        public virtual BatchGetViewResponse BatchGetView(BatchGetViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetViewResponseUnmarshaller.Instance;

            return Invoke<BatchGetViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetView operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/BatchGetView">REST API Reference for BatchGetView Operation</seealso>
        public virtual IAsyncResult BeginBatchGetView(BatchGetViewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetView.</param>
        /// 
        /// <returns>Returns a  BatchGetViewResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/BatchGetView">REST API Reference for BatchGetView Operation</seealso>
        public virtual BatchGetViewResponse EndBatchGetView(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetViewResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIndex

        /// <summary>
        /// Turns on Amazon Web Services Resource Explorer in the Amazon Web Services Region in
        /// which you called this operation by creating an index. Resource Explorer begins discovering
        /// the resources in this Region and stores the details about the resources in the index
        /// so that they can be queried by using the <a>Search</a> operation. You can create only
        /// one index in a Region.
        /// 
        ///  <note> 
        /// <para>
        /// This operation creates only a <i>local</i> index. To promote the local index in one
        /// Amazon Web Services Region into the aggregator index for the Amazon Web Services account,
        /// use the <a>UpdateIndexType</a> operation. For more information, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-aggregator-region.html">Turning
        /// on cross-Region search by creating an aggregator index</a> in the <i>Amazon Web Services
        /// Resource Explorer User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more details about what happens when you turn on Resource Explorer in an Amazon
        /// Web Services Region, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-service-activate.html">Turn
        /// on Resource Explorer to index your resources in an Amazon Web Services Region</a>
        /// in the <i>Amazon Web Services Resource Explorer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If this is the first Amazon Web Services Region in which you've created an index for
        /// Resource Explorer, then this operation also <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/security_iam_service-linked-roles.html">creates
        /// a service-linked role</a> in your Amazon Web Services account that allows Resource
        /// Explorer to enumerate your resources to populate the index.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Action</b>: <code>resource-explorer-2:CreateIndex</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Resource</b>: The ARN of the index (as it will exist after the operation completes)
        /// in the Amazon Web Services Region and account in which you're trying to create the
        /// index. Use the wildcard character (<code>*</code>) at the end of the string to match
        /// the eventual UUID. For example, the following <code>Resource</code> element restricts
        /// the role or user to creating an index in only the <code>us-east-2</code> Region of
        /// the specified account.
        /// </para>
        ///  
        /// <para>
        ///  <code>"Resource": "arn:aws:resource-explorer-2:us-west-2:<i>&lt;account-id&gt;</i>:index/*"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can use <code>"Resource": "*"</code> to allow the role or user
        /// to create an index in any Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Action</b>: <code>iam:CreateServiceLinkedRole</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Resource</b>: No specific resource (*). 
        /// </para>
        ///  
        /// <para>
        /// This permission is required only the first time you create an index to turn on Resource
        /// Explorer in the account. Resource Explorer uses this to create the <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/security_iam_service-linked-roles.html">service-linked
        /// role needed to index the resources in your account</a>. Resource Explorer uses the
        /// same service-linked role for all additional indexes you create afterwards.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ConflictException">
        /// You tried to create a new view or index when one already exists, and you either didn't
        /// specify or specified a different idempotency token as the original request.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual CreateIndexResponse CreateIndex(CreateIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return Invoke<CreateIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual IAsyncResult BeginCreateIndex(CreateIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIndex.</param>
        /// 
        /// <returns>Returns a  CreateIndexResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        public virtual CreateIndexResponse EndCreateIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateView

        /// <summary>
        /// Creates a view that users can query by using the <a>Search</a> operation. Results
        /// from queries that you make using this view include only resources that match the view's
        /// <code>Filters</code>. For more information about Amazon Web Services Resource Explorer
        /// views, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-views.html">Managing
        /// views</a> in the <i>Amazon Web Services Resource Explorer User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Only the principals with an IAM identity-based policy that grants <code>Allow</code>
        /// to the <code>Search</code> action on a <code>Resource</code> with the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of this view can <a>Search</a> using views you create with
        /// this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateView service method.</param>
        /// 
        /// <returns>The response from the CreateView service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ConflictException">
        /// You tried to create a new view or index when one already exists, and you either didn't
        /// specify or specified a different idempotency token as the original request.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ServiceQuotaExceededException">
        /// The request failed because it exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.UnauthorizedException">
        /// The principal making the request isn't permitted to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/CreateView">REST API Reference for CreateView Operation</seealso>
        public virtual CreateViewResponse CreateView(CreateViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateViewResponseUnmarshaller.Instance;

            return Invoke<CreateViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateView operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/CreateView">REST API Reference for CreateView Operation</seealso>
        public virtual IAsyncResult BeginCreateView(CreateViewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateView.</param>
        /// 
        /// <returns>Returns a  CreateViewResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/CreateView">REST API Reference for CreateView Operation</seealso>
        public virtual CreateViewResponse EndCreateView(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateViewResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIndex

        /// <summary>
        /// Deletes the specified index and turns off Amazon Web Services Resource Explorer in
        /// the specified Amazon Web Services Region. When you delete an index, Resource Explorer
        /// stops discovering and indexing resources in that Region. Resource Explorer also deletes
        /// all views in that Region. These actions occur as asynchronous background tasks. You
        /// can check to see when the actions are complete by using the <a>GetIndex</a> operation
        /// and checking the <code>Status</code> response value.
        /// 
        ///  <note> 
        /// <para>
        /// If the index you delete is the aggregator index for the Amazon Web Services account,
        /// you must wait 24 hours before you can promote another local index to be the aggregator
        /// index for the account. Users can't perform account-wide searches using Resource Explorer
        /// until another aggregator index is configured.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// 
        /// <returns>The response from the DeleteIndex service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ResourceNotFoundException">
        /// You specified a resource that doesn't exist. Check the ID or ARN that you used to
        /// identity the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        public virtual DeleteIndexResponse DeleteIndex(DeleteIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexResponseUnmarshaller.Instance;

            return Invoke<DeleteIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        public virtual IAsyncResult BeginDeleteIndex(DeleteIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndex.</param>
        /// 
        /// <returns>Returns a  DeleteIndexResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        public virtual DeleteIndexResponse EndDeleteIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteView

        /// <summary>
        /// Deletes the specified view.
        /// 
        ///  
        /// <para>
        /// If the specified view is the default view for its Amazon Web Services Region, then
        /// all <a>Search</a> operations in that Region must explicitly specify the view to use
        /// until you configure a new default by calling the <a>AssociateDefaultView</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteView service method.</param>
        /// 
        /// <returns>The response from the DeleteView service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ResourceNotFoundException">
        /// You specified a resource that doesn't exist. Check the ID or ARN that you used to
        /// identity the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.UnauthorizedException">
        /// The principal making the request isn't permitted to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/DeleteView">REST API Reference for DeleteView Operation</seealso>
        public virtual DeleteViewResponse DeleteView(DeleteViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteViewResponseUnmarshaller.Instance;

            return Invoke<DeleteViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteView operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/DeleteView">REST API Reference for DeleteView Operation</seealso>
        public virtual IAsyncResult BeginDeleteView(DeleteViewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteView.</param>
        /// 
        /// <returns>Returns a  DeleteViewResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/DeleteView">REST API Reference for DeleteView Operation</seealso>
        public virtual DeleteViewResponse EndDeleteView(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteViewResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateDefaultView

        /// <summary>
        /// After you call this operation, the affected Amazon Web Services Region no longer has
        /// a default view. All <a>Search</a> operations in that Region must explicitly specify
        /// a view or the operation fails. You can configure a new default by calling the <a>AssociateDefaultView</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// If an Amazon Web Services Region doesn't have a default view configured, then users
        /// must explicitly specify a view with every <code>Search</code> operation performed
        /// in that Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDefaultView service method.</param>
        /// 
        /// <returns>The response from the DisassociateDefaultView service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/DisassociateDefaultView">REST API Reference for DisassociateDefaultView Operation</seealso>
        public virtual DisassociateDefaultViewResponse DisassociateDefaultView(DisassociateDefaultViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDefaultViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDefaultViewResponseUnmarshaller.Instance;

            return Invoke<DisassociateDefaultViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDefaultView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDefaultView operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDefaultView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/DisassociateDefaultView">REST API Reference for DisassociateDefaultView Operation</seealso>
        public virtual IAsyncResult BeginDisassociateDefaultView(DisassociateDefaultViewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDefaultViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDefaultViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDefaultView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDefaultView.</param>
        /// 
        /// <returns>Returns a  DisassociateDefaultViewResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/DisassociateDefaultView">REST API Reference for DisassociateDefaultView Operation</seealso>
        public virtual DisassociateDefaultViewResponse EndDisassociateDefaultView(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateDefaultViewResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDefaultView

        /// <summary>
        /// Retrieves the Amazon Resource Name (ARN) of the view that is the default for the Amazon
        /// Web Services Region in which you call this operation. You can then call <a>GetView</a>
        /// to retrieve the details of that view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultView service method.</param>
        /// 
        /// <returns>The response from the GetDefaultView service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ResourceNotFoundException">
        /// You specified a resource that doesn't exist. Check the ID or ARN that you used to
        /// identity the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/GetDefaultView">REST API Reference for GetDefaultView Operation</seealso>
        public virtual GetDefaultViewResponse GetDefaultView(GetDefaultViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDefaultViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultViewResponseUnmarshaller.Instance;

            return Invoke<GetDefaultViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDefaultView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultView operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDefaultView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/GetDefaultView">REST API Reference for GetDefaultView Operation</seealso>
        public virtual IAsyncResult BeginGetDefaultView(GetDefaultViewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDefaultViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDefaultView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDefaultView.</param>
        /// 
        /// <returns>Returns a  GetDefaultViewResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/GetDefaultView">REST API Reference for GetDefaultView Operation</seealso>
        public virtual GetDefaultViewResponse EndGetDefaultView(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDefaultViewResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIndex

        /// <summary>
        /// Retrieves details about the Amazon Web Services Resource Explorer index in the Amazon
        /// Web Services Region in which you invoked the operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndex service method.</param>
        /// 
        /// <returns>The response from the GetIndex service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ResourceNotFoundException">
        /// You specified a resource that doesn't exist. Check the ID or ARN that you used to
        /// identity the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/GetIndex">REST API Reference for GetIndex Operation</seealso>
        public virtual GetIndexResponse GetIndex(GetIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexResponseUnmarshaller.Instance;

            return Invoke<GetIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIndex operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/GetIndex">REST API Reference for GetIndex Operation</seealso>
        public virtual IAsyncResult BeginGetIndex(GetIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIndex.</param>
        /// 
        /// <returns>Returns a  GetIndexResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/GetIndex">REST API Reference for GetIndex Operation</seealso>
        public virtual GetIndexResponse EndGetIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  GetView

        /// <summary>
        /// Retrieves details of the specified view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetView service method.</param>
        /// 
        /// <returns>The response from the GetView service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ResourceNotFoundException">
        /// You specified a resource that doesn't exist. Check the ID or ARN that you used to
        /// identity the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.UnauthorizedException">
        /// The principal making the request isn't permitted to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/GetView">REST API Reference for GetView Operation</seealso>
        public virtual GetViewResponse GetView(GetViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetViewResponseUnmarshaller.Instance;

            return Invoke<GetViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetView operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/GetView">REST API Reference for GetView Operation</seealso>
        public virtual IAsyncResult BeginGetView(GetViewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetView.</param>
        /// 
        /// <returns>Returns a  GetViewResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/GetView">REST API Reference for GetView Operation</seealso>
        public virtual GetViewResponse EndGetView(IAsyncResult asyncResult)
        {
            return EndInvoke<GetViewResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIndexes

        /// <summary>
        /// Retrieves a list of all of the indexes in Amazon Web Services Regions that are currently
        /// collecting resource information for Amazon Web Services Resource Explorer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndexes service method.</param>
        /// 
        /// <returns>The response from the ListIndexes service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListIndexes">REST API Reference for ListIndexes Operation</seealso>
        public virtual ListIndexesResponse ListIndexes(ListIndexesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexesResponseUnmarshaller.Instance;

            return Invoke<ListIndexesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIndexes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIndexes operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIndexes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListIndexes">REST API Reference for ListIndexes Operation</seealso>
        public virtual IAsyncResult BeginListIndexes(ListIndexesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIndexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIndexes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIndexes.</param>
        /// 
        /// <returns>Returns a  ListIndexesResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListIndexes">REST API Reference for ListIndexes Operation</seealso>
        public virtual ListIndexesResponse EndListIndexes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIndexesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSupportedResourceTypes

        /// <summary>
        /// Retrieves a list of all resource types currently supported by Amazon Web Services
        /// Resource Explorer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedResourceTypes service method.</param>
        /// 
        /// <returns>The response from the ListSupportedResourceTypes service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListSupportedResourceTypes">REST API Reference for ListSupportedResourceTypes Operation</seealso>
        public virtual ListSupportedResourceTypesResponse ListSupportedResourceTypes(ListSupportedResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSupportedResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportedResourceTypesResponseUnmarshaller.Instance;

            return Invoke<ListSupportedResourceTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSupportedResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedResourceTypes operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSupportedResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListSupportedResourceTypes">REST API Reference for ListSupportedResourceTypes Operation</seealso>
        public virtual IAsyncResult BeginListSupportedResourceTypes(ListSupportedResourceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSupportedResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportedResourceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSupportedResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSupportedResourceTypes.</param>
        /// 
        /// <returns>Returns a  ListSupportedResourceTypesResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListSupportedResourceTypes">REST API Reference for ListSupportedResourceTypes Operation</seealso>
        public virtual ListSupportedResourceTypesResponse EndListSupportedResourceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSupportedResourceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags that are attached to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ResourceNotFoundException">
        /// You specified a resource that doesn't exist. Check the ID or ARN that you used to
        /// identity the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.UnauthorizedException">
        /// The principal making the request isn't permitted to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListViews

        /// <summary>
        /// Lists the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource names (ARNs)</a> of the views available in the Amazon Web Services Region
        /// in which you call this operation.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a paginated operation. These operations can occasionally return
        /// an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListViews service method.</param>
        /// 
        /// <returns>The response from the ListViews service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListViews">REST API Reference for ListViews Operation</seealso>
        public virtual ListViewsResponse ListViews(ListViewsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListViewsResponseUnmarshaller.Instance;

            return Invoke<ListViewsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListViews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListViews operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListViews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListViews">REST API Reference for ListViews Operation</seealso>
        public virtual IAsyncResult BeginListViews(ListViewsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListViewsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListViews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListViews.</param>
        /// 
        /// <returns>Returns a  ListViewsResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/ListViews">REST API Reference for ListViews Operation</seealso>
        public virtual ListViewsResponse EndListViews(IAsyncResult asyncResult)
        {
            return EndInvoke<ListViewsResponse>(asyncResult);
        }

        #endregion
        
        #region  Search

        /// <summary>
        /// Searches for resources and displays details about all resources that match the specified
        /// criteria. You must specify a query string.
        /// 
        ///  
        /// <para>
        /// All search queries must use a view. If you don't explicitly specify a view, then Amazon
        /// Web Services Resource Explorer uses the default view for the Amazon Web Services Region
        /// in which you call this operation. The results are the logical intersection of the
        /// results that match both the <code>QueryString</code> parameter supplied to this operation
        /// and the <code>SearchFilter</code> parameter attached to the view.
        /// </para>
        ///  
        /// <para>
        /// For the complete syntax supported by the <code>QueryString</code> parameter, see <a
        /// href="https://docs.aws.amazon.com/resource-explorer/latest/APIReference/about-query-syntax.html">Search
        /// query syntax reference for Resource Explorer</a>.
        /// </para>
        ///  
        /// <para>
        /// If your search results are empty, or are missing results that you think should be
        /// there, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/troubleshooting_search.html">Troubleshooting
        /// Resource Explorer search</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// 
        /// <returns>The response from the Search service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ResourceNotFoundException">
        /// You specified a resource that doesn't exist. Check the ID or ARN that you used to
        /// identity the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.UnauthorizedException">
        /// The principal making the request isn't permitted to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/Search">REST API Reference for Search Operation</seealso>
        public virtual SearchResponse Search(SearchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return Invoke<SearchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Search operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Search operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/Search">REST API Reference for Search Operation</seealso>
        public virtual IAsyncResult BeginSearch(SearchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Search operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearch.</param>
        /// 
        /// <returns>Returns a  SearchResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/Search">REST API Reference for Search Operation</seealso>
        public virtual SearchResponse EndSearch(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tag key and value pairs to an Amazon Web Services Resource Explorer
        /// view or index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ConflictException">
        /// You tried to create a new view or index when one already exists, and you either didn't
        /// specify or specified a different idempotency token as the original request.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.UnauthorizedException">
        /// The principal making the request isn't permitted to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tag key and value pairs from an Amazon Web Services Resource Explorer
        /// view or index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ResourceNotFoundException">
        /// You specified a resource that doesn't exist. Check the ID or ARN that you used to
        /// identity the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.UnauthorizedException">
        /// The principal making the request isn't permitted to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIndexType

        /// <summary>
        /// Changes the type of the index from one of the following types to the other. For more
        /// information about indexes and the role they perform in Amazon Web Services Resource
        /// Explorer, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-aggregator-region.html">Turning
        /// on cross-Region search by creating an aggregator index</a> in the <i>Amazon Web Services
        /// Resource Explorer User Guide</i>.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>AGGREGATOR</code> index type</b> 
        /// </para>
        ///  
        /// <para>
        /// The index contains information about resources from all Amazon Web Services Regions
        /// in the Amazon Web Services account in which you've created a Resource Explorer index.
        /// Resource information from all other Regions is replicated to this Region's index.
        /// </para>
        ///  
        /// <para>
        /// When you change the index type to <code>AGGREGATOR</code>, Resource Explorer turns
        /// on replication of all discovered resource information from the other Amazon Web Services
        /// Regions in your account to this index. You can then, from this Region only, perform
        /// resource search queries that span all Amazon Web Services Regions in the Amazon Web
        /// Services account. Turning on replication from all other Regions is performed by asynchronous
        /// background tasks. You can check the status of the asynchronous tasks by using the
        /// <a>GetIndex</a> operation. When the asynchronous tasks complete, the <code>Status</code>
        /// response of that operation changes from <code>UPDATING</code> to <code>ACTIVE</code>.
        /// After that, you can start to see results from other Amazon Web Services Regions in
        /// query results. However, it can take several hours for replication from all other Regions
        /// to complete.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can have only one aggregator index per Amazon Web Services account. Before you
        /// can promote a different index to be the aggregator index for the account, you must
        /// first demote the existing aggregator index to type <code>LOCAL</code>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <b> <code>LOCAL</code> index type</b> 
        /// </para>
        ///  
        /// <para>
        /// The index contains information about resources in only the Amazon Web Services Region
        /// in which the index exists. If an aggregator index in another Region exists, then information
        /// in this local index is replicated to the aggregator index.
        /// </para>
        ///  
        /// <para>
        /// When you change the index type to <code>LOCAL</code>, Resource Explorer turns off
        /// the replication of resource information from all other Amazon Web Services Regions
        /// in the Amazon Web Services account to this Region. The aggregator index remains in
        /// the <code>UPDATING</code> state until all replication with other Regions successfully
        /// stops. You can check the status of the asynchronous task by using the <a>GetIndex</a>
        /// operation. When Resource Explorer successfully stops all replication with other Regions,
        /// the <code>Status</code> response of that operation changes from <code>UPDATING</code>
        /// to <code>ACTIVE</code>. Separately, the resource information from other Regions that
        /// was previously stored in the index is deleted within 30 days by another background
        /// task. Until that asynchronous task completes, some results from other Regions can
        /// continue to appear in search results.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you demote an aggregator index to a local index, you must wait 24 hours before
        /// you can promote another index to be the new aggregator index for the account.
        /// </para>
        ///  </important> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndexType service method.</param>
        /// 
        /// <returns>The response from the UpdateIndexType service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ConflictException">
        /// You tried to create a new view or index when one already exists, and you either didn't
        /// specify or specified a different idempotency token as the original request.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ResourceNotFoundException">
        /// You specified a resource that doesn't exist. Check the ID or ARN that you used to
        /// identity the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ServiceQuotaExceededException">
        /// The request failed because it exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/UpdateIndexType">REST API Reference for UpdateIndexType Operation</seealso>
        public virtual UpdateIndexTypeResponse UpdateIndexType(UpdateIndexTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateIndexTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIndexType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndexType operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIndexType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/UpdateIndexType">REST API Reference for UpdateIndexType Operation</seealso>
        public virtual IAsyncResult BeginUpdateIndexType(UpdateIndexTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIndexTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIndexType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIndexType.</param>
        /// 
        /// <returns>Returns a  UpdateIndexTypeResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/UpdateIndexType">REST API Reference for UpdateIndexType Operation</seealso>
        public virtual UpdateIndexTypeResponse EndUpdateIndexType(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIndexTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateView

        /// <summary>
        /// Modifies some of the details of a view. You can change the filter string and the list
        /// of included properties. You can't change the name of the view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateView service method.</param>
        /// 
        /// <returns>The response from the UpdateView service method, as returned by ResourceExplorer2.</returns>
        /// <exception cref="Amazon.ResourceExplorer2.Model.AccessDeniedException">
        /// The credentials that you used to call this operation don't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.InternalServerException">
        /// The request failed because of internal service error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ServiceQuotaExceededException">
        /// The request failed because it exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ThrottlingException">
        /// The request failed because you exceeded a rate limit for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/arexug/mainline/quotas.html">Quotas
        /// for Resource Explorer</a>.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.UnauthorizedException">
        /// The principal making the request isn't permitted to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.ResourceExplorer2.Model.ValidationException">
        /// You provided an invalid value for one of the operation's parameters. Check the syntax
        /// for the operation, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/UpdateView">REST API Reference for UpdateView Operation</seealso>
        public virtual UpdateViewResponse UpdateView(UpdateViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateViewResponseUnmarshaller.Instance;

            return Invoke<UpdateViewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateView operation on AmazonResourceExplorer2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/UpdateView">REST API Reference for UpdateView Operation</seealso>
        public virtual IAsyncResult BeginUpdateView(UpdateViewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateViewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateView.</param>
        /// 
        /// <returns>Returns a  UpdateViewResult from ResourceExplorer2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resource-explorer-2-2022-07-28/UpdateView">REST API Reference for UpdateView Operation</seealso>
        public virtual UpdateViewResponse EndUpdateView(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateViewResponse>(asyncResult);
        }

        #endregion
        
    }
}