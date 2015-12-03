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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
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
    /// Amazon Inspector enables you to analyze the behavior of the applications you run in
    /// AWS and to identify potential security issues. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_introduction.html">
    /// Amazon Inspector User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonInspectorClient : AmazonServiceClient, IAmazonInspector
    {
        
        #region Constructors

#if DNX
    
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

#endif

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

        internal AddAttributesToFindingsResponse AddAttributesToFindings(AddAttributesToFindingsRequest request)
        {
            var marshaller = new AddAttributesToFindingsRequestMarshaller();
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
        public Task<AddAttributesToFindingsResponse> AddAttributesToFindingsAsync(AddAttributesToFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddAttributesToFindingsRequestMarshaller();
            var unmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<AddAttributesToFindingsRequest,AddAttributesToFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachAssessmentAndRulesPackage

        internal AttachAssessmentAndRulesPackageResponse AttachAssessmentAndRulesPackage(AttachAssessmentAndRulesPackageRequest request)
        {
            var marshaller = new AttachAssessmentAndRulesPackageRequestMarshaller();
            var unmarshaller = AttachAssessmentAndRulesPackageResponseUnmarshaller.Instance;

            return Invoke<AttachAssessmentAndRulesPackageRequest,AttachAssessmentAndRulesPackageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachAssessmentAndRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachAssessmentAndRulesPackage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachAssessmentAndRulesPackageResponse> AttachAssessmentAndRulesPackageAsync(AttachAssessmentAndRulesPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachAssessmentAndRulesPackageRequestMarshaller();
            var unmarshaller = AttachAssessmentAndRulesPackageResponseUnmarshaller.Instance;

            return InvokeAsync<AttachAssessmentAndRulesPackageRequest,AttachAssessmentAndRulesPackageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication

        internal CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var marshaller = new CreateApplicationRequestMarshaller();
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a new application using the resource group ARN generated by <a>CreateResourceGroup</a>.
        /// You can create up to 50 applications per AWS account. You can run up to 500 concurrent
        /// agents per AWS account. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">
        /// Inspector Applications.</a>
        /// </summary>
        /// <param name="applicationName">The user-defined name identifying the application that you want to create. The name must be unique within the AWS account.</param>
        /// <param name="resourceGroupArn">The ARN specifying the resource group that is used to create the application.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<CreateApplicationResponse> CreateApplicationAsync(string applicationName, string resourceGroupArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateApplicationRequest();
            request.ApplicationName = applicationName;
            request.ResourceGroupArn = resourceGroupArn;
            return CreateApplicationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateApplicationRequestMarshaller();
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAssessment

        internal CreateAssessmentResponse CreateAssessment(CreateAssessmentRequest request)
        {
            var marshaller = new CreateAssessmentRequestMarshaller();
            var unmarshaller = CreateAssessmentResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentRequest,CreateAssessmentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateAssessmentResponse> CreateAssessmentAsync(CreateAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAssessmentRequestMarshaller();
            var unmarshaller = CreateAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentRequest,CreateAssessmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceGroup

        internal CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request)
        {
            var marshaller = new CreateResourceGroupRequestMarshaller();
            var unmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return Invoke<CreateResourceGroupRequest,CreateResourceGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a resource group using the specified set of tags (key and value pairs) that
        /// are used to select the EC2 instances to be included in an Inspector application. The
        /// created resource group is then used to create an Inspector application.
        /// </summary>
        /// <param name="resourceGroupTags">A collection of keys and an array of possible values in JSON format. For example, [{ "key1" : ["Value1","Value2"]},{"Key2": ["Value3"]}]</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        public Task<CreateResourceGroupResponse> CreateResourceGroupAsync(string resourceGroupTags, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateResourceGroupRequest();
            request.ResourceGroupTags = resourceGroupTags;
            return CreateResourceGroupAsync(request, cancellationToken);
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
        public Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateResourceGroupRequestMarshaller();
            var unmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceGroupRequest,CreateResourceGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplication

        internal DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var marshaller = new DeleteApplicationRequestMarshaller();
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">The ARN specifying the application that you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.OperationInProgressException">
        /// 
        /// </exception>
        public Task<DeleteApplicationResponse> DeleteApplicationAsync(string applicationArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteApplicationRequest();
            request.ApplicationArn = applicationArn;
            return DeleteApplicationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteApplicationRequestMarshaller();
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessment

        internal DeleteAssessmentResponse DeleteAssessment(DeleteAssessmentRequest request)
        {
            var marshaller = new DeleteAssessmentRequestMarshaller();
            var unmarshaller = DeleteAssessmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentRequest,DeleteAssessmentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment that you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssessment service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.OperationInProgressException">
        /// 
        /// </exception>
        public Task<DeleteAssessmentResponse> DeleteAssessmentAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteAssessmentRequest();
            request.AssessmentArn = assessmentArn;
            return DeleteAssessmentAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteAssessmentResponse> DeleteAssessmentAsync(DeleteAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAssessmentRequestMarshaller();
            var unmarshaller = DeleteAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentRequest,DeleteAssessmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRun

        internal DeleteRunResponse DeleteRun(DeleteRunRequest request)
        {
            var marshaller = new DeleteRunRequestMarshaller();
            var unmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return Invoke<DeleteRunRequest,DeleteRunResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="runArn">The ARN specifying the assessment run that you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<DeleteRunResponse> DeleteRunAsync(string runArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteRunRequest();
            request.RunArn = runArn;
            return DeleteRunAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteRunResponse> DeleteRunAsync(DeleteRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRunRequestMarshaller();
            var unmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRunRequest,DeleteRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplication

        internal DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var marshaller = new DescribeApplicationRequestMarshaller();
            var unmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationRequest,DescribeApplicationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">The ARN specifying the application that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<DescribeApplicationResponse> DescribeApplicationAsync(string applicationArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeApplicationRequest();
            request.ApplicationArn = applicationArn;
            return DescribeApplicationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeApplicationRequestMarshaller();
            var unmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationRequest,DescribeApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssessment

        internal DescribeAssessmentResponse DescribeAssessment(DescribeAssessmentRequest request)
        {
            var marshaller = new DescribeAssessmentRequestMarshaller();
            var unmarshaller = DescribeAssessmentResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentRequest,DescribeAssessmentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssessment service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<DescribeAssessmentResponse> DescribeAssessmentAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeAssessmentRequest();
            request.AssessmentArn = assessmentArn;
            return DescribeAssessmentAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAssessmentResponse> DescribeAssessmentAsync(DescribeAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAssessmentRequestMarshaller();
            var unmarshaller = DescribeAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentRequest,DescribeAssessmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCrossAccountAccessRole

        internal DescribeCrossAccountAccessRoleResponse DescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request)
        {
            var marshaller = new DescribeCrossAccountAccessRoleRequestMarshaller();
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
        public Task<DescribeCrossAccountAccessRoleResponse> DescribeCrossAccountAccessRoleAsync(DescribeCrossAccountAccessRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCrossAccountAccessRoleRequestMarshaller();
            var unmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCrossAccountAccessRoleRequest,DescribeCrossAccountAccessRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFinding

        internal DescribeFindingResponse DescribeFinding(DescribeFindingRequest request)
        {
            var marshaller = new DescribeFindingRequestMarshaller();
            var unmarshaller = DescribeFindingResponseUnmarshaller.Instance;

            return Invoke<DescribeFindingRequest,DescribeFindingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the finding specified by the finding ARN.
        /// </summary>
        /// <param name="findingArn">The ARN specifying the finding that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFinding service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<DescribeFindingResponse> DescribeFindingAsync(string findingArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeFindingRequest();
            request.FindingArn = findingArn;
            return DescribeFindingAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFinding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFinding operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeFindingResponse> DescribeFindingAsync(DescribeFindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeFindingRequestMarshaller();
            var unmarshaller = DescribeFindingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFindingRequest,DescribeFindingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeResourceGroup

        internal DescribeResourceGroupResponse DescribeResourceGroup(DescribeResourceGroupRequest request)
        {
            var marshaller = new DescribeResourceGroupRequestMarshaller();
            var unmarshaller = DescribeResourceGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceGroupRequest,DescribeResourceGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the resource group specified by the resource group ARN.
        /// </summary>
        /// <param name="resourceGroupArn">The ARN specifying the resource group that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<DescribeResourceGroupResponse> DescribeResourceGroupAsync(string resourceGroupArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeResourceGroupRequest();
            request.ResourceGroupArn = resourceGroupArn;
            return DescribeResourceGroupAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeResourceGroupResponse> DescribeResourceGroupAsync(DescribeResourceGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeResourceGroupRequestMarshaller();
            var unmarshaller = DescribeResourceGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourceGroupRequest,DescribeResourceGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRulesPackage

        internal DescribeRulesPackageResponse DescribeRulesPackage(DescribeRulesPackageRequest request)
        {
            var marshaller = new DescribeRulesPackageRequestMarshaller();
            var unmarshaller = DescribeRulesPackageResponseUnmarshaller.Instance;

            return Invoke<DescribeRulesPackageRequest,DescribeRulesPackageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the rules package specified by the rules package ARN.
        /// </summary>
        /// <param name="rulesPackageArn">The ARN specifying the rules package that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRulesPackage service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<DescribeRulesPackageResponse> DescribeRulesPackageAsync(string rulesPackageArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeRulesPackageRequest();
            request.RulesPackageArn = rulesPackageArn;
            return DescribeRulesPackageAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeRulesPackageResponse> DescribeRulesPackageAsync(DescribeRulesPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRulesPackageRequestMarshaller();
            var unmarshaller = DescribeRulesPackageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRulesPackageRequest,DescribeRulesPackageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRun

        internal DescribeRunResponse DescribeRun(DescribeRunRequest request)
        {
            var marshaller = new DescribeRunRequestMarshaller();
            var unmarshaller = DescribeRunResponseUnmarshaller.Instance;

            return Invoke<DescribeRunRequest,DescribeRunResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="runArn">The ARN specifying the assessment run that you want to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRun service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<DescribeRunResponse> DescribeRunAsync(string runArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeRunRequest();
            request.RunArn = runArn;
            return DescribeRunAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeRunResponse> DescribeRunAsync(DescribeRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRunRequestMarshaller();
            var unmarshaller = DescribeRunResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRunRequest,DescribeRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachAssessmentAndRulesPackage

        internal DetachAssessmentAndRulesPackageResponse DetachAssessmentAndRulesPackage(DetachAssessmentAndRulesPackageRequest request)
        {
            var marshaller = new DetachAssessmentAndRulesPackageRequestMarshaller();
            var unmarshaller = DetachAssessmentAndRulesPackageResponseUnmarshaller.Instance;

            return Invoke<DetachAssessmentAndRulesPackageRequest,DetachAssessmentAndRulesPackageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Detaches the rules package specified by the rules package ARN from the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment from which you want to detach a rules package.</param>
        /// <param name="rulesPackageArn">The ARN specifying the rules package that you want to detach from the assessment.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachAssessmentAndRulesPackage service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<DetachAssessmentAndRulesPackageResponse> DetachAssessmentAndRulesPackageAsync(string assessmentArn, string rulesPackageArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DetachAssessmentAndRulesPackageRequest();
            request.AssessmentArn = assessmentArn;
            request.RulesPackageArn = rulesPackageArn;
            return DetachAssessmentAndRulesPackageAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachAssessmentAndRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachAssessmentAndRulesPackage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachAssessmentAndRulesPackageResponse> DetachAssessmentAndRulesPackageAsync(DetachAssessmentAndRulesPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachAssessmentAndRulesPackageRequestMarshaller();
            var unmarshaller = DetachAssessmentAndRulesPackageResponseUnmarshaller.Instance;

            return InvokeAsync<DetachAssessmentAndRulesPackageRequest,DetachAssessmentAndRulesPackageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAssessmentTelemetry

        internal GetAssessmentTelemetryResponse GetAssessmentTelemetry(GetAssessmentTelemetryRequest request)
        {
            var marshaller = new GetAssessmentTelemetryRequestMarshaller();
            var unmarshaller = GetAssessmentTelemetryResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentTelemetryRequest,GetAssessmentTelemetryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the metadata about the telemetry (application behavioral data) for the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment the telemetry of which you want to obtain.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssessmentTelemetry service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<GetAssessmentTelemetryResponse> GetAssessmentTelemetryAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetAssessmentTelemetryRequest();
            request.AssessmentArn = assessmentArn;
            return GetAssessmentTelemetryAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessmentTelemetry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentTelemetry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetAssessmentTelemetryResponse> GetAssessmentTelemetryAsync(GetAssessmentTelemetryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAssessmentTelemetryRequestMarshaller();
            var unmarshaller = GetAssessmentTelemetryResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssessmentTelemetryRequest,GetAssessmentTelemetryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListApplications

        internal ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var marshaller = new ListApplicationsRequestMarshaller();
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsRequest,ListApplicationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the ARNs of the applications within this AWS account. For more information about
        /// applications, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">Inspector
        /// Applications</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        public Task<ListApplicationsResponse> ListApplicationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListApplicationsRequest();
            return ListApplicationsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Lists the ARNs of the applications within this AWS account. For more information about
        /// applications, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">Inspector
        /// Applications</a>.
        /// </summary>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        public Task<ListApplicationsResponse> ListApplicationsAsync(ApplicationsFilter filter, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListApplicationsRequest();
            request.Filter = filter;
            return ListApplicationsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListApplicationsRequestMarshaller();
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsRequest,ListApplicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentAgents

        internal ListAssessmentAgentsResponse ListAssessmentAgents(ListAssessmentAgentsRequest request)
        {
            var marshaller = new ListAssessmentAgentsRequestMarshaller();
            var unmarshaller = ListAssessmentAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentAgentsRequest,ListAssessmentAgentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the agents of the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment whose agents you want to list.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssessmentAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<ListAssessmentAgentsResponse> ListAssessmentAgentsAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListAssessmentAgentsRequest();
            request.AssessmentArn = assessmentArn;
            return ListAssessmentAgentsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Lists the agents of the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment whose agents you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssessmentAgents service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<ListAssessmentAgentsResponse> ListAssessmentAgentsAsync(string assessmentArn, AgentsFilter filter, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListAssessmentAgentsRequest();
            request.AssessmentArn = assessmentArn;
            request.Filter = filter;
            return ListAssessmentAgentsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAssessmentAgentsResponse> ListAssessmentAgentsAsync(ListAssessmentAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAssessmentAgentsRequestMarshaller();
            var unmarshaller = ListAssessmentAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentAgentsRequest,ListAssessmentAgentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssessments

        internal ListAssessmentsResponse ListAssessments(ListAssessmentsRequest request)
        {
            var marshaller = new ListAssessmentsRequestMarshaller();
            var unmarshaller = ListAssessmentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentsRequest,ListAssessmentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the assessments corresponding to applications specified by the applications'
        /// ARNs.
        /// </summary>
        /// <param name="applicationArns">A list of ARNs specifying the applications the assessments of which you want to list.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssessments service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<ListAssessmentsResponse> ListAssessmentsAsync(List<string> applicationArns, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListAssessmentsRequest();
            request.ApplicationArns = applicationArns;
            return ListAssessmentsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Lists the assessments corresponding to applications specified by the applications'
        /// ARNs.
        /// </summary>
        /// <param name="applicationArns">A list of ARNs specifying the applications the assessments of which you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssessments service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<ListAssessmentsResponse> ListAssessmentsAsync(List<string> applicationArns, AssessmentsFilter filter, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListAssessmentsRequest();
            request.ApplicationArns = applicationArns;
            request.Filter = filter;
            return ListAssessmentsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAssessmentsResponse> ListAssessmentsAsync(ListAssessmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAssessmentsRequestMarshaller();
            var unmarshaller = ListAssessmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentsRequest,ListAssessmentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedAssessments

        internal ListAttachedAssessmentsResponse ListAttachedAssessments(ListAttachedAssessmentsRequest request)
        {
            var marshaller = new ListAttachedAssessmentsRequestMarshaller();
            var unmarshaller = ListAttachedAssessmentsResponseUnmarshaller.Instance;

            return Invoke<ListAttachedAssessmentsRequest,ListAttachedAssessmentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedAssessments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAttachedAssessmentsResponse> ListAttachedAssessmentsAsync(ListAttachedAssessmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAttachedAssessmentsRequestMarshaller();
            var unmarshaller = ListAttachedAssessmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedAssessmentsRequest,ListAttachedAssessmentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedRulesPackages

        internal ListAttachedRulesPackagesResponse ListAttachedRulesPackages(ListAttachedRulesPackagesRequest request)
        {
            var marshaller = new ListAttachedRulesPackagesRequestMarshaller();
            var unmarshaller = ListAttachedRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedRulesPackagesRequest,ListAttachedRulesPackagesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRulesPackages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAttachedRulesPackagesResponse> ListAttachedRulesPackagesAsync(ListAttachedRulesPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAttachedRulesPackagesRequestMarshaller();
            var unmarshaller = ListAttachedRulesPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedRulesPackagesRequest,ListAttachedRulesPackagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFindings

        internal ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var marshaller = new ListFindingsRequestMarshaller();
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
        public Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListFindingsRequestMarshaller();
            var unmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFindingsRequest,ListFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRulesPackages

        internal ListRulesPackagesResponse ListRulesPackages(ListRulesPackagesRequest request)
        {
            var marshaller = new ListRulesPackagesRequestMarshaller();
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
        public Task<ListRulesPackagesResponse> ListRulesPackagesAsync(ListRulesPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListRulesPackagesRequestMarshaller();
            var unmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRulesPackagesRequest,ListRulesPackagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRuns

        internal ListRunsResponse ListRuns(ListRunsRequest request)
        {
            var marshaller = new ListRunsRequestMarshaller();
            var unmarshaller = ListRunsResponseUnmarshaller.Instance;

            return Invoke<ListRunsRequest,ListRunsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the assessment runs associated with the assessments specified by the assessment
        /// ARNs.
        /// </summary>
        /// <param name="assessmentArns">The ARNs specifying the assessments whose runs you want to list.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<ListRunsResponse> ListRunsAsync(List<string> assessmentArns, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRunsRequest();
            request.AssessmentArns = assessmentArns;
            return ListRunsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Lists the assessment runs associated with the assessments specified by the assessment
        /// ARNs.
        /// </summary>
        /// <param name="assessmentArns">The ARNs specifying the assessments whose runs you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuns service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<ListRunsResponse> ListRunsAsync(List<string> assessmentArns, RunsFilter filter, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRunsRequest();
            request.AssessmentArns = assessmentArns;
            request.Filter = filter;
            return ListRunsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListRunsResponse> ListRunsAsync(ListRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListRunsRequestMarshaller();
            var unmarshaller = ListRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRunsRequest,ListRunsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists all tags associated with a resource.
        /// </summary>
        /// <param name="resourceArn">The ARN specifying the resource whose tags you want to list.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(string resourceArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListTagsForResourceRequest();
            request.ResourceArn = resourceArn;
            return ListTagsForResourceAsync(request, cancellationToken);
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
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  LocalizeText

        internal LocalizeTextResponse LocalizeText(LocalizeTextRequest request)
        {
            var marshaller = new LocalizeTextRequestMarshaller();
            var unmarshaller = LocalizeTextResponseUnmarshaller.Instance;

            return Invoke<LocalizeTextRequest,LocalizeTextResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the LocalizeText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LocalizeText operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<LocalizeTextResponse> LocalizeTextAsync(LocalizeTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new LocalizeTextRequestMarshaller();
            var unmarshaller = LocalizeTextResponseUnmarshaller.Instance;

            return InvokeAsync<LocalizeTextRequest,LocalizeTextResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PreviewAgentsForResourceGroup

        internal PreviewAgentsForResourceGroupResponse PreviewAgentsForResourceGroup(PreviewAgentsForResourceGroupRequest request)
        {
            var marshaller = new PreviewAgentsForResourceGroupRequestMarshaller();
            var unmarshaller = PreviewAgentsForResourceGroupResponseUnmarshaller.Instance;

            return Invoke<PreviewAgentsForResourceGroupRequest,PreviewAgentsForResourceGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Previews the agents installed on the EC2 instances that are included in the application
        /// created with the specified resource group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PreviewAgentsForResourceGroup service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<PreviewAgentsForResourceGroupResponse> PreviewAgentsForResourceGroupAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PreviewAgentsForResourceGroupRequest();
            return PreviewAgentsForResourceGroupAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PreviewAgentsForResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgentsForResourceGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PreviewAgentsForResourceGroupResponse> PreviewAgentsForResourceGroupAsync(PreviewAgentsForResourceGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PreviewAgentsForResourceGroupRequestMarshaller();
            var unmarshaller = PreviewAgentsForResourceGroupResponseUnmarshaller.Instance;

            return InvokeAsync<PreviewAgentsForResourceGroupRequest,PreviewAgentsForResourceGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterCrossAccountAccessRole

        internal RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request)
        {
            var marshaller = new RegisterCrossAccountAccessRoleRequestMarshaller();
            var unmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<RegisterCrossAccountAccessRoleRequest,RegisterCrossAccountAccessRoleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Register the role that Inspector uses to list your EC2 instances during the assessment.
        /// </summary>
        /// <param name="roleArn">The ARN of the IAM role that Inspector uses to list your EC2 instances during the assessment.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        public Task<RegisterCrossAccountAccessRoleResponse> RegisterCrossAccountAccessRoleAsync(string roleArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RegisterCrossAccountAccessRoleRequest();
            request.RoleArn = roleArn;
            return RegisterCrossAccountAccessRoleAsync(request, cancellationToken);
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
        public Task<RegisterCrossAccountAccessRoleResponse> RegisterCrossAccountAccessRoleAsync(RegisterCrossAccountAccessRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterCrossAccountAccessRoleRequestMarshaller();
            var unmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterCrossAccountAccessRoleRequest,RegisterCrossAccountAccessRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveAttributesFromFindings

        internal RemoveAttributesFromFindingsResponse RemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request)
        {
            var marshaller = new RemoveAttributesFromFindingsRequestMarshaller();
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
        public Task<RemoveAttributesFromFindingsResponse> RemoveAttributesFromFindingsAsync(RemoveAttributesFromFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveAttributesFromFindingsRequestMarshaller();
            var unmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAttributesFromFindingsRequest,RemoveAttributesFromFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RunAssessment

        internal RunAssessmentResponse RunAssessment(RunAssessmentRequest request)
        {
            var marshaller = new RunAssessmentRequestMarshaller();
            var unmarshaller = RunAssessmentResponseUnmarshaller.Instance;

            return Invoke<RunAssessmentRequest,RunAssessmentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Starts the analysis of the application’s behavior against selected rule packages for
        /// the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="runName">A name specifying the run of the assessment.</param>
        /// <param name="assessmentArn">The ARN of the assessment that you want to run.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunAssessment service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<RunAssessmentResponse> RunAssessmentAsync(string runName, string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RunAssessmentRequest();
            request.RunName = runName;
            request.AssessmentArn = assessmentArn;
            return RunAssessmentAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RunAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RunAssessmentResponse> RunAssessmentAsync(RunAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RunAssessmentRequestMarshaller();
            var unmarshaller = RunAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<RunAssessmentRequest,RunAssessmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetTagsForResource

        internal SetTagsForResourceResponse SetTagsForResource(SetTagsForResourceRequest request)
        {
            var marshaller = new SetTagsForResourceRequestMarshaller();
            var unmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<SetTagsForResourceRequest,SetTagsForResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Sets tags (key and value pairs) to the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="resourceArn">The ARN of the assessment that you want to set tags to.</param>
        /// <param name="tags">A collection of key and value pairs that you want to set to an assessment.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTagsForResource service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<SetTagsForResourceResponse> SetTagsForResourceAsync(string resourceArn, List<Tag> tags, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SetTagsForResourceRequest();
            request.ResourceArn = resourceArn;
            request.Tags = tags;
            return SetTagsForResourceAsync(request, cancellationToken);
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
        public Task<SetTagsForResourceResponse> SetTagsForResourceAsync(SetTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetTagsForResourceRequestMarshaller();
            var unmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<SetTagsForResourceRequest,SetTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartDataCollection

        internal StartDataCollectionResponse StartDataCollection(StartDataCollectionRequest request)
        {
            var marshaller = new StartDataCollectionRequestMarshaller();
            var unmarshaller = StartDataCollectionResponseUnmarshaller.Instance;

            return Invoke<StartDataCollectionRequest,StartDataCollectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Starts data collection for the assessment specified by the assessment ARN. For this
        /// API to function properly, you must not exceed the limit of running up to 500 concurrent
        /// agents per AWS account.
        /// </summary>
        /// <param name="assessmentArn">The ARN of the assessment for which you want to start the data collection process.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDataCollection service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidCrossAccountRoleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<StartDataCollectionResponse> StartDataCollectionAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new StartDataCollectionRequest();
            request.AssessmentArn = assessmentArn;
            return StartDataCollectionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartDataCollectionResponse> StartDataCollectionAsync(StartDataCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartDataCollectionRequestMarshaller();
            var unmarshaller = StartDataCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartDataCollectionRequest,StartDataCollectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopDataCollection

        internal StopDataCollectionResponse StopDataCollection(StopDataCollectionRequest request)
        {
            var marshaller = new StopDataCollectionRequestMarshaller();
            var unmarshaller = StopDataCollectionResponseUnmarshaller.Instance;

            return Invoke<StopDataCollectionRequest,StopDataCollectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Stop data collection for the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN of the assessment for which you want to stop the data collection process.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDataCollection service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<StopDataCollectionResponse> StopDataCollectionAsync(string assessmentArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new StopDataCollectionRequest();
            request.AssessmentArn = assessmentArn;
            return StopDataCollectionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StopDataCollectionResponse> StopDataCollectionAsync(StopDataCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopDataCollectionRequestMarshaller();
            var unmarshaller = StopDataCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<StopDataCollectionRequest,StopDataCollectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication

        internal UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var marshaller = new UpdateApplicationRequestMarshaller();
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">Application ARN that you want to update.</param>
        /// <param name="applicationName">Application name that you want to update.</param>
        /// <param name="resourceGroupArn">The resource group ARN that you want to update.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.NoSuchEntityException">
        /// 
        /// </exception>
        public Task<UpdateApplicationResponse> UpdateApplicationAsync(string applicationArn, string applicationName, string resourceGroupArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateApplicationRequest();
            request.ApplicationArn = applicationArn;
            request.ApplicationName = applicationName;
            request.ResourceGroupArn = resourceGroupArn;
            return UpdateApplicationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateApplicationRequestMarshaller();
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssessment

        internal UpdateAssessmentResponse UpdateAssessment(UpdateAssessmentRequest request)
        {
            var marshaller = new UpdateAssessmentRequestMarshaller();
            var unmarshaller = UpdateAssessmentResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentRequest,UpdateAssessmentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateAssessmentResponse> UpdateAssessmentAsync(UpdateAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAssessmentRequestMarshaller();
            var unmarshaller = UpdateAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssessmentRequest,UpdateAssessmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}