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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.OpsWorks.Model;

namespace Amazon.OpsWorks
{
    /// <summary>
    /// Interface for accessing OpsWorks
    ///
    /// AWS OpsWorks 
    /// <para>
    /// Welcome to the <i>AWS OpsWorks Stacks API Reference</i>. This guide provides descriptions,
    /// syntax, and usage examples for AWS OpsWorks Stacks actions and data types, including
    /// common parameters and error codes. 
    /// </para>
    ///  
    /// <para>
    /// AWS OpsWorks Stacks is an application management service that provides an integrated
    /// experience for overseeing the complete application lifecycle. For information about
    /// this product, go to the <a href="http://aws.amazon.com/opsworks/">AWS OpsWorks</a>
    /// details page. 
    /// </para>
    ///  
    /// <para>
    ///  <b>SDKs and CLI</b> 
    /// </para>
    ///  
    /// <para>
    /// The most common way to use the AWS OpsWorks Stacks API is by using the AWS Command
    /// Line Interface (CLI) or by using one of the AWS SDKs to implement applications in
    /// your preferred language. For more information, see:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-chap-welcome.html">AWS
    /// CLI</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/AWSJavaSDK/latest/javadoc/com/amazonaws/services/opsworks/AWSOpsWorksClient.html">AWS
    /// SDK for Java</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/sdkfornet/latest/apidocs/html/N_Amazon_OpsWorks.htm">AWS
    /// SDK for .NET</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/aws-sdk-php-2/latest/class-Aws.OpsWorks.OpsWorksClient.html">AWS
    /// SDK for PHP 2</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/sdkforruby/api/">AWS SDK for Ruby</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/documentation/sdkforjavascript/">AWS SDK for Node.js</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.pythonboto.org/en/latest/ref/opsworks.html">AWS SDK for Python(Boto)</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS OpsWorks Stacks supports the following endpoints, all HTTPS. You must connect
    /// to one of the following endpoints. Stacks can only be accessed or managed within the
    /// endpoint in which they are created.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// opsworks.us-east-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.us-east-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.us-west-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.us-west-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.ca-central-1.amazonaws.com (API only; not available in the AWS console)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.eu-west-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.eu-west-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.eu-west-3.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.eu-central-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.ap-northeast-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.ap-northeast-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.ap-south-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.ap-southeast-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.ap-southeast-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks.sa-east-1.amazonaws.com
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Chef Versions</b> 
    /// </para>
    ///  
    /// <para>
    /// When you call <a>CreateStack</a>, <a>CloneStack</a>, or <a>UpdateStack</a> we recommend
    /// you use the <code>ConfigurationManager</code> parameter to specify the Chef version.
    /// The recommended and default value for Linux stacks is currently 12. Windows stacks
    /// use Chef 12.2. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook-chef11.html">Chef
    /// Versions</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can specify Chef 12, 11.10, or 11.4 for your Linux stack. We recommend migrating
    /// your existing Linux stacks to Chef 12 as soon as possible.
    /// </para>
    ///  </note>
    /// </summary>
    public partial interface IAmazonOpsWorks : IAmazonService, IDisposable
    {
                
        #region  AssignInstance


