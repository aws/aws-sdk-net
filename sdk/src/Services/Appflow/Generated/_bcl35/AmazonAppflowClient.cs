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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Appflow.Model;
using Amazon.Appflow.Model.Internal.MarshallTransformations;
using Amazon.Appflow.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Appflow
{
    /// <summary>
    /// Implementation for accessing Appflow
    ///
    /// Welcome to the Amazon AppFlow API reference. This guide is for developers who need
    /// detailed information about the Amazon AppFlow API operations, data types, and errors.
    /// 
    /// 
    ///  
    /// <para>
    /// Amazon AppFlow is a fully managed integration service that enables you to securely
    /// transfer data between software as a service (SaaS) applications like Salesforce, Marketo,
    /// Slack, and ServiceNow, and AWS services like Amazon S3 and Amazon Redshift. 
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started on the Amazon AppFlow API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/appflow/1.0/APIReference/API_Operations.html">Actions</a>:
    /// An alphabetical list of all Amazon AppFlow API operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/appflow/1.0/APIReference/API_Types.html">Data
    /// types</a>: An alphabetical list of all Amazon AppFlow data types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/appflow/1.0/APIReference/CommonParameters.html">Common
    /// parameters</a>: Parameters that all Query operations can use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/appflow/1.0/APIReference/CommonErrors.html">Common
    /// errors</a>: Client and server errors that all operations can return.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you're new to Amazon AppFlow, we recommend that you review the <a href="https://docs.aws.amazon.com/appflow/latest/userguide/what-is-appflow.html">Amazon
    /// AppFlow User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon AppFlow API users can use vendor-specific mechanisms for OAuth, and include
    /// applicable OAuth attributes (such as <code>auth-code</code> and <code>redirecturi</code>)
    /// with the connector-specific <code>ConnectorProfileProperties</code> when creating
    /// a new connector profile using Amazon AppFlow API operations. For example, Salesforce
    /// users can refer to the <a href="https://help.salesforce.com/articleView?id=remoteaccess_authenticate.htm">
    /// <i>Authorize Apps with OAuth</i> </a> documentation.
    /// </para>
    /// </summary>
    public partial class AmazonAppflowClient : AmazonServiceClient, IAmazonAppflow
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppflowMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonAppflowClient with the credentials loaded from the application's
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
        public AmazonAppflowClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppflowConfig()) { }

        /// <summary>
        /// Constructs AmazonAppflowClient with the credentials loaded from the application's
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
        public AmazonAppflowClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppflowConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppflowClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppflowClient Configuration Object</param>
        public AmazonAppflowClient(AmazonAppflowConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppflowClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppflowClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppflowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Credentials and an
        /// AmazonAppflowClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppflowClient Configuration Object</param>
        public AmazonAppflowClient(AWSCredentials credentials, AmazonAppflowConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppflowConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppflowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppflowClient Configuration Object</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppflowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppflowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppflowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppflowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppflowClient Configuration Object</param>
        public AmazonAppflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppflowConfig clientConfig)
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


        #region  CreateConnectorProfile

        /// <summary>
        /// Creates a new connector profile associated with your AWS account. There is a soft
        /// quota of 100 connector profiles per AWS account. If you need more connector profiles
        /// than this quota allows, you can submit a request to the Amazon AppFlow team through
        /// the Amazon AppFlow support channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectorProfile service method.</param>
        /// 
        /// <returns>The response from the CreateConnectorProfile service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CreateConnectorProfile">REST API Reference for CreateConnectorProfile Operation</seealso>
        public virtual CreateConnectorProfileResponse CreateConnectorProfile(CreateConnectorProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorProfileResponseUnmarshaller.Instance;

            return Invoke<CreateConnectorProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnectorProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectorProfile operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnectorProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CreateConnectorProfile">REST API Reference for CreateConnectorProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateConnectorProfile(CreateConnectorProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectorProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectorProfile.</param>
        /// 
        /// <returns>Returns a  CreateConnectorProfileResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CreateConnectorProfile">REST API Reference for CreateConnectorProfile Operation</seealso>
        public virtual CreateConnectorProfileResponse EndCreateConnectorProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectorProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFlow

        /// <summary>
        /// Enables your application to create a new flow using Amazon AppFlow. You must create
        /// a connector profile before calling this API. Please note that the Request Syntax below
        /// shows syntax for multiple destinations, however, you can only transfer data to one
        /// item in this list at a time. Amazon AppFlow does not currently support flows to multiple
        /// destinations at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow service method.</param>
        /// 
        /// <returns>The response from the CreateFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        public virtual CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;

            return Invoke<CreateFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        public virtual IAsyncResult BeginCreateFlow(CreateFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFlow.</param>
        /// 
        /// <returns>Returns a  CreateFlowResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        public virtual CreateFlowResponse EndCreateFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnectorProfile

        /// <summary>
        /// Enables you to delete an existing connector profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectorProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectorProfile service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DeleteConnectorProfile">REST API Reference for DeleteConnectorProfile Operation</seealso>
        public virtual DeleteConnectorProfileResponse DeleteConnectorProfile(DeleteConnectorProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectorProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectorProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectorProfile operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectorProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DeleteConnectorProfile">REST API Reference for DeleteConnectorProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnectorProfile(DeleteConnectorProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectorProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectorProfile.</param>
        /// 
        /// <returns>Returns a  DeleteConnectorProfileResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DeleteConnectorProfile">REST API Reference for DeleteConnectorProfile Operation</seealso>
        public virtual DeleteConnectorProfileResponse EndDeleteConnectorProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectorProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFlow

        /// <summary>
        /// Enables your application to delete an existing flow. Before deleting the flow, Amazon
        /// AppFlow validates the request by checking the flow configuration and status. You can
        /// delete flows one at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow service method.</param>
        /// 
        /// <returns>The response from the DeleteFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        public virtual DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        public virtual IAsyncResult BeginDeleteFlow(DeleteFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFlow.</param>
        /// 
        /// <returns>Returns a  DeleteFlowResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        public virtual DeleteFlowResponse EndDeleteFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConnectorEntity

        /// <summary>
        /// Provides details regarding the entity used with the connector, with a description
        /// of the data model for each entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectorEntity service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectorEntity service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectorEntity">REST API Reference for DescribeConnectorEntity Operation</seealso>
        public virtual DescribeConnectorEntityResponse DescribeConnectorEntity(DescribeConnectorEntityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectorEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorEntityResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectorEntityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectorEntity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectorEntity operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnectorEntity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectorEntity">REST API Reference for DescribeConnectorEntity Operation</seealso>
        public virtual IAsyncResult BeginDescribeConnectorEntity(DescribeConnectorEntityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectorEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorEntityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectorEntity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectorEntity.</param>
        /// 
        /// <returns>Returns a  DescribeConnectorEntityResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectorEntity">REST API Reference for DescribeConnectorEntity Operation</seealso>
        public virtual DescribeConnectorEntityResponse EndDescribeConnectorEntity(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConnectorEntityResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConnectorProfiles

        /// <summary>
        /// Returns a list of <code>connector-profile</code> details matching the provided <code>connector-profile</code>
        /// names and <code>connector-types</code>. Both input lists are optional, and you can
        /// use them to filter the result. 
        /// 
        ///  
        /// <para>
        /// If no names or <code>connector-types</code> are provided, returns all connector profiles
        /// in a paginated form. If there is no match, this operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectorProfiles service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectorProfiles service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectorProfiles">REST API Reference for DescribeConnectorProfiles Operation</seealso>
        public virtual DescribeConnectorProfilesResponse DescribeConnectorProfiles(DescribeConnectorProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectorProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorProfilesResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectorProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectorProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectorProfiles operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnectorProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectorProfiles">REST API Reference for DescribeConnectorProfiles Operation</seealso>
        public virtual IAsyncResult BeginDescribeConnectorProfiles(DescribeConnectorProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectorProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectorProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectorProfiles.</param>
        /// 
        /// <returns>Returns a  DescribeConnectorProfilesResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectorProfiles">REST API Reference for DescribeConnectorProfiles Operation</seealso>
        public virtual DescribeConnectorProfilesResponse EndDescribeConnectorProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConnectorProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConnectors

        /// <summary>
        /// Describes the connectors vended by Amazon AppFlow for specified connector types.
        /// If you don't specify a connector type, this operation describes all connectors vended
        /// by Amazon AppFlow. If there are more connectors than can be returned in one page,
        /// the response contains a <code>nextToken</code> object, which can be be passed in to
        /// the next call to the <code>DescribeConnectors</code> API operation to retrieve the
        /// next page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectors service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectors service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectors">REST API Reference for DescribeConnectors Operation</seealso>
        public virtual DescribeConnectorsResponse DescribeConnectors(DescribeConnectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectors operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectors">REST API Reference for DescribeConnectors Operation</seealso>
        public virtual IAsyncResult BeginDescribeConnectors(DescribeConnectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectors.</param>
        /// 
        /// <returns>Returns a  DescribeConnectorsResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeConnectors">REST API Reference for DescribeConnectors Operation</seealso>
        public virtual DescribeConnectorsResponse EndDescribeConnectors(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConnectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFlow

        /// <summary>
        /// Provides a description of the specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlow service method.</param>
        /// 
        /// <returns>The response from the DescribeFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        public virtual DescribeFlowResponse DescribeFlow(DescribeFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlow operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        public virtual IAsyncResult BeginDescribeFlow(DescribeFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlow.</param>
        /// 
        /// <returns>Returns a  DescribeFlowResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        public virtual DescribeFlowResponse EndDescribeFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFlowExecutionRecords

        /// <summary>
        /// Fetches the execution history of the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowExecutionRecords service method.</param>
        /// 
        /// <returns>The response from the DescribeFlowExecutionRecords service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeFlowExecutionRecords">REST API Reference for DescribeFlowExecutionRecords Operation</seealso>
        public virtual DescribeFlowExecutionRecordsResponse DescribeFlowExecutionRecords(DescribeFlowExecutionRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowExecutionRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowExecutionRecordsResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowExecutionRecordsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlowExecutionRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowExecutionRecords operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlowExecutionRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeFlowExecutionRecords">REST API Reference for DescribeFlowExecutionRecords Operation</seealso>
        public virtual IAsyncResult BeginDescribeFlowExecutionRecords(DescribeFlowExecutionRecordsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowExecutionRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowExecutionRecordsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlowExecutionRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlowExecutionRecords.</param>
        /// 
        /// <returns>Returns a  DescribeFlowExecutionRecordsResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/DescribeFlowExecutionRecords">REST API Reference for DescribeFlowExecutionRecords Operation</seealso>
        public virtual DescribeFlowExecutionRecordsResponse EndDescribeFlowExecutionRecords(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFlowExecutionRecordsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConnectorEntities

        /// <summary>
        /// Returns the list of available connector entities supported by Amazon AppFlow. For
        /// example, you can query Salesforce for <i>Account</i> and <i>Opportunity</i> entities,
        /// or query ServiceNow for the <i>Incident</i> entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorEntities service method.</param>
        /// 
        /// <returns>The response from the ListConnectorEntities service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListConnectorEntities">REST API Reference for ListConnectorEntities Operation</seealso>
        public virtual ListConnectorEntitiesResponse ListConnectorEntities(ListConnectorEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConnectorEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorEntitiesResponseUnmarshaller.Instance;

            return Invoke<ListConnectorEntitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectorEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorEntities operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectorEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListConnectorEntities">REST API Reference for ListConnectorEntities Operation</seealso>
        public virtual IAsyncResult BeginListConnectorEntities(ListConnectorEntitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConnectorEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectorEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectorEntities.</param>
        /// 
        /// <returns>Returns a  ListConnectorEntitiesResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListConnectorEntities">REST API Reference for ListConnectorEntities Operation</seealso>
        public virtual ListConnectorEntitiesResponse EndListConnectorEntities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConnectorEntitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFlows

        /// <summary>
        /// Lists all of the flows associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlows service method.</param>
        /// 
        /// <returns>The response from the ListFlows service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListFlows">REST API Reference for ListFlows Operation</seealso>
        public virtual ListFlowsResponse ListFlows(ListFlowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;

            return Invoke<ListFlowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFlows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlows operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFlows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListFlows">REST API Reference for ListFlows Operation</seealso>
        public virtual IAsyncResult BeginListFlows(ListFlowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFlows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFlows.</param>
        /// 
        /// <returns>Returns a  ListFlowsResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListFlows">REST API Reference for ListFlows Operation</seealso>
        public virtual ListFlowsResponse EndListFlows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFlowsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves the tags that are associated with a specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFlow

        /// <summary>
        /// Activates an existing flow. For on-demand flows, this operation runs the flow immediately.
        /// For schedule and event-triggered flows, this operation activates the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlow service method.</param>
        /// 
        /// <returns>The response from the StartFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/StartFlow">REST API Reference for StartFlow Operation</seealso>
        public virtual StartFlowResponse StartFlow(StartFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowResponseUnmarshaller.Instance;

            return Invoke<StartFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFlow operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/StartFlow">REST API Reference for StartFlow Operation</seealso>
        public virtual IAsyncResult BeginStartFlow(StartFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFlow.</param>
        /// 
        /// <returns>Returns a  StartFlowResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/StartFlow">REST API Reference for StartFlow Operation</seealso>
        public virtual StartFlowResponse EndStartFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  StopFlow

        /// <summary>
        /// Deactivates the existing flow. For on-demand flows, this operation returns an <code>unsupportedOperationException</code>
        /// error message. For schedule and event-triggered flows, this operation deactivates
        /// the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFlow service method.</param>
        /// 
        /// <returns>The response from the StopFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.UnsupportedOperationException">
        /// The requested operation is not supported for the current flow.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/StopFlow">REST API Reference for StopFlow Operation</seealso>
        public virtual StopFlowResponse StopFlow(StopFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFlowResponseUnmarshaller.Instance;

            return Invoke<StopFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopFlow operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/StopFlow">REST API Reference for StopFlow Operation</seealso>
        public virtual IAsyncResult BeginStopFlow(StopFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopFlow.</param>
        /// 
        /// <returns>Returns a  StopFlowResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/StopFlow">REST API Reference for StopFlow Operation</seealso>
        public virtual StopFlowResponse EndStopFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<StopFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Applies a tag to the specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from the specified flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConnectorProfile

        /// <summary>
        /// Updates a given connector profile associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectorProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectorProfile service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateConnectorProfile">REST API Reference for UpdateConnectorProfile Operation</seealso>
        public virtual UpdateConnectorProfileResponse UpdateConnectorProfile(UpdateConnectorProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectorProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectorProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectorProfile operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectorProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateConnectorProfile">REST API Reference for UpdateConnectorProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnectorProfile(UpdateConnectorProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectorProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectorProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectorProfile.</param>
        /// 
        /// <returns>Returns a  UpdateConnectorProfileResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateConnectorProfile">REST API Reference for UpdateConnectorProfile Operation</seealso>
        public virtual UpdateConnectorProfileResponse EndUpdateConnectorProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectorProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFlow

        /// <summary>
        /// Updates an existing flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlow service method.</param>
        /// 
        /// <returns>The response from the UpdateFlow service method, as returned by Appflow.</returns>
        /// <exception cref="Amazon.Appflow.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a flow with the given
        /// name already exists within the account. Check for conflicting resource names and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorAuthenticationException">
        /// An error occurred when authenticating with the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ConnectorServerException">
        /// An error occurred when retrieving data from the connector endpoint.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ResourceNotFoundException">
        /// The resource specified in the request (such as the source or destination connector
        /// profile) is not found.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota (such as the number of flows) to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Appflow.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateFlow">REST API Reference for UpdateFlow Operation</seealso>
        public virtual UpdateFlowResponse UpdateFlow(UpdateFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlow operation on AmazonAppflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateFlow">REST API Reference for UpdateFlow Operation</seealso>
        public virtual IAsyncResult BeginUpdateFlow(UpdateFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFlow.</param>
        /// 
        /// <returns>Returns a  UpdateFlowResult from Appflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appflow-2020-08-23/UpdateFlow">REST API Reference for UpdateFlow Operation</seealso>
        public virtual UpdateFlowResponse EndUpdateFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFlowResponse>(asyncResult);
        }

        #endregion
        
    }
}