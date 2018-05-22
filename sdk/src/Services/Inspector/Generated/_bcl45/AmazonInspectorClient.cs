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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Inspector.Model;
using Amazon.Inspector.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Inspector
{
    /// <summary>
    /// Implementation for accessing Inspector
    ///
    /// Amazon Inspector 
    /// <para>
    /// Amazon Inspector enables you to analyze the behavior of your AWS resources and to
    /// identify potential security issues. For more information, see <a href="http://docs.aws.amazon.com/inspector/latest/userguide/inspector_introduction.html">
    /// Amazon Inspector User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonInspectorClient : AmazonServiceClient, IAmazonInspector
    {
        #region Constructors

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
        public AmazonInspectorClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonInspectorConfig()) { }

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
        public AmazonInspectorClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonInspectorConfig{RegionEndpoint = region}) { }

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
        public AmazonInspectorClient(AmazonInspectorConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            : this(credentials, new AmazonInspectorConfig{RegionEndpoint = region})
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
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInspectorConfig() {RegionEndpoint=region})
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInspectorConfig{RegionEndpoint = region})
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

        
        #region  AddAttributesToFindings


        /// <summary>
        /// Assigns attributes (key and value pairs) to the findings that are specified by the
        /// ARNs of the findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/AddAttributesToFindings">REST API Reference for AddAttributesToFindings Operation</seealso>
        public virtual AddAttributesToFindingsResponse AddAttributesToFindings(AddAttributesToFindingsRequest request)
        {
            var marshaller = AddAttributesToFindingsRequestMarshaller.Instance;
            var unmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return Invoke<AddAttributesToFindingsRequest,AddAttributesToFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddAttributesToFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/AddAttributesToFindings">REST API Reference for AddAttributesToFindings Operation</seealso>
        public virtual Task<AddAttributesToFindingsResponse> AddAttributesToFindingsAsync(AddAttributesToFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddAttributesToFindingsRequestMarshaller.Instance;
            var unmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<AddAttributesToFindingsRequest,AddAttributesToFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAssessmentTarget


        /// <summary>
        /// Creates a new assessment target using the ARN of the resource group that is generated
        /// by <a>CreateResourceGroup</a>. If the <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
        /// role</a> isn’t already registered, also creates and registers a service-linked role
        /// to grant Amazon Inspector access to AWS Services needed to perform security assessments.
        /// You can create up to 50 assessment targets per AWS account. You can run up to 500
        /// concurrent agents per AWS account. For more information, see <a href="http://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">
        /// Amazon Inspector Assessment Targets</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTarget service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTarget">REST API Reference for CreateAssessmentTarget Operation</seealso>
        public virtual CreateAssessmentTargetResponse CreateAssessmentTarget(CreateAssessmentTargetRequest request)
        {
            var marshaller = CreateAssessmentTargetRequestMarshaller.Instance;
            var unmarshaller = CreateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTargetRequest,CreateAssessmentTargetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTarget">REST API Reference for CreateAssessmentTarget Operation</seealso>
        public virtual Task<CreateAssessmentTargetResponse> CreateAssessmentTargetAsync(CreateAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAssessmentTargetRequestMarshaller.Instance;
            var unmarshaller = CreateAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentTargetRequest,CreateAssessmentTargetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAssessmentTemplate


        /// <summary>
        /// Creates an assessment template for the assessment target that is specified by the
        /// ARN of the assessment target. If the <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
        /// role</a> isn’t already registered, also creates and registers a service-linked role
        /// to grant Amazon Inspector access to AWS Services needed to perform security assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTemplate service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTemplate">REST API Reference for CreateAssessmentTemplate Operation</seealso>
        public virtual CreateAssessmentTemplateResponse CreateAssessmentTemplate(CreateAssessmentTemplateRequest request)
        {
            var marshaller = CreateAssessmentTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTemplateRequest,CreateAssessmentTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTemplate">REST API Reference for CreateAssessmentTemplate Operation</seealso>
        public virtual Task<CreateAssessmentTemplateResponse> CreateAssessmentTemplateAsync(CreateAssessmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAssessmentTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateAssessmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentTemplateRequest,CreateAssessmentTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceGroup


        /// <summary>
        /// Creates a resource group using the specified set of tags (key and value pairs) that
        /// are used to select the EC2 instances to be included in an Amazon Inspector assessment
        /// target. The created resource group is then used to create an Amazon Inspector assessment
        /// target. For more information, see <a>CreateAssessmentTarget</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateResourceGroup">REST API Reference for CreateResourceGroup Operation</seealso>
        public virtual CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request)
        {
            var marshaller = CreateResourceGroupRequestMarshaller.Instance;
            var unmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return Invoke<CreateResourceGroupRequest,CreateResourceGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateResourceGroup">REST API Reference for CreateResourceGroup Operation</seealso>
        public virtual Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateResourceGroupRequestMarshaller.Instance;
            var unmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceGroupRequest,CreateResourceGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessmentRun


        /// <summary>
        /// Deletes the assessment run that is specified by the ARN of the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentRun service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentRun">REST API Reference for DeleteAssessmentRun Operation</seealso>
        public virtual DeleteAssessmentRunResponse DeleteAssessmentRun(DeleteAssessmentRunRequest request)
        {
            var marshaller = DeleteAssessmentRunRequestMarshaller.Instance;
            var unmarshaller = DeleteAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentRunRequest,DeleteAssessmentRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentRun">REST API Reference for DeleteAssessmentRun Operation</seealso>
        public virtual Task<DeleteAssessmentRunResponse> DeleteAssessmentRunAsync(DeleteAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAssessmentRunRequestMarshaller.Instance;
            var unmarshaller = DeleteAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentRunRequest,DeleteAssessmentRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessmentTarget


        /// <summary>
        /// Deletes the assessment target that is specified by the ARN of the assessment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTarget service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTarget">REST API Reference for DeleteAssessmentTarget Operation</seealso>
        public virtual DeleteAssessmentTargetResponse DeleteAssessmentTarget(DeleteAssessmentTargetRequest request)
        {
            var marshaller = DeleteAssessmentTargetRequestMarshaller.Instance;
            var unmarshaller = DeleteAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTargetRequest,DeleteAssessmentTargetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTarget">REST API Reference for DeleteAssessmentTarget Operation</seealso>
        public virtual Task<DeleteAssessmentTargetResponse> DeleteAssessmentTargetAsync(DeleteAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAssessmentTargetRequestMarshaller.Instance;
            var unmarshaller = DeleteAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentTargetRequest,DeleteAssessmentTargetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessmentTemplate


        /// <summary>
        /// Deletes the assessment template that is specified by the ARN of the assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTemplate service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTemplate">REST API Reference for DeleteAssessmentTemplate Operation</seealso>
        public virtual DeleteAssessmentTemplateResponse DeleteAssessmentTemplate(DeleteAssessmentTemplateRequest request)
        {
            var marshaller = DeleteAssessmentTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTemplateRequest,DeleteAssessmentTemplateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTemplate">REST API Reference for DeleteAssessmentTemplate Operation</seealso>
        public virtual Task<DeleteAssessmentTemplateResponse> DeleteAssessmentTemplateAsync(DeleteAssessmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAssessmentTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteAssessmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentTemplateRequest,DeleteAssessmentTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssessmentRuns


        /// <summary>
        /// Describes the assessment runs that are specified by the ARNs of the assessment runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentRuns service method.</param>
        /// 
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
            var marshaller = DescribeAssessmentRunsRequestMarshaller.Instance;
            var unmarshaller = DescribeAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentRunsRequest,DescribeAssessmentRunsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessmentRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentRuns">REST API Reference for DescribeAssessmentRuns Operation</seealso>
        public virtual Task<DescribeAssessmentRunsResponse> DescribeAssessmentRunsAsync(DescribeAssessmentRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAssessmentRunsRequestMarshaller.Instance;
            var unmarshaller = DescribeAssessmentRunsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentRunsRequest,DescribeAssessmentRunsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssessmentTargets


        /// <summary>
        /// Describes the assessment targets that are specified by the ARNs of the assessment
        /// targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTargets service method.</param>
        /// 
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
            var marshaller = DescribeAssessmentTargetsRequestMarshaller.Instance;
            var unmarshaller = DescribeAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTargetsRequest,DescribeAssessmentTargetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessmentTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTargets">REST API Reference for DescribeAssessmentTargets Operation</seealso>
        public virtual Task<DescribeAssessmentTargetsResponse> DescribeAssessmentTargetsAsync(DescribeAssessmentTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAssessmentTargetsRequestMarshaller.Instance;
            var unmarshaller = DescribeAssessmentTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentTargetsRequest,DescribeAssessmentTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssessmentTemplates


        /// <summary>
        /// Describes the assessment templates that are specified by the ARNs of the assessment
        /// templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTemplates service method.</param>
        /// 
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
            var marshaller = DescribeAssessmentTemplatesRequestMarshaller.Instance;
            var unmarshaller = DescribeAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTemplatesRequest,DescribeAssessmentTemplatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessmentTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTemplates">REST API Reference for DescribeAssessmentTemplates Operation</seealso>
        public virtual Task<DescribeAssessmentTemplatesResponse> DescribeAssessmentTemplatesAsync(DescribeAssessmentTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAssessmentTemplatesRequestMarshaller.Instance;
            var unmarshaller = DescribeAssessmentTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentTemplatesRequest,DescribeAssessmentTemplatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCrossAccountAccessRole


        /// <summary>
        /// Describes the IAM role that enables Amazon Inspector to access your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole service method.</param>
        /// 
        /// <returns>The response from the DescribeCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeCrossAccountAccessRole">REST API Reference for DescribeCrossAccountAccessRole Operation</seealso>
        public virtual DescribeCrossAccountAccessRoleResponse DescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request)
        {
            var marshaller = DescribeCrossAccountAccessRoleRequestMarshaller.Instance;
            var unmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<DescribeCrossAccountAccessRoleRequest,DescribeCrossAccountAccessRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeCrossAccountAccessRole">REST API Reference for DescribeCrossAccountAccessRole Operation</seealso>
        public virtual Task<DescribeCrossAccountAccessRoleResponse> DescribeCrossAccountAccessRoleAsync(DescribeCrossAccountAccessRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeCrossAccountAccessRoleRequestMarshaller.Instance;
            var unmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCrossAccountAccessRoleRequest,DescribeCrossAccountAccessRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFindings


        /// <summary>
        /// Describes the findings that are specified by the ARNs of the findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFindings service method.</param>
        /// 
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
            var marshaller = DescribeFindingsRequestMarshaller.Instance;
            var unmarshaller = DescribeFindingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFindingsRequest,DescribeFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeFindings">REST API Reference for DescribeFindings Operation</seealso>
        public virtual Task<DescribeFindingsResponse> DescribeFindingsAsync(DescribeFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeFindingsRequestMarshaller.Instance;
            var unmarshaller = DescribeFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFindingsRequest,DescribeFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeResourceGroups


        /// <summary>
        /// Describes the resource groups that are specified by the ARNs of the resource groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroups service method.</param>
        /// 
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
            var marshaller = DescribeResourceGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeResourceGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceGroupsRequest,DescribeResourceGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeResourceGroups">REST API Reference for DescribeResourceGroups Operation</seealso>
        public virtual Task<DescribeResourceGroupsResponse> DescribeResourceGroupsAsync(DescribeResourceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeResourceGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeResourceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourceGroupsRequest,DescribeResourceGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRulesPackages


        /// <summary>
        /// Describes the rules packages that are specified by the ARNs of the rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackages service method.</param>
        /// 
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
            var marshaller = DescribeRulesPackagesRequestMarshaller.Instance;
            var unmarshaller = DescribeRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<DescribeRulesPackagesRequest,DescribeRulesPackagesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeRulesPackages">REST API Reference for DescribeRulesPackages Operation</seealso>
        public virtual Task<DescribeRulesPackagesResponse> DescribeRulesPackagesAsync(DescribeRulesPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRulesPackagesRequestMarshaller.Instance;
            var unmarshaller = DescribeRulesPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRulesPackagesRequest,DescribeRulesPackagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAssessmentReport


        /// <summary>
        /// Produces an assessment report that includes detailed and comprehensive results of
        /// a specified assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReport service method.</param>
        /// 
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
        /// <exception cref="Amazon.Inspector.Model.UnsupportedFeatureException">
        /// Used by the <a>GetAssessmentReport</a> API. The request was rejected because you tried
        /// to generate a report for an assessment run that existed before reporting was supported
        /// in Amazon Inspector. You can only generate reports for assessment runs that took place
        /// or will take place after generating reports in Amazon Inspector became available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetAssessmentReport">REST API Reference for GetAssessmentReport Operation</seealso>
        public virtual GetAssessmentReportResponse GetAssessmentReport(GetAssessmentReportRequest request)
        {
            var marshaller = GetAssessmentReportRequestMarshaller.Instance;
            var unmarshaller = GetAssessmentReportResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentReportRequest,GetAssessmentReportResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetAssessmentReport">REST API Reference for GetAssessmentReport Operation</seealso>
        public virtual Task<GetAssessmentReportResponse> GetAssessmentReportAsync(GetAssessmentReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAssessmentReportRequestMarshaller.Instance;
            var unmarshaller = GetAssessmentReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssessmentReportRequest,GetAssessmentReportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTelemetryMetadata


        /// <summary>
        /// Information about the data that is collected for the specified assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryMetadata service method.</param>
        /// 
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
            var marshaller = GetTelemetryMetadataRequestMarshaller.Instance;
            var unmarshaller = GetTelemetryMetadataResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryMetadataRequest,GetTelemetryMetadataResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetTelemetryMetadata">REST API Reference for GetTelemetryMetadata Operation</seealso>
        public virtual Task<GetTelemetryMetadataResponse> GetTelemetryMetadataAsync(GetTelemetryMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetTelemetryMetadataRequestMarshaller.Instance;
            var unmarshaller = GetTelemetryMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetTelemetryMetadataRequest,GetTelemetryMetadataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentRunAgents


        /// <summary>
        /// Lists the agents of the assessment runs that are specified by the ARNs of the assessment
        /// runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRunAgents service method.</param>
        /// 
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
            var marshaller = ListAssessmentRunAgentsRequestMarshaller.Instance;
            var unmarshaller = ListAssessmentRunAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunAgentsRequest,ListAssessmentRunAgentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentRunAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRunAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRunAgents">REST API Reference for ListAssessmentRunAgents Operation</seealso>
        public virtual Task<ListAssessmentRunAgentsResponse> ListAssessmentRunAgentsAsync(ListAssessmentRunAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAssessmentRunAgentsRequestMarshaller.Instance;
            var unmarshaller = ListAssessmentRunAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentRunAgentsRequest,ListAssessmentRunAgentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentRuns


        /// <summary>
        /// Lists the assessment runs that correspond to the assessment templates that are specified
        /// by the ARNs of the assessment templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRuns service method.</param>
        /// 
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
            var marshaller = ListAssessmentRunsRequestMarshaller.Instance;
            var unmarshaller = ListAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunsRequest,ListAssessmentRunsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRuns">REST API Reference for ListAssessmentRuns Operation</seealso>
        public virtual Task<ListAssessmentRunsResponse> ListAssessmentRunsAsync(ListAssessmentRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAssessmentRunsRequestMarshaller.Instance;
            var unmarshaller = ListAssessmentRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentRunsRequest,ListAssessmentRunsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentTargets


        /// <summary>
        /// Lists the ARNs of the assessment targets within this AWS account. For more information
        /// about assessment targets, see <a href="http://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">Amazon
        /// Inspector Assessment Targets</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTargets service method.</param>
        /// 
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
            var marshaller = ListAssessmentTargetsRequestMarshaller.Instance;
            var unmarshaller = ListAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTargetsRequest,ListAssessmentTargetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTargets">REST API Reference for ListAssessmentTargets Operation</seealso>
        public virtual Task<ListAssessmentTargetsResponse> ListAssessmentTargetsAsync(ListAssessmentTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAssessmentTargetsRequestMarshaller.Instance;
            var unmarshaller = ListAssessmentTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentTargetsRequest,ListAssessmentTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentTemplates


        /// <summary>
        /// Lists the assessment templates that correspond to the assessment targets that are
        /// specified by the ARNs of the assessment targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTemplates service method.</param>
        /// 
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
            var marshaller = ListAssessmentTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTemplatesRequest,ListAssessmentTemplatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTemplates">REST API Reference for ListAssessmentTemplates Operation</seealso>
        public virtual Task<ListAssessmentTemplatesResponse> ListAssessmentTemplatesAsync(ListAssessmentTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAssessmentTemplatesRequestMarshaller.Instance;
            var unmarshaller = ListAssessmentTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentTemplatesRequest,ListAssessmentTemplatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListEventSubscriptions


        /// <summary>
        /// Lists all the event subscriptions for the assessment template that is specified by
        /// the ARN of the assessment template. For more information, see <a>SubscribeToEvent</a>
        /// and <a>UnsubscribeFromEvent</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSubscriptions service method.</param>
        /// 
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
            var marshaller = ListEventSubscriptionsRequestMarshaller.Instance;
            var unmarshaller = ListEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListEventSubscriptionsRequest,ListEventSubscriptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListEventSubscriptions">REST API Reference for ListEventSubscriptions Operation</seealso>
        public virtual Task<ListEventSubscriptionsResponse> ListEventSubscriptionsAsync(ListEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListEventSubscriptionsRequestMarshaller.Instance;
            var unmarshaller = ListEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventSubscriptionsRequest,ListEventSubscriptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Lists findings that are generated by the assessment runs that are specified by the
        /// ARNs of the assessment runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
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
            var marshaller = ListFindingsRequestMarshaller.Instance;
            var unmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsRequest,ListFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListFindingsRequestMarshaller.Instance;
            var unmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFindingsRequest,ListFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRulesPackages


        /// <summary>
        /// Lists all available Amazon Inspector rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages service method.</param>
        /// 
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
            var marshaller = ListRulesPackagesRequestMarshaller.Instance;
            var unmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<ListRulesPackagesRequest,ListRulesPackagesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListRulesPackages">REST API Reference for ListRulesPackages Operation</seealso>
        public virtual Task<ListRulesPackagesResponse> ListRulesPackagesAsync(ListRulesPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRulesPackagesRequestMarshaller.Instance;
            var unmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRulesPackagesRequest,ListRulesPackagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with an assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
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
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PreviewAgents


        /// <summary>
        /// Previews the agents installed on the EC2 instances that are part of the specified
        /// assessment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgents service method.</param>
        /// 
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
            var marshaller = PreviewAgentsRequestMarshaller.Instance;
            var unmarshaller = PreviewAgentsResponseUnmarshaller.Instance;

            return Invoke<PreviewAgentsRequest,PreviewAgentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PreviewAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/PreviewAgents">REST API Reference for PreviewAgents Operation</seealso>
        public virtual Task<PreviewAgentsResponse> PreviewAgentsAsync(PreviewAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PreviewAgentsRequestMarshaller.Instance;
            var unmarshaller = PreviewAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<PreviewAgentsRequest,PreviewAgentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterCrossAccountAccessRole


        /// <summary>
        /// Registers the IAM role that grants Amazon Inspector access to AWS Services needed
        /// to perform security assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RegisterCrossAccountAccessRole">REST API Reference for RegisterCrossAccountAccessRole Operation</seealso>
        public virtual RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request)
        {
            var marshaller = RegisterCrossAccountAccessRoleRequestMarshaller.Instance;
            var unmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<RegisterCrossAccountAccessRoleRequest,RegisterCrossAccountAccessRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RegisterCrossAccountAccessRole">REST API Reference for RegisterCrossAccountAccessRole Operation</seealso>
        public virtual Task<RegisterCrossAccountAccessRoleResponse> RegisterCrossAccountAccessRoleAsync(RegisterCrossAccountAccessRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterCrossAccountAccessRoleRequestMarshaller.Instance;
            var unmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterCrossAccountAccessRoleRequest,RegisterCrossAccountAccessRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveAttributesFromFindings


        /// <summary>
        /// Removes entire attributes (key and value pairs) from the findings that are specified
        /// by the ARNs of the findings where an attribute with the specified key exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RemoveAttributesFromFindings">REST API Reference for RemoveAttributesFromFindings Operation</seealso>
        public virtual RemoveAttributesFromFindingsResponse RemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request)
        {
            var marshaller = RemoveAttributesFromFindingsRequestMarshaller.Instance;
            var unmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return Invoke<RemoveAttributesFromFindingsRequest,RemoveAttributesFromFindingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAttributesFromFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RemoveAttributesFromFindings">REST API Reference for RemoveAttributesFromFindings Operation</seealso>
        public virtual Task<RemoveAttributesFromFindingsResponse> RemoveAttributesFromFindingsAsync(RemoveAttributesFromFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveAttributesFromFindingsRequestMarshaller.Instance;
            var unmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAttributesFromFindingsRequest,RemoveAttributesFromFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetTagsForResource


        /// <summary>
        /// Sets tags (key and value pairs) to the assessment template that is specified by the
        /// ARN of the assessment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SetTagsForResource">REST API Reference for SetTagsForResource Operation</seealso>
        public virtual SetTagsForResourceResponse SetTagsForResource(SetTagsForResourceRequest request)
        {
            var marshaller = SetTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<SetTagsForResourceRequest,SetTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SetTagsForResource">REST API Reference for SetTagsForResource Operation</seealso>
        public virtual Task<SetTagsForResourceResponse> SetTagsForResourceAsync(SetTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<SetTagsForResourceRequest,SetTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartAssessmentRun


        /// <summary>
        /// Starts the assessment run specified by the ARN of the assessment template. For this
        /// API to function properly, you must not exceed the limit of running up to 500 concurrent
        /// agents per AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentRun service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StartAssessmentRun">REST API Reference for StartAssessmentRun Operation</seealso>
        public virtual StartAssessmentRunResponse StartAssessmentRun(StartAssessmentRunRequest request)
        {
            var marshaller = StartAssessmentRunRequestMarshaller.Instance;
            var unmarshaller = StartAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StartAssessmentRunRequest,StartAssessmentRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StartAssessmentRun">REST API Reference for StartAssessmentRun Operation</seealso>
        public virtual Task<StartAssessmentRunResponse> StartAssessmentRunAsync(StartAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartAssessmentRunRequestMarshaller.Instance;
            var unmarshaller = StartAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartAssessmentRunRequest,StartAssessmentRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopAssessmentRun


        /// <summary>
        /// Stops the assessment run that is specified by the ARN of the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAssessmentRun service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StopAssessmentRun">REST API Reference for StopAssessmentRun Operation</seealso>
        public virtual StopAssessmentRunResponse StopAssessmentRun(StopAssessmentRunRequest request)
        {
            var marshaller = StopAssessmentRunRequestMarshaller.Instance;
            var unmarshaller = StopAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StopAssessmentRunRequest,StopAssessmentRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAssessmentRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StopAssessmentRun">REST API Reference for StopAssessmentRun Operation</seealso>
        public virtual Task<StopAssessmentRunResponse> StopAssessmentRunAsync(StopAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopAssessmentRunRequestMarshaller.Instance;
            var unmarshaller = StopAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<StopAssessmentRunRequest,StopAssessmentRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SubscribeToEvent


        /// <summary>
        /// Enables the process of sending Amazon Simple Notification Service (SNS) notifications
        /// about a specified event to a specified SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToEvent service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SubscribeToEvent">REST API Reference for SubscribeToEvent Operation</seealso>
        public virtual SubscribeToEventResponse SubscribeToEvent(SubscribeToEventRequest request)
        {
            var marshaller = SubscribeToEventRequestMarshaller.Instance;
            var unmarshaller = SubscribeToEventResponseUnmarshaller.Instance;

            return Invoke<SubscribeToEventRequest,SubscribeToEventResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SubscribeToEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToEvent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SubscribeToEvent">REST API Reference for SubscribeToEvent Operation</seealso>
        public virtual Task<SubscribeToEventResponse> SubscribeToEventAsync(SubscribeToEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SubscribeToEventRequestMarshaller.Instance;
            var unmarshaller = SubscribeToEventResponseUnmarshaller.Instance;

            return InvokeAsync<SubscribeToEventRequest,SubscribeToEventResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnsubscribeFromEvent


        /// <summary>
        /// Disables the process of sending Amazon Simple Notification Service (SNS) notifications
        /// about a specified event to a specified SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromEvent service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UnsubscribeFromEvent">REST API Reference for UnsubscribeFromEvent Operation</seealso>
        public virtual UnsubscribeFromEventResponse UnsubscribeFromEvent(UnsubscribeFromEventRequest request)
        {
            var marshaller = UnsubscribeFromEventRequestMarshaller.Instance;
            var unmarshaller = UnsubscribeFromEventResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeFromEventRequest,UnsubscribeFromEventResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnsubscribeFromEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromEvent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UnsubscribeFromEvent">REST API Reference for UnsubscribeFromEvent Operation</seealso>
        public virtual Task<UnsubscribeFromEventResponse> UnsubscribeFromEventAsync(UnsubscribeFromEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UnsubscribeFromEventRequestMarshaller.Instance;
            var unmarshaller = UnsubscribeFromEventResponseUnmarshaller.Instance;

            return InvokeAsync<UnsubscribeFromEventRequest,UnsubscribeFromEventResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssessmentTarget


        /// <summary>
        /// Updates the assessment target that is specified by the ARN of the assessment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentTarget service method.</param>
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UpdateAssessmentTarget">REST API Reference for UpdateAssessmentTarget Operation</seealso>
        public virtual UpdateAssessmentTargetResponse UpdateAssessmentTarget(UpdateAssessmentTargetRequest request)
        {
            var marshaller = UpdateAssessmentTargetRequestMarshaller.Instance;
            var unmarshaller = UpdateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentTargetRequest,UpdateAssessmentTargetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UpdateAssessmentTarget">REST API Reference for UpdateAssessmentTarget Operation</seealso>
        public virtual Task<UpdateAssessmentTargetResponse> UpdateAssessmentTargetAsync(UpdateAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAssessmentTargetRequestMarshaller.Instance;
            var unmarshaller = UpdateAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssessmentTargetRequest,UpdateAssessmentTargetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}