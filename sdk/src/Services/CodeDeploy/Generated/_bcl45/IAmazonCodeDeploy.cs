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
    /// This reference guide provides descriptions of the AWS CodeDeploy APIs. For more information
    /// about AWS CodeDeploy, see the <a href="docs.aws.amazon.com/codedeploy/latest/userguide">AWS
    /// CodeDeploy User Guide</a>.
    /// </para>
    ///  <b>Using the APIs</b> 
    /// <para>
    /// You can use the AWS CodeDeploy APIs to work with the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Applications are unique identifiers used by AWS CodeDeploy to ensure the correct combinations
    /// of revisions, deployment configurations, and deployment groups are being referenced
    /// during deployments.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeDeploy APIs to create, delete, get, list, and update applications.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Deployment configurations are sets of deployment rules and success and failure conditions
    /// used by AWS CodeDeploy during deployments.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeDeploy APIs to create, delete, get, and list deployment configurations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Deployment groups are groups of instances to which application revisions can be deployed.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeDeploy APIs to create, delete, get, list, and update deployment
    /// groups.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Instances represent Amazon EC2 instances to which application revisions are deployed.
    /// Instances are identified by their Amazon EC2 tags or Auto Scaling group names. Instances
    /// belong to deployment groups.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeDeploy APIs to get and list instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Deployments represent the process of deploying revisions to instances.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeDeploy APIs to create, get, list, and stop deployments.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Application revisions are archive files stored in Amazon S3 buckets or GitHub repositories.
    /// These revisions contain source content (such as source code, web pages, executable
    /// files, and deployment scripts) along with an application specification (AppSpec) file.
    /// (The AppSpec file is unique to AWS CodeDeploy; it defines the deployment actions you
    /// want AWS CodeDeploy to execute.) Ffor application revisions stored in Amazon S3 buckets,
    /// an application revision is uniquely identified by its Amazon S3 object key and its
    /// ETag, version, or both. For application revisions stored in GitHub repositories, an
    /// application revision is uniquely identified by its repository name and commit ID.
    /// Application revisions are deployed through deployment groups.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeDeploy APIs to get, list, and register application revisions.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCodeDeploy : IDisposable
    {

        
        #region  AddTagsToOnPremisesInstances


        /// <summary>
        /// Adds tags to on-premises instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToOnPremisesInstances service method.</param>
        /// 
        /// <returns>The response from the AddTagsToOnPremisesInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceLimitExceededException">
        /// The maximum number of allowed on-premises instances in a single call was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNotRegisteredException">
        /// The specified on-premises instance is not registered.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The specified tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagLimitExceededException">
        /// The maximum allowed number of tags was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagRequiredException">
        /// A tag was not specified.
        /// </exception>
        AddTagsToOnPremisesInstancesResponse AddTagsToOnPremisesInstances(AddTagsToOnPremisesInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToOnPremisesInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToOnPremisesInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsToOnPremisesInstancesResponse> AddTagsToOnPremisesInstancesAsync(AddTagsToOnPremisesInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetApplicationRevisions


        /// <summary>
        /// Gets information about one or more application revisions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplicationRevisions service method.</param>
        /// 
        /// <returns>The response from the BatchGetApplicationRevisions service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRevisionException">
        /// The revision was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        BatchGetApplicationRevisionsResponse BatchGetApplicationRevisions(BatchGetApplicationRevisionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetApplicationRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplicationRevisions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<BatchGetApplicationRevisionsResponse> BatchGetApplicationRevisionsAsync(BatchGetApplicationRevisionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetApplications


        /// <summary>
        /// Gets information about one or more applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplications service method.</param>
        /// 
        /// <returns>The response from the BatchGetApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        BatchGetApplicationsResponse BatchGetApplications(BatchGetApplicationsRequest request);


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
        
        #region  BatchGetDeploymentGroups


        /// <summary>
        /// Get information about one or more deployment groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentGroups service method.</param>
        /// 
        /// <returns>The response from the BatchGetDeploymentGroups service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        BatchGetDeploymentGroupsResponse BatchGetDeploymentGroups(BatchGetDeploymentGroupsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDeploymentGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<BatchGetDeploymentGroupsResponse> BatchGetDeploymentGroupsAsync(BatchGetDeploymentGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetDeploymentInstances


        /// <summary>
        /// Gets information about one or more instance that are part of a deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentInstances service method.</param>
        /// 
        /// <returns>The response from the BatchGetDeploymentInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceIdRequiredException">
        /// The instance ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        BatchGetDeploymentInstancesResponse BatchGetDeploymentInstances(BatchGetDeploymentInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDeploymentInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<BatchGetDeploymentInstancesResponse> BatchGetDeploymentInstancesAsync(BatchGetDeploymentInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetDeployments


        /// <summary>
        /// Gets information about one or more deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeployments service method.</param>
        /// 
        /// <returns>The response from the BatchGetDeployments service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        BatchGetDeploymentsResponse BatchGetDeployments(BatchGetDeploymentsRequest request);


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
        
        #region  BatchGetOnPremisesInstances


        /// <summary>
        /// Gets information about one or more on-premises instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetOnPremisesInstances service method.</param>
        /// 
        /// <returns>The response from the BatchGetOnPremisesInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        BatchGetOnPremisesInstancesResponse BatchGetOnPremisesInstances(BatchGetOnPremisesInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetOnPremisesInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetOnPremisesInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<BatchGetOnPremisesInstancesResponse> BatchGetOnPremisesInstancesAsync(BatchGetOnPremisesInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationAlreadyExistsException">
        /// An application with the specified name already exists with the applicable IAM user
        /// or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationLimitExceededException">
        /// More applications were attempted to be created than are allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);


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
        /// Deploys an application revision through the specified deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentLimitExceededException">
        /// The number of allowed deployments was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DescriptionTooLongException">
        /// The description is too long.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRevisionException">
        /// The revision was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);


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
        /// Creates a deployment configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentConfig service method.</param>
        /// 
        /// <returns>The response from the CreateDeploymentConfig service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigAlreadyExistsException">
        /// A deployment configuration with the specified name already exists with the applicable
        /// IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigLimitExceededException">
        /// The deployment configurations limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidMinimumHealthyHostValueException">
        /// The minimum healthy instance value was specified in an invalid format.
        /// </exception>
        CreateDeploymentConfigResponse CreateDeploymentConfig(CreateDeploymentConfigRequest request);


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
        /// Creates a deployment group to which application revisions will be deployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupAlreadyExistsException">
        /// A deployment group with the specified name already exists with the applicable IAM
        /// user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupLimitExceededException">
        /// The deployment groups limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoScalingGroupException">
        /// The Auto Scaling group was specified in an invalid format or does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRoleException">
        /// The service role ARN was specified in an invalid format. Or, if an Auto Scaling group
        /// was specified, the specified service role does not grant the appropriate permissions
        /// to Auto Scaling.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The specified tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTriggerConfigException">
        /// The trigger was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.LifecycleHookLimitExceededException">
        /// The limit for lifecycle hooks was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RoleRequiredException">
        /// The role ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TriggerTargetsLimitExceededException">
        /// The maximum allowed number of triggers was exceeded.
        /// </exception>
        CreateDeploymentGroupResponse CreateDeploymentGroup(CreateDeploymentGroupRequest request);


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
        /// Deletes an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);


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
        /// Deletes a deployment configuration.
        /// 
        ///  <note>A deployment configuration cannot be deleted if it is currently in use. Predefined
        /// configurations cannot be deleted.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteDeploymentConfig service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigInUseException">
        /// The deployment configuration is still in use.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidOperationException">
        /// An invalid operation was detected.
        /// </exception>
        DeleteDeploymentConfigResponse DeleteDeploymentConfig(DeleteDeploymentConfigRequest request);


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
        /// Deletes a deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRoleException">
        /// The service role ARN was specified in an invalid format. Or, if an Auto Scaling group
        /// was specified, the specified service role does not grant the appropriate permissions
        /// to Auto Scaling.
        /// </exception>
        DeleteDeploymentGroupResponse DeleteDeploymentGroup(DeleteDeploymentGroupRequest request);


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
        
        #region  DeregisterOnPremisesInstance


        /// <summary>
        /// Deregisters an on-premises instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOnPremisesInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterOnPremisesInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        DeregisterOnPremisesInstanceResponse DeregisterOnPremisesInstance(DeregisterOnPremisesInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterOnPremisesInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOnPremisesInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterOnPremisesInstanceResponse> DeregisterOnPremisesInstanceAsync(DeregisterOnPremisesInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApplication


        /// <summary>
        /// Gets information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        GetApplicationResponse GetApplication(GetApplicationRequest request);


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
        /// Gets information about an application revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationRevision service method.</param>
        /// 
        /// <returns>The response from the GetApplicationRevision service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRevisionException">
        /// The revision was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionDoesNotExistException">
        /// The named revision does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        GetApplicationRevisionResponse GetApplicationRevision(GetApplicationRevisionRequest request);


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
        /// Gets information about a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        GetDeploymentResponse GetDeployment(GetDeploymentRequest request);


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
        /// Gets information about a deployment configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentConfig service method.</param>
        /// 
        /// <returns>The response from the GetDeploymentConfig service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        GetDeploymentConfigResponse GetDeploymentConfig(GetDeploymentConfigRequest request);


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
        /// Gets information about a deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentGroup service method.</param>
        /// 
        /// <returns>The response from the GetDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        GetDeploymentGroupResponse GetDeploymentGroup(GetDeploymentGroupRequest request);


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
        /// Gets information about an instance as part of a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentInstance service method.</param>
        /// 
        /// <returns>The response from the GetDeploymentInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceDoesNotExistException">
        /// The specified instance does not exist in the deployment group.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceIdRequiredException">
        /// The instance ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        GetDeploymentInstanceResponse GetDeploymentInstance(GetDeploymentInstanceRequest request);


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
        
        #region  GetOnPremisesInstance


        /// <summary>
        /// Gets information about an on-premises instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOnPremisesInstance service method.</param>
        /// 
        /// <returns>The response from the GetOnPremisesInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNotRegisteredException">
        /// The specified on-premises instance is not registered.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        GetOnPremisesInstanceResponse GetOnPremisesInstance(GetOnPremisesInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetOnPremisesInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOnPremisesInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetOnPremisesInstanceResponse> GetOnPremisesInstanceAsync(GetOnPremisesInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApplicationRevisions


        /// <summary>
        /// Lists information about revisions for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationRevisions service method.</param>
        /// 
        /// <returns>The response from the ListApplicationRevisions service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.BucketNameFilterRequiredException">
        /// A bucket name is required, but was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidBucketNameFilterException">
        /// The bucket name either doesn't exist or was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeployedStateFilterException">
        /// The deployed state filter was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidKeyPrefixFilterException">
        /// The specified key prefix filter was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidSortByException">
        /// The column name to sort by is either not present or was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidSortOrderException">
        /// The sort order was specified in an invalid format.
        /// </exception>
        ListApplicationRevisionsResponse ListApplicationRevisions(ListApplicationRevisionsRequest request);


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
        /// Lists the applications registered with the applicable IAM user or AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        ListApplicationsResponse ListApplications();


        /// <summary>
        /// Lists the applications registered with the applicable IAM user or AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);


        /// <summary>
        /// Lists the applications registered with the applicable IAM user or AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        Task<ListApplicationsResponse> ListApplicationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        /// Lists the deployment configurations with the applicable IAM user or AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListDeploymentConfigs service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        ListDeploymentConfigsResponse ListDeploymentConfigs();


        /// <summary>
        /// Lists the deployment configurations with the applicable IAM user or AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentConfigs service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentConfigs service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        ListDeploymentConfigsResponse ListDeploymentConfigs(ListDeploymentConfigsRequest request);


        /// <summary>
        /// Lists the deployment configurations with the applicable IAM user or AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentConfigs service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        Task<ListDeploymentConfigsResponse> ListDeploymentConfigsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        /// Lists the deployment groups for an application registered with the applicable IAM
        /// user or AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentGroups service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentGroups service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        ListDeploymentGroupsResponse ListDeploymentGroups(ListDeploymentGroupsRequest request);


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
        /// Lists the instance for a deployment associated with the applicable IAM user or AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentInstances service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentNotStartedException">
        /// The specified deployment has not started.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceStatusException">
        /// The specified instance status does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        ListDeploymentInstancesResponse ListDeploymentInstances(ListDeploymentInstancesRequest request);


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
        /// Lists the deployments in a deployment group for an application registered with the
        /// applicable IAM user or AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentStatusException">
        /// The specified deployment status doesn't exist or cannot be determined.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTimeRangeException">
        /// The specified time range was specified in an invalid format.
        /// </exception>
        ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request);


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
        
        #region  ListOnPremisesInstances


        /// <summary>
        /// Gets a list of names for one or more on-premises instances.
        /// 
        ///  
        /// <para>
        /// Unless otherwise specified, both registered and deregistered on-premises instance
        /// names will be listed. To list only registered or deregistered on-premises instance
        /// names, use the registration status parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOnPremisesInstances service method.</param>
        /// 
        /// <returns>The response from the ListOnPremisesInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRegistrationStatusException">
        /// The registration status was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagFilterException">
        /// The specified tag filter was specified in an invalid format.
        /// </exception>
        ListOnPremisesInstancesResponse ListOnPremisesInstances(ListOnPremisesInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListOnPremisesInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOnPremisesInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListOnPremisesInstancesResponse> ListOnPremisesInstancesAsync(ListOnPremisesInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterApplicationRevision


        /// <summary>
        /// Registers with AWS CodeDeploy a revision for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplicationRevision service method.</param>
        /// 
        /// <returns>The response from the RegisterApplicationRevision service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DescriptionTooLongException">
        /// The description is too long.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRevisionException">
        /// The revision was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        RegisterApplicationRevisionResponse RegisterApplicationRevision(RegisterApplicationRevisionRequest request);


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
        
        #region  RegisterOnPremisesInstance


        /// <summary>
        /// Registers an on-premises instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOnPremisesInstance service method.</param>
        /// 
        /// <returns>The response from the RegisterOnPremisesInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.IamUserArnAlreadyRegisteredException">
        /// The specified IAM user ARN is already registered with an on-premises instance.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.IamUserArnRequiredException">
        /// An IAM user ARN was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameAlreadyRegisteredException">
        /// The specified on-premises instance name is already registered.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidIamUserArnException">
        /// The IAM user ARN was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        RegisterOnPremisesInstanceResponse RegisterOnPremisesInstance(RegisterOnPremisesInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterOnPremisesInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterOnPremisesInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterOnPremisesInstanceResponse> RegisterOnPremisesInstanceAsync(RegisterOnPremisesInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTagsFromOnPremisesInstances


        /// <summary>
        /// Removes one or more tags from one or more on-premises instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromOnPremisesInstances service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromOnPremisesInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceLimitExceededException">
        /// The maximum number of allowed on-premises instances in a single call was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNotRegisteredException">
        /// The specified on-premises instance is not registered.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The specified tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagLimitExceededException">
        /// The maximum allowed number of tags was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagRequiredException">
        /// A tag was not specified.
        /// </exception>
        RemoveTagsFromOnPremisesInstancesResponse RemoveTagsFromOnPremisesInstances(RemoveTagsFromOnPremisesInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromOnPremisesInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromOnPremisesInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsFromOnPremisesInstancesResponse> RemoveTagsFromOnPremisesInstancesAsync(RemoveTagsFromOnPremisesInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopDeployment


        /// <summary>
        /// Attempts to stop an ongoing deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDeployment service method.</param>
        /// 
        /// <returns>The response from the StopDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentAlreadyCompletedException">
        /// The deployment is already complete.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        StopDeploymentResponse StopDeployment(StopDeploymentRequest request);


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
        /// Changes the name of an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationAlreadyExistsException">
        /// An application with the specified name already exists with the applicable IAM user
        /// or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);


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
        /// Changes information about a deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeploymentGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupAlreadyExistsException">
        /// A deployment group with the specified name already exists with the applicable IAM
        /// user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoScalingGroupException">
        /// The Auto Scaling group was specified in an invalid format or does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRoleException">
        /// The service role ARN was specified in an invalid format. Or, if an Auto Scaling group
        /// was specified, the specified service role does not grant the appropriate permissions
        /// to Auto Scaling.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The specified tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTriggerConfigException">
        /// The trigger was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.LifecycleHookLimitExceededException">
        /// The limit for lifecycle hooks was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TriggerTargetsLimitExceededException">
        /// The maximum allowed number of triggers was exceeded.
        /// </exception>
        UpdateDeploymentGroupResponse UpdateDeploymentGroup(UpdateDeploymentGroupRequest request);


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