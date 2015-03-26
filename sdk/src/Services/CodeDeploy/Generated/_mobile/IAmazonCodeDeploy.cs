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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CodeDeploy.Model;

namespace Amazon.CodeDeploy
{
    /// <summary>
    /// Interface for accessing CodeDeploy
    ///
    /// AWS CodeDeploy <b>Overview</b> 
    /// <para>
    /// This is the AWS CodeDeploy API Reference. This guide provides descriptions of the
    /// AWS CodeDeploy APIs. For additional information, see the <a href="http://docs.aws.amazon.com/codedeploy/latest/userguide">AWS
    /// CodeDeploy User Guide</a>.
    /// </para>
    ///  <b>Using the APIs</b> 
    /// <para>
    /// You can use the AWS CodeDeploy APIs to work with the following items:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// <i>Applications</i>, which are unique identifiers that AWS CodeDeploy uses to ensure
    /// that the correct combinations of revisions, deployment configurations, and deployment
    /// groups are being referenced during deployments.
    /// </para>
    ///  
    /// <para>
    /// You can work with applications by calling <a>CreateApplication</a>, <a>DeleteApplication</a>,
    /// <a>GetApplication</a>, <a>ListApplications</a>, <a>BatchGetApplications</a>, and <a>UpdateApplication</a>
    /// to create, delete, and get information about applications, and to change information
    /// about an application, respectively.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Deployment configurations</i>, which are sets of deployment rules and deployment
    /// success and failure conditions that AWS CodeDeploy uses during deployments.
    /// </para>
    ///  
    /// <para>
    /// You can work with deployment configurations by calling <a>CreateDeploymentConfig</a>,
    /// <a>DeleteDeploymentConfig</a>, <a>GetDeploymentConfig</a>, and <a>ListDeploymentConfigs</a>
    /// to create, delete, and get information about deployment configurations, respectively.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Deployment groups</i>, which represent groups of Amazon EC2 instances to which
    /// application revisions can be deployed.
    /// </para>
    ///  
    /// <para>
    /// You can work with deployment groups by calling <a>CreateDeploymentGroup</a>, <a>DeleteDeploymentGroup</a>,
    /// <a>GetDeploymentGroup</a>, <a>ListDeploymentGroups</a>, and <a>UpdateDeploymentGroup</a>
    /// to create, delete, and get information about single and multiple deployment groups,
    /// and to change information about a deployment group, respectively.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Deployment instances</i> (also known simply as <i>instances</i>), which represent
    /// Amazon EC2 instances to which application revisions are deployed. Deployment instances
    /// are identified by their Amazon EC2 tags or Auto Scaling group names. Deployment instances
    /// belong to deployment groups.
    /// </para>
    ///  
    /// <para>
    /// You can work with deployment instances by calling <a>GetDeploymentInstance</a> and
    /// <a>ListDeploymentInstances</a> to get information about single and multiple deployment
    /// instances, respectively.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Deployments</i>, which represent the process of deploying revisions to deployment
    /// groups.
    /// </para>
    ///  
    /// <para>
    /// You can work with deployments by calling <a>CreateDeployment</a>, <a>GetDeployment</a>,
    /// <a>ListDeployments</a>, <a>BatchGetDeployments</a>, and <a>StopDeployment</a> to create
    /// and get information about deployments, and to stop a deployment, respectively.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Application revisions</i> (also known simply as <i>revisions</i>), which are archive
    /// files that are stored in Amazon S3 buckets or GitHub repositories. These revisions
    /// contain source content (such as source code, web pages, executable files, any deployment
    /// scripts, and similar) along with an Application Specification file (AppSpec file).
    /// (The AppSpec file is unique to AWS CodeDeploy; it defines a series of deployment actions
    /// that you want AWS CodeDeploy to execute.) An application revision is uniquely identified
    /// by its Amazon S3 object key and its ETag, version, or both. Application revisions
    /// are deployed to deployment groups.
    /// </para>
    ///  
    /// <para>
    /// You can work with application revisions by calling <a>GetApplicationRevision</a>,
    /// <a>ListApplicationRevisions</a>, and <a>RegisterApplicationRevision</a> to get information
    /// about application revisions and to inform AWS CodeDeploy about an application revision,
    /// respectively.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCodeDeploy : IDisposable
    {
                
        #region  BatchGetApplications

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<BatchGetApplicationsResponse> BatchGetApplicationsAsync(BatchGetApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetDeployments

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<BatchGetDeploymentsResponse> BatchGetDeploymentsAsync(BatchGetDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApplication

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDeploymentConfig

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDeploymentConfigResponse> CreateDeploymentConfigAsync(CreateDeploymentConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDeploymentGroup

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDeploymentGroupResponse> CreateDeploymentGroupAsync(CreateDeploymentGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApplication

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDeploymentConfig

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDeploymentConfigResponse> DeleteDeploymentConfigAsync(DeleteDeploymentConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDeploymentGroup

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDeploymentGroupResponse> DeleteDeploymentGroupAsync(DeleteDeploymentGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplication

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplicationRevision

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationRevision operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetApplicationRevisionResponse> GetApplicationRevisionAsync(GetApplicationRevisionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeployment

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeploymentConfig

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDeploymentConfigResponse> GetDeploymentConfigAsync(GetDeploymentConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeploymentGroup

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDeploymentGroupResponse> GetDeploymentGroupAsync(GetDeploymentGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeploymentInstance

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeploymentInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDeploymentInstanceResponse> GetDeploymentInstanceAsync(GetDeploymentInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplicationRevisions

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationRevisions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListApplicationRevisionsResponse> ListApplicationRevisionsAsync(ListApplicationRevisionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplications

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeploymentConfigs

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeploymentConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDeploymentConfigsResponse> ListDeploymentConfigsAsync(ListDeploymentConfigsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeploymentGroups

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeploymentGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDeploymentGroupsResponse> ListDeploymentGroupsAsync(ListDeploymentGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeploymentInstances

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeploymentInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDeploymentInstancesResponse> ListDeploymentInstancesAsync(ListDeploymentInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeployments

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterApplicationRevision

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterApplicationRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplicationRevision operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterApplicationRevisionResponse> RegisterApplicationRevisionAsync(RegisterApplicationRevisionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopDeployment

        /// <summary>
        /// Initiates the asynchronous execution of the StopDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopDeploymentResponse> StopDeploymentAsync(StopDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplication

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDeploymentGroup

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeploymentGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDeploymentGroupResponse> UpdateDeploymentGroupAsync(UpdateDeploymentGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}