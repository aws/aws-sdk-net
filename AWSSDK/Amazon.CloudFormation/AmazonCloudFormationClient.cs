/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;

using Amazon.CloudFormation.Model;
using Amazon.CloudFormation.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.CloudFormation
{
    /// <summary>
    /// Implementation for accessing AmazonCloudFormation.
    ///  
    /// AWS CloudFormation <para>AWS CloudFormation enables you to create and manage AWS infrastructure deployments predictably and repeatedly. AWS
    /// CloudFormation helps you leverage AWS products such as Amazon EC2, EBS, Amazon SNS, ELB, and Auto Scaling to build highly-reliable, highly
    /// scalable, cost effective applications without worrying about creating and configuring the underlying the AWS infrastructure.</para>
    /// <para>With AWS CloudFormation, you declare all of your resources and dependencies in a template file. The template defines a collection of
    /// resources as a single unit called a stack. AWS CloudFormation creates and deletes all member resources of the stack together and manages all
    /// dependencies between the resources for you.</para> <para>For more information about this product, go to the CloudFormation Product
    /// Page.</para> <para>Amazon CloudFormation makes use of other AWS products. If you need additional technical information about a specific AWS
    /// product, you can find the product's technical documentation at http://aws.amazon.com/documentation/.</para>
    /// </summary>
    public class AmazonCloudFormationClient : AmazonWebServiceClient, AmazonCloudFormation
    {
    
        AbstractAWSSigner signer = new AWS4Signer();

        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCloudFormationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCloudFormation Configuration Object</param>
        public AmazonCloudFormationClient(AmazonCloudFormationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudFormationClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudFormationConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials and an
        /// AmazonCloudFormationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(AWSCredentials credentials, AmazonCloudFormationConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFormationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFormationConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion
   
        #region ValidateTemplate

        /// <summary>
        /// <para>Validates a specified template.</para>
        /// </summary>
        /// 
        /// <param name="validateTemplateRequest">Container for the necessary parameters to execute the ValidateTemplate service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest validateTemplateRequest)
        {
            IAsyncResult asyncResult = invokeValidateTemplate(validateTemplateRequest, null, null, true);
            return EndValidateTemplate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ValidateTemplate"/>
        /// </summary>
        /// 
        /// <param name="validateTemplateRequest">Container for the necessary parameters to execute the ValidateTemplate operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateTemplate
        ///         operation.</returns>
        public IAsyncResult BeginValidateTemplate(ValidateTemplateRequest validateTemplateRequest, AsyncCallback callback, object state)
        {
            return invokeValidateTemplate(validateTemplateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ValidateTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ValidateTemplate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateTemplate.</param>
        /// 
        /// <returns>Returns a ValidateTemplateResult from AmazonCloudFormation.</returns>
        public ValidateTemplateResponse EndValidateTemplate(IAsyncResult asyncResult)
        {
            return endOperation<ValidateTemplateResponse>(asyncResult);
        }
        
        IAsyncResult invokeValidateTemplate(ValidateTemplateRequest validateTemplateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ValidateTemplateRequestMarshaller().Marshall(validateTemplateRequest);
            var unmarshaller = ValidateTemplateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Validates a specified template.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public ValidateTemplateResponse ValidateTemplate()
        {
            return ValidateTemplate(new ValidateTemplateRequest());
        }
        

        #endregion
    
        #region DescribeStacks

        /// <summary>
        /// <para>Returns the description for the specified stack; if no stack name was specified, then it returns the description for all the stacks
        /// created.</para>
        /// </summary>
        /// 
        /// <param name="describeStacksRequest">Container for the necessary parameters to execute the DescribeStacks service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public DescribeStacksResponse DescribeStacks(DescribeStacksRequest describeStacksRequest)
        {
            IAsyncResult asyncResult = invokeDescribeStacks(describeStacksRequest, null, null, true);
            return EndDescribeStacks(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStacks"/>
        /// </summary>
        /// 
        /// <param name="describeStacksRequest">Container for the necessary parameters to execute the DescribeStacks operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStacks
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStacks(DescribeStacksRequest describeStacksRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeStacks(describeStacksRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStacks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStacks.</param>
        /// 
        /// <returns>Returns a DescribeStacksResult from AmazonCloudFormation.</returns>
        public DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult)
        {
            return endOperation<DescribeStacksResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeStacks(DescribeStacksRequest describeStacksRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStacksRequestMarshaller().Marshall(describeStacksRequest);
            var unmarshaller = DescribeStacksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns the description for the specified stack; if no stack name was specified, then it returns the description for all the stacks
        /// created.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }
        

        #endregion
    
        #region GetTemplate

        /// <summary>
        /// <para>Returns the template body for a specified stack name. You can get the template for running or deleted stacks.</para> <para>For deleted
        /// stacks, GetTemplate returns the template for up to 90 days after the stack has been deleted.</para> <para><b>NOTE:</b> If the template does
        /// not exist, a ValidationError is returned. </para>
        /// </summary>
        /// 
        /// <param name="getTemplateRequest">Container for the necessary parameters to execute the GetTemplate service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public GetTemplateResponse GetTemplate(GetTemplateRequest getTemplateRequest)
        {
            IAsyncResult asyncResult = invokeGetTemplate(getTemplateRequest, null, null, true);
            return EndGetTemplate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.GetTemplate"/>
        /// </summary>
        /// 
        /// <param name="getTemplateRequest">Container for the necessary parameters to execute the GetTemplate operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplate
        ///         operation.</returns>
        public IAsyncResult BeginGetTemplate(GetTemplateRequest getTemplateRequest, AsyncCallback callback, object state)
        {
            return invokeGetTemplate(getTemplateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.GetTemplate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplate.</param>
        /// 
        /// <returns>Returns a GetTemplateResult from AmazonCloudFormation.</returns>
        public GetTemplateResponse EndGetTemplate(IAsyncResult asyncResult)
        {
            return endOperation<GetTemplateResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetTemplate(GetTemplateRequest getTemplateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetTemplateRequestMarshaller().Marshall(getTemplateRequest);
            var unmarshaller = GetTemplateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListStacks

        /// <summary>
        /// <para>Returns the summary information for stacks whose status matches the specified StackStatusFilter. Summary information for stacks that
        /// have been deleted is kept for 90 days after the stack is deleted. If no StackStatusFilter is specified, summary information for all stacks
        /// is returned (including existing stacks and stacks that have been deleted).</para>
        /// </summary>
        /// 
        /// <param name="listStacksRequest">Container for the necessary parameters to execute the ListStacks service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public ListStacksResponse ListStacks(ListStacksRequest listStacksRequest)
        {
            IAsyncResult asyncResult = invokeListStacks(listStacksRequest, null, null, true);
            return EndListStacks(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListStacks operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ListStacks"/>
        /// </summary>
        /// 
        /// <param name="listStacksRequest">Container for the necessary parameters to execute the ListStacks operation on AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStacks
        ///         operation.</returns>
        public IAsyncResult BeginListStacks(ListStacksRequest listStacksRequest, AsyncCallback callback, object state)
        {
            return invokeListStacks(listStacksRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListStacks operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ListStacks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStacks.</param>
        /// 
        /// <returns>Returns a ListStacksResult from AmazonCloudFormation.</returns>
        public ListStacksResponse EndListStacks(IAsyncResult asyncResult)
        {
            return endOperation<ListStacksResponse>(asyncResult);
        }
        
        IAsyncResult invokeListStacks(ListStacksRequest listStacksRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListStacksRequestMarshaller().Marshall(listStacksRequest);
            var unmarshaller = ListStacksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns the summary information for stacks whose status matches the specified StackStatusFilter. Summary information for stacks that
        /// have been deleted is kept for 90 days after the stack is deleted. If no StackStatusFilter is specified, summary information for all stacks
        /// is returned (including existing stacks and stacks that have been deleted).</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public ListStacksResponse ListStacks()
        {
            return ListStacks(new ListStacksRequest());
        }
        

        #endregion
    
        #region CreateStack

        /// <summary>
        /// <para>Creates a stack as specified in the template. After the call completes successfully, the stack creation starts. You can check the
        /// status of the stack via the DescribeStacks API.</para> <para><b>NOTE:</b> Currently, the limit for stacks is 20 stacks per account per
        /// region. </para>
        /// </summary>
        /// 
        /// <param name="createStackRequest">Container for the necessary parameters to execute the CreateStack service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by AmazonCloudFormation.</returns>
        /// 
        /// <exception cref="AlreadyExistsException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InsufficientCapabilitiesException"/>
        public CreateStackResponse CreateStack(CreateStackRequest createStackRequest)
        {
            IAsyncResult asyncResult = invokeCreateStack(createStackRequest, null, null, true);
            return EndCreateStack(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.CreateStack"/>
        /// </summary>
        /// 
        /// <param name="createStackRequest">Container for the necessary parameters to execute the CreateStack operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStack
        ///         operation.</returns>
        public IAsyncResult BeginCreateStack(CreateStackRequest createStackRequest, AsyncCallback callback, object state)
        {
            return invokeCreateStack(createStackRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.CreateStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStack.</param>
        /// 
        /// <returns>Returns a CreateStackResult from AmazonCloudFormation.</returns>
        public CreateStackResponse EndCreateStack(IAsyncResult asyncResult)
        {
            return endOperation<CreateStackResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateStack(CreateStackRequest createStackRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateStackRequestMarshaller().Marshall(createStackRequest);
            var unmarshaller = CreateStackResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region EstimateTemplateCost

        /// <summary>
        /// <para>Returns the estimated monthly cost of a template. The return value is an AWS Simple Monthly Calculator URL with a query string that
        /// describes the resources required to run the template.</para>
        /// </summary>
        /// 
        /// <param name="estimateTemplateCostRequest">Container for the necessary parameters to execute the EstimateTemplateCost service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the EstimateTemplateCost service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public EstimateTemplateCostResponse EstimateTemplateCost(EstimateTemplateCostRequest estimateTemplateCostRequest)
        {
            IAsyncResult asyncResult = invokeEstimateTemplateCost(estimateTemplateCostRequest, null, null, true);
            return EndEstimateTemplateCost(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the EstimateTemplateCost operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.EstimateTemplateCost"/>
        /// </summary>
        /// 
        /// <param name="estimateTemplateCostRequest">Container for the necessary parameters to execute the EstimateTemplateCost operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndEstimateTemplateCost operation.</returns>
        public IAsyncResult BeginEstimateTemplateCost(EstimateTemplateCostRequest estimateTemplateCostRequest, AsyncCallback callback, object state)
        {
            return invokeEstimateTemplateCost(estimateTemplateCostRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the EstimateTemplateCost operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.EstimateTemplateCost"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEstimateTemplateCost.</param>
        /// 
        /// <returns>Returns a EstimateTemplateCostResult from AmazonCloudFormation.</returns>
        public EstimateTemplateCostResponse EndEstimateTemplateCost(IAsyncResult asyncResult)
        {
            return endOperation<EstimateTemplateCostResponse>(asyncResult);
        }
        
        IAsyncResult invokeEstimateTemplateCost(EstimateTemplateCostRequest estimateTemplateCostRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new EstimateTemplateCostRequestMarshaller().Marshall(estimateTemplateCostRequest);
            var unmarshaller = EstimateTemplateCostResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeStackEvents

        /// <summary>
        /// <para>Returns all the stack related events for the AWS account. If <c>StackName</c> is specified, returns events related to all the stacks
        /// with the given name. If <c>StackName</c> is not specified, returns all the events for the account. For more information about a stack's
        /// event history, go to the AWS CloudFormation User Guide.</para> <para><b>NOTE:</b>Events are returned, even if the stack never existed or has
        /// been successfully deleted.</para>
        /// </summary>
        /// 
        /// <param name="describeStackEventsRequest">Container for the necessary parameters to execute the DescribeStackEvents service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest describeStackEventsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeStackEvents(describeStackEventsRequest, null, null, true);
            return EndDescribeStackEvents(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackEvents operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackEvents"/>
        /// </summary>
        /// 
        /// <param name="describeStackEventsRequest">Container for the necessary parameters to execute the DescribeStackEvents operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStackEvents operation.</returns>
        public IAsyncResult BeginDescribeStackEvents(DescribeStackEventsRequest describeStackEventsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeStackEvents(describeStackEventsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStackEvents operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackEvents"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackEvents.</param>
        /// 
        /// <returns>Returns a DescribeStackEventsResult from AmazonCloudFormation.</returns>
        public DescribeStackEventsResponse EndDescribeStackEvents(IAsyncResult asyncResult)
        {
            return endOperation<DescribeStackEventsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeStackEvents(DescribeStackEventsRequest describeStackEventsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStackEventsRequestMarshaller().Marshall(describeStackEventsRequest);
            var unmarshaller = DescribeStackEventsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns all the stack related events for the AWS account. If <c>StackName</c> is specified, returns events related to all the stacks
        /// with the given name. If <c>StackName</c> is not specified, returns all the events for the account. For more information about a stack's
        /// event history, go to the AWS CloudFormation User Guide.</para> <para><b>NOTE:</b>Events are returned, even if the stack never existed or has
        /// been successfully deleted.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public DescribeStackEventsResponse DescribeStackEvents()
        {
            return DescribeStackEvents(new DescribeStackEventsRequest());
        }
        

        #endregion
    
        #region DescribeStackResource

        /// <summary>
        /// <para>Returns a description of the specified resource in the specified stack.</para> <para>For deleted stacks, DescribeStackResource returns
        /// resource information for up to 90 days after the stack has been deleted.</para>
        /// </summary>
        /// 
        /// <param name="describeStackResourceRequest">Container for the necessary parameters to execute the DescribeStackResource service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackResource service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest describeStackResourceRequest)
        {
            IAsyncResult asyncResult = invokeDescribeStackResource(describeStackResourceRequest, null, null, true);
            return EndDescribeStackResource(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResource operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackResource"/>
        /// </summary>
        /// 
        /// <param name="describeStackResourceRequest">Container for the necessary parameters to execute the DescribeStackResource operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStackResource operation.</returns>
        public IAsyncResult BeginDescribeStackResource(DescribeStackResourceRequest describeStackResourceRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeStackResource(describeStackResourceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStackResource operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackResource"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackResource.</param>
        /// 
        /// <returns>Returns a DescribeStackResourceResult from AmazonCloudFormation.</returns>
        public DescribeStackResourceResponse EndDescribeStackResource(IAsyncResult asyncResult)
        {
            return endOperation<DescribeStackResourceResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeStackResource(DescribeStackResourceRequest describeStackResourceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStackResourceRequestMarshaller().Marshall(describeStackResourceRequest);
            var unmarshaller = DescribeStackResourceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CancelUpdateStack

        /// <summary>
        /// <para>Cancels an update on the specified stack. If the call completes successfully, the stack will roll back the update and revert to the
        /// previous stack configuration.</para> <para><b>NOTE:</b>Only stacks that are in the UPDATE_IN_PROGRESS state can be canceled.</para>
        /// </summary>
        /// 
        /// <param name="cancelUpdateStackRequest">Container for the necessary parameters to execute the CancelUpdateStack service method on
        ///          AmazonCloudFormation.</param>
        /// 
        public CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest cancelUpdateStackRequest)
        {
            IAsyncResult asyncResult = invokeCancelUpdateStack(cancelUpdateStackRequest, null, null, true);
            return EndCancelUpdateStack(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CancelUpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.CancelUpdateStack"/>
        /// </summary>
        /// 
        /// <param name="cancelUpdateStackRequest">Container for the necessary parameters to execute the CancelUpdateStack operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCancelUpdateStack(CancelUpdateStackRequest cancelUpdateStackRequest, AsyncCallback callback, object state)
        {
            return invokeCancelUpdateStack(cancelUpdateStackRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CancelUpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.CancelUpdateStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelUpdateStack.</param>
        public CancelUpdateStackResponse EndCancelUpdateStack(IAsyncResult asyncResult)
        {
            return endOperation<CancelUpdateStackResponse>(asyncResult);
        }
        
        IAsyncResult invokeCancelUpdateStack(CancelUpdateStackRequest cancelUpdateStackRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CancelUpdateStackRequestMarshaller().Marshall(cancelUpdateStackRequest);
            var unmarshaller = CancelUpdateStackResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteStack

        /// <summary>
        /// <para>Deletes a specified stack. Once the call completes successfully, stack deletion starts. Deleted stacks do not show up in the
        /// DescribeStacks API if the deletion has been completed successfully.</para>
        /// </summary>
        /// 
        /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack service method on
        ///          AmazonCloudFormation.</param>
        /// 
        public DeleteStackResponse DeleteStack(DeleteStackRequest deleteStackRequest)
        {
            IAsyncResult asyncResult = invokeDeleteStack(deleteStackRequest, null, null, true);
            return EndDeleteStack(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DeleteStack"/>
        /// </summary>
        /// 
        /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteStack(DeleteStackRequest deleteStackRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteStack(deleteStackRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DeleteStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStack.</param>
        public DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult)
        {
            return endOperation<DeleteStackResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteStack(DeleteStackRequest deleteStackRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteStackRequestMarshaller().Marshall(deleteStackRequest);
            var unmarshaller = DeleteStackResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListStackResources

        /// <summary>
        /// <para>Returns descriptions of all resources of the specified stack.</para> <para>For deleted stacks, ListStackResources returns resource
        /// information for up to 90 days after the stack has been deleted.</para>
        /// </summary>
        /// 
        /// <param name="listStackResourcesRequest">Container for the necessary parameters to execute the ListStackResources service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ListStackResources service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public ListStackResourcesResponse ListStackResources(ListStackResourcesRequest listStackResourcesRequest)
        {
            IAsyncResult asyncResult = invokeListStackResources(listStackResourcesRequest, null, null, true);
            return EndListStackResources(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ListStackResources"/>
        /// </summary>
        /// 
        /// <param name="listStackResourcesRequest">Container for the necessary parameters to execute the ListStackResources operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListStackResources operation.</returns>
        public IAsyncResult BeginListStackResources(ListStackResourcesRequest listStackResourcesRequest, AsyncCallback callback, object state)
        {
            return invokeListStackResources(listStackResourcesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ListStackResources"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackResources.</param>
        /// 
        /// <returns>Returns a ListStackResourcesResult from AmazonCloudFormation.</returns>
        public ListStackResourcesResponse EndListStackResources(IAsyncResult asyncResult)
        {
            return endOperation<ListStackResourcesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListStackResources(ListStackResourcesRequest listStackResourcesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListStackResourcesRequestMarshaller().Marshall(listStackResourcesRequest);
            var unmarshaller = ListStackResourcesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeStackResources

        /// <summary>
        /// <para>Returns AWS resource descriptions for running and deleted stacks. If <c>StackName</c> is specified, all the associated resources that
        /// are part of the stack are returned. If <c>PhysicalResourceId</c> is specified, the associated resources of the stack that the resource
        /// belongs to are returned.</para> <para><b>NOTE:</b>Only the first 100 resources will be returned. If your stack has more resources than this,
        /// you should use ListStackResources instead.</para> <para>For deleted stacks, <c>DescribeStackResources</c> returns resource information for
        /// up to 90 days after the stack has been deleted.</para> <para>You must specify either <c>StackName</c> or <c>PhysicalResourceId</c> , but not
        /// both. In addition, you can specify <c>LogicalResourceId</c> to filter the returned result. For more information about resources, the
        /// <c>LogicalResourceId</c> and <c>PhysicalResourceId</c> , go to the AWS CloudFormation User Guide.</para> <para><b>NOTE:</b>A ValidationError
        /// is returned if you specify both StackName and PhysicalResourceId in the same request.</para>
        /// </summary>
        /// 
        /// <param name="describeStackResourcesRequest">Container for the necessary parameters to execute the DescribeStackResources service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest describeStackResourcesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeStackResources(describeStackResourcesRequest, null, null, true);
            return EndDescribeStackResources(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackResources"/>
        /// </summary>
        /// 
        /// <param name="describeStackResourcesRequest">Container for the necessary parameters to execute the DescribeStackResources operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStackResources operation.</returns>
        public IAsyncResult BeginDescribeStackResources(DescribeStackResourcesRequest describeStackResourcesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeStackResources(describeStackResourcesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackResources"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackResources.</param>
        /// 
        /// <returns>Returns a DescribeStackResourcesResult from AmazonCloudFormation.</returns>
        public DescribeStackResourcesResponse EndDescribeStackResources(IAsyncResult asyncResult)
        {
            return endOperation<DescribeStackResourcesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeStackResources(DescribeStackResourcesRequest describeStackResourcesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeStackResourcesRequestMarshaller().Marshall(describeStackResourcesRequest);
            var unmarshaller = DescribeStackResourcesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns AWS resource descriptions for running and deleted stacks. If <c>StackName</c> is specified, all the associated resources that
        /// are part of the stack are returned. If <c>PhysicalResourceId</c> is specified, the associated resources of the stack that the resource
        /// belongs to are returned.</para> <para><b>NOTE:</b>Only the first 100 resources will be returned. If your stack has more resources than this,
        /// you should use ListStackResources instead.</para> <para>For deleted stacks, <c>DescribeStackResources</c> returns resource information for
        /// up to 90 days after the stack has been deleted.</para> <para>You must specify either <c>StackName</c> or <c>PhysicalResourceId</c> , but not
        /// both. In addition, you can specify <c>LogicalResourceId</c> to filter the returned result. For more information about resources, the
        /// <c>LogicalResourceId</c> and <c>PhysicalResourceId</c> , go to the AWS CloudFormation User Guide.</para> <para><b>NOTE:</b>A ValidationError
        /// is returned if you specify both StackName and PhysicalResourceId in the same request.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by AmazonCloudFormation.</returns>
        /// 
        public DescribeStackResourcesResponse DescribeStackResources()
        {
            return DescribeStackResources(new DescribeStackResourcesRequest());
        }
        

        #endregion
    
        #region UpdateStack

        /// <summary>
        /// <para>Updates a stack as specified in the template. After the call completes successfully, the stack update starts. You can check the status
        /// of the stack via the DescribeStacks action.</para> <para>To get a copy of the template for an existing stack, you can use the GetTemplate
        /// action.</para> <para>Tags that were associated with this stack during creation time will still be associated with the stack after an
        /// <c>UpdateStack</c> operation.</para> <para>For more information about creating an update template, updating a stack, and monitoring the
        /// progress of the update, see Updating a Stack.</para>
        /// </summary>
        /// 
        /// <param name="updateStackRequest">Container for the necessary parameters to execute the UpdateStack service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by AmazonCloudFormation.</returns>
        /// 
        /// <exception cref="InsufficientCapabilitiesException"/>
        public UpdateStackResponse UpdateStack(UpdateStackRequest updateStackRequest)
        {
            IAsyncResult asyncResult = invokeUpdateStack(updateStackRequest, null, null, true);
            return EndUpdateStack(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.UpdateStack"/>
        /// </summary>
        /// 
        /// <param name="updateStackRequest">Container for the necessary parameters to execute the UpdateStack operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStack
        ///         operation.</returns>
        public IAsyncResult BeginUpdateStack(UpdateStackRequest updateStackRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateStack(updateStackRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.UpdateStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStack.</param>
        /// 
        /// <returns>Returns a UpdateStackResult from AmazonCloudFormation.</returns>
        public UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult)
        {
            return endOperation<UpdateStackResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateStack(UpdateStackRequest updateStackRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateStackRequestMarshaller().Marshall(updateStackRequest);
            var unmarshaller = UpdateStackResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
