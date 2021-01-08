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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Inspector.Model;
using Amazon.Inspector.Model.Internal.MarshallTransformations;
using Amazon.Inspector.Internal;
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
    /// identify potential security issues. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_introduction.html">
    /// Amazon Inspector User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonInspectorClient : AmazonServiceClient, IAmazonInspector
    {
        private static IServiceMetadata serviceMetadata = new AmazonInspectorMetadata();

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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/AddAttributesToFindings">REST API Reference for AddAttributesToFindings Operation</seealso>
        public virtual AddAttributesToFindingsResponse AddAttributesToFindings(AddAttributesToFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddAttributesToFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return Invoke<AddAttributesToFindingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddAttributesToFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddAttributesToFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/AddAttributesToFindings">REST API Reference for AddAttributesToFindings Operation</seealso>
        public virtual IAsyncResult BeginAddAttributesToFindings(AddAttributesToFindingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddAttributesToFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddAttributesToFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddAttributesToFindings.</param>
        /// 
        /// <returns>Returns a  AddAttributesToFindingsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/AddAttributesToFindings">REST API Reference for AddAttributesToFindings Operation</seealso>
        public virtual AddAttributesToFindingsResponse EndAddAttributesToFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<AddAttributesToFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssessmentTarget

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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTarget">REST API Reference for CreateAssessmentTarget Operation</seealso>
        public virtual CreateAssessmentTargetResponse CreateAssessmentTarget(CreateAssessmentTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTarget operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssessmentTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTarget">REST API Reference for CreateAssessmentTarget Operation</seealso>
        public virtual IAsyncResult BeginCreateAssessmentTarget(CreateAssessmentTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssessmentTarget.</param>
        /// 
        /// <returns>Returns a  CreateAssessmentTargetResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTarget">REST API Reference for CreateAssessmentTarget Operation</seealso>
        public virtual CreateAssessmentTargetResponse EndCreateAssessmentTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssessmentTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssessmentTemplate

        /// <summary>
        /// Creates an assessment template for the assessment target that is specified by the
        /// ARN of the assessment target. If the <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
        /// role</a> isn’t already registered, this action also creates and registers a service-linked
        /// role to grant Amazon Inspector access to AWS Services needed to perform security assessments.
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTemplate">REST API Reference for CreateAssessmentTemplate Operation</seealso>
        public virtual CreateAssessmentTemplateResponse CreateAssessmentTemplate(CreateAssessmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTemplate operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssessmentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTemplate">REST API Reference for CreateAssessmentTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateAssessmentTemplate(CreateAssessmentTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssessmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssessmentTemplate.</param>
        /// 
        /// <returns>Returns a  CreateAssessmentTemplateResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTemplate">REST API Reference for CreateAssessmentTemplate Operation</seealso>
        public virtual CreateAssessmentTemplateResponse EndCreateAssessmentTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssessmentTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateExclusionsPreview

        /// <summary>
        /// Starts the generation of an exclusions preview for the specified assessment template.
        /// The exclusions preview lists the potential exclusions (ExclusionPreview) that Inspector
        /// can detect before it runs the assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExclusionsPreview service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExclusionsPreviewResponseUnmarshaller.Instance;

            return Invoke<CreateExclusionsPreviewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExclusionsPreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExclusionsPreview operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExclusionsPreview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateExclusionsPreview">REST API Reference for CreateExclusionsPreview Operation</seealso>
        public virtual IAsyncResult BeginCreateExclusionsPreview(CreateExclusionsPreviewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExclusionsPreviewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExclusionsPreview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExclusionsPreview.</param>
        /// 
        /// <returns>Returns a  CreateExclusionsPreviewResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateExclusionsPreview">REST API Reference for CreateExclusionsPreview Operation</seealso>
        public virtual CreateExclusionsPreviewResponse EndCreateExclusionsPreview(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateExclusionsPreviewResponse>(asyncResult);
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateResourceGroup">REST API Reference for CreateResourceGroup Operation</seealso>
        public virtual CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return Invoke<CreateResourceGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateResourceGroup">REST API Reference for CreateResourceGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateResourceGroup(CreateResourceGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceGroup.</param>
        /// 
        /// <returns>Returns a  CreateResourceGroupResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateResourceGroup">REST API Reference for CreateResourceGroup Operation</seealso>
        public virtual CreateResourceGroupResponse EndCreateResourceGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceGroupResponse>(asyncResult);
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentRun">REST API Reference for DeleteAssessmentRun Operation</seealso>
        public virtual DeleteAssessmentRunResponse DeleteAssessmentRun(DeleteAssessmentRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentRun operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessmentRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentRun">REST API Reference for DeleteAssessmentRun Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssessmentRun(DeleteAssessmentRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessmentRun.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentRunResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentRun">REST API Reference for DeleteAssessmentRun Operation</seealso>
        public virtual DeleteAssessmentRunResponse EndDeleteAssessmentRun(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssessmentRunResponse>(asyncResult);
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTarget">REST API Reference for DeleteAssessmentTarget Operation</seealso>
        public virtual DeleteAssessmentTargetResponse DeleteAssessmentTarget(DeleteAssessmentTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTarget operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessmentTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTarget">REST API Reference for DeleteAssessmentTarget Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssessmentTarget(DeleteAssessmentTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessmentTarget.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentTargetResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTarget">REST API Reference for DeleteAssessmentTarget Operation</seealso>
        public virtual DeleteAssessmentTargetResponse EndDeleteAssessmentTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssessmentTargetResponse>(asyncResult);
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTemplate">REST API Reference for DeleteAssessmentTemplate Operation</seealso>
        public virtual DeleteAssessmentTemplateResponse DeleteAssessmentTemplate(DeleteAssessmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTemplate operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessmentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTemplate">REST API Reference for DeleteAssessmentTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssessmentTemplate(DeleteAssessmentTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessmentTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentTemplateResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTemplate">REST API Reference for DeleteAssessmentTemplate Operation</seealso>
        public virtual DeleteAssessmentTemplateResponse EndDeleteAssessmentTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssessmentTemplateResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessmentRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentRuns operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssessmentRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentRuns">REST API Reference for DescribeAssessmentRuns Operation</seealso>
        public virtual IAsyncResult BeginDescribeAssessmentRuns(DescribeAssessmentRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssessmentRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssessmentRuns.</param>
        /// 
        /// <returns>Returns a  DescribeAssessmentRunsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentRuns">REST API Reference for DescribeAssessmentRuns Operation</seealso>
        public virtual DescribeAssessmentRunsResponse EndDescribeAssessmentRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssessmentRunsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTargetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessmentTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTargets operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssessmentTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTargets">REST API Reference for DescribeAssessmentTargets Operation</seealso>
        public virtual IAsyncResult BeginDescribeAssessmentTargets(DescribeAssessmentTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssessmentTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssessmentTargets.</param>
        /// 
        /// <returns>Returns a  DescribeAssessmentTargetsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTargets">REST API Reference for DescribeAssessmentTargets Operation</seealso>
        public virtual DescribeAssessmentTargetsResponse EndDescribeAssessmentTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssessmentTargetsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessmentTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTemplates operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssessmentTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTemplates">REST API Reference for DescribeAssessmentTemplates Operation</seealso>
        public virtual IAsyncResult BeginDescribeAssessmentTemplates(DescribeAssessmentTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssessmentTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssessmentTemplates.</param>
        /// 
        /// <returns>Returns a  DescribeAssessmentTemplatesResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTemplates">REST API Reference for DescribeAssessmentTemplates Operation</seealso>
        public virtual DescribeAssessmentTemplatesResponse EndDescribeAssessmentTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssessmentTemplatesResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<DescribeCrossAccountAccessRoleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCrossAccountAccessRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeCrossAccountAccessRole">REST API Reference for DescribeCrossAccountAccessRole Operation</seealso>
        public virtual IAsyncResult BeginDescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCrossAccountAccessRole.</param>
        /// 
        /// <returns>Returns a  DescribeCrossAccountAccessRoleResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeCrossAccountAccessRole">REST API Reference for DescribeCrossAccountAccessRole Operation</seealso>
        public virtual DescribeCrossAccountAccessRoleResponse EndDescribeCrossAccountAccessRole(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCrossAccountAccessRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExclusions

        /// <summary>
        /// Describes the exclusions that are specified by the exclusions' ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExclusions service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExclusionsResponseUnmarshaller.Instance;

            return Invoke<DescribeExclusionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExclusions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExclusions operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExclusions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeExclusions">REST API Reference for DescribeExclusions Operation</seealso>
        public virtual IAsyncResult BeginDescribeExclusions(DescribeExclusionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExclusionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExclusions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExclusions.</param>
        /// 
        /// <returns>Returns a  DescribeExclusionsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeExclusions">REST API Reference for DescribeExclusions Operation</seealso>
        public virtual DescribeExclusionsResponse EndDescribeExclusions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExclusionsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFindingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFindingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFindings operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeFindings">REST API Reference for DescribeFindings Operation</seealso>
        public virtual IAsyncResult BeginDescribeFindings(DescribeFindingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFindingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFindings.</param>
        /// 
        /// <returns>Returns a  DescribeFindingsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeFindings">REST API Reference for DescribeFindings Operation</seealso>
        public virtual DescribeFindingsResponse EndDescribeFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFindingsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroups operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourceGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeResourceGroups">REST API Reference for DescribeResourceGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeResourceGroups(DescribeResourceGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourceGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourceGroups.</param>
        /// 
        /// <returns>Returns a  DescribeResourceGroupsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeResourceGroups">REST API Reference for DescribeResourceGroups Operation</seealso>
        public virtual DescribeResourceGroupsResponse EndDescribeResourceGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResourceGroupsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<DescribeRulesPackagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackages operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRulesPackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeRulesPackages">REST API Reference for DescribeRulesPackages Operation</seealso>
        public virtual IAsyncResult BeginDescribeRulesPackages(DescribeRulesPackagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRulesPackagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRulesPackages.</param>
        /// 
        /// <returns>Returns a  DescribeRulesPackagesResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeRulesPackages">REST API Reference for DescribeRulesPackages Operation</seealso>
        public virtual DescribeRulesPackagesResponse EndDescribeRulesPackages(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRulesPackagesResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentReportResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentReportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReport operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssessmentReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetAssessmentReport">REST API Reference for GetAssessmentReport Operation</seealso>
        public virtual IAsyncResult BeginGetAssessmentReport(GetAssessmentReportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssessmentReport.</param>
        /// 
        /// <returns>Returns a  GetAssessmentReportResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetAssessmentReport">REST API Reference for GetAssessmentReport Operation</seealso>
        public virtual GetAssessmentReportResponse EndGetAssessmentReport(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssessmentReportResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExclusionsPreview

        /// <summary>
        /// Retrieves the exclusions preview (a list of ExclusionPreview objects) specified by
        /// the preview token. You can obtain the preview token by running the CreateExclusionsPreview
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExclusionsPreview service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExclusionsPreviewResponseUnmarshaller.Instance;

            return Invoke<GetExclusionsPreviewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExclusionsPreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExclusionsPreview operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExclusionsPreview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetExclusionsPreview">REST API Reference for GetExclusionsPreview Operation</seealso>
        public virtual IAsyncResult BeginGetExclusionsPreview(GetExclusionsPreviewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExclusionsPreviewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExclusionsPreview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExclusionsPreview.</param>
        /// 
        /// <returns>Returns a  GetExclusionsPreviewResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetExclusionsPreview">REST API Reference for GetExclusionsPreview Operation</seealso>
        public virtual GetExclusionsPreviewResponse EndGetExclusionsPreview(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExclusionsPreviewResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTelemetryMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryMetadataResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryMetadata operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetTelemetryMetadata">REST API Reference for GetTelemetryMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetTelemetryMetadata(GetTelemetryMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTelemetryMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryMetadata.</param>
        /// 
        /// <returns>Returns a  GetTelemetryMetadataResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetTelemetryMetadata">REST API Reference for GetTelemetryMetadata Operation</seealso>
        public virtual GetTelemetryMetadataResponse EndGetTelemetryMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTelemetryMetadataResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunAgentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentRunAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRunAgents operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentRunAgents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRunAgents">REST API Reference for ListAssessmentRunAgents Operation</seealso>
        public virtual IAsyncResult BeginListAssessmentRunAgents(ListAssessmentRunAgentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunAgentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentRunAgents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentRunAgents.</param>
        /// 
        /// <returns>Returns a  ListAssessmentRunAgentsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRunAgents">REST API Reference for ListAssessmentRunAgents Operation</seealso>
        public virtual ListAssessmentRunAgentsResponse EndListAssessmentRunAgents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssessmentRunAgentsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRuns operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRuns">REST API Reference for ListAssessmentRuns Operation</seealso>
        public virtual IAsyncResult BeginListAssessmentRuns(ListAssessmentRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentRuns.</param>
        /// 
        /// <returns>Returns a  ListAssessmentRunsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRuns">REST API Reference for ListAssessmentRuns Operation</seealso>
        public virtual ListAssessmentRunsResponse EndListAssessmentRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssessmentRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssessmentTargets

        /// <summary>
        /// Lists the ARNs of the assessment targets within this AWS account. For more information
        /// about assessment targets, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">Amazon
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTargetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTargets operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTargets">REST API Reference for ListAssessmentTargets Operation</seealso>
        public virtual IAsyncResult BeginListAssessmentTargets(ListAssessmentTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentTargets.</param>
        /// 
        /// <returns>Returns a  ListAssessmentTargetsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTargets">REST API Reference for ListAssessmentTargets Operation</seealso>
        public virtual ListAssessmentTargetsResponse EndListAssessmentTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssessmentTargetsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTemplates operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTemplates">REST API Reference for ListAssessmentTemplates Operation</seealso>
        public virtual IAsyncResult BeginListAssessmentTemplates(ListAssessmentTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentTemplates.</param>
        /// 
        /// <returns>Returns a  ListAssessmentTemplatesResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTemplates">REST API Reference for ListAssessmentTemplates Operation</seealso>
        public virtual ListAssessmentTemplatesResponse EndListAssessmentTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssessmentTemplatesResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListEventSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventSubscriptions operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListEventSubscriptions">REST API Reference for ListEventSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginListEventSubscriptions(ListEventSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListEventSubscriptionsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListEventSubscriptions">REST API Reference for ListEventSubscriptions Operation</seealso>
        public virtual ListEventSubscriptionsResponse EndListEventSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExclusions

        /// <summary>
        /// List exclusions that are generated by the assessment run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExclusions service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExclusionsResponseUnmarshaller.Instance;

            return Invoke<ListExclusionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExclusions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExclusions operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExclusions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListExclusions">REST API Reference for ListExclusions Operation</seealso>
        public virtual IAsyncResult BeginListExclusions(ListExclusionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExclusionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExclusions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExclusions.</param>
        /// 
        /// <returns>Returns a  ListExclusionsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListExclusions">REST API Reference for ListExclusions Operation</seealso>
        public virtual ListExclusionsResponse EndListExclusions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExclusionsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual IAsyncResult BeginListFindings(ListFindingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindings.</param>
        /// 
        /// <returns>Returns a  ListFindingsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual ListFindingsResponse EndListFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFindingsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<ListRulesPackagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRulesPackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListRulesPackages">REST API Reference for ListRulesPackages Operation</seealso>
        public virtual IAsyncResult BeginListRulesPackages(ListRulesPackagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRulesPackages.</param>
        /// 
        /// <returns>Returns a  ListRulesPackagesResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListRulesPackages">REST API Reference for ListRulesPackages Operation</seealso>
        public virtual ListRulesPackagesResponse EndListRulesPackages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRulesPackagesResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PreviewAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewAgentsResponseUnmarshaller.Instance;

            return Invoke<PreviewAgentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PreviewAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgents operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPreviewAgents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/PreviewAgents">REST API Reference for PreviewAgents Operation</seealso>
        public virtual IAsyncResult BeginPreviewAgents(PreviewAgentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PreviewAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewAgentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PreviewAgents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPreviewAgents.</param>
        /// 
        /// <returns>Returns a  PreviewAgentsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/PreviewAgents">REST API Reference for PreviewAgents Operation</seealso>
        public virtual PreviewAgentsResponse EndPreviewAgents(IAsyncResult asyncResult)
        {
            return EndInvoke<PreviewAgentsResponse>(asyncResult);
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RegisterCrossAccountAccessRole">REST API Reference for RegisterCrossAccountAccessRole Operation</seealso>
        public virtual RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<RegisterCrossAccountAccessRoleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterCrossAccountAccessRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RegisterCrossAccountAccessRole">REST API Reference for RegisterCrossAccountAccessRole Operation</seealso>
        public virtual IAsyncResult BeginRegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterCrossAccountAccessRole.</param>
        /// 
        /// <returns>Returns a  RegisterCrossAccountAccessRoleResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RegisterCrossAccountAccessRole">REST API Reference for RegisterCrossAccountAccessRole Operation</seealso>
        public virtual RegisterCrossAccountAccessRoleResponse EndRegisterCrossAccountAccessRole(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterCrossAccountAccessRoleResponse>(asyncResult);
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RemoveAttributesFromFindings">REST API Reference for RemoveAttributesFromFindings Operation</seealso>
        public virtual RemoveAttributesFromFindingsResponse RemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAttributesFromFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return Invoke<RemoveAttributesFromFindingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAttributesFromFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAttributesFromFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RemoveAttributesFromFindings">REST API Reference for RemoveAttributesFromFindings Operation</seealso>
        public virtual IAsyncResult BeginRemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAttributesFromFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAttributesFromFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAttributesFromFindings.</param>
        /// 
        /// <returns>Returns a  RemoveAttributesFromFindingsResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RemoveAttributesFromFindings">REST API Reference for RemoveAttributesFromFindings Operation</seealso>
        public virtual RemoveAttributesFromFindingsResponse EndRemoveAttributesFromFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveAttributesFromFindingsResponse>(asyncResult);
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SetTagsForResource">REST API Reference for SetTagsForResource Operation</seealso>
        public virtual SetTagsForResourceResponse SetTagsForResource(SetTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<SetTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SetTagsForResource">REST API Reference for SetTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginSetTagsForResource(SetTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTagsForResource.</param>
        /// 
        /// <returns>Returns a  SetTagsForResourceResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SetTagsForResource">REST API Reference for SetTagsForResource Operation</seealso>
        public virtual SetTagsForResourceResponse EndSetTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<SetTagsForResourceResponse>(asyncResult);
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StartAssessmentRun">REST API Reference for StartAssessmentRun Operation</seealso>
        public virtual StartAssessmentRunResponse StartAssessmentRun(StartAssessmentRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StartAssessmentRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentRun operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAssessmentRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StartAssessmentRun">REST API Reference for StartAssessmentRun Operation</seealso>
        public virtual IAsyncResult BeginStartAssessmentRun(StartAssessmentRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAssessmentRun.</param>
        /// 
        /// <returns>Returns a  StartAssessmentRunResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StartAssessmentRun">REST API Reference for StartAssessmentRun Operation</seealso>
        public virtual StartAssessmentRunResponse EndStartAssessmentRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAssessmentRunResponse>(asyncResult);
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StopAssessmentRun">REST API Reference for StopAssessmentRun Operation</seealso>
        public virtual StopAssessmentRunResponse StopAssessmentRun(StopAssessmentRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StopAssessmentRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAssessmentRun operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopAssessmentRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StopAssessmentRun">REST API Reference for StopAssessmentRun Operation</seealso>
        public virtual IAsyncResult BeginStopAssessmentRun(StopAssessmentRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAssessmentRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopAssessmentRun.</param>
        /// 
        /// <returns>Returns a  StopAssessmentRunResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StopAssessmentRun">REST API Reference for StopAssessmentRun Operation</seealso>
        public virtual StopAssessmentRunResponse EndStopAssessmentRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StopAssessmentRunResponse>(asyncResult);
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SubscribeToEvent">REST API Reference for SubscribeToEvent Operation</seealso>
        public virtual SubscribeToEventResponse SubscribeToEvent(SubscribeToEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubscribeToEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeToEventResponseUnmarshaller.Instance;

            return Invoke<SubscribeToEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SubscribeToEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToEvent operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubscribeToEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SubscribeToEvent">REST API Reference for SubscribeToEvent Operation</seealso>
        public virtual IAsyncResult BeginSubscribeToEvent(SubscribeToEventRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubscribeToEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeToEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SubscribeToEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubscribeToEvent.</param>
        /// 
        /// <returns>Returns a  SubscribeToEventResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SubscribeToEvent">REST API Reference for SubscribeToEvent Operation</seealso>
        public virtual SubscribeToEventResponse EndSubscribeToEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<SubscribeToEventResponse>(asyncResult);
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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UnsubscribeFromEvent">REST API Reference for UnsubscribeFromEvent Operation</seealso>
        public virtual UnsubscribeFromEventResponse UnsubscribeFromEvent(UnsubscribeFromEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnsubscribeFromEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeFromEventResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeFromEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnsubscribeFromEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromEvent operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnsubscribeFromEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UnsubscribeFromEvent">REST API Reference for UnsubscribeFromEvent Operation</seealso>
        public virtual IAsyncResult BeginUnsubscribeFromEvent(UnsubscribeFromEventRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnsubscribeFromEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeFromEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnsubscribeFromEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnsubscribeFromEvent.</param>
        /// 
        /// <returns>Returns a  UnsubscribeFromEventResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UnsubscribeFromEvent">REST API Reference for UnsubscribeFromEvent Operation</seealso>
        public virtual UnsubscribeFromEventResponse EndUnsubscribeFromEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<UnsubscribeFromEventResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssessmentTarget

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
        /// <exception cref="Amazon.Inspector.Model.ServiceTemporarilyUnavailableException">
        /// The serice is temporary unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UpdateAssessmentTarget">REST API Reference for UpdateAssessmentTarget Operation</seealso>
        public virtual UpdateAssessmentTargetResponse UpdateAssessmentTarget(UpdateAssessmentTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentTarget operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessmentTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UpdateAssessmentTarget">REST API Reference for UpdateAssessmentTarget Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssessmentTarget(UpdateAssessmentTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessmentTarget.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentTargetResult from Inspector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UpdateAssessmentTarget">REST API Reference for UpdateAssessmentTarget Operation</seealso>
        public virtual UpdateAssessmentTargetResponse EndUpdateAssessmentTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssessmentTargetResponse>(asyncResult);
        }

        #endregion
        
    }
}