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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using Amazon.Inspector.Model;
using Amazon.Inspector.Model.Internal.MarshallTransformations;
using Amazon.Inspector.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.Inspector
{
    /// <summary>
    /// <para>Implementation for accessing Inspector</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Amazon Inspector 
    /// <para>
    /// Amazon Inspector enables you to analyze the behavior of your AWS resources and to
    /// identify potential security issues. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_introduction.html">
    /// Amazon Inspector User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonInspectorClient : AmazonServiceClient, IAmazonInspector
    {
        private static IServiceMetadata serviceMetadata = new AmazonInspectorMetadata();
        private IInspectorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IInspectorPaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new InspectorPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonInspectorClient with the credentials loaded from the application's
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
        public AmazonInspectorClient() : base(new AmazonInspectorConfig()) { }

        /// <summary>
        /// Constructs AmazonInspectorClient with the credentials loaded from the application's
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
        public AmazonInspectorClient(RegionEndpoint region) : base(new AmazonInspectorConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonInspectorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonInspectorClient Configuration Object</param>
        public AmazonInspectorClient(AmazonInspectorConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonInspectorClient(AWSCredentials credentials)
            : this(credentials, new AmazonInspectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspectorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonInspectorConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Credentials and an
        /// AmazonInspectorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonInspectorClient Configuration Object</param>
        public AmazonInspectorClient(AWSCredentials credentials, AmazonInspectorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInspectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInspectorConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInspectorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonInspectorClient Configuration Object</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonInspectorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInspectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInspectorConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInspectorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonInspectorClient Configuration Object</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonInspectorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonInspectorEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonInspectorAuthSchemeHandler());
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

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Assigns attributes (key and value pairs) to the findings that are specified by the
        /// ARNs of the findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings service method.</param>
        /// <returns>The response from the AddAttributesToFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/AddAttributesToFindings">REST API Reference for AddAttributesToFindings Operation</seealso>
        public virtual AddAttributesToFindingsResponse AddAttributesToFindings(AddAttributesToFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddAttributesToFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return Invoke<AddAttributesToFindingsResponse>(request, options);
        }
#else
        internal virtual AddAttributesToFindingsResponse AddAttributesToFindings(AddAttributesToFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddAttributesToFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return Invoke<AddAttributesToFindingsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Assigns attributes (key and value pairs) to the findings that are specified by the
        /// ARNs of the findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AddAttributesToFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/AddAttributesToFindings">REST API Reference for AddAttributesToFindings Operation</seealso>
        public virtual Task<AddAttributesToFindingsResponse> AddAttributesToFindingsAsync(AddAttributesToFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddAttributesToFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<AddAttributesToFindingsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new assessment target using the ARN of the resource group that is generated
        /// by <a>CreateResourceGroup</a>. If resourceGroupArn is not specified, all EC2 instances
        /// in the current AWS account and region are included in the assessment target. If the
        /// <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
        /// role</a> isn’t already registered, this action also creates and registers a service-linked
        /// role to grant Amazon Inspector access to AWS Services needed to perform security assessments.
        /// You can create up to 50 assessment targets per AWS account. You can run up to 500
        /// concurrent agents per AWS account. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">
        /// Amazon Inspector Assessment Targets</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTarget service method.</param>
        /// <returns>The response from the CreateAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTarget">REST API Reference for CreateAssessmentTarget Operation</seealso>
        public virtual CreateAssessmentTargetResponse CreateAssessmentTarget(CreateAssessmentTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTargetResponse>(request, options);
        }
#else
        internal virtual CreateAssessmentTargetResponse CreateAssessmentTarget(CreateAssessmentTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTargetResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new assessment target using the ARN of the resource group that is generated
        /// by <a>CreateResourceGroup</a>. If resourceGroupArn is not specified, all EC2 instances
        /// in the current AWS account and region are included in the assessment target. If the
        /// <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
        /// role</a> isn’t already registered, this action also creates and registers a service-linked
        /// role to grant Amazon Inspector access to AWS Services needed to perform security assessments.
        /// You can create up to 50 assessment targets per AWS account. You can run up to 500
        /// concurrent agents per AWS account. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">
        /// Amazon Inspector Assessment Targets</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTarget">REST API Reference for CreateAssessmentTarget Operation</seealso>
        public virtual Task<CreateAssessmentTargetResponse> CreateAssessmentTargetAsync(CreateAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentTargetResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an assessment template for the assessment target that is specified by the
        /// ARN of the assessment target. If the <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
        /// role</a> isn’t already registered, this action also creates and registers a service-linked
        /// role to grant Amazon Inspector access to AWS Services needed to perform security assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTemplate service method.</param>
        /// <returns>The response from the CreateAssessmentTemplate service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTemplate">REST API Reference for CreateAssessmentTemplate Operation</seealso>
        public virtual CreateAssessmentTemplateResponse CreateAssessmentTemplate(CreateAssessmentTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTemplateResponse>(request, options);
        }
#else
        internal virtual CreateAssessmentTemplateResponse CreateAssessmentTemplate(CreateAssessmentTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTemplateResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an assessment template for the assessment target that is specified by the
        /// ARN of the assessment target. If the <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
        /// role</a> isn’t already registered, this action also creates and registers a service-linked
        /// role to grant Amazon Inspector access to AWS Services needed to perform security assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAssessmentTemplate service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTemplate">REST API Reference for CreateAssessmentTemplate Operation</seealso>
        public virtual Task<CreateAssessmentTemplateResponse> CreateAssessmentTemplateAsync(CreateAssessmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentTemplateResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Starts the generation of an exclusions preview for the specified assessment template.
        /// The exclusions preview lists the potential exclusions (ExclusionPreview) that Inspector
        /// can detect before it runs the assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExclusionsPreview service method.</param>
        /// <returns>The response from the CreateExclusionsPreview service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.PreviewGenerationInProgressException">
        /// The request is rejected. The specified assessment template is currently generating
        /// an exclusions preview.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateExclusionsPreview">REST API Reference for CreateExclusionsPreview Operation</seealso>
        public virtual CreateExclusionsPreviewResponse CreateExclusionsPreview(CreateExclusionsPreviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExclusionsPreviewResponseUnmarshaller.Instance;

            return Invoke<CreateExclusionsPreviewResponse>(request, options);
        }
#else
        internal virtual CreateExclusionsPreviewResponse CreateExclusionsPreview(CreateExclusionsPreviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExclusionsPreviewResponseUnmarshaller.Instance;

            return Invoke<CreateExclusionsPreviewResponse>(request, options);
        }
#endif

        /// <summary>
        /// Starts the generation of an exclusions preview for the specified assessment template.
        /// The exclusions preview lists the potential exclusions (ExclusionPreview) that Inspector
        /// can detect before it runs the assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExclusionsPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateExclusionsPreview service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.PreviewGenerationInProgressException">
        /// The request is rejected. The specified assessment template is currently generating
        /// an exclusions preview.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateExclusionsPreview">REST API Reference for CreateExclusionsPreview Operation</seealso>
        public virtual Task<CreateExclusionsPreviewResponse> CreateExclusionsPreviewAsync(CreateExclusionsPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExclusionsPreviewResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExclusionsPreviewResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a resource group using the specified set of tags (key and value pairs) that
        /// are used to select the EC2 instances to be included in an Amazon Inspector assessment
        /// target. The created resource group is then used to create an Amazon Inspector assessment
        /// target. For more information, see <a>CreateAssessmentTarget</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup service method.</param>
        /// <returns>The response from the CreateResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateResourceGroup">REST API Reference for CreateResourceGroup Operation</seealso>
        public virtual CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return Invoke<CreateResourceGroupResponse>(request, options);
        }
#else
        internal virtual CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return Invoke<CreateResourceGroupResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a resource group using the specified set of tags (key and value pairs) that
        /// are used to select the EC2 instances to be included in an Amazon Inspector assessment
        /// target. The created resource group is then used to create an Amazon Inspector assessment
        /// target. For more information, see <a>CreateAssessmentTarget</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateResourceGroup">REST API Reference for CreateResourceGroup Operation</seealso>
        public virtual Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceGroupResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the assessment run that is specified by the ARN of the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentRun service method.</param>
        /// <returns>The response from the DeleteAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentRun">REST API Reference for DeleteAssessmentRun Operation</seealso>
        public virtual DeleteAssessmentRunResponse DeleteAssessmentRun(DeleteAssessmentRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentRunResponse>(request, options);
        }
#else
        internal virtual DeleteAssessmentRunResponse DeleteAssessmentRun(DeleteAssessmentRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentRunResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the assessment run that is specified by the ARN of the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentRun">REST API Reference for DeleteAssessmentRun Operation</seealso>
        public virtual Task<DeleteAssessmentRunResponse> DeleteAssessmentRunAsync(DeleteAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentRunResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the assessment target that is specified by the ARN of the assessment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTarget service method.</param>
        /// <returns>The response from the DeleteAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTarget">REST API Reference for DeleteAssessmentTarget Operation</seealso>
        public virtual DeleteAssessmentTargetResponse DeleteAssessmentTarget(DeleteAssessmentTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTargetResponse>(request, options);
        }
#else
        internal virtual DeleteAssessmentTargetResponse DeleteAssessmentTarget(DeleteAssessmentTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTargetResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the assessment target that is specified by the ARN of the assessment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTarget">REST API Reference for DeleteAssessmentTarget Operation</seealso>
        public virtual Task<DeleteAssessmentTargetResponse> DeleteAssessmentTargetAsync(DeleteAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentTargetResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the assessment template that is specified by the ARN of the assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTemplate service method.</param>
        /// <returns>The response from the DeleteAssessmentTemplate service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTemplate">REST API Reference for DeleteAssessmentTemplate Operation</seealso>
        public virtual DeleteAssessmentTemplateResponse DeleteAssessmentTemplate(DeleteAssessmentTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTemplateResponse>(request, options);
        }
#else
        internal virtual DeleteAssessmentTemplateResponse DeleteAssessmentTemplate(DeleteAssessmentTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTemplateResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the assessment template that is specified by the ARN of the assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAssessmentTemplate service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTemplate">REST API Reference for DeleteAssessmentTemplate Operation</seealso>
        public virtual Task<DeleteAssessmentTemplateResponse> DeleteAssessmentTemplateAsync(DeleteAssessmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentTemplateResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Describes the assessment runs that are specified by the ARNs of the assessment runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentRuns service method.</param>
        /// <returns>The response from the DescribeAssessmentRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentRuns">REST API Reference for DescribeAssessmentRuns Operation</seealso>
        public virtual DescribeAssessmentRunsResponse DescribeAssessmentRuns(DescribeAssessmentRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentRunsResponse>(request, options);
        }
#else
        internal virtual DescribeAssessmentRunsResponse DescribeAssessmentRuns(DescribeAssessmentRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentRunsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Describes the assessment runs that are specified by the ARNs of the assessment runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeAssessmentRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentRuns">REST API Reference for DescribeAssessmentRuns Operation</seealso>
        public virtual Task<DescribeAssessmentRunsResponse> DescribeAssessmentRunsAsync(DescribeAssessmentRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentRunsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentRunsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Describes the assessment targets that are specified by the ARNs of the assessment
        /// targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTargets service method.</param>
        /// <returns>The response from the DescribeAssessmentTargets service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTargets">REST API Reference for DescribeAssessmentTargets Operation</seealso>
        public virtual DescribeAssessmentTargetsResponse DescribeAssessmentTargets(DescribeAssessmentTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTargetsResponse>(request, options);
        }
#else
        internal virtual DescribeAssessmentTargetsResponse DescribeAssessmentTargets(DescribeAssessmentTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTargetsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Describes the assessment targets that are specified by the ARNs of the assessment
        /// targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeAssessmentTargets service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTargets">REST API Reference for DescribeAssessmentTargets Operation</seealso>
        public virtual Task<DescribeAssessmentTargetsResponse> DescribeAssessmentTargetsAsync(DescribeAssessmentTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentTargetsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Describes the assessment templates that are specified by the ARNs of the assessment
        /// templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTemplates service method.</param>
        /// <returns>The response from the DescribeAssessmentTemplates service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTemplates">REST API Reference for DescribeAssessmentTemplates Operation</seealso>
        public virtual DescribeAssessmentTemplatesResponse DescribeAssessmentTemplates(DescribeAssessmentTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTemplatesResponse>(request, options);
        }
#else
        internal virtual DescribeAssessmentTemplatesResponse DescribeAssessmentTemplates(DescribeAssessmentTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTemplatesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Describes the assessment templates that are specified by the ARNs of the assessment
        /// templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeAssessmentTemplates service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTemplates">REST API Reference for DescribeAssessmentTemplates Operation</seealso>
        public virtual Task<DescribeAssessmentTemplatesResponse> DescribeAssessmentTemplatesAsync(DescribeAssessmentTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentTemplatesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Describes the IAM role that enables Amazon Inspector to access your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole service method.</param>
        /// <returns>The response from the DescribeCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeCrossAccountAccessRole">REST API Reference for DescribeCrossAccountAccessRole Operation</seealso>
        public virtual DescribeCrossAccountAccessRoleResponse DescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<DescribeCrossAccountAccessRoleResponse>(request, options);
        }
#else
        internal virtual DescribeCrossAccountAccessRoleResponse DescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<DescribeCrossAccountAccessRoleResponse>(request, options);
        }
#endif

        /// <summary>
        /// Describes the IAM role that enables Amazon Inspector to access your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeCrossAccountAccessRole">REST API Reference for DescribeCrossAccountAccessRole Operation</seealso>
        public virtual Task<DescribeCrossAccountAccessRoleResponse> DescribeCrossAccountAccessRoleAsync(DescribeCrossAccountAccessRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCrossAccountAccessRoleResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Describes the exclusions that are specified by the exclusions' ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExclusions service method.</param>
        /// <returns>The response from the DescribeExclusions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeExclusions">REST API Reference for DescribeExclusions Operation</seealso>
        public virtual DescribeExclusionsResponse DescribeExclusions(DescribeExclusionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExclusionsResponseUnmarshaller.Instance;

            return Invoke<DescribeExclusionsResponse>(request, options);
        }
#else
        internal virtual DescribeExclusionsResponse DescribeExclusions(DescribeExclusionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExclusionsResponseUnmarshaller.Instance;

            return Invoke<DescribeExclusionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Describes the exclusions that are specified by the exclusions' ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExclusions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeExclusions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeExclusions">REST API Reference for DescribeExclusions Operation</seealso>
        public virtual Task<DescribeExclusionsResponse> DescribeExclusionsAsync(DescribeExclusionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExclusionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExclusionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Describes the findings that are specified by the ARNs of the findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFindings service method.</param>
        /// <returns>The response from the DescribeFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeFindings">REST API Reference for DescribeFindings Operation</seealso>
        public virtual DescribeFindingsResponse DescribeFindings(DescribeFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFindingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFindingsResponse>(request, options);
        }
#else
        internal virtual DescribeFindingsResponse DescribeFindings(DescribeFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFindingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFindingsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Describes the findings that are specified by the ARNs of the findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeFindings">REST API Reference for DescribeFindings Operation</seealso>
        public virtual Task<DescribeFindingsResponse> DescribeFindingsAsync(DescribeFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFindingsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Describes the resource groups that are specified by the ARNs of the resource groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroups service method.</param>
        /// <returns>The response from the DescribeResourceGroups service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeResourceGroups">REST API Reference for DescribeResourceGroups Operation</seealso>
        public virtual DescribeResourceGroupsResponse DescribeResourceGroups(DescribeResourceGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceGroupsResponse>(request, options);
        }
#else
        internal virtual DescribeResourceGroupsResponse DescribeResourceGroups(DescribeResourceGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceGroupsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Describes the resource groups that are specified by the ARNs of the resource groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeResourceGroups service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeResourceGroups">REST API Reference for DescribeResourceGroups Operation</seealso>
        public virtual Task<DescribeResourceGroupsResponse> DescribeResourceGroupsAsync(DescribeResourceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourceGroupsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Describes the rules packages that are specified by the ARNs of the rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackages service method.</param>
        /// <returns>The response from the DescribeRulesPackages service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeRulesPackages">REST API Reference for DescribeRulesPackages Operation</seealso>
        public virtual DescribeRulesPackagesResponse DescribeRulesPackages(DescribeRulesPackagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<DescribeRulesPackagesResponse>(request, options);
        }
#else
        internal virtual DescribeRulesPackagesResponse DescribeRulesPackages(DescribeRulesPackagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<DescribeRulesPackagesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Describes the rules packages that are specified by the ARNs of the rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeRulesPackages service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeRulesPackages">REST API Reference for DescribeRulesPackages Operation</seealso>
        public virtual Task<DescribeRulesPackagesResponse> DescribeRulesPackagesAsync(DescribeRulesPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRulesPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRulesPackagesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Produces an assessment report that includes detailed and comprehensive results of
        /// a specified assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReport service method.</param>
        /// <returns>The response from the GetAssessmentReport service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.UnsupportedFeatureException">
        /// Used by the <a>GetAssessmentReport</a> API. The request was rejected because you tried
        /// to generate a report for an assessment run that existed before reporting was supported
        /// in Amazon Inspector. You can only generate reports for assessment runs that took place
        /// or will take place after generating reports in Amazon Inspector became available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetAssessmentReport">REST API Reference for GetAssessmentReport Operation</seealso>
        public virtual GetAssessmentReportResponse GetAssessmentReport(GetAssessmentReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentReportResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentReportResponse>(request, options);
        }
#else
        internal virtual GetAssessmentReportResponse GetAssessmentReport(GetAssessmentReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentReportResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentReportResponse>(request, options);
        }
#endif

        /// <summary>
        /// Produces an assessment report that includes detailed and comprehensive results of
        /// a specified assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAssessmentReport service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AssessmentRunInProgressException">
        /// You cannot perform a specified action if an assessment run is currently in progress.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.UnsupportedFeatureException">
        /// Used by the <a>GetAssessmentReport</a> API. The request was rejected because you tried
        /// to generate a report for an assessment run that existed before reporting was supported
        /// in Amazon Inspector. You can only generate reports for assessment runs that took place
        /// or will take place after generating reports in Amazon Inspector became available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetAssessmentReport">REST API Reference for GetAssessmentReport Operation</seealso>
        public virtual Task<GetAssessmentReportResponse> GetAssessmentReportAsync(GetAssessmentReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssessmentReportResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the exclusions preview (a list of ExclusionPreview objects) specified by
        /// the preview token. You can obtain the preview token by running the CreateExclusionsPreview
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExclusionsPreview service method.</param>
        /// <returns>The response from the GetExclusionsPreview service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetExclusionsPreview">REST API Reference for GetExclusionsPreview Operation</seealso>
        public virtual GetExclusionsPreviewResponse GetExclusionsPreview(GetExclusionsPreviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExclusionsPreviewResponseUnmarshaller.Instance;

            return Invoke<GetExclusionsPreviewResponse>(request, options);
        }
#else
        internal virtual GetExclusionsPreviewResponse GetExclusionsPreview(GetExclusionsPreviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExclusionsPreviewResponseUnmarshaller.Instance;

            return Invoke<GetExclusionsPreviewResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves the exclusions preview (a list of ExclusionPreview objects) specified by
        /// the preview token. You can obtain the preview token by running the CreateExclusionsPreview
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExclusionsPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetExclusionsPreview service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetExclusionsPreview">REST API Reference for GetExclusionsPreview Operation</seealso>
        public virtual Task<GetExclusionsPreviewResponse> GetExclusionsPreviewAsync(GetExclusionsPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExclusionsPreviewResponseUnmarshaller.Instance;

            return InvokeAsync<GetExclusionsPreviewResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Information about the data that is collected for the specified assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryMetadata service method.</param>
        /// <returns>The response from the GetTelemetryMetadata service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetTelemetryMetadata">REST API Reference for GetTelemetryMetadata Operation</seealso>
        public virtual GetTelemetryMetadataResponse GetTelemetryMetadata(GetTelemetryMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryMetadataResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryMetadataResponse>(request, options);
        }
#else
        internal virtual GetTelemetryMetadataResponse GetTelemetryMetadata(GetTelemetryMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryMetadataResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryMetadataResponse>(request, options);
        }
#endif

        /// <summary>
        /// Information about the data that is collected for the specified assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetTelemetryMetadata service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetTelemetryMetadata">REST API Reference for GetTelemetryMetadata Operation</seealso>
        public virtual Task<GetTelemetryMetadataResponse> GetTelemetryMetadataAsync(GetTelemetryMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetTelemetryMetadataResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the agents of the assessment runs that are specified by the ARNs of the assessment
        /// runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRunAgents service method.</param>
        /// <returns>The response from the ListAssessmentRunAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRunAgents">REST API Reference for ListAssessmentRunAgents Operation</seealso>
        public virtual ListAssessmentRunAgentsResponse ListAssessmentRunAgents(ListAssessmentRunAgentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunAgentsResponse>(request, options);
        }
#else
        internal virtual ListAssessmentRunAgentsResponse ListAssessmentRunAgents(ListAssessmentRunAgentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunAgentsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the agents of the assessment runs that are specified by the ARNs of the assessment
        /// runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRunAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAssessmentRunAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRunAgents">REST API Reference for ListAssessmentRunAgents Operation</seealso>
        public virtual Task<ListAssessmentRunAgentsResponse> ListAssessmentRunAgentsAsync(ListAssessmentRunAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentRunAgentsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the assessment runs that correspond to the assessment templates that are specified
        /// by the ARNs of the assessment templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRuns service method.</param>
        /// <returns>The response from the ListAssessmentRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRuns">REST API Reference for ListAssessmentRuns Operation</seealso>
        public virtual ListAssessmentRunsResponse ListAssessmentRuns(ListAssessmentRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunsResponse>(request, options);
        }
#else
        internal virtual ListAssessmentRunsResponse ListAssessmentRuns(ListAssessmentRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the assessment runs that correspond to the assessment templates that are specified
        /// by the ARNs of the assessment templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAssessmentRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRuns">REST API Reference for ListAssessmentRuns Operation</seealso>
        public virtual Task<ListAssessmentRunsResponse> ListAssessmentRunsAsync(ListAssessmentRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentRunsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the ARNs of the assessment targets within this AWS account. For more information
        /// about assessment targets, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">Amazon
        /// Inspector Assessment Targets</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTargets service method.</param>
        /// <returns>The response from the ListAssessmentTargets service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTargets">REST API Reference for ListAssessmentTargets Operation</seealso>
        public virtual ListAssessmentTargetsResponse ListAssessmentTargets(ListAssessmentTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTargetsResponse>(request, options);
        }
#else
        internal virtual ListAssessmentTargetsResponse ListAssessmentTargets(ListAssessmentTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTargetsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the ARNs of the assessment targets within this AWS account. For more information
        /// about assessment targets, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">Amazon
        /// Inspector Assessment Targets</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAssessmentTargets service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTargets">REST API Reference for ListAssessmentTargets Operation</seealso>
        public virtual Task<ListAssessmentTargetsResponse> ListAssessmentTargetsAsync(ListAssessmentTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentTargetsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the assessment templates that correspond to the assessment targets that are
        /// specified by the ARNs of the assessment targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTemplates service method.</param>
        /// <returns>The response from the ListAssessmentTemplates service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTemplates">REST API Reference for ListAssessmentTemplates Operation</seealso>
        public virtual ListAssessmentTemplatesResponse ListAssessmentTemplates(ListAssessmentTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTemplatesResponse>(request, options);
        }
#else
        internal virtual ListAssessmentTemplatesResponse ListAssessmentTemplates(ListAssessmentTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTemplatesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the assessment templates that correspond to the assessment targets that are
        /// specified by the ARNs of the assessment targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAssessmentTemplates service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTemplates">REST API Reference for ListAssessmentTemplates Operation</seealso>
        public virtual Task<ListAssessmentTemplatesResponse> ListAssessmentTemplatesAsync(ListAssessmentTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentTemplatesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists all the event subscriptions for the assessment template that is specified by
        /// the ARN of the assessment template. For more information, see <a>SubscribeToEvent</a>
        /// and <a>UnsubscribeFromEvent</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSubscriptions service method.</param>
        /// <returns>The response from the ListEventSubscriptions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListEventSubscriptions">REST API Reference for ListEventSubscriptions Operation</seealso>
        public virtual ListEventSubscriptionsResponse ListEventSubscriptions(ListEventSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListEventSubscriptionsResponse>(request, options);
        }
#else
        internal virtual ListEventSubscriptionsResponse ListEventSubscriptions(ListEventSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListEventSubscriptionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists all the event subscriptions for the assessment template that is specified by
        /// the ARN of the assessment template. For more information, see <a>SubscribeToEvent</a>
        /// and <a>UnsubscribeFromEvent</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListEventSubscriptions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListEventSubscriptions">REST API Reference for ListEventSubscriptions Operation</seealso>
        public virtual Task<ListEventSubscriptionsResponse> ListEventSubscriptionsAsync(ListEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventSubscriptionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// List exclusions that are generated by the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExclusions service method.</param>
        /// <returns>The response from the ListExclusions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListExclusions">REST API Reference for ListExclusions Operation</seealso>
        public virtual ListExclusionsResponse ListExclusions(ListExclusionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExclusionsResponseUnmarshaller.Instance;

            return Invoke<ListExclusionsResponse>(request, options);
        }
#else
        internal virtual ListExclusionsResponse ListExclusions(ListExclusionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExclusionsResponseUnmarshaller.Instance;

            return Invoke<ListExclusionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// List exclusions that are generated by the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExclusions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListExclusions service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListExclusions">REST API Reference for ListExclusions Operation</seealso>
        public virtual Task<ListExclusionsResponse> ListExclusionsAsync(ListExclusionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExclusionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExclusionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists findings that are generated by the assessment runs that are specified by the
        /// ARNs of the assessment runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <returns>The response from the ListFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsResponse>(request, options);
        }
#else
        internal virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists findings that are generated by the assessment runs that are specified by the
        /// ARNs of the assessment runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFindingsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists all available Amazon Inspector rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages service method.</param>
        /// <returns>The response from the ListRulesPackages service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListRulesPackages">REST API Reference for ListRulesPackages Operation</seealso>
        public virtual ListRulesPackagesResponse ListRulesPackages(ListRulesPackagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<ListRulesPackagesResponse>(request, options);
        }
#else
        internal virtual ListRulesPackagesResponse ListRulesPackages(ListRulesPackagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<ListRulesPackagesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists all available Amazon Inspector rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRulesPackages service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListRulesPackages">REST API Reference for ListRulesPackages Operation</seealso>
        public virtual Task<ListRulesPackagesResponse> ListRulesPackagesAsync(ListRulesPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRulesPackagesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists all tags associated with an assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#else
        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists all tags associated with an assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Previews the agents installed on the EC2 instances that are part of the specified
        /// assessment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgents service method.</param>
        /// <returns>The response from the PreviewAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/PreviewAgents">REST API Reference for PreviewAgents Operation</seealso>
        public virtual PreviewAgentsResponse PreviewAgents(PreviewAgentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PreviewAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewAgentsResponseUnmarshaller.Instance;

            return Invoke<PreviewAgentsResponse>(request, options);
        }
#else
        internal virtual PreviewAgentsResponse PreviewAgents(PreviewAgentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PreviewAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewAgentsResponseUnmarshaller.Instance;

            return Invoke<PreviewAgentsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Previews the agents installed on the EC2 instances that are part of the specified
        /// assessment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PreviewAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/PreviewAgents">REST API Reference for PreviewAgents Operation</seealso>
        public virtual Task<PreviewAgentsResponse> PreviewAgentsAsync(PreviewAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PreviewAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<PreviewAgentsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Registers the IAM role that grants Amazon Inspector access to AWS Services needed
        /// to perform security assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole service method.</param>
        /// <returns>The response from the RegisterCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RegisterCrossAccountAccessRole">REST API Reference for RegisterCrossAccountAccessRole Operation</seealso>
        public virtual RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<RegisterCrossAccountAccessRoleResponse>(request, options);
        }
#else
        internal virtual RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<RegisterCrossAccountAccessRoleResponse>(request, options);
        }
#endif

        /// <summary>
        /// Registers the IAM role that grants Amazon Inspector access to AWS Services needed
        /// to perform security assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RegisterCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RegisterCrossAccountAccessRole">REST API Reference for RegisterCrossAccountAccessRole Operation</seealso>
        public virtual Task<RegisterCrossAccountAccessRoleResponse> RegisterCrossAccountAccessRoleAsync(RegisterCrossAccountAccessRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterCrossAccountAccessRoleResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Removes entire attributes (key and value pairs) from the findings that are specified
        /// by the ARNs of the findings where an attribute with the specified key exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings service method.</param>
        /// <returns>The response from the RemoveAttributesFromFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RemoveAttributesFromFindings">REST API Reference for RemoveAttributesFromFindings Operation</seealso>
        public virtual RemoveAttributesFromFindingsResponse RemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAttributesFromFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return Invoke<RemoveAttributesFromFindingsResponse>(request, options);
        }
#else
        internal virtual RemoveAttributesFromFindingsResponse RemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAttributesFromFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return Invoke<RemoveAttributesFromFindingsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Removes entire attributes (key and value pairs) from the findings that are specified
        /// by the ARNs of the findings where an attribute with the specified key exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RemoveAttributesFromFindings service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RemoveAttributesFromFindings">REST API Reference for RemoveAttributesFromFindings Operation</seealso>
        public virtual Task<RemoveAttributesFromFindingsResponse> RemoveAttributesFromFindingsAsync(RemoveAttributesFromFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAttributesFromFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAttributesFromFindingsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Sets tags (key and value pairs) to the assessment template that is specified by the
        /// ARN of the assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource service method.</param>
        /// <returns>The response from the SetTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SetTagsForResource">REST API Reference for SetTagsForResource Operation</seealso>
        public virtual SetTagsForResourceResponse SetTagsForResource(SetTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<SetTagsForResourceResponse>(request, options);
        }
#else
        internal virtual SetTagsForResourceResponse SetTagsForResource(SetTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<SetTagsForResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Sets tags (key and value pairs) to the assessment template that is specified by the
        /// ARN of the assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SetTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SetTagsForResource">REST API Reference for SetTagsForResource Operation</seealso>
        public virtual Task<SetTagsForResourceResponse> SetTagsForResourceAsync(SetTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<SetTagsForResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Starts the assessment run specified by the ARN of the assessment template. For this
        /// API to function properly, you must not exceed the limit of running up to 500 concurrent
        /// agents per AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentRun service method.</param>
        /// <returns>The response from the StartAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AgentsAlreadyRunningAssessmentException">
        /// You started an assessment run, but one of the instances is already participating in
        /// another assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StartAssessmentRun">REST API Reference for StartAssessmentRun Operation</seealso>
        public virtual StartAssessmentRunResponse StartAssessmentRun(StartAssessmentRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StartAssessmentRunResponse>(request, options);
        }
#else
        internal virtual StartAssessmentRunResponse StartAssessmentRun(StartAssessmentRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StartAssessmentRunResponse>(request, options);
        }
#endif

        /// <summary>
        /// Starts the assessment run specified by the ARN of the assessment template. For this
        /// API to function properly, you must not exceed the limit of running up to 500 concurrent
        /// agents per AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.AgentsAlreadyRunningAssessmentException">
        /// You started an assessment run, but one of the instances is already participating in
        /// another assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// Amazon Inspector cannot assume the cross-account role that it needs to list your EC2
        /// instances during the assessment run.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StartAssessmentRun">REST API Reference for StartAssessmentRun Operation</seealso>
        public virtual Task<StartAssessmentRunResponse> StartAssessmentRunAsync(StartAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartAssessmentRunResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Stops the assessment run that is specified by the ARN of the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAssessmentRun service method.</param>
        /// <returns>The response from the StopAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StopAssessmentRun">REST API Reference for StopAssessmentRun Operation</seealso>
        public virtual StopAssessmentRunResponse StopAssessmentRun(StopAssessmentRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StopAssessmentRunResponse>(request, options);
        }
#else
        internal virtual StopAssessmentRunResponse StopAssessmentRun(StopAssessmentRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StopAssessmentRunResponse>(request, options);
        }
#endif

        /// <summary>
        /// Stops the assessment run that is specified by the ARN of the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAssessmentRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopAssessmentRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StopAssessmentRun">REST API Reference for StopAssessmentRun Operation</seealso>
        public virtual Task<StopAssessmentRunResponse> StopAssessmentRunAsync(StopAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<StopAssessmentRunResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Enables the process of sending Amazon Simple Notification Service (SNS) notifications
        /// about a specified event to a specified SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToEvent service method.</param>
        /// <returns>The response from the SubscribeToEvent service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SubscribeToEvent">REST API Reference for SubscribeToEvent Operation</seealso>
        public virtual SubscribeToEventResponse SubscribeToEvent(SubscribeToEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubscribeToEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeToEventResponseUnmarshaller.Instance;

            return Invoke<SubscribeToEventResponse>(request, options);
        }
#else
        internal virtual SubscribeToEventResponse SubscribeToEvent(SubscribeToEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubscribeToEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeToEventResponseUnmarshaller.Instance;

            return Invoke<SubscribeToEventResponse>(request, options);
        }
#endif

        /// <summary>
        /// Enables the process of sending Amazon Simple Notification Service (SNS) notifications
        /// about a specified event to a specified SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SubscribeToEvent service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SubscribeToEvent">REST API Reference for SubscribeToEvent Operation</seealso>
        public virtual Task<SubscribeToEventResponse> SubscribeToEventAsync(SubscribeToEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubscribeToEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeToEventResponseUnmarshaller.Instance;

            return InvokeAsync<SubscribeToEventResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Disables the process of sending Amazon Simple Notification Service (SNS) notifications
        /// about a specified event to a specified SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromEvent service method.</param>
        /// <returns>The response from the UnsubscribeFromEvent service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UnsubscribeFromEvent">REST API Reference for UnsubscribeFromEvent Operation</seealso>
        public virtual UnsubscribeFromEventResponse UnsubscribeFromEvent(UnsubscribeFromEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnsubscribeFromEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeFromEventResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeFromEventResponse>(request, options);
        }
#else
        internal virtual UnsubscribeFromEventResponse UnsubscribeFromEvent(UnsubscribeFromEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnsubscribeFromEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeFromEventResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeFromEventResponse>(request, options);
        }
#endif

        /// <summary>
        /// Disables the process of sending Amazon Simple Notification Service (SNS) notifications
        /// about a specified event to a specified SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UnsubscribeFromEvent service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UnsubscribeFromEvent">REST API Reference for UnsubscribeFromEvent Operation</seealso>
        public virtual Task<UnsubscribeFromEventResponse> UnsubscribeFromEventAsync(UnsubscribeFromEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UnsubscribeFromEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeFromEventResponseUnmarshaller.Instance;

            return InvokeAsync<UnsubscribeFromEventResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the assessment target that is specified by the ARN of the assessment target.
        /// 
        ///  
        /// <para>
        /// If resourceGroupArn is not specified, all EC2 instances in the current AWS account
        /// and region are included in the assessment target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentTarget service method.</param>
        /// <returns>The response from the UpdateAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UpdateAssessmentTarget">REST API Reference for UpdateAssessmentTarget Operation</seealso>
        public virtual UpdateAssessmentTargetResponse UpdateAssessmentTarget(UpdateAssessmentTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentTargetResponse>(request, options);
        }
#else
        internal virtual UpdateAssessmentTargetResponse UpdateAssessmentTarget(UpdateAssessmentTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentTargetResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the assessment target that is specified by the ARN of the assessment target.
        /// 
        ///  
        /// <para>
        /// If resourceGroupArn is not specified, all EC2 instances in the current AWS account
        /// and region are included in the assessment target.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAssessmentTarget service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error code describes the entity.
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UpdateAssessmentTarget">REST API Reference for UpdateAssessmentTarget Operation</seealso>
        public virtual Task<UpdateAssessmentTargetResponse> UpdateAssessmentTargetAsync(UpdateAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssessmentTargetResponse>(request, options, cancellationToken);
        }

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
    }
}
