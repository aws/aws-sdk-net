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
    /// Amazon Security Lake is in preview release. Your use of the Security Lake preview
    /// is subject to Section 2 of the <a href="http://aws.amazon.com/service-terms/">Amazon
    /// Web Services Service Terms</a>("Betas and Previews").
    /// </para>
    ///  </note> 
    /// <para>
    /// Amazon Security Lake is a fully managed security data lake service. You can use Security
    /// Lake to automatically centralize security data from cloud, on-premises, and custom
    /// sources into a data lake that's stored in your Amazon Web Servicesaccount. Amazon
    /// Web Services Organizations is an account management service that lets you consolidate
    /// multiple Amazon Web Services accounts into an organization that you create and centrally
    /// manage. With Organizations, you can create member accounts and invite existing accounts
    /// to join your organization. Security Lake helps you analyze security data for a more
    /// complete understanding of your security posture across the entire organization. It
    /// can also help you improve the protection of your workloads, applications, and data.
    /// </para>
    ///  
    /// <para>
    /// The data lake is backed by Amazon Simple Storage Service (Amazon S3) buckets, and
    /// you retain ownership over your data. 
    /// </para>
    ///  
    /// <para>
    /// Amazon Security Lake integrates with CloudTrail, a service that provides a record
    /// of actions taken by a user, role, or an Amazon Web Services service in Security Lake
    /// CloudTrail captures API calls for Security Lake as events. The calls captured include
    /// calls from the Security Lake console and code calls to the Security Lake API operations.
    /// If you create a trail, you can enable continuous delivery of CloudTrail events to
    /// an Amazon S3 bucket, including events for Security Lake. If you don't configure a
    /// trail, you can still view the most recent events in the CloudTrail console in Event
    /// history. Using the information collected by CloudTrail you can determine the request
    /// that was made to Security Lake, the IP address from which the request was made, who
    /// made the request, when it was made, and additional details. To learn more about Security
    /// Lake information in CloudTrail, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/securitylake-cloudtrail.html">Amazon
    /// Security Lake User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// Security Lake automates the collection of security-related log and event data from
    /// integrated Amazon Web Services and third-party services. It also helps you manage
    /// the lifecycle of data with customizable retention and replication settings. Security
    /// Lake converts ingested data into Apache Parquet format and a standard open-source
    /// schema called the Open Cybersecurity Schema Framework (OCSF).
    /// </para>
    ///  
    /// <para>
    /// Other Amazon Web Services and third-party services can subscribe to the data that's
    /// stored in Security Lake for incident response and security data analytics.
    /// </para>
    /// </summary>
    public partial interface IAmazonSecurityLake : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISecurityLakePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateAwsLogSource


        /// <summary>
        /// Adds a natively supported Amazon Web Service as an Amazon Security Lake source. Enables
        /// source types for member accounts in required Amazon Web Services Regions, based on
        /// the parameters you specify. You can choose any source type in any Region for either
        /// accounts that are part of a trusted organization or standalone accounts. At least
        /// one of the three dimensions is a mandatory input to this API. However, you can supply
        /// any combination of the three dimensions to this API. 
        /// 
        ///  
        /// <para>
        /// By default, a dimension refers to the entire set. When you don't provide a dimension,
        /// Security Lake assumes that the missing dimension refers to the entire set. This is
        /// overridden when you supply any one of the inputs. For instance, when you do not specify
        /// members, the API enables all Security Lake member accounts for all sources. Similarly,
        /// when you do not specify Regions, Security Lake is enabled for all the Regions where
        /// Security Lake is available as a service.
        /// </para>
        ///  
        /// <para>
        /// You can use this API only to enable natively supported Amazon Web Services as a source.
        /// Use <code>CreateCustomLogSource</code> to enable data collection from a custom source.
        /// 
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// S3 while processing a request. In particular, this class provides access to the Amazon
        /// S3 extended request ID. If Amazon S3 is incorrectly handling a request and you need
        /// to contact Amazon, this extended request ID may provide useful debugging information.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateAwsLogSource">REST API Reference for CreateAwsLogSource Operation</seealso>
        CreateAwsLogSourceResponse CreateAwsLogSource(CreateAwsLogSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAwsLogSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAwsLogSource operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAwsLogSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateAwsLogSource">REST API Reference for CreateAwsLogSource Operation</seealso>
        IAsyncResult BeginCreateAwsLogSource(CreateAwsLogSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAwsLogSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAwsLogSource.</param>
        /// 
        /// <returns>Returns a  CreateAwsLogSourceResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateAwsLogSource">REST API Reference for CreateAwsLogSource Operation</seealso>
        CreateAwsLogSourceResponse EndCreateAwsLogSource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCustomLogSource


        /// <summary>
        /// Adds a third-party custom source in Amazon Security Lake, from the Amazon Web Services
        /// Region where you want to create a custom source. Security Lake can collect logs and
        /// events from third-party custom sources. After creating the appropriate IAM role to
        /// invoke Glue crawler, use this API to add a custom source name in Security Lake. This
        /// operation creates a partition in the Amazon S3 bucket for Security Lake as the target
        /// location for log files from the custom source in addition to an associated Glue table
        /// and an Glue crawler.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the CreateCustomLogSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomLogSource operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomLogSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateCustomLogSource">REST API Reference for CreateCustomLogSource Operation</seealso>
        IAsyncResult BeginCreateCustomLogSource(CreateCustomLogSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomLogSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomLogSource.</param>
        /// 
        /// <returns>Returns a  CreateCustomLogSourceResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateCustomLogSource">REST API Reference for CreateCustomLogSource Operation</seealso>
        CreateCustomLogSourceResponse EndCreateCustomLogSource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatalake


        /// <summary>
        /// Initializes an Amazon Security Lake instance with the provided (or default) configuration.
        /// You can enable Security Lake in Amazon Web Services Regions with customized settings
        /// before enabling log collection in Regions. You can either use the <code>enableAll</code>
        /// parameter to specify all Regions or specify the Regions where you want to enable Security
        /// Lake. To specify particular Regions, use the <code>Regions</code> parameter and then
        /// configure these Regions using the <code>configurations</code> parameter. If you have
        /// already enabled Security Lake in a Region when you call this command, the command
        /// will update the Region if you provide new configuration parameters. If you have not
        /// already enabled Security Lake in the Region when you call this API, it will set up
        /// the data lake in the Region with the specified configurations.
        /// 
        ///  
        /// <para>
        /// When you enable Security Lake, it starts ingesting security data after the <code>CreateAwsLogSource</code>
        /// call. This includes ingesting security data from sources, storing data, and making
        /// data accessible to subscribers. Security Lake also enables all the existing settings
        /// and resources that it stores or maintains for your Amazon Web Services account in
        /// the current Region, including security log and event data. For more information, see
        /// the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/what-is-security-lake.html">Amazon
        /// Security Lake User Guide</a>.
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
        /// Initiates the asynchronous execution of the CreateDatalake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalake operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatalake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalake">REST API Reference for CreateDatalake Operation</seealso>
        IAsyncResult BeginCreateDatalake(CreateDatalakeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatalake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatalake.</param>
        /// 
        /// <returns>Returns a  CreateDatalakeResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalake">REST API Reference for CreateDatalake Operation</seealso>
        CreateDatalakeResponse EndCreateDatalake(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatalakeAutoEnable


        /// <summary>
        /// Automatically enables Amazon Security Lake for new member accounts in your organization.
        /// Security Lake is not automatically enabled for any existing member accounts in your
        /// organization.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the CreateDatalakeAutoEnable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeAutoEnable operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatalakeAutoEnable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeAutoEnable">REST API Reference for CreateDatalakeAutoEnable Operation</seealso>
        IAsyncResult BeginCreateDatalakeAutoEnable(CreateDatalakeAutoEnableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatalakeAutoEnable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatalakeAutoEnable.</param>
        /// 
        /// <returns>Returns a  CreateDatalakeAutoEnableResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeAutoEnable">REST API Reference for CreateDatalakeAutoEnable Operation</seealso>
        CreateDatalakeAutoEnableResponse EndCreateDatalakeAutoEnable(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatalakeDelegatedAdmin


        /// <summary>
        /// Designates the Amazon Security Lake delegated administrator account for the organization.
        /// This API can only be called by the organization management account. The organization
        /// management account cannot be the delegated administrator account.
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
        /// Initiates the asynchronous execution of the CreateDatalakeDelegatedAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeDelegatedAdmin operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatalakeDelegatedAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeDelegatedAdmin">REST API Reference for CreateDatalakeDelegatedAdmin Operation</seealso>
        IAsyncResult BeginCreateDatalakeDelegatedAdmin(CreateDatalakeDelegatedAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatalakeDelegatedAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatalakeDelegatedAdmin.</param>
        /// 
        /// <returns>Returns a  CreateDatalakeDelegatedAdminResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeDelegatedAdmin">REST API Reference for CreateDatalakeDelegatedAdmin Operation</seealso>
        CreateDatalakeDelegatedAdminResponse EndCreateDatalakeDelegatedAdmin(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatalakeExceptionsSubscription


        /// <summary>
        /// Creates the specified notification subscription in Amazon Security Lake for the organization
        /// you specify.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the CreateDatalakeExceptionsSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeExceptionsSubscription operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatalakeExceptionsSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeExceptionsSubscription">REST API Reference for CreateDatalakeExceptionsSubscription Operation</seealso>
        IAsyncResult BeginCreateDatalakeExceptionsSubscription(CreateDatalakeExceptionsSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatalakeExceptionsSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatalakeExceptionsSubscription.</param>
        /// 
        /// <returns>Returns a  CreateDatalakeExceptionsSubscriptionResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeExceptionsSubscription">REST API Reference for CreateDatalakeExceptionsSubscription Operation</seealso>
        CreateDatalakeExceptionsSubscriptionResponse EndCreateDatalakeExceptionsSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSubscriber


        /// <summary>
        /// Creates a subscription permission for accounts that are already enabled in Amazon
        /// Security Lake. You can create a subscriber with access to data in the current Amazon
        /// Web Services Region.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// The request was rejected because a value that's not valid or is out of range was supplied
        /// for an input parameter.
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
        /// Initiates the asynchronous execution of the CreateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        IAsyncResult BeginCreateSubscriber(CreateSubscriberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriber.</param>
        /// 
        /// <returns>Returns a  CreateSubscriberResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        CreateSubscriberResponse EndCreateSubscriber(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSubscriptionNotificationConfiguration


        /// <summary>
        /// Notifies the subscriber when new data is written to the data lake for the sources
        /// that the subscriber consumes in Security Lake.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// The request was rejected because a value that's not valid or is out of range was supplied
        /// for an input parameter.
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
        /// Initiates the asynchronous execution of the CreateSubscriptionNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionNotificationConfiguration operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriptionNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriptionNotificationConfiguration">REST API Reference for CreateSubscriptionNotificationConfiguration Operation</seealso>
        IAsyncResult BeginCreateSubscriptionNotificationConfiguration(CreateSubscriptionNotificationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriptionNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriptionNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionNotificationConfigurationResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriptionNotificationConfiguration">REST API Reference for CreateSubscriptionNotificationConfiguration Operation</seealso>
        CreateSubscriptionNotificationConfigurationResponse EndCreateSubscriptionNotificationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAwsLogSource


        /// <summary>
        /// Removes a natively supported Amazon Web Service as an Amazon Security Lake source.
        /// When you remove the source, Security Lake stops collecting data from that source,
        /// and subscribers can no longer consume new data from the source. Subscribers can still
        /// consume data that Security Lake collected from the source before disablement.
        /// 
        ///  
        /// <para>
        /// You can choose any source type in any Amazon Web Services Region for either accounts
        /// that are part of a trusted organization or standalone accounts. At least one of the
        /// three dimensions is a mandatory input to this API. However, you can supply any combination
        /// of the three dimensions to this API. 
        /// </para>
        ///  
        /// <para>
        /// By default, a dimension refers to the entire set. This is overridden when you supply
        /// any one of the inputs. For instance, when you do not specify members, the API disables
        /// all Security Lake member accounts for sources. Similarly, when you do not specify
        /// Regions, Security Lake is disabled for all the Regions where Security Lake is available
        /// as a service.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the DeleteAwsLogSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAwsLogSource operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAwsLogSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteAwsLogSource">REST API Reference for DeleteAwsLogSource Operation</seealso>
        IAsyncResult BeginDeleteAwsLogSource(DeleteAwsLogSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAwsLogSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAwsLogSource.</param>
        /// 
        /// <returns>Returns a  DeleteAwsLogSourceResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteAwsLogSource">REST API Reference for DeleteAwsLogSource Operation</seealso>
        DeleteAwsLogSourceResponse EndDeleteAwsLogSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCustomLogSource


        /// <summary>
        /// Removes a custom log source from Amazon Security Lake.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the DeleteCustomLogSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomLogSource operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomLogSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteCustomLogSource">REST API Reference for DeleteCustomLogSource Operation</seealso>
        IAsyncResult BeginDeleteCustomLogSource(DeleteCustomLogSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomLogSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomLogSource.</param>
        /// 
        /// <returns>Returns a  DeleteCustomLogSourceResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteCustomLogSource">REST API Reference for DeleteCustomLogSource Operation</seealso>
        DeleteCustomLogSourceResponse EndDeleteCustomLogSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDatalake


        /// <summary>
        /// When you delete Amazon Security Lake from your account, Security Lake is disabled
        /// in all Amazon Web Services Regions. Also, this API automatically takes steps to remove
        /// the account from Security Lake . 
        /// 
        ///  
        /// <para>
        /// This operation disables security data collection from sources, deletes data stored,
        /// and stops making data accessible to subscribers. Security Lake also deletes all the
        /// existing settings and resources that it stores or maintains for your Amazon Web Services
        /// account in the current Region, including security log and event data. The <code>DeleteDatalake</code>
        /// operation does not delete the Amazon S3 bucket, which is owned by your Amazon Web
        /// Services account. For more information, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/disable-security-lake.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteDatalake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalake operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatalake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalake">REST API Reference for DeleteDatalake Operation</seealso>
        IAsyncResult BeginDeleteDatalake(DeleteDatalakeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatalake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatalake.</param>
        /// 
        /// <returns>Returns a  DeleteDatalakeResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalake">REST API Reference for DeleteDatalake Operation</seealso>
        DeleteDatalakeResponse EndDeleteDatalake(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDatalakeAutoEnable


        /// <summary>
        /// Automatically deletes Amazon Security Lake to stop collecting security data. When
        /// you delete Amazon Security Lake from your account, Security Lake is disabled in all
        /// Regions. Also, this API automatically takes steps to remove the account from Security
        /// Lake . 
        /// 
        ///  
        /// <para>
        /// This operation disables security data collection from sources, deletes data stored,
        /// and stops making data accessible to subscribers. Security Lake also deletes all the
        /// existing settings and resources that it stores or maintains for your Amazon Web Services
        /// account in the current Region, including security log and event data. The <code>DeleteDatalake</code>
        /// operation does not delete the Amazon S3 bucket, which is owned by your Amazon Web
        /// Services account. For more information, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/disable-security-lake.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the DeleteDatalakeAutoEnable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeAutoEnable operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatalakeAutoEnable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeAutoEnable">REST API Reference for DeleteDatalakeAutoEnable Operation</seealso>
        IAsyncResult BeginDeleteDatalakeAutoEnable(DeleteDatalakeAutoEnableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatalakeAutoEnable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatalakeAutoEnable.</param>
        /// 
        /// <returns>Returns a  DeleteDatalakeAutoEnableResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeAutoEnable">REST API Reference for DeleteDatalakeAutoEnable Operation</seealso>
        DeleteDatalakeAutoEnableResponse EndDeleteDatalakeAutoEnable(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDatalakeDelegatedAdmin


        /// <summary>
        /// Deletes the Amazon Security Lake delegated administrator account for the organization.
        /// This API can only be called by the organization management account. The organization
        /// management account cannot be the delegated administrator account.
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
        /// Initiates the asynchronous execution of the DeleteDatalakeDelegatedAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeDelegatedAdmin operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatalakeDelegatedAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeDelegatedAdmin">REST API Reference for DeleteDatalakeDelegatedAdmin Operation</seealso>
        IAsyncResult BeginDeleteDatalakeDelegatedAdmin(DeleteDatalakeDelegatedAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatalakeDelegatedAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatalakeDelegatedAdmin.</param>
        /// 
        /// <returns>Returns a  DeleteDatalakeDelegatedAdminResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeDelegatedAdmin">REST API Reference for DeleteDatalakeDelegatedAdmin Operation</seealso>
        DeleteDatalakeDelegatedAdminResponse EndDeleteDatalakeDelegatedAdmin(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDatalakeExceptionsSubscription


        /// <summary>
        /// Deletes the specified notification subscription in Amazon Security Lake for the organization
        /// you specify.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the DeleteDatalakeExceptionsSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeExceptionsSubscription operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatalakeExceptionsSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeExceptionsSubscription">REST API Reference for DeleteDatalakeExceptionsSubscription Operation</seealso>
        IAsyncResult BeginDeleteDatalakeExceptionsSubscription(DeleteDatalakeExceptionsSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatalakeExceptionsSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatalakeExceptionsSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteDatalakeExceptionsSubscriptionResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeExceptionsSubscription">REST API Reference for DeleteDatalakeExceptionsSubscription Operation</seealso>
        DeleteDatalakeExceptionsSubscriptionResponse EndDeleteDatalakeExceptionsSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSubscriber


        /// <summary>
        /// Deletes the subscription permission for accounts that are already enabled in Amazon
        /// Security Lake. You can delete a subscriber and remove access to data in the current
        /// Amazon Web Services Region.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// The request was rejected because a value that's not valid or is out of range was supplied
        /// for an input parameter.
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
        /// Initiates the asynchronous execution of the DeleteSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        IAsyncResult BeginDeleteSubscriber(DeleteSubscriberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriber.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriberResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        DeleteSubscriberResponse EndDeleteSubscriber(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSubscriptionNotificationConfiguration


        /// <summary>
        /// Deletes the specified notification subscription in Amazon Security Lake for the organization
        /// you specify.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// The request was rejected because a value that's not valid or is out of range was supplied
        /// for an input parameter.
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
        /// Initiates the asynchronous execution of the DeleteSubscriptionNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionNotificationConfiguration operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriptionNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriptionNotificationConfiguration">REST API Reference for DeleteSubscriptionNotificationConfiguration Operation</seealso>
        IAsyncResult BeginDeleteSubscriptionNotificationConfiguration(DeleteSubscriptionNotificationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriptionNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriptionNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriptionNotificationConfigurationResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriptionNotificationConfiguration">REST API Reference for DeleteSubscriptionNotificationConfiguration Operation</seealso>
        DeleteSubscriptionNotificationConfigurationResponse EndDeleteSubscriptionNotificationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDatalake


        /// <summary>
        /// Retrieves the Amazon Security Lake configuration object for the specified Amazon Web
        /// Services account ID. You can use the <code>GetDatalake</code> API to know whether
        /// Security Lake is enabled for the current Region. This API does not take input parameters.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the GetDatalake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatalake operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatalake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalake">REST API Reference for GetDatalake Operation</seealso>
        IAsyncResult BeginGetDatalake(GetDatalakeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatalake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatalake.</param>
        /// 
        /// <returns>Returns a  GetDatalakeResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalake">REST API Reference for GetDatalake Operation</seealso>
        GetDatalakeResponse EndGetDatalake(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDatalakeAutoEnable


        /// <summary>
        /// Retrieves the configuration that will be automatically set up for accounts added to
        /// the organization after the organization has onboarded to Amazon Security Lake. This
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the GetDatalakeAutoEnable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeAutoEnable operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatalakeAutoEnable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeAutoEnable">REST API Reference for GetDatalakeAutoEnable Operation</seealso>
        IAsyncResult BeginGetDatalakeAutoEnable(GetDatalakeAutoEnableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatalakeAutoEnable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatalakeAutoEnable.</param>
        /// 
        /// <returns>Returns a  GetDatalakeAutoEnableResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeAutoEnable">REST API Reference for GetDatalakeAutoEnable Operation</seealso>
        GetDatalakeAutoEnableResponse EndGetDatalakeAutoEnable(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDatalakeExceptionsExpiry


        /// <summary>
        /// Retrieves the expiration period and time-to-live (TTL) for which the exception message
        /// will remain. Exceptions are stored by default, for 2 weeks from when a record was
        /// created in Amazon Security Lake. This API does not take input parameters.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the GetDatalakeExceptionsExpiry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeExceptionsExpiry operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatalakeExceptionsExpiry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsExpiry">REST API Reference for GetDatalakeExceptionsExpiry Operation</seealso>
        IAsyncResult BeginGetDatalakeExceptionsExpiry(GetDatalakeExceptionsExpiryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatalakeExceptionsExpiry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatalakeExceptionsExpiry.</param>
        /// 
        /// <returns>Returns a  GetDatalakeExceptionsExpiryResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsExpiry">REST API Reference for GetDatalakeExceptionsExpiry Operation</seealso>
        GetDatalakeExceptionsExpiryResponse EndGetDatalakeExceptionsExpiry(IAsyncResult asyncResult);

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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the GetDatalakeExceptionsSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeExceptionsSubscription operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatalakeExceptionsSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsSubscription">REST API Reference for GetDatalakeExceptionsSubscription Operation</seealso>
        IAsyncResult BeginGetDatalakeExceptionsSubscription(GetDatalakeExceptionsSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatalakeExceptionsSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatalakeExceptionsSubscription.</param>
        /// 
        /// <returns>Returns a  GetDatalakeExceptionsSubscriptionResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsSubscription">REST API Reference for GetDatalakeExceptionsSubscription Operation</seealso>
        GetDatalakeExceptionsSubscriptionResponse EndGetDatalakeExceptionsSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDatalakeStatus


        /// <summary>
        /// Retrieves a snapshot of the current Region, including whether Amazon Security Lake
        /// is enabled for those accounts and which sources Security Lake is collecting data from.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the GetDatalakeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeStatus operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatalakeStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeStatus">REST API Reference for GetDatalakeStatus Operation</seealso>
        IAsyncResult BeginGetDatalakeStatus(GetDatalakeStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatalakeStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatalakeStatus.</param>
        /// 
        /// <returns>Returns a  GetDatalakeStatusResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeStatus">REST API Reference for GetDatalakeStatus Operation</seealso>
        GetDatalakeStatusResponse EndGetDatalakeStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSubscriber


        /// <summary>
        /// Retrieves the subscription information for the specified subscription ID. You can
        /// get information about a specific subscriber.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because a value that's not valid or is out of range was supplied
        /// for an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetSubscriber">REST API Reference for GetSubscriber Operation</seealso>
        GetSubscriberResponse GetSubscriber(GetSubscriberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriber operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetSubscriber">REST API Reference for GetSubscriber Operation</seealso>
        IAsyncResult BeginGetSubscriber(GetSubscriberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriber.</param>
        /// 
        /// <returns>Returns a  GetSubscriberResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetSubscriber">REST API Reference for GetSubscriber Operation</seealso>
        GetSubscriberResponse EndGetSubscriber(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatalakeExceptions


        /// <summary>
        /// Lists the Amazon Security Lake exceptions that you can use to find the source of problems
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the ListDatalakeExceptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatalakeExceptions operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatalakeExceptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDatalakeExceptions">REST API Reference for ListDatalakeExceptions Operation</seealso>
        IAsyncResult BeginListDatalakeExceptions(ListDatalakeExceptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatalakeExceptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatalakeExceptions.</param>
        /// 
        /// <returns>Returns a  ListDatalakeExceptionsResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDatalakeExceptions">REST API Reference for ListDatalakeExceptions Operation</seealso>
        ListDatalakeExceptionsResponse EndListDatalakeExceptions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLogSources


        /// <summary>
        /// Retrieves the log sources in the current Amazon Web Services Region.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the ListLogSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLogSources operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLogSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListLogSources">REST API Reference for ListLogSources Operation</seealso>
        IAsyncResult BeginListLogSources(ListLogSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLogSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLogSources.</param>
        /// 
        /// <returns>Returns a  ListLogSourcesResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListLogSources">REST API Reference for ListLogSources Operation</seealso>
        ListLogSourcesResponse EndListLogSources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSubscribers


        /// <summary>
        /// List all subscribers for the specific Amazon Security Lake account ID. You can retrieve
        /// a list of subscriptions associated with a specific organization or Amazon Web Services
        /// account.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because a value that's not valid or is out of range was supplied
        /// for an input parameter.
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
        /// Initiates the asynchronous execution of the ListSubscribers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribers operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscribers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListSubscribers">REST API Reference for ListSubscribers Operation</seealso>
        IAsyncResult BeginListSubscribers(ListSubscribersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscribers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscribers.</param>
        /// 
        /// <returns>Returns a  ListSubscribersResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListSubscribers">REST API Reference for ListSubscribers Operation</seealso>
        ListSubscribersResponse EndListSubscribers(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDatalake


        /// <summary>
        /// Specifies where to store your security data and for how long. You can add a rollup
        /// Region to consolidate data from multiple Amazon Web Services Regions.
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
        /// Initiates the asynchronous execution of the UpdateDatalake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalake operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatalake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalake">REST API Reference for UpdateDatalake Operation</seealso>
        IAsyncResult BeginUpdateDatalake(UpdateDatalakeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatalake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatalake.</param>
        /// 
        /// <returns>Returns a  UpdateDatalakeResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalake">REST API Reference for UpdateDatalake Operation</seealso>
        UpdateDatalakeResponse EndUpdateDatalake(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDatalakeExceptionsExpiry


        /// <summary>
        /// Update the expiration period for the exception message to your preferred time, and
        /// control the time-to-live (TTL) for the exception message to remain. Exceptions are
        /// stored by default for 2 weeks from when a record was created in Amazon Security Lake.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the UpdateDatalakeExceptionsExpiry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalakeExceptionsExpiry operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatalakeExceptionsExpiry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsExpiry">REST API Reference for UpdateDatalakeExceptionsExpiry Operation</seealso>
        IAsyncResult BeginUpdateDatalakeExceptionsExpiry(UpdateDatalakeExceptionsExpiryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatalakeExceptionsExpiry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatalakeExceptionsExpiry.</param>
        /// 
        /// <returns>Returns a  UpdateDatalakeExceptionsExpiryResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsExpiry">REST API Reference for UpdateDatalakeExceptionsExpiry Operation</seealso>
        UpdateDatalakeExceptionsExpiryResponse EndUpdateDatalakeExceptionsExpiry(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDatalakeExceptionsSubscription


        /// <summary>
        /// Updates the specified notification subscription in Amazon Security Lake for the organization
        /// you specify.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// Initiates the asynchronous execution of the UpdateDatalakeExceptionsSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalakeExceptionsSubscription operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatalakeExceptionsSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsSubscription">REST API Reference for UpdateDatalakeExceptionsSubscription Operation</seealso>
        IAsyncResult BeginUpdateDatalakeExceptionsSubscription(UpdateDatalakeExceptionsSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatalakeExceptionsSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatalakeExceptionsSubscription.</param>
        /// 
        /// <returns>Returns a  UpdateDatalakeExceptionsSubscriptionResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsSubscription">REST API Reference for UpdateDatalakeExceptionsSubscription Operation</seealso>
        UpdateDatalakeExceptionsSubscriptionResponse EndUpdateDatalakeExceptionsSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSubscriber


        /// <summary>
        /// Updates an existing subscription for the given Amazon Security Lake account ID. You
        /// can update a subscriber by changing the sources that the subscriber consumes data
        /// from.
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// The request was rejected because a value that's not valid or is out of range was supplied
        /// for an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        UpdateSubscriberResponse UpdateSubscriber(UpdateSubscriberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        IAsyncResult BeginUpdateSubscriber(UpdateSubscriberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriber.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriberResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        UpdateSubscriberResponse EndUpdateSubscriber(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSubscriptionNotificationConfiguration


        /// <summary>
        /// Creates a new subscription notification or adds the existing subscription notification
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
        /// Amazon Security Lake cannot find an Amazon Web Services account with the accountID
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
        /// The request was rejected because a value that's not valid or is out of range was supplied
        /// for an input parameter.
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
        /// Initiates the asynchronous execution of the UpdateSubscriptionNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionNotificationConfiguration operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriptionNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriptionNotificationConfiguration">REST API Reference for UpdateSubscriptionNotificationConfiguration Operation</seealso>
        IAsyncResult BeginUpdateSubscriptionNotificationConfiguration(UpdateSubscriptionNotificationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriptionNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriptionNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriptionNotificationConfigurationResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriptionNotificationConfiguration">REST API Reference for UpdateSubscriptionNotificationConfiguration Operation</seealso>
        UpdateSubscriptionNotificationConfigurationResponse EndUpdateSubscriptionNotificationConfiguration(IAsyncResult asyncResult);

        #endregion
        
    }
}