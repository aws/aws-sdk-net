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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CostAndUsageReport.Model;
using Amazon.CostAndUsageReport.Model.Internal.MarshallTransformations;
using Amazon.CostAndUsageReport.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CostAndUsageReport
{
    /// <summary>
    /// <para>Implementation for accessing CostAndUsageReport</para>
    ///
    /// You can use the Amazon Web Services Cost and Usage Report API to programmatically
    /// create, query, and delete Amazon Web Services Cost and Usage Report definitions.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Cost and Usage Report track the monthly Amazon Web Services costs
    /// and usage associated with your Amazon Web Services account. The report contains line
    /// items for each unique combination of Amazon Web Services product, usage type, and
    /// operation that your Amazon Web Services account uses. You can configure the Amazon
    /// Web Services Cost and Usage Report to show only the data that you want, using the
    /// Amazon Web Services Cost and Usage Report API.
    /// </para>
    ///  
    /// <para>
    /// Service Endpoint
    /// </para>
    ///  
    /// <para>
    /// The Amazon Web Services Cost and Usage Report API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// cur.us-east-1.amazonaws.com
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCostAndUsageReportClient : AmazonServiceClient, IAmazonCostAndUsageReport
    {
        private static IServiceMetadata serviceMetadata = new AmazonCostAndUsageReportMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with the credentials loaded from the application's
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
        public AmazonCostAndUsageReportClient()
            : base(new AmazonCostAndUsageReportConfig()) { }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with the credentials loaded from the application's
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
        public AmazonCostAndUsageReportClient(RegionEndpoint region)
            : base(new AmazonCostAndUsageReportConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCostAndUsageReportClient Configuration Object</param>
        public AmazonCostAndUsageReportClient(AmazonCostAndUsageReportConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCostAndUsageReportClient(AWSCredentials credentials)
            : this(credentials, new AmazonCostAndUsageReportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostAndUsageReportClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCostAndUsageReportConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Credentials and an
        /// AmazonCostAndUsageReportClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCostAndUsageReportClient Configuration Object</param>
        public AmazonCostAndUsageReportClient(AWSCredentials credentials, AmazonCostAndUsageReportConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCostAndUsageReportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCostAndUsageReportConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCostAndUsageReportClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCostAndUsageReportClient Configuration Object</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCostAndUsageReportConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCostAndUsageReportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCostAndUsageReportConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCostAndUsageReportClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCostAndUsageReportClient Configuration Object</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCostAndUsageReportConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICostAndUsageReportPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICostAndUsageReportPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CostAndUsageReportPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCostAndUsageReportEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCostAndUsageReportAuthSchemeHandler());
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


        #region  DeleteReportDefinition

        internal virtual DeleteReportDefinitionResponse DeleteReportDefinition(DeleteReportDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteReportDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified report. Any tags associated with the report are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        public virtual Task<DeleteReportDefinitionResponse> DeleteReportDefinitionAsync(DeleteReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReportDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeReportDefinitions

        internal virtual DescribeReportDefinitionsResponse DescribeReportDefinitions(DescribeReportDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReportDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportDefinitionsResponseUnmarshaller.Instance;

            return Invoke<DescribeReportDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the Amazon Web Services Cost and Usage Report available to this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReportDefinitions service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DescribeReportDefinitions">REST API Reference for DescribeReportDefinitions Operation</seealso>
        public virtual Task<DescribeReportDefinitionsResponse> DescribeReportDefinitionsAsync(DescribeReportDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReportDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReportDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags associated with the specified report definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ResourceNotFoundException">
        /// The specified report (<c>ReportName</c>) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyReportDefinition

        internal virtual ModifyReportDefinitionResponse ModifyReportDefinition(ModifyReportDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<ModifyReportDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Allows you to programmatically update your report preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/ModifyReportDefinition">REST API Reference for ModifyReportDefinition Operation</seealso>
        public virtual Task<ModifyReportDefinitionResponse> ModifyReportDefinitionAsync(ModifyReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReportDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutReportDefinition

        internal virtual PutReportDefinitionResponse PutReportDefinition(PutReportDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<PutReportDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new report using the description that you provide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.DuplicateReportNameException">
        /// A report with the specified name already exists in the account. Specify a different
        /// report name.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ReportLimitReachedException">
        /// This account already has five reports defined. To define a new report, you must delete
        /// an existing report.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ResourceNotFoundException">
        /// The specified report (<c>ReportName</c>) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        public virtual Task<PutReportDefinitionResponse> PutReportDefinitionAsync(PutReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<PutReportDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Associates a set of tags with a report definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ResourceNotFoundException">
        /// The specified report (<c>ReportName</c>) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a set of tags from a report definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ResourceNotFoundException">
        /// The specified report (<c>ReportName</c>) in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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