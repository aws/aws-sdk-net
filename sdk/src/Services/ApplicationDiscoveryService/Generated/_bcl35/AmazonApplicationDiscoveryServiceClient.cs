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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.ApplicationDiscoveryService.Model;
using Amazon.ApplicationDiscoveryService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ApplicationDiscoveryService
{
    /// <summary>
    /// Implementation for accessing ApplicationDiscoveryService
    ///
    /// This is the AWS Discovery Service API Reference. The AWS Discovery Service streamlines
    /// the process of migrating to Amazon Web Services by helping you identify assets in
    /// your data center, including servers, virtual machines, applications, application dependencies,
    /// and network infrastructure. You can use this information to find the workloads that
    /// make up an application, analyze dependencies, and build migration strategies. The
    /// service also collects performance data about your workloads which you can use to assess
    /// migration outcomes.
    /// 
    ///  
    /// <para>
    /// This API reference provides descriptions, syntax, and usage examples for each of the
    /// actions and data types for the Discovery Service. The topic for each action shows
    /// the API request parameters and the response. Alternatively, you can use one of the
    /// AWS SDKs to access an API that's tailored to the programming language or platform
    /// that you're using. For more information, see <a href="http://aws.amazon.com/tools/#SDKs">AWS
    /// SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// This guide is intended for use with the <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/remote-commands-prereq.html">AWS
    /// Discovery Service user guide</a>.
    /// </para>
    ///  
    /// <para>
    /// The following are short descriptions of each API action, organized by function.
    /// </para>
    ///  
    /// <para>
    ///  <b>Managing AWS Agents</b> 
    /// </para>
    ///  
    /// <para>
    /// The AWS agent is an Amazon application that you install on servers and virtual machines
    /// in your data center or on Amazon EC2 instances. The agent captures server configuration
    /// and activity information (including hardware profile, network, file system, and process
    /// activity) and sends this data to the AWS Application Discovery Service. The Discovery
    /// Service processes this data and maps the application dependencies for your workloads.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>StartDataCollectionByAgentIds</i>: Instructs the specified agents to start collecting
    /// data. Agents can reside on host servers or virtual machines in your data center or
    /// on AWS EC2 instances.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>StopDataCollectionByAgentIds</i>: Instructs the specified agents to stop collecting
    /// data.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>DescribeAgents</i>: Lists AWS agents by ID or lists all agents associated with
    /// your user account if you did not specify an agent ID. The output includes agent IDs,
    /// IP addresses, MAC addresses, agent health, host name where the agent resides, and
    /// the version number of each agent.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Querying Configuration Items</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>configuration item</i> is an IT asset that was discovered in your data center
    /// by an AWS agent. With the Discovery Service, you can specify filters and query specific
    /// configuration items. For example, using this API, you could create a filter to query
    /// for a process configuration item named apache and an operating system configuration
    /// item named Ubuntu.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>GetConfigurationAttributes</i>: Retrieves a list of attributes for a specific
    /// configuration ID. For example, the output for a <i>server</i> configuration item includes
    /// a list of attributes about the server, including host name, operating system, number
    /// of network cards, etc.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>ListConfigurations</i>: Retrieves a list of configurations items according to
    /// the criteria you specify in a filter. The filter criteria identify relationship requirements.
    /// For example, the following filter specifies criteria of process.name and values of
    /// <i>nginx</i> and <i>apache</i>.
    /// </para>
    ///  
    /// <para>
    ///  <code>ConfigurationType = Process Filters = [WebServerCriteria] WebServerCriteria
    /// = { ‘key’ : process.name, ‘values’ : [ ‘nginx’, ‘apache’ ], ‘condition’ : ‘contains’
    /// } </code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tagging Discovered Configuration Items</b> 
    /// </para>
    ///  
    /// <para>
    /// You can tag discovered configuration items. Tags are metadata that help you categorize
    /// IT assets in your data center. Tags use a <i>key</i>,<i>value</i> format. For example,
    /// <code>{"key": "serverType", "value": "webServer"}</code>. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>CreateTags</i>: Creates one or more tags for a configuration item. Tags are metadata
    /// that help you categorize IT assets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>DescribeTags</i>: Retrieve a list of configuration items that are tagged with
    /// a specific tag. Or retrieve a list all tags assigned to a specific configuration item.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>DeleteTags</i>: Deletes one or more tags associated with a configuration item.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Exporting Data</b> 
    /// </para>
    ///  
    /// <para>
    /// You can export discovered data to an Amazon S3 bucket in the form of CSV files.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>ExportConfigurations</i>: Exports all discovered configuration data to an Amazon
    /// S3 bucket. Data includes processes, connections, servers, and system performance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>GetExportStatus</i>: Gets the status of the data export. When the export is complete,
    /// the service returns an Amazon S3 URL where you can download CSV files that include
    /// the data.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonApplicationDiscoveryServiceClient : AmazonServiceClient, IAmazonApplicationDiscoveryService
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with the credentials loaded from the application's
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
        public AmazonApplicationDiscoveryServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationDiscoveryServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with the credentials loaded from the application's
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
        public AmazonApplicationDiscoveryServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationDiscoveryServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonApplicationDiscoveryServiceClient Configuration Object</param>
        public AmazonApplicationDiscoveryServiceClient(AmazonApplicationDiscoveryServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApplicationDiscoveryServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonApplicationDiscoveryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationDiscoveryServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApplicationDiscoveryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Credentials and an
        /// AmazonApplicationDiscoveryServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApplicationDiscoveryServiceClient Configuration Object</param>
        public AmazonApplicationDiscoveryServiceClient(AWSCredentials credentials, AmazonApplicationDiscoveryServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationDiscoveryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationDiscoveryServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationDiscoveryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApplicationDiscoveryServiceClient Configuration Object</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApplicationDiscoveryServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationDiscoveryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationDiscoveryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationDiscoveryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationDiscoveryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApplicationDiscoveryServiceClient Configuration Object</param>
        public AmazonApplicationDiscoveryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApplicationDiscoveryServiceConfig clientConfig)
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

        
        #region  CreateTags

        /// <summary>
        /// Creates one or more tags for a configuration item. Tags are metadata that help you
        /// categorize IT assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        public CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsRequest,CreateTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTags
        ///         operation.</returns>
        public IAsyncResult BeginCreateTags(CreateTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        /// 
        /// <returns>Returns a  CreateTagsResult from ApplicationDiscoveryService.</returns>
        public  CreateTagsResponse EndCreateTags(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTags

        /// <summary>
        /// Deletes one or more tags associated with a configuration item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        public IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from ApplicationDiscoveryService.</returns>
        public  DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAgents

        /// <summary>
        /// Lists AWS agents by ID or lists all agents associated with your user account if you
        /// did not specify an agent ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgents service method.</param>
        /// 
        /// <returns>The response from the DescribeAgents service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        public DescribeAgentsResponse DescribeAgents(DescribeAgentsRequest request)
        {
            var marshaller = new DescribeAgentsRequestMarshaller();
            var unmarshaller = DescribeAgentsResponseUnmarshaller.Instance;

            return Invoke<DescribeAgentsRequest,DescribeAgentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgents operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAgents
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAgents(DescribeAgentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAgentsRequestMarshaller();
            var unmarshaller = DescribeAgentsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAgentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAgents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAgents.</param>
        /// 
        /// <returns>Returns a  DescribeAgentsResult from ApplicationDiscoveryService.</returns>
        public  DescribeAgentsResponse EndDescribeAgents(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAgentsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTags

        /// <summary>
        /// Retrieve a list of configuration items that are tagged with a specific tag. Or retrieve
        /// a list all tags assigned to a specific configuration item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from ApplicationDiscoveryService.</returns>
        public  DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportConfigurations

        /// <summary>
        /// Exports the selected configurations to an Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportConfigurations service method.</param>
        /// 
        /// <returns>The response from the ExportConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.OperationNotPermittedException">
        /// This operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        public ExportConfigurationsResponse ExportConfigurations(ExportConfigurationsRequest request)
        {
            var marshaller = new ExportConfigurationsRequestMarshaller();
            var unmarshaller = ExportConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ExportConfigurationsRequest,ExportConfigurationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportConfigurations operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportConfigurations
        ///         operation.</returns>
        public IAsyncResult BeginExportConfigurations(ExportConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ExportConfigurationsRequestMarshaller();
            var unmarshaller = ExportConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke<ExportConfigurationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportConfigurations.</param>
        /// 
        /// <returns>Returns a  ExportConfigurationsResult from ApplicationDiscoveryService.</returns>
        public  ExportConfigurationsResponse EndExportConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfigurationAttributes

        /// <summary>
        /// Retrieve a list of attributes for a specific configuration ID. For example, the output
        /// for a <i>server</i> configuration item includes a list of attributes about the server,
        /// including host name, operating system, number of network cards, etc.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationAttributes service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        public GetConfigurationAttributesResponse GetConfigurationAttributes(GetConfigurationAttributesRequest request)
        {
            var marshaller = new GetConfigurationAttributesRequestMarshaller();
            var unmarshaller = GetConfigurationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationAttributesRequest,GetConfigurationAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationAttributes operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationAttributes
        ///         operation.</returns>
        public IAsyncResult BeginGetConfigurationAttributes(GetConfigurationAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetConfigurationAttributesRequestMarshaller();
            var unmarshaller = GetConfigurationAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<GetConfigurationAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationAttributes.</param>
        /// 
        /// <returns>Returns a  GetConfigurationAttributesResult from ApplicationDiscoveryService.</returns>
        public  GetConfigurationAttributesResponse EndGetConfigurationAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfigurationAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExportStatus

        /// <summary>
        /// Retrieves the status of a given export process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportStatus service method.</param>
        /// 
        /// <returns>The response from the GetExportStatus service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        public GetExportStatusResponse GetExportStatus(GetExportStatusRequest request)
        {
            var marshaller = new GetExportStatusRequestMarshaller();
            var unmarshaller = GetExportStatusResponseUnmarshaller.Instance;

            return Invoke<GetExportStatusRequest,GetExportStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExportStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportStatus operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExportStatus
        ///         operation.</returns>
        public IAsyncResult BeginGetExportStatus(GetExportStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetExportStatusRequestMarshaller();
            var unmarshaller = GetExportStatusResponseUnmarshaller.Instance;

            return BeginInvoke<GetExportStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportStatus.</param>
        /// 
        /// <returns>Returns a  GetExportStatusResult from ApplicationDiscoveryService.</returns>
        public  GetExportStatusResponse EndGetExportStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExportStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConfigurations

        /// <summary>
        /// Retrieve a list of configurations items according to the criteria you specify in a
        /// filter. The filter criteria identify relationship requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        public ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request)
        {
            var marshaller = new ListConfigurationsRequestMarshaller();
            var unmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationsRequest,ListConfigurationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurations
        ///         operation.</returns>
        public IAsyncResult BeginListConfigurations(ListConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListConfigurationsRequestMarshaller();
            var unmarshaller = ListConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListConfigurationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurations.</param>
        /// 
        /// <returns>Returns a  ListConfigurationsResult from ApplicationDiscoveryService.</returns>
        public  ListConfigurationsResponse EndListConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveConfiguration

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveConfiguration service method.</param>
        /// 
        /// <returns>The response from the RemoveConfiguration service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ResourceNotFoundException">
        /// The specified configuration ID was not located. Verify the configuration ID and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        public RemoveConfigurationResponse RemoveConfiguration(RemoveConfigurationRequest request)
        {
            var marshaller = new RemoveConfigurationRequestMarshaller();
            var unmarshaller = RemoveConfigurationResponseUnmarshaller.Instance;

            return Invoke<RemoveConfigurationRequest,RemoveConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveConfiguration operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginRemoveConfiguration(RemoveConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemoveConfigurationRequestMarshaller();
            var unmarshaller = RemoveConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveConfiguration.</param>
        /// 
        /// <returns>Returns a  RemoveConfigurationResult from ApplicationDiscoveryService.</returns>
        public  RemoveConfigurationResponse EndRemoveConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDataCollectionByAgentIds

        /// <summary>
        /// Instructs the specified agents to start collecting data. Agents can reside on host
        /// servers or virtual machines in your data center or on AWS EC2 instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollectionByAgentIds service method.</param>
        /// 
        /// <returns>The response from the StartDataCollectionByAgentIds service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        public StartDataCollectionByAgentIdsResponse StartDataCollectionByAgentIds(StartDataCollectionByAgentIdsRequest request)
        {
            var marshaller = new StartDataCollectionByAgentIdsRequestMarshaller();
            var unmarshaller = StartDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return Invoke<StartDataCollectionByAgentIdsRequest,StartDataCollectionByAgentIdsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollectionByAgentIds operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataCollectionByAgentIds
        ///         operation.</returns>
        public IAsyncResult BeginStartDataCollectionByAgentIds(StartDataCollectionByAgentIdsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartDataCollectionByAgentIdsRequestMarshaller();
            var unmarshaller = StartDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return BeginInvoke<StartDataCollectionByAgentIdsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataCollectionByAgentIds.</param>
        /// 
        /// <returns>Returns a  StartDataCollectionByAgentIdsResult from ApplicationDiscoveryService.</returns>
        public  StartDataCollectionByAgentIdsResponse EndStartDataCollectionByAgentIds(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDataCollectionByAgentIdsResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDataCollectionByAgentIds

        /// <summary>
        /// Instructs the specified agents to stop collecting data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollectionByAgentIds service method.</param>
        /// 
        /// <returns>The response from the StopDataCollectionByAgentIds service method, as returned by ApplicationDiscoveryService.</returns>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.AuthorizationErrorException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterException">
        /// One or more parameters are not valid. Verify the parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.InvalidParameterValueException">
        /// The value of one or more parameters are either invalid or out of range. Verify the
        /// parameter values and try again.
        /// </exception>
        /// <exception cref="Amazon.ApplicationDiscoveryService.Model.ServerInternalErrorException">
        /// The server experienced an internal error.
        /// </exception>
        public StopDataCollectionByAgentIdsResponse StopDataCollectionByAgentIds(StopDataCollectionByAgentIdsRequest request)
        {
            var marshaller = new StopDataCollectionByAgentIdsRequestMarshaller();
            var unmarshaller = StopDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return Invoke<StopDataCollectionByAgentIdsRequest,StopDataCollectionByAgentIdsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollectionByAgentIds operation on AmazonApplicationDiscoveryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDataCollectionByAgentIds
        ///         operation.</returns>
        public IAsyncResult BeginStopDataCollectionByAgentIds(StopDataCollectionByAgentIdsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopDataCollectionByAgentIdsRequestMarshaller();
            var unmarshaller = StopDataCollectionByAgentIdsResponseUnmarshaller.Instance;

            return BeginInvoke<StopDataCollectionByAgentIdsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDataCollectionByAgentIds.</param>
        /// 
        /// <returns>Returns a  StopDataCollectionByAgentIdsResult from ApplicationDiscoveryService.</returns>
        public  StopDataCollectionByAgentIdsResponse EndStopDataCollectionByAgentIds(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDataCollectionByAgentIdsResponse>(asyncResult);
        }

        #endregion
        
    }
}