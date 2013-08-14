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
using System.Threading.Tasks;

using Amazon.ElasticBeanstalk.Model;

namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// Interface for accessing AmazonElasticBeanstalk.
    /// 
    /// 
    /// </summary>
	public partial interface IAmazonElasticBeanstalk : IDisposable
    {
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="checkDNSAvailabilityRequest">Container for the necessary parameters to execute the CheckDNSAvailability service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CheckDNSAvailability service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CheckDNSAvailabilityResponse> CheckDNSAvailabilityAsync(CheckDNSAvailabilityRequest checkDNSAvailabilityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createApplicationRequest">Container for the necessary parameters to execute the CreateApplication service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyApplicationsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest createApplicationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createApplicationVersionRequest">Container for the necessary parameters to execute the CreateApplicationVersion service method
        /// on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyApplicationsException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyApplicationVersionsException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateApplicationVersionResponse> CreateApplicationVersionAsync(CreateApplicationVersionRequest createApplicationVersionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createConfigurationTemplateRequest">Container for the necessary parameters to execute the CreateConfigurationTemplate service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateConfigurationTemplate service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyConfigurationTemplatesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateConfigurationTemplateResponse> CreateConfigurationTemplateAsync(CreateConfigurationTemplateRequest createConfigurationTemplateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createEnvironmentRequest">Container for the necessary parameters to execute the CreateEnvironment service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest createEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createStorageLocationRequest">Container for the necessary parameters to execute the CreateStorageLocation service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.TooManyBucketsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateStorageLocationResponse> CreateStorageLocationAsync(CreateStorageLocationRequest createStorageLocationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteApplicationRequest">Container for the necessary parameters to execute the DeleteApplication service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.OperationInProgressException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest deleteApplicationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteApplicationVersionRequest">Container for the necessary parameters to execute the DeleteApplicationVersion service method
        /// on AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.OperationInProgressException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.SourceBundleDeletionException" />
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteApplicationVersionResponse> DeleteApplicationVersionAsync(DeleteApplicationVersionRequest deleteApplicationVersionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteConfigurationTemplateRequest">Container for the necessary parameters to execute the DeleteConfigurationTemplate service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.OperationInProgressException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteConfigurationTemplateResponse> DeleteConfigurationTemplateAsync(DeleteConfigurationTemplateRequest deleteConfigurationTemplateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteEnvironmentConfigurationRequest">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration
        /// service method on AmazonElasticBeanstalk.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteEnvironmentConfigurationResponse> DeleteEnvironmentConfigurationAsync(DeleteEnvironmentConfigurationRequest deleteEnvironmentConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeApplicationsRequest">Container for the necessary parameters to execute the DescribeApplications service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeApplicationsResponse> DescribeApplicationsAsync(DescribeApplicationsRequest describeApplicationsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeApplicationVersionsRequest">Container for the necessary parameters to execute the DescribeApplicationVersions service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(DescribeApplicationVersionsRequest describeApplicationVersionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeConfigurationOptionsRequest">Container for the necessary parameters to execute the DescribeConfigurationOptions service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(DescribeConfigurationOptionsRequest describeConfigurationOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeConfigurationSettingsRequest">Container for the necessary parameters to execute the DescribeConfigurationSettings
        /// service method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSettings service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeConfigurationSettingsResponse> DescribeConfigurationSettingsAsync(DescribeConfigurationSettingsRequest describeConfigurationSettingsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentResourcesRequest">Container for the necessary parameters to execute the DescribeEnvironmentResources service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentResources service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEnvironmentResourcesResponse> DescribeEnvironmentResourcesAsync(DescribeEnvironmentResourcesRequest describeEnvironmentResourcesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeEnvironmentsRequest">Container for the necessary parameters to execute the DescribeEnvironments service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(DescribeEnvironmentsRequest describeEnvironmentsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest describeEventsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="listAvailableSolutionStacksRequest">Container for the necessary parameters to execute the ListAvailableSolutionStacks service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(ListAvailableSolutionStacksRequest listAvailableSolutionStacksRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="rebuildEnvironmentRequest">Container for the necessary parameters to execute the RebuildEnvironment service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RebuildEnvironmentResponse> RebuildEnvironmentAsync(RebuildEnvironmentRequest rebuildEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="requestEnvironmentInfoRequest">Container for the necessary parameters to execute the RequestEnvironmentInfo service method on
        /// AmazonElasticBeanstalk.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RequestEnvironmentInfoResponse> RequestEnvironmentInfoAsync(RequestEnvironmentInfoRequest requestEnvironmentInfoRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="restartAppServerRequest">Container for the necessary parameters to execute the RestartAppServer service method on
        /// AmazonElasticBeanstalk.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RestartAppServerResponse> RestartAppServerAsync(RestartAppServerRequest restartAppServerRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="retrieveEnvironmentInfoRequest">Container for the necessary parameters to execute the RetrieveEnvironmentInfo service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RetrieveEnvironmentInfoResponse> RetrieveEnvironmentInfoAsync(RetrieveEnvironmentInfoRequest retrieveEnvironmentInfoRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="swapEnvironmentCNAMEsRequest">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method on
        /// AmazonElasticBeanstalk.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SwapEnvironmentCNAMEsResponse> SwapEnvironmentCNAMEsAsync(SwapEnvironmentCNAMEsRequest swapEnvironmentCNAMEsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="terminateEnvironmentRequest">Container for the necessary parameters to execute the TerminateEnvironment service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the TerminateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<TerminateEnvironmentResponse> TerminateEnvironmentAsync(TerminateEnvironmentRequest terminateEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateApplicationRequest">Container for the necessary parameters to execute the UpdateApplication service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest updateApplicationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateApplicationVersionRequest">Container for the necessary parameters to execute the UpdateApplicationVersion service method
        /// on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by AmazonElasticBeanstalk.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateApplicationVersionResponse> UpdateApplicationVersionAsync(UpdateApplicationVersionRequest updateApplicationVersionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateConfigurationTemplateRequest">Container for the necessary parameters to execute the UpdateConfigurationTemplate service
        /// method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateConfigurationTemplateResponse> UpdateConfigurationTemplateAsync(UpdateConfigurationTemplateRequest updateConfigurationTemplateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="updateEnvironmentRequest">Container for the necessary parameters to execute the UpdateEnvironment service method on
        /// AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest updateEnvironmentRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="validateConfigurationSettingsRequest">Container for the necessary parameters to execute the ValidateConfigurationSettings
        /// service method on AmazonElasticBeanstalk.</param>
        /// 
        /// <returns>The response from the ValidateConfigurationSettings service method, as returned by AmazonElasticBeanstalk.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ValidateConfigurationSettingsResponse> ValidateConfigurationSettingsAsync(ValidateConfigurationSettingsRequest validateConfigurationSettingsRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
