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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

using Amazon.OpsWorks.Model;

namespace Amazon.OpsWorks
{
    /// <summary>
    /// Implementation for accessing OpsWorks
    ///
    /// AWS OpsWorks   
    /// <para>
    /// Welcome to the  <i>AWS OpsWorks API Reference</i>. This guide provides descriptions,
    /// syntax, and usage examples about AWS OpsWorks         actions and data types, including
    /// common parameters and error codes. 
    /// </para>
    ///   
    /// <para>
    /// AWS OpsWorks is an application management service that provides an integrated experience
    /// for overseeing the         complete application lifecycle. For information about this
    /// product, go to the  <a href="http://aws.amazon.com/opsworks/">AWS OpsWorks</a> details
    /// page. 
    /// </para>
    ///   
    /// <para>
    /// <b>SDKs and CLI</b> 
    /// </para>
    ///   
    /// <para>
    /// The most common way to use the AWS OpsWorks API is by using the AWS Command Line Interface
    /// (CLI) or   by using one of the AWS SDKs to implement applications in your preferred
    /// language. For more information, see:
    /// </para>
    ///   <ul>    <li><a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-chap-welcome.html">AWS
    /// CLI</a></li>    <li><a href="http://docs.aws.amazon.com/AWSJavaSDK/latest/javadoc/com/amazonaws/services/opsworks/AWSOpsWorksClient.html">AWS
    /// SDK for Java</a></li>    <li><a href="http://docs.aws.amazon.com/sdkfornet/latest/apidocs/html/N_Amazon_OpsWorks.htm">AWS
    /// SDK for .NET</a></li>    <li><a href="http://docs.aws.amazon.com/aws-sdk-php-2/latest/class-Aws.OpsWorks.OpsWorksClient.html">AWS
    /// SDK for PHP 2</a></li>    <li><a href="http://docs.aws.amazon.com/AWSRubySDK/latest/AWS/OpsWorks/Client.html">AWS
    /// SDK for Ruby</a></li>    <li><a href="http://aws.amazon.com/documentation/sdkforjavascript/">AWS
    /// SDK for Node.js</a></li>    <li><a href="http://docs.pythonboto.org/en/latest/ref/opsworks.html">AWS
    /// SDK for Python(Boto)</a></li>  </ul>      
    /// <para>
    /// <b>Endpoints</b>
    /// </para>
    ///   
    /// <para>
    /// AWS OpsWorks supports only one endpoint, opsworks.us-east-1.amazonaws.com (HTTPS),
    /// so you must connect to that endpoint. You can then use the API         to direct AWS
    /// OpsWorks to create stacks in any AWS Region.
    /// </para>
    ///   
    /// <para>
    /// <b>Chef Version</b>
    /// </para>
    ///   
    /// <para>
    /// When you call <a>CreateStack</a>, <a>CloneStack</a>, or <a>UpdateStack</a> we recommend
    /// you use         the <code>ConfigurationManager</code> parameter to specify the Chef
    /// version, 0.9, 11.4, or 11.10.         The default value is currently 11.4.       
    ///  For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook-chef11.html">Chef
    /// Versions</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonOpsWorks : IDisposable
    {
                
        #region  AssignVolume

        /// <summary>
        /// Initiates the asynchronous execution of the AssignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AssignVolumeResponse> AssignVolumeAsync(AssignVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateElasticIp

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AssociateElasticIpResponse> AssociateElasticIpAsync(AssociateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachElasticLoadBalancer

        /// <summary>
        /// Initiates the asynchronous execution of the AttachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachElasticLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AttachElasticLoadBalancerResponse> AttachElasticLoadBalancerAsync(AttachElasticLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CloneStack

        /// <summary>
        /// Initiates the asynchronous execution of the CloneStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CloneStackResponse> CloneStackAsync(CloneStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApp

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDeployment

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInstance

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLayer

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStack

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserProfile

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApp

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInstance

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLayer

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLayerResponse> DeleteLayerAsync(DeleteLayerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStack

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserProfile

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterElasticIp

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterElasticIpResponse> DeregisterElasticIpAsync(DeregisterElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterRdsDbInstance

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterRdsDbInstanceResponse> DeregisterRdsDbInstanceAsync(DeregisterRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterVolume

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterVolumeResponse> DeregisterVolumeAsync(DeregisterVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApps

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApps operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCommands

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommands operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommands operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCommandsResponse> DescribeCommandsAsync(DescribeCommandsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDeployments

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeployments operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDeploymentsResponse> DescribeDeploymentsAsync(DescribeDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeElasticIps

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticIps operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticIps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeElasticIpsResponse> DescribeElasticIpsAsync(DescribeElasticIpsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeElasticLoadBalancers

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticLoadBalancers operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(DescribeElasticLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstances

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLayers

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLayers operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLayers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLayersResponse> DescribeLayersAsync(DescribeLayersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoadBasedAutoScaling

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBasedAutoScalingResponse> DescribeLoadBasedAutoScalingAsync(DescribeLoadBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMyUserProfile

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMyUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(DescribeMyUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePermissions

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePermissions operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribePermissionsResponse> DescribePermissionsAsync(DescribePermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRaidArrays

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRaidArrays operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRaidArrays operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeRaidArraysResponse> DescribeRaidArraysAsync(DescribeRaidArraysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRdsDbInstances

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRdsDbInstances operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRdsDbInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeRdsDbInstancesResponse> DescribeRdsDbInstancesAsync(DescribeRdsDbInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeServiceErrors

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceErrors operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceErrors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(DescribeServiceErrorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStacks

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStackSummary

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSummary operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeStackSummaryResponse> DescribeStackSummaryAsync(DescribeStackSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTimeBasedAutoScaling

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTimeBasedAutoScalingResponse> DescribeTimeBasedAutoScalingAsync(DescribeTimeBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUserProfiles

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfiles operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(DescribeUserProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVolumes

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachElasticLoadBalancer

        /// <summary>
        /// Initiates the asynchronous execution of the DetachElasticLoadBalancer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachElasticLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DetachElasticLoadBalancerResponse> DetachElasticLoadBalancerAsync(DetachElasticLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateElasticIp

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisassociateElasticIpResponse> DisassociateElasticIpAsync(DisassociateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHostnameSuggestion

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostnameSuggestion operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostnameSuggestion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHostnameSuggestionResponse> GetHostnameSuggestionAsync(GetHostnameSuggestionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RebootInstance

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterElasticIp

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterElasticIpResponse> RegisterElasticIpAsync(RegisterElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterRdsDbInstance

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterRdsDbInstanceResponse> RegisterRdsDbInstanceAsync(RegisterRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterVolume

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterVolumeResponse> RegisterVolumeAsync(RegisterVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetLoadBasedAutoScaling

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetLoadBasedAutoScalingResponse> SetLoadBasedAutoScalingAsync(SetLoadBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetPermission

        /// <summary>
        /// Initiates the asynchronous execution of the SetPermission operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetPermissionResponse> SetPermissionAsync(SetPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetTimeBasedAutoScaling

        /// <summary>
        /// Initiates the asynchronous execution of the SetTimeBasedAutoScaling operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTimeBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetTimeBasedAutoScalingResponse> SetTimeBasedAutoScalingAsync(SetTimeBasedAutoScalingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartInstance

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartStack

        /// <summary>
        /// Initiates the asynchronous execution of the StartStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartStackResponse> StartStackAsync(StartStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopInstance

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopStack

        /// <summary>
        /// Initiates the asynchronous execution of the StopStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopStackResponse> StopStackAsync(StopStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnassignVolume

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UnassignVolumeResponse> UnassignVolumeAsync(UnassignVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApp

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateElasticIp

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateElasticIp operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateElasticIpResponse> UpdateElasticIpAsync(UpdateElasticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInstance

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLayer

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLayer operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateLayerResponse> UpdateLayerAsync(UpdateLayerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMyUserProfile

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMyUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMyUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(UpdateMyUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRdsDbInstance

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRdsDbInstance operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateRdsDbInstanceResponse> UpdateRdsDbInstanceAsync(UpdateRdsDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateStack

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserProfile

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVolume

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVolume operation.
        /// <seealso cref="Amazon.OpsWorks.IAmazonOpsWorks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}