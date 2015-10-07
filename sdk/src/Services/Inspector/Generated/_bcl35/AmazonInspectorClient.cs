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
    /// AWS and to identify potential security issues. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_introduction.html">
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
        /// Assigns attributes (key and value pair) to the findings specified by the findings'
        /// ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings service method.</param>
        /// 
        /// <returns>The response from the AddAttributesToFindings service method, as returned by Inspector.</returns>
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
        public AddAttributesToFindingsResponse AddAttributesToFindings(AddAttributesToFindingsRequest request)
        {
            var marshaller = new AddAttributesToFindingsRequestMarshaller();
            var unmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return Invoke<AddAttributesToFindingsRequest,AddAttributesToFindingsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginAddAttributesToFindings(AddAttributesToFindingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddAttributesToFindingsRequestMarshaller();
            var unmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return BeginInvoke<AddAttributesToFindingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddAttributesToFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddAttributesToFindings.</param>
        /// 
        /// <returns>Returns a  AddAttributesToFindingsResult from Inspector.</returns>
        public  AddAttributesToFindingsResponse EndAddAttributesToFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<AddAttributesToFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachAssessmentAndRulesPackage

        /// <summary>
        /// Attaches the rules package specified by the rules package ARN to the assessment specified
        /// by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachAssessmentAndRulesPackage service method.</param>
        /// 
        /// <returns>The response from the AttachAssessmentAndRulesPackage service method, as returned by Inspector.</returns>
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
        public AttachAssessmentAndRulesPackageResponse AttachAssessmentAndRulesPackage(AttachAssessmentAndRulesPackageRequest request)
        {
            var marshaller = new AttachAssessmentAndRulesPackageRequestMarshaller();
            var unmarshaller = AttachAssessmentAndRulesPackageResponseUnmarshaller.Instance;

            return Invoke<AttachAssessmentAndRulesPackageRequest,AttachAssessmentAndRulesPackageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachAssessmentAndRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachAssessmentAndRulesPackage operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachAssessmentAndRulesPackage
        ///         operation.</returns>
        public IAsyncResult BeginAttachAssessmentAndRulesPackage(AttachAssessmentAndRulesPackageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachAssessmentAndRulesPackageRequestMarshaller();
            var unmarshaller = AttachAssessmentAndRulesPackageResponseUnmarshaller.Instance;

            return BeginInvoke<AttachAssessmentAndRulesPackageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachAssessmentAndRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachAssessmentAndRulesPackage.</param>
        /// 
        /// <returns>Returns a  AttachAssessmentAndRulesPackageResult from Inspector.</returns>
        public  AttachAssessmentAndRulesPackageResponse EndAttachAssessmentAndRulesPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachAssessmentAndRulesPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApplication

        /// <summary>
        /// Creates a new application using the resource group ARN generated by <a>CreateResourceGroup</a>.
        /// You can create up to 50 applications per AWS account. You can run up to 500 concurrent
        /// agents per AWS account. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">
        /// Inspector Applications.</a>
        /// </summary>
        /// <param name="applicationName">The user-defined name identifying the application that you want to create. The name must be unique within the AWS account.</param>
        /// <param name="resourceGroupArn">The ARN specifying the resource group that is used to create the application.</param>
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
        public CreateApplicationResponse CreateApplication(string applicationName, string resourceGroupArn)
        {
            var request = new CreateApplicationRequest();
            request.ApplicationName = applicationName;
            request.ResourceGroupArn = resourceGroupArn;
            return CreateApplication(request);
        }


        /// <summary>
        /// Creates a new application using the resource group ARN generated by <a>CreateResourceGroup</a>.
        /// You can create up to 50 applications per AWS account. You can run up to 500 concurrent
        /// agents per AWS account. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">
        /// Inspector Applications.</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
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
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var marshaller = new CreateApplicationRequestMarshaller();
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        public IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateApplicationRequestMarshaller();
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from Inspector.</returns>
        public  CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssessment

        /// <summary>
        /// Creates an assessment for the application specified by the application ARN. You can
        /// create up to 500 assessments per AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment service method.</param>
        /// 
        /// <returns>The response from the CreateAssessment service method, as returned by Inspector.</returns>
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
        public CreateAssessmentResponse CreateAssessment(CreateAssessmentRequest request)
        {
            var marshaller = new CreateAssessmentRequestMarshaller();
            var unmarshaller = CreateAssessmentResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentRequest,CreateAssessmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssessment
        ///         operation.</returns>
        public IAsyncResult BeginCreateAssessment(CreateAssessmentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateAssessmentRequestMarshaller();
            var unmarshaller = CreateAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAssessmentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssessment.</param>
        /// 
        /// <returns>Returns a  CreateAssessmentResult from Inspector.</returns>
        public  CreateAssessmentResponse EndCreateAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateResourceGroup

        /// <summary>
        /// Creates a resource group using the specified set of tags (key and value pairs) that
        /// are used to select the EC2 instances to be included in an Inspector application. The
        /// created resource group is then used to create an Inspector application.
        /// </summary>
        /// <param name="resourceGroupTags">A collection of keys and an array of possible values in JSON format. For example, [{ "key1" : ["Value1","Value2"]},{"Key2": ["Value3"]}]</param>
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
        public CreateResourceGroupResponse CreateResourceGroup(string resourceGroupTags)
        {
            var request = new CreateResourceGroupRequest();
            request.ResourceGroupTags = resourceGroupTags;
            return CreateResourceGroup(request);
        }


        /// <summary>
        /// Creates a resource group using the specified set of tags (key and value pairs) that
        /// are used to select the EC2 instances to be included in an Inspector application. The
        /// created resource group is then used to create an Inspector application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup service method.</param>
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
        public CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request)
        {
            var marshaller = new CreateResourceGroupRequestMarshaller();
            var unmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return Invoke<CreateResourceGroupRequest,CreateResourceGroupResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginCreateResourceGroup(CreateResourceGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateResourceGroupRequestMarshaller();
            var unmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateResourceGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceGroup.</param>
        /// 
        /// <returns>Returns a  CreateResourceGroupResult from Inspector.</returns>
        public  CreateResourceGroupResponse EndCreateResourceGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplication

        /// <summary>
        /// Deletes the application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">The ARN specifying the application that you want to delete.</param>
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
        public DeleteApplicationResponse DeleteApplication(string applicationArn)
        {
            var request = new DeleteApplicationRequest();
            request.ApplicationArn = applicationArn;
            return DeleteApplication(request);
        }


        /// <summary>
        /// Deletes the application specified by the application ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
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
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var marshaller = new DeleteApplicationRequestMarshaller();
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        public IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteApplicationRequestMarshaller();
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from Inspector.</returns>
        public  DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssessment

        /// <summary>
        /// Deletes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment that you want to delete.</param>
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
        public DeleteAssessmentResponse DeleteAssessment(string assessmentArn)
        {
            var request = new DeleteAssessmentRequest();
            request.AssessmentArn = assessmentArn;
            return DeleteAssessment(request);
        }


        /// <summary>
        /// Deletes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment service method.</param>
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
        public DeleteAssessmentResponse DeleteAssessment(DeleteAssessmentRequest request)
        {
            var marshaller = new DeleteAssessmentRequestMarshaller();
            var unmarshaller = DeleteAssessmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentRequest,DeleteAssessmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessment
        ///         operation.</returns>
        public IAsyncResult BeginDeleteAssessment(DeleteAssessmentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteAssessmentRequestMarshaller();
            var unmarshaller = DeleteAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAssessmentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessment.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentResult from Inspector.</returns>
        public  DeleteAssessmentResponse EndDeleteAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRun

        /// <summary>
        /// Deletes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="runArn">The ARN specifying the assessment run that you want to delete.</param>
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
        public DeleteRunResponse DeleteRun(string runArn)
        {
            var request = new DeleteRunRequest();
            request.RunArn = runArn;
            return DeleteRun(request);
        }


        /// <summary>
        /// Deletes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun service method.</param>
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
        public DeleteRunResponse DeleteRun(DeleteRunRequest request)
        {
            var marshaller = new DeleteRunRequestMarshaller();
            var unmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return Invoke<DeleteRunRequest,DeleteRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRun
        ///         operation.</returns>
        public IAsyncResult BeginDeleteRun(DeleteRunRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteRunRequestMarshaller();
            var unmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRunRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRun.</param>
        /// 
        /// <returns>Returns a  DeleteRunResult from Inspector.</returns>
        public  DeleteRunResponse EndDeleteRun(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRunResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplication

        /// <summary>
        /// Describes the application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">The ARN specifying the application that you want to describe.</param>
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
        public DescribeApplicationResponse DescribeApplication(string applicationArn)
        {
            var request = new DescribeApplicationRequest();
            request.ApplicationArn = applicationArn;
            return DescribeApplication(request);
        }


        /// <summary>
        /// Describes the application specified by the application ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
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
        public DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var marshaller = new DescribeApplicationRequestMarshaller();
            var unmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationRequest,DescribeApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplication
        ///         operation.</returns>
        public IAsyncResult BeginDescribeApplication(DescribeApplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeApplicationRequestMarshaller();
            var unmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplication.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationResult from Inspector.</returns>
        public  DescribeApplicationResponse EndDescribeApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAssessment

        /// <summary>
        /// Describes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment that you want to describe.</param>
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
        public DescribeAssessmentResponse DescribeAssessment(string assessmentArn)
        {
            var request = new DescribeAssessmentRequest();
            request.AssessmentArn = assessmentArn;
            return DescribeAssessment(request);
        }


        /// <summary>
        /// Describes the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessment service method.</param>
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
        public DescribeAssessmentResponse DescribeAssessment(DescribeAssessmentRequest request)
        {
            var marshaller = new DescribeAssessmentRequestMarshaller();
            var unmarshaller = DescribeAssessmentResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentRequest,DescribeAssessmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessment operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssessment
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAssessment(DescribeAssessmentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAssessmentRequestMarshaller();
            var unmarshaller = DescribeAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAssessmentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssessment.</param>
        /// 
        /// <returns>Returns a  DescribeAssessmentResult from Inspector.</returns>
        public  DescribeAssessmentResponse EndDescribeAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCrossAccountAccessRole

        /// <summary>
        /// Describes the IAM role that enables Inspector to access your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole service method.</param>
        /// 
        /// <returns>The response from the DescribeCrossAccountAccessRole service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        public DescribeCrossAccountAccessRoleResponse DescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request)
        {
            var marshaller = new DescribeCrossAccountAccessRoleRequestMarshaller();
            var unmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<DescribeCrossAccountAccessRoleRequest,DescribeCrossAccountAccessRoleResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeCrossAccountAccessRoleRequestMarshaller();
            var unmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeCrossAccountAccessRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCrossAccountAccessRole.</param>
        /// 
        /// <returns>Returns a  DescribeCrossAccountAccessRoleResult from Inspector.</returns>
        public  DescribeCrossAccountAccessRoleResponse EndDescribeCrossAccountAccessRole(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCrossAccountAccessRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFinding

        /// <summary>
        /// Describes the finding specified by the finding ARN.
        /// </summary>
        /// <param name="findingArn">The ARN specifying the finding that you want to describe.</param>
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
        public DescribeFindingResponse DescribeFinding(string findingArn)
        {
            var request = new DescribeFindingRequest();
            request.FindingArn = findingArn;
            return DescribeFinding(request);
        }


        /// <summary>
        /// Describes the finding specified by the finding ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFinding service method.</param>
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
        public DescribeFindingResponse DescribeFinding(DescribeFindingRequest request)
        {
            var marshaller = new DescribeFindingRequestMarshaller();
            var unmarshaller = DescribeFindingResponseUnmarshaller.Instance;

            return Invoke<DescribeFindingRequest,DescribeFindingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFinding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFinding operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFinding
        ///         operation.</returns>
        public IAsyncResult BeginDescribeFinding(DescribeFindingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeFindingRequestMarshaller();
            var unmarshaller = DescribeFindingResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeFindingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFinding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFinding.</param>
        /// 
        /// <returns>Returns a  DescribeFindingResult from Inspector.</returns>
        public  DescribeFindingResponse EndDescribeFinding(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFindingResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeResourceGroup

        /// <summary>
        /// Describes the resource group specified by the resource group ARN.
        /// </summary>
        /// <param name="resourceGroupArn">The ARN specifying the resource group that you want to describe.</param>
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
        public DescribeResourceGroupResponse DescribeResourceGroup(string resourceGroupArn)
        {
            var request = new DescribeResourceGroupRequest();
            request.ResourceGroupArn = resourceGroupArn;
            return DescribeResourceGroup(request);
        }


        /// <summary>
        /// Describes the resource group specified by the resource group ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroup service method.</param>
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
        public DescribeResourceGroupResponse DescribeResourceGroup(DescribeResourceGroupRequest request)
        {
            var marshaller = new DescribeResourceGroupRequestMarshaller();
            var unmarshaller = DescribeResourceGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceGroupRequest,DescribeResourceGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroup operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourceGroup
        ///         operation.</returns>
        public IAsyncResult BeginDescribeResourceGroup(DescribeResourceGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeResourceGroupRequestMarshaller();
            var unmarshaller = DescribeResourceGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeResourceGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourceGroup.</param>
        /// 
        /// <returns>Returns a  DescribeResourceGroupResult from Inspector.</returns>
        public  DescribeResourceGroupResponse EndDescribeResourceGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResourceGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRulesPackage

        /// <summary>
        /// Describes the rules package specified by the rules package ARN.
        /// </summary>
        /// <param name="rulesPackageArn">The ARN specifying the rules package that you want to describe.</param>
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
        public DescribeRulesPackageResponse DescribeRulesPackage(string rulesPackageArn)
        {
            var request = new DescribeRulesPackageRequest();
            request.RulesPackageArn = rulesPackageArn;
            return DescribeRulesPackage(request);
        }


        /// <summary>
        /// Describes the rules package specified by the rules package ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackage service method.</param>
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
        public DescribeRulesPackageResponse DescribeRulesPackage(DescribeRulesPackageRequest request)
        {
            var marshaller = new DescribeRulesPackageRequestMarshaller();
            var unmarshaller = DescribeRulesPackageResponseUnmarshaller.Instance;

            return Invoke<DescribeRulesPackageRequest,DescribeRulesPackageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackage operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRulesPackage
        ///         operation.</returns>
        public IAsyncResult BeginDescribeRulesPackage(DescribeRulesPackageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeRulesPackageRequestMarshaller();
            var unmarshaller = DescribeRulesPackageResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeRulesPackageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRulesPackage.</param>
        /// 
        /// <returns>Returns a  DescribeRulesPackageResult from Inspector.</returns>
        public  DescribeRulesPackageResponse EndDescribeRulesPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRulesPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRun

        /// <summary>
        /// Describes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="runArn">The ARN specifying the assessment run that you want to describe.</param>
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
        public DescribeRunResponse DescribeRun(string runArn)
        {
            var request = new DescribeRunRequest();
            request.RunArn = runArn;
            return DescribeRun(request);
        }


        /// <summary>
        /// Describes the assessment run specified by the run ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRun service method.</param>
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
        public DescribeRunResponse DescribeRun(DescribeRunRequest request)
        {
            var marshaller = new DescribeRunRequestMarshaller();
            var unmarshaller = DescribeRunResponseUnmarshaller.Instance;

            return Invoke<DescribeRunRequest,DescribeRunResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRun operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRun
        ///         operation.</returns>
        public IAsyncResult BeginDescribeRun(DescribeRunRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeRunRequestMarshaller();
            var unmarshaller = DescribeRunResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeRunRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRun.</param>
        /// 
        /// <returns>Returns a  DescribeRunResult from Inspector.</returns>
        public  DescribeRunResponse EndDescribeRun(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRunResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachAssessmentAndRulesPackage

        /// <summary>
        /// Detaches the rules package specified by the rules package ARN from the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment from which you want to detach a rules package.</param>
        /// <param name="rulesPackageArn">The ARN specifying the rules package that you want to detach from the assessment.</param>
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
        public DetachAssessmentAndRulesPackageResponse DetachAssessmentAndRulesPackage(string assessmentArn, string rulesPackageArn)
        {
            var request = new DetachAssessmentAndRulesPackageRequest();
            request.AssessmentArn = assessmentArn;
            request.RulesPackageArn = rulesPackageArn;
            return DetachAssessmentAndRulesPackage(request);
        }


        /// <summary>
        /// Detaches the rules package specified by the rules package ARN from the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachAssessmentAndRulesPackage service method.</param>
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
        public DetachAssessmentAndRulesPackageResponse DetachAssessmentAndRulesPackage(DetachAssessmentAndRulesPackageRequest request)
        {
            var marshaller = new DetachAssessmentAndRulesPackageRequestMarshaller();
            var unmarshaller = DetachAssessmentAndRulesPackageResponseUnmarshaller.Instance;

            return Invoke<DetachAssessmentAndRulesPackageRequest,DetachAssessmentAndRulesPackageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachAssessmentAndRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachAssessmentAndRulesPackage operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachAssessmentAndRulesPackage
        ///         operation.</returns>
        public IAsyncResult BeginDetachAssessmentAndRulesPackage(DetachAssessmentAndRulesPackageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachAssessmentAndRulesPackageRequestMarshaller();
            var unmarshaller = DetachAssessmentAndRulesPackageResponseUnmarshaller.Instance;

            return BeginInvoke<DetachAssessmentAndRulesPackageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachAssessmentAndRulesPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachAssessmentAndRulesPackage.</param>
        /// 
        /// <returns>Returns a  DetachAssessmentAndRulesPackageResult from Inspector.</returns>
        public  DetachAssessmentAndRulesPackageResponse EndDetachAssessmentAndRulesPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachAssessmentAndRulesPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssessmentTelemetry

        /// <summary>
        /// Returns the metadata about the telemetry (application behavioral data) for the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment the telemetry of which you want to obtain.</param>
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
        public GetAssessmentTelemetryResponse GetAssessmentTelemetry(string assessmentArn)
        {
            var request = new GetAssessmentTelemetryRequest();
            request.AssessmentArn = assessmentArn;
            return GetAssessmentTelemetry(request);
        }


        /// <summary>
        /// Returns the metadata about the telemetry (application behavioral data) for the assessment
        /// specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentTelemetry service method.</param>
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
        public GetAssessmentTelemetryResponse GetAssessmentTelemetry(GetAssessmentTelemetryRequest request)
        {
            var marshaller = new GetAssessmentTelemetryRequestMarshaller();
            var unmarshaller = GetAssessmentTelemetryResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentTelemetryRequest,GetAssessmentTelemetryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessmentTelemetry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentTelemetry operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssessmentTelemetry
        ///         operation.</returns>
        public IAsyncResult BeginGetAssessmentTelemetry(GetAssessmentTelemetryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetAssessmentTelemetryRequestMarshaller();
            var unmarshaller = GetAssessmentTelemetryResponseUnmarshaller.Instance;

            return BeginInvoke<GetAssessmentTelemetryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssessmentTelemetry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssessmentTelemetry.</param>
        /// 
        /// <returns>Returns a  GetAssessmentTelemetryResult from Inspector.</returns>
        public  GetAssessmentTelemetryResponse EndGetAssessmentTelemetry(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssessmentTelemetryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplications

        /// <summary>
        /// Lists the ARNs of the applications within this AWS account. For more information about
        /// applications, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">Inspector
        /// Applications</a>.
        /// </summary>
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
        public ListApplicationsResponse ListApplications()
        {
            var request = new ListApplicationsRequest();
            return ListApplications(request);
        }


        /// <summary>
        /// Lists the ARNs of the applications within this AWS account. For more information about
        /// applications, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">Inspector
        /// Applications</a>.
        /// </summary>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
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
        public ListApplicationsResponse ListApplications(ApplicationsFilter filter)
        {
            var request = new ListApplicationsRequest();
            request.Filter = filter;
            return ListApplications(request);
        }


        /// <summary>
        /// Lists the ARNs of the applications within this AWS account. For more information about
        /// applications, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide//inspector_applications.html">Inspector
        /// Applications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
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
        public ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var marshaller = new ListApplicationsRequestMarshaller();
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsRequest,ListApplicationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        public IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListApplicationsRequestMarshaller();
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListApplicationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from Inspector.</returns>
        public  ListApplicationsResponse EndListApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssessmentAgents

        /// <summary>
        /// Lists the agents of the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment whose agents you want to list.</param>
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
        public ListAssessmentAgentsResponse ListAssessmentAgents(string assessmentArn)
        {
            var request = new ListAssessmentAgentsRequest();
            request.AssessmentArn = assessmentArn;
            return ListAssessmentAgents(request);
        }


        /// <summary>
        /// Lists the agents of the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN specifying the assessment whose agents you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
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
        public ListAssessmentAgentsResponse ListAssessmentAgents(string assessmentArn, AgentsFilter filter)
        {
            var request = new ListAssessmentAgentsRequest();
            request.AssessmentArn = assessmentArn;
            request.Filter = filter;
            return ListAssessmentAgents(request);
        }


        /// <summary>
        /// Lists the agents of the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentAgents service method.</param>
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
        public ListAssessmentAgentsResponse ListAssessmentAgents(ListAssessmentAgentsRequest request)
        {
            var marshaller = new ListAssessmentAgentsRequestMarshaller();
            var unmarshaller = ListAssessmentAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentAgentsRequest,ListAssessmentAgentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentAgents operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentAgents
        ///         operation.</returns>
        public IAsyncResult BeginListAssessmentAgents(ListAssessmentAgentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAssessmentAgentsRequestMarshaller();
            var unmarshaller = ListAssessmentAgentsResponseUnmarshaller.Instance;

            return BeginInvoke<ListAssessmentAgentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentAgents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentAgents.</param>
        /// 
        /// <returns>Returns a  ListAssessmentAgentsResult from Inspector.</returns>
        public  ListAssessmentAgentsResponse EndListAssessmentAgents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssessmentAgentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssessments

        /// <summary>
        /// Lists the assessments corresponding to applications specified by the applications'
        /// ARNs.
        /// </summary>
        /// <param name="applicationArns">A list of ARNs specifying the applications the assessments of which you want to list.</param>
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
        public ListAssessmentsResponse ListAssessments(List<string> applicationArns)
        {
            var request = new ListAssessmentsRequest();
            request.ApplicationArns = applicationArns;
            return ListAssessments(request);
        }


        /// <summary>
        /// Lists the assessments corresponding to applications specified by the applications'
        /// ARNs.
        /// </summary>
        /// <param name="applicationArns">A list of ARNs specifying the applications the assessments of which you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
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
        public ListAssessmentsResponse ListAssessments(List<string> applicationArns, AssessmentsFilter filter)
        {
            var request = new ListAssessmentsRequest();
            request.ApplicationArns = applicationArns;
            request.Filter = filter;
            return ListAssessments(request);
        }


        /// <summary>
        /// Lists the assessments corresponding to applications specified by the applications'
        /// ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments service method.</param>
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
        public ListAssessmentsResponse ListAssessments(ListAssessmentsRequest request)
        {
            var marshaller = new ListAssessmentsRequestMarshaller();
            var unmarshaller = ListAssessmentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentsRequest,ListAssessmentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessments
        ///         operation.</returns>
        public IAsyncResult BeginListAssessments(ListAssessmentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAssessmentsRequestMarshaller();
            var unmarshaller = ListAssessmentsResponseUnmarshaller.Instance;

            return BeginInvoke<ListAssessmentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessments.</param>
        /// 
        /// <returns>Returns a  ListAssessmentsResult from Inspector.</returns>
        public  ListAssessmentsResponse EndListAssessments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssessmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttachedAssessments

        /// <summary>
        /// Lists the assessments attached to the rules package specified by the rules package
        /// ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedAssessments service method.</param>
        /// 
        /// <returns>The response from the ListAttachedAssessments service method, as returned by Inspector.</returns>
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
        public ListAttachedAssessmentsResponse ListAttachedAssessments(ListAttachedAssessmentsRequest request)
        {
            var marshaller = new ListAttachedAssessmentsRequestMarshaller();
            var unmarshaller = ListAttachedAssessmentsResponseUnmarshaller.Instance;

            return Invoke<ListAttachedAssessmentsRequest,ListAttachedAssessmentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedAssessments operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedAssessments
        ///         operation.</returns>
        public IAsyncResult BeginListAttachedAssessments(ListAttachedAssessmentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAttachedAssessmentsRequestMarshaller();
            var unmarshaller = ListAttachedAssessmentsResponseUnmarshaller.Instance;

            return BeginInvoke<ListAttachedAssessmentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedAssessments.</param>
        /// 
        /// <returns>Returns a  ListAttachedAssessmentsResult from Inspector.</returns>
        public  ListAttachedAssessmentsResponse EndListAttachedAssessments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttachedAssessmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttachedRulesPackages

        /// <summary>
        /// Lists the rules packages attached to the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRulesPackages service method.</param>
        /// 
        /// <returns>The response from the ListAttachedRulesPackages service method, as returned by Inspector.</returns>
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
        public ListAttachedRulesPackagesResponse ListAttachedRulesPackages(ListAttachedRulesPackagesRequest request)
        {
            var marshaller = new ListAttachedRulesPackagesRequestMarshaller();
            var unmarshaller = ListAttachedRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedRulesPackagesRequest,ListAttachedRulesPackagesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRulesPackages operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedRulesPackages
        ///         operation.</returns>
        public IAsyncResult BeginListAttachedRulesPackages(ListAttachedRulesPackagesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAttachedRulesPackagesRequestMarshaller();
            var unmarshaller = ListAttachedRulesPackagesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAttachedRulesPackagesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedRulesPackages.</param>
        /// 
        /// <returns>Returns a  ListAttachedRulesPackagesResult from Inspector.</returns>
        public  ListAttachedRulesPackagesResponse EndListAttachedRulesPackages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttachedRulesPackagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFindings

        /// <summary>
        /// Lists findings generated by the assessment run specified by the run ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Inspector.</returns>
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
        public ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var marshaller = new ListFindingsRequestMarshaller();
            var unmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsRequest,ListFindingsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListFindings(ListFindingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListFindingsRequestMarshaller();
            var unmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return BeginInvoke<ListFindingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindings.</param>
        /// 
        /// <returns>Returns a  ListFindingsResult from Inspector.</returns>
        public  ListFindingsResponse EndListFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRulesPackages

        /// <summary>
        /// Lists all available Inspector rules packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages service method.</param>
        /// 
        /// <returns>The response from the ListRulesPackages service method, as returned by Inspector.</returns>
        /// <exception cref="Amazon.Inspector.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InternalException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Inspector.Model.InvalidInputException">
        /// 
        /// </exception>
        public ListRulesPackagesResponse ListRulesPackages(ListRulesPackagesRequest request)
        {
            var marshaller = new ListRulesPackagesRequestMarshaller();
            var unmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<ListRulesPackagesRequest,ListRulesPackagesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListRulesPackages(ListRulesPackagesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListRulesPackagesRequestMarshaller();
            var unmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return BeginInvoke<ListRulesPackagesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRulesPackages.</param>
        /// 
        /// <returns>Returns a  ListRulesPackagesResult from Inspector.</returns>
        public  ListRulesPackagesResponse EndListRulesPackages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRulesPackagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuns

        /// <summary>
        /// Lists the assessment runs associated with the assessments specified by the assessment
        /// ARNs.
        /// </summary>
        /// <param name="assessmentArns">The ARNs specifying the assessments whose runs you want to list.</param>
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
        public ListRunsResponse ListRuns(List<string> assessmentArns)
        {
            var request = new ListRunsRequest();
            request.AssessmentArns = assessmentArns;
            return ListRuns(request);
        }


        /// <summary>
        /// Lists the assessment runs associated with the assessments specified by the assessment
        /// ARNs.
        /// </summary>
        /// <param name="assessmentArns">The ARNs specifying the assessments whose runs you want to list.</param>
        /// <param name="filter">You can use this parameter to specify a subset of data to be included in the action's response. For a record to match a filter, all specified filter attributes must match. When multiple values are specified for a filter attribute, any of the values can match.</param>
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
        public ListRunsResponse ListRuns(List<string> assessmentArns, RunsFilter filter)
        {
            var request = new ListRunsRequest();
            request.AssessmentArns = assessmentArns;
            request.Filter = filter;
            return ListRuns(request);
        }


        /// <summary>
        /// Lists the assessment runs associated with the assessments specified by the assessment
        /// ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuns service method.</param>
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
        public ListRunsResponse ListRuns(ListRunsRequest request)
        {
            var marshaller = new ListRunsRequestMarshaller();
            var unmarshaller = ListRunsResponseUnmarshaller.Instance;

            return Invoke<ListRunsRequest,ListRunsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuns operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuns
        ///         operation.</returns>
        public IAsyncResult BeginListRuns(ListRunsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListRunsRequestMarshaller();
            var unmarshaller = ListRunsResponseUnmarshaller.Instance;

            return BeginInvoke<ListRunsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuns.</param>
        /// 
        /// <returns>Returns a  ListRunsResult from Inspector.</returns>
        public  ListRunsResponse EndListRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags associated with a resource.
        /// </summary>
        /// <param name="resourceArn">The ARN specifying the resource whose tags you want to list.</param>
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
        public ListTagsForResourceResponse ListTagsForResource(string resourceArn)
        {
            var request = new ListTagsForResourceRequest();
            request.ResourceArn = resourceArn;
            return ListTagsForResource(request);
        }


        /// <summary>
        /// Lists all tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Inspector.</returns>
        public  ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  LocalizeText

        /// <summary>
        /// Translates a textual identifier into a user-readable text in a specified locale.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LocalizeText service method.</param>
        /// 
        /// <returns>The response from the LocalizeText service method, as returned by Inspector.</returns>
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
        public LocalizeTextResponse LocalizeText(LocalizeTextRequest request)
        {
            var marshaller = new LocalizeTextRequestMarshaller();
            var unmarshaller = LocalizeTextResponseUnmarshaller.Instance;

            return Invoke<LocalizeTextRequest,LocalizeTextResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the LocalizeText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LocalizeText operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLocalizeText
        ///         operation.</returns>
        public IAsyncResult BeginLocalizeText(LocalizeTextRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new LocalizeTextRequestMarshaller();
            var unmarshaller = LocalizeTextResponseUnmarshaller.Instance;

            return BeginInvoke<LocalizeTextRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  LocalizeText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLocalizeText.</param>
        /// 
        /// <returns>Returns a  LocalizeTextResult from Inspector.</returns>
        public  LocalizeTextResponse EndLocalizeText(IAsyncResult asyncResult)
        {
            return EndInvoke<LocalizeTextResponse>(asyncResult);
        }

        #endregion
        
        #region  PreviewAgentsForResourceGroup

        /// <summary>
        /// Previews the agents installed on the EC2 instances that are included in the application
        /// created with the specified resource group.
        /// </summary>
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
        public PreviewAgentsForResourceGroupResponse PreviewAgentsForResourceGroup()
        {
            var request = new PreviewAgentsForResourceGroupRequest();
            return PreviewAgentsForResourceGroup(request);
        }


        /// <summary>
        /// Previews the agents installed on the EC2 instances that are included in the application
        /// created with the specified resource group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgentsForResourceGroup service method.</param>
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
        public PreviewAgentsForResourceGroupResponse PreviewAgentsForResourceGroup(PreviewAgentsForResourceGroupRequest request)
        {
            var marshaller = new PreviewAgentsForResourceGroupRequestMarshaller();
            var unmarshaller = PreviewAgentsForResourceGroupResponseUnmarshaller.Instance;

            return Invoke<PreviewAgentsForResourceGroupRequest,PreviewAgentsForResourceGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PreviewAgentsForResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgentsForResourceGroup operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPreviewAgentsForResourceGroup
        ///         operation.</returns>
        public IAsyncResult BeginPreviewAgentsForResourceGroup(PreviewAgentsForResourceGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PreviewAgentsForResourceGroupRequestMarshaller();
            var unmarshaller = PreviewAgentsForResourceGroupResponseUnmarshaller.Instance;

            return BeginInvoke<PreviewAgentsForResourceGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PreviewAgentsForResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPreviewAgentsForResourceGroup.</param>
        /// 
        /// <returns>Returns a  PreviewAgentsForResourceGroupResult from Inspector.</returns>
        public  PreviewAgentsForResourceGroupResponse EndPreviewAgentsForResourceGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<PreviewAgentsForResourceGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterCrossAccountAccessRole

        /// <summary>
        /// Register the role that Inspector uses to list your EC2 instances during the assessment.
        /// </summary>
        /// <param name="roleArn">The ARN of the IAM role that Inspector uses to list your EC2 instances during the assessment.</param>
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
        public RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(string roleArn)
        {
            var request = new RegisterCrossAccountAccessRoleRequest();
            request.RoleArn = roleArn;
            return RegisterCrossAccountAccessRole(request);
        }


        /// <summary>
        /// Register the role that Inspector uses to list your EC2 instances during the assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole service method.</param>
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
        public RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request)
        {
            var marshaller = new RegisterCrossAccountAccessRoleRequestMarshaller();
            var unmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<RegisterCrossAccountAccessRoleRequest,RegisterCrossAccountAccessRoleResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginRegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterCrossAccountAccessRoleRequestMarshaller();
            var unmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterCrossAccountAccessRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterCrossAccountAccessRole.</param>
        /// 
        /// <returns>Returns a  RegisterCrossAccountAccessRoleResult from Inspector.</returns>
        public  RegisterCrossAccountAccessRoleResponse EndRegisterCrossAccountAccessRole(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterCrossAccountAccessRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveAttributesFromFindings

        /// <summary>
        /// Removes the entire attribute (key and value pair) from the findings specified by the
        /// finding ARNs where an attribute with the specified key exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings service method.</param>
        /// 
        /// <returns>The response from the RemoveAttributesFromFindings service method, as returned by Inspector.</returns>
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
        public RemoveAttributesFromFindingsResponse RemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request)
        {
            var marshaller = new RemoveAttributesFromFindingsRequestMarshaller();
            var unmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return Invoke<RemoveAttributesFromFindingsRequest,RemoveAttributesFromFindingsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginRemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemoveAttributesFromFindingsRequestMarshaller();
            var unmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveAttributesFromFindingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAttributesFromFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAttributesFromFindings.</param>
        /// 
        /// <returns>Returns a  RemoveAttributesFromFindingsResult from Inspector.</returns>
        public  RemoveAttributesFromFindingsResponse EndRemoveAttributesFromFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveAttributesFromFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  RunAssessment

        /// <summary>
        /// Starts the analysis of the application’s behavior against selected rule packages for
        /// the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="runName">A name specifying the run of the assessment.</param>
        /// <param name="assessmentArn">The ARN of the assessment that you want to run.</param>
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
        public RunAssessmentResponse RunAssessment(string runName, string assessmentArn)
        {
            var request = new RunAssessmentRequest();
            request.RunName = runName;
            request.AssessmentArn = assessmentArn;
            return RunAssessment(request);
        }


        /// <summary>
        /// Starts the analysis of the application’s behavior against selected rule packages for
        /// the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunAssessment service method.</param>
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
        public RunAssessmentResponse RunAssessment(RunAssessmentRequest request)
        {
            var marshaller = new RunAssessmentRequestMarshaller();
            var unmarshaller = RunAssessmentResponseUnmarshaller.Instance;

            return Invoke<RunAssessmentRequest,RunAssessmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RunAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunAssessment operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunAssessment
        ///         operation.</returns>
        public IAsyncResult BeginRunAssessment(RunAssessmentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RunAssessmentRequestMarshaller();
            var unmarshaller = RunAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke<RunAssessmentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RunAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunAssessment.</param>
        /// 
        /// <returns>Returns a  RunAssessmentResult from Inspector.</returns>
        public  RunAssessmentResponse EndRunAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<RunAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  SetTagsForResource

        /// <summary>
        /// Sets tags (key and value pairs) to the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="resourceArn">The ARN of the assessment that you want to set tags to.</param>
        /// <param name="tags">A collection of key and value pairs that you want to set to an assessment.</param>
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
        public SetTagsForResourceResponse SetTagsForResource(string resourceArn, List<Tag> tags)
        {
            var request = new SetTagsForResourceRequest();
            request.ResourceArn = resourceArn;
            request.Tags = tags;
            return SetTagsForResource(request);
        }


        /// <summary>
        /// Sets tags (key and value pairs) to the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource service method.</param>
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
        public SetTagsForResourceResponse SetTagsForResource(SetTagsForResourceRequest request)
        {
            var marshaller = new SetTagsForResourceRequestMarshaller();
            var unmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<SetTagsForResourceRequest,SetTagsForResourceResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginSetTagsForResource(SetTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetTagsForResourceRequestMarshaller();
            var unmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<SetTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTagsForResource.</param>
        /// 
        /// <returns>Returns a  SetTagsForResourceResult from Inspector.</returns>
        public  SetTagsForResourceResponse EndSetTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<SetTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDataCollection

        /// <summary>
        /// Starts data collection for the assessment specified by the assessment ARN. For this
        /// API to function properly, you must not exceed the limit of running up to 500 concurrent
        /// agents per AWS account.
        /// </summary>
        /// <param name="assessmentArn">The ARN of the assessment for which you want to start the data collection process.</param>
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
        public StartDataCollectionResponse StartDataCollection(string assessmentArn)
        {
            var request = new StartDataCollectionRequest();
            request.AssessmentArn = assessmentArn;
            return StartDataCollection(request);
        }


        /// <summary>
        /// Starts data collection for the assessment specified by the assessment ARN. For this
        /// API to function properly, you must not exceed the limit of running up to 500 concurrent
        /// agents per AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollection service method.</param>
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
        public StartDataCollectionResponse StartDataCollection(StartDataCollectionRequest request)
        {
            var marshaller = new StartDataCollectionRequestMarshaller();
            var unmarshaller = StartDataCollectionResponseUnmarshaller.Instance;

            return Invoke<StartDataCollectionRequest,StartDataCollectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollection operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataCollection
        ///         operation.</returns>
        public IAsyncResult BeginStartDataCollection(StartDataCollectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartDataCollectionRequestMarshaller();
            var unmarshaller = StartDataCollectionResponseUnmarshaller.Instance;

            return BeginInvoke<StartDataCollectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataCollection.</param>
        /// 
        /// <returns>Returns a  StartDataCollectionResult from Inspector.</returns>
        public  StartDataCollectionResponse EndStartDataCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDataCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDataCollection

        /// <summary>
        /// Stop data collection for the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="assessmentArn">The ARN of the assessment for which you want to stop the data collection process.</param>
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
        public StopDataCollectionResponse StopDataCollection(string assessmentArn)
        {
            var request = new StopDataCollectionRequest();
            request.AssessmentArn = assessmentArn;
            return StopDataCollection(request);
        }


        /// <summary>
        /// Stop data collection for the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollection service method.</param>
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
        public StopDataCollectionResponse StopDataCollection(StopDataCollectionRequest request)
        {
            var marshaller = new StopDataCollectionRequestMarshaller();
            var unmarshaller = StopDataCollectionResponseUnmarshaller.Instance;

            return Invoke<StopDataCollectionRequest,StopDataCollectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDataCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollection operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDataCollection
        ///         operation.</returns>
        public IAsyncResult BeginStopDataCollection(StopDataCollectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopDataCollectionRequestMarshaller();
            var unmarshaller = StopDataCollectionResponseUnmarshaller.Instance;

            return BeginInvoke<StopDataCollectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDataCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDataCollection.</param>
        /// 
        /// <returns>Returns a  StopDataCollectionResult from Inspector.</returns>
        public  StopDataCollectionResponse EndStopDataCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDataCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplication

        /// <summary>
        /// Updates application specified by the application ARN.
        /// </summary>
        /// <param name="applicationArn">Application ARN that you want to update.</param>
        /// <param name="applicationName">Application name that you want to update.</param>
        /// <param name="resourceGroupArn">The resource group ARN that you want to update.</param>
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
        public UpdateApplicationResponse UpdateApplication(string applicationArn, string applicationName, string resourceGroupArn)
        {
            var request = new UpdateApplicationRequest();
            request.ApplicationArn = applicationArn;
            request.ApplicationName = applicationName;
            request.ResourceGroupArn = resourceGroupArn;
            return UpdateApplication(request);
        }


        /// <summary>
        /// Updates application specified by the application ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
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
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var marshaller = new UpdateApplicationRequestMarshaller();
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        public IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateApplicationRequestMarshaller();
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from Inspector.</returns>
        public  UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssessment

        /// <summary>
        /// Updates the assessment specified by the assessment ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessment service method, as returned by Inspector.</returns>
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
        public UpdateAssessmentResponse UpdateAssessment(UpdateAssessmentRequest request)
        {
            var marshaller = new UpdateAssessmentRequestMarshaller();
            var unmarshaller = UpdateAssessmentResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentRequest,UpdateAssessmentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment operation on AmazonInspectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessment
        ///         operation.</returns>
        public IAsyncResult BeginUpdateAssessment(UpdateAssessmentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateAssessmentRequestMarshaller();
            var unmarshaller = UpdateAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAssessmentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessment.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentResult from Inspector.</returns>
        public  UpdateAssessmentResponse EndUpdateAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssessmentResponse>(asyncResult);
        }

        #endregion
        
    }
}