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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ControlCatalog.Model;
using Amazon.ControlCatalog.Model.Internal.MarshallTransformations;
using Amazon.ControlCatalog.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ControlCatalog
{
    /// <summary>
    /// <para>Implementation for accessing ControlCatalog</para>
    ///
    /// Welcome to the Control Catalog API reference. This guide is for developers who need
    /// detailed information about how to programmatically identify and filter the common
    /// controls and related metadata that are available to Amazon Web Services customers.
    /// This API reference provides descriptions, syntax, and usage examples for each of the
    /// actions and data types that are supported by Control Catalog. 
    /// 
    ///  
    /// <para>
    /// Use the following links to get started with the Control Catalog API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/API_Operations.html">Actions</a>:
    /// An alphabetical list of all Control Catalog API operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/API_Types.html">Data
    /// types</a>: An alphabetical list of all Control Catalog data types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/CommonParameters.html">Common
    /// parameters</a>: Parameters that all operations can use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/CommonErrors.html">Common
    /// errors</a>: Client and server errors that all operations can return.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonControlCatalogClient : AmazonServiceClient, IAmazonControlCatalog
    {
        private static IServiceMetadata serviceMetadata = new AmazonControlCatalogMetadata();
        private IControlCatalogPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IControlCatalogPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ControlCatalogPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonControlCatalogClient with the credentials loaded from the application's
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
        public AmazonControlCatalogClient()
            : base(new AmazonControlCatalogConfig()) { }

        /// <summary>
        /// Constructs AmazonControlCatalogClient with the credentials loaded from the application's
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
        public AmazonControlCatalogClient(RegionEndpoint region)
            : base(new AmazonControlCatalogConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonControlCatalogClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonControlCatalogClient Configuration Object</param>
        public AmazonControlCatalogClient(AmazonControlCatalogConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonControlCatalogClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonControlCatalogClient(AWSCredentials credentials)
            : this(credentials, new AmazonControlCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonControlCatalogClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonControlCatalogClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonControlCatalogConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonControlCatalogClient with AWS Credentials and an
        /// AmazonControlCatalogClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonControlCatalogClient Configuration Object</param>
        public AmazonControlCatalogClient(AWSCredentials credentials, AmazonControlCatalogConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonControlCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonControlCatalogClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonControlCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonControlCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonControlCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonControlCatalogConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonControlCatalogClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonControlCatalogClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonControlCatalogClient Configuration Object</param>
        public AmazonControlCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonControlCatalogConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonControlCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonControlCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonControlCatalogConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonControlCatalogClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonControlCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonControlCatalogConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonControlCatalogClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonControlCatalogClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonControlCatalogClient Configuration Object</param>
        public AmazonControlCatalogClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonControlCatalogConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonControlCatalogEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonControlCatalogAuthSchemeHandler());
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


        #region  GetControl


        /// <summary>
        /// Returns details about a specific control, most notably a list of Amazon Web Services
        /// Regions where this control is supported. Input a value for the <i>ControlArn</i> parameter,
        /// in ARN form. <c>GetControl</c> accepts <i>controltower</i> or <i>controlcatalog</i>
        /// control ARNs as input. Returns a <i>controlcatalog</i> ARN format.
        /// 
        ///  
        /// <para>
        /// In the API response, controls that have the value <c>GLOBAL</c> in the <c>Scope</c>
        /// field do not show the <c>DeployableRegions</c> field, because it does not apply. Controls
        /// that have the value <c>REGIONAL</c> in the <c>Scope</c> field return a value for the
        /// <c>DeployableRegions</c> field, as shown in the example.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControl service method.</param>
        /// 
        /// <returns>The response from the GetControl service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/GetControl">REST API Reference for GetControl Operation</seealso>
        public virtual GetControlResponse GetControl(GetControlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetControlResponseUnmarshaller.Instance;

            return Invoke<GetControlResponse>(request, options);
        }


        /// <summary>
        /// Returns details about a specific control, most notably a list of Amazon Web Services
        /// Regions where this control is supported. Input a value for the <i>ControlArn</i> parameter,
        /// in ARN form. <c>GetControl</c> accepts <i>controltower</i> or <i>controlcatalog</i>
        /// control ARNs as input. Returns a <i>controlcatalog</i> ARN format.
        /// 
        ///  
        /// <para>
        /// In the API response, controls that have the value <c>GLOBAL</c> in the <c>Scope</c>
        /// field do not show the <c>DeployableRegions</c> field, because it does not apply. Controls
        /// that have the value <c>REGIONAL</c> in the <c>Scope</c> field return a value for the
        /// <c>DeployableRegions</c> field, as shown in the example.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetControl service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/GetControl">REST API Reference for GetControl Operation</seealso>
        public virtual Task<GetControlResponse> GetControlAsync(GetControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetControlResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCommonControls


        /// <summary>
        /// Returns a paginated list of common controls from the Amazon Web Services Control Catalog.
        /// 
        ///  
        /// <para>
        /// You can apply an optional filter to see common controls that have a specific objective.
        /// If you don’t provide a filter, the operation returns all common controls. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommonControls service method.</param>
        /// 
        /// <returns>The response from the ListCommonControls service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListCommonControls">REST API Reference for ListCommonControls Operation</seealso>
        public virtual ListCommonControlsResponse ListCommonControls(ListCommonControlsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCommonControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommonControlsResponseUnmarshaller.Instance;

            return Invoke<ListCommonControlsResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of common controls from the Amazon Web Services Control Catalog.
        /// 
        ///  
        /// <para>
        /// You can apply an optional filter to see common controls that have a specific objective.
        /// If you don’t provide a filter, the operation returns all common controls. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommonControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommonControls service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListCommonControls">REST API Reference for ListCommonControls Operation</seealso>
        public virtual Task<ListCommonControlsResponse> ListCommonControlsAsync(ListCommonControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCommonControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommonControlsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCommonControlsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListControlMappings


        /// <summary>
        /// Returns a paginated list of control mappings from the Control Catalog. Control mappings
        /// show relationships between controls and other entities, such as common controls or
        /// compliance frameworks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlMappings service method.</param>
        /// 
        /// <returns>The response from the ListControlMappings service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListControlMappings">REST API Reference for ListControlMappings Operation</seealso>
        public virtual ListControlMappingsResponse ListControlMappings(ListControlMappingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListControlMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlMappingsResponseUnmarshaller.Instance;

            return Invoke<ListControlMappingsResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of control mappings from the Control Catalog. Control mappings
        /// show relationships between controls and other entities, such as common controls or
        /// compliance frameworks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListControlMappings service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListControlMappings">REST API Reference for ListControlMappings Operation</seealso>
        public virtual Task<ListControlMappingsResponse> ListControlMappingsAsync(ListControlMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListControlMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlMappingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListControlMappingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListControls


        /// <summary>
        /// Returns a paginated list of all available controls in the Control Catalog library.
        /// Allows you to discover available controls. The list of controls is given as structures
        /// of type <i>controlSummary</i>. The ARN is returned in the global <i>controlcatalog</i>
        /// format, as shown in the examples.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControls service method.</param>
        /// 
        /// <returns>The response from the ListControls service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListControls">REST API Reference for ListControls Operation</seealso>
        public virtual ListControlsResponse ListControls(ListControlsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlsResponseUnmarshaller.Instance;

            return Invoke<ListControlsResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of all available controls in the Control Catalog library.
        /// Allows you to discover available controls. The list of controls is given as structures
        /// of type <i>controlSummary</i>. The ARN is returned in the global <i>controlcatalog</i>
        /// format, as shown in the examples.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListControls service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListControls">REST API Reference for ListControls Operation</seealso>
        public virtual Task<ListControlsResponse> ListControlsAsync(ListControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListControlsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Returns a paginated list of domains from the Control Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of domains from the Control Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObjectives


        /// <summary>
        /// Returns a paginated list of objectives from the Control Catalog.
        /// 
        ///  
        /// <para>
        /// You can apply an optional filter to see the objectives that belong to a specific domain.
        /// If you don’t provide a filter, the operation returns all objectives. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectives service method.</param>
        /// 
        /// <returns>The response from the ListObjectives service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListObjectives">REST API Reference for ListObjectives Operation</seealso>
        public virtual ListObjectivesResponse ListObjectives(ListObjectivesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectivesResponseUnmarshaller.Instance;

            return Invoke<ListObjectivesResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of objectives from the Control Catalog.
        /// 
        ///  
        /// <para>
        /// You can apply an optional filter to see the objectives that belong to a specific domain.
        /// If you don’t provide a filter, the operation returns all objectives. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectives service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjectives service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListObjectives">REST API Reference for ListObjectives Operation</seealso>
        public virtual Task<ListObjectivesResponse> ListObjectivesAsync(ListObjectivesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListObjectivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectivesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListObjectivesResponse>(request, options, cancellationToken);
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