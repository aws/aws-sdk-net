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


using System;
using System.Threading;

using Amazon.AutoScaling.Model;
using Amazon.AutoScaling.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Implementation for accessing AutoScaling
    ///
    /// Auto Scaling                
    /// <para>
    ///             Auto Scaling is a web service designed            to automatically launch
    /// or terminate Amazon Elastic Compute Cloud (Amazon EC2) instances based on        
    ///    user-defined policies, schedules, and health checks.             This service is
    /// used in conjunction with Amazon CloudWatch             and Elastic Load Balancing
    /// services.        
    /// </para>
    ///                 
    /// <para>
    /// Auto Scaling provides APIs that you can call by submitting a Query Request.      
    ///       Query requests are HTTP or HTTPS requests that use the HTTP verbs GET or POST
    /// and a Query parameter named <i>Action</i>            or <i>Operation</i> that specifies
    /// the API you are calling. Action is used throughout this documentation, although Operation
    ///             is also supported for backward compatibility with other Amazon Web Services
    /// (AWS) Query APIs. 
    /// </para>
    ///         
    /// <para>
    /// Calling the API using a Query request is the most direct way to access the web service,
    /// but requires that your application handle            low-level details such as generating
    /// the hash to sign the request and error handling. The benefit of calling the service
    /// using a             Query request is that you are assured of having access to the
    /// complete functionality of the API. For information about signing a             a query
    /// request, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/api_requests.html">Use
    /// Query Requests to Call Auto Scaling APIs</a>
    /// </para>
    ///         
    /// <para>
    ///         This guide provides detailed information         about Auto Scaling actions,
    /// data types, parameters, and errors. For detailed information         about Auto Scaling
    /// features and their associated API actions, go to the         <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/">Auto
    /// Scaling Developer Guide</a>.        
    /// </para>
    ///                 
    /// <para>
    /// This reference is based on the current WSDL, which is available at:
    /// </para>
    ///         
    /// <para>
    /// <a href="http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl">http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl</a>
    ///        
    /// </para>
    ///         
    /// <para>
    /// <b>Endpoints</b>
    /// </para>
    ///         
    /// <para>
    /// The examples in this guide assume that your instances are launched in the US East
    /// (Northern Virginia) region and use us-east-1 as the endpoint.
    /// </para>
    ///         
    /// <para>
    /// You can set up your Auto Scaling infrastructure in other AWS regions. For information
    /// about this product's regions and endpoints, see            <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">Regions
    /// and Endpoints</a>             in the Amazon Web Services General Reference.      
    ///  
    /// </para>
    /// </summary>
    public partial class AmazonAutoScalingClient : AmazonWebServiceClient, AmazonAutoScaling
    {
        AbstractAWSSigner signer = new AWS4Signer();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        public AmazonAutoScalingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        public AmazonAutoScalingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingConfig{RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(AmazonAutoScalingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAutoScalingClient(AWSCredentials credentials)
            : this(credentials, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAutoScalingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials and an
        /// AmazonAutoScalingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(AWSCredentials credentials, AmazonAutoScalingConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAutoScalingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAutoScalingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  AttachInstances


        /// <summary>
        /// Attaches one or more Amazon EC2 instances to an existing Auto Scaling group.
        ///            After the instance(s) is attached, it becomes a part of the Auto Scaling
        /// group.       
        /// 
        ///         
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/attach-instance-asg.html">Attach
        /// Amazon EC2 Instance(s) to Your Existing Auto Scaling Group</a>        in the <i>Auto
        /// Scaling Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances service method.</param>
        /// 
        /// <returns>The response from the AttachInstances service method, as returned by AutoScaling.</returns>
        public AttachInstancesResponse AttachInstances(AttachInstancesRequest request)
        {
            IAsyncResult asyncResult = invokeAttachInstances(request, null, null, true);
            return EndAttachInstances(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachInstances operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachInstances
        ///         operation.</returns>
        public IAsyncResult BeginAttachInstances(AttachInstancesRequest request, AsyncCallback callback, object state)
        {
            return invokeAttachInstances(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachInstances operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachInstances.</param>
        /// 
        /// <returns>Returns a  AttachInstancesResult from AutoScaling.</returns>
        public  AttachInstancesResponse EndAttachInstances(IAsyncResult asyncResult)
        {
            return endOperation< AttachInstancesResponse>(asyncResult);
        }

        IAsyncResult invokeAttachInstances(AttachInstancesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AttachInstancesRequestMarshaller().Marshall(request);
            var unmarshaller = AttachInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CompleteLifecycleAction


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction service method.</param>
        /// 
        /// <returns>The response from the CompleteLifecycleAction service method, as returned by AutoScaling.</returns>
        public CompleteLifecycleActionResponse CompleteLifecycleAction(CompleteLifecycleActionRequest request)
        {
            IAsyncResult asyncResult = invokeCompleteLifecycleAction(request, null, null, true);
            return EndCompleteLifecycleAction(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteLifecycleAction operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCompleteLifecycleAction
        ///         operation.</returns>
        public IAsyncResult BeginCompleteLifecycleAction(CompleteLifecycleActionRequest request, AsyncCallback callback, object state)
        {
            return invokeCompleteLifecycleAction(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteLifecycleAction operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteLifecycleAction.</param>
        /// 
        /// <returns>Returns a  CompleteLifecycleActionResult from AutoScaling.</returns>
        public  CompleteLifecycleActionResponse EndCompleteLifecycleAction(IAsyncResult asyncResult)
        {
            return endOperation< CompleteLifecycleActionResponse>(asyncResult);
        }

        IAsyncResult invokeCompleteLifecycleAction(CompleteLifecycleActionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CompleteLifecycleActionRequestMarshaller().Marshall(request);
            var unmarshaller = CompleteLifecycleActionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateAutoScalingGroup


        /// <summary>
        /// Creates a new Auto Scaling group with the specified name and other attributes.
        ///        When the creation request is completed,        the Auto Scaling group is ready
        /// to be used in other calls.        
        /// 
        ///         <note>            The Auto Scaling group name must be unique within      
        ///       the scope of your AWS account.        </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The quota for capacity groups or launch configurations        for this customer
        /// has already been reached.
        /// </exception>
        public CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest request)
        {
            IAsyncResult asyncResult = invokeCreateAutoScalingGroup(request, null, null, true);
            return EndCreateAutoScalingGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutoScalingGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateAutoScalingGroup(CreateAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateAutoScalingGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  CreateAutoScalingGroupResult from AutoScaling.</returns>
        public  CreateAutoScalingGroupResponse EndCreateAutoScalingGroup(IAsyncResult asyncResult)
        {
            return endOperation< CreateAutoScalingGroupResponse>(asyncResult);
        }

        IAsyncResult invokeCreateAutoScalingGroup(CreateAutoScalingGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateAutoScalingGroupRequestMarshaller().Marshall(request);
            var unmarshaller = CreateAutoScalingGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateLaunchConfiguration


        /// <summary>
        /// Creates a new launch configuration. The launch configuration name        
        /// must be unique within the scope of the client's AWS account. The maximum limit   
        ///     of launch configurations, which by default is 100, must not yet have been met;
        /// otherwise,         the call will fail. When created, the new launch configuration
        ///         is available for immediate use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The quota for capacity groups or launch configurations        for this customer
        /// has already been reached.
        /// </exception>
        public CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeCreateLaunchConfiguration(request, null, null, true);
            return EndCreateLaunchConfiguration(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLaunchConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginCreateLaunchConfiguration(CreateLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateLaunchConfiguration(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateLaunchConfigurationResult from AutoScaling.</returns>
        public  CreateLaunchConfigurationResponse EndCreateLaunchConfiguration(IAsyncResult asyncResult)
        {
            return endOperation< CreateLaunchConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokeCreateLaunchConfiguration(CreateLaunchConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateLaunchConfigurationRequestMarshaller().Marshall(request);
            var unmarshaller = CreateLaunchConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateOrUpdateTags


        /// <summary>
        /// Creates new tags or updates existing tags for an Auto Scaling group. 
        ///       
        /// 
        ///         <note>            A tag's definition is composed of a resource ID, resource
        /// type, key and value, and the propagate flag.             Value and the propagate flag
        /// are optional parameters. See the Request Parameters for more information.        
        ///            </note>        
        /// <para>
        /// For information on creating tags for your Auto Scaling group, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASTagging.html">Tag
        /// Your Auto Scaling Groups and Amazon EC2 Instances</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags service method.</param>
        /// 
        /// <returns>The response from the CreateOrUpdateTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The quota for capacity groups or launch configurations        for this customer
        /// has already been reached.
        /// </exception>
        public CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest request)
        {
            IAsyncResult asyncResult = invokeCreateOrUpdateTags(request, null, null, true);
            return EndCreateOrUpdateTags(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrUpdateTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOrUpdateTags
        ///         operation.</returns>
        public IAsyncResult BeginCreateOrUpdateTags(CreateOrUpdateTagsRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateOrUpdateTags(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOrUpdateTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOrUpdateTags.</param>
        /// 
        /// <returns>Returns a  CreateOrUpdateTagsResult from AutoScaling.</returns>
        public  CreateOrUpdateTagsResponse EndCreateOrUpdateTags(IAsyncResult asyncResult)
        {
            return endOperation< CreateOrUpdateTagsResponse>(asyncResult);
        }

        IAsyncResult invokeCreateOrUpdateTags(CreateOrUpdateTagsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateOrUpdateTagsRequestMarshaller().Marshall(request);
            var unmarshaller = CreateOrUpdateTagsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteAutoScalingGroup


        /// <summary>
        /// Deletes the specified Auto Scaling group if the group has no        instances
        /// and no scaling activities in progress.        
        /// 
        ///         <note>            To remove all instances before calling <a>DeleteAutoScalingGroup</a>,
        ///            you can call <a>UpdateAutoScalingGroup</a> to set the minimum and     
        ///        maximum size of the AutoScalingGroup to zero.        </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="ResourceInUseException">
        /// This is returned when you cannot delete a launch        configuration or Auto
        /// Scaling group because it is being used.
        /// </exception>
        /// <exception cref="ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group        while there are scaling activities
        /// in progress for that group.
        /// </exception>
        public DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteAutoScalingGroup(request, null, null, true);
            return EndDeleteAutoScalingGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAutoScalingGroup
        ///         operation.</returns>
        public IAsyncResult BeginDeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteAutoScalingGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteAutoScalingGroupResult from AutoScaling.</returns>
        public  DeleteAutoScalingGroupResponse EndDeleteAutoScalingGroup(IAsyncResult asyncResult)
        {
            return endOperation< DeleteAutoScalingGroupResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteAutoScalingGroupRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteLaunchConfiguration


        /// <summary>
        /// Deletes the specified <a>LaunchConfiguration</a>.        
        /// 
        ///         
        /// <para>
        ///         The specified launch configuration must not be         attached to an Auto
        /// Scaling group. When this call completes,        the launch configuration is no longer
        /// available for use.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="ResourceInUseException">
        /// This is returned when you cannot delete a launch        configuration or Auto
        /// Scaling group because it is being used.
        /// </exception>
        public DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteLaunchConfiguration(request, null, null, true);
            return EndDeleteLaunchConfiguration(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLaunchConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginDeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteLaunchConfiguration(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteLaunchConfigurationResult from AutoScaling.</returns>
        public  DeleteLaunchConfigurationResponse EndDeleteLaunchConfiguration(IAsyncResult asyncResult)
        {
            return endOperation< DeleteLaunchConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteLaunchConfigurationRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteLifecycleHook


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecycleHook service method, as returned by AutoScaling.</returns>
        public DeleteLifecycleHookResponse DeleteLifecycleHook(DeleteLifecycleHookRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteLifecycleHook(request, null, null, true);
            return EndDeleteLifecycleHook(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleHook operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLifecycleHook
        ///         operation.</returns>
        public IAsyncResult BeginDeleteLifecycleHook(DeleteLifecycleHookRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteLifecycleHook(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLifecycleHook operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLifecycleHook.</param>
        /// 
        /// <returns>Returns a  DeleteLifecycleHookResult from AutoScaling.</returns>
        public  DeleteLifecycleHookResponse EndDeleteLifecycleHook(IAsyncResult asyncResult)
        {
            return endOperation< DeleteLifecycleHookResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteLifecycleHook(DeleteLifecycleHookRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteLifecycleHookRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteLifecycleHookResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteNotificationConfiguration


        /// <summary>
        /// Deletes notifications created by <a>PutNotificationConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by AutoScaling.</returns>
        public DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteNotificationConfiguration(request, null, null, true);
            return EndDeleteNotificationConfiguration(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotificationConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginDeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteNotificationConfiguration(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationConfigurationResult from AutoScaling.</returns>
        public  DeleteNotificationConfigurationResponse EndDeleteNotificationConfiguration(IAsyncResult asyncResult)
        {
            return endOperation< DeleteNotificationConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteNotificationConfigurationRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes a policy created by <a>PutScalingPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by AutoScaling.</returns>
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            IAsyncResult asyncResult = invokeDeletePolicy(request, null, null, true);
            return EndDeletePolicy(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicy
        ///         operation.</returns>
        public IAsyncResult BeginDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeDeletePolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        /// 
        /// <returns>Returns a  DeletePolicyResult from AutoScaling.</returns>
        public  DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult)
        {
            return endOperation< DeletePolicyResponse>(asyncResult);
        }

        IAsyncResult invokeDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeletePolicyRequestMarshaller().Marshall(request);
            var unmarshaller = DeletePolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteScheduledAction


        /// <summary>
        /// Deletes a scheduled action previously created using the <a>PutScheduledUpdateGroupAction</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by AutoScaling.</returns>
        public DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteScheduledAction(request, null, null, true);
            return EndDeleteScheduledAction(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScheduledAction
        ///         operation.</returns>
        public IAsyncResult BeginDeleteScheduledAction(DeleteScheduledActionRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteScheduledAction(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScheduledAction operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScheduledAction.</param>
        /// 
        /// <returns>Returns a  DeleteScheduledActionResult from AutoScaling.</returns>
        public  DeleteScheduledActionResponse EndDeleteScheduledAction(IAsyncResult asyncResult)
        {
            return endOperation< DeleteScheduledActionResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteScheduledAction(DeleteScheduledActionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteScheduledActionRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteScheduledActionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Removes the specified tags or a set of tags from a set of resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by AutoScaling.</returns>
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteTags(request, null, null, true);
            return EndDeleteTags(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        public IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteTags(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from AutoScaling.</returns>
        public  DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return endOperation< DeleteTagsResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteTagsRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteTagsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeAccountLimits

        /// <summary>
        /// Returns the limits for the Auto Scaling resources currently allowed for
        /// your AWS account.        
        /// 
        ///         
        /// <para>
        /// Your AWS account comes with default limits on resources for Auto Scaling.        
        ///     There is a default limit of <code>20</code> Auto Scaling groups and <code>100</code>
        ///            launch configurations per region.
        /// </para>
        ///         
        /// <para>
        /// If you reach the limits for the number of Auto Scaling groups or the launch configurations,
        ///            you can go to the <a href="https://aws.amazon.com/support/">Support Center</a>
        /// and place a             request to raise the limits.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        public DescribeAccountLimitsResponse DescribeAccountLimits()
        {
            return DescribeAccountLimits(new DescribeAccountLimitsRequest());
        }

        /// <summary>
        /// Returns the limits for the Auto Scaling resources currently allowed for
        /// your AWS account.        
        /// 
        ///         
        /// <para>
        /// Your AWS account comes with default limits on resources for Auto Scaling.        
        ///     There is a default limit of <code>20</code> Auto Scaling groups and <code>100</code>
        ///            launch configurations per region.
        /// </para>
        ///         
        /// <para>
        /// If you reach the limits for the number of Auto Scaling groups or the launch configurations,
        ///            you can go to the <a href="https://aws.amazon.com/support/">Support Center</a>
        /// and place a             request to raise the limits.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        public DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeAccountLimits(request, null, null, true);
            return EndDescribeAccountLimits(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountLimits
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAccountLimits(DescribeAccountLimitsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeAccountLimits(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountLimits operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountLimits.</param>
        /// 
        /// <returns>Returns a  DescribeAccountLimitsResult from AutoScaling.</returns>
        public  DescribeAccountLimitsResponse EndDescribeAccountLimits(IAsyncResult asyncResult)
        {
            return endOperation< DescribeAccountLimitsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeAccountLimits(DescribeAccountLimitsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAccountLimitsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeAdjustmentTypes

        /// <summary>
        /// Returns policy adjustment types for use in the <a>PutScalingPolicy</a>
        /// action.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        public DescribeAdjustmentTypesResponse DescribeAdjustmentTypes()
        {
            return DescribeAdjustmentTypes(new DescribeAdjustmentTypesRequest());
        }

        /// <summary>
        /// Returns policy adjustment types for use in the <a>PutScalingPolicy</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        public DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeAdjustmentTypes(request, null, null, true);
            return EndDescribeAdjustmentTypes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAdjustmentTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAdjustmentTypes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeAdjustmentTypes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAdjustmentTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAdjustmentTypes.</param>
        /// 
        /// <returns>Returns a  DescribeAdjustmentTypesResult from AutoScaling.</returns>
        public  DescribeAdjustmentTypesResponse EndDescribeAdjustmentTypes(IAsyncResult asyncResult)
        {
            return endOperation< DescribeAdjustmentTypesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAdjustmentTypesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeAutoScalingGroups

        /// <summary>
        /// Returns a full description of each Auto Scaling group in the given list.
        ///             This includes all Amazon EC2 instances that are members of the group.
        ///             If a list of names is not provided, the service returns the          
        ///  full details of all Auto Scaling groups.        
        /// 
        ///         
        /// <para>
        ///             This action supports pagination by returning a token if there are more
        /// pages to retrieve.            To get the next page, call this action again with the
        /// returned token as the <code>NextToken</code> parameter.        
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups()
        {
            return DescribeAutoScalingGroups(new DescribeAutoScalingGroupsRequest());
        }

        /// <summary>
        /// Returns a full description of each Auto Scaling group in the given list.
        ///             This includes all Amazon EC2 instances that are members of the group.
        ///             If a list of names is not provided, the service returns the          
        ///  full details of all Auto Scaling groups.        
        /// 
        ///         
        /// <para>
        ///             This action supports pagination by returning a token if there are more
        /// pages to retrieve.            To get the next page, call this action again with the
        /// returned token as the <code>NextToken</code> parameter.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeAutoScalingGroups(request, null, null, true);
            return EndDescribeAutoScalingGroups(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingGroups operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutoScalingGroups
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeAutoScalingGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoScalingGroups operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingGroups.</param>
        /// 
        /// <returns>Returns a  DescribeAutoScalingGroupsResult from AutoScaling.</returns>
        public  DescribeAutoScalingGroupsResponse EndDescribeAutoScalingGroups(IAsyncResult asyncResult)
        {
            return endOperation< DescribeAutoScalingGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAutoScalingGroupsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeAutoScalingInstances

        /// <summary>
        /// Returns a description of each Auto Scaling instance in the <code>InstanceIds</code>
        /// list.            If a list is not provided, the service returns the full details of
        /// all instances up to a maximum of 50.             By default, the service returns a
        /// list of 20 items.        
        /// 
        ///         
        /// <para>
        ///             This action supports pagination by returning a token if there are more
        /// pages to retrieve.            To get the next page, call this action again with the
        /// returned token as the <code>NextToken</code> parameter.        
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances()
        {
            return DescribeAutoScalingInstances(new DescribeAutoScalingInstancesRequest());
        }

        /// <summary>
        /// Returns a description of each Auto Scaling instance in the <code>InstanceIds</code>
        /// list.            If a list is not provided, the service returns the full details of
        /// all instances up to a maximum of 50.             By default, the service returns a
        /// list of 20 items.        
        /// 
        ///         
        /// <para>
        ///             This action supports pagination by returning a token if there are more
        /// pages to retrieve.            To get the next page, call this action again with the
        /// returned token as the <code>NextToken</code> parameter.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeAutoScalingInstances(request, null, null, true);
            return EndDescribeAutoScalingInstances(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingInstances operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutoScalingInstances
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeAutoScalingInstances(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoScalingInstances operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingInstances.</param>
        /// 
        /// <returns>Returns a  DescribeAutoScalingInstancesResult from AutoScaling.</returns>
        public  DescribeAutoScalingInstancesResponse EndDescribeAutoScalingInstances(IAsyncResult asyncResult)
        {
            return endOperation< DescribeAutoScalingInstancesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAutoScalingInstancesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeAutoScalingNotificationTypes

        /// <summary>
        /// Returns a list of all notification types that are supported by Auto Scaling.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        public DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes()
        {
            return DescribeAutoScalingNotificationTypes(new DescribeAutoScalingNotificationTypesRequest());
        }

        /// <summary>
        /// Returns a list of all notification types that are supported by Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        public DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeAutoScalingNotificationTypes(request, null, null, true);
            return EndDescribeAutoScalingNotificationTypes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingNotificationTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutoScalingNotificationTypes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeAutoScalingNotificationTypes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoScalingNotificationTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingNotificationTypes.</param>
        /// 
        /// <returns>Returns a  DescribeAutoScalingNotificationTypesResult from AutoScaling.</returns>
        public  DescribeAutoScalingNotificationTypesResponse EndDescribeAutoScalingNotificationTypes(IAsyncResult asyncResult)
        {
            return endOperation< DescribeAutoScalingNotificationTypesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAutoScalingNotificationTypesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeLaunchConfigurations

        /// <summary>
        /// Returns a full description of the launch configurations, or the specified
        /// launch configurations,        if they exist.        
        /// 
        ///         
        /// <para>
        ///         If no name is specified, then the full details of        all launch configurations
        /// are returned.        
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations()
        {
            return DescribeLaunchConfigurations(new DescribeLaunchConfigurationsRequest());
        }

        /// <summary>
        /// Returns a full description of the launch configurations, or the specified
        /// launch configurations,        if they exist.        
        /// 
        ///         
        /// <para>
        ///         If no name is specified, then the full details of        all launch configurations
        /// are returned.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeLaunchConfigurations(request, null, null, true);
            return EndDescribeLaunchConfigurations(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLaunchConfigurations
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeLaunchConfigurations(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLaunchConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLaunchConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeLaunchConfigurationsResult from AutoScaling.</returns>
        public  DescribeLaunchConfigurationsResponse EndDescribeLaunchConfigurations(IAsyncResult asyncResult)
        {
            return endOperation< DescribeLaunchConfigurationsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLaunchConfigurationsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeLifecycleHooks


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHooks service method, as returned by AutoScaling.</returns>
        public DescribeLifecycleHooksResponse DescribeLifecycleHooks(DescribeLifecycleHooksRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeLifecycleHooks(request, null, null, true);
            return EndDescribeLifecycleHooks(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLifecycleHooks operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLifecycleHooks
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLifecycleHooks(DescribeLifecycleHooksRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeLifecycleHooks(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLifecycleHooks operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLifecycleHooks.</param>
        /// 
        /// <returns>Returns a  DescribeLifecycleHooksResult from AutoScaling.</returns>
        public  DescribeLifecycleHooksResponse EndDescribeLifecycleHooks(IAsyncResult asyncResult)
        {
            return endOperation< DescribeLifecycleHooksResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeLifecycleHooks(DescribeLifecycleHooksRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLifecycleHooksRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeLifecycleHooksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeLifecycleHookTypes


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHookTypes service method, as returned by AutoScaling.</returns>
        public DescribeLifecycleHookTypesResponse DescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeLifecycleHookTypes(request, null, null, true);
            return EndDescribeLifecycleHookTypes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLifecycleHookTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLifecycleHookTypes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeLifecycleHookTypes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLifecycleHookTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLifecycleHookTypes.</param>
        /// 
        /// <returns>Returns a  DescribeLifecycleHookTypesResult from AutoScaling.</returns>
        public  DescribeLifecycleHookTypesResponse EndDescribeLifecycleHookTypes(IAsyncResult asyncResult)
        {
            return endOperation< DescribeLifecycleHookTypesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLifecycleHookTypesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeMetricCollectionTypes

        /// <summary>
        /// Returns a list of metrics and a corresponding list             of granularities
        /// for each metric.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        public DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes()
        {
            return DescribeMetricCollectionTypes(new DescribeMetricCollectionTypesRequest());
        }

        /// <summary>
        /// Returns a list of metrics and a corresponding list             of granularities
        /// for each metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        public DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeMetricCollectionTypes(request, null, null, true);
            return EndDescribeMetricCollectionTypes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricCollectionTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMetricCollectionTypes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeMetricCollectionTypes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetricCollectionTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetricCollectionTypes.</param>
        /// 
        /// <returns>Returns a  DescribeMetricCollectionTypesResult from AutoScaling.</returns>
        public  DescribeMetricCollectionTypesResponse EndDescribeMetricCollectionTypes(IAsyncResult asyncResult)
        {
            return endOperation< DescribeMetricCollectionTypesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeMetricCollectionTypesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeNotificationConfigurations

        /// <summary>
        /// Returns a list of notification actions associated with Auto Scaling groups
        ///             for specified events.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations()
        {
            return DescribeNotificationConfigurations(new DescribeNotificationConfigurationsRequest());
        }

        /// <summary>
        /// Returns a list of notification actions associated with Auto Scaling groups
        ///             for specified events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeNotificationConfigurations(request, null, null, true);
            return EndDescribeNotificationConfigurations(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotificationConfigurations
        ///         operation.</returns>
        public IAsyncResult BeginDescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeNotificationConfigurations(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotificationConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeNotificationConfigurationsResult from AutoScaling.</returns>
        public  DescribeNotificationConfigurationsResponse EndDescribeNotificationConfigurations(IAsyncResult asyncResult)
        {
            return endOperation< DescribeNotificationConfigurationsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeNotificationConfigurationsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribePolicies

        /// <summary>
        /// Returns descriptions of what each policy does.            This action
        /// supports pagination. If the response includes a token,             there are more
        /// records available. To get the additional records, repeat            the request with
        /// the response token as the <code>NextToken</code> parameter.
        /// </summary>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribePoliciesResponse DescribePolicies()
        {
            return DescribePolicies(new DescribePoliciesRequest());
        }

        /// <summary>
        /// Returns descriptions of what each policy does.            This action
        /// supports pagination. If the response includes a token,             there are more
        /// records available. To get the additional records, repeat            the request with
        /// the response token as the <code>NextToken</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies service method.</param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribePolicies(request, null, null, true);
            return EndDescribePolicies(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePolicies operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePolicies
        ///         operation.</returns>
        public IAsyncResult BeginDescribePolicies(DescribePoliciesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribePolicies(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePolicies operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePolicies.</param>
        /// 
        /// <returns>Returns a  DescribePoliciesResult from AutoScaling.</returns>
        public  DescribePoliciesResponse EndDescribePolicies(IAsyncResult asyncResult)
        {
            return endOperation< DescribePoliciesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribePolicies(DescribePoliciesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribePoliciesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribePoliciesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeScalingActivities

        /// <summary>
        /// Returns the scaling activities for the specified Auto Scaling group. 
        ///       
        /// 
        ///         
        /// <para>
        ///             If the specified <code>ActivityIds</code> list is empty,            all
        /// the activities from the past six weeks are returned.            Activities are sorted
        /// by the start time.            Activities still in progress appear first on the list.
        ///        
        /// </para>
        ///         
        /// <para>
        ///             This action supports pagination. If the response includes a token,   
        ///          there are more records available. To get the additional records, repeat 
        ///           the request with the response token as the <code>NextToken</code> parameter.
        ///                    
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeScalingActivitiesResponse DescribeScalingActivities()
        {
            return DescribeScalingActivities(new DescribeScalingActivitiesRequest());
        }

        /// <summary>
        /// Returns the scaling activities for the specified Auto Scaling group. 
        ///       
        /// 
        ///         
        /// <para>
        ///             If the specified <code>ActivityIds</code> list is empty,            all
        /// the activities from the past six weeks are returned.            Activities are sorted
        /// by the start time.            Activities still in progress appear first on the list.
        ///        
        /// </para>
        ///         
        /// <para>
        ///             This action supports pagination. If the response includes a token,   
        ///          there are more records available. To get the additional records, repeat 
        ///           the request with the response token as the <code>NextToken</code> parameter.
        ///                    
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeScalingActivities(request, null, null, true);
            return EndDescribeScalingActivities(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingActivities
        ///         operation.</returns>
        public IAsyncResult BeginDescribeScalingActivities(DescribeScalingActivitiesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeScalingActivities(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingActivities operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingActivities.</param>
        /// 
        /// <returns>Returns a  DescribeScalingActivitiesResult from AutoScaling.</returns>
        public  DescribeScalingActivitiesResponse EndDescribeScalingActivities(IAsyncResult asyncResult)
        {
            return endOperation< DescribeScalingActivitiesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeScalingActivities(DescribeScalingActivitiesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeScalingActivitiesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeScalingActivitiesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeScalingProcessTypes

        /// <summary>
        /// Returns scaling process types for use in the <a>ResumeProcesses</a>            and
        /// <a>SuspendProcesses</a> actions.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        public DescribeScalingProcessTypesResponse DescribeScalingProcessTypes()
        {
            return DescribeScalingProcessTypes(new DescribeScalingProcessTypesRequest());
        }

        /// <summary>
        /// Returns scaling process types for use in the <a>ResumeProcesses</a>            and
        /// <a>SuspendProcesses</a> actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        public DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeScalingProcessTypes(request, null, null, true);
            return EndDescribeScalingProcessTypes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingProcessTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingProcessTypes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeScalingProcessTypes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingProcessTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingProcessTypes.</param>
        /// 
        /// <returns>Returns a  DescribeScalingProcessTypesResult from AutoScaling.</returns>
        public  DescribeScalingProcessTypesResponse EndDescribeScalingProcessTypes(IAsyncResult asyncResult)
        {
            return endOperation< DescribeScalingProcessTypesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeScalingProcessTypesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeScheduledActions

        /// <summary>
        /// Lists all the actions scheduled for your Auto Scaling group that haven't
        /// been executed. To see a list of            actions already executed, see the activity
        /// record returned in <a>DescribeScalingActivities</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeScheduledActionsResponse DescribeScheduledActions()
        {
            return DescribeScheduledActions(new DescribeScheduledActionsRequest());
        }

        /// <summary>
        /// Lists all the actions scheduled for your Auto Scaling group that haven't
        /// been executed. To see a list of            actions already executed, see the activity
        /// record returned in <a>DescribeScalingActivities</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeScheduledActions(request, null, null, true);
            return EndDescribeScheduledActions(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledActions operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScheduledActions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeScheduledActions(DescribeScheduledActionsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeScheduledActions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScheduledActions operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledActions.</param>
        /// 
        /// <returns>Returns a  DescribeScheduledActionsResult from AutoScaling.</returns>
        public  DescribeScheduledActionsResponse EndDescribeScheduledActions(IAsyncResult asyncResult)
        {
            return endOperation< DescribeScheduledActionsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeScheduledActions(DescribeScheduledActionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeScheduledActionsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeScheduledActionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeTags

        /// <summary>
        /// Lists the Auto Scaling group tags.          
        /// 
        ///         
        /// <para>
        ///             You can use filters to limit results when describing tags. For example,
        /// you can query for             tags of a particular Auto Scaling group. You can specify
        /// multiple values for a filter. A             tag must match at least one of the specified
        /// values for it to be included in the results.         
        /// </para>
        ///         
        /// <para>
        ///             You can also specify multiple filters. The result includes information
        /// for a particular             tag only if it matches all your filters. If there's no
        /// match, no special message is returned.        
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
        }

        /// <summary>
        /// Lists the Auto Scaling group tags.          
        /// 
        ///         
        /// <para>
        ///             You can use filters to limit results when describing tags. For example,
        /// you can query for             tags of a particular Auto Scaling group. You can specify
        /// multiple values for a filter. A             tag must match at least one of the specified
        /// values for it to be included in the results.         
        /// </para>
        ///         
        /// <para>
        ///             You can also specify multiple filters. The result includes information
        /// for a particular             tag only if it matches all your filters. If there's no
        /// match, no special message is returned.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeTags(request, null, null, true);
            return EndDescribeTags(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeTags(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from AutoScaling.</returns>
        public  DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult)
        {
            return endOperation< DescribeTagsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTagsRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeTagsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DescribeTerminationPolicyTypes

        /// <summary>
        /// Returns a list of all termination policies supported by Auto Scaling.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        public DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes()
        {
            return DescribeTerminationPolicyTypes(new DescribeTerminationPolicyTypesRequest());
        }

        /// <summary>
        /// Returns a list of all termination policies supported by Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        public DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeTerminationPolicyTypes(request, null, null, true);
            return EndDescribeTerminationPolicyTypes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTerminationPolicyTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTerminationPolicyTypes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeTerminationPolicyTypes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTerminationPolicyTypes operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTerminationPolicyTypes.</param>
        /// 
        /// <returns>Returns a  DescribeTerminationPolicyTypesResult from AutoScaling.</returns>
        public  DescribeTerminationPolicyTypesResponse EndDescribeTerminationPolicyTypes(IAsyncResult asyncResult)
        {
            return endOperation< DescribeTerminationPolicyTypesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTerminationPolicyTypesRequestMarshaller().Marshall(request);
            var unmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DetachInstances


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances service method.</param>
        /// 
        /// <returns>The response from the DetachInstances service method, as returned by AutoScaling.</returns>
        public DetachInstancesResponse DetachInstances(DetachInstancesRequest request)
        {
            IAsyncResult asyncResult = invokeDetachInstances(request, null, null, true);
            return EndDetachInstances(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachInstances operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachInstances
        ///         operation.</returns>
        public IAsyncResult BeginDetachInstances(DetachInstancesRequest request, AsyncCallback callback, object state)
        {
            return invokeDetachInstances(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachInstances operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachInstances.</param>
        /// 
        /// <returns>Returns a  DetachInstancesResult from AutoScaling.</returns>
        public  DetachInstancesResponse EndDetachInstances(IAsyncResult asyncResult)
        {
            return endOperation< DetachInstancesResponse>(asyncResult);
        }

        IAsyncResult invokeDetachInstances(DetachInstancesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DetachInstancesRequestMarshaller().Marshall(request);
            var unmarshaller = DetachInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DisableMetricsCollection


        /// <summary>
        /// Disables monitoring of group metrics for the            Auto Scaling group
        /// specified in <code>AutoScalingGroupName</code>.            You can specify the list
        /// of affected metrics with the            <code>Metrics</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the DisableMetricsCollection service method, as returned by AutoScaling.</returns>
        public DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest request)
        {
            IAsyncResult asyncResult = invokeDisableMetricsCollection(request, null, null, true);
            return EndDisableMetricsCollection(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableMetricsCollection
        ///         operation.</returns>
        public IAsyncResult BeginDisableMetricsCollection(DisableMetricsCollectionRequest request, AsyncCallback callback, object state)
        {
            return invokeDisableMetricsCollection(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableMetricsCollection.</param>
        /// 
        /// <returns>Returns a  DisableMetricsCollectionResult from AutoScaling.</returns>
        public  DisableMetricsCollectionResponse EndDisableMetricsCollection(IAsyncResult asyncResult)
        {
            return endOperation< DisableMetricsCollectionResponse>(asyncResult);
        }

        IAsyncResult invokeDisableMetricsCollection(DisableMetricsCollectionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DisableMetricsCollectionRequestMarshaller().Marshall(request);
            var unmarshaller = DisableMetricsCollectionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  EnableMetricsCollection


        /// <summary>
        /// Enables monitoring of group metrics for the            Auto Scaling group
        /// specified in <code>AutoScalingGroupName</code>.            You can specify the list
        /// of enabled metrics with the            <code>Metrics</code> parameter.        
        /// 
        ///         
        /// <para>
        ///             Auto Scaling metrics collection can be turned on only             if the
        /// <code>InstanceMonitoring</code> flag,             in the Auto Scaling group's launch
        /// configuration,             is set to <code>True</code>.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the EnableMetricsCollection service method, as returned by AutoScaling.</returns>
        public EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest request)
        {
            IAsyncResult asyncResult = invokeEnableMetricsCollection(request, null, null, true);
            return EndEnableMetricsCollection(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableMetricsCollection
        ///         operation.</returns>
        public IAsyncResult BeginEnableMetricsCollection(EnableMetricsCollectionRequest request, AsyncCallback callback, object state)
        {
            return invokeEnableMetricsCollection(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMetricsCollection.</param>
        /// 
        /// <returns>Returns a  EnableMetricsCollectionResult from AutoScaling.</returns>
        public  EnableMetricsCollectionResponse EndEnableMetricsCollection(IAsyncResult asyncResult)
        {
            return endOperation< EnableMetricsCollectionResponse>(asyncResult);
        }

        IAsyncResult invokeEnableMetricsCollection(EnableMetricsCollectionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new EnableMetricsCollectionRequestMarshaller().Marshall(request);
            var unmarshaller = EnableMetricsCollectionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  EnterStandby


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby service method.</param>
        /// 
        /// <returns>The response from the EnterStandby service method, as returned by AutoScaling.</returns>
        public EnterStandbyResponse EnterStandby(EnterStandbyRequest request)
        {
            IAsyncResult asyncResult = invokeEnterStandby(request, null, null, true);
            return EndEnterStandby(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnterStandby operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnterStandby
        ///         operation.</returns>
        public IAsyncResult BeginEnterStandby(EnterStandbyRequest request, AsyncCallback callback, object state)
        {
            return invokeEnterStandby(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  EnterStandby operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnterStandby.</param>
        /// 
        /// <returns>Returns a  EnterStandbyResult from AutoScaling.</returns>
        public  EnterStandbyResponse EndEnterStandby(IAsyncResult asyncResult)
        {
            return endOperation< EnterStandbyResponse>(asyncResult);
        }

        IAsyncResult invokeEnterStandby(EnterStandbyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new EnterStandbyRequestMarshaller().Marshall(request);
            var unmarshaller = EnterStandbyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ExecutePolicy


        /// <summary>
        /// Executes the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy service method.</param>
        /// 
        /// <returns>The response from the ExecutePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group        while there are scaling activities
        /// in progress for that group.
        /// </exception>
        public ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest request)
        {
            IAsyncResult asyncResult = invokeExecutePolicy(request, null, null, true);
            return EndExecutePolicy(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecutePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecutePolicy
        ///         operation.</returns>
        public IAsyncResult BeginExecutePolicy(ExecutePolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeExecutePolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecutePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecutePolicy.</param>
        /// 
        /// <returns>Returns a  ExecutePolicyResult from AutoScaling.</returns>
        public  ExecutePolicyResponse EndExecutePolicy(IAsyncResult asyncResult)
        {
            return endOperation< ExecutePolicyResponse>(asyncResult);
        }

        IAsyncResult invokeExecutePolicy(ExecutePolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ExecutePolicyRequestMarshaller().Marshall(request);
            var unmarshaller = ExecutePolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ExitStandby


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby service method.</param>
        /// 
        /// <returns>The response from the ExitStandby service method, as returned by AutoScaling.</returns>
        public ExitStandbyResponse ExitStandby(ExitStandbyRequest request)
        {
            IAsyncResult asyncResult = invokeExitStandby(request, null, null, true);
            return EndExitStandby(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExitStandby operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExitStandby
        ///         operation.</returns>
        public IAsyncResult BeginExitStandby(ExitStandbyRequest request, AsyncCallback callback, object state)
        {
            return invokeExitStandby(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ExitStandby operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExitStandby.</param>
        /// 
        /// <returns>Returns a  ExitStandbyResult from AutoScaling.</returns>
        public  ExitStandbyResponse EndExitStandby(IAsyncResult asyncResult)
        {
            return endOperation< ExitStandbyResponse>(asyncResult);
        }

        IAsyncResult invokeExitStandby(ExitStandbyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ExitStandbyRequestMarshaller().Marshall(request);
            var unmarshaller = ExitStandbyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  PutLifecycleHook


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleHook service method, as returned by AutoScaling.</returns>
        public PutLifecycleHookResponse PutLifecycleHook(PutLifecycleHookRequest request)
        {
            IAsyncResult asyncResult = invokePutLifecycleHook(request, null, null, true);
            return EndPutLifecycleHook(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleHook operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLifecycleHook
        ///         operation.</returns>
        public IAsyncResult BeginPutLifecycleHook(PutLifecycleHookRequest request, AsyncCallback callback, object state)
        {
            return invokePutLifecycleHook(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  PutLifecycleHook operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLifecycleHook.</param>
        /// 
        /// <returns>Returns a  PutLifecycleHookResult from AutoScaling.</returns>
        public  PutLifecycleHookResponse EndPutLifecycleHook(IAsyncResult asyncResult)
        {
            return endOperation< PutLifecycleHookResponse>(asyncResult);
        }

        IAsyncResult invokePutLifecycleHook(PutLifecycleHookRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutLifecycleHookRequestMarshaller().Marshall(request);
            var unmarshaller = PutLifecycleHookResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  PutNotificationConfiguration


        /// <summary>
        /// Configures an Auto Scaling group to send notifications when          
        ///   specified events take place. Subscribers to this topic can have             messages
        /// for events delivered to an endpoint such as a web server             or email address.
        ///         
        /// 
        ///         
        /// <para>
        /// For more information  see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASGettingNotifications.html">Get
        /// Email Notifications When Your Auto Scaling Group Changes</a>
        /// </para>
        ///         
        /// <para>
        /// A new <code>PutNotificationConfiguration</code> overwrites an existing configuration.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="LimitExceededException">
        /// The quota for capacity groups or launch configurations        for this customer
        /// has already been reached.
        /// </exception>
        public PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokePutNotificationConfiguration(request, null, null, true);
            return EndPutNotificationConfiguration(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutNotificationConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginPutNotificationConfiguration(PutNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokePutNotificationConfiguration(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  PutNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  PutNotificationConfigurationResult from AutoScaling.</returns>
        public  PutNotificationConfigurationResponse EndPutNotificationConfiguration(IAsyncResult asyncResult)
        {
            return endOperation< PutNotificationConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokePutNotificationConfiguration(PutNotificationConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutNotificationConfigurationRequestMarshaller().Marshall(request);
            var unmarshaller = PutNotificationConfigurationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  PutScalingPolicy


        /// <summary>
        /// Creates or updates a policy for an Auto Scaling group.             To
        /// update an existing policy, use the existing            policy name and set the parameter(s)
        /// you want to change.             Any existing parameter not changed in an update to
        /// an            existing policy is not changed in this update request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="LimitExceededException">
        /// The quota for capacity groups or launch configurations        for this customer
        /// has already been reached.
        /// </exception>
        public PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            IAsyncResult asyncResult = invokePutScalingPolicy(request, null, null, true);
            return EndPutScalingPolicy(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutScalingPolicy
        ///         operation.</returns>
        public IAsyncResult BeginPutScalingPolicy(PutScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokePutScalingPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  PutScalingPolicy operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScalingPolicy.</param>
        /// 
        /// <returns>Returns a  PutScalingPolicyResult from AutoScaling.</returns>
        public  PutScalingPolicyResponse EndPutScalingPolicy(IAsyncResult asyncResult)
        {
            return endOperation< PutScalingPolicyResponse>(asyncResult);
        }

        IAsyncResult invokePutScalingPolicy(PutScalingPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutScalingPolicyRequestMarshaller().Marshall(request);
            var unmarshaller = PutScalingPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  PutScheduledUpdateGroupAction


        /// <summary>
        /// Creates or updates a scheduled scaling action for an Auto Scaling group.
        ///             When updating a scheduled scaling action, if you leave a parameter unspecified,
        /// the corresponding value             remains unchanged in the affected Auto Scaling
        /// group.        
        /// 
        ///         
        /// <para>
        /// For information on creating or updating a scheduled action for your Auto Scaling group,
        ///             see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/schedule_time.html">Scale
        /// Based on a Schedule</a>.
        /// </para>
        ///         <note>            
        /// <para>
        /// Auto Scaling supports the date and time expressed in "YYYY-MM-DDThh:mm:ssZ" format
        /// in UTC/GMT only.
        /// </para>
        ///         </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction service method.</param>
        /// 
        /// <returns>The response from the PutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The quota for capacity groups or launch configurations        for this customer
        /// has already been reached.
        /// </exception>
        public PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request)
        {
            IAsyncResult asyncResult = invokePutScheduledUpdateGroupAction(request, null, null, true);
            return EndPutScheduledUpdateGroupAction(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutScheduledUpdateGroupAction operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutScheduledUpdateGroupAction
        ///         operation.</returns>
        public IAsyncResult BeginPutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request, AsyncCallback callback, object state)
        {
            return invokePutScheduledUpdateGroupAction(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  PutScheduledUpdateGroupAction operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScheduledUpdateGroupAction.</param>
        /// 
        /// <returns>Returns a  PutScheduledUpdateGroupActionResult from AutoScaling.</returns>
        public  PutScheduledUpdateGroupActionResponse EndPutScheduledUpdateGroupAction(IAsyncResult asyncResult)
        {
            return endOperation< PutScheduledUpdateGroupActionResponse>(asyncResult);
        }

        IAsyncResult invokePutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutScheduledUpdateGroupActionRequestMarshaller().Marshall(request);
            var unmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  RecordLifecycleActionHeartbeat


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat service method.</param>
        /// 
        /// <returns>The response from the RecordLifecycleActionHeartbeat service method, as returned by AutoScaling.</returns>
        public RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request)
        {
            IAsyncResult asyncResult = invokeRecordLifecycleActionHeartbeat(request, null, null, true);
            return EndRecordLifecycleActionHeartbeat(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RecordLifecycleActionHeartbeat operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecordLifecycleActionHeartbeat
        ///         operation.</returns>
        public IAsyncResult BeginRecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request, AsyncCallback callback, object state)
        {
            return invokeRecordLifecycleActionHeartbeat(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RecordLifecycleActionHeartbeat operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecordLifecycleActionHeartbeat.</param>
        /// 
        /// <returns>Returns a  RecordLifecycleActionHeartbeatResult from AutoScaling.</returns>
        public  RecordLifecycleActionHeartbeatResponse EndRecordLifecycleActionHeartbeat(IAsyncResult asyncResult)
        {
            return endOperation< RecordLifecycleActionHeartbeatResponse>(asyncResult);
        }

        IAsyncResult invokeRecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RecordLifecycleActionHeartbeatRequestMarshaller().Marshall(request);
            var unmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ResumeProcesses


        /// <summary>
        /// Resumes all suspended Auto Scaling processes for an Auto Scaling group.
        ///            For information on suspending and resuming Auto Scaling process, see <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend
        /// and Resume Auto Scaling Process</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses service method.</param>
        /// 
        /// <returns>The response from the ResumeProcesses service method, as returned by AutoScaling.</returns>
        public ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest request)
        {
            IAsyncResult asyncResult = invokeResumeProcesses(request, null, null, true);
            return EndResumeProcesses(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeProcesses
        ///         operation.</returns>
        public IAsyncResult BeginResumeProcesses(ResumeProcessesRequest request, AsyncCallback callback, object state)
        {
            return invokeResumeProcesses(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeProcesses.</param>
        /// 
        /// <returns>Returns a  ResumeProcessesResult from AutoScaling.</returns>
        public  ResumeProcessesResponse EndResumeProcesses(IAsyncResult asyncResult)
        {
            return endOperation< ResumeProcessesResponse>(asyncResult);
        }

        IAsyncResult invokeResumeProcesses(ResumeProcessesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ResumeProcessesRequestMarshaller().Marshall(request);
            var unmarshaller = ResumeProcessesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  SetDesiredCapacity


        /// <summary>
        /// Sets the desired size of the specified <a>AutoScalingGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity service method.</param>
        /// 
        /// <returns>The response from the SetDesiredCapacity service method, as returned by AutoScaling.</returns>
        /// <exception cref="ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group        while there are scaling activities
        /// in progress for that group.
        /// </exception>
        public SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest request)
        {
            IAsyncResult asyncResult = invokeSetDesiredCapacity(request, null, null, true);
            return EndSetDesiredCapacity(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetDesiredCapacity operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetDesiredCapacity
        ///         operation.</returns>
        public IAsyncResult BeginSetDesiredCapacity(SetDesiredCapacityRequest request, AsyncCallback callback, object state)
        {
            return invokeSetDesiredCapacity(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetDesiredCapacity operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDesiredCapacity.</param>
        /// 
        /// <returns>Returns a  SetDesiredCapacityResult from AutoScaling.</returns>
        public  SetDesiredCapacityResponse EndSetDesiredCapacity(IAsyncResult asyncResult)
        {
            return endOperation< SetDesiredCapacityResponse>(asyncResult);
        }

        IAsyncResult invokeSetDesiredCapacity(SetDesiredCapacityRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetDesiredCapacityRequestMarshaller().Marshall(request);
            var unmarshaller = SetDesiredCapacityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  SetInstanceHealth


        /// <summary>
        /// Sets the health status of a specified instance that belongs to any of
        /// your Auto Scaling groups.         
        /// 
        ///         
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-configure-healthcheck.html">Configure
        /// Health Checks for Your Auto Scaling group</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth service method.</param>
        /// 
        /// <returns>The response from the SetInstanceHealth service method, as returned by AutoScaling.</returns>
        public SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest request)
        {
            IAsyncResult asyncResult = invokeSetInstanceHealth(request, null, null, true);
            return EndSetInstanceHealth(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetInstanceHealth operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetInstanceHealth
        ///         operation.</returns>
        public IAsyncResult BeginSetInstanceHealth(SetInstanceHealthRequest request, AsyncCallback callback, object state)
        {
            return invokeSetInstanceHealth(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetInstanceHealth operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetInstanceHealth.</param>
        /// 
        /// <returns>Returns a  SetInstanceHealthResult from AutoScaling.</returns>
        public  SetInstanceHealthResponse EndSetInstanceHealth(IAsyncResult asyncResult)
        {
            return endOperation< SetInstanceHealthResponse>(asyncResult);
        }

        IAsyncResult invokeSetInstanceHealth(SetInstanceHealthRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetInstanceHealthRequestMarshaller().Marshall(request);
            var unmarshaller = SetInstanceHealthResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  SuspendProcesses


        /// <summary>
        /// Suspends Auto Scaling processes for an Auto Scaling group.           
        /// To suspend specific process types, specify them by name            with the <code>ScalingProcesses.member.N</code>
        /// parameter.            To suspend all process types, omit the <code>ScalingProcesses.member.N</code>
        ///            parameter.         
        /// 
        ///         <important>            
        /// <para>
        ///                 Suspending either of the two primary process types,              
        ///  <code>Launch</code> or <code>Terminate</code>,                can prevent other process
        /// types from functioning                properly.             
        /// </para>
        ///         </important>        
        /// <para>
        ///             To resume processes that have been suspended,            use <a>ResumeProcesses</a>
        /// For more information on suspending and resuming Auto Scaling process,            
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend
        /// and Resume Auto Scaling Process</a>.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses service method.</param>
        /// 
        /// <returns>The response from the SuspendProcesses service method, as returned by AutoScaling.</returns>
        public SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest request)
        {
            IAsyncResult asyncResult = invokeSuspendProcesses(request, null, null, true);
            return EndSuspendProcesses(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SuspendProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSuspendProcesses
        ///         operation.</returns>
        public IAsyncResult BeginSuspendProcesses(SuspendProcessesRequest request, AsyncCallback callback, object state)
        {
            return invokeSuspendProcesses(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SuspendProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSuspendProcesses.</param>
        /// 
        /// <returns>Returns a  SuspendProcessesResult from AutoScaling.</returns>
        public  SuspendProcessesResponse EndSuspendProcesses(IAsyncResult asyncResult)
        {
            return endOperation< SuspendProcessesResponse>(asyncResult);
        }

        IAsyncResult invokeSuspendProcesses(SuspendProcessesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SuspendProcessesRequestMarshaller().Marshall(request);
            var unmarshaller = SuspendProcessesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  TerminateInstanceInAutoScalingGroup


        /// <summary>
        /// Terminates the specified instance.        Optionally, the desired group size
        /// can be adjusted.        
        /// 
        ///         <note>        This call simply registers a termination request.        The
        /// termination of the instance cannot happen immediately.        </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group        while there are scaling activities
        /// in progress for that group.
        /// </exception>
        public TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request)
        {
            IAsyncResult asyncResult = invokeTerminateInstanceInAutoScalingGroup(request, null, null, true);
            return EndTerminateInstanceInAutoScalingGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstanceInAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateInstanceInAutoScalingGroup
        ///         operation.</returns>
        public IAsyncResult BeginTerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeTerminateInstanceInAutoScalingGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateInstanceInAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateInstanceInAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  TerminateInstanceInAutoScalingGroupResult from AutoScaling.</returns>
        public  TerminateInstanceInAutoScalingGroupResponse EndTerminateInstanceInAutoScalingGroup(IAsyncResult asyncResult)
        {
            return endOperation< TerminateInstanceInAutoScalingGroupResponse>(asyncResult);
        }

        IAsyncResult invokeTerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new TerminateInstanceInAutoScalingGroupRequestMarshaller().Marshall(request);
            var unmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  UpdateAutoScalingGroup


        /// <summary>
        /// Updates the configuration for the specified <a>AutoScalingGroup</a>.     
        ///   
        /// 
        ///         <note>            
        /// <para>
        ///                 To update an Auto Scaling group with a launch configuration      
        ///          that has the <code>InstanceMonitoring</code> flag                set to <code>False</code>,
        /// you must first ensure that collection                of group metrics is disabled.
        /// Otherwise, calls to                 <a>UpdateAutoScalingGroup</a> will fail.     
        ///           If you have previously enabled group metrics collection,               
        ///  you can disable collection of all group metrics                by calling <a>DisableMetricsCollection</a>.
        ///                            
        /// </para>
        ///         </note>        
        /// <para>
        ///         The new settings are registered upon the completion of this call.        Any
        /// launch configuration settings take effect on any triggers after        this call returns.
        ///        Scaling activities that are currently in progress aren't affected.        
        /// </para>
        ///         <note>            <ul>                <li>                    
        /// <para>
        /// If a new value is specified for <i>MinSize</i> without specifying the value for <i>DesiredCapacity</i>,
        ///                         and if the new <i>MinSize</i> is larger than the current size
        /// of the Auto Scaling Group, there                        will be an implicit call to
        /// <a>SetDesiredCapacity</a> to set the group to the new <i>MinSize</i>. 
        /// </para>
        ///                 </li>                <li>                    
        /// <para>
        /// If a new value is specified for <i>MaxSize</i> without specifying the value for <i>DesiredCapacity</i>,
        /// and                         the new <i>MaxSize</i> is smaller than the current size
        /// of the Auto Scaling Group, there will                         be an implicit call
        /// to <a>SetDesiredCapacity</a> to set the group to the new <i>MaxSize</i>. 
        /// </para>
        ///                 </li>                <li>                    
        /// <para>
        /// All other optional parameters are left unchanged if not passed in the request.
        /// </para>
        ///                 </li>            </ul>        </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group        while there are scaling activities
        /// in progress for that group.
        /// </exception>
        public UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateAutoScalingGroup(request, null, null, true);
            return EndUpdateAutoScalingGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAutoScalingGroup
        ///         operation.</returns>
        public IAsyncResult BeginUpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateAutoScalingGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  UpdateAutoScalingGroupResult from AutoScaling.</returns>
        public  UpdateAutoScalingGroupResponse EndUpdateAutoScalingGroup(IAsyncResult asyncResult)
        {
            return endOperation< UpdateAutoScalingGroupResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateAutoScalingGroupRequestMarshaller().Marshall(request);
            var unmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
    }
}