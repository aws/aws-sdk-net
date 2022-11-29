/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SecurityLake.Model;

namespace Amazon.SecurityLake
{
    /// <summary>
    /// Interface for accessing SecurityLake
    ///
    /// <note> 
    /// <para>
    /// Amazon Security Lake is in preview release. Your use of the Amazon Security Lake preview
    /// is subject to Section 2 of the <a href="http://aws.amazon.com/service-terms/">Amazon
    /// Web Services Service Terms</a>("Betas and Previews").
    /// </para>
    ///  </note> 
    /// <para>
    /// Amazon Security Lake is a fully-managed security data lake service. You can use Security
    /// Lake to automatically centralize security data from cloud, on-premises, and custom
    /// sources into a data lake that's stored in your account. Security Lake helps you analyze
    /// security data, so you can get a more complete understanding of your security posture
    /// across the entire organization and improve the protection of your workloads, applications,
    /// and data.
    /// </para>
    ///  
    /// <para>
    /// The data lake is backed by Amazon Simple Storage Service (Amazon S3) buckets, and
    /// you retain ownership over your data.
    /// </para>
    ///  
    /// <para>
    /// Security Lake automates the collection of security-related log and event data from
    /// integrated Amazon Web Services. and third-party services and manages the lifecycle
    /// of data with customizable retention and replication settings. Security Lake also converts
    /// ingested data into Apache Parquet format and a standard open-source schema called
    /// the Open Cybersecurity Schema Framework (OCSF).
    /// </para>
    ///  
    /// <para>
    /// Other Amazon Web Services and third-party services can subscribe to the data that's
    /// stored in Security Lake for incident response and security data analytics.
    /// </para>
    /// </summary>
    public partial interface IAmazonSecurityLake : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISecurityLakePaginatorFactory Paginators { get; }

        
        #region  CreateAwsLogSource


        /// <summary>
        /// Adds a natively-supported Amazon Web Services service as a Security Lake source. Enables
        /// source types for member accounts in required Regions, based on specified parameters.
        /// You can choose any source type in any Region for accounts that are either part of
        /// a trusted organization or standalone accounts. At least one of the three dimensions
        /// is a mandatory input to this API. However, any combination of the three dimensions
        /// can be supplied to this API. 
        /// 
        ///  
        /// <para>
        /// By default, dimension refers to the entire set. When you don't provide a dimension,
        /// Security Lake assumes that the missing dimension refers to the entire set. This is
        /// overridden when you supply any one of the inputs. For instance, when members is not
        /// specified, the API disables all Security Lake member accounts for sources. Similarly,
        /// when Regions are not specified, Security Lake is disabled for all the Regions where
        /// Security Lake is available as a service.
        /// </para>
        ///  
        /// <para>
        /// You can use this API only to enable a natively-supported Amazon Web Services services
        /// as a source. Use <code>CreateCustomLogSource</code> to enable data collection from
        /// a custom source. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAwsLogSource service method.</param>
        /// 
        /// <returns>The response from the CreateAwsLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.S3Exception">
        /// Provides an extension of the AmazonServiceException for errors reported by Amazon
        /// S3 while processing a request. In particular, this class provides access to Amazon
        /// S3's extended request ID. This ID is required debugging information in the case the
        /// user needs to contact Amazon about an issue where Amazon S3 is incorrectly handling
        /// a request.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateAwsLogSource">REST API Reference for CreateAwsLogSource Operation</seealso>
        CreateAwsLogSourceResponse CreateAwsLogSource(CreateAwsLogSourceRequest request);



        /// <summary>
        /// Adds a natively-supported Amazon Web Services service as a Security Lake source. Enables
        /// source types for member accounts in required Regions, based on specified parameters.
        /// You can choose any source type in any Region for accounts that are either part of
        /// a trusted organization or standalone accounts. At least one of the three dimensions
        /// is a mandatory input to this API. However, any combination of the three dimensions
        /// can be supplied to this API. 
        /// 
        ///  
        /// <para>
        /// By default, dimension refers to the entire set. When you don't provide a dimension,
        /// Security Lake assumes that the missing dimension refers to the entire set. This is
        /// overridden when you supply any one of the inputs. For instance, when members is not
        /// specified, the API disables all Security Lake member accounts for sources. Similarly,
        /// when Regions are not specified, Security Lake is disabled for all the Regions where
        /// Security Lake is available as a service.
        /// </para>
        ///  
        /// <para>
        /// You can use this API only to enable a natively-supported Amazon Web Services services
        /// as a source. Use <code>CreateCustomLogSource</code> to enable data collection from
        /// a custom source. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAwsLogSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAwsLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.S3Exception">
        /// Provides an extension of the AmazonServiceException for errors reported by Amazon
        /// S3 while processing a request. In particular, this class provides access to Amazon
        /// S3's extended request ID. This ID is required debugging information in the case the
        /// user needs to contact Amazon about an issue where Amazon S3 is incorrectly handling
        /// a request.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateAwsLogSource">REST API Reference for CreateAwsLogSource Operation</seealso>
        Task<CreateAwsLogSourceResponse> CreateAwsLogSourceAsync(CreateAwsLogSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCustomLogSource


        /// <summary>
        /// Adds a third-party custom source in Amazon Security Lake, from the Region where you
        /// want to create a custom source. Security Lake can collect logs and events from third-party
        /// custom sources. After creating the appropriate API roles, use this API to add a custom
        /// source name in Security Lake. This operation creates a partition in the Security Lake
        /// S3 bucket as the target location for log files from the custom source, an associated
        /// Glue table, and an Glue crawler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomLogSource service method.</param>
        /// 
        /// <returns>The response from the CreateCustomLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSourceNamesException">
        /// There was a conflict when you attempted to modify a Security Lake source name.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateCustomLogSource">REST API Reference for CreateCustomLogSource Operation</seealso>
        CreateCustomLogSourceResponse CreateCustomLogSource(CreateCustomLogSourceRequest request);



        /// <summary>
        /// Adds a third-party custom source in Amazon Security Lake, from the Region where you
        /// want to create a custom source. Security Lake can collect logs and events from third-party
        /// custom sources. After creating the appropriate API roles, use this API to add a custom
        /// source name in Security Lake. This operation creates a partition in the Security Lake
        /// S3 bucket as the target location for log files from the custom source, an associated
        /// Glue table, and an Glue crawler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomLogSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSourceNamesException">
        /// There was a conflict when you attempted to modify a Security Lake source name.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateCustomLogSource">REST API Reference for CreateCustomLogSource Operation</seealso>
        Task<CreateCustomLogSourceResponse> CreateCustomLogSourceAsync(CreateCustomLogSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDatalake


        /// <summary>
        /// Initializes an Amazon Security Lake instance with the provided (or default) configuration.
        /// You can enable Security Lake in Regions with customized settings in advance before
        /// enabling log collection in Regions. You can either use the <code>enableAll</code>
        /// parameter to specify all Regions or you can specify the Regions you want to enable
        /// Security Lake using the <code>Regions</code> parameter and configure these Regions
        /// using the <code>configurations</code> parameter. When the <code>CreateDataLake</code>
        /// API is called multiple times, if that Region is already enabled, it will update the
        /// Region if configuration for that Region is provided. If that Region is a new Region,
        /// it will be set up with the customized configurations if it is specified. 
        /// 
        ///  
        /// <para>
        /// When you enable Security Lake, it starts ingesting security data after the <code>CreateAwsLogSource</code>
        /// call. This includes ingesting security data from sources, storing data, and making
        /// data accessible to subscribers. Security Lake also enables all the existing settings
        /// and resources that it stores or maintains for your account in the current Region,
        /// including security log and event data. For more information, see the Amazon Security
        /// Lake User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalake service method.</param>
        /// 
        /// <returns>The response from the CreateDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalake">REST API Reference for CreateDatalake Operation</seealso>
        CreateDatalakeResponse CreateDatalake(CreateDatalakeRequest request);



        /// <summary>
        /// Initializes an Amazon Security Lake instance with the provided (or default) configuration.
        /// You can enable Security Lake in Regions with customized settings in advance before
        /// enabling log collection in Regions. You can either use the <code>enableAll</code>
        /// parameter to specify all Regions or you can specify the Regions you want to enable
        /// Security Lake using the <code>Regions</code> parameter and configure these Regions
        /// using the <code>configurations</code> parameter. When the <code>CreateDataLake</code>
        /// API is called multiple times, if that Region is already enabled, it will update the
        /// Region if configuration for that Region is provided. If that Region is a new Region,
        /// it will be set up with the customized configurations if it is specified. 
        /// 
        ///  
        /// <para>
        /// When you enable Security Lake, it starts ingesting security data after the <code>CreateAwsLogSource</code>
        /// call. This includes ingesting security data from sources, storing data, and making
        /// data accessible to subscribers. Security Lake also enables all the existing settings
        /// and resources that it stores or maintains for your account in the current Region,
        /// including security log and event data. For more information, see the Amazon Security
        /// Lake User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalake">REST API Reference for CreateDatalake Operation</seealso>
        Task<CreateDatalakeResponse> CreateDatalakeAsync(CreateDatalakeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDatalakeAutoEnable


        /// <summary>
        /// Automatically enable Security Lake in the specified Regions to begin ingesting security
        /// data. When you choose to enable organization accounts automatically, then Security
        /// Lake begins to enable new accounts as member accounts as they are added to the organization.
        /// Security Lake does not enable existing organization accounts that are not yet enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeAutoEnable service method.</param>
        /// 
        /// <returns>The response from the CreateDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeAutoEnable">REST API Reference for CreateDatalakeAutoEnable Operation</seealso>
        CreateDatalakeAutoEnableResponse CreateDatalakeAutoEnable(CreateDatalakeAutoEnableRequest request);



        /// <summary>
        /// Automatically enable Security Lake in the specified Regions to begin ingesting security
        /// data. When you choose to enable organization accounts automatically, then Security
        /// Lake begins to enable new accounts as member accounts as they are added to the organization.
        /// Security Lake does not enable existing organization accounts that are not yet enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeAutoEnable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeAutoEnable">REST API Reference for CreateDatalakeAutoEnable Operation</seealso>
        Task<CreateDatalakeAutoEnableResponse> CreateDatalakeAutoEnableAsync(CreateDatalakeAutoEnableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDatalakeDelegatedAdmin


        /// <summary>
        /// Designates the Security Lake administrator account for the organization. This API
        /// can only be called by the organization management account. The organization management
        /// account cannot be the delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeDelegatedAdmin service method.</param>
        /// 
        /// <returns>The response from the CreateDatalakeDelegatedAdmin service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeDelegatedAdmin">REST API Reference for CreateDatalakeDelegatedAdmin Operation</seealso>
        CreateDatalakeDelegatedAdminResponse CreateDatalakeDelegatedAdmin(CreateDatalakeDelegatedAdminRequest request);



        /// <summary>
        /// Designates the Security Lake administrator account for the organization. This API
        /// can only be called by the organization management account. The organization management
        /// account cannot be the delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeDelegatedAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatalakeDelegatedAdmin service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeDelegatedAdmin">REST API Reference for CreateDatalakeDelegatedAdmin Operation</seealso>
        Task<CreateDatalakeDelegatedAdminResponse> CreateDatalakeDelegatedAdminAsync(CreateDatalakeDelegatedAdminRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDatalakeExceptionsSubscription


        /// <summary>
        /// Creates the specified notification subscription in Security Lake. Creates the specified
        /// subscription notifications in the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeExceptionsSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeExceptionsSubscription">REST API Reference for CreateDatalakeExceptionsSubscription Operation</seealso>
        CreateDatalakeExceptionsSubscriptionResponse CreateDatalakeExceptionsSubscription(CreateDatalakeExceptionsSubscriptionRequest request);



        /// <summary>
        /// Creates the specified notification subscription in Security Lake. Creates the specified
        /// subscription notifications in the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeExceptionsSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeExceptionsSubscription">REST API Reference for CreateDatalakeExceptionsSubscription Operation</seealso>
        Task<CreateDatalakeExceptionsSubscriptionResponse> CreateDatalakeExceptionsSubscriptionAsync(CreateDatalakeExceptionsSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSubscriber


        /// <summary>
        /// Creates a subscription permission for accounts that are already enabled in Security
        /// Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSubscriptionException">
        /// A conflicting subscription exception operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        CreateSubscriberResponse CreateSubscriber(CreateSubscriberRequest request);



        /// <summary>
        /// Creates a subscription permission for accounts that are already enabled in Security
        /// Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSubscriptionException">
        /// A conflicting subscription exception operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        Task<CreateSubscriberResponse> CreateSubscriberAsync(CreateSubscriberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSubscriptionNotificationConfiguration


        /// <summary>
        /// Creates the specified notification subscription in Security Lake. Creates the specified
        /// subscription notifications from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriptionNotificationConfiguration">REST API Reference for CreateSubscriptionNotificationConfiguration Operation</seealso>
        CreateSubscriptionNotificationConfigurationResponse CreateSubscriptionNotificationConfiguration(CreateSubscriptionNotificationConfigurationRequest request);



        /// <summary>
        /// Creates the specified notification subscription in Security Lake. Creates the specified
        /// subscription notifications from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriptionNotificationConfiguration">REST API Reference for CreateSubscriptionNotificationConfiguration Operation</seealso>
        Task<CreateSubscriptionNotificationConfigurationResponse> CreateSubscriptionNotificationConfigurationAsync(CreateSubscriptionNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAwsLogSource


        /// <summary>
        /// Removes a natively-supported Amazon Web Services service as a Amazon Security Lake
        /// source. When you remove the source, Security Lake stops collecting data from that
        /// source, and subscribers can no longer consume new data from the source. Subscribers
        /// can still consume data that Amazon Security Lake collected from the source before
        /// disablement.
        /// 
        ///  
        /// <para>
        /// You can choose any source type in any Region for accounts that are either part of
        /// a trusted organization or standalone accounts. At least one of the three dimensions
        /// is a mandatory input to this API. However, any combination of the three dimensions
        /// can be supplied to this API. 
        /// </para>
        ///  
        /// <para>
        /// By default, dimension refers to the entire set. This is overridden when you supply
        /// any one of the inputs. For instance, when members is not specified, the API disables
        /// all Security Lake member accounts for sources. Similarly, when Regions are not specified,
        /// Security Lake is disabled for all the Regions where Security Lake is available as
        /// a service.
        /// </para>
        ///  
        /// <para>
        /// You can use this API to remove a natively-supported Amazon Web Services service as
        /// a source. Use <code>DeregisterCustomData</code> to remove a custom source.
        /// </para>
        ///  
        /// <para>
        /// When you don't provide a dimension, Security Lake assumes that the missing dimension
        /// refers to the entire set. For example, if you don't provide specific accounts, the
        /// API applies to the entire set of accounts in your organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAwsLogSource service method.</param>
        /// 
        /// <returns>The response from the DeleteAwsLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteAwsLogSource">REST API Reference for DeleteAwsLogSource Operation</seealso>
        DeleteAwsLogSourceResponse DeleteAwsLogSource(DeleteAwsLogSourceRequest request);



        /// <summary>
        /// Removes a natively-supported Amazon Web Services service as a Amazon Security Lake
        /// source. When you remove the source, Security Lake stops collecting data from that
        /// source, and subscribers can no longer consume new data from the source. Subscribers
        /// can still consume data that Amazon Security Lake collected from the source before
        /// disablement.
        /// 
        ///  
        /// <para>
        /// You can choose any source type in any Region for accounts that are either part of
        /// a trusted organization or standalone accounts. At least one of the three dimensions
        /// is a mandatory input to this API. However, any combination of the three dimensions
        /// can be supplied to this API. 
        /// </para>
        ///  
        /// <para>
        /// By default, dimension refers to the entire set. This is overridden when you supply
        /// any one of the inputs. For instance, when members is not specified, the API disables
        /// all Security Lake member accounts for sources. Similarly, when Regions are not specified,
        /// Security Lake is disabled for all the Regions where Security Lake is available as
        /// a service.
        /// </para>
        ///  
        /// <para>
        /// You can use this API to remove a natively-supported Amazon Web Services service as
        /// a source. Use <code>DeregisterCustomData</code> to remove a custom source.
        /// </para>
        ///  
        /// <para>
        /// When you don't provide a dimension, Security Lake assumes that the missing dimension
        /// refers to the entire set. For example, if you don't provide specific accounts, the
        /// API applies to the entire set of accounts in your organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAwsLogSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAwsLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteAwsLogSource">REST API Reference for DeleteAwsLogSource Operation</seealso>
        Task<DeleteAwsLogSourceResponse> DeleteAwsLogSourceAsync(DeleteAwsLogSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCustomLogSource


        /// <summary>
        /// Removes a custom log source from Security Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomLogSource service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSourceNamesException">
        /// There was a conflict when you attempted to modify a Security Lake source name.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteCustomLogSource">REST API Reference for DeleteCustomLogSource Operation</seealso>
        DeleteCustomLogSourceResponse DeleteCustomLogSource(DeleteCustomLogSourceRequest request);



        /// <summary>
        /// Removes a custom log source from Security Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomLogSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSourceNamesException">
        /// There was a conflict when you attempted to modify a Security Lake source name.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteCustomLogSource">REST API Reference for DeleteCustomLogSource Operation</seealso>
        Task<DeleteCustomLogSourceResponse> DeleteCustomLogSourceAsync(DeleteCustomLogSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDatalake


        /// <summary>
        /// When you delete Amazon Security Lake from your account, Security Lake is disabled
        /// in all Regions. Also, this API automatically performs the off-boarding steps to off-board
        /// the account from Security Lake . This includes ingesting security data from sources,
        /// storing data, and making data accessible to subscribers. Security Lake also deletes
        /// all the existing settings and resources that it stores or maintains for your account
        /// in the current Region, including security log and event data. <code>DeleteDatalake</code>
        /// does not delete the S3 bucket which is owned by the Amazon Web Services account. For
        /// more information, see the Amazon Security Lake User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalake service method.</param>
        /// 
        /// <returns>The response from the DeleteDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalake">REST API Reference for DeleteDatalake Operation</seealso>
        DeleteDatalakeResponse DeleteDatalake(DeleteDatalakeRequest request);



        /// <summary>
        /// When you delete Amazon Security Lake from your account, Security Lake is disabled
        /// in all Regions. Also, this API automatically performs the off-boarding steps to off-board
        /// the account from Security Lake . This includes ingesting security data from sources,
        /// storing data, and making data accessible to subscribers. Security Lake also deletes
        /// all the existing settings and resources that it stores or maintains for your account
        /// in the current Region, including security log and event data. <code>DeleteDatalake</code>
        /// does not delete the S3 bucket which is owned by the Amazon Web Services account. For
        /// more information, see the Amazon Security Lake User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalake">REST API Reference for DeleteDatalake Operation</seealso>
        Task<DeleteDatalakeResponse> DeleteDatalakeAsync(DeleteDatalakeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDatalakeAutoEnable


        /// <summary>
        /// Automatically delete Security Lake in the specified Regions to stop ingesting security
        /// data. When you delete Amazon Security Lake from your account, Security Lake is disabled
        /// in all Regions. Also, this API automatically performs the off-boarding steps to off-board
        /// the account from Security Lake . This includes ingesting security data from sources,
        /// storing data, and making data accessible to subscribers. Security Lake also deletes
        /// all the existing settings and resources that it stores or maintains for your account
        /// in the current Region, including security log and event data. For more information,
        /// see the Amazon Security Lake User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeAutoEnable service method.</param>
        /// 
        /// <returns>The response from the DeleteDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeAutoEnable">REST API Reference for DeleteDatalakeAutoEnable Operation</seealso>
        DeleteDatalakeAutoEnableResponse DeleteDatalakeAutoEnable(DeleteDatalakeAutoEnableRequest request);



        /// <summary>
        /// Automatically delete Security Lake in the specified Regions to stop ingesting security
        /// data. When you delete Amazon Security Lake from your account, Security Lake is disabled
        /// in all Regions. Also, this API automatically performs the off-boarding steps to off-board
        /// the account from Security Lake . This includes ingesting security data from sources,
        /// storing data, and making data accessible to subscribers. Security Lake also deletes
        /// all the existing settings and resources that it stores or maintains for your account
        /// in the current Region, including security log and event data. For more information,
        /// see the Amazon Security Lake User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeAutoEnable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeAutoEnable">REST API Reference for DeleteDatalakeAutoEnable Operation</seealso>
        Task<DeleteDatalakeAutoEnableResponse> DeleteDatalakeAutoEnableAsync(DeleteDatalakeAutoEnableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDatalakeDelegatedAdmin


        /// <summary>
        /// Deletes the Security Lake administrator account for the organization. This API can
        /// only be called by the organization management account. The organization management
        /// account cannot be the delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeDelegatedAdmin service method.</param>
        /// 
        /// <returns>The response from the DeleteDatalakeDelegatedAdmin service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeDelegatedAdmin">REST API Reference for DeleteDatalakeDelegatedAdmin Operation</seealso>
        DeleteDatalakeDelegatedAdminResponse DeleteDatalakeDelegatedAdmin(DeleteDatalakeDelegatedAdminRequest request);



        /// <summary>
        /// Deletes the Security Lake administrator account for the organization. This API can
        /// only be called by the organization management account. The organization management
        /// account cannot be the delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeDelegatedAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatalakeDelegatedAdmin service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeDelegatedAdmin">REST API Reference for DeleteDatalakeDelegatedAdmin Operation</seealso>
        Task<DeleteDatalakeDelegatedAdminResponse> DeleteDatalakeDelegatedAdminAsync(DeleteDatalakeDelegatedAdminRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDatalakeExceptionsSubscription


        /// <summary>
        /// Deletes the specified notification subscription in Security Lake. Deletes the specified
        /// subscription notifications in the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeExceptionsSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeExceptionsSubscription">REST API Reference for DeleteDatalakeExceptionsSubscription Operation</seealso>
        DeleteDatalakeExceptionsSubscriptionResponse DeleteDatalakeExceptionsSubscription(DeleteDatalakeExceptionsSubscriptionRequest request);



        /// <summary>
        /// Deletes the specified notification subscription in Security Lake. Deletes the specified
        /// subscription notifications in the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeExceptionsSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeExceptionsSubscription">REST API Reference for DeleteDatalakeExceptionsSubscription Operation</seealso>
        Task<DeleteDatalakeExceptionsSubscriptionResponse> DeleteDatalakeExceptionsSubscriptionAsync(DeleteDatalakeExceptionsSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSubscriber


        /// <summary>
        /// Deletes the specified subscription permissions to Security Lake. Deletes the specified
        /// subscription permissions from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        DeleteSubscriberResponse DeleteSubscriber(DeleteSubscriberRequest request);



        /// <summary>
        /// Deletes the specified subscription permissions to Security Lake. Deletes the specified
        /// subscription permissions from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        Task<DeleteSubscriberResponse> DeleteSubscriberAsync(DeleteSubscriberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSubscriptionNotificationConfiguration


        /// <summary>
        /// Deletes the specified notification subscription in Security Lake. Deletes the specified
        /// subscription notifications from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriptionNotificationConfiguration">REST API Reference for DeleteSubscriptionNotificationConfiguration Operation</seealso>
        DeleteSubscriptionNotificationConfigurationResponse DeleteSubscriptionNotificationConfiguration(DeleteSubscriptionNotificationConfigurationRequest request);



        /// <summary>
        /// Deletes the specified notification subscription in Security Lake. Deletes the specified
        /// subscription notifications from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriptionNotificationConfiguration">REST API Reference for DeleteSubscriptionNotificationConfiguration Operation</seealso>
        Task<DeleteSubscriptionNotificationConfigurationResponse> DeleteSubscriptionNotificationConfigurationAsync(DeleteSubscriptionNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDatalake


        /// <summary>
        /// Retrieve the Security Lake configuration object for the specified account ID. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalake service method.</param>
        /// 
        /// <returns>The response from the GetDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalake">REST API Reference for GetDatalake Operation</seealso>
        GetDatalakeResponse GetDatalake(GetDatalakeRequest request);



        /// <summary>
        /// Retrieve the Security Lake configuration object for the specified account ID. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalake">REST API Reference for GetDatalake Operation</seealso>
        Task<GetDatalakeResponse> GetDatalakeAsync(GetDatalakeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDatalakeAutoEnable


        /// <summary>
        /// Retrieves the configuration that will be automatically set up for accounts added to
        /// the organization after the organization has on boarded to Amazon Security Lake. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeAutoEnable service method.</param>
        /// 
        /// <returns>The response from the GetDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeAutoEnable">REST API Reference for GetDatalakeAutoEnable Operation</seealso>
        GetDatalakeAutoEnableResponse GetDatalakeAutoEnable(GetDatalakeAutoEnableRequest request);



        /// <summary>
        /// Retrieves the configuration that will be automatically set up for accounts added to
        /// the organization after the organization has on boarded to Amazon Security Lake. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeAutoEnable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeAutoEnable">REST API Reference for GetDatalakeAutoEnable Operation</seealso>
        Task<GetDatalakeAutoEnableResponse> GetDatalakeAutoEnableAsync(GetDatalakeAutoEnableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDatalakeExceptionsExpiry


        /// <summary>
        /// Retrieves the expiration period and time-to-live (TTL) for which the exception message
        /// will remain. Exceptions are stored by default, for a 2 week period of time from when
        /// a record was created in Security Lake. This API does not take input parameters. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeExceptionsExpiry service method.</param>
        /// 
        /// <returns>The response from the GetDatalakeExceptionsExpiry service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsExpiry">REST API Reference for GetDatalakeExceptionsExpiry Operation</seealso>
        GetDatalakeExceptionsExpiryResponse GetDatalakeExceptionsExpiry(GetDatalakeExceptionsExpiryRequest request);



        /// <summary>
        /// Retrieves the expiration period and time-to-live (TTL) for which the exception message
        /// will remain. Exceptions are stored by default, for a 2 week period of time from when
        /// a record was created in Security Lake. This API does not take input parameters. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeExceptionsExpiry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatalakeExceptionsExpiry service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsExpiry">REST API Reference for GetDatalakeExceptionsExpiry Operation</seealso>
        Task<GetDatalakeExceptionsExpiryResponse> GetDatalakeExceptionsExpiryAsync(GetDatalakeExceptionsExpiryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDatalakeExceptionsSubscription


        /// <summary>
        /// Retrieves the details of exception notifications for the account in Amazon Security
        /// Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeExceptionsSubscription service method.</param>
        /// 
        /// <returns>The response from the GetDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsSubscription">REST API Reference for GetDatalakeExceptionsSubscription Operation</seealso>
        GetDatalakeExceptionsSubscriptionResponse GetDatalakeExceptionsSubscription(GetDatalakeExceptionsSubscriptionRequest request);



        /// <summary>
        /// Retrieves the details of exception notifications for the account in Amazon Security
        /// Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeExceptionsSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsSubscription">REST API Reference for GetDatalakeExceptionsSubscription Operation</seealso>
        Task<GetDatalakeExceptionsSubscriptionResponse> GetDatalakeExceptionsSubscriptionAsync(GetDatalakeExceptionsSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDatalakeStatus


        /// <summary>
        /// Retrieve the Security Lake configuration object for the specified account ID. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeStatus service method.</param>
        /// 
        /// <returns>The response from the GetDatalakeStatus service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeStatus">REST API Reference for GetDatalakeStatus Operation</seealso>
        GetDatalakeStatusResponse GetDatalakeStatus(GetDatalakeStatusRequest request);



        /// <summary>
        /// Retrieve the Security Lake configuration object for the specified account ID. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatalakeStatus service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeStatus">REST API Reference for GetDatalakeStatus Operation</seealso>
        Task<GetDatalakeStatusResponse> GetDatalakeStatusAsync(GetDatalakeStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSubscriber


        /// <summary>
        /// Retrieves subscription information for the specified subscription ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriber service method.</param>
        /// 
        /// <returns>The response from the GetSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetSubscriber">REST API Reference for GetSubscriber Operation</seealso>
        GetSubscriberResponse GetSubscriber(GetSubscriberRequest request);



        /// <summary>
        /// Retrieves subscription information for the specified subscription ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetSubscriber">REST API Reference for GetSubscriber Operation</seealso>
        Task<GetSubscriberResponse> GetSubscriberAsync(GetSubscriberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDatalakeExceptions


        /// <summary>
        /// List the Amazon Security Lake exceptions that you can use to find the source of problems
        /// and fix them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatalakeExceptions service method.</param>
        /// 
        /// <returns>The response from the ListDatalakeExceptions service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDatalakeExceptions">REST API Reference for ListDatalakeExceptions Operation</seealso>
        ListDatalakeExceptionsResponse ListDatalakeExceptions(ListDatalakeExceptionsRequest request);



        /// <summary>
        /// List the Amazon Security Lake exceptions that you can use to find the source of problems
        /// and fix them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatalakeExceptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatalakeExceptions service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDatalakeExceptions">REST API Reference for ListDatalakeExceptions Operation</seealso>
        Task<ListDatalakeExceptionsResponse> ListDatalakeExceptionsAsync(ListDatalakeExceptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLogSources


        /// <summary>
        /// Lists the log sources in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogSources service method.</param>
        /// 
        /// <returns>The response from the ListLogSources service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListLogSources">REST API Reference for ListLogSources Operation</seealso>
        ListLogSourcesResponse ListLogSources(ListLogSourcesRequest request);



        /// <summary>
        /// Lists the log sources in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLogSources service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListLogSources">REST API Reference for ListLogSources Operation</seealso>
        Task<ListLogSourcesResponse> ListLogSourcesAsync(ListLogSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSubscribers


        /// <summary>
        /// List all subscribers for the specific Security Lake account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribers service method.</param>
        /// 
        /// <returns>The response from the ListSubscribers service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListSubscribers">REST API Reference for ListSubscribers Operation</seealso>
        ListSubscribersResponse ListSubscribers(ListSubscribersRequest request);



        /// <summary>
        /// List all subscribers for the specific Security Lake account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscribers service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListSubscribers">REST API Reference for ListSubscribers Operation</seealso>
        Task<ListSubscribersResponse> ListSubscribersAsync(ListSubscribersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDatalake


        /// <summary>
        /// Amazon Security Lake allows you to specify where to store your security data and for
        /// how long. You can specify a rollup Region to consolidate data from multiple regions.
        /// 
        /// 
        ///  
        /// <para>
        /// You can update the properties of a Region or source. Input can either be directly
        /// specified to the API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalake service method.</param>
        /// 
        /// <returns>The response from the UpdateDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.EventBridgeException">
        /// Represents an error interacting with the Amazon EventBridge service.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalake">REST API Reference for UpdateDatalake Operation</seealso>
        UpdateDatalakeResponse UpdateDatalake(UpdateDatalakeRequest request);



        /// <summary>
        /// Amazon Security Lake allows you to specify where to store your security data and for
        /// how long. You can specify a rollup Region to consolidate data from multiple regions.
        /// 
        /// 
        ///  
        /// <para>
        /// You can update the properties of a Region or source. Input can either be directly
        /// specified to the API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.EventBridgeException">
        /// Represents an error interacting with the Amazon EventBridge service.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalake">REST API Reference for UpdateDatalake Operation</seealso>
        Task<UpdateDatalakeResponse> UpdateDatalakeAsync(UpdateDatalakeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDatalakeExceptionsExpiry


        /// <summary>
        /// Update the expiration period for the exception message to your preferred time, and
        /// control the time-to-live (TTL) for the exception message to remain. Exceptions are
        /// stored by default, for a 2 week period of time from when a record was created in Security
        /// Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalakeExceptionsExpiry service method.</param>
        /// 
        /// <returns>The response from the UpdateDatalakeExceptionsExpiry service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsExpiry">REST API Reference for UpdateDatalakeExceptionsExpiry Operation</seealso>
        UpdateDatalakeExceptionsExpiryResponse UpdateDatalakeExceptionsExpiry(UpdateDatalakeExceptionsExpiryRequest request);



        /// <summary>
        /// Update the expiration period for the exception message to your preferred time, and
        /// control the time-to-live (TTL) for the exception message to remain. Exceptions are
        /// stored by default, for a 2 week period of time from when a record was created in Security
        /// Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalakeExceptionsExpiry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatalakeExceptionsExpiry service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsExpiry">REST API Reference for UpdateDatalakeExceptionsExpiry Operation</seealso>
        Task<UpdateDatalakeExceptionsExpiryResponse> UpdateDatalakeExceptionsExpiryAsync(UpdateDatalakeExceptionsExpiryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDatalakeExceptionsSubscription


        /// <summary>
        /// Update the subscription notification for exception notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalakeExceptionsSubscription service method.</param>
        /// 
        /// <returns>The response from the UpdateDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsSubscription">REST API Reference for UpdateDatalakeExceptionsSubscription Operation</seealso>
        UpdateDatalakeExceptionsSubscriptionResponse UpdateDatalakeExceptionsSubscription(UpdateDatalakeExceptionsSubscriptionRequest request);



        /// <summary>
        /// Update the subscription notification for exception notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalakeExceptionsSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsSubscription">REST API Reference for UpdateDatalakeExceptionsSubscription Operation</seealso>
        Task<UpdateDatalakeExceptionsSubscriptionResponse> UpdateDatalakeExceptionsSubscriptionAsync(UpdateDatalakeExceptionsSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSubscriber


        /// <summary>
        /// Update the subscription permission for the given Security Lake account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSubscriptionException">
        /// A conflicting subscription exception operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        UpdateSubscriberResponse UpdateSubscriber(UpdateSubscriberRequest request);



        /// <summary>
        /// Update the subscription permission for the given Security Lake account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSubscriptionException">
        /// A conflicting subscription exception operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        Task<UpdateSubscriberResponse> UpdateSubscriberAsync(UpdateSubscriberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSubscriptionNotificationConfiguration


        /// <summary>
        /// Create a new subscription notification or add the existing subscription notification
        /// setting for the specified subscription ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriptionNotificationConfiguration">REST API Reference for UpdateSubscriptionNotificationConfiguration Operation</seealso>
        UpdateSubscriptionNotificationConfigurationResponse UpdateSubscriptionNotificationConfiguration(UpdateSubscriptionNotificationConfigurationRequest request);



        /// <summary>
        /// Create a new subscription notification or add the existing subscription notification
        /// setting for the specified subscription ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriptionNotificationConfiguration">REST API Reference for UpdateSubscriptionNotificationConfiguration Operation</seealso>
        Task<UpdateSubscriptionNotificationConfigurationResponse> UpdateSubscriptionNotificationConfigurationAsync(UpdateSubscriptionNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}