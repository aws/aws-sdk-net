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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeStarNotifications.Model;

#pragma warning disable CS1570
namespace Amazon.CodeStarNotifications
{
    /// <summary>
    /// <para>Interface for accessing CodeStarNotifications</para>
    ///
    /// This AWS CodeStar Notifications API Reference provides descriptions and usage examples
    /// of the operations and data types for the AWS CodeStar Notifications API. You can use
    /// the AWS CodeStar Notifications API to work with the following objects:
    /// 
    ///  
    /// <para>
    /// Notification rules, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateNotificationRule</a>, which creates a notification rule for a resource in
    /// your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteNotificationRule</a>, which deletes a notification rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeNotificationRule</a>, which provides information about a notification
    /// rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListNotificationRules</a>, which lists the notification rules associated with
    /// your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateNotificationRule</a>, which changes the name, events, or targets associated
    /// with a notification rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Subscribe</a>, which subscribes a target to a notification rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Unsubscribe</a>, which removes a target from a notification rule. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Targets, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteTarget</a>, which removes a notification rule target from a notification
    /// rule. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListTargets</a>, which lists the targets associated with a notification rule.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Events, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListEventTypes</a>, which lists the event types you can include in a notification
    /// rule. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Tags, by calling the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a>, which lists the tags already associated with a notification
    /// rule in your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a>, which associates a tag you provide with a notification rule in
    /// your account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a>, which removes a tag from a notification rule in your account.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For information about how to use AWS CodeStar Notifications, see the <a href="https://docs.aws.amazon.com/dtconsole/latest/userguide/what-is-dtconsole.html">Amazon
    /// Web Services Developer Tools Console User Guide</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeStarNotifications : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeStarNotificationsPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateNotificationRule



        /// <summary>
        /// Creates a notification rule for a resource. The rule specifies the events you want
        /// notifications about and the targets (such as Chatbot topics or Chatbot clients configured
        /// for Slack) where you want to receive them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotificationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.AccessDeniedException">
        /// AWS CodeStar Notifications can't create the notification rule because you do not have
        /// sufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceAlreadyExistsException">
        /// A resource with the same name or ID already exists. Notification rule names must be
        /// unique in your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/CreateNotificationRule">REST API Reference for CreateNotificationRule Operation</seealso>
        Task<CreateNotificationRuleResponse> CreateNotificationRuleAsync(CreateNotificationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNotificationRule



        /// <summary>
        /// Deletes a notification rule for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteNotificationRule">REST API Reference for DeleteNotificationRule Operation</seealso>
        Task<DeleteNotificationRuleResponse> DeleteNotificationRuleAsync(DeleteNotificationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTarget



        /// <summary>
        /// Deletes a specified target for notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTarget service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DeleteTarget">REST API Reference for DeleteTarget Operation</seealso>
        Task<DeleteTargetResponse> DeleteTargetAsync(DeleteTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNotificationRule



        /// <summary>
        /// Returns information about a specified notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/DescribeNotificationRule">REST API Reference for DescribeNotificationRule Operation</seealso>
        Task<DescribeNotificationRuleResponse> DescribeNotificationRuleAsync(DescribeNotificationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEventTypes



        /// <summary>
        /// Returns information about the event types available for configuring notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventTypes service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.InvalidNextTokenException">
        /// The value for the enumeration token used in the request to return the next batch of
        /// the results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListEventTypes">REST API Reference for ListEventTypes Operation</seealso>
        Task<ListEventTypesResponse> ListEventTypesAsync(ListEventTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotificationRules



        /// <summary>
        /// Returns a list of the notification rules for an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotificationRules service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.InvalidNextTokenException">
        /// The value for the enumeration token used in the request to return the next batch of
        /// the results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListNotificationRules">REST API Reference for ListNotificationRules Operation</seealso>
        Task<ListNotificationRulesResponse> ListNotificationRulesAsync(ListNotificationRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of the tags associated with a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTargets



        /// <summary>
        /// Returns a list of the notification rule targets for an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargets service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.InvalidNextTokenException">
        /// The value for the enumeration token used in the request to return the next batch of
        /// the results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/ListTargets">REST API Reference for ListTargets Operation</seealso>
        Task<ListTargetsResponse> ListTargetsAsync(ListTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Subscribe



        /// <summary>
        /// Creates an association between a notification rule and an Chatbot topic or Chatbot
        /// client so that the associated target can receive notifications when the events described
        /// in the rule are triggered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Subscribe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Subscribe">REST API Reference for Subscribe Operation</seealso>
        Task<SubscribeResponse> SubscribeAsync(SubscribeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Associates a set of provided tags with a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Unsubscribe



        /// <summary>
        /// Removes an association between a notification rule and an Chatbot topic so that subscribers
        /// to that topic stop receiving notifications when the events described in the rule are
        /// triggered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Unsubscribe service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the association between one or more provided tags and a notification rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConcurrentModificationException">
        /// AWS CodeStar Notifications can't complete the request because the resource is being
        /// modified by another process. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.LimitExceededException">
        /// One of the AWS CodeStar Notifications limits has been exceeded. Limits apply to accounts,
        /// notification rules, notifications, resources, and targets. For more information, see
        /// Limits.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotificationRule



        /// <summary>
        /// Updates a notification rule for a resource. You can change the events that trigger
        /// the notification rule, the status of the rule, and the targets that receive the notifications.
        /// 
        ///  <note> 
        /// <para>
        /// To add or remove tags for a notification rule, you must use <a>TagResource</a> and
        /// <a>UntagResource</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotificationRule service method, as returned by CodeStarNotifications.</returns>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ConfigurationException">
        /// Some or all of the configuration is incomplete, missing, or not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ResourceNotFoundException">
        /// AWS CodeStar Notifications can't find a resource that matches the provided ARN.
        /// </exception>
        /// <exception cref="Amazon.CodeStarNotifications.Model.ValidationException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-notifications-2019-10-15/UpdateNotificationRule">REST API Reference for UpdateNotificationRule Operation</seealso>
        Task<UpdateNotificationRuleResponse> UpdateNotificationRuleAsync(UpdateNotificationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonCodeStarNotificationsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonCodeStarNotificationsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonCodeStarNotificationsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonCodeStarNotificationsConfig to create AmazonCodeStarNotificationsClient");
            }

            return awsCredentials == null ? 
                    new AmazonCodeStarNotificationsClient(serviceClientConfig) :
                    new AmazonCodeStarNotificationsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}