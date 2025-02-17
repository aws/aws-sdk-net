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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QuickSight.Model;

#pragma warning disable CS1570
namespace Amazon.QuickSight
{
    /// <summary>
    /// <para>Interface for accessing QuickSight</para>
    ///
    /// Amazon QuickSight API Reference 
    /// <para>
    /// Amazon QuickSight is a fully managed, serverless business intelligence service for
    /// the Amazon Web Services Cloud that makes it easy to extend data and insights to every
    /// user in your organization. This API reference contains documentation for a programming
    /// interface that you can use to manage Amazon QuickSight. 
    /// </para>
    /// </summary>
    public partial interface IAmazonQuickSight : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IQuickSightPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchCreateTopicReviewedAnswer



        /// <summary>
        /// Creates new reviewed answers for a Q Topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateTopicReviewedAnswer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateTopicReviewedAnswer service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/BatchCreateTopicReviewedAnswer">REST API Reference for BatchCreateTopicReviewedAnswer Operation</seealso>
        Task<BatchCreateTopicReviewedAnswerResponse> BatchCreateTopicReviewedAnswerAsync(BatchCreateTopicReviewedAnswerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteTopicReviewedAnswer



        /// <summary>
        /// Deletes reviewed answers for Q Topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTopicReviewedAnswer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteTopicReviewedAnswer service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/BatchDeleteTopicReviewedAnswer">REST API Reference for BatchDeleteTopicReviewedAnswer Operation</seealso>
        Task<BatchDeleteTopicReviewedAnswerResponse> BatchDeleteTopicReviewedAnswerAsync(BatchDeleteTopicReviewedAnswerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelIngestion



        /// <summary>
        /// Cancels an ongoing ingestion of data into SPICE.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CancelIngestion">REST API Reference for CancelIngestion Operation</seealso>
        Task<CancelIngestionResponse> CancelIngestionAsync(CancelIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccountCustomization



        /// <summary>
        /// Creates Amazon QuickSight customizations for the current Amazon Web Services Region.
        /// Currently, you can add a custom default theme by using the <c>CreateAccountCustomization</c>
        /// or <c>UpdateAccountCustomization</c> API operation. To further customize Amazon QuickSight
        /// by removing Amazon QuickSight sample assets and videos for all new users, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/customizing-quicksight.html">Customizing
        /// Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide.</i> 
        /// 
        ///  
        /// <para>
        /// You can create customizations for your Amazon Web Services account or, if you specify
        /// a namespace, for a QuickSight namespace instead. Customizations that apply to a namespace
        /// always override customizations that apply to an Amazon Web Services account. To find
        /// out which customizations apply, use the <c>DescribeAccountCustomization</c> API operation.
        /// </para>
        ///  
        /// <para>
        /// Before you use the <c>CreateAccountCustomization</c> API operation to add a theme
        /// as the namespace default, make sure that you first share the theme with the namespace.
        /// If you don't share it with the namespace, the theme isn't visible to your users even
        /// if you make it the default theme. To check if the theme is shared, view the current
        /// permissions by using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeThemePermissions.html">DescribeThemePermissions</a>
        /// </c> API operation. To share the theme, grant permissions by using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateThemePermissions.html">UpdateThemePermissions</a>
        /// </c> API operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAccountCustomization">REST API Reference for CreateAccountCustomization Operation</seealso>
        Task<CreateAccountCustomizationResponse> CreateAccountCustomizationAsync(CreateAccountCustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccountSubscription



        /// <summary>
        /// Creates an Amazon QuickSight account, or subscribes to Amazon QuickSight Q.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Region for the account is derived from what is configured
        /// in the CLI or SDK.
        /// </para>
        ///  
        /// <para>
        /// Before you use this operation, make sure that you can connect to an existing Amazon
        /// Web Services account. If you don't have an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/setting-up-aws-sign-up.html">Sign
        /// up for Amazon Web Services</a> in the <i>Amazon QuickSight User Guide</i>. The person
        /// who signs up for Amazon QuickSight needs to have the correct Identity and Access Management
        /// (IAM) permissions. For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/iam-policy-examples.html">IAM
        /// Policy Examples for Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If your IAM policy includes both the <c>Subscribe</c> and <c>CreateAccountSubscription</c>
        /// actions, make sure that both actions are set to <c>Allow</c>. If either action is
        /// set to <c>Deny</c>, the <c>Deny</c> action prevails and your API call fails.
        /// </para>
        ///  
        /// <para>
        /// You can't pass an existing IAM role to access other Amazon Web Services services using
        /// this API operation. To pass your existing IAM role to Amazon QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/security_iam_service-with-iam.html#security-create-iam-role">Passing
        /// IAM roles to Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can't set default resource access on the new account from the Amazon QuickSight
        /// API. Instead, add default resource access from the Amazon QuickSight console. For
        /// more information about setting default resource access to Amazon Web Services services,
        /// see <a href="https://docs.aws.amazon.com/quicksight/latest/user/scoping-policies-defaults.html">Setting
        /// default resource access to Amazon Web Services services</a> in the <i>Amazon QuickSight
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccountSubscription service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAccountSubscription">REST API Reference for CreateAccountSubscription Operation</seealso>
        Task<CreateAccountSubscriptionResponse> CreateAccountSubscriptionAsync(CreateAccountSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAnalysis



        /// <summary>
        /// Creates an analysis in Amazon QuickSight. Analyses can be created either from a template
        /// or from an <c>AnalysisDefinition</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAnalysis">REST API Reference for CreateAnalysis Operation</seealso>
        Task<CreateAnalysisResponse> CreateAnalysisAsync(CreateAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBrand



        /// <summary>
        /// Creates an Amazon QuickSight brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateBrand">REST API Reference for CreateBrand Operation</seealso>
        Task<CreateBrandResponse> CreateBrandAsync(CreateBrandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCustomPermissions



        /// <summary>
        /// Creates a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateCustomPermissions">REST API Reference for CreateCustomPermissions Operation</seealso>
        Task<CreateCustomPermissionsResponse> CreateCustomPermissionsAsync(CreateCustomPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDashboard



        /// <summary>
        /// Creates a dashboard from either a template or directly with a <c>DashboardDefinition</c>.
        /// To first create a template, see the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_CreateTemplate.html">CreateTemplate</a>
        /// </c> API operation.
        /// 
        ///  
        /// <para>
        /// A dashboard is an entity in Amazon QuickSight that identifies Amazon QuickSight reports,
        /// created from analyses. You can share Amazon QuickSight dashboards. With the right
        /// permissions, you can create scheduled email reports from them. If you have the correct
        /// permissions, you can create a dashboard from a template that exists in a different
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        Task<CreateDashboardResponse> CreateDashboardAsync(CreateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataSet



        /// <summary>
        /// Creates a dataset. This operation doesn't support datasets that include uploaded files
        /// as a source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        Task<CreateDataSetResponse> CreateDataSetAsync(CreateDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataSource



        /// <summary>
        /// Creates a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.CustomerManagedKeyUnavailableException">
        /// The customer managed key that is registered to your Amazon QuickSight account is unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFolder



        /// <summary>
        /// Creates an empty shared folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateFolder">REST API Reference for CreateFolder Operation</seealso>
        Task<CreateFolderResponse> CreateFolderAsync(CreateFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFolderMembership



        /// <summary>
        /// Adds an asset, such as a dashboard, analysis, or dataset into a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFolderMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFolderMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateFolderMembership">REST API Reference for CreateFolderMembership Operation</seealso>
        Task<CreateFolderMembershipResponse> CreateFolderMembershipAsync(CreateFolderMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGroup



        /// <summary>
        /// Use the <c>CreateGroup</c> operation to create a group in Amazon QuickSight. You can
        /// create up to 10,000 groups in a namespace. If you want to create more than 10,000
        /// groups in a namespace, contact Amazon Web Services Support.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:&lt;your-region&gt;:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </c>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGroupMembership



        /// <summary>
        /// Adds an Amazon QuickSight user to an Amazon QuickSight group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        Task<CreateGroupMembershipResponse> CreateGroupMembershipAsync(CreateGroupMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIAMPolicyAssignment



        /// <summary>
        /// Creates an assignment with one specified IAM policy, identified by its Amazon Resource
        /// Name (ARN). This policy assignment is attached to the specified groups or users of
        /// Amazon QuickSight. Assignment names are unique per Amazon Web Services account. To
        /// avoid overwriting rules in other namespaces, use assignment names that are unique.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIAMPolicyAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIAMPolicyAssignment">REST API Reference for CreateIAMPolicyAssignment Operation</seealso>
        Task<CreateIAMPolicyAssignmentResponse> CreateIAMPolicyAssignmentAsync(CreateIAMPolicyAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIngestion



        /// <summary>
        /// Creates and starts a new SPICE ingestion for a dataset. You can manually refresh datasets
        /// in an Enterprise edition account 32 times in a 24-hour period. You can manually refresh
        /// datasets in a Standard edition account 8 times in a 24-hour period. Each 24-hour period
        /// is measured starting 24 hours before the current date and time.
        /// 
        ///  
        /// <para>
        /// Any ingestions operating on tagged datasets inherit the same tags automatically for
        /// use in access control. For an example, see <a href="http://aws.amazon.com/premiumsupport/knowledge-center/iam-ec2-resource-tags/">How
        /// do I create an IAM policy to control access to Amazon EC2 resources using tags?</a>
        /// in the Amazon Web Services Knowledge Center. Tags are visible on the tagged dataset,
        /// but not on the ingestion resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        Task<CreateIngestionResponse> CreateIngestionAsync(CreateIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNamespace



        /// <summary>
        /// (Enterprise edition only) Creates a new namespace for you to use with Amazon QuickSight.
        /// 
        ///  
        /// <para>
        /// A namespace allows you to isolate the Amazon QuickSight users and groups that are
        /// registered for that namespace. Users that access the namespace can share assets only
        /// with other users or groups in the same namespace. They can't see users and groups
        /// in other namespaces. You can create a namespace after your Amazon Web Services account
        /// is subscribed to Amazon QuickSight. The namespace must be unique within the Amazon
        /// Web Services account. By default, there is a limit of 100 namespaces per Amazon Web
        /// Services account. To increase your limit, create a ticket with Amazon Web Services
        /// Support. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNamespace service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRefreshSchedule



        /// <summary>
        /// Creates a refresh schedule for a dataset. You can create up to 5 different schedules
        /// for a single dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateRefreshSchedule">REST API Reference for CreateRefreshSchedule Operation</seealso>
        Task<CreateRefreshScheduleResponse> CreateRefreshScheduleAsync(CreateRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRoleMembership



        /// <summary>
        /// Use <c>CreateRoleMembership</c> to add an existing Amazon QuickSight group to an existing
        /// role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoleMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoleMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateRoleMembership">REST API Reference for CreateRoleMembership Operation</seealso>
        Task<CreateRoleMembershipResponse> CreateRoleMembershipAsync(CreateRoleMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTemplate



        /// <summary>
        /// Creates a template either from a <c>TemplateDefinition</c> or from an existing Amazon
        /// QuickSight analysis or template. You can use the resulting template to create additional
        /// dashboards, templates, or analyses.
        /// 
        ///  
        /// <para>
        /// A <i>template</i> is an entity in Amazon QuickSight that encapsulates the metadata
        /// required to create an analysis and that you can use to create s dashboard. A template
        /// adds a layer of abstraction by using placeholders to replace the dataset associated
        /// with the analysis. You can use templates to create dashboards by replacing dataset
        /// placeholders with datasets that follow the same schema that was used to create the
        /// source analysis and template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTemplateAlias



        /// <summary>
        /// Creates a template alias for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplateAlias">REST API Reference for CreateTemplateAlias Operation</seealso>
        Task<CreateTemplateAliasResponse> CreateTemplateAliasAsync(CreateTemplateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTheme



        /// <summary>
        /// Creates a theme.
        /// 
        ///  
        /// <para>
        /// A <i>theme</i> is set of configuration options for color and layout. Themes apply
        /// to analyses and dashboards. For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/themes-in-quicksight.html">Using
        /// Themes in Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTheme">REST API Reference for CreateTheme Operation</seealso>
        Task<CreateThemeResponse> CreateThemeAsync(CreateThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateThemeAlias



        /// <summary>
        /// Creates a theme alias for a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThemeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateThemeAlias">REST API Reference for CreateThemeAlias Operation</seealso>
        Task<CreateThemeAliasResponse> CreateThemeAliasAsync(CreateThemeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTopic



        /// <summary>
        /// Creates a new Q topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTopicRefreshSchedule



        /// <summary>
        /// Creates a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTopicRefreshSchedule">REST API Reference for CreateTopicRefreshSchedule Operation</seealso>
        Task<CreateTopicRefreshScheduleResponse> CreateTopicRefreshScheduleAsync(CreateTopicRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVPCConnection



        /// <summary>
        /// Creates a new VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVPCConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateVPCConnection">REST API Reference for CreateVPCConnection Operation</seealso>
        Task<CreateVPCConnectionResponse> CreateVPCConnectionAsync(CreateVPCConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccountCustomization



        /// <summary>
        /// Deletes all Amazon QuickSight customizations in this Amazon Web Services Region for
        /// the specified Amazon Web Services account and Amazon QuickSight namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountCustomization">REST API Reference for DeleteAccountCustomization Operation</seealso>
        Task<DeleteAccountCustomizationResponse> DeleteAccountCustomizationAsync(DeleteAccountCustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccountSubscription



        /// <summary>
        /// Use the <c>DeleteAccountSubscription</c> operation to delete an Amazon QuickSight
        /// account. This operation will result in an error message if you have configured your
        /// account termination protection settings to <c>True</c>. To change this setting and
        /// delete your account, call the <c>UpdateAccountSettings</c> API and set the value of
        /// the <c>TerminationProtectionEnabled</c> parameter to <c>False</c>, then make another
        /// call to the <c>DeleteAccountSubscription</c> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountSubscription service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountSubscription">REST API Reference for DeleteAccountSubscription Operation</seealso>
        Task<DeleteAccountSubscriptionResponse> DeleteAccountSubscriptionAsync(DeleteAccountSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAnalysis



        /// <summary>
        /// Deletes an analysis from Amazon QuickSight. You can optionally include a recovery
        /// window during which you can restore the analysis. If you don't specify a recovery
        /// window value, the operation defaults to 30 days. Amazon QuickSight attaches a <c>DeletionTime</c>
        /// stamp to the response that specifies the end of the recovery window. At the end of
        /// the recovery window, Amazon QuickSight deletes the analysis permanently.
        /// 
        ///  
        /// <para>
        /// At any time before recovery window ends, you can use the <c>RestoreAnalysis</c> API
        /// operation to remove the <c>DeletionTime</c> stamp and cancel the deletion of the analysis.
        /// The analysis remains visible in the API until it's deleted, so you can describe it
        /// but you can't make a template from it.
        /// </para>
        ///  
        /// <para>
        /// An analysis that's scheduled for deletion isn't accessible in the Amazon QuickSight
        /// console. To access it in the console, restore it. Deleting an analysis doesn't delete
        /// the dashboards that you publish from it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAnalysis">REST API Reference for DeleteAnalysis Operation</seealso>
        Task<DeleteAnalysisResponse> DeleteAnalysisAsync(DeleteAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBrand



        /// <summary>
        /// Deletes an Amazon QuickSight brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteBrand">REST API Reference for DeleteBrand Operation</seealso>
        Task<DeleteBrandResponse> DeleteBrandAsync(DeleteBrandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBrandAssignment



        /// <summary>
        /// Deletes a brand assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrandAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBrandAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteBrandAssignment">REST API Reference for DeleteBrandAssignment Operation</seealso>
        Task<DeleteBrandAssignmentResponse> DeleteBrandAssignmentAsync(DeleteBrandAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCustomPermissions



        /// <summary>
        /// Deletes a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteCustomPermissions">REST API Reference for DeleteCustomPermissions Operation</seealso>
        Task<DeleteCustomPermissionsResponse> DeleteCustomPermissionsAsync(DeleteCustomPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDashboard



        /// <summary>
        /// Deletes a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        Task<DeleteDashboardResponse> DeleteDashboardAsync(DeleteDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataSet



        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        Task<DeleteDataSetResponse> DeleteDataSetAsync(DeleteDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataSetRefreshProperties



        /// <summary>
        /// Deletes the dataset refresh properties of the dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSetRefreshProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSetRefreshProperties service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSetRefreshProperties">REST API Reference for DeleteDataSetRefreshProperties Operation</seealso>
        Task<DeleteDataSetRefreshPropertiesResponse> DeleteDataSetRefreshPropertiesAsync(DeleteDataSetRefreshPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataSource



        /// <summary>
        /// Deletes the data source permanently. This operation breaks all the datasets that reference
        /// the deleted data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDefaultQBusinessApplication



        /// <summary>
        /// Deletes a linked Amazon Q Business application from an Amazon QuickSight account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultQBusinessApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDefaultQBusinessApplication service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDefaultQBusinessApplication">REST API Reference for DeleteDefaultQBusinessApplication Operation</seealso>
        Task<DeleteDefaultQBusinessApplicationResponse> DeleteDefaultQBusinessApplicationAsync(DeleteDefaultQBusinessApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFolder



        /// <summary>
        /// Deletes an empty folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteFolder">REST API Reference for DeleteFolder Operation</seealso>
        Task<DeleteFolderResponse> DeleteFolderAsync(DeleteFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFolderMembership



        /// <summary>
        /// Removes an asset, such as a dashboard, analysis, or dataset, from a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolderMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFolderMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteFolderMembership">REST API Reference for DeleteFolderMembership Operation</seealso>
        Task<DeleteFolderMembershipResponse> DeleteFolderMembershipAsync(DeleteFolderMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGroup



        /// <summary>
        /// Removes a user group from Amazon QuickSight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGroupMembership



        /// <summary>
        /// Removes a user from a group so that the user is no longer a member of the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        Task<DeleteGroupMembershipResponse> DeleteGroupMembershipAsync(DeleteGroupMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIAMPolicyAssignment



        /// <summary>
        /// Deletes an existing IAM policy assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIAMPolicyAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIAMPolicyAssignment">REST API Reference for DeleteIAMPolicyAssignment Operation</seealso>
        Task<DeleteIAMPolicyAssignmentResponse> DeleteIAMPolicyAssignmentAsync(DeleteIAMPolicyAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIdentityPropagationConfig



        /// <summary>
        /// Deletes all access scopes and authorized targets that are associated with a service
        /// from the Amazon QuickSight IAM Identity Center application.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for Amazon QuickSight accounts that use IAM Identity
        /// Center.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPropagationConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdentityPropagationConfig service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIdentityPropagationConfig">REST API Reference for DeleteIdentityPropagationConfig Operation</seealso>
        Task<DeleteIdentityPropagationConfigResponse> DeleteIdentityPropagationConfigAsync(DeleteIdentityPropagationConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNamespace



        /// <summary>
        /// Deletes a namespace and the users and groups that are associated with the namespace.
        /// This is an asynchronous process. Assets including dashboards, analyses, datasets and
        /// data sources are not deleted. To delete these assets, you use the API operations for
        /// the relevant asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRefreshSchedule



        /// <summary>
        /// Deletes a refresh schedule from a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRefreshSchedule">REST API Reference for DeleteRefreshSchedule Operation</seealso>
        Task<DeleteRefreshScheduleResponse> DeleteRefreshScheduleAsync(DeleteRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRoleCustomPermission



        /// <summary>
        /// Removes custom permissions from the role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleCustomPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoleCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRoleCustomPermission">REST API Reference for DeleteRoleCustomPermission Operation</seealso>
        Task<DeleteRoleCustomPermissionResponse> DeleteRoleCustomPermissionAsync(DeleteRoleCustomPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRoleMembership



        /// <summary>
        /// Removes a group from a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoleMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRoleMembership">REST API Reference for DeleteRoleMembership Operation</seealso>
        Task<DeleteRoleMembershipResponse> DeleteRoleMembershipAsync(DeleteRoleMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTemplate



        /// <summary>
        /// Deletes a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTemplateAlias



        /// <summary>
        /// Deletes the item that the specified template alias points to. If you provide a specific
        /// alias, you delete the version of the template that the alias points to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplateAlias">REST API Reference for DeleteTemplateAlias Operation</seealso>
        Task<DeleteTemplateAliasResponse> DeleteTemplateAliasAsync(DeleteTemplateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTheme



        /// <summary>
        /// Deletes a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTheme">REST API Reference for DeleteTheme Operation</seealso>
        Task<DeleteThemeResponse> DeleteThemeAsync(DeleteThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteThemeAlias



        /// <summary>
        /// Deletes the version of the theme that the specified theme alias points to. If you
        /// provide a specific alias, you delete the version of the theme that the alias points
        /// to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThemeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteThemeAlias">REST API Reference for DeleteThemeAlias Operation</seealso>
        Task<DeleteThemeAliasResponse> DeleteThemeAliasAsync(DeleteThemeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTopic



        /// <summary>
        /// Deletes a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTopic">REST API Reference for DeleteTopic Operation</seealso>
        Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTopicRefreshSchedule



        /// <summary>
        /// Deletes a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTopicRefreshSchedule">REST API Reference for DeleteTopicRefreshSchedule Operation</seealso>
        Task<DeleteTopicRefreshScheduleResponse> DeleteTopicRefreshScheduleAsync(DeleteTopicRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUser



        /// <summary>
        /// Deletes the Amazon QuickSight user that is associated with the identity of the IAM
        /// user or role that's making the call. The IAM user isn't deleted as a result of this
        /// call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserByPrincipalId



        /// <summary>
        /// Deletes a user identified by its principal ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserByPrincipalId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserByPrincipalId service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        Task<DeleteUserByPrincipalIdResponse> DeleteUserByPrincipalIdAsync(DeleteUserByPrincipalIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserCustomPermission



        /// <summary>
        /// Deletes a custom permissions profile from a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserCustomPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserCustomPermission">REST API Reference for DeleteUserCustomPermission Operation</seealso>
        Task<DeleteUserCustomPermissionResponse> DeleteUserCustomPermissionAsync(DeleteUserCustomPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVPCConnection



        /// <summary>
        /// Deletes a VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVPCConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteVPCConnection">REST API Reference for DeleteVPCConnection Operation</seealso>
        Task<DeleteVPCConnectionResponse> DeleteVPCConnectionAsync(DeleteVPCConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountCustomization



        /// <summary>
        /// Describes the customizations associated with the provided Amazon Web Services account
        /// and Amazon Amazon QuickSight namespace in an Amazon Web Services Region. The Amazon
        /// QuickSight console evaluates which customizations to apply by running this API operation
        /// with the <c>Resolved</c> flag included. 
        /// 
        ///  
        /// <para>
        /// To determine what customizations display when you run this command, it can help to
        /// visualize the relationship of the entities involved. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Amazon Web Services account</c> - The Amazon Web Services account exists at the
        /// top of the hierarchy. It has the potential to use all of the Amazon Web Services Regions
        /// and Amazon Web Services Services. When you subscribe to Amazon QuickSight, you choose
        /// one Amazon Web Services Region to use as your home Region. That's where your free
        /// SPICE capacity is located. You can use Amazon QuickSight in any supported Amazon Web
        /// Services Region. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon Web Services Region</c> - In each Amazon Web Services Region where you
        /// sign in to Amazon QuickSight at least once, Amazon QuickSight acts as a separate instance
        /// of the same service. If you have a user directory, it resides in us-east-1, which
        /// is the US East (N. Virginia). Generally speaking, these users have access to Amazon
        /// QuickSight in any Amazon Web Services Region, unless they are constrained to a namespace.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To run the command in a different Amazon Web Services Region, you change your Region
        /// settings. If you're using the CLI, you can use one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-options.html">command
        /// line options</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-profiles.html">named
        /// profiles</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Run <c>aws configure</c> to change your default Amazon Web Services Region. Use Enter
        /// to key the same settings for your keys. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-configure.html">Configuring
        /// the CLI</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>Namespace</c> - A QuickSight namespace is a partition that contains users and
        /// assets (data sources, datasets, dashboards, and so on). To access assets that are
        /// in a specific namespace, users and groups must also be part of the same namespace.
        /// People who share a namespace are completely isolated from users and assets in other
        /// namespaces, even if they are in the same Amazon Web Services account and Amazon Web
        /// Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Applied customizations</c> - Within an Amazon Web Services Region, a set of Amazon
        /// QuickSight customizations can apply to an Amazon Web Services account or to a namespace.
        /// Settings that you apply to a namespace override settings that you apply to an Amazon
        /// Web Services account. All settings are isolated to a single Amazon Web Services Region.
        /// To apply them in other Amazon Web Services Regions, run the <c>CreateAccountCustomization</c>
        /// command in each Amazon Web Services Region where you want to apply the same customizations.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountCustomization">REST API Reference for DescribeAccountCustomization Operation</seealso>
        Task<DescribeAccountCustomizationResponse> DescribeAccountCustomizationAsync(DescribeAccountCustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountSettings



        /// <summary>
        /// Describes the settings that were used when your Amazon QuickSight subscription was
        /// first created in this Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountSettings service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountSettings">REST API Reference for DescribeAccountSettings Operation</seealso>
        Task<DescribeAccountSettingsResponse> DescribeAccountSettingsAsync(DescribeAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountSubscription



        /// <summary>
        /// Use the DescribeAccountSubscription operation to receive a description of an Amazon
        /// QuickSight account's subscription. A successful API call returns an <c>AccountInfo</c>
        /// object that includes an account's name, subscription status, authentication type,
        /// edition, and notification email address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountSubscription service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountSubscription">REST API Reference for DescribeAccountSubscription Operation</seealso>
        Task<DescribeAccountSubscriptionResponse> DescribeAccountSubscriptionAsync(DescribeAccountSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAnalysis



        /// <summary>
        /// Provides a summary of the metadata for an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysis">REST API Reference for DescribeAnalysis Operation</seealso>
        Task<DescribeAnalysisResponse> DescribeAnalysisAsync(DescribeAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAnalysisDefinition



        /// <summary>
        /// Provides a detailed description of the definition of an analysis.
        /// 
        ///  <note> 
        /// <para>
        /// If you do not need to know details about the content of an Analysis, for instance
        /// if you are trying to check the status of a recently created or updated Analysis, use
        /// the <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeAnalysis.html">
        /// <c>DescribeAnalysis</c> </a> instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnalysisDefinition service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysisDefinition">REST API Reference for DescribeAnalysisDefinition Operation</seealso>
        Task<DescribeAnalysisDefinitionResponse> DescribeAnalysisDefinitionAsync(DescribeAnalysisDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAnalysisPermissions



        /// <summary>
        /// Provides the read and write permissions for an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnalysisPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysisPermissions">REST API Reference for DescribeAnalysisPermissions Operation</seealso>
        Task<DescribeAnalysisPermissionsResponse> DescribeAnalysisPermissionsAsync(DescribeAnalysisPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAssetBundleExportJob



        /// <summary>
        /// Describes an existing export job.
        /// 
        ///  
        /// <para>
        /// Poll job descriptions after a job starts to know the status of the job. When a job
        /// succeeds, a URL is provided to download the exported assets' data from. Download URLs
        /// are valid for five minutes after they are generated. You can call the <c>DescribeAssetBundleExportJob</c>
        /// API for a new download URL as needed.
        /// </para>
        ///  
        /// <para>
        /// Job descriptions are available for 14 days after the job starts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetBundleExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssetBundleExportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAssetBundleExportJob">REST API Reference for DescribeAssetBundleExportJob Operation</seealso>
        Task<DescribeAssetBundleExportJobResponse> DescribeAssetBundleExportJobAsync(DescribeAssetBundleExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAssetBundleImportJob



        /// <summary>
        /// Describes an existing import job.
        /// 
        ///  
        /// <para>
        /// Poll job descriptions after starting a job to know when it has succeeded or failed.
        /// Job descriptions are available for 14 days after job starts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetBundleImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssetBundleImportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAssetBundleImportJob">REST API Reference for DescribeAssetBundleImportJob Operation</seealso>
        Task<DescribeAssetBundleImportJobResponse> DescribeAssetBundleImportJobAsync(DescribeAssetBundleImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBrand



        /// <summary>
        /// Describes a brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrand">REST API Reference for DescribeBrand Operation</seealso>
        Task<DescribeBrandResponse> DescribeBrandAsync(DescribeBrandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBrandAssignment



        /// <summary>
        /// Describes a brand assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrandAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBrandAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrandAssignment">REST API Reference for DescribeBrandAssignment Operation</seealso>
        Task<DescribeBrandAssignmentResponse> DescribeBrandAssignmentAsync(DescribeBrandAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBrandPublishedVersion



        /// <summary>
        /// Describes the published version of the brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrandPublishedVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBrandPublishedVersion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrandPublishedVersion">REST API Reference for DescribeBrandPublishedVersion Operation</seealso>
        Task<DescribeBrandPublishedVersionResponse> DescribeBrandPublishedVersionAsync(DescribeBrandPublishedVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCustomPermissions



        /// <summary>
        /// Describes a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeCustomPermissions">REST API Reference for DescribeCustomPermissions Operation</seealso>
        Task<DescribeCustomPermissionsResponse> DescribeCustomPermissionsAsync(DescribeCustomPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDashboard



        /// <summary>
        /// Provides a summary for a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        Task<DescribeDashboardResponse> DescribeDashboardAsync(DescribeDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDashboardDefinition



        /// <summary>
        /// Provides a detailed description of the definition of a dashboard.
        /// 
        ///  <note> 
        /// <para>
        /// If you do not need to know details about the content of a dashboard, for instance
        /// if you are trying to check the status of a recently created or updated dashboard,
        /// use the <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeDashboard.html">
        /// <c>DescribeDashboard</c> </a> instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboardDefinition service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardDefinition">REST API Reference for DescribeDashboardDefinition Operation</seealso>
        Task<DescribeDashboardDefinitionResponse> DescribeDashboardDefinitionAsync(DescribeDashboardDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDashboardPermissions



        /// <summary>
        /// Describes read and write permissions for a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboardPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardPermissions">REST API Reference for DescribeDashboardPermissions Operation</seealso>
        Task<DescribeDashboardPermissionsResponse> DescribeDashboardPermissionsAsync(DescribeDashboardPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDashboardSnapshotJob



        /// <summary>
        /// Describes an existing snapshot job.
        /// 
        ///  
        /// <para>
        /// Poll job descriptions after a job starts to know the status of the job. For information
        /// on available status codes, see <c>JobStatus</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardSnapshotJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboardSnapshotJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardSnapshotJob">REST API Reference for DescribeDashboardSnapshotJob Operation</seealso>
        Task<DescribeDashboardSnapshotJobResponse> DescribeDashboardSnapshotJobAsync(DescribeDashboardSnapshotJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDashboardSnapshotJobResult



        /// <summary>
        /// Describes the result of an existing snapshot job that has finished running.
        /// 
        ///  
        /// <para>
        /// A finished snapshot job will return a <c>COMPLETED</c> or <c>FAILED</c> status when
        /// you poll the job with a <c>DescribeDashboardSnapshotJob</c> API call.
        /// </para>
        ///  
        /// <para>
        /// If the job has not finished running, this operation returns a message that says <c>Dashboard
        /// Snapshot Job with id &lt;SnapshotjobId&gt; has not reached a terminal state.</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardSnapshotJobResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboardSnapshotJobResult service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardSnapshotJobResult">REST API Reference for DescribeDashboardSnapshotJobResult Operation</seealso>
        Task<DescribeDashboardSnapshotJobResultResponse> DescribeDashboardSnapshotJobResultAsync(DescribeDashboardSnapshotJobResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDashboardsQAConfiguration



        /// <summary>
        /// Describes an existing dashboard QA configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardsQAConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboardsQAConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardsQAConfiguration">REST API Reference for DescribeDashboardsQAConfiguration Operation</seealso>
        Task<DescribeDashboardsQAConfigurationResponse> DescribeDashboardsQAConfigurationAsync(DescribeDashboardsQAConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataSet



        /// <summary>
        /// Describes a dataset. This operation doesn't support datasets that include uploaded
        /// files as a source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSet">REST API Reference for DescribeDataSet Operation</seealso>
        Task<DescribeDataSetResponse> DescribeDataSetAsync(DescribeDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataSetPermissions



        /// <summary>
        /// Describes the permissions on a dataset.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:region:aws-account-id:dataset/data-set-id</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSetPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetPermissions">REST API Reference for DescribeDataSetPermissions Operation</seealso>
        Task<DescribeDataSetPermissionsResponse> DescribeDataSetPermissionsAsync(DescribeDataSetPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataSetRefreshProperties



        /// <summary>
        /// Describes the refresh properties of a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetRefreshProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSetRefreshProperties service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetRefreshProperties">REST API Reference for DescribeDataSetRefreshProperties Operation</seealso>
        Task<DescribeDataSetRefreshPropertiesResponse> DescribeDataSetRefreshPropertiesAsync(DescribeDataSetRefreshPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataSource



        /// <summary>
        /// Describes a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        Task<DescribeDataSourceResponse> DescribeDataSourceAsync(DescribeDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataSourcePermissions



        /// <summary>
        /// Describes the resource permissions for a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSourcePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSourcePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSourcePermissions">REST API Reference for DescribeDataSourcePermissions Operation</seealso>
        Task<DescribeDataSourcePermissionsResponse> DescribeDataSourcePermissionsAsync(DescribeDataSourcePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDefaultQBusinessApplication



        /// <summary>
        /// Describes a Amazon Q Business application that is linked to an Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultQBusinessApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDefaultQBusinessApplication service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDefaultQBusinessApplication">REST API Reference for DescribeDefaultQBusinessApplication Operation</seealso>
        Task<DescribeDefaultQBusinessApplicationResponse> DescribeDefaultQBusinessApplicationAsync(DescribeDefaultQBusinessApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFolder



        /// <summary>
        /// Describes a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolder">REST API Reference for DescribeFolder Operation</seealso>
        Task<DescribeFolderResponse> DescribeFolderAsync(DescribeFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFolderPermissions



        /// <summary>
        /// Describes permissions for a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFolderPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolderPermissions">REST API Reference for DescribeFolderPermissions Operation</seealso>
        Task<DescribeFolderPermissionsResponse> DescribeFolderPermissionsAsync(DescribeFolderPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFolderResolvedPermissions



        /// <summary>
        /// Describes the folder resolved permissions. Permissions consists of both folder direct
        /// permissions and the inherited permissions from the ancestor folders.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderResolvedPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFolderResolvedPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolderResolvedPermissions">REST API Reference for DescribeFolderResolvedPermissions Operation</seealso>
        Task<DescribeFolderResolvedPermissionsResponse> DescribeFolderResolvedPermissionsAsync(DescribeFolderResolvedPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeGroup



        /// <summary>
        /// Returns an Amazon QuickSight group's description and Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeGroupMembership



        /// <summary>
        /// Use the <c>DescribeGroupMembership</c> operation to determine if a user is a member
        /// of the specified group. If the user exists and is a member of the specified group,
        /// an associated <c>GroupMember</c> object is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroupMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroupMembership">REST API Reference for DescribeGroupMembership Operation</seealso>
        Task<DescribeGroupMembershipResponse> DescribeGroupMembershipAsync(DescribeGroupMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIAMPolicyAssignment



        /// <summary>
        /// Describes an existing IAM policy assignment, as specified by the assignment name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIAMPolicyAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIAMPolicyAssignment">REST API Reference for DescribeIAMPolicyAssignment Operation</seealso>
        Task<DescribeIAMPolicyAssignmentResponse> DescribeIAMPolicyAssignmentAsync(DescribeIAMPolicyAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIngestion



        /// <summary>
        /// Describes a SPICE ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIngestion">REST API Reference for DescribeIngestion Operation</seealso>
        Task<DescribeIngestionResponse> DescribeIngestionAsync(DescribeIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIpRestriction



        /// <summary>
        /// Provides a summary and status of IP rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpRestriction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIpRestriction service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIpRestriction">REST API Reference for DescribeIpRestriction Operation</seealso>
        Task<DescribeIpRestrictionResponse> DescribeIpRestrictionAsync(DescribeIpRestrictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeKeyRegistration



        /// <summary>
        /// Describes all customer managed key registrations in a Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyRegistration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeKeyRegistration">REST API Reference for DescribeKeyRegistration Operation</seealso>
        Task<DescribeKeyRegistrationResponse> DescribeKeyRegistrationAsync(DescribeKeyRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNamespace



        /// <summary>
        /// Describes the current namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNamespace service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        Task<DescribeNamespaceResponse> DescribeNamespaceAsync(DescribeNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeQPersonalizationConfiguration



        /// <summary>
        /// Describes a personalization configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQPersonalizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQPersonalizationConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeQPersonalizationConfiguration">REST API Reference for DescribeQPersonalizationConfiguration Operation</seealso>
        Task<DescribeQPersonalizationConfigurationResponse> DescribeQPersonalizationConfigurationAsync(DescribeQPersonalizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeQuickSightQSearchConfiguration



        /// <summary>
        /// Describes the state of a Amazon QuickSight Q Search configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuickSightQSearchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQuickSightQSearchConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeQuickSightQSearchConfiguration">REST API Reference for DescribeQuickSightQSearchConfiguration Operation</seealso>
        Task<DescribeQuickSightQSearchConfigurationResponse> DescribeQuickSightQSearchConfigurationAsync(DescribeQuickSightQSearchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRefreshSchedule



        /// <summary>
        /// Provides a summary of a refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeRefreshSchedule">REST API Reference for DescribeRefreshSchedule Operation</seealso>
        Task<DescribeRefreshScheduleResponse> DescribeRefreshScheduleAsync(DescribeRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRoleCustomPermission



        /// <summary>
        /// Describes all custom permissions that are mapped to a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoleCustomPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRoleCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeRoleCustomPermission">REST API Reference for DescribeRoleCustomPermission Operation</seealso>
        Task<DescribeRoleCustomPermissionResponse> DescribeRoleCustomPermissionAsync(DescribeRoleCustomPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTemplate



        /// <summary>
        /// Describes a template's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplate">REST API Reference for DescribeTemplate Operation</seealso>
        Task<DescribeTemplateResponse> DescribeTemplateAsync(DescribeTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTemplateAlias



        /// <summary>
        /// Describes the template alias for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateAlias">REST API Reference for DescribeTemplateAlias Operation</seealso>
        Task<DescribeTemplateAliasResponse> DescribeTemplateAliasAsync(DescribeTemplateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTemplateDefinition



        /// <summary>
        /// Provides a detailed description of the definition of a template.
        /// 
        ///  <note> 
        /// <para>
        /// If you do not need to know details about the content of a template, for instance if
        /// you are trying to check the status of a recently created or updated template, use
        /// the <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeTemplate.html">
        /// <c>DescribeTemplate</c> </a> instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTemplateDefinition service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateDefinition">REST API Reference for DescribeTemplateDefinition Operation</seealso>
        Task<DescribeTemplateDefinitionResponse> DescribeTemplateDefinitionAsync(DescribeTemplateDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTemplatePermissions



        /// <summary>
        /// Describes read and write permissions on a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplatePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTemplatePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplatePermissions">REST API Reference for DescribeTemplatePermissions Operation</seealso>
        Task<DescribeTemplatePermissionsResponse> DescribeTemplatePermissionsAsync(DescribeTemplatePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTheme



        /// <summary>
        /// Describes a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTheme">REST API Reference for DescribeTheme Operation</seealso>
        Task<DescribeThemeResponse> DescribeThemeAsync(DescribeThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeThemeAlias



        /// <summary>
        /// Describes the alias for a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThemeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeThemeAlias">REST API Reference for DescribeThemeAlias Operation</seealso>
        Task<DescribeThemeAliasResponse> DescribeThemeAliasAsync(DescribeThemeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeThemePermissions



        /// <summary>
        /// Describes the read and write permissions for a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThemePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeThemePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeThemePermissions">REST API Reference for DescribeThemePermissions Operation</seealso>
        Task<DescribeThemePermissionsResponse> DescribeThemePermissionsAsync(DescribeThemePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTopic



        /// <summary>
        /// Describes a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopic">REST API Reference for DescribeTopic Operation</seealso>
        Task<DescribeTopicResponse> DescribeTopicAsync(DescribeTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTopicPermissions



        /// <summary>
        /// Describes the permissions of a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTopicPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicPermissions">REST API Reference for DescribeTopicPermissions Operation</seealso>
        Task<DescribeTopicPermissionsResponse> DescribeTopicPermissionsAsync(DescribeTopicPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTopicRefresh



        /// <summary>
        /// Describes the status of a topic refresh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicRefresh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTopicRefresh service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicRefresh">REST API Reference for DescribeTopicRefresh Operation</seealso>
        Task<DescribeTopicRefreshResponse> DescribeTopicRefreshAsync(DescribeTopicRefreshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTopicRefreshSchedule



        /// <summary>
        /// Deletes a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicRefreshSchedule">REST API Reference for DescribeTopicRefreshSchedule Operation</seealso>
        Task<DescribeTopicRefreshScheduleResponse> DescribeTopicRefreshScheduleAsync(DescribeTopicRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUser



        /// <summary>
        /// Returns information about a user, given the user name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVPCConnection



        /// <summary>
        /// Describes a VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVPCConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeVPCConnection">REST API Reference for DescribeVPCConnection Operation</seealso>
        Task<DescribeVPCConnectionResponse> DescribeVPCConnectionAsync(DescribeVPCConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateEmbedUrlForAnonymousUser



        /// <summary>
        /// Generates an embed URL that you can use to embed an Amazon QuickSight dashboard or
        /// visual in your website, without having to register any reader users. Before you use
        /// this action, make sure that you have configured the dashboards and permissions.
        /// 
        ///  
        /// <para>
        /// The following rules apply to the generated URL:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It contains a temporary bearer token. It is valid for 5 minutes after it is generated.
        /// Once redeemed within this period, it cannot be re-used again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The URL validity period should not be confused with the actual session lifetime that
        /// can be customized using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GenerateEmbedUrlForAnonymousUser.html#QS-GenerateEmbedUrlForAnonymousUser-request-SessionLifetimeInMinutes">SessionLifetimeInMinutes</a>
        /// </c> parameter. The resulting user session is valid for 15 minutes (minimum) to 10
        /// hours (maximum). The default session duration is 10 hours.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are charged only when the URL is used or there is interaction with Amazon QuickSight.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics.html">Embedded
        /// Analytics</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the high-level steps for embedding and for an interactive
        /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
        /// QuickSight Developer Portal</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForAnonymousUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateEmbedUrlForAnonymousUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForAnonymousUser">REST API Reference for GenerateEmbedUrlForAnonymousUser Operation</seealso>
        Task<GenerateEmbedUrlForAnonymousUserResponse> GenerateEmbedUrlForAnonymousUserAsync(GenerateEmbedUrlForAnonymousUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateEmbedUrlForRegisteredUser



        /// <summary>
        /// Generates an embed URL that you can use to embed an Amazon QuickSight experience in
        /// your website. This action can be used for any type of user registered in an Amazon
        /// QuickSight account. Before you use this action, make sure that you have configured
        /// the relevant Amazon QuickSight resource and permissions.
        /// 
        ///  
        /// <para>
        /// The following rules apply to the generated URL:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It contains a temporary bearer token. It is valid for 5 minutes after it is generated.
        /// Once redeemed within this period, it cannot be re-used again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The URL validity period should not be confused with the actual session lifetime that
        /// can be customized using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GenerateEmbedUrlForRegisteredUser.html#QS-GenerateEmbedUrlForRegisteredUser-request-SessionLifetimeInMinutes">SessionLifetimeInMinutes</a>
        /// </c> parameter.
        /// </para>
        ///  
        /// <para>
        /// The resulting user session is valid for 15 minutes (minimum) to 10 hours (maximum).
        /// The default session duration is 10 hours.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are charged only when the URL is used or there is interaction with Amazon QuickSight.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics.html">Embedded
        /// Analytics</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the high-level steps for embedding and for an interactive
        /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
        /// QuickSight Developer Portal</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForRegisteredUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateEmbedUrlForRegisteredUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForRegisteredUser">REST API Reference for GenerateEmbedUrlForRegisteredUser Operation</seealso>
        Task<GenerateEmbedUrlForRegisteredUserResponse> GenerateEmbedUrlForRegisteredUserAsync(GenerateEmbedUrlForRegisteredUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateEmbedUrlForRegisteredUserWithIdentity



        /// <summary>
        /// Generates an embed URL that you can use to embed an Amazon QuickSight experience in
        /// your website. This action can be used for any type of user that is registered in an
        /// Amazon QuickSight account that uses IAM Identity Center for authentication. This API
        /// requires <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-overview.html#types-identity-enhanced-iam-role-sessions">identity-enhanced
        /// IAM Role sessions</a> for the authenticated user that the API call is being made for.
        /// 
        ///  
        /// <para>
        /// This API uses <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation.html">trusted
        /// identity propagation</a> to ensure that an end user is authenticated and receives
        /// the embed URL that is specific to that user. The IAM Identity Center application that
        /// the user has logged into needs to have <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-using-customermanagedapps-specify-trusted-apps.html">trusted
        /// Identity Propagation enabled for Amazon QuickSight</a> with the scope value set to
        /// <c>quicksight:read</c>. Before you use this action, make sure that you have configured
        /// the relevant Amazon QuickSight resource and permissions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForRegisteredUserWithIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateEmbedUrlForRegisteredUserWithIdentity service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForRegisteredUserWithIdentity">REST API Reference for GenerateEmbedUrlForRegisteredUserWithIdentity Operation</seealso>
        Task<GenerateEmbedUrlForRegisteredUserWithIdentityResponse> GenerateEmbedUrlForRegisteredUserWithIdentityAsync(GenerateEmbedUrlForRegisteredUserWithIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDashboardEmbedUrl



        /// <summary>
        /// Generates a temporary session URL and authorization code(bearer token) that you can
        /// use to embed an Amazon QuickSight read-only dashboard in your website or application.
        /// Before you use this command, make sure that you have configured the dashboards and
        /// permissions. 
        /// 
        ///  
        /// <para>
        /// Currently, you can use <c>GetDashboardEmbedURL</c> only from the server, not from
        /// the user's browser. The following rules apply to the generated URL:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// They must be used together.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// They can be used one time only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// They are valid for 5 minutes after you run this command.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are charged only when the URL is used or there is interaction with Amazon QuickSight.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The resulting user session is valid for 15 minutes (default) up to 10 hours (maximum).
        /// You can use the optional <c>SessionLifetimeInMinutes</c> parameter to customize session
        /// duration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics-deprecated.html">Embedding
        /// Analytics Using GetDashboardEmbedUrl</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the high-level steps for embedding and for an interactive
        /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
        /// QuickSight Developer Portal</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDashboardEmbedUrl service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.DomainNotWhitelistedException">
        /// The domain specified isn't on the allow list. All domains for embedded dashboards
        /// must be added to the approved list by an Amazon QuickSight admin.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.IdentityTypeNotSupportedException">
        /// The identity type specified isn't supported. Supported identity types include <c>IAM</c>
        /// and <c>QUICKSIGHT</c>.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        Task<GetDashboardEmbedUrlResponse> GetDashboardEmbedUrlAsync(GetDashboardEmbedUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSessionEmbedUrl



        /// <summary>
        /// Generates a session URL and authorization code that you can use to embed the Amazon
        /// Amazon QuickSight console in your web server code. Use <c>GetSessionEmbedUrl</c> where
        /// you want to provide an authoring portal that allows users to create data sources,
        /// datasets, analyses, and dashboards. The users who access an embedded Amazon QuickSight
        /// console need belong to the author or admin security cohort. If you want to restrict
        /// permissions to some of these features, add a custom permissions profile to the user
        /// with the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateUser.html">UpdateUser</a>
        /// </c> API operation. Use <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_RegisterUser.html">RegisterUser</a>
        /// </c> API operation to add a new user with a custom permission profile attached. For
        /// more information, see the following sections in the <i>Amazon QuickSight User Guide</i>:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics.html">Embedding
        /// Analytics</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/quicksight/latest/user/customizing-permissions-to-the-quicksight-console.html">Customizing
        /// Access to the Amazon QuickSight Console</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionEmbedUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSessionEmbedUrl service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetSessionEmbedUrl">REST API Reference for GetSessionEmbedUrl Operation</seealso>
        Task<GetSessionEmbedUrlResponse> GetSessionEmbedUrlAsync(GetSessionEmbedUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAnalyses



        /// <summary>
        /// Lists Amazon QuickSight analyses that exist in the specified Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnalyses service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAnalyses">REST API Reference for ListAnalyses Operation</seealso>
        Task<ListAnalysesResponse> ListAnalysesAsync(ListAnalysesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssetBundleExportJobs



        /// <summary>
        /// Lists all asset bundle export jobs that have been taken place in the last 14 days.
        /// Jobs created more than 14 days ago are deleted forever and are not returned. If you
        /// are using the same job ID for multiple jobs, <c>ListAssetBundleExportJobs</c> only
        /// returns the most recent job that uses the repeated job ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetBundleExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetBundleExportJobs service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAssetBundleExportJobs">REST API Reference for ListAssetBundleExportJobs Operation</seealso>
        Task<ListAssetBundleExportJobsResponse> ListAssetBundleExportJobsAsync(ListAssetBundleExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssetBundleImportJobs



        /// <summary>
        /// Lists all asset bundle import jobs that have taken place in the last 14 days. Jobs
        /// created more than 14 days ago are deleted forever and are not returned. If you are
        /// using the same job ID for multiple jobs, <c>ListAssetBundleImportJobs</c> only returns
        /// the most recent job that uses the repeated job ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetBundleImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetBundleImportJobs service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAssetBundleImportJobs">REST API Reference for ListAssetBundleImportJobs Operation</seealso>
        Task<ListAssetBundleImportJobsResponse> ListAssetBundleImportJobsAsync(ListAssetBundleImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBrands



        /// <summary>
        /// Lists all brands in an Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrands service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBrands service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListBrands">REST API Reference for ListBrands Operation</seealso>
        Task<ListBrandsResponse> ListBrandsAsync(ListBrandsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCustomPermissions



        /// <summary>
        /// Returns a list of all the custom permissions profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListCustomPermissions">REST API Reference for ListCustomPermissions Operation</seealso>
        Task<ListCustomPermissionsResponse> ListCustomPermissionsAsync(ListCustomPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDashboards



        /// <summary>
        /// Lists dashboards in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDashboardVersions



        /// <summary>
        /// Lists all the versions of the dashboards in the Amazon QuickSight subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboardVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDashboardVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboardVersions">REST API Reference for ListDashboardVersions Operation</seealso>
        Task<ListDashboardVersionsResponse> ListDashboardVersionsAsync(ListDashboardVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSets



        /// <summary>
        /// Lists all of the datasets belonging to the current Amazon Web Services account in
        /// an Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:region:aws-account-id:dataset/*</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        Task<ListDataSetsResponse> ListDataSetsAsync(ListDataSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSources



        /// <summary>
        /// Lists data sources in current Amazon Web Services Region that belong to this Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFolderMembers



        /// <summary>
        /// List all assets (<c>DASHBOARD</c>, <c>ANALYSIS</c>, and <c>DATASET</c>) in a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFolderMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFolderMembers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFolderMembers">REST API Reference for ListFolderMembers Operation</seealso>
        Task<ListFolderMembersResponse> ListFolderMembersAsync(ListFolderMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFolders



        /// <summary>
        /// Lists all folders in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFolders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFolders service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFolders">REST API Reference for ListFolders Operation</seealso>
        Task<ListFoldersResponse> ListFoldersAsync(ListFoldersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFoldersForResource



        /// <summary>
        /// List all folders that a resource is a member of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFoldersForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFoldersForResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFoldersForResource">REST API Reference for ListFoldersForResource Operation</seealso>
        Task<ListFoldersForResourceResponse> ListFoldersForResourceAsync(ListFoldersForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGroupMemberships



        /// <summary>
        /// Lists member users in a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupMemberships service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        Task<ListGroupMembershipsResponse> ListGroupMembershipsAsync(ListGroupMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGroups



        /// <summary>
        /// Lists all user groups in Amazon QuickSight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIAMPolicyAssignments



        /// <summary>
        /// Lists the IAM policy assignments in the current Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIAMPolicyAssignments service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignments">REST API Reference for ListIAMPolicyAssignments Operation</seealso>
        Task<ListIAMPolicyAssignmentsResponse> ListIAMPolicyAssignmentsAsync(ListIAMPolicyAssignmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIAMPolicyAssignmentsForUser



        /// <summary>
        /// Lists all of the IAM policy assignments, including the Amazon Resource Names (ARNs),
        /// for the IAM policies assigned to the specified user and group, or groups that the
        /// user belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignmentsForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIAMPolicyAssignmentsForUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignmentsForUser">REST API Reference for ListIAMPolicyAssignmentsForUser Operation</seealso>
        Task<ListIAMPolicyAssignmentsForUserResponse> ListIAMPolicyAssignmentsForUserAsync(ListIAMPolicyAssignmentsForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIdentityPropagationConfigs



        /// <summary>
        /// Lists all services and authorized targets that the Amazon QuickSight IAM Identity
        /// Center application can access.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for Amazon QuickSight accounts that use IAM Identity
        /// Center.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPropagationConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentityPropagationConfigs service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIdentityPropagationConfigs">REST API Reference for ListIdentityPropagationConfigs Operation</seealso>
        Task<ListIdentityPropagationConfigsResponse> ListIdentityPropagationConfigsAsync(ListIdentityPropagationConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIngestions



        /// <summary>
        /// Lists the history of SPICE ingestions for a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIngestions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        Task<ListIngestionsResponse> ListIngestionsAsync(ListIngestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNamespaces



        /// <summary>
        /// Lists the namespaces for the specified Amazon Web Services account. This operation
        /// doesn't list deleted namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRefreshSchedules



        /// <summary>
        /// Lists the refresh schedules of a dataset. Each dataset can have up to 5 schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRefreshSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRefreshSchedules service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListRefreshSchedules">REST API Reference for ListRefreshSchedules Operation</seealso>
        Task<ListRefreshSchedulesResponse> ListRefreshSchedulesAsync(ListRefreshSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRoleMemberships



        /// <summary>
        /// Lists all groups that are associated with a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoleMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoleMemberships service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListRoleMemberships">REST API Reference for ListRoleMemberships Operation</seealso>
        Task<ListRoleMembershipsResponse> ListRoleMembershipsAsync(ListRoleMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags assigned to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTemplateAliases



        /// <summary>
        /// Lists all the aliases of a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateAliases service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateAliases">REST API Reference for ListTemplateAliases Operation</seealso>
        Task<ListTemplateAliasesResponse> ListTemplateAliasesAsync(ListTemplateAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTemplates



        /// <summary>
        /// Lists all the templates in the current Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTemplateVersions



        /// <summary>
        /// Lists all the versions of the templates in the current Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        Task<ListTemplateVersionsResponse> ListTemplateVersionsAsync(ListTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListThemeAliases



        /// <summary>
        /// Lists all the aliases of a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemeAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThemeAliases service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemeAliases">REST API Reference for ListThemeAliases Operation</seealso>
        Task<ListThemeAliasesResponse> ListThemeAliasesAsync(ListThemeAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListThemes



        /// <summary>
        /// Lists all the themes in the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThemes service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemes">REST API Reference for ListThemes Operation</seealso>
        Task<ListThemesResponse> ListThemesAsync(ListThemesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListThemeVersions



        /// <summary>
        /// Lists all the versions of the themes in the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemeVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThemeVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemeVersions">REST API Reference for ListThemeVersions Operation</seealso>
        Task<ListThemeVersionsResponse> ListThemeVersionsAsync(ListThemeVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTopicRefreshSchedules



        /// <summary>
        /// Lists all of the refresh schedules for a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRefreshSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopicRefreshSchedules service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopicRefreshSchedules">REST API Reference for ListTopicRefreshSchedules Operation</seealso>
        Task<ListTopicRefreshSchedulesResponse> ListTopicRefreshSchedulesAsync(ListTopicRefreshSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTopicReviewedAnswers



        /// <summary>
        /// Lists all reviewed answers for a Q Topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicReviewedAnswers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopicReviewedAnswers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopicReviewedAnswers">REST API Reference for ListTopicReviewedAnswers Operation</seealso>
        Task<ListTopicReviewedAnswersResponse> ListTopicReviewedAnswersAsync(ListTopicReviewedAnswersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTopics



        /// <summary>
        /// Lists all of the topics within an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopics">REST API Reference for ListTopics Operation</seealso>
        Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUserGroups



        /// <summary>
        /// Lists the Amazon QuickSight groups that an Amazon QuickSight user is a member of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        Task<ListUserGroupsResponse> ListUserGroupsAsync(ListUserGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUsers



        /// <summary>
        /// Returns a list of all of the Amazon QuickSight users belonging to this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVPCConnections



        /// <summary>
        /// Lists all of the VPC connections in the current set Amazon Web Services Region of
        /// an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVPCConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVPCConnections service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListVPCConnections">REST API Reference for ListVPCConnections Operation</seealso>
        Task<ListVPCConnectionsResponse> ListVPCConnectionsAsync(ListVPCConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PredictQAResults



        /// <summary>
        /// Predicts existing visuals or generates new visuals to answer a given query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PredictQAResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PredictQAResults service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/PredictQAResults">REST API Reference for PredictQAResults Operation</seealso>
        Task<PredictQAResultsResponse> PredictQAResultsAsync(PredictQAResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutDataSetRefreshProperties



        /// <summary>
        /// Creates or updates the dataset refresh properties for the dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataSetRefreshProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDataSetRefreshProperties service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/PutDataSetRefreshProperties">REST API Reference for PutDataSetRefreshProperties Operation</seealso>
        Task<PutDataSetRefreshPropertiesResponse> PutDataSetRefreshPropertiesAsync(PutDataSetRefreshPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterUser



        /// <summary>
        /// Creates an Amazon QuickSight user whose identity is associated with the Identity and
        /// Access Management (IAM) identity or role specified in the request. When you register
        /// a new user from the Amazon QuickSight API, Amazon QuickSight generates a registration
        /// URL. The user accesses this registration URL to create their account. Amazon QuickSight
        /// doesn't send a registration email to users who are registered from the Amazon QuickSight
        /// API. If you want new users to receive a registration email, then add those users in
        /// the Amazon QuickSight console. For more information on registering a new user in the
        /// Amazon QuickSight console, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/managing-users.html#inviting-users">
        /// Inviting users to access Amazon QuickSight</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreAnalysis



        /// <summary>
        /// Restores an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RestoreAnalysis">REST API Reference for RestoreAnalysis Operation</seealso>
        Task<RestoreAnalysisResponse> RestoreAnalysisAsync(RestoreAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchAnalyses



        /// <summary>
        /// Searches for analyses that belong to the user specified in the filter.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAnalyses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchAnalyses service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchAnalyses">REST API Reference for SearchAnalyses Operation</seealso>
        Task<SearchAnalysesResponse> SearchAnalysesAsync(SearchAnalysesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchDashboards



        /// <summary>
        /// Searches for dashboards that belong to a user. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDashboards service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDashboards">REST API Reference for SearchDashboards Operation</seealso>
        Task<SearchDashboardsResponse> SearchDashboardsAsync(SearchDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchDataSets



        /// <summary>
        /// Use the <c>SearchDataSets</c> operation to search for datasets that belong to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDataSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDataSets service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDataSets">REST API Reference for SearchDataSets Operation</seealso>
        Task<SearchDataSetsResponse> SearchDataSetsAsync(SearchDataSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchDataSources



        /// <summary>
        /// Use the <c>SearchDataSources</c> operation to search for data sources that belong
        /// to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDataSources service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDataSources">REST API Reference for SearchDataSources Operation</seealso>
        Task<SearchDataSourcesResponse> SearchDataSourcesAsync(SearchDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchFolders



        /// <summary>
        /// Searches the subfolders in a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFolders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchFolders service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchFolders">REST API Reference for SearchFolders Operation</seealso>
        Task<SearchFoldersResponse> SearchFoldersAsync(SearchFoldersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchGroups



        /// <summary>
        /// Use the <c>SearchGroups</c> operation to search groups in a specified Amazon QuickSight
        /// namespace using the supplied filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchGroups">REST API Reference for SearchGroups Operation</seealso>
        Task<SearchGroupsResponse> SearchGroupsAsync(SearchGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchTopics



        /// <summary>
        /// Searches for any Q topic that exists in an Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTopics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTopics service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchTopics">REST API Reference for SearchTopics Operation</seealso>
        Task<SearchTopicsResponse> SearchTopicsAsync(SearchTopicsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartAssetBundleExportJob



        /// <summary>
        /// Starts an Asset Bundle export job.
        /// 
        ///  
        /// <para>
        /// An Asset Bundle export job exports specified Amazon QuickSight assets. You can also
        /// choose to export any asset dependencies in the same job. Export jobs run asynchronously
        /// and can be polled with a <c>DescribeAssetBundleExportJob</c> API call. When a job
        /// is successfully completed, a download URL that contains the exported assets is returned.
        /// The URL is valid for 5 minutes and can be refreshed with a <c>DescribeAssetBundleExportJob</c>
        /// API call. Each Amazon QuickSight account can run up to 5 export jobs concurrently.
        /// </para>
        ///  
        /// <para>
        /// The API caller must have the necessary permissions in their IAM role to access each
        /// resource before the resources can be exported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssetBundleExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAssetBundleExportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartAssetBundleExportJob">REST API Reference for StartAssetBundleExportJob Operation</seealso>
        Task<StartAssetBundleExportJobResponse> StartAssetBundleExportJobAsync(StartAssetBundleExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartAssetBundleImportJob



        /// <summary>
        /// Starts an Asset Bundle import job.
        /// 
        ///  
        /// <para>
        /// An Asset Bundle import job imports specified Amazon QuickSight assets into an Amazon
        /// QuickSight account. You can also choose to import a naming prefix and specified configuration
        /// overrides. The assets that are contained in the bundle file that you provide are used
        /// to create or update a new or existing asset in your Amazon QuickSight account. Each
        /// Amazon QuickSight account can run up to 5 import jobs concurrently.
        /// </para>
        ///  
        /// <para>
        /// The API caller must have the necessary <c>"create"</c>, <c>"describe"</c>, and <c>"update"</c>
        /// permissions in their IAM role to access each resource type that is contained in the
        /// bundle file before the resources can be imported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssetBundleImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAssetBundleImportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartAssetBundleImportJob">REST API Reference for StartAssetBundleImportJob Operation</seealso>
        Task<StartAssetBundleImportJobResponse> StartAssetBundleImportJobAsync(StartAssetBundleImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDashboardSnapshotJob



        /// <summary>
        /// Starts an asynchronous job that generates a snapshot of a dashboard's output. You
        /// can request one or several of the following format configurations in each API call.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// 1 Paginated PDF
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1 Excel workbook that includes up to 5 table or pivot table visuals
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 5 CSVs from table or pivot table visuals
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The status of a submitted job can be polled with the <c>DescribeDashboardSnapshotJob</c>
        /// API. When you call the <c>DescribeDashboardSnapshotJob</c> API, check the <c>JobStatus</c>
        /// field in the response. Once the job reaches a <c>COMPLETED</c> or <c>FAILED</c> status,
        /// use the <c>DescribeDashboardSnapshotJobResult</c> API to obtain the URLs for the generated
        /// files. If the job fails, the <c>DescribeDashboardSnapshotJobResult</c> API returns
        /// detailed information about the error that occurred.
        /// </para>
        ///  
        /// <para>
        ///  <b>StartDashboardSnapshotJob API throttling</b> 
        /// </para>
        ///  
        /// <para>
        /// Amazon QuickSight utilizes API throttling to create a more consistent user experience
        /// within a time span for customers when they call the <c>StartDashboardSnapshotJob</c>.
        /// By default, 12 jobs can run simlutaneously in one Amazon Web Services account and
        /// users can submit up 10 API requests per second before an account is throttled. If
        /// an overwhelming number of API requests are made by the same user in a short period
        /// of time, Amazon QuickSight throttles the API calls to maintin an optimal experience
        /// and reliability for all Amazon QuickSight users.
        /// </para>
        ///  
        /// <para>
        ///  <b>Common throttling scenarios</b> 
        /// </para>
        ///  
        /// <para>
        /// The following list provides information about the most commin throttling scenarios
        /// that can occur.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>A large number of <c>SnapshotExport</c> API jobs are running simultaneously on
        /// an Amazon Web Services account.</b> When a new <c>StartDashboardSnapshotJob</c> is
        /// created and there are already 12 jobs with the <c>RUNNING</c> status, the new job
        /// request fails and returns a <c>LimitExceededException</c> error. Wait for a current
        /// job to comlpete before you resubmit the new job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>A large number of API requests are submitted on an Amazon Web Services account.</b>
        /// When a user makes more than 10 API calls to the Amazon QuickSight API in one second,
        /// a <c>ThrottlingException</c> is returned.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If your use case requires a higher throttling limit, contact your account admin or
        /// <a href="http://aws.amazon.com/contact-us/">Amazon Web ServicesSupport</a> to explore
        /// options to tailor a more optimal expereince for your account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Best practices to handle throttling</b> 
        /// </para>
        ///  
        /// <para>
        /// If your use case projects high levels of API traffic, try to reduce the degree of
        /// frequency and parallelism of API calls as much as you can to avoid throttling. You
        /// can also perform a timing test to calculate an estimate for the total processing time
        /// of your projected load that stays within the throttling limits of the Amazon QuickSight
        /// APIs. For example, if your projected traffic is 100 snapshot jobs before 12:00 PM
        /// per day, start 12 jobs in parallel and measure the amount of time it takes to proccess
        /// all 12 jobs. Once you obtain the result, multiply the duration by 9, for example <c>(12
        /// minutes * 9 = 108 minutes)</c>. Use the new result to determine the latest time at
        /// which the jobs need to be started to meet your target deadline.
        /// </para>
        ///  
        /// <para>
        /// The time that it takes to process a job can be impacted by the following factors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The dataset type (Direct Query or SPICE).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The size of the dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The complexity of the calculated fields that are used in the dashboard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of visuals that are on a sheet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The types of visuals that are on the sheet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of formats and snapshots that are requested in the job configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The size of the generated snapshots.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDashboardSnapshotJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDashboardSnapshotJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartDashboardSnapshotJob">REST API Reference for StartDashboardSnapshotJob Operation</seealso>
        Task<StartDashboardSnapshotJobResponse> StartDashboardSnapshotJobAsync(StartDashboardSnapshotJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDashboardSnapshotJobSchedule



        /// <summary>
        /// Starts an asynchronous job that runs an existing dashboard schedule and sends the
        /// dashboard snapshot through email. 
        /// 
        ///  
        /// <para>
        /// Only one job can run simultaneously in a given schedule. Repeated requests are skipped
        /// with a <c>202</c> HTTP status code.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sending-reports.html">Scheduling
        /// and sending Amazon QuickSight reports by email</a> and <a href="https://docs.aws.amazon.com/quicksight/latest/user/email-reports-from-dashboard.html">Configuring
        /// email report settings for a Amazon QuickSight dashboard</a> in the <i>Amazon QuickSight
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDashboardSnapshotJobSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDashboardSnapshotJobSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartDashboardSnapshotJobSchedule">REST API Reference for StartDashboardSnapshotJobSchedule Operation</seealso>
        Task<StartDashboardSnapshotJobScheduleResponse> StartDashboardSnapshotJobScheduleAsync(StartDashboardSnapshotJobScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Amazon QuickSight resource.
        /// 
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values. You can use the <c>TagResource</c> operation with a resource
        /// that already has tags. If you specify a new tag key for the resource, this tag is
        /// appended to the list of tags associated with the resource. If you specify a tag key
        /// that is already associated with the resource, the new tag value that you specify replaces
        /// the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource. Amazon QuickSight supports tagging
        /// on data set, data source, dashboard, template, topic, and user. 
        /// </para>
        ///  
        /// <para>
        /// Tagging for Amazon QuickSight works in a similar way to tagging for other Amazon Web
        /// Services services, except for the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Tags are used to track costs for users in Amazon QuickSight. You can't tag other resources
        /// that Amazon QuickSight costs are based on, such as storage capacoty (SPICE), session
        /// usage, alert consumption, or reporting units.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon QuickSight doesn't currently support the tag editor for Resource Groups.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccountCustomization



        /// <summary>
        /// Updates Amazon QuickSight customizations for the current Amazon Web Services Region.
        /// Currently, the only customization that you can use is a theme.
        /// 
        ///  
        /// <para>
        /// You can use customizations for your Amazon Web Services account or, if you specify
        /// a namespace, for a Amazon QuickSight namespace instead. Customizations that apply
        /// to a namespace override customizations that apply to an Amazon Web Services account.
        /// To find out which customizations apply, use the <c>DescribeAccountCustomization</c>
        /// API operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountCustomization">REST API Reference for UpdateAccountCustomization Operation</seealso>
        Task<UpdateAccountCustomizationResponse> UpdateAccountCustomizationAsync(UpdateAccountCustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccountSettings



        /// <summary>
        /// Updates the Amazon QuickSight settings in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        Task<UpdateAccountSettingsResponse> UpdateAccountSettingsAsync(UpdateAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAnalysis



        /// <summary>
        /// Updates an analysis in Amazon QuickSight
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAnalysis">REST API Reference for UpdateAnalysis Operation</seealso>
        Task<UpdateAnalysisResponse> UpdateAnalysisAsync(UpdateAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAnalysisPermissions



        /// <summary>
        /// Updates the read and write permissions for an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysisPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnalysisPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAnalysisPermissions">REST API Reference for UpdateAnalysisPermissions Operation</seealso>
        Task<UpdateAnalysisPermissionsResponse> UpdateAnalysisPermissionsAsync(UpdateAnalysisPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplicationWithTokenExchangeGrant



        /// <summary>
        /// Updates an Amazon QuickSight application with a token exchange grant. This operation
        /// only supports Amazon QuickSight applications that are registered with IAM Identity
        /// Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationWithTokenExchangeGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplicationWithTokenExchangeGrant service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateApplicationWithTokenExchangeGrant">REST API Reference for UpdateApplicationWithTokenExchangeGrant Operation</seealso>
        Task<UpdateApplicationWithTokenExchangeGrantResponse> UpdateApplicationWithTokenExchangeGrantAsync(UpdateApplicationWithTokenExchangeGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBrand



        /// <summary>
        /// Updates a brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrand">REST API Reference for UpdateBrand Operation</seealso>
        Task<UpdateBrandResponse> UpdateBrandAsync(UpdateBrandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBrandAssignment



        /// <summary>
        /// Updates a brand assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrandAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrandAssignment">REST API Reference for UpdateBrandAssignment Operation</seealso>
        Task<UpdateBrandAssignmentResponse> UpdateBrandAssignmentAsync(UpdateBrandAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBrandPublishedVersion



        /// <summary>
        /// Updates the published version of a brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandPublishedVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrandPublishedVersion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrandPublishedVersion">REST API Reference for UpdateBrandPublishedVersion Operation</seealso>
        Task<UpdateBrandPublishedVersionResponse> UpdateBrandPublishedVersionAsync(UpdateBrandPublishedVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCustomPermissions



        /// <summary>
        /// Updates a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateCustomPermissions">REST API Reference for UpdateCustomPermissions Operation</seealso>
        Task<UpdateCustomPermissionsResponse> UpdateCustomPermissionsAsync(UpdateCustomPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDashboard



        /// <summary>
        /// Updates a dashboard in an Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// Updating a Dashboard creates a new dashboard version but does not immediately publish
        /// the new version. You can update the published version of a dashboard by using the
        /// <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateDashboardPublishedVersion.html">UpdateDashboardPublishedVersion</a>
        /// </c> API operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        Task<UpdateDashboardResponse> UpdateDashboardAsync(UpdateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDashboardLinks



        /// <summary>
        /// Updates the linked analyses on a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboardLinks service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardLinks">REST API Reference for UpdateDashboardLinks Operation</seealso>
        Task<UpdateDashboardLinksResponse> UpdateDashboardLinksAsync(UpdateDashboardLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDashboardPermissions



        /// <summary>
        /// Updates read and write permissions on a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboardPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPermissions">REST API Reference for UpdateDashboardPermissions Operation</seealso>
        Task<UpdateDashboardPermissionsResponse> UpdateDashboardPermissionsAsync(UpdateDashboardPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDashboardPublishedVersion



        /// <summary>
        /// Updates the published version of a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPublishedVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboardPublishedVersion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPublishedVersion">REST API Reference for UpdateDashboardPublishedVersion Operation</seealso>
        Task<UpdateDashboardPublishedVersionResponse> UpdateDashboardPublishedVersionAsync(UpdateDashboardPublishedVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDashboardsQAConfiguration



        /// <summary>
        /// Updates a Dashboard QA configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardsQAConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboardsQAConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardsQAConfiguration">REST API Reference for UpdateDashboardsQAConfiguration Operation</seealso>
        Task<UpdateDashboardsQAConfigurationResponse> UpdateDashboardsQAConfigurationAsync(UpdateDashboardsQAConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataSet



        /// <summary>
        /// Updates a dataset. This operation doesn't support datasets that include uploaded files
        /// as a source. Partial updates are not supported by this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        Task<UpdateDataSetResponse> UpdateDataSetAsync(UpdateDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataSetPermissions



        /// <summary>
        /// Updates the permissions on a dataset.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:region:aws-account-id:dataset/data-set-id</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSetPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSetPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSetPermissions">REST API Reference for UpdateDataSetPermissions Operation</seealso>
        Task<UpdateDataSetPermissionsResponse> UpdateDataSetPermissionsAsync(UpdateDataSetPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataSource



        /// <summary>
        /// Updates a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.CustomerManagedKeyUnavailableException">
        /// The customer managed key that is registered to your Amazon QuickSight account is unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataSourcePermissions



        /// <summary>
        /// Updates the permissions to a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSourcePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSourcePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSourcePermissions">REST API Reference for UpdateDataSourcePermissions Operation</seealso>
        Task<UpdateDataSourcePermissionsResponse> UpdateDataSourcePermissionsAsync(UpdateDataSourcePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDefaultQBusinessApplication



        /// <summary>
        /// Updates a Amazon Q Business application that is linked to a Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultQBusinessApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDefaultQBusinessApplication service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDefaultQBusinessApplication">REST API Reference for UpdateDefaultQBusinessApplication Operation</seealso>
        Task<UpdateDefaultQBusinessApplicationResponse> UpdateDefaultQBusinessApplicationAsync(UpdateDefaultQBusinessApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFolder



        /// <summary>
        /// Updates the name of a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFolder">REST API Reference for UpdateFolder Operation</seealso>
        Task<UpdateFolderResponse> UpdateFolderAsync(UpdateFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFolderPermissions



        /// <summary>
        /// Updates permissions of a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolderPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFolderPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFolderPermissions">REST API Reference for UpdateFolderPermissions Operation</seealso>
        Task<UpdateFolderPermissionsResponse> UpdateFolderPermissionsAsync(UpdateFolderPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGroup



        /// <summary>
        /// Changes a group description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIAMPolicyAssignment



        /// <summary>
        /// Updates an existing IAM policy assignment. This operation updates only the optional
        /// parameter or parameters that are specified in the request. This overwrites all of
        /// the users included in <c>Identities</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIAMPolicyAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIAMPolicyAssignment">REST API Reference for UpdateIAMPolicyAssignment Operation</seealso>
        Task<UpdateIAMPolicyAssignmentResponse> UpdateIAMPolicyAssignmentAsync(UpdateIAMPolicyAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIdentityPropagationConfig



        /// <summary>
        /// Adds or updates services and authorized targets to configure what the Amazon QuickSight
        /// IAM Identity Center application can access.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for Amazon QuickSight accounts using IAM Identity
        /// Center
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityPropagationConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdentityPropagationConfig service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIdentityPropagationConfig">REST API Reference for UpdateIdentityPropagationConfig Operation</seealso>
        Task<UpdateIdentityPropagationConfigResponse> UpdateIdentityPropagationConfigAsync(UpdateIdentityPropagationConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIpRestriction



        /// <summary>
        /// Updates the content and status of IP rules. Traffic from a source is allowed when
        /// the source satisfies either the <c>IpRestrictionRule</c>, <c>VpcIdRestrictionRule</c>,
        /// or <c>VpcEndpointIdRestrictionRule</c>. To use this operation, you must provide the
        /// entire map of rules. You can use the <c>DescribeIpRestriction</c> operation to get
        /// the current rule map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIpRestriction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIpRestriction service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIpRestriction">REST API Reference for UpdateIpRestriction Operation</seealso>
        Task<UpdateIpRestrictionResponse> UpdateIpRestrictionAsync(UpdateIpRestrictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateKeyRegistration



        /// <summary>
        /// Updates a customer managed key in a Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyRegistration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateKeyRegistration">REST API Reference for UpdateKeyRegistration Operation</seealso>
        Task<UpdateKeyRegistrationResponse> UpdateKeyRegistrationAsync(UpdateKeyRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePublicSharingSettings



        /// <summary>
        /// Use the <c>UpdatePublicSharingSettings</c> operation to turn on or turn off the public
        /// sharing settings of an Amazon QuickSight dashboard.
        /// 
        ///  
        /// <para>
        /// To use this operation, turn on session capacity pricing for your Amazon QuickSight
        /// account.
        /// </para>
        ///  
        /// <para>
        /// Before you can turn on public sharing on your account, make sure to give public sharing
        /// permissions to an administrative user in the Identity and Access Management (IAM)
        /// console. For more information on using IAM with Amazon QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/security_iam_service-with-iam.html">Using
        /// Amazon QuickSight with IAM</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicSharingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePublicSharingSettings service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdatePublicSharingSettings">REST API Reference for UpdatePublicSharingSettings Operation</seealso>
        Task<UpdatePublicSharingSettingsResponse> UpdatePublicSharingSettingsAsync(UpdatePublicSharingSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQPersonalizationConfiguration



        /// <summary>
        /// Updates a personalization configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQPersonalizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQPersonalizationConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateQPersonalizationConfiguration">REST API Reference for UpdateQPersonalizationConfiguration Operation</seealso>
        Task<UpdateQPersonalizationConfigurationResponse> UpdateQPersonalizationConfigurationAsync(UpdateQPersonalizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQuickSightQSearchConfiguration



        /// <summary>
        /// Updates the state of a Amazon QuickSight Q Search configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickSightQSearchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQuickSightQSearchConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateQuickSightQSearchConfiguration">REST API Reference for UpdateQuickSightQSearchConfiguration Operation</seealso>
        Task<UpdateQuickSightQSearchConfigurationResponse> UpdateQuickSightQSearchConfigurationAsync(UpdateQuickSightQSearchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRefreshSchedule



        /// <summary>
        /// Updates a refresh schedule for a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateRefreshSchedule">REST API Reference for UpdateRefreshSchedule Operation</seealso>
        Task<UpdateRefreshScheduleResponse> UpdateRefreshScheduleAsync(UpdateRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRoleCustomPermission



        /// <summary>
        /// Updates the custom permissions that are associated with a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleCustomPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoleCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateRoleCustomPermission">REST API Reference for UpdateRoleCustomPermission Operation</seealso>
        Task<UpdateRoleCustomPermissionResponse> UpdateRoleCustomPermissionAsync(UpdateRoleCustomPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSPICECapacityConfiguration



        /// <summary>
        /// Updates the SPICE capacity configuration for a Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSPICECapacityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSPICECapacityConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateSPICECapacityConfiguration">REST API Reference for UpdateSPICECapacityConfiguration Operation</seealso>
        Task<UpdateSPICECapacityConfigurationResponse> UpdateSPICECapacityConfigurationAsync(UpdateSPICECapacityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTemplate



        /// <summary>
        /// Updates a template from an existing Amazon QuickSight analysis or another template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTemplateAlias



        /// <summary>
        /// Updates the template alias of a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplateAlias">REST API Reference for UpdateTemplateAlias Operation</seealso>
        Task<UpdateTemplateAliasResponse> UpdateTemplateAliasAsync(UpdateTemplateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTemplatePermissions



        /// <summary>
        /// Updates the resource permissions for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplatePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplatePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplatePermissions">REST API Reference for UpdateTemplatePermissions Operation</seealso>
        Task<UpdateTemplatePermissionsResponse> UpdateTemplatePermissionsAsync(UpdateTemplatePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTheme



        /// <summary>
        /// Updates a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTheme">REST API Reference for UpdateTheme Operation</seealso>
        Task<UpdateThemeResponse> UpdateThemeAsync(UpdateThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateThemeAlias



        /// <summary>
        /// Updates an alias of a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThemeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateThemeAlias">REST API Reference for UpdateThemeAlias Operation</seealso>
        Task<UpdateThemeAliasResponse> UpdateThemeAliasAsync(UpdateThemeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateThemePermissions



        /// <summary>
        /// Updates the resource permissions for a theme. Permissions apply to the action to grant
        /// or revoke permissions on, for example <c>"quicksight:DescribeTheme"</c>.
        /// 
        ///  
        /// <para>
        /// Theme permissions apply in groupings. Valid groupings include the following for the
        /// three levels of permissions, which are user, owner, or no permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// User
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeAliases"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeVersions"</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Owner
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeAliases"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeVersions"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DeleteTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:UpdateTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:CreateThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DeleteThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:UpdateThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:UpdateThemePermissions"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeThemePermissions"</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// To specify no permissions, omit the permissions list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThemePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThemePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateThemePermissions">REST API Reference for UpdateThemePermissions Operation</seealso>
        Task<UpdateThemePermissionsResponse> UpdateThemePermissionsAsync(UpdateThemePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTopic



        /// <summary>
        /// Updates a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopic">REST API Reference for UpdateTopic Operation</seealso>
        Task<UpdateTopicResponse> UpdateTopicAsync(UpdateTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTopicPermissions



        /// <summary>
        /// Updates the permissions of a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopicPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTopicPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopicPermissions">REST API Reference for UpdateTopicPermissions Operation</seealso>
        Task<UpdateTopicPermissionsResponse> UpdateTopicPermissionsAsync(UpdateTopicPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTopicRefreshSchedule



        /// <summary>
        /// Updates a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopicRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopicRefreshSchedule">REST API Reference for UpdateTopicRefreshSchedule Operation</seealso>
        Task<UpdateTopicRefreshScheduleResponse> UpdateTopicRefreshScheduleAsync(UpdateTopicRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUser



        /// <summary>
        /// Updates an Amazon QuickSight user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserCustomPermission



        /// <summary>
        /// Updates a custom permissions profile for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserCustomPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUserCustomPermission">REST API Reference for UpdateUserCustomPermission Operation</seealso>
        Task<UpdateUserCustomPermissionResponse> UpdateUserCustomPermissionAsync(UpdateUserCustomPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVPCConnection



        /// <summary>
        /// Updates a VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVPCConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateVPCConnection">REST API Reference for UpdateVPCConnection Operation</seealso>
        Task<UpdateVPCConnectionResponse> UpdateVPCConnectionAsync(UpdateVPCConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}