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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LicenseManager.Model;

namespace Amazon.LicenseManager
{
    /// <summary>
    /// Interface for accessing LicenseManager
    ///
    /// AWS License Manager  
    /// <para>
    ///  <i>This is the AWS License Manager API Reference.</i> It provides descriptions, syntax,
    /// and usage examples for each of the actions and data types for License Manager. The
    /// topic for each action shows the Query API request parameters and the XML response.
    /// You can also view the XML request elements in the WSDL. 
    /// </para>
    ///  
    /// <para>
    ///  Alternatively, you can use one of the AWS SDKs to access an API that's tailored to
    /// the programming language or platform that you're using. For more information, see
    /// <a href="http://aws.amazon.com/tools/#SDKs">AWS SDKs</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonLicenseManager : IAmazonService, IDisposable
    {

        
        #region  CreateLicenseConfiguration


        /// <summary>
        /// Creates a new license configuration object. A license configuration is an abstraction
        /// of a customer license agreement that can be consumed and enforced by License Manager.
        /// Components include specifications for the license type (licensing by instance, socket,
        /// CPU, or VCPU), tenancy (shared tenancy, Amazon EC2 Dedicated Instance, Amazon EC2
        /// Dedicated Host, or any of these), host affinity (how long a VM must be associated
        /// with a host), the number of licenses purchased and used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        CreateLicenseConfigurationResponse CreateLicenseConfiguration(CreateLicenseConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        Task<CreateLicenseConfigurationResponse> CreateLicenseConfigurationAsync(CreateLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLicenseConfiguration


        /// <summary>
        /// Deletes an existing license configuration. This action fails if the configuration
        /// is in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        DeleteLicenseConfigurationResponse DeleteLicenseConfiguration(DeleteLicenseConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        Task<DeleteLicenseConfigurationResponse> DeleteLicenseConfigurationAsync(DeleteLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLicenseConfiguration


        /// <summary>
        /// Returns a detailed description of a license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        GetLicenseConfigurationResponse GetLicenseConfiguration(GetLicenseConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        Task<GetLicenseConfigurationResponse> GetLicenseConfigurationAsync(GetLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetServiceSettings


        /// <summary>
        /// Gets License Manager settings for a region. Exposes the configured S3 bucket, SNS
        /// topic, etc., for inspection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        Task<GetServiceSettingsResponse> GetServiceSettingsAsync(GetServiceSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssociationsForLicenseConfiguration


        /// <summary>
        /// Lists the resource associations for a license configuration. Resource associations
        /// need not consume licenses from a license configuration. For example, an AMI or a stopped
        /// instance may not consume a license (depending on the license rules). Use this operation
        /// to find all resources associated with a license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the ListAssociationsForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        ListAssociationsForLicenseConfigurationResponse ListAssociationsForLicenseConfiguration(ListAssociationsForLicenseConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociationsForLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        Task<ListAssociationsForLicenseConfigurationResponse> ListAssociationsForLicenseConfigurationAsync(ListAssociationsForLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLicenseConfigurations


        /// <summary>
        /// Lists license configuration objects for an account, each containing the name, description,
        /// license type, and other license terms modeled from a license agreement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListLicenseConfigurations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        ListLicenseConfigurationsResponse ListLicenseConfigurations(ListLicenseConfigurationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        Task<ListLicenseConfigurationsResponse> ListLicenseConfigurationsAsync(ListLicenseConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLicenseSpecificationsForResource


        /// <summary>
        /// Returns the license configuration for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource service method.</param>
        /// 
        /// <returns>The response from the ListLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        ListLicenseSpecificationsForResourceResponse ListLicenseSpecificationsForResource(ListLicenseSpecificationsForResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseSpecificationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        Task<ListLicenseSpecificationsForResourceResponse> ListLicenseSpecificationsForResourceAsync(ListLicenseSpecificationsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceInventory


        /// <summary>
        /// Returns a detailed list of resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory service method.</param>
        /// 
        /// <returns>The response from the ListResourceInventory service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FailedDependencyException">
        /// A dependency required to run the API is missing.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        ListResourceInventoryResponse ListResourceInventory(ListResourceInventoryRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceInventory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        Task<ListResourceInventoryResponse> ListResourceInventoryAsync(ListResourceInventoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags attached to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUsageForLicenseConfiguration


        /// <summary>
        /// Lists all license usage records for a license configuration, displaying license consumption
        /// details by resource at a selected point in time. Use this action to audit the current
        /// license consumption for any license inventory and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageForLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the ListUsageForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        ListUsageForLicenseConfigurationResponse ListUsageForLicenseConfiguration(ListUsageForLicenseConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsageForLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsageForLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        Task<ListUsageForLicenseConfigurationResponse> ListUsageForLicenseConfigurationAsync(ListUsageForLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Attach one of more tags to any resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLicenseConfiguration


        /// <summary>
        /// Modifies the attributes of an existing license configuration object. A license configuration
        /// is an abstraction of a customer license agreement that can be consumed and enforced
        /// by License Manager. Components include specifications for the license type (Instances,
        /// cores, sockets, VCPUs), tenancy (shared or Dedicated Host), host affinity (how long
        /// a VM is associated with a host), the number of licenses purchased and used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        UpdateLicenseConfigurationResponse UpdateLicenseConfiguration(UpdateLicenseConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        Task<UpdateLicenseConfigurationResponse> UpdateLicenseConfigurationAsync(UpdateLicenseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLicenseSpecificationsForResource


        /// <summary>
        /// Adds or removes license configurations for a specified AWS resource. This operation
        /// currently supports updating the license specifications of AMIs, instances, and hosts.
        /// Launch templates and AWS CloudFormation templates are not managed from this operation
        /// as those resources send the license configurations directly to a resource creation
        /// operation, such as <code>RunInstances</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidResourceStateException">
        /// License Manager cannot allocate a license to a resource because of its state. 
        /// 
        ///  
        /// <para>
        /// For example, you cannot allocate a license to an instance in the process of shutting
        /// down.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.LicenseUsageException">
        /// You do not have enough licenses available to support a new resource launch.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        UpdateLicenseSpecificationsForResourceResponse UpdateLicenseSpecificationsForResource(UpdateLicenseSpecificationsForResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLicenseSpecificationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        Task<UpdateLicenseSpecificationsForResourceResponse> UpdateLicenseSpecificationsForResourceAsync(UpdateLicenseSpecificationsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateServiceSettings


        /// <summary>
        /// Updates License Manager service settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        Task<UpdateServiceSettingsResponse> UpdateServiceSettingsAsync(UpdateServiceSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}