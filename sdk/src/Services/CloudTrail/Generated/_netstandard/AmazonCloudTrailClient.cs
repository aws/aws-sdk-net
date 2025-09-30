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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CloudTrail
{
    /// <summary>
    /// <para>Implementation for accessing CloudTrail</para>
    ///
    /// CloudTrail 
    /// <para>
    /// This is the CloudTrail API Reference. It provides descriptions of actions, data types,
    /// common parameters, and common errors for CloudTrail.
    /// </para>
    ///  
    /// <para>
    /// CloudTrail is a web service that records Amazon Web Services API calls for your Amazon
    /// Web Services account and delivers log files to an Amazon S3 bucket. The recorded information
    /// includes the identity of the user, the start time of the Amazon Web Services API call,
    /// the source IP address, the request parameters, and the response elements returned
    /// by the service.
    /// </para>
    ///  <note> 
    /// <para>
    /// As an alternative to the API, you can use one of the Amazon Web Services SDKs, which
    /// consist of libraries and sample code for various programming languages and platforms
    /// (Java, Ruby, .NET, iOS, Android, etc.). The SDKs provide programmatic access to CloudTrail.
    /// For example, the SDKs handle cryptographically signing requests, managing errors,
    /// and retrying requests automatically. For more information about the Amazon Web Services
    /// SDKs, including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// to Build on Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// See the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-user-guide.html">CloudTrail
    /// User Guide</a> for information about the data that is included with each Amazon Web
    /// Services API call listed in the log files.
    /// </para>
    /// </summary>
    public partial class AmazonCloudTrailClient : AmazonServiceClient, IAmazonCloudTrail
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudTrailMetadata();
        
        #region Constructors

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
            : base(new AmazonCloudTrailConfig()) { }

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
            : base(new AmazonCloudTrailConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
        private ICloudTrailPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudTrailPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudTrailPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudTrailEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudTrailAuthSchemeHandler());
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more tags to a trail, event data store, dashboard, or channel, up to a
        /// limit of 50. Overwrites an existing tag's value when a new value is specified for
        /// an existing tag key. Tag key names must be unique; you cannot have two keys with the
        /// same name but different values. If you specify a key without a value, the tag will
        /// be created with the specified key and a value of null. You can tag a trail or event
        /// data store that applies to all Amazon Web Services Regions only from the Region in
        /// which the trail or event data store was created (also known as its home Region).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TagsLimitExceededException">
        /// The number of tags per trail, event data store, dashboard, or channel has exceeded
        /// the permitted amount. Currently, the limit is 50.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelQuery

        internal virtual CancelQueryResponse CancelQuery(CancelQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQueryResponseUnmarshaller.Instance;

            return Invoke<CancelQueryResponse>(request, options);
        }



        /// <summary>
        /// Cancels a query if the query is not in a terminated state, such as <c>CANCELLED</c>,
        /// <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>FINISHED</c>. You must specify an ARN value
        /// for <c>EventDataStore</c>. The ID of the query that you want to cancel is also required.
        /// When you run <c>CancelQuery</c>, the query status might show as <c>CANCELLED</c> even
        /// if the operation is not yet finished.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveQueryException">
        /// The specified query cannot be canceled because it is in the <c>FINISHED</c>, <c>FAILED</c>,
        /// <c>TIMED_OUT</c>, or <c>CANCELLED</c> state.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.QueryIdNotFoundException">
        /// The query ID does not exist or does not map to a query.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CancelQuery">REST API Reference for CancelQuery Operation</seealso>
        public virtual Task<CancelQueryResponse> CancelQueryAsync(CancelQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQueryResponseUnmarshaller.Instance;

            return InvokeAsync<CancelQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateChannel

        internal virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }



        /// <summary>
        /// Creates a channel for CloudTrail to ingest events from a partner or external source.
        /// After you create a channel, a CloudTrail Lake event data store can log events from
        /// the partner or source that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelAlreadyExistsException">
        /// This exception is thrown when the provided channel already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelMaxLimitExceededException">
        /// This exception is thrown when the maximum number of channels limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidSourceException">
        /// This exception is thrown when the specified value of <c>Source</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TagsLimitExceededException">
        /// The number of tags per trail, event data store, dashboard, or channel has exceeded
        /// the permitted amount. Currently, the limit is 50.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDashboard

        internal virtual CreateDashboardResponse CreateDashboard(CreateDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return Invoke<CreateDashboardResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom dashboard or the Highlights dashboard. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Custom dashboards</b> - Custom dashboards allow you to query events in any event
        /// data store type. You can add up to 10 widgets to a custom dashboard. You can manually
        /// refresh a custom dashboard, or you can set a refresh schedule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Highlights dashboard</b> - You can create the Highlights dashboard to see a summary
        /// of key user activities and API usage across all your event data stores. CloudTrail
        /// Lake manages the Highlights dashboard and refreshes the dashboard every 6 hours. To
        /// create the Highlights dashboard, you must set and enable a refresh schedule.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  CloudTrail runs queries to populate the dashboard's widgets during a manual or scheduled
        /// refresh. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
        /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
        /// to attach a resource-based policy to each event data store. For more information,
        /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
        /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  To set a refresh schedule, CloudTrail must be granted permissions to run the <c>StartDashboardRefresh</c>
        /// operation to refresh the dashboard on your behalf. To provide permissions, run the
        /// <c>PutResourcePolicy</c> operation to attach a resource-based policy to the dashboard.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-dashboards">
        /// Resource-based policy example for a dashboard</a> in the <i>CloudTrail User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about dashboards, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-dashboard.html">CloudTrail
        /// Lake dashboards</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatementException">
        /// The query that was submitted has validation errors, or uses incorrect syntax or unsupported
        /// keywords. For more information about writing a query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ServiceQuotaExceededException">
        /// This exception is thrown when the quota is exceeded. For information about CloudTrail
        /// quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/ct.html#limits_cloudtrail">Service
        /// quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual Task<CreateDashboardResponse> CreateDashboardAsync(CreateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEventDataStore

        internal virtual CreateEventDataStoreResponse CreateEventDataStore(CreateEventDataStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventDataStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventDataStoreResponseUnmarshaller.Instance;

            return Invoke<CreateEventDataStoreResponse>(request, options);
        }



        /// <summary>
        /// Creates a new event data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventDataStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreAlreadyExistsException">
        /// An event data store with that name already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreMaxLimitExceededException">
        /// Your account has used the maximum number of event data stores.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
        /// 
        ///  
        /// <para>
        /// You can:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a valid number of event selectors (1 to 5) for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid number of data resources (1 to 250) for an event selector. The limit
        /// of number of resources on an individual event selector is configurable up to 250.
        /// However, this upper limit is allowed only if the total number of data resources does
        /// not exceed 250 across all event selectors for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateEventDataStore">REST API Reference for CreateEventDataStore Operation</seealso>
        public virtual Task<CreateEventDataStoreResponse> CreateEventDataStoreAsync(CreateEventDataStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventDataStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventDataStoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventDataStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTrail

        internal virtual CreateTrailResponse CreateTrail(CreateTrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrailResponseUnmarshaller.Instance;

            return Invoke<CreateTrailResponse>(request, options);
        }



        /// <summary>
        /// Creates a trail that specifies the settings for delivery of log data to an Amazon
        /// S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailInvalidClientTokenIdException">
        /// This exception is thrown when a call results in the <c>InvalidClientTokenId</c> error
        /// code. This can occur when you are creating or updating a trail to send notifications
        /// to an Amazon SNS topic that is in a suspended Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudWatchLogsDeliveryUnavailableException">
        /// Cannot set a CloudWatch Logs delivery for this Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the Amazon SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsLogGroupArnException">
        /// This exception is thrown when the provided CloudWatch Logs log group is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsRoleArnException">
        /// This exception is thrown when the provided role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3BucketNameException">
        /// This exception is thrown when the provided S3 bucket name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3PrefixException">
        /// This exception is thrown when the provided S3 prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidSnsTopicNameException">
        /// This exception is thrown when the provided SNS topic name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyDisabledException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.MaximumNumberOfTrailsExceededException">
        /// This exception is thrown when the maximum number of trails is reached.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TagsLimitExceededException">
        /// The number of tags per trail, event data store, dashboard, or channel has exceeded
        /// the permitted amount. Currently, the limit is 50.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailAlreadyExistsException">
        /// This exception is thrown when the specified trail already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotProvidedException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/CreateTrail">REST API Reference for CreateTrail Operation</seealso>
        public virtual Task<CreateTrailResponse> CreateTrailAsync(CreateTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrailResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteChannel

        internal virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDashboard

        internal virtual DeleteDashboardResponse DeleteDashboard(DeleteDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return Invoke<DeleteDashboardResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified dashboard. You cannot delete a dashboard that has termination
        /// protection enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual Task<DeleteDashboardResponse> DeleteDashboardAsync(DeleteDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEventDataStore

        internal virtual DeleteEventDataStoreResponse DeleteEventDataStore(DeleteEventDataStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventDataStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventDataStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteEventDataStoreResponse>(request, options);
        }



        /// <summary>
        /// Disables the event data store specified by <c>EventDataStore</c>, which accepts an
        /// event data store ARN. After you run <c>DeleteEventDataStore</c>, the event data store
        /// enters a <c>PENDING_DELETION</c> state, and is automatically deleted after a wait
        /// period of seven days. <c>TerminationProtectionEnabled</c> must be set to <c>False</c>
        /// on the event data store and the <c>FederationStatus</c> must be <c>DISABLED</c>. You
        /// cannot delete an event data store if <c>TerminationProtectionEnabled</c> is <c>True</c>
        /// or the <c>FederationStatus</c> is <c>ENABLED</c>.
        /// 
        ///  
        /// <para>
        /// After you run <c>DeleteEventDataStore</c> on an event data store, you cannot run <c>ListQueries</c>,
        /// <c>DescribeQuery</c>, or <c>GetQueryResults</c> on queries that are using an event
        /// data store in a <c>PENDING_DELETION</c> state. An event data store in the <c>PENDING_DELETION</c>
        /// state does not incur costs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventDataStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelExistsForEDSException">
        /// This exception is thrown when the specified event data store cannot yet be deleted
        /// because it is in use by a channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreFederationEnabledException">
        /// You cannot delete the event data store because Lake query federation is enabled.
        /// To delete the event data store, run the <c>DisableFederation</c> operation to disable
        /// Lake query federation on the event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreHasOngoingImportException">
        /// This exception is thrown when you try to update or delete an event data store that
        /// currently has an import in progress.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreTerminationProtectedException">
        /// The event data store cannot be deleted because termination protection is enabled for
        /// it.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteEventDataStore">REST API Reference for DeleteEventDataStore Operation</seealso>
        public virtual Task<DeleteEventDataStoreResponse> DeleteEventDataStoreAsync(DeleteEventDataStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventDataStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventDataStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventDataStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the resource-based policy attached to the CloudTrail event data store, dashboard,
        /// or channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceARNNotValidException">
        /// This exception is thrown when the provided resource does not exist, or the ARN format
        /// of the resource is not valid. 
        /// 
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourcePolicyNotFoundException">
        /// This exception is thrown when the specified resource policy is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTrail

        internal virtual DeleteTrailResponse DeleteTrail(DeleteTrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrailResponseUnmarshaller.Instance;

            return Invoke<DeleteTrailResponse>(request, options);
        }



        /// <summary>
        /// Deletes a trail. This operation must be called from the Region in which the trail
        /// was created. <c>DeleteTrail</c> cannot be called on the shadow trails (replicated
        /// trails in other Regions) of a trail that is enabled in all Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeleteTrail">REST API Reference for DeleteTrail Operation</seealso>
        public virtual Task<DeleteTrailResponse> DeleteTrailAsync(DeleteTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrailResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeregisterOrganizationDelegatedAdmin

        internal virtual DeregisterOrganizationDelegatedAdminResponse DeregisterOrganizationDelegatedAdmin(DeregisterOrganizationDelegatedAdminRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterOrganizationDelegatedAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance;

            return Invoke<DeregisterOrganizationDelegatedAdminResponse>(request, options);
        }



        /// <summary>
        /// Removes CloudTrail delegated administrator permissions from a member account in an
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOrganizationDelegatedAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterOrganizationDelegatedAdmin service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccountNotFoundException">
        /// This exception is thrown when the specified account is not found or not part of an
        /// organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.AccountNotRegisteredException">
        /// This exception is thrown when the specified account is not registered as the CloudTrail
        /// delegated administrator.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationManagementAccountException">
        /// This exception is thrown when the account making the request is not the organization's
        /// management account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DeregisterOrganizationDelegatedAdmin">REST API Reference for DeregisterOrganizationDelegatedAdmin Operation</seealso>
        public virtual Task<DeregisterOrganizationDelegatedAdminResponse> DeregisterOrganizationDelegatedAdminAsync(DeregisterOrganizationDelegatedAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterOrganizationDelegatedAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterOrganizationDelegatedAdminResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeQuery

        internal virtual DescribeQueryResponse DescribeQuery(DescribeQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueryResponseUnmarshaller.Instance;

            return Invoke<DescribeQueryResponse>(request, options);
        }



        /// <summary>
        /// Returns metadata about a query, including query run time in milliseconds, number of
        /// events scanned and matched, and query status. If the query results were delivered
        /// to an S3 bucket, the response also provides the S3 URI and the delivery status.
        /// 
        ///  
        /// <para>
        /// You must specify either <c>QueryId</c> or <c>QueryAlias</c>. Specifying the <c>QueryAlias</c>
        /// parameter returns information about the last query run for the alias. You can provide
        /// <c>RefreshId</c> along with <c>QueryAlias</c> to view the query results of a dashboard
        /// query for the specified <c>RefreshId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.QueryIdNotFoundException">
        /// The query ID does not exist or does not map to a query.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeQuery">REST API Reference for DescribeQuery Operation</seealso>
        public virtual Task<DescribeQueryResponse> DescribeQueryAsync(DescribeQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTrails

        internal virtual DescribeTrailsResponse DescribeTrails()
        {
            return DescribeTrails(new DescribeTrailsRequest());
        }
        internal virtual DescribeTrailsResponse DescribeTrails(DescribeTrailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrailsResponseUnmarshaller.Instance;

            return Invoke<DescribeTrailsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves settings for one or more trails associated with the current Region for your
        /// account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
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
        /// Retrieves settings for one or more trails associated with the current Region for your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DescribeTrails">REST API Reference for DescribeTrails Operation</seealso>
        public virtual Task<DescribeTrailsResponse> DescribeTrailsAsync(DescribeTrailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrailsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrailsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableFederation

        internal virtual DisableFederationResponse DisableFederation(DisableFederationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableFederationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableFederationResponseUnmarshaller.Instance;

            return Invoke<DisableFederationResponse>(request, options);
        }



        /// <summary>
        /// Disables Lake query federation on the specified event data store. When you disable
        /// federation, CloudTrail disables the integration with Glue, Lake Formation, and Amazon
        /// Athena. After disabling Lake query federation, you can no longer query your event
        /// data in Amazon Athena.
        /// 
        ///  
        /// <para>
        /// No CloudTrail Lake data is deleted when you disable federation and you can continue
        /// to run queries in CloudTrail Lake.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableFederation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableFederation service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConcurrentModificationException">
        /// You are trying to update a resource when another request is in progress. Allow sufficient
        /// wait time for the previous request to complete, then retry your request.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/DisableFederation">REST API Reference for DisableFederation Operation</seealso>
        public virtual Task<DisableFederationResponse> DisableFederationAsync(DisableFederationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableFederationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableFederationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableFederationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableFederation

        internal virtual EnableFederationResponse EnableFederation(EnableFederationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableFederationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableFederationResponseUnmarshaller.Instance;

            return Invoke<EnableFederationResponse>(request, options);
        }



        /// <summary>
        /// Enables Lake query federation on the specified event data store. Federating an event
        /// data store lets you view the metadata associated with the event data store in the
        /// Glue <a href="https://docs.aws.amazon.com/glue/latest/dg/components-overview.html#data-catalog-intro">Data
        /// Catalog</a> and run SQL queries against your event data using Amazon Athena. The table
        /// metadata stored in the Glue Data Catalog lets the Athena query engine know how to
        /// find, read, and process the data that you want to query.
        /// 
        ///  
        /// <para>
        /// When you enable Lake query federation, CloudTrail creates a managed database named
        /// <c>aws:cloudtrail</c> (if the database doesn't already exist) and a managed federated
        /// table in the Glue Data Catalog. The event data store ID is used for the table name.
        /// CloudTrail registers the role ARN and event data store in <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-federation-lake-formation.html">Lake
        /// Formation</a>, the service responsible for allowing fine-grained access control of
        /// the federated resources in the Glue Data Catalog.
        /// </para>
        ///  
        /// <para>
        /// For more information about Lake query federation, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-federation.html">Federate
        /// an event data store</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableFederation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableFederation service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConcurrentModificationException">
        /// You are trying to update a resource when another request is in progress. Allow sufficient
        /// wait time for the previous request to complete, then retry your request.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreFederationEnabledException">
        /// You cannot delete the event data store because Lake query federation is enabled.
        /// To delete the event data store, run the <c>DisableFederation</c> operation to disable
        /// Lake query federation on the event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/EnableFederation">REST API Reference for EnableFederation Operation</seealso>
        public virtual Task<EnableFederationResponse> EnableFederationAsync(EnableFederationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableFederationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableFederationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableFederationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GenerateQuery

        internal virtual GenerateQueryResponse GenerateQuery(GenerateQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateQueryResponseUnmarshaller.Instance;

            return Invoke<GenerateQueryResponse>(request, options);
        }



        /// <summary>
        /// Generates a query from a natural language prompt. This operation uses generative
        /// artificial intelligence (generative AI) to produce a ready-to-use SQL query from the
        /// prompt. 
        /// 
        ///  
        /// <para>
        /// The prompt can be a question or a statement about the event data in your event data
        /// store. For example, you can enter prompts like "What are my top errors in the past
        /// month?" and “Give me a list of users that used SNS.”
        /// </para>
        ///  
        /// <para>
        /// The prompt must be in English. For information about limitations, permissions, and
        /// supported Regions, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-query-generator.html">Create
        /// CloudTrail Lake queries from natural language prompts</a> in the <i>CloudTrail </i>
        /// user guide.
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not include any personally identifying, confidential, or sensitive information
        /// in your prompts.
        /// </para>
        ///  
        /// <para>
        /// This feature uses generative AI large language models (LLMs); we recommend double-checking
        /// the LLM response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.GenerateResponseException">
        /// This exception is thrown when a valid query could not be generated for the provided
        /// prompt.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GenerateQuery">REST API Reference for GenerateQuery Operation</seealso>
        public virtual Task<GenerateQueryResponse> GenerateQueryAsync(GenerateQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateQueryResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetChannel

        internal virtual GetChannelResponse GetChannel(GetChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelResponseUnmarshaller.Instance;

            return Invoke<GetChannelResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetChannel">REST API Reference for GetChannel Operation</seealso>
        public virtual Task<GetChannelResponse> GetChannelAsync(GetChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetChannelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDashboard

        internal virtual GetDashboardResponse GetDashboard(GetDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardResponseUnmarshaller.Instance;

            return Invoke<GetDashboardResponse>(request, options);
        }



        /// <summary>
        /// Returns the specified dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        public virtual Task<GetDashboardResponse> GetDashboardAsync(GetDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<GetDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEventConfiguration

        internal virtual GetEventConfigurationResponse GetEventConfiguration(GetEventConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetEventConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current event configuration settings for the specified event data store,
        /// including details about maximum event size and context key selectors configured for
        /// the event data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventConfiguration service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventConfiguration">REST API Reference for GetEventConfiguration Operation</seealso>
        public virtual Task<GetEventConfigurationResponse> GetEventConfigurationAsync(GetEventConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEventDataStore

        internal virtual GetEventDataStoreResponse GetEventDataStore(GetEventDataStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventDataStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventDataStoreResponseUnmarshaller.Instance;

            return Invoke<GetEventDataStoreResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an event data store specified as either an ARN or the ID
        /// portion of the ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventDataStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventDataStore">REST API Reference for GetEventDataStore Operation</seealso>
        public virtual Task<GetEventDataStoreResponse> GetEventDataStoreAsync(GetEventDataStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventDataStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventDataStoreResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventDataStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEventSelectors

        internal virtual GetEventSelectorsResponse GetEventSelectors(GetEventSelectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventSelectorsResponseUnmarshaller.Instance;

            return Invoke<GetEventSelectorsResponse>(request, options);
        }



        /// <summary>
        /// Describes the settings for the event selectors that you configured for your trail.
        /// The information returned for your event selectors includes the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If your event selector includes read-only events, write-only events, or all events.
        /// This applies to management events, data events, and network activity events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes management events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes network activity events, the event sources for which
        /// you are logging network activity events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your event selector includes data events, the resources on which you are logging
        /// data events.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about logging management, data, and network activity events,
        /// see the following topics in the <i>CloudTrail User Guide</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html">Logging
        /// management events</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
        /// data events</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-network-events-with-cloudtrail.html">Logging
        /// network activity events</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetEventSelectors">REST API Reference for GetEventSelectors Operation</seealso>
        public virtual Task<GetEventSelectorsResponse> GetEventSelectorsAsync(GetEventSelectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventSelectorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEventSelectorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetImport

        internal virtual GetImportResponse GetImport(GetImportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportResponseUnmarshaller.Instance;

            return Invoke<GetImportResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImport service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ImportNotFoundException">
        /// The specified import was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetImport">REST API Reference for GetImport Operation</seealso>
        public virtual Task<GetImportResponse> GetImportAsync(GetImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetInsightSelectors

        internal virtual GetInsightSelectorsResponse GetInsightSelectors(GetInsightSelectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightSelectorsResponseUnmarshaller.Instance;

            return Invoke<GetInsightSelectorsResponse>(request, options);
        }



        /// <summary>
        /// Describes the settings for the Insights event selectors that you configured for your
        /// trail or event data store. <c>GetInsightSelectors</c> shows if CloudTrail Insights
        /// event logging is enabled on the trail or event data store, and if it is, which Insights
        /// types are enabled. If you run <c>GetInsightSelectors</c> on a trail or event data
        /// store that does not have Insights events enabled, the operation throws the exception
        /// <c>InsightNotEnabledException</c> 
        /// 
        ///  
        /// <para>
        /// Specify either the <c>EventDataStore</c> parameter to get Insights event selectors
        /// for an event data store, or the <c>TrailName</c> parameter to the get Insights event
        /// selectors for a trail. You cannot specify these parameters together.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
        /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsightSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsightNotEnabledException">
        /// If you run <c>GetInsightSelectors</c> on a trail or event data store that does not
        /// have Insights events enabled, the operation throws the exception <c>InsightNotEnabledException</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetInsightSelectors">REST API Reference for GetInsightSelectors Operation</seealso>
        public virtual Task<GetInsightSelectorsResponse> GetInsightSelectorsAsync(GetInsightSelectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightSelectorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetInsightSelectorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetQueryResults

        internal virtual GetQueryResultsResponse GetQueryResults(GetQueryResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsResponse>(request, options);
        }



        /// <summary>
        /// Gets event data results of a query. You must specify the <c>QueryID</c> value returned
        /// by the <c>StartQuery</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryResults service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.QueryIdNotFoundException">
        /// The query ID does not exist or does not map to a query.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual Task<GetQueryResultsResponse> GetQueryResultsAsync(GetQueryResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourcePolicy

        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the JSON text of the resource-based policy document attached to the CloudTrail
        /// event data store, dashboard, or channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceARNNotValidException">
        /// This exception is thrown when the provided resource does not exist, or the ARN format
        /// of the resource is not valid. 
        /// 
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourcePolicyNotFoundException">
        /// This exception is thrown when the specified resource policy is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTrail

        internal virtual GetTrailResponse GetTrail(GetTrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrailResponseUnmarshaller.Instance;

            return Invoke<GetTrailResponse>(request, options);
        }



        /// <summary>
        /// Returns settings information for a specified trail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrail">REST API Reference for GetTrail Operation</seealso>
        public virtual Task<GetTrailResponse> GetTrailAsync(GetTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrailResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrailResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTrailStatus

        internal virtual GetTrailStatusResponse GetTrailStatus(GetTrailStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrailStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrailStatusResponseUnmarshaller.Instance;

            return Invoke<GetTrailStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns a JSON-formatted list of information about the specified trail. Fields include
        /// information on delivery errors, Amazon SNS and Amazon S3 errors, and start and stop
        /// logging times for each trail. This operation returns trail status from a single Region.
        /// To return trail status from all Regions, you must call the operation on each Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrailStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrailStatus service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/GetTrailStatus">REST API Reference for GetTrailStatus Operation</seealso>
        public virtual Task<GetTrailStatusResponse> GetTrailStatusAsync(GetTrailStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrailStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrailStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrailStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListChannels

        internal virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }



        /// <summary>
        /// Lists the channels in the current account, and their source names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDashboards

        internal virtual ListDashboardsResponse ListDashboards(ListDashboardsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return Invoke<ListDashboardsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about all dashboards in the account, in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDashboardsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEventDataStores

        internal virtual ListEventDataStoresResponse ListEventDataStores(ListEventDataStoresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventDataStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventDataStoresResponseUnmarshaller.Instance;

            return Invoke<ListEventDataStoresResponse>(request, options);
        }



        /// <summary>
        /// Returns information about all event data stores in the account, in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventDataStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventDataStores service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListEventDataStores">REST API Reference for ListEventDataStores Operation</seealso>
        public virtual Task<ListEventDataStoresResponse> ListEventDataStoresAsync(ListEventDataStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventDataStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventDataStoresResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventDataStoresResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListImportFailures

        internal virtual ListImportFailuresResponse ListImportFailures(ListImportFailuresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportFailuresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportFailuresResponseUnmarshaller.Instance;

            return Invoke<ListImportFailuresResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of failures for the specified import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportFailures service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImportFailures service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListImportFailures">REST API Reference for ListImportFailures Operation</seealso>
        public virtual Task<ListImportFailuresResponse> ListImportFailuresAsync(ListImportFailuresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportFailuresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportFailuresResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportFailuresResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListImports

        internal virtual ListImportsResponse ListImports(ListImportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportsResponseUnmarshaller.Instance;

            return Invoke<ListImportsResponse>(request, options);
        }



        /// <summary>
        /// Returns information on all imports, or a select set of imports by <c>ImportStatus</c>
        /// or <c>Destination</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListImports">REST API Reference for ListImports Operation</seealso>
        public virtual Task<ListImportsResponse> ListImportsAsync(ListImportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInsightsMetricData

        internal virtual ListInsightsMetricDataResponse ListInsightsMetricData(ListInsightsMetricDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInsightsMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInsightsMetricDataResponseUnmarshaller.Instance;

            return Invoke<ListInsightsMetricDataResponse>(request, options);
        }



        /// <summary>
        /// Returns Insights metrics data for trails that have enabled Insights. The request must
        /// include the <c>EventSource</c>, <c>EventName</c>, and <c>InsightType</c> parameters.
        /// 
        ///  
        /// <para>
        /// If the <c>InsightType</c> is set to <c>ApiErrorRateInsight</c>, the request must also
        /// include the <c>ErrorCode</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// The following are the available time periods for <c>ListInsightsMetricData</c>. Each
        /// cutoff is inclusive.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data points with a period of 60 seconds (1-minute) are available for 15 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 300 seconds (5-minute) are available for 63 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 3600 seconds (1 hour) are available for 90 days.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Access to the <c>ListInsightsMetricData</c> API operation is linked to the <c>cloudtrail:LookupEvents</c>
        /// action. To use this operation, you must have permissions to perform the <c>cloudtrail:LookupEvents</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInsightsMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInsightsMetricData service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListInsightsMetricData">REST API Reference for ListInsightsMetricData Operation</seealso>
        public virtual Task<ListInsightsMetricDataResponse> ListInsightsMetricDataAsync(ListInsightsMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInsightsMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInsightsMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<ListInsightsMetricDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPublicKeys

        internal virtual ListPublicKeysResponse ListPublicKeys(ListPublicKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListPublicKeysResponse>(request, options);
        }



        /// <summary>
        /// Returns all public keys whose private keys were used to sign the digest files within
        /// the specified time range. The public key is needed to validate digest files that were
        /// signed with its corresponding private key.
        /// 
        ///  <note> 
        /// <para>
        /// CloudTrail uses different private and public key pairs per Region. Each digest file
        /// is signed with a private key unique to its Region. When you validate a digest file
        /// from a specific Region, you must look in the same Region for its corresponding public
        /// key.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPublicKeys service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTimeRangeException">
        /// Occurs if the timestamp values are not valid. Either the start time occurs after the
        /// end time, or the time range is outside the range of possible values.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTokenException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual Task<ListPublicKeysResponse> ListPublicKeysAsync(ListPublicKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListPublicKeysResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListQueries

        internal virtual ListQueriesResponse ListQueries(ListQueriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueriesResponseUnmarshaller.Instance;

            return Invoke<ListQueriesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of queries and query statuses for the past seven days. You must specify
        /// an ARN value for <c>EventDataStore</c>. Optionally, to shorten the list of results,
        /// you can specify a time range, formatted as timestamps, by adding <c>StartTime</c>
        /// and <c>EndTime</c> parameters, and a <c>QueryStatus</c> value. Valid values for <c>QueryStatus</c>
        /// include <c>QUEUED</c>, <c>RUNNING</c>, <c>FINISHED</c>, <c>FAILED</c>, <c>TIMED_OUT</c>,
        /// or <c>CANCELLED</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueries service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidDateRangeException">
        /// A date range for the query was specified that is not valid. Be sure that the start
        /// time is chronologically before the end time. For more information about writing a
        /// query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatusException">
        /// The query status is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListQueries">REST API Reference for ListQueries Operation</seealso>
        public virtual Task<ListQueriesResponse> ListQueriesAsync(ListQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQueriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags for the specified trails, event data stores, dashboards, or channels
        /// in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTokenException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTrails

        internal virtual ListTrailsResponse ListTrails(ListTrailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrailsResponseUnmarshaller.Instance;

            return Invoke<ListTrailsResponse>(request, options);
        }



        /// <summary>
        /// Lists trails that are in the current account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/ListTrails">REST API Reference for ListTrails Operation</seealso>
        public virtual Task<ListTrailsResponse> ListTrailsAsync(ListTrailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrailsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrailsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  LookupEvents

        internal virtual LookupEventsResponse LookupEvents(LookupEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = LookupEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupEventsResponseUnmarshaller.Instance;

            return Invoke<LookupEventsResponse>(request, options);
        }



        /// <summary>
        /// Looks up <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html#cloudtrail-concepts-management-events">management
        /// events</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html#cloudtrail-concepts-insights-events">CloudTrail
        /// Insights events</a> that are captured by CloudTrail. You can look up events that occurred
        /// in a Region within the last 90 days.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>LookupEvents</c> returns recent Insights events for trails that enable Insights.
        /// To view Insights events for an event data store, you can run queries on your Insights
        /// event data store, and you can also view the Lake dashboard for Insights.
        /// </para>
        ///  </note> 
        /// <para>
        /// Lookup supports the following attributes for management events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services access key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event source
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Read only
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resource name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resource type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User name
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Lookup supports the following attributes for Insights events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Event ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Event source
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// All attributes are optional. The default number of results returned is 50, with a
        /// maximum of 50 possible. The response includes a token that you can use to get the
        /// next page of results.
        /// </para>
        ///  <important> 
        /// <para>
        /// The rate of lookup requests is limited to two per second, per account, per Region.
        /// If this limit is exceeded, a throttling error occurs.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LookupEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the LookupEvents service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventCategoryException">
        /// Occurs if an event category that is not valid is specified as a value of <c>EventCategory</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidLookupAttributesException">
        /// Occurs when a lookup attribute is specified that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidMaxResultsException">
        /// This exception is thrown if the limit specified is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidNextTokenException">
        /// A token that is not valid, or a token that was previously used in a request with different
        /// parameters. This exception is thrown if the token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTimeRangeException">
        /// Occurs if the timestamp values are not valid. Either the start time occurs after the
        /// end time, or the time range is outside the range of possible values.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/LookupEvents">REST API Reference for LookupEvents Operation</seealso>
        public virtual Task<LookupEventsResponse> LookupEventsAsync(LookupEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = LookupEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupEventsResponseUnmarshaller.Instance;

            return InvokeAsync<LookupEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutEventConfiguration

        internal virtual PutEventConfigurationResponse PutEventConfiguration(PutEventConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutEventConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the event configuration settings for the specified event data store. You can
        /// update the maximum event size and context key selectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEventConfiguration service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientIAMAccessPermissionException">
        /// The task can't be completed because you are signed in with an account that lacks permissions
        /// to view or create a service-linked role. Sign in with an account that has the required
        /// permissions and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutEventConfiguration">REST API Reference for PutEventConfiguration Operation</seealso>
        public virtual Task<PutEventConfigurationResponse> PutEventConfigurationAsync(PutEventConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutEventConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutEventSelectors

        internal virtual PutEventSelectorsResponse PutEventSelectors(PutEventSelectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventSelectorsResponseUnmarshaller.Instance;

            return Invoke<PutEventSelectorsResponse>(request, options);
        }



        /// <summary>
        /// Configures event selectors (also referred to as <i>basic event selectors</i>) or advanced
        /// event selectors for your trail. You can use either <c>AdvancedEventSelectors</c> or
        /// <c>EventSelectors</c>, but not both. If you apply <c>AdvancedEventSelectors</c> to
        /// a trail, any existing <c>EventSelectors</c> are overwritten.
        /// 
        ///  
        /// <para>
        /// You can use <c>AdvancedEventSelectors</c> to log management events, data events for
        /// all resource types, and network activity events.
        /// </para>
        ///  
        /// <para>
        /// You can use <c>EventSelectors</c> to log management events and data events for the
        /// following resource types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS::DynamoDB::Table</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Lambda::Function</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3::Object</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't use <c>EventSelectors</c> to log network activity events.
        /// </para>
        ///  
        /// <para>
        /// If you want your trail to log Insights events, be sure the event selector or advanced
        /// event selector enables logging of the Insights event types you want configured for
        /// your trail. For more information about logging Insights events, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
        /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>. By default, trails
        /// created without specific event selectors are configured to log all read and write
        /// management events, and no data events or network activity events.
        /// </para>
        ///  
        /// <para>
        /// When an event occurs in your account, CloudTrail evaluates the event selectors or
        /// advanced event selectors in all trails. For each trail, if the event matches any event
        /// selector, the trail processes and logs the event. If the event doesn't match any event
        /// selector, the trail doesn't log the event.
        /// </para>
        ///  
        /// <para>
        /// Example
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You create an event selector for a trail and specify that you want to log write-only
        /// events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 <c>GetConsoleOutput</c> and <c>RunInstances</c> API operations occur in your
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudTrail evaluates whether the events match your event selectors.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>RunInstances</c> is a write-only event and it matches your event selector.
        /// The trail logs the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>GetConsoleOutput</c> is a read-only event that doesn't match your event selector.
        /// The trail doesn't log the event. 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// The <c>PutEventSelectors</c> operation must be called from the Region in which the
        /// trail was created; otherwise, an <c>InvalidHomeRegionException</c> exception is thrown.
        /// </para>
        ///  
        /// <para>
        /// You can configure up to five event selectors for each trail.
        /// </para>
        ///  
        /// <para>
        /// You can add advanced event selectors, and conditions for your advanced event selectors,
        /// up to a maximum of 500 values for all conditions and selectors on a trail. For more
        /// information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html">Logging
        /// management events</a>, <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
        /// data events</a>, <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-network-events-with-cloudtrail.html">Logging
        /// network activity events</a>, and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html">Quotas
        /// in CloudTrail</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEventSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
        /// 
        ///  
        /// <para>
        /// You can:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a valid number of event selectors (1 to 5) for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid number of data resources (1 to 250) for an event selector. The limit
        /// of number of resources on an individual event selector is configurable up to 250.
        /// However, this upper limit is allowed only if the total number of data resources does
        /// not exceed 250 across all event selectors for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutEventSelectors">REST API Reference for PutEventSelectors Operation</seealso>
        public virtual Task<PutEventSelectorsResponse> PutEventSelectorsAsync(PutEventSelectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventSelectorsResponseUnmarshaller.Instance;

            return InvokeAsync<PutEventSelectorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutInsightSelectors

        internal virtual PutInsightSelectorsResponse PutInsightSelectors(PutInsightSelectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutInsightSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInsightSelectorsResponseUnmarshaller.Instance;

            return Invoke<PutInsightSelectorsResponse>(request, options);
        }



        /// <summary>
        /// Lets you enable Insights event logging by specifying the Insights selectors that you
        /// want to enable on an existing trail or event data store. You also use <c>PutInsightSelectors</c>
        /// to turn off Insights event logging, by passing an empty list of Insights types. The
        /// valid Insights event types are <c>ApiErrorRateInsight</c> and <c>ApiCallRateInsight</c>.
        /// 
        ///  
        /// <para>
        /// To enable Insights on an event data store, you must specify the ARNs (or ID suffix
        /// of the ARNs) for the source event data store (<c>EventDataStore</c>) and the destination
        /// event data store (<c>InsightsDestination</c>). The source event data store logs management
        /// events and enables Insights. The destination event data store logs Insights events
        /// based upon the management event activity of the source event data store. The source
        /// and destination event data stores must belong to the same Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// To log Insights events for a trail, you must specify the name (<c>TrailName</c>) of
        /// the CloudTrail trail for which you want to change or add Insights selectors.
        /// </para>
        ///  
        /// <para>
        /// To log CloudTrail Insights events on API call volume, the trail or event data store
        /// must log <c>write</c> management events. To log CloudTrail Insights events on API
        /// error rate, the trail or event data store must log <c>read</c> or <c>write</c> management
        /// events. You can call <c>GetEventSelectors</c> on a trail to check whether the trail
        /// logs management events. You can call <c>GetEventDataStore</c> on an event data store
        /// to check whether the event data store logs management events.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
        /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInsightSelectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutInsightSelectors service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidInsightSelectorsException">
        /// For <c>PutInsightSelectors</c>, this exception is thrown when the formatting or syntax
        /// of the <c>InsightSelectors</c> JSON statement is not valid, or the specified <c>InsightType</c>
        /// in the <c>InsightSelectors</c> statement is not valid. Valid values for <c>InsightType</c>
        /// are <c>ApiCallRateInsight</c> and <c>ApiErrorRateInsight</c>. To enable Insights on
        /// an event data store, the destination event data store specified by the <c>InsightsDestination</c>
        /// parameter must log Insights events and the source event data store specified by the
        /// <c>EventDataStore</c> parameter must log management events.
        /// 
        ///  
        /// <para>
        /// For <c>UpdateEventDataStore</c>, this exception is thrown if Insights are enabled
        /// on the event data store and the updated advanced event selectors are not compatible
        /// with the configured <c>InsightSelectors</c>. If the <c>InsightSelectors</c> includes
        /// an <c>InsightType</c> of <c>ApiCallRateInsight</c>, the source event data store must
        /// log <c>write</c> management events. If the <c>InsightSelectors</c> includes an <c>InsightType</c>
        /// of <c>ApiErrorRateInsight</c>, the source event data store must log management events.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutInsightSelectors">REST API Reference for PutInsightSelectors Operation</seealso>
        public virtual Task<PutInsightSelectorsResponse> PutInsightSelectorsAsync(PutInsightSelectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutInsightSelectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInsightSelectorsResponseUnmarshaller.Instance;

            return InvokeAsync<PutInsightSelectorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Attaches a resource-based permission policy to a CloudTrail event data store, dashboard,
        /// or channel. For more information about resource-based policies, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html">CloudTrail
        /// resource-based policy examples</a> in the <i>CloudTrail User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceARNNotValidException">
        /// This exception is thrown when the provided resource does not exist, or the ARN format
        /// of the resource is not valid. 
        /// 
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourcePolicyNotValidException">
        /// This exception is thrown when the resouce-based policy has syntax errors, or contains
        /// a principal that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterOrganizationDelegatedAdmin

        internal virtual RegisterOrganizationDelegatedAdminResponse RegisterOrganizationDelegatedAdmin(RegisterOrganizationDelegatedAdminRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterOrganizationDelegatedAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance;

            return Invoke<RegisterOrganizationDelegatedAdminResponse>(request, options);
        }



        /// <summary>
        /// Registers an organization’s member account as the CloudTrail <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-delegated-administrator.html">delegated
        /// administrator</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOrganizationDelegatedAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterOrganizationDelegatedAdmin service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccountNotFoundException">
        /// This exception is thrown when the specified account is not found or not part of an
        /// organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.AccountRegisteredException">
        /// This exception is thrown when the account is already registered as the CloudTrail
        /// delegated administrator.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CannotDelegateManagementAccountException">
        /// This exception is thrown when the management account of an organization is registered
        /// as the CloudTrail delegated administrator.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.DelegatedAdminAccountLimitExceededException">
        /// This exception is thrown when the maximum number of CloudTrail delegated administrators
        /// is reached.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientIAMAccessPermissionException">
        /// The task can't be completed because you are signed in with an account that lacks permissions
        /// to view or create a service-linked role. Sign in with an account that has the required
        /// permissions and then try again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationManagementAccountException">
        /// This exception is thrown when the account making the request is not the organization's
        /// management account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RegisterOrganizationDelegatedAdmin">REST API Reference for RegisterOrganizationDelegatedAdmin Operation</seealso>
        public virtual Task<RegisterOrganizationDelegatedAdminResponse> RegisterOrganizationDelegatedAdminAsync(RegisterOrganizationDelegatedAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterOrganizationDelegatedAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterOrganizationDelegatedAdminResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags from a trail, event data store, dashboard, or channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTagParameterException">
        /// This exception is thrown when the specified tag key or values are not valid. It can
        /// also occur if there are duplicate tags or too many tags on the resource.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceTypeNotSupportedException">
        /// This exception is thrown when the specified resource type is not supported by CloudTrail.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreEventDataStore

        internal virtual RestoreEventDataStoreResponse RestoreEventDataStore(RestoreEventDataStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreEventDataStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreEventDataStoreResponseUnmarshaller.Instance;

            return Invoke<RestoreEventDataStoreResponse>(request, options);
        }



        /// <summary>
        /// Restores a deleted event data store specified by <c>EventDataStore</c>, which accepts
        /// an event data store ARN. You can only restore a deleted event data store within the
        /// seven-day wait period after deletion. Restoring an event data store can take several
        /// minutes, depending on the size of the event data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreEventDataStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreMaxLimitExceededException">
        /// Your account has used the maximum number of event data stores.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/RestoreEventDataStore">REST API Reference for RestoreEventDataStore Operation</seealso>
        public virtual Task<RestoreEventDataStoreResponse> RestoreEventDataStoreAsync(RestoreEventDataStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreEventDataStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreEventDataStoreResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreEventDataStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchSampleQueries

        internal virtual SearchSampleQueriesResponse SearchSampleQueries(SearchSampleQueriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSampleQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSampleQueriesResponseUnmarshaller.Instance;

            return Invoke<SearchSampleQueriesResponse>(request, options);
        }



        /// <summary>
        /// Searches sample queries and returns a list of sample queries that are sorted by relevance.
        /// To search for sample queries, provide a natural language <c>SearchPhrase</c> in English.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSampleQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSampleQueries service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/SearchSampleQueries">REST API Reference for SearchSampleQueries Operation</seealso>
        public virtual Task<SearchSampleQueriesResponse> SearchSampleQueriesAsync(SearchSampleQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSampleQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSampleQueriesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchSampleQueriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDashboardRefresh

        internal virtual StartDashboardRefreshResponse StartDashboardRefresh(StartDashboardRefreshRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDashboardRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDashboardRefreshResponseUnmarshaller.Instance;

            return Invoke<StartDashboardRefreshResponse>(request, options);
        }



        /// <summary>
        /// Starts a refresh of the specified dashboard. 
        /// 
        ///  
        /// <para>
        ///  Each time a dashboard is refreshed, CloudTrail runs queries to populate the dashboard's
        /// widgets. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
        /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
        /// to attach a resource-based policy to each event data store. For more information,
        /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
        /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDashboardRefresh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDashboardRefresh service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ServiceQuotaExceededException">
        /// This exception is thrown when the quota is exceeded. For information about CloudTrail
        /// quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/ct.html#limits_cloudtrail">Service
        /// quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartDashboardRefresh">REST API Reference for StartDashboardRefresh Operation</seealso>
        public virtual Task<StartDashboardRefreshResponse> StartDashboardRefreshAsync(StartDashboardRefreshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDashboardRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDashboardRefreshResponseUnmarshaller.Instance;

            return InvokeAsync<StartDashboardRefreshResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartEventDataStoreIngestion

        internal virtual StartEventDataStoreIngestionResponse StartEventDataStoreIngestion(StartEventDataStoreIngestionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartEventDataStoreIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEventDataStoreIngestionResponseUnmarshaller.Instance;

            return Invoke<StartEventDataStoreIngestionResponse>(request, options);
        }



        /// <summary>
        /// Starts the ingestion of live events on an event data store specified as either an
        /// ARN or the ID portion of the ARN. To start ingestion, the event data store <c>Status</c>
        /// must be <c>STOPPED_INGESTION</c> and the <c>eventCategory</c> must be <c>Management</c>,
        /// <c>Data</c>, <c>NetworkActivity</c>, or <c>ConfigurationItem</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEventDataStoreIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEventDataStoreIngestion service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartEventDataStoreIngestion">REST API Reference for StartEventDataStoreIngestion Operation</seealso>
        public virtual Task<StartEventDataStoreIngestionResponse> StartEventDataStoreIngestionAsync(StartEventDataStoreIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartEventDataStoreIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEventDataStoreIngestionResponseUnmarshaller.Instance;

            return InvokeAsync<StartEventDataStoreIngestionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartImport

        internal virtual StartImportResponse StartImport(StartImportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportResponseUnmarshaller.Instance;

            return Invoke<StartImportResponse>(request, options);
        }



        /// <summary>
        /// Starts an import of logged trail events from a source S3 bucket to a destination
        /// event data store. By default, CloudTrail only imports events contained in the S3 bucket's
        /// <c>CloudTrail</c> prefix and the prefixes inside the <c>CloudTrail</c> prefix, and
        /// does not check prefixes for other Amazon Web Services services. If you want to import
        /// CloudTrail events contained in another prefix, you must include the prefix in the
        /// <c>S3LocationUri</c>. For more considerations about importing trail events, see <a
        /// href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-copy-trail-to-lake.html#cloudtrail-trail-copy-considerations">Considerations
        /// for copying trail events</a> in the <i>CloudTrail User Guide</i>. 
        /// 
        ///  
        /// <para>
        ///  When you start a new import, the <c>Destinations</c> and <c>ImportSource</c> parameters
        /// are required. Before starting a new import, disable any access control lists (ACLs)
        /// attached to the source S3 bucket. For more information about disabling ACLs, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Controlling
        /// ownership of objects and disabling ACLs for your bucket</a>. 
        /// </para>
        ///  
        /// <para>
        ///  When you retry an import, the <c>ImportID</c> parameter is required. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If the destination event data store is for an organization, you must use the management
        /// account to import trail events. You cannot use the delegated administrator account
        /// for the organization. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImport service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.AccountHasOngoingImportException">
        /// This exception is thrown when you start a new import and a previous import is still
        /// in progress.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ImportNotFoundException">
        /// The specified import was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidImportSourceException">
        /// This exception is thrown when the provided source S3 bucket is not valid for import.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartImport">REST API Reference for StartImport Operation</seealso>
        public virtual Task<StartImportResponse> StartImportAsync(StartImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportResponseUnmarshaller.Instance;

            return InvokeAsync<StartImportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartLogging

        internal virtual StartLoggingResponse StartLogging(StartLoggingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLoggingResponseUnmarshaller.Instance;

            return Invoke<StartLoggingResponse>(request, options);
        }



        /// <summary>
        /// Starts the recording of Amazon Web Services API calls and log file delivery for a
        /// trail. For a trail that is enabled in all Regions, this operation must be called from
        /// the Region in which the trail was created. This operation cannot be called on the
        /// shadow trails (replicated trails in other Regions) of a trail that is enabled in all
        /// Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartLogging">REST API Reference for StartLogging Operation</seealso>
        public virtual Task<StartLoggingResponse> StartLoggingAsync(StartLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<StartLoggingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartQuery

        internal virtual StartQueryResponse StartQuery(StartQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryResponseUnmarshaller.Instance;

            return Invoke<StartQueryResponse>(request, options);
        }



        /// <summary>
        /// Starts a CloudTrail Lake query. Use the <c>QueryStatement</c> parameter to provide
        /// your SQL query, enclosed in single quotation marks. Use the optional <c>DeliveryS3Uri</c>
        /// parameter to deliver the query results to an S3 bucket.
        /// 
        ///  
        /// <para>
        ///  <c>StartQuery</c> requires you specify either the <c>QueryStatement</c> parameter,
        /// or a <c>QueryAlias</c> and any <c>QueryParameters</c>. In the current release, the
        /// <c>QueryAlias</c> and <c>QueryParameters</c> parameters are used only for the queries
        /// that populate the CloudTrail Lake dashboards.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartQuery service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatementException">
        /// The query that was submitted has validation errors, or uses incorrect syntax or unsupported
        /// keywords. For more information about writing a query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3BucketNameException">
        /// This exception is thrown when the provided S3 bucket name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3PrefixException">
        /// This exception is thrown when the provided S3 prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.MaxConcurrentQueriesException">
        /// You are already running the maximum number of concurrent queries. The maximum number
        /// of concurrent queries is 10. Wait a minute for some queries to finish, and then run
        /// the query again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StartQuery">REST API Reference for StartQuery Operation</seealso>
        public virtual Task<StartQueryResponse> StartQueryAsync(StartQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryResponseUnmarshaller.Instance;

            return InvokeAsync<StartQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopEventDataStoreIngestion

        internal virtual StopEventDataStoreIngestionResponse StopEventDataStoreIngestion(StopEventDataStoreIngestionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopEventDataStoreIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEventDataStoreIngestionResponseUnmarshaller.Instance;

            return Invoke<StopEventDataStoreIngestionResponse>(request, options);
        }



        /// <summary>
        /// Stops the ingestion of live events on an event data store specified as either an ARN
        /// or the ID portion of the ARN. To stop ingestion, the event data store <c>Status</c>
        /// must be <c>ENABLED</c> and the <c>eventCategory</c> must be <c>Management</c>, <c>Data</c>,
        /// <c>NetworkActivity</c>, or <c>ConfigurationItem</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEventDataStoreIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEventDataStoreIngestion service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreStatusException">
        /// The event data store is not in a status that supports the operation.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopEventDataStoreIngestion">REST API Reference for StopEventDataStoreIngestion Operation</seealso>
        public virtual Task<StopEventDataStoreIngestionResponse> StopEventDataStoreIngestionAsync(StopEventDataStoreIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopEventDataStoreIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEventDataStoreIngestionResponseUnmarshaller.Instance;

            return InvokeAsync<StopEventDataStoreIngestionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopImport

        internal virtual StopImportResponse StopImport(StopImportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopImportResponseUnmarshaller.Instance;

            return Invoke<StopImportResponse>(request, options);
        }



        /// <summary>
        /// Stops a specified import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopImport service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ImportNotFoundException">
        /// The specified import was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopImport">REST API Reference for StopImport Operation</seealso>
        public virtual Task<StopImportResponse> StopImportAsync(StopImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopImportResponseUnmarshaller.Instance;

            return InvokeAsync<StopImportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopLogging

        internal virtual StopLoggingResponse StopLogging(StopLoggingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLoggingResponseUnmarshaller.Instance;

            return Invoke<StopLoggingResponse>(request, options);
        }



        /// <summary>
        /// Suspends the recording of Amazon Web Services API calls and log file delivery for
        /// the specified trail. Under most circumstances, there is no need to use this action.
        /// You can update a trail without stopping it first. This action is the only way to stop
        /// recording. For a trail enabled in all Regions, this operation must be called from
        /// the Region in which the trail was created, or an <c>InvalidHomeRegionException</c>
        /// will occur. This operation cannot be called on the shadow trails (replicated trails
        /// in other Regions) of a trail enabled in all Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopLogging service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/StopLogging">REST API Reference for StopLogging Operation</seealso>
        public virtual Task<StopLoggingResponse> StopLoggingAsync(StopLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<StopLoggingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateChannel

        internal virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }



        /// <summary>
        /// Updates a channel specified by a required channel ARN or UUID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelAlreadyExistsException">
        /// This exception is thrown when the provided channel already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelARNInvalidException">
        /// This exception is thrown when the specified value of <c>ChannelARN</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ChannelNotFoundException">
        /// This exception is thrown when CloudTrail cannot find the specified channel.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventDataStoreCategoryException">
        /// This exception is thrown when event categories of specified event data stores are
        /// not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDashboard

        internal virtual UpdateDashboardResponse UpdateDashboard(UpdateDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified dashboard. 
        /// 
        ///  
        /// <para>
        ///  To set a refresh schedule, CloudTrail must be granted permissions to run the <c>StartDashboardRefresh</c>
        /// operation to refresh the dashboard on your behalf. To provide permissions, run the
        /// <c>PutResourcePolicy</c> operation to attach a resource-based policy to the dashboard.
        /// For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-dashboards">
        /// Resource-based policy example for a dashboard</a> in the <i>CloudTrail User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  CloudTrail runs queries to populate the dashboard's widgets during a manual or scheduled
        /// refresh. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
        /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
        /// to attach a resource-based policy to each event data store. For more information,
        /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
        /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidQueryStatementException">
        /// The query that was submitted has validation errors, or uses incorrect syntax or unsupported
        /// keywords. For more information about writing a query, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-create-edit-query.html">Create
        /// or edit a query</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ResourceNotFoundException">
        /// This exception is thrown when the specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ServiceQuotaExceededException">
        /// This exception is thrown when the quota is exceeded. For information about CloudTrail
        /// quotas, see <a href="https://docs.aws.amazon.com/general/latest/gr/ct.html#limits_cloudtrail">Service
        /// quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual Task<UpdateDashboardResponse> UpdateDashboardAsync(UpdateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEventDataStore

        internal virtual UpdateEventDataStoreResponse UpdateEventDataStore(UpdateEventDataStoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventDataStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventDataStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateEventDataStoreResponse>(request, options);
        }



        /// <summary>
        /// Updates an event data store. The required <c>EventDataStore</c> value is an ARN or
        /// the ID portion of the ARN. Other parameters are optional, but at least one optional
        /// parameter must be specified, or CloudTrail throws an error. <c>RetentionPeriod</c>
        /// is in days, and valid values are integers between 7 and 3653 if the <c>BillingMode</c>
        /// is set to <c>EXTENDABLE_RETENTION_PRICING</c>, or between 7 and 2557 if <c>BillingMode</c>
        /// is set to <c>FIXED_RETENTION_PRICING</c>. By default, <c>TerminationProtection</c>
        /// is enabled.
        /// 
        ///  
        /// <para>
        /// For event data stores for CloudTrail events, <c>AdvancedEventSelectors</c> includes
        /// or excludes management, data, or network activity events in your event data store.
        /// For more information about <c>AdvancedEventSelectors</c>, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/APIReference/API_AdvancedEventSelector.html">AdvancedEventSelectors</a>.
        /// </para>
        ///  
        /// <para>
        ///  For event data stores for CloudTrail Insights events, Config configuration items,
        /// Audit Manager evidence, or non-Amazon Web Services events, <c>AdvancedEventSelectors</c>
        /// includes events of that type in your event data store.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventDataStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventDataStore service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreAlreadyExistsException">
        /// An event data store with that name already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreARNInvalidException">
        /// The specified event data store ARN is not valid or does not map to an event data store
        /// in your account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreHasOngoingImportException">
        /// This exception is thrown when you try to update or delete an event data store that
        /// currently has an import in progress.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.EventDataStoreNotFoundException">
        /// The specified event data store was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InactiveEventDataStoreException">
        /// The event data store is inactive.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
        /// 
        ///  
        /// <para>
        /// You can:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a valid number of event selectors (1 to 5) for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid number of data resources (1 to 250) for an event selector. The limit
        /// of number of resources on an individual event selector is configurable up to 250.
        /// However, this upper limit is allowed only if the total number of data resources does
        /// not exceed 250 across all event selectors for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidInsightSelectorsException">
        /// For <c>PutInsightSelectors</c>, this exception is thrown when the formatting or syntax
        /// of the <c>InsightSelectors</c> JSON statement is not valid, or the specified <c>InsightType</c>
        /// in the <c>InsightSelectors</c> statement is not valid. Valid values for <c>InsightType</c>
        /// are <c>ApiCallRateInsight</c> and <c>ApiErrorRateInsight</c>. To enable Insights on
        /// an event data store, the destination event data store specified by the <c>InsightsDestination</c>
        /// parameter must log Insights events and the source event data store specified by the
        /// <c>EventDataStore</c> parameter must log management events.
        /// 
        ///  
        /// <para>
        /// For <c>UpdateEventDataStore</c>, this exception is thrown if Insights are enabled
        /// on the event data store and the updated advanced event selectors are not compatible
        /// with the configured <c>InsightSelectors</c>. If the <c>InsightSelectors</c> includes
        /// an <c>InsightType</c> of <c>ApiCallRateInsight</c>, the source event data store must
        /// log <c>write</c> management events. If the <c>InsightSelectors</c> includes an <c>InsightType</c>
        /// of <c>ApiErrorRateInsight</c>, the source event data store must log management events.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateEventDataStore">REST API Reference for UpdateEventDataStore Operation</seealso>
        public virtual Task<UpdateEventDataStoreResponse> UpdateEventDataStoreAsync(UpdateEventDataStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventDataStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventDataStoreResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEventDataStoreResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTrail

        internal virtual UpdateTrailResponse UpdateTrail(UpdateTrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrailResponseUnmarshaller.Instance;

            return Invoke<UpdateTrailResponse>(request, options);
        }



        /// <summary>
        /// Updates trail settings that control what events you are logging, and how to handle
        /// log files. Changes to a trail do not require stopping the CloudTrail service. Use
        /// this action to designate an existing bucket for log delivery. If the existing bucket
        /// has previously been a target for CloudTrail log files, an IAM policy exists for the
        /// bucket. <c>UpdateTrail</c> must be called from the Region in which the trail was created;
        /// otherwise, an <c>InvalidHomeRegionException</c> is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrail service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailAccessNotEnabledException">
        /// This exception is thrown when trusted access has not been enabled between CloudTrail
        /// and Organizations. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_how-to-enable-disable-trusted-access">How
        /// to enable or disable trusted access</a> in the <i>Organizations User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> in the <i>CloudTrail User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailARNInvalidException">
        /// This exception is thrown when an operation is called with an ARN that is not valid.
        /// 
        ///  
        /// <para>
        /// The following is the format of a trail ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of an event data store ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a dashboard ARN: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is the format of a channel ARN: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudTrailInvalidClientTokenIdException">
        /// This exception is thrown when a call results in the <c>InvalidClientTokenId</c> error
        /// code. This can occur when you are creating or updating a trail to send notifications
        /// to an Amazon SNS topic that is in a suspended Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.CloudWatchLogsDeliveryUnavailableException">
        /// Cannot set a CloudWatch Logs delivery for this Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ConflictException">
        /// This exception is thrown when the specified resource is not ready for an operation.
        /// This can occur when you try to run an operation on a resource before CloudTrail has
        /// time to fully load the resource, or because another operation is modifying the resource.
        /// If this exception occurs, wait a few minutes, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientDependencyServiceAccessPermissionException">
        /// This exception is thrown when the IAM identity that is used to create the organization
        /// resource lacks one or more required permissions for creating an organization resource
        /// in a required service.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientEncryptionPolicyException">
        /// For the <c>CreateTrail</c> <c>PutInsightSelectors</c>, <c>UpdateTrail</c>, <c>StartQuery</c>,
        /// and <c>StartImport</c> operations, this exception is thrown when the policy on the
        /// S3 bucket or KMS key does not have sufficient permissions for the operation.
        /// 
        ///  
        /// <para>
        /// For all other operations, this exception is thrown when the policy for the KMS key
        /// does not have sufficient permissions for the operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientS3BucketPolicyException">
        /// This exception is thrown when the policy on the S3 bucket is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InsufficientSnsTopicPolicyException">
        /// This exception is thrown when the policy on the Amazon SNS topic is not sufficient.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsLogGroupArnException">
        /// This exception is thrown when the provided CloudWatch Logs log group is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidCloudWatchLogsRoleArnException">
        /// This exception is thrown when the provided role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidEventSelectorsException">
        /// This exception is thrown when the <c>PutEventSelectors</c> operation is called with
        /// a number of event selectors, advanced event selectors, or data resources that is not
        /// valid. The combination of event selectors or advanced event selectors and data resources
        /// is not valid. A trail can have up to 5 event selectors. If a trail uses advanced event
        /// selectors, a maximum of 500 total values for all conditions in all advanced event
        /// selectors is allowed. A trail is limited to 250 data resources. These data resources
        /// can be distributed across event selectors, but the overall total cannot exceed 250.
        /// 
        ///  
        /// <para>
        /// You can:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a valid number of event selectors (1 to 5) for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid number of data resources (1 to 250) for an event selector. The limit
        /// of number of resources on an individual event selector is configurable up to 250.
        /// However, this upper limit is allowed only if the total number of data resources does
        /// not exceed 250 across all event selectors for a trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify up to 500 values for all conditions in all advanced event selectors for a
        /// trail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify a valid value for a parameter. For example, specifying the <c>ReadWriteType</c>
        /// parameter with a value of <c>read-only</c> is not valid.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidHomeRegionException">
        /// This exception is thrown when an operation is called on a trail from a Region other
        /// than the Region in which the trail was created.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidKmsKeyIdException">
        /// This exception is thrown when the KMS key ARN is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterCombinationException">
        /// This exception is thrown when the combination of parameters provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidParameterException">
        /// The request includes a parameter that is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3BucketNameException">
        /// This exception is thrown when the provided S3 bucket name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidS3PrefixException">
        /// This exception is thrown when the provided S3 prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidSnsTopicNameException">
        /// This exception is thrown when the provided SNS topic name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.InvalidTrailNameException">
        /// This exception is thrown when the provided trail name is not valid. Trail names must
        /// meet the following requirements:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsException">
        /// This exception is thrown when there is an issue with the specified KMS key and the
        /// trail or event data store can't be updated.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyDisabledException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.KmsKeyNotFoundException">
        /// This exception is thrown when the KMS key does not exist, when the S3 bucket and the
        /// KMS key are not in the same Region, or when the KMS key associated with the Amazon
        /// SNS topic either does not exist or is not in the same Region.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NoManagementAccountSLRExistsException">
        /// This exception is thrown when the management account does not have a service-linked
        /// role.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.NotOrganizationMasterAccountException">
        /// This exception is thrown when the Amazon Web Services account making the request to
        /// create or update an organization trail or event data store is not the management account
        /// for an organization in Organizations. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/creating-an-organizational-trail-prepare.html">Prepare
        /// For Creating a Trail For Your Organization</a> or <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html">Organization
        /// event data stores</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationNotInAllFeaturesModeException">
        /// This exception is thrown when Organizations is not configured to support all features.
        /// All features must be enabled in Organizations to support creating an organization
        /// trail or event data store.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.OrganizationsNotInUseException">
        /// This exception is thrown when the request is made from an Amazon Web Services account
        /// that is not a member of an organization. To make this request, sign in using the credentials
        /// of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.S3BucketDoesNotExistException">
        /// This exception is thrown when the specified S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.ThrottlingException">
        /// This exception is thrown when the request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotFoundException">
        /// This exception is thrown when the trail with the given name is not found.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.TrailNotProvidedException">
        /// This exception is no longer in use.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudtrail-2013-11-01/UpdateTrail">REST API Reference for UpdateTrail Operation</seealso>
        public virtual Task<UpdateTrailResponse> UpdateTrailAsync(UpdateTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrailResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrailResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}