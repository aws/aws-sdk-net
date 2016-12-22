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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ElasticBeanstalk.Model;

namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// Interface for accessing ElasticBeanstalk
    ///
    /// AWS Elastic Beanstalk 
    /// <para>
    /// AWS Elastic Beanstalk makes it easy for you to create, deploy, and manage scalable,
    /// fault-tolerant applications running on the Amazon Web Services cloud.
    /// </para>
    ///  
    /// <para>
    /// For more information about this product, go to the <a href="http://aws.amazon.com/elasticbeanstalk/">AWS
    /// Elastic Beanstalk</a> details page. The location of the latest AWS Elastic Beanstalk
    /// WSDL is <a href="http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl">http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl</a>.
    /// To install the Software Development Kits (SDKs), Integrated Development Environment
    /// (IDE) Toolkits, and command line tools that enable you to access the API, go to <a
    /// href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// For a list of region-specific endpoints that AWS Elastic Beanstalk supports, go to
    /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">Regions
    /// and Endpoints</a> in the <i>Amazon Web Services Glossary</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonElasticBeanstalk : IAmazonService, IDisposable
    {
                
        #region  AbortEnvironmentUpdate


        /// <summary>
        /// Initiates the asynchronous execution of the AbortEnvironmentUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortEnvironmentUpdate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AbortEnvironmentUpdateResponse> AbortEnvironmentUpdateAsync(AbortEnvironmentUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ApplyEnvironmentManagedAction


        /// <summary>
        /// Initiates the asynchronous execution of the ApplyEnvironmentManagedAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyEnvironmentManagedAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ApplyEnvironmentManagedActionResponse> ApplyEnvironmentManagedActionAsync(ApplyEnvironmentManagedActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CheckDNSAvailability


        /// <summary>
        /// Initiates the asynchronous execution of the CheckDNSAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CheckDNSAvailabilityResponse> CheckDNSAvailabilityAsync(CheckDNSAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ComposeEnvironments


        /// <summary>
        /// Initiates the asynchronous execution of the ComposeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ComposeEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ComposeEnvironmentsResponse> ComposeEnvironmentsAsync(ComposeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApplicationVersion


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateApplicationVersionResponse> CreateApplicationVersionAsync(CreateApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateConfigurationTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateConfigurationTemplateResponse> CreateConfigurationTemplateAsync(CreateConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEnvironment


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStorageLocation


        /// <summary>
        /// Creates the Amazon S3 storage location for the account.
        /// 
        ///  
        /// <para>
        /// This location is used to store user log files.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one of more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        Task<CreateStorageLocationResponse> CreateStorageLocationAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateStorageLocationResponse> CreateStorageLocationAsync(CreateStorageLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApplicationVersion


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteApplicationVersionResponse> DeleteApplicationVersionAsync(DeleteApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConfigurationTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteConfigurationTemplateResponse> DeleteConfigurationTemplateAsync(DeleteConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEnvironmentConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteEnvironmentConfigurationResponse> DeleteEnvironmentConfigurationAsync(DeleteEnvironmentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApplications


        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        Task<DescribeApplicationsResponse> DescribeApplicationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeApplicationsResponse> DescribeApplicationsAsync(DescribeApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApplicationVersions


        /// <summary>
        /// Retrieve a list of application versions.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(DescribeApplicationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConfigurationOptions


        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(DescribeConfigurationOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConfigurationSettings


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConfigurationSettingsResponse> DescribeConfigurationSettingsAsync(DescribeConfigurationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEnvironmentHealth


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEnvironmentHealthResponse> DescribeEnvironmentHealthAsync(DescribeEnvironmentHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEnvironmentManagedActionHistory


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentManagedActionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActionHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEnvironmentManagedActionHistoryResponse> DescribeEnvironmentManagedActionHistoryAsync(DescribeEnvironmentManagedActionHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEnvironmentManagedActions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentManagedActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEnvironmentManagedActionsResponse> DescribeEnvironmentManagedActionsAsync(DescribeEnvironmentManagedActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEnvironmentResources


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEnvironmentResourcesResponse> DescribeEnvironmentResourcesAsync(DescribeEnvironmentResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEnvironments


        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(DescribeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEvents


        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> 
        /// <para>
        /// This action returns the most recent 1,000 events from the specified <code>NextToken</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstancesHealth


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstancesHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancesHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeInstancesHealthResponse> DescribeInstancesHealthAsync(DescribeInstancesHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAvailableSolutionStacks


        /// <summary>
        /// Returns a list of the available solution stack names.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableSolutionStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(ListAvailableSolutionStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RebuildEnvironment


        /// <summary>
        /// Initiates the asynchronous execution of the RebuildEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RebuildEnvironmentResponse> RebuildEnvironmentAsync(RebuildEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RequestEnvironmentInfo


        /// <summary>
        /// Initiates the asynchronous execution of the RequestEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RequestEnvironmentInfoResponse> RequestEnvironmentInfoAsync(RequestEnvironmentInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestartAppServer


        /// <summary>
        /// Initiates the asynchronous execution of the RestartAppServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestartAppServerResponse> RestartAppServerAsync(RestartAppServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RetrieveEnvironmentInfo


        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RetrieveEnvironmentInfoResponse> RetrieveEnvironmentInfoAsync(RetrieveEnvironmentInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SwapEnvironmentCNAMEs


        /// <summary>
        /// Initiates the asynchronous execution of the SwapEnvironmentCNAMEs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SwapEnvironmentCNAMEsResponse> SwapEnvironmentCNAMEsAsync(SwapEnvironmentCNAMEsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateEnvironment


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TerminateEnvironmentResponse> TerminateEnvironmentAsync(TerminateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplicationResourceLifecycle


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationResourceLifecycle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationResourceLifecycle operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateApplicationResourceLifecycleResponse> UpdateApplicationResourceLifecycleAsync(UpdateApplicationResourceLifecycleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplicationVersion


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateApplicationVersionResponse> UpdateApplicationVersionAsync(UpdateApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConfigurationTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateConfigurationTemplateResponse> UpdateConfigurationTemplateAsync(UpdateConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEnvironment


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidateConfigurationSettings


        /// <summary>
        /// Initiates the asynchronous execution of the ValidateConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ValidateConfigurationSettingsResponse> ValidateConfigurationSettingsAsync(ValidateConfigurationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}