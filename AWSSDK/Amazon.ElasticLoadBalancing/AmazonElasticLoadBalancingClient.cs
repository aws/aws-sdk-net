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

using Amazon.ElasticLoadBalancing.Model;
using Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Implementation for accessing AmazonElasticLoadBalancing.
    ///  
    /// Elastic Load Balancing <para> Elastic Load Balancing is a cost-effective and easy to use web service to help you improve the availability
    /// and scalability of your application running on Amazon Elastic Cloud Compute (Amazon EC2). It makes it easy for you to distribute application
    /// loads between two or more EC2 instances. Elastic Load Balancing supports the growth in traffic of your application by enabling availability
    /// through redundancy. </para> <para>This guide provides detailed information about Elastic Load Balancing actions, data types, and parameters
    /// that can be used for sending a query request. Query requests are HTTP or HTTPS requests that use the HTTP verb GET or POST and a query
    /// parameter named Action or Operation. Action is used throughout this documentation, although Operation is supported for backward
    /// compatibility with other AWS Query APIs.</para> <para>For detailed information on constructing a query request using the actions, data
    /// types, and parameters mentioned in this guide, go to Using the Query API in the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// <para>For detailed information about Elastic Load Balancing features and their associated actions, go to Using Elastic Load Balancing in the
    /// <i>Elastic Load Balancing Developer Guide</i> .</para> <para>This reference guide is based on the current WSDL, which is available at:
    /// </para>
    /// </summary>
    public class AmazonElasticLoadBalancingClient : AmazonWebServiceClient, AmazonElasticLoadBalancing
    {
    
        AbstractAWSSigner signer = new AWS4Signer();

        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig(), true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticLoadBalancing Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AmazonElasticLoadBalancingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticLoadBalancingConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials and an
        /// AmazonElasticLoadBalancingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, AmazonElasticLoadBalancingConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticLoadBalancingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User)
        {
        }
        

        #endregion
   
        #region DescribeLoadBalancerPolicyTypes

        /// <summary>
        /// <para> Returns meta-information on the specified LoadBalancer policies defined by the Elastic Load Balancing service. The policy types that
        /// are returned from this action can be used in a CreateLoadBalancerPolicy action to instantiate specific policy configurations that will be
        /// applied to an Elastic LoadBalancer. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPolicyTypesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes
        ///          service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyTypeNotFoundException"/>
        public DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest describeLoadBalancerPolicyTypesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeLoadBalancerPolicyTypes(describeLoadBalancerPolicyTypesRequest, null, null, true);
            return EndDescribeLoadBalancerPolicyTypes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancerPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPolicyTypesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeLoadBalancerPolicyTypes operation.</returns>
        public IAsyncResult BeginDescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest describeLoadBalancerPolicyTypesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeLoadBalancerPolicyTypes(describeLoadBalancerPolicyTypesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancerPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerPolicyTypes.</param>
        /// 
        /// <returns>Returns a DescribeLoadBalancerPolicyTypesResult from AmazonElasticLoadBalancing.</returns>
        public DescribeLoadBalancerPolicyTypesResponse EndDescribeLoadBalancerPolicyTypes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeLoadBalancerPolicyTypesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest describeLoadBalancerPolicyTypesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLoadBalancerPolicyTypesRequestMarshaller().Marshall(describeLoadBalancerPolicyTypesRequest);
            var unmarshaller = DescribeLoadBalancerPolicyTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns meta-information on the specified LoadBalancer policies defined by the Elastic Load Balancing service. The policy types that
        /// are returned from this action can be used in a CreateLoadBalancerPolicy action to instantiate specific policy configurations that will be
        /// applied to an Elastic LoadBalancer. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyTypeNotFoundException"/>
        public DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes()
        {
            return DescribeLoadBalancerPolicyTypes(new DescribeLoadBalancerPolicyTypesRequest());
        }
        

        #endregion
    
        #region ConfigureHealthCheck

        /// <summary>
        /// <para> Enables the client to define an application healthcheck for the instances. </para>
        /// </summary>
        /// 
        /// <param name="configureHealthCheckRequest">Container for the necessary parameters to execute the ConfigureHealthCheck service method on
        ///          AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the ConfigureHealthCheck service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        public ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest configureHealthCheckRequest)
        {
            IAsyncResult asyncResult = invokeConfigureHealthCheck(configureHealthCheckRequest, null, null, true);
            return EndConfigureHealthCheck(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureHealthCheck operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ConfigureHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="configureHealthCheckRequest">Container for the necessary parameters to execute the ConfigureHealthCheck operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndConfigureHealthCheck operation.</returns>
        public IAsyncResult BeginConfigureHealthCheck(ConfigureHealthCheckRequest configureHealthCheckRequest, AsyncCallback callback, object state)
        {
            return invokeConfigureHealthCheck(configureHealthCheckRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ConfigureHealthCheck operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ConfigureHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureHealthCheck.</param>
        /// 
        /// <returns>Returns a ConfigureHealthCheckResult from AmazonElasticLoadBalancing.</returns>
        public ConfigureHealthCheckResponse EndConfigureHealthCheck(IAsyncResult asyncResult)
        {
            return endOperation<ConfigureHealthCheckResponse>(asyncResult);
        }
        
        IAsyncResult invokeConfigureHealthCheck(ConfigureHealthCheckRequest configureHealthCheckRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ConfigureHealthCheckRequestMarshaller().Marshall(configureHealthCheckRequest);
            var unmarshaller = ConfigureHealthCheckResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DetachLoadBalancerFromSubnets

        /// <summary>
        /// <para> Removes subnets from the set of configured subnets in the VPC for the LoadBalancer. </para> <para> After a subnet is removed all of
        /// the EndPoints registered with the LoadBalancer that are in the removed subnet will go into the <i>OutOfService</i> state. When a subnet is
        /// removed, the LoadBalancer will balance the traffic among the remaining routable subnets for the LoadBalancer. </para>
        /// </summary>
        /// 
        /// <param name="detachLoadBalancerFromSubnetsRequest">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets
        ///          service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerFromSubnets service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        public DetachLoadBalancerFromSubnetsResponse DetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest detachLoadBalancerFromSubnetsRequest)
        {
            IAsyncResult asyncResult = invokeDetachLoadBalancerFromSubnets(detachLoadBalancerFromSubnetsRequest, null, null, true);
            return EndDetachLoadBalancerFromSubnets(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DetachLoadBalancerFromSubnets"/>
        /// </summary>
        /// 
        /// <param name="detachLoadBalancerFromSubnetsRequest">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDetachLoadBalancerFromSubnets operation.</returns>
        public IAsyncResult BeginDetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest detachLoadBalancerFromSubnetsRequest, AsyncCallback callback, object state)
        {
            return invokeDetachLoadBalancerFromSubnets(detachLoadBalancerFromSubnetsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DetachLoadBalancerFromSubnets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachLoadBalancerFromSubnets.</param>
        /// 
        /// <returns>Returns a DetachLoadBalancerFromSubnetsResult from AmazonElasticLoadBalancing.</returns>
        public DetachLoadBalancerFromSubnetsResponse EndDetachLoadBalancerFromSubnets(IAsyncResult asyncResult)
        {
            return endOperation<DetachLoadBalancerFromSubnetsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest detachLoadBalancerFromSubnetsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DetachLoadBalancerFromSubnetsRequestMarshaller().Marshall(detachLoadBalancerFromSubnetsRequest);
            var unmarshaller = DetachLoadBalancerFromSubnetsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeLoadBalancerPolicies

        /// <summary>
        /// <para>Returns detailed descriptions of the policies. If you specify a LoadBalancer name, the operation returns either the descriptions of
        /// the specified policies, or descriptions of all the policies created for the LoadBalancer. If you don't specify a LoadBalancer name, the
        /// operation returns descriptions of the specified sample policies, or descriptions of all the sample policies. The names of the sample
        /// policies have the <c>ELBSample-</c> prefix. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPoliciesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies service
        ///          method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyNotFoundException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        public DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest describeLoadBalancerPoliciesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeLoadBalancerPolicies(describeLoadBalancerPoliciesRequest, null, null, true);
            return EndDescribeLoadBalancerPolicies(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancerPolicies"/>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPoliciesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeLoadBalancerPolicies operation.</returns>
        public IAsyncResult BeginDescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest describeLoadBalancerPoliciesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeLoadBalancerPolicies(describeLoadBalancerPoliciesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancerPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerPolicies.</param>
        /// 
        /// <returns>Returns a DescribeLoadBalancerPoliciesResult from AmazonElasticLoadBalancing.</returns>
        public DescribeLoadBalancerPoliciesResponse EndDescribeLoadBalancerPolicies(IAsyncResult asyncResult)
        {
            return endOperation<DescribeLoadBalancerPoliciesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest describeLoadBalancerPoliciesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLoadBalancerPoliciesRequestMarshaller().Marshall(describeLoadBalancerPoliciesRequest);
            var unmarshaller = DescribeLoadBalancerPoliciesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns detailed descriptions of the policies. If you specify a LoadBalancer name, the operation returns either the descriptions of
        /// the specified policies, or descriptions of all the policies created for the LoadBalancer. If you don't specify a LoadBalancer name, the
        /// operation returns descriptions of the specified sample policies, or descriptions of all the sample policies. The names of the sample
        /// policies have the <c>ELBSample-</c> prefix. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyNotFoundException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        public DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies()
        {
            return DescribeLoadBalancerPolicies(new DescribeLoadBalancerPoliciesRequest());
        }
        

        #endregion
    
        #region SetLoadBalancerPoliciesOfListener

        /// <summary>
        /// <para> Associates, updates, or disables a policy with a listener on the LoadBalancer. You can associate multiple policies with a listener.
        /// </para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesOfListenerRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerPoliciesOfListener service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesOfListener service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyNotFoundException"/>
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="ListenerNotFoundException"/>
        public SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest setLoadBalancerPoliciesOfListenerRequest)
        {
            IAsyncResult asyncResult = invokeSetLoadBalancerPoliciesOfListener(setLoadBalancerPoliciesOfListenerRequest, null, null, true);
            return EndSetLoadBalancerPoliciesOfListener(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerPoliciesOfListener"/>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesOfListenerRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerPoliciesOfListener operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndSetLoadBalancerPoliciesOfListener operation.</returns>
        public IAsyncResult BeginSetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest setLoadBalancerPoliciesOfListenerRequest, AsyncCallback callback, object state)
        {
            return invokeSetLoadBalancerPoliciesOfListener(setLoadBalancerPoliciesOfListenerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerPoliciesOfListener"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerPoliciesOfListener.</param>
        /// 
        /// <returns>Returns a SetLoadBalancerPoliciesOfListenerResult from AmazonElasticLoadBalancing.</returns>
        public SetLoadBalancerPoliciesOfListenerResponse EndSetLoadBalancerPoliciesOfListener(IAsyncResult asyncResult)
        {
            return endOperation<SetLoadBalancerPoliciesOfListenerResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest setLoadBalancerPoliciesOfListenerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetLoadBalancerPoliciesOfListenerRequestMarshaller().Marshall(setLoadBalancerPoliciesOfListenerRequest);
            var unmarshaller = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DisableAvailabilityZonesForLoadBalancer

        /// <summary>
        /// <para> Removes the specified EC2 Availability Zones from the set of configured Availability Zones for the LoadBalancer. </para> <para> There
        /// must be at least one Availability Zone registered with a LoadBalancer at all times. A client cannot remove all the Availability Zones from a
        /// LoadBalancer. Once an Availability Zone is removed, all the instances registered with the LoadBalancer that are in the removed Availability
        /// Zone go into the OutOfService state. Upon Availability Zone removal, the LoadBalancer attempts to equally balance the traffic among its
        /// remaining usable Availability Zones. Trying to remove an Availability Zone that was not associated with the LoadBalancer does nothing.
        /// </para> <para><b>NOTE:</b> In order for this call to be successful, the client must have created the LoadBalancer. The client must provide
        /// the same account credentials as those that were used to create the LoadBalancer. </para>
        /// </summary>
        /// 
        /// <param name="disableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          DisableAvailabilityZonesForLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DisableAvailabilityZonesForLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        public DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest disableAvailabilityZonesForLoadBalancerRequest)
        {
            IAsyncResult asyncResult = invokeDisableAvailabilityZonesForLoadBalancer(disableAvailabilityZonesForLoadBalancerRequest, null, null, true);
            return EndDisableAvailabilityZonesForLoadBalancer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DisableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="disableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          DisableAvailabilityZonesForLoadBalancer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDisableAvailabilityZonesForLoadBalancer operation.</returns>
        public IAsyncResult BeginDisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest disableAvailabilityZonesForLoadBalancerRequest, AsyncCallback callback, object state)
        {
            return invokeDisableAvailabilityZonesForLoadBalancer(disableAvailabilityZonesForLoadBalancerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DisableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableAvailabilityZonesForLoadBalancer.</param>
        /// 
        /// <returns>Returns a DisableAvailabilityZonesForLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        public DisableAvailabilityZonesForLoadBalancerResponse EndDisableAvailabilityZonesForLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation<DisableAvailabilityZonesForLoadBalancerResponse>(asyncResult);
        }
        
        IAsyncResult invokeDisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest disableAvailabilityZonesForLoadBalancerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DisableAvailabilityZonesForLoadBalancerRequestMarshaller().Marshall(disableAvailabilityZonesForLoadBalancerRequest);
            var unmarshaller = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeInstanceHealth

        /// <summary>
        /// <para> Returns the current state of the instances of the specified LoadBalancer. If no instances are specified, the state of all the
        /// instances for the LoadBalancer is returned. </para> <para><b>NOTE:</b> The client must have created the specified input LoadBalancer in
        /// order to retrieve this information; the client must provide the same account credentials as those that were used to create the LoadBalancer.
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeInstanceHealthRequest">Container for the necessary parameters to execute the DescribeInstanceHealth service method on
        ///          AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeInstanceHealth service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="InvalidInstanceException"/>
        public DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest describeInstanceHealthRequest)
        {
            IAsyncResult asyncResult = invokeDescribeInstanceHealth(describeInstanceHealthRequest, null, null, true);
            return EndDescribeInstanceHealth(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceHealth operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="describeInstanceHealthRequest">Container for the necessary parameters to execute the DescribeInstanceHealth operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeInstanceHealth operation.</returns>
        public IAsyncResult BeginDescribeInstanceHealth(DescribeInstanceHealthRequest describeInstanceHealthRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeInstanceHealth(describeInstanceHealthRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInstanceHealth operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceHealth.</param>
        /// 
        /// <returns>Returns a DescribeInstanceHealthResult from AmazonElasticLoadBalancing.</returns>
        public DescribeInstanceHealthResponse EndDescribeInstanceHealth(IAsyncResult asyncResult)
        {
            return endOperation<DescribeInstanceHealthResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeInstanceHealth(DescribeInstanceHealthRequest describeInstanceHealthRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeInstanceHealthRequestMarshaller().Marshall(describeInstanceHealthRequest);
            var unmarshaller = DescribeInstanceHealthResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteLoadBalancerPolicy

        /// <summary>
        /// <para> Deletes a policy from the LoadBalancer. The specified policy must not be enabled for any listeners. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerPolicyRequest">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy service method
        ///          on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        public DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest deleteLoadBalancerPolicyRequest)
        {
            IAsyncResult asyncResult = invokeDeleteLoadBalancerPolicy(deleteLoadBalancerPolicyRequest, null, null, true);
            return EndDeleteLoadBalancerPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerPolicyRequest">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteLoadBalancerPolicy operation.</returns>
        public IAsyncResult BeginDeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest deleteLoadBalancerPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteLoadBalancerPolicy(deleteLoadBalancerPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancerPolicy.</param>
        /// 
        /// <returns>Returns a DeleteLoadBalancerPolicyResult from AmazonElasticLoadBalancing.</returns>
        public DeleteLoadBalancerPolicyResponse EndDeleteLoadBalancerPolicy(IAsyncResult asyncResult)
        {
            return endOperation<DeleteLoadBalancerPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest deleteLoadBalancerPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteLoadBalancerPolicyRequestMarshaller().Marshall(deleteLoadBalancerPolicyRequest);
            var unmarshaller = DeleteLoadBalancerPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateLoadBalancerPolicy

        /// <summary>
        /// <para> Creates a new policy that contains the necessary attributes depending on the policy type. Policies are settings that are saved for
        /// your Elastic LoadBalancer and that can be applied to the front-end listener, or the back-end application server, depending on your policy
        /// type. </para>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerPolicyRequest">Container for the necessary parameters to execute the CreateLoadBalancerPolicy service method
        ///          on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyTypeNotFoundException"/>
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="DuplicatePolicyNameException"/>
        /// <exception cref="TooManyPoliciesException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        public CreateLoadBalancerPolicyResponse CreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest createLoadBalancerPolicyRequest)
        {
            IAsyncResult asyncResult = invokeCreateLoadBalancerPolicy(createLoadBalancerPolicyRequest, null, null, true);
            return EndCreateLoadBalancerPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerPolicyRequest">Container for the necessary parameters to execute the CreateLoadBalancerPolicy operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateLoadBalancerPolicy operation.</returns>
        public IAsyncResult BeginCreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest createLoadBalancerPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeCreateLoadBalancerPolicy(createLoadBalancerPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancerPolicy.</param>
        /// 
        /// <returns>Returns a CreateLoadBalancerPolicyResult from AmazonElasticLoadBalancing.</returns>
        public CreateLoadBalancerPolicyResponse EndCreateLoadBalancerPolicy(IAsyncResult asyncResult)
        {
            return endOperation<CreateLoadBalancerPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest createLoadBalancerPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateLoadBalancerPolicyRequestMarshaller().Marshall(createLoadBalancerPolicyRequest);
            var unmarshaller = CreateLoadBalancerPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region EnableAvailabilityZonesForLoadBalancer

        /// <summary>
        /// <para> Adds one or more EC2 Availability Zones to the LoadBalancer. </para> <para> The LoadBalancer evenly distributes requests across all
        /// its registered Availability Zones that contain instances. As a result, the client must ensure that its LoadBalancer is appropriately scaled
        /// for each registered Availability Zone. </para> <para><b>NOTE:</b> The new EC2 Availability Zones to be added must be in the same EC2 Region
        /// as the Availability Zones for which the LoadBalancer was created. </para>
        /// </summary>
        /// 
        /// <param name="enableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          EnableAvailabilityZonesForLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the EnableAvailabilityZonesForLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        public EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest enableAvailabilityZonesForLoadBalancerRequest)
        {
            IAsyncResult asyncResult = invokeEnableAvailabilityZonesForLoadBalancer(enableAvailabilityZonesForLoadBalancerRequest, null, null, true);
            return EndEnableAvailabilityZonesForLoadBalancer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.EnableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="enableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          EnableAvailabilityZonesForLoadBalancer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndEnableAvailabilityZonesForLoadBalancer operation.</returns>
        public IAsyncResult BeginEnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest enableAvailabilityZonesForLoadBalancerRequest, AsyncCallback callback, object state)
        {
            return invokeEnableAvailabilityZonesForLoadBalancer(enableAvailabilityZonesForLoadBalancerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.EnableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAvailabilityZonesForLoadBalancer.</param>
        /// 
        /// <returns>Returns a EnableAvailabilityZonesForLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        public EnableAvailabilityZonesForLoadBalancerResponse EndEnableAvailabilityZonesForLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation<EnableAvailabilityZonesForLoadBalancerResponse>(asyncResult);
        }
        
        IAsyncResult invokeEnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest enableAvailabilityZonesForLoadBalancerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new EnableAvailabilityZonesForLoadBalancerRequestMarshaller().Marshall(enableAvailabilityZonesForLoadBalancerRequest);
            var unmarshaller = EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateLoadBalancerListeners

        /// <summary>
        /// <para> Creates one or more listeners on a LoadBalancer for the specified port. If a listener with the given port does not already exist, it
        /// will be created; otherwise, the properties of the new listener must match the properties of the existing listener. </para>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerListenersRequest">Container for the necessary parameters to execute the CreateLoadBalancerListeners service
        ///          method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerListeners service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="DuplicateListenerException"/>
        /// <exception cref="CertificateNotFoundException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        public CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest createLoadBalancerListenersRequest)
        {
            IAsyncResult asyncResult = invokeCreateLoadBalancerListeners(createLoadBalancerListenersRequest, null, null, true);
            return EndCreateLoadBalancerListeners(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerListenersRequest">Container for the necessary parameters to execute the CreateLoadBalancerListeners operation
        ///          on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateLoadBalancerListeners operation.</returns>
        public IAsyncResult BeginCreateLoadBalancerListeners(CreateLoadBalancerListenersRequest createLoadBalancerListenersRequest, AsyncCallback callback, object state)
        {
            return invokeCreateLoadBalancerListeners(createLoadBalancerListenersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancerListeners.</param>
        /// 
        /// <returns>Returns a CreateLoadBalancerListenersResult from AmazonElasticLoadBalancing.</returns>
        public CreateLoadBalancerListenersResponse EndCreateLoadBalancerListeners(IAsyncResult asyncResult)
        {
            return endOperation<CreateLoadBalancerListenersResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateLoadBalancerListeners(CreateLoadBalancerListenersRequest createLoadBalancerListenersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateLoadBalancerListenersRequestMarshaller().Marshall(createLoadBalancerListenersRequest);
            var unmarshaller = CreateLoadBalancerListenersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateLoadBalancer

        /// <summary>
        /// <para> Creates a new LoadBalancer. </para> <para> After the call has completed successfully, a new LoadBalancer is created; however, it will
        /// not be usable until at least one instance has been registered. When the LoadBalancer creation is completed, the client can check whether or
        /// not it is usable by using the DescribeInstanceHealth action. The LoadBalancer is usable as soon as any registered instance is
        /// <i>InService</i> .
        /// </para> <para><b>NOTE:</b> Currently, the client's quota of LoadBalancers is limited to ten per Region. </para> <para><b>NOTE:</b>
        /// LoadBalancer DNS names vary depending on the Region they're created in. For LoadBalancers created in the United States, the DNS name ends
        /// with: us-east-1.elb.amazonaws.com (for the US Standard Region) us-west-1.elb.amazonaws.com (for the Northern California Region) For
        /// LoadBalancers created in the EU (Ireland) Region, the DNS name ends with: eu-west-1.elb.amazonaws.com </para> <para>For information on using
        /// CreateLoadBalancer to create a new LoadBalancer in Amazon EC2, go to Using Query API section in the <i>Creating a Load Balancer With SSL
        /// Cipher Settings and Back-end Authentication</i> topic of the <i>Elastic Load Balancing Developer Guide</i> .</para> <para>For information on
        /// using CreateLoadBalancer to create a new LoadBalancer in Amazon VPC, go to Using Query API section in the <i>Creating a Basic Load Balancer
        /// in Amazon VPC</i> topic of the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerRequest">Container for the necessary parameters to execute the CreateLoadBalancer service method on
        ///          AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="InvalidSecurityGroupException"/>
        /// <exception cref="CertificateNotFoundException"/>
        /// <exception cref="InvalidSchemeException"/>
        /// <exception cref="DuplicateLoadBalancerNameException"/>
        /// <exception cref="TooManyLoadBalancersException"/>
        /// <exception cref="SubnetNotFoundException"/>
        public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest createLoadBalancerRequest)
        {
            IAsyncResult asyncResult = invokeCreateLoadBalancer(createLoadBalancerRequest, null, null, true);
            return EndCreateLoadBalancer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerRequest">Container for the necessary parameters to execute the CreateLoadBalancer operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateLoadBalancer operation.</returns>
        public IAsyncResult BeginCreateLoadBalancer(CreateLoadBalancerRequest createLoadBalancerRequest, AsyncCallback callback, object state)
        {
            return invokeCreateLoadBalancer(createLoadBalancerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancer.</param>
        /// 
        /// <returns>Returns a CreateLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        public CreateLoadBalancerResponse EndCreateLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation<CreateLoadBalancerResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateLoadBalancer(CreateLoadBalancerRequest createLoadBalancerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateLoadBalancerRequestMarshaller().Marshall(createLoadBalancerRequest);
            var unmarshaller = CreateLoadBalancerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteLoadBalancer

        /// <summary>
        /// <para> Deletes the specified LoadBalancer. </para> <para> If attempting to recreate the LoadBalancer, the client must reconfigure all the
        /// settings. The DNS name associated with a deleted LoadBalancer will no longer be usable. Once deleted, the name and associated DNS record of
        /// the LoadBalancer no longer exist and traffic sent to any of its IP addresses will no longer be delivered to client instances. The client
        /// will not receive the same DNS name even if a new LoadBalancer with same LoadBalancerName is created. </para> <para> To successfully call
        /// this API, the client must provide the same account credentials as were used to create the LoadBalancer. </para> <para><b>NOTE:</b> By
        /// design, if the LoadBalancer does not exist or has already been deleted, DeleteLoadBalancer still succeeds. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerRequest">Container for the necessary parameters to execute the DeleteLoadBalancer service method on
        ///          AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest deleteLoadBalancerRequest)
        {
            IAsyncResult asyncResult = invokeDeleteLoadBalancer(deleteLoadBalancerRequest, null, null, true);
            return EndDeleteLoadBalancer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerRequest">Container for the necessary parameters to execute the DeleteLoadBalancer operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteLoadBalancer operation.</returns>
        public IAsyncResult BeginDeleteLoadBalancer(DeleteLoadBalancerRequest deleteLoadBalancerRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteLoadBalancer(deleteLoadBalancerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancer.</param>
        /// 
        /// <returns>Returns a DeleteLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        public DeleteLoadBalancerResponse EndDeleteLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation<DeleteLoadBalancerResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteLoadBalancer(DeleteLoadBalancerRequest deleteLoadBalancerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteLoadBalancerRequestMarshaller().Marshall(deleteLoadBalancerRequest);
            var unmarshaller = DeleteLoadBalancerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetLoadBalancerPoliciesForBackendServer

        /// <summary>
        /// <para> Replaces the current set of policies associated with a port on which the back-end server is listening with a new set of policies.
        /// After the policies have been created using CreateLoadBalancerPolicy, they can be applied here as a list. At this time, only the back-end
        /// server authentication policy type can be applied to the back-end ports; this policy type is composed of multiple public key policies.
        /// </para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesForBackendServerRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerPoliciesForBackendServer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesForBackendServer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyNotFoundException"/>
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        public SetLoadBalancerPoliciesForBackendServerResponse SetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest setLoadBalancerPoliciesForBackendServerRequest)
        {
            IAsyncResult asyncResult = invokeSetLoadBalancerPoliciesForBackendServer(setLoadBalancerPoliciesForBackendServerRequest, null, null, true);
            return EndSetLoadBalancerPoliciesForBackendServer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerPoliciesForBackendServer"/>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesForBackendServerRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerPoliciesForBackendServer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndSetLoadBalancerPoliciesForBackendServer operation.</returns>
        public IAsyncResult BeginSetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest setLoadBalancerPoliciesForBackendServerRequest, AsyncCallback callback, object state)
        {
            return invokeSetLoadBalancerPoliciesForBackendServer(setLoadBalancerPoliciesForBackendServerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerPoliciesForBackendServer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerPoliciesForBackendServer.</param>
        /// 
        /// <returns>Returns a SetLoadBalancerPoliciesForBackendServerResult from AmazonElasticLoadBalancing.</returns>
        public SetLoadBalancerPoliciesForBackendServerResponse EndSetLoadBalancerPoliciesForBackendServer(IAsyncResult asyncResult)
        {
            return endOperation<SetLoadBalancerPoliciesForBackendServerResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest setLoadBalancerPoliciesForBackendServerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetLoadBalancerPoliciesForBackendServerRequestMarshaller().Marshall(setLoadBalancerPoliciesForBackendServerRequest);
            var unmarshaller = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteLoadBalancerListeners

        /// <summary>
        /// <para> Deletes listeners from the LoadBalancer for the specified port. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerListenersRequest">Container for the necessary parameters to execute the DeleteLoadBalancerListeners service
        ///          method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerListeners service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest deleteLoadBalancerListenersRequest)
        {
            IAsyncResult asyncResult = invokeDeleteLoadBalancerListeners(deleteLoadBalancerListenersRequest, null, null, true);
            return EndDeleteLoadBalancerListeners(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerListenersRequest">Container for the necessary parameters to execute the DeleteLoadBalancerListeners operation
        ///          on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteLoadBalancerListeners operation.</returns>
        public IAsyncResult BeginDeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest deleteLoadBalancerListenersRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteLoadBalancerListeners(deleteLoadBalancerListenersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancerListeners.</param>
        /// 
        /// <returns>Returns a DeleteLoadBalancerListenersResult from AmazonElasticLoadBalancing.</returns>
        public DeleteLoadBalancerListenersResponse EndDeleteLoadBalancerListeners(IAsyncResult asyncResult)
        {
            return endOperation<DeleteLoadBalancerListenersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest deleteLoadBalancerListenersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteLoadBalancerListenersRequestMarshaller().Marshall(deleteLoadBalancerListenersRequest);
            var unmarshaller = DeleteLoadBalancerListenersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeregisterInstancesFromLoadBalancer

        /// <summary>
        /// <para> Deregisters instances from the LoadBalancer. Once the instance is deregistered, it will stop receiving traffic from the LoadBalancer.
        /// </para> <para> In order to successfully call this API, the same account credentials as those used to create the LoadBalancer must be
        /// provided. </para>
        /// </summary>
        /// 
        /// <param name="deregisterInstancesFromLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          DeregisterInstancesFromLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeregisterInstancesFromLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="InvalidInstanceException"/>
        public DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest deregisterInstancesFromLoadBalancerRequest)
        {
            IAsyncResult asyncResult = invokeDeregisterInstancesFromLoadBalancer(deregisterInstancesFromLoadBalancerRequest, null, null, true);
            return EndDeregisterInstancesFromLoadBalancer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeregisterInstancesFromLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="deregisterInstancesFromLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          DeregisterInstancesFromLoadBalancer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeregisterInstancesFromLoadBalancer operation.</returns>
        public IAsyncResult BeginDeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest deregisterInstancesFromLoadBalancerRequest, AsyncCallback callback, object state)
        {
            return invokeDeregisterInstancesFromLoadBalancer(deregisterInstancesFromLoadBalancerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeregisterInstancesFromLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterInstancesFromLoadBalancer.</param>
        /// 
        /// <returns>Returns a DeregisterInstancesFromLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        public DeregisterInstancesFromLoadBalancerResponse EndDeregisterInstancesFromLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation<DeregisterInstancesFromLoadBalancerResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest deregisterInstancesFromLoadBalancerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeregisterInstancesFromLoadBalancerRequestMarshaller().Marshall(deregisterInstancesFromLoadBalancerRequest);
            var unmarshaller = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetLoadBalancerListenerSSLCertificate

        /// <summary>
        /// <para> Sets the certificate that terminates the specified listener's SSL connections. The specified certificate replaces any prior
        /// certificate that was used on the same LoadBalancer and port. </para> <para>For information on using SetLoadBalancerListenerSSLCertificate,
        /// go to Using the Query API in <i>Updating an SSL Certificate for a Load Balancer</i> section of the <i>Elastic Load Balancing Developer
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerListenerSSLCertificateRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerListenerSSLCertificate service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerListenerSSLCertificate service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="CertificateNotFoundException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="ListenerNotFoundException"/>
        public SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest setLoadBalancerListenerSSLCertificateRequest)
        {
            IAsyncResult asyncResult = invokeSetLoadBalancerListenerSSLCertificate(setLoadBalancerListenerSSLCertificateRequest, null, null, true);
            return EndSetLoadBalancerListenerSSLCertificate(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerListenerSSLCertificate"/>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerListenerSSLCertificateRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerListenerSSLCertificate operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndSetLoadBalancerListenerSSLCertificate operation.</returns>
        public IAsyncResult BeginSetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest setLoadBalancerListenerSSLCertificateRequest, AsyncCallback callback, object state)
        {
            return invokeSetLoadBalancerListenerSSLCertificate(setLoadBalancerListenerSSLCertificateRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerListenerSSLCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerListenerSSLCertificate.</param>
        /// 
        /// <returns>Returns a SetLoadBalancerListenerSSLCertificateResult from AmazonElasticLoadBalancing.</returns>
        public SetLoadBalancerListenerSSLCertificateResponse EndSetLoadBalancerListenerSSLCertificate(IAsyncResult asyncResult)
        {
            return endOperation<SetLoadBalancerListenerSSLCertificateResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest setLoadBalancerListenerSSLCertificateRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetLoadBalancerListenerSSLCertificateRequestMarshaller().Marshall(setLoadBalancerListenerSSLCertificateRequest);
            var unmarshaller = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateLBCookieStickinessPolicy

        /// <summary>
        /// <para> Generates a stickiness policy with sticky session lifetimes controlled by the lifetime of the browser (user-agent) or a specified
        /// expiration period. This policy can be associated only with HTTP/HTTPS listeners. </para> <para> When a LoadBalancer implements this policy,
        /// the LoadBalancer uses a special cookie to track the backend server instance for each request. When the LoadBalancer receives a request, it
        /// first checks to see if this cookie is present in the request. If so, the LoadBalancer sends the request to the application server specified
        /// in the cookie. If not, the LoadBalancer sends the request to a server that is chosen based on the existing load balancing algorithm. </para>
        /// <para> A cookie is inserted into the response for binding subsequent requests from the same user to that server. The validity of the cookie
        /// is based on the cookie expiration time, which is specified in the policy configuration. </para>
        /// </summary>
        /// 
        /// <param name="createLBCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy
        ///          service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLBCookieStickinessPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="DuplicatePolicyNameException"/>
        /// <exception cref="TooManyPoliciesException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        public CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest createLBCookieStickinessPolicyRequest)
        {
            IAsyncResult asyncResult = invokeCreateLBCookieStickinessPolicy(createLBCookieStickinessPolicyRequest, null, null, true);
            return EndCreateLBCookieStickinessPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLBCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="createLBCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateLBCookieStickinessPolicy operation.</returns>
        public IAsyncResult BeginCreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest createLBCookieStickinessPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeCreateLBCookieStickinessPolicy(createLBCookieStickinessPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLBCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLBCookieStickinessPolicy.</param>
        /// 
        /// <returns>Returns a CreateLBCookieStickinessPolicyResult from AmazonElasticLoadBalancing.</returns>
        public CreateLBCookieStickinessPolicyResponse EndCreateLBCookieStickinessPolicy(IAsyncResult asyncResult)
        {
            return endOperation<CreateLBCookieStickinessPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest createLBCookieStickinessPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateLBCookieStickinessPolicyRequestMarshaller().Marshall(createLBCookieStickinessPolicyRequest);
            var unmarshaller = CreateLBCookieStickinessPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AttachLoadBalancerToSubnets

        /// <summary>
        /// <para> Adds one or more subnets to the set of configured subnets in the VPC for the LoadBalancer. </para> <para> The Loadbalancers evenly
        /// distribute requests across all of the registered subnets. </para>
        /// </summary>
        /// 
        /// <param name="attachLoadBalancerToSubnetsRequest">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets service
        ///          method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerToSubnets service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="SubnetNotFoundException"/>
        public AttachLoadBalancerToSubnetsResponse AttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest attachLoadBalancerToSubnetsRequest)
        {
            IAsyncResult asyncResult = invokeAttachLoadBalancerToSubnets(attachLoadBalancerToSubnetsRequest, null, null, true);
            return EndAttachLoadBalancerToSubnets(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.AttachLoadBalancerToSubnets"/>
        /// </summary>
        /// 
        /// <param name="attachLoadBalancerToSubnetsRequest">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets operation
        ///          on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAttachLoadBalancerToSubnets operation.</returns>
        public IAsyncResult BeginAttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest attachLoadBalancerToSubnetsRequest, AsyncCallback callback, object state)
        {
            return invokeAttachLoadBalancerToSubnets(attachLoadBalancerToSubnetsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.AttachLoadBalancerToSubnets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachLoadBalancerToSubnets.</param>
        /// 
        /// <returns>Returns a AttachLoadBalancerToSubnetsResult from AmazonElasticLoadBalancing.</returns>
        public AttachLoadBalancerToSubnetsResponse EndAttachLoadBalancerToSubnets(IAsyncResult asyncResult)
        {
            return endOperation<AttachLoadBalancerToSubnetsResponse>(asyncResult);
        }
        
        IAsyncResult invokeAttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest attachLoadBalancerToSubnetsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AttachLoadBalancerToSubnetsRequestMarshaller().Marshall(attachLoadBalancerToSubnetsRequest);
            var unmarshaller = AttachLoadBalancerToSubnetsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateAppCookieStickinessPolicy

        /// <summary>
        /// <para> Generates a stickiness policy with sticky session lifetimes that follow that of an application-generated cookie. This policy can be
        /// associated only with HTTP/HTTPS listeners. </para> <para> This policy is similar to the policy created by CreateLBCookieStickinessPolicy,
        /// except that the lifetime of the special Elastic Load Balancing cookie follows the lifetime of the application-generated cookie specified in
        /// the policy configuration. The LoadBalancer only inserts a new stickiness cookie when the application response includes a new application
        /// cookie. </para> <para> If the application cookie is explicitly removed or expires, the session stops being sticky until a new application
        /// cookie is issued. </para> <para><b>NOTE:</b> An application client must receive and send two cookies: the application-generated cookie and
        /// the special Elastic Load Balancing cookie named AWSELB. This is the default behavior for many common web browsers. </para>
        /// </summary>
        /// 
        /// <param name="createAppCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy
        ///          service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateAppCookieStickinessPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="DuplicatePolicyNameException"/>
        /// <exception cref="TooManyPoliciesException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        public CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest createAppCookieStickinessPolicyRequest)
        {
            IAsyncResult asyncResult = invokeCreateAppCookieStickinessPolicy(createAppCookieStickinessPolicyRequest, null, null, true);
            return EndCreateAppCookieStickinessPolicy(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateAppCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="createAppCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateAppCookieStickinessPolicy operation.</returns>
        public IAsyncResult BeginCreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest createAppCookieStickinessPolicyRequest, AsyncCallback callback, object state)
        {
            return invokeCreateAppCookieStickinessPolicy(createAppCookieStickinessPolicyRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateAppCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppCookieStickinessPolicy.</param>
        /// 
        /// <returns>Returns a CreateAppCookieStickinessPolicyResult from AmazonElasticLoadBalancing.</returns>
        public CreateAppCookieStickinessPolicyResponse EndCreateAppCookieStickinessPolicy(IAsyncResult asyncResult)
        {
            return endOperation<CreateAppCookieStickinessPolicyResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest createAppCookieStickinessPolicyRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateAppCookieStickinessPolicyRequestMarshaller().Marshall(createAppCookieStickinessPolicyRequest);
            var unmarshaller = CreateAppCookieStickinessPolicyResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RegisterInstancesWithLoadBalancer

        /// <summary>
        /// <para> Adds new instances to the LoadBalancer. </para> <para> Once the instance is registered, it starts receiving traffic and requests from
        /// the LoadBalancer. Any instance that is not in any of the Availability Zones registered for the LoadBalancer will be moved to the
        /// <i>OutOfService</i> state. It will move to the <i>InService</i> state when the Availability Zone is added to the LoadBalancer. </para>
        /// <para><b>NOTE:</b> In order for this call to be successful, the client must have created the LoadBalancer. The client must provide the same
        /// account credentials as those that were used to create the LoadBalancer. </para> <para><b>NOTE:</b> Completion of this API does not guarantee
        /// that operation has completed. Rather, it means that the request has been registered and the changes will happen shortly. </para>
        /// </summary>
        /// 
        /// <param name="registerInstancesWithLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          RegisterInstancesWithLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the RegisterInstancesWithLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="InvalidInstanceException"/>
        public RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest registerInstancesWithLoadBalancerRequest)
        {
            IAsyncResult asyncResult = invokeRegisterInstancesWithLoadBalancer(registerInstancesWithLoadBalancerRequest, null, null, true);
            return EndRegisterInstancesWithLoadBalancer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.RegisterInstancesWithLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="registerInstancesWithLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          RegisterInstancesWithLoadBalancer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRegisterInstancesWithLoadBalancer operation.</returns>
        public IAsyncResult BeginRegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest registerInstancesWithLoadBalancerRequest, AsyncCallback callback, object state)
        {
            return invokeRegisterInstancesWithLoadBalancer(registerInstancesWithLoadBalancerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.RegisterInstancesWithLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterInstancesWithLoadBalancer.</param>
        /// 
        /// <returns>Returns a RegisterInstancesWithLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        public RegisterInstancesWithLoadBalancerResponse EndRegisterInstancesWithLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation<RegisterInstancesWithLoadBalancerResponse>(asyncResult);
        }
        
        IAsyncResult invokeRegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest registerInstancesWithLoadBalancerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RegisterInstancesWithLoadBalancerRequestMarshaller().Marshall(registerInstancesWithLoadBalancerRequest);
            var unmarshaller = RegisterInstancesWithLoadBalancerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ApplySecurityGroupsToLoadBalancer

        /// <summary>
        /// <para> Associates one or more security groups with your LoadBalancer in VPC. The provided security group IDs will override any currently
        /// applied security groups. </para>
        /// </summary>
        /// 
        /// <param name="applySecurityGroupsToLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          ApplySecurityGroupsToLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the ApplySecurityGroupsToLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="InvalidSecurityGroupException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        public ApplySecurityGroupsToLoadBalancerResponse ApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest applySecurityGroupsToLoadBalancerRequest)
        {
            IAsyncResult asyncResult = invokeApplySecurityGroupsToLoadBalancer(applySecurityGroupsToLoadBalancerRequest, null, null, true);
            return EndApplySecurityGroupsToLoadBalancer(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ApplySecurityGroupsToLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="applySecurityGroupsToLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          ApplySecurityGroupsToLoadBalancer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndApplySecurityGroupsToLoadBalancer operation.</returns>
        public IAsyncResult BeginApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest applySecurityGroupsToLoadBalancerRequest, AsyncCallback callback, object state)
        {
            return invokeApplySecurityGroupsToLoadBalancer(applySecurityGroupsToLoadBalancerRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ApplySecurityGroupsToLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplySecurityGroupsToLoadBalancer.</param>
        /// 
        /// <returns>Returns a ApplySecurityGroupsToLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        public ApplySecurityGroupsToLoadBalancerResponse EndApplySecurityGroupsToLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation<ApplySecurityGroupsToLoadBalancerResponse>(asyncResult);
        }
        
        IAsyncResult invokeApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest applySecurityGroupsToLoadBalancerRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ApplySecurityGroupsToLoadBalancerRequestMarshaller().Marshall(applySecurityGroupsToLoadBalancerRequest);
            var unmarshaller = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeLoadBalancers

        /// <summary>
        /// <para> Returns detailed configuration information for the specified LoadBalancers. If no LoadBalancers are specified, the operation returns
        /// configuration information for all LoadBalancers created by the caller. </para> <para><b>NOTE:</b> The client must have created the specified
        /// input LoadBalancers in order to retrieve this information; the client must provide the same account credentials as those that were used to
        /// create the LoadBalancer. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancersRequest">Container for the necessary parameters to execute the DescribeLoadBalancers service method on
        ///          AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        public DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest describeLoadBalancersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeLoadBalancers(describeLoadBalancersRequest, null, null, true);
            return EndDescribeLoadBalancers(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancers"/>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancersRequest">Container for the necessary parameters to execute the DescribeLoadBalancers operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeLoadBalancers operation.</returns>
        public IAsyncResult BeginDescribeLoadBalancers(DescribeLoadBalancersRequest describeLoadBalancersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeLoadBalancers(describeLoadBalancersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLoadBalancers operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancers"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancers.</param>
        /// 
        /// <returns>Returns a DescribeLoadBalancersResult from AmazonElasticLoadBalancing.</returns>
        public DescribeLoadBalancersResponse EndDescribeLoadBalancers(IAsyncResult asyncResult)
        {
            return endOperation<DescribeLoadBalancersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeLoadBalancers(DescribeLoadBalancersRequest describeLoadBalancersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLoadBalancersRequestMarshaller().Marshall(describeLoadBalancersRequest);
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns detailed configuration information for the specified LoadBalancers. If no LoadBalancers are specified, the operation returns
        /// configuration information for all LoadBalancers created by the caller. </para> <para><b>NOTE:</b> The client must have created the specified
        /// input LoadBalancers in order to retrieve this information; the client must provide the same account credentials as those that were used to
        /// create the LoadBalancer. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        public DescribeLoadBalancersResponse DescribeLoadBalancers()
        {
            return DescribeLoadBalancers(new DescribeLoadBalancersRequest());
        }
        

        #endregion
    
    }
}
    