        /// <summary>
        /// Initiates the asynchronous execution of the AssignInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignInstance">REST API Reference for AssignInstance Operation</seealso>
        Task<AssignInstanceResponse> AssignInstanceAsync(AssignInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssignVolume


        /// <summary>
        /// Initiates the asynchronous execution of the AssignVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssignVolume">REST API Reference for AssignVolume Operation</seealso>
        Task<AssignVolumeResponse> AssignVolumeAsync(AssignVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateElasticIp


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AssociateElasticIp">REST API Reference for AssociateElasticIp Operation</seealso>
        Task<AssociateElasticIpResponse> AssociateElasticIpAsync(AssociateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachElasticLoadBalancer


        /// <summary>
        /// Initiates the asynchronous execution of the AttachElasticLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachElasticLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/AttachElasticLoadBalancer">REST API Reference for AttachElasticLoadBalancer Operation</seealso>
        Task<AttachElasticLoadBalancerResponse> AttachElasticLoadBalancerAsync(AttachElasticLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CloneStack


        /// <summary>
        /// Initiates the asynchronous execution of the CloneStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloneStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CloneStack">REST API Reference for CloneStack Operation</seealso>
        Task<CloneStackResponse> CloneStackAsync(CloneStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApp


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateApp">REST API Reference for CreateApp Operation</seealso>
        Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDeployment


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInstance


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLayer


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateLayer">REST API Reference for CreateLayer Operation</seealso>
        Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStack


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateStack">REST API Reference for CreateStack Operation</seealso>
        Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserProfile


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApp


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInstance


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLayer


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteLayer">REST API Reference for DeleteLayer Operation</seealso>
        Task<DeleteLayerResponse> DeleteLayerAsync(DeleteLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStack


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserProfile


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterEcsCluster


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterEcsCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterEcsCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterEcsCluster">REST API Reference for DeregisterEcsCluster Operation</seealso>
        Task<DeregisterEcsClusterResponse> DeregisterEcsClusterAsync(DeregisterEcsClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterElasticIp


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterElasticIp">REST API Reference for DeregisterElasticIp Operation</seealso>
        Task<DeregisterElasticIpResponse> DeregisterElasticIpAsync(DeregisterElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterInstance


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        Task<DeregisterInstanceResponse> DeregisterInstanceAsync(DeregisterInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterRdsDbInstance


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterRdsDbInstance">REST API Reference for DeregisterRdsDbInstance Operation</seealso>
        Task<DeregisterRdsDbInstanceResponse> DeregisterRdsDbInstanceAsync(DeregisterRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterVolume


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DeregisterVolume">REST API Reference for DeregisterVolume Operation</seealso>
        Task<DeregisterVolumeResponse> DeregisterVolumeAsync(DeregisterVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAgentVersions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgentVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeAgentVersions">REST API Reference for DescribeAgentVersions Operation</seealso>
        Task<DescribeAgentVersionsResponse> DescribeAgentVersionsAsync(DescribeAgentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApps


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeApps">REST API Reference for DescribeApps Operation</seealso>
        Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCommands


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCommands operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCommands operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeCommands">REST API Reference for DescribeCommands Operation</seealso>
        Task<DescribeCommandsResponse> DescribeCommandsAsync(DescribeCommandsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDeployments


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeDeployments">REST API Reference for DescribeDeployments Operation</seealso>
        Task<DescribeDeploymentsResponse> DescribeDeploymentsAsync(DescribeDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEcsClusters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEcsClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEcsClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeEcsClusters">REST API Reference for DescribeEcsClusters Operation</seealso>
        Task<DescribeEcsClustersResponse> DescribeEcsClustersAsync(DescribeEcsClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeElasticIps


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticIps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticIps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticIps">REST API Reference for DescribeElasticIps Operation</seealso>
        Task<DescribeElasticIpsResponse> DescribeElasticIpsAsync(DescribeElasticIpsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeElasticLoadBalancers


        /// <summary>
        /// Describes a stack's Elastic Load Balancing instances.
        /// 
        ///  <note> 
        /// <para>
        /// This call accepts only one resource-identifying parameter.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeElasticLoadBalancers service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticLoadBalancers">REST API Reference for DescribeElasticLoadBalancers Operation</seealso>
        Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeElasticLoadBalancers">REST API Reference for DescribeElasticLoadBalancers Operation</seealso>
        Task<DescribeElasticLoadBalancersResponse> DescribeElasticLoadBalancersAsync(DescribeElasticLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstances


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLayers


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLayers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLayers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLayers">REST API Reference for DescribeLayers Operation</seealso>
        Task<DescribeLayersResponse> DescribeLayersAsync(DescribeLayersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoadBasedAutoScaling


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeLoadBasedAutoScaling">REST API Reference for DescribeLoadBasedAutoScaling Operation</seealso>
        Task<DescribeLoadBasedAutoScalingResponse> DescribeLoadBasedAutoScalingAsync(DescribeLoadBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMyUserProfile


        /// <summary>
        /// Describes a user's SSH information.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information
        /// on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeMyUserProfile">REST API Reference for DescribeMyUserProfile Operation</seealso>
        Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMyUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMyUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeMyUserProfile">REST API Reference for DescribeMyUserProfile Operation</seealso>
        Task<DescribeMyUserProfileResponse> DescribeMyUserProfileAsync(DescribeMyUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOperatingSystems


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOperatingSystems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOperatingSystems operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeOperatingSystems">REST API Reference for DescribeOperatingSystems Operation</seealso>
        Task<DescribeOperatingSystemsResponse> DescribeOperatingSystemsAsync(DescribeOperatingSystemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePermissions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribePermissions">REST API Reference for DescribePermissions Operation</seealso>
        Task<DescribePermissionsResponse> DescribePermissionsAsync(DescribePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRaidArrays


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRaidArrays operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRaidArrays operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRaidArrays">REST API Reference for DescribeRaidArrays Operation</seealso>
        Task<DescribeRaidArraysResponse> DescribeRaidArraysAsync(DescribeRaidArraysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRdsDbInstances


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRdsDbInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRdsDbInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeRdsDbInstances">REST API Reference for DescribeRdsDbInstances Operation</seealso>
        Task<DescribeRdsDbInstancesResponse> DescribeRdsDbInstancesAsync(DescribeRdsDbInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeServiceErrors


        /// <summary>
        /// Describes AWS OpsWorks Stacks service errors.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// This call accepts only one resource-identifying parameter.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServiceErrors service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeServiceErrors">REST API Reference for DescribeServiceErrors Operation</seealso>
        Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceErrors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeServiceErrors">REST API Reference for DescribeServiceErrors Operation</seealso>
        Task<DescribeServiceErrorsResponse> DescribeServiceErrorsAsync(DescribeServiceErrorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStackProvisioningParameters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackProvisioningParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackProvisioningParameters">REST API Reference for DescribeStackProvisioningParameters Operation</seealso>
        Task<DescribeStackProvisioningParametersResponse> DescribeStackProvisioningParametersAsync(DescribeStackProvisioningParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStacks


        /// <summary>
        /// Requests a description of one or more stacks.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
        /// or Manage permissions level for the stack, or an attached policy that explicitly grants
        /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        Task<DescribeStacksResponse> DescribeStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStackSummary


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeStackSummary">REST API Reference for DescribeStackSummary Operation</seealso>
        Task<DescribeStackSummaryResponse> DescribeStackSummaryAsync(DescribeStackSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTimeBasedAutoScaling


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTimeBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeTimeBasedAutoScaling">REST API Reference for DescribeTimeBasedAutoScaling Operation</seealso>
        Task<DescribeTimeBasedAutoScalingResponse> DescribeTimeBasedAutoScalingAsync(DescribeTimeBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUserProfiles


        /// <summary>
        /// Describe specified users.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have an attached
        /// policy that explicitly grants permissions. For more information on user permissions,
        /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserProfiles service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ResourceNotFoundException">
        /// Indicates that a resource was not found.
        /// </exception>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeUserProfiles">REST API Reference for DescribeUserProfiles Operation</seealso>
        Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeUserProfiles">REST API Reference for DescribeUserProfiles Operation</seealso>
        Task<DescribeUserProfilesResponse> DescribeUserProfilesAsync(DescribeUserProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVolumes


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachElasticLoadBalancer


        /// <summary>
        /// Initiates the asynchronous execution of the DetachElasticLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachElasticLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DetachElasticLoadBalancer">REST API Reference for DetachElasticLoadBalancer Operation</seealso>
        Task<DetachElasticLoadBalancerResponse> DetachElasticLoadBalancerAsync(DetachElasticLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateElasticIp


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/DisassociateElasticIp">REST API Reference for DisassociateElasticIp Operation</seealso>
        Task<DisassociateElasticIpResponse> DisassociateElasticIpAsync(DisassociateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHostnameSuggestion


        /// <summary>
        /// Initiates the asynchronous execution of the GetHostnameSuggestion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostnameSuggestion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GetHostnameSuggestion">REST API Reference for GetHostnameSuggestion Operation</seealso>
        Task<GetHostnameSuggestionResponse> GetHostnameSuggestionAsync(GetHostnameSuggestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GrantAccess


        /// <summary>
        /// Initiates the asynchronous execution of the GrantAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GrantAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/GrantAccess">REST API Reference for GrantAccess Operation</seealso>
        Task<GrantAccessResponse> GrantAccessAsync(GrantAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTags


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RebootInstance


        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterEcsCluster


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterEcsCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterEcsCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterEcsCluster">REST API Reference for RegisterEcsCluster Operation</seealso>
        Task<RegisterEcsClusterResponse> RegisterEcsClusterAsync(RegisterEcsClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterElasticIp


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterElasticIp">REST API Reference for RegisterElasticIp Operation</seealso>
        Task<RegisterElasticIpResponse> RegisterElasticIpAsync(RegisterElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterInstance


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        Task<RegisterInstanceResponse> RegisterInstanceAsync(RegisterInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterRdsDbInstance


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterRdsDbInstance">REST API Reference for RegisterRdsDbInstance Operation</seealso>
        Task<RegisterRdsDbInstanceResponse> RegisterRdsDbInstanceAsync(RegisterRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterVolume


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/RegisterVolume">REST API Reference for RegisterVolume Operation</seealso>
        Task<RegisterVolumeResponse> RegisterVolumeAsync(RegisterVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetLoadBasedAutoScaling


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetLoadBasedAutoScaling">REST API Reference for SetLoadBasedAutoScaling Operation</seealso>
        Task<SetLoadBasedAutoScalingResponse> SetLoadBasedAutoScalingAsync(SetLoadBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetPermission


        /// <summary>
        /// Initiates the asynchronous execution of the SetPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetPermission">REST API Reference for SetPermission Operation</seealso>
        Task<SetPermissionResponse> SetPermissionAsync(SetPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetTimeBasedAutoScaling


        /// <summary>
        /// Initiates the asynchronous execution of the SetTimeBasedAutoScaling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTimeBasedAutoScaling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/SetTimeBasedAutoScaling">REST API Reference for SetTimeBasedAutoScaling Operation</seealso>
        Task<SetTimeBasedAutoScalingResponse> SetTimeBasedAutoScalingAsync(SetTimeBasedAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartInstance


        /// <summary>
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartInstance">REST API Reference for StartInstance Operation</seealso>
        Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartStack


        /// <summary>
        /// Initiates the asynchronous execution of the StartStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StartStack">REST API Reference for StartStack Operation</seealso>
        Task<StartStackResponse> StartStackAsync(StartStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopInstance


        /// <summary>
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopInstance">REST API Reference for StopInstance Operation</seealso>
        Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopStack


        /// <summary>
        /// Initiates the asynchronous execution of the StopStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/StopStack">REST API Reference for StopStack Operation</seealso>
        Task<StopStackResponse> StopStackAsync(StopStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnassignInstance


        /// <summary>
        /// Initiates the asynchronous execution of the UnassignInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignInstance">REST API Reference for UnassignInstance Operation</seealso>
        Task<UnassignInstanceResponse> UnassignInstanceAsync(UnassignInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnassignVolume


        /// <summary>
        /// Initiates the asynchronous execution of the UnassignVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UnassignVolume">REST API Reference for UnassignVolume Operation</seealso>
        Task<UnassignVolumeResponse> UnassignVolumeAsync(UnassignVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApp


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateElasticIp


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateElasticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateElasticIp">REST API Reference for UpdateElasticIp Operation</seealso>
        Task<UpdateElasticIpResponse> UpdateElasticIpAsync(UpdateElasticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInstance


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLayer


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateLayer">REST API Reference for UpdateLayer Operation</seealso>
        Task<UpdateLayerResponse> UpdateLayerAsync(UpdateLayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMyUserProfile


        /// <summary>
        /// Updates a user's SSH public key.
        /// 
        ///  
        /// <para>
        ///  <b>Required Permissions</b>: To use this action, an IAM user must have self-management
        /// enabled or an attached policy that explicitly grants permissions. For more information
        /// on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMyUserProfile service method, as returned by OpsWorks.</returns>
        /// <exception cref="Amazon.OpsWorks.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateMyUserProfile">REST API Reference for UpdateMyUserProfile Operation</seealso>
        Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMyUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMyUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateMyUserProfile">REST API Reference for UpdateMyUserProfile Operation</seealso>
        Task<UpdateMyUserProfileResponse> UpdateMyUserProfileAsync(UpdateMyUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRdsDbInstance


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRdsDbInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRdsDbInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateRdsDbInstance">REST API Reference for UpdateRdsDbInstance Operation</seealso>
        Task<UpdateRdsDbInstanceResponse> UpdateRdsDbInstanceAsync(UpdateRdsDbInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateStack


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserProfile


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVolume


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworks-2013-02-18/UpdateVolume">REST API Reference for UpdateVolume Operation</seealso>
        Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}