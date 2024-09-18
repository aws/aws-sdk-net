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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MailManager.Model;

#pragma warning disable CS1570
namespace Amazon.MailManager
{
    /// <summary>
    /// <para>Interface for accessing MailManager</para>
    ///
    /// Amazon SES Mail Manager API 
    /// <para>
    /// The Amazon SES Mail Manager API contains operations and data types that comprise the
    /// Mail Manager feature of <a href="http://aws.amazon.com/ses">Amazon Simple Email Service
    /// (SES)</a>.
    /// 
    ///  
    /// <para>
    /// Mail Manager is a set of Amazon SES email gateway features designed to help you strengthen
    /// your organization's email infrastructure, simplify email workflow management, and
    /// streamline email compliance control. To learn more, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/eb.html">Mail
    /// Manager chapter</a> in the <i>Amazon SES Developer Guide</i>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonMailManager : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMailManagerPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateAddonInstance


        /// <summary>
        /// Creates an Add On instance for the subscription indicated in the request. The resulting
        /// Amazon Resource Name (ARN) can be used in a conditional statement for a rule set or
        /// traffic policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonInstance service method.</param>
        /// 
        /// <returns>The response from the CreateAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonInstance">REST API Reference for CreateAddonInstance Operation</seealso>
        CreateAddonInstanceResponse CreateAddonInstance(CreateAddonInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonInstance operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAddonInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonInstance">REST API Reference for CreateAddonInstance Operation</seealso>
        IAsyncResult BeginCreateAddonInstance(CreateAddonInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAddonInstance.</param>
        /// 
        /// <returns>Returns a  CreateAddonInstanceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonInstance">REST API Reference for CreateAddonInstance Operation</seealso>
        CreateAddonInstanceResponse EndCreateAddonInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAddonSubscription


        /// <summary>
        /// Creates a subscription for an Add On representing the acceptance of its terms of use
        /// and additional pricing. The subscription can then be used to create an instance for
        /// use in rule sets or traffic policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonSubscription">REST API Reference for CreateAddonSubscription Operation</seealso>
        CreateAddonSubscriptionResponse CreateAddonSubscription(CreateAddonSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonSubscription operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAddonSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonSubscription">REST API Reference for CreateAddonSubscription Operation</seealso>
        IAsyncResult BeginCreateAddonSubscription(CreateAddonSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAddonSubscription.</param>
        /// 
        /// <returns>Returns a  CreateAddonSubscriptionResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonSubscription">REST API Reference for CreateAddonSubscription Operation</seealso>
        CreateAddonSubscriptionResponse EndCreateAddonSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateArchive


        /// <summary>
        /// Creates a new email archive resource for storing and retaining emails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArchive service method.</param>
        /// 
        /// <returns>The response from the CreateArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        CreateArchiveResponse CreateArchive(CreateArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateArchive operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        IAsyncResult BeginCreateArchive(CreateArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateArchive.</param>
        /// 
        /// <returns>Returns a  CreateArchiveResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        CreateArchiveResponse EndCreateArchive(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIngressPoint


        /// <summary>
        /// Provision a new ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngressPoint service method.</param>
        /// 
        /// <returns>The response from the CreateIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateIngressPoint">REST API Reference for CreateIngressPoint Operation</seealso>
        CreateIngressPointResponse CreateIngressPoint(CreateIngressPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIngressPoint operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIngressPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateIngressPoint">REST API Reference for CreateIngressPoint Operation</seealso>
        IAsyncResult BeginCreateIngressPoint(CreateIngressPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIngressPoint.</param>
        /// 
        /// <returns>Returns a  CreateIngressPointResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateIngressPoint">REST API Reference for CreateIngressPoint Operation</seealso>
        CreateIngressPointResponse EndCreateIngressPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRelay


        /// <summary>
        /// Creates a relay resource which can be used in rules to relay incoming emails to defined
        /// relay destinations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelay service method.</param>
        /// 
        /// <returns>The response from the CreateRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRelay">REST API Reference for CreateRelay Operation</seealso>
        CreateRelayResponse CreateRelay(CreateRelayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRelay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRelay operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRelay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRelay">REST API Reference for CreateRelay Operation</seealso>
        IAsyncResult BeginCreateRelay(CreateRelayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRelay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRelay.</param>
        /// 
        /// <returns>Returns a  CreateRelayResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRelay">REST API Reference for CreateRelay Operation</seealso>
        CreateRelayResponse EndCreateRelay(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRuleSet


        /// <summary>
        /// Provision a new rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleSet service method.</param>
        /// 
        /// <returns>The response from the CreateRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRuleSet">REST API Reference for CreateRuleSet Operation</seealso>
        CreateRuleSetResponse CreateRuleSet(CreateRuleSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleSet operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRuleSet">REST API Reference for CreateRuleSet Operation</seealso>
        IAsyncResult BeginCreateRuleSet(CreateRuleSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRuleSet.</param>
        /// 
        /// <returns>Returns a  CreateRuleSetResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRuleSet">REST API Reference for CreateRuleSet Operation</seealso>
        CreateRuleSetResponse EndCreateRuleSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrafficPolicy


        /// <summary>
        /// Provision a new traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        CreateTrafficPolicyResponse CreateTrafficPolicy(CreateTrafficPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrafficPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        IAsyncResult BeginCreateTrafficPolicy(CreateTrafficPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrafficPolicy.</param>
        /// 
        /// <returns>Returns a  CreateTrafficPolicyResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        CreateTrafficPolicyResponse EndCreateTrafficPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAddonInstance


        /// <summary>
        /// Deletes an Add On instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonInstance">REST API Reference for DeleteAddonInstance Operation</seealso>
        DeleteAddonInstanceResponse DeleteAddonInstance(DeleteAddonInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonInstance operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAddonInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonInstance">REST API Reference for DeleteAddonInstance Operation</seealso>
        IAsyncResult BeginDeleteAddonInstance(DeleteAddonInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAddonInstance.</param>
        /// 
        /// <returns>Returns a  DeleteAddonInstanceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonInstance">REST API Reference for DeleteAddonInstance Operation</seealso>
        DeleteAddonInstanceResponse EndDeleteAddonInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAddonSubscription


        /// <summary>
        /// Deletes an Add On subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonSubscription">REST API Reference for DeleteAddonSubscription Operation</seealso>
        DeleteAddonSubscriptionResponse DeleteAddonSubscription(DeleteAddonSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonSubscription operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAddonSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonSubscription">REST API Reference for DeleteAddonSubscription Operation</seealso>
        IAsyncResult BeginDeleteAddonSubscription(DeleteAddonSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAddonSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteAddonSubscriptionResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonSubscription">REST API Reference for DeleteAddonSubscription Operation</seealso>
        DeleteAddonSubscriptionResponse EndDeleteAddonSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteArchive


        /// <summary>
        /// Initiates deletion of an email archive. This changes the archive state to pending
        /// deletion. In this state, no new emails can be added, and existing archived emails
        /// become inaccessible (search, export, download). The archive and all of its contents
        /// will be permanently deleted 30 days after entering the pending deletion state, regardless
        /// of the configured retention period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive service method.</param>
        /// 
        /// <returns>The response from the DeleteArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        IAsyncResult BeginDeleteArchive(DeleteArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteArchive.</param>
        /// 
        /// <returns>Returns a  DeleteArchiveResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        DeleteArchiveResponse EndDeleteArchive(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIngressPoint


        /// <summary>
        /// Delete an ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngressPoint service method.</param>
        /// 
        /// <returns>The response from the DeleteIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteIngressPoint">REST API Reference for DeleteIngressPoint Operation</seealso>
        DeleteIngressPointResponse DeleteIngressPoint(DeleteIngressPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngressPoint operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIngressPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteIngressPoint">REST API Reference for DeleteIngressPoint Operation</seealso>
        IAsyncResult BeginDeleteIngressPoint(DeleteIngressPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIngressPoint.</param>
        /// 
        /// <returns>Returns a  DeleteIngressPointResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteIngressPoint">REST API Reference for DeleteIngressPoint Operation</seealso>
        DeleteIngressPointResponse EndDeleteIngressPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRelay


        /// <summary>
        /// Deletes an existing relay resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelay service method.</param>
        /// 
        /// <returns>The response from the DeleteRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRelay">REST API Reference for DeleteRelay Operation</seealso>
        DeleteRelayResponse DeleteRelay(DeleteRelayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRelay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelay operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRelay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRelay">REST API Reference for DeleteRelay Operation</seealso>
        IAsyncResult BeginDeleteRelay(DeleteRelayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRelay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRelay.</param>
        /// 
        /// <returns>Returns a  DeleteRelayResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRelay">REST API Reference for DeleteRelay Operation</seealso>
        DeleteRelayResponse EndDeleteRelay(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRuleSet


        /// <summary>
        /// Delete a rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleSet service method.</param>
        /// 
        /// <returns>The response from the DeleteRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRuleSet">REST API Reference for DeleteRuleSet Operation</seealso>
        DeleteRuleSetResponse DeleteRuleSet(DeleteRuleSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleSet operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRuleSet">REST API Reference for DeleteRuleSet Operation</seealso>
        IAsyncResult BeginDeleteRuleSet(DeleteRuleSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRuleSet.</param>
        /// 
        /// <returns>Returns a  DeleteRuleSetResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRuleSet">REST API Reference for DeleteRuleSet Operation</seealso>
        DeleteRuleSetResponse EndDeleteRuleSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrafficPolicy


        /// <summary>
        /// Delete a traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteTrafficPolicy">REST API Reference for DeleteTrafficPolicy Operation</seealso>
        DeleteTrafficPolicyResponse DeleteTrafficPolicy(DeleteTrafficPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrafficPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteTrafficPolicy">REST API Reference for DeleteTrafficPolicy Operation</seealso>
        IAsyncResult BeginDeleteTrafficPolicy(DeleteTrafficPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrafficPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteTrafficPolicyResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteTrafficPolicy">REST API Reference for DeleteTrafficPolicy Operation</seealso>
        DeleteTrafficPolicyResponse EndDeleteTrafficPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAddonInstance


        /// <summary>
        /// Gets detailed information about an Add On instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddonInstance service method.</param>
        /// 
        /// <returns>The response from the GetAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonInstance">REST API Reference for GetAddonInstance Operation</seealso>
        GetAddonInstanceResponse GetAddonInstance(GetAddonInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAddonInstance operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAddonInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonInstance">REST API Reference for GetAddonInstance Operation</seealso>
        IAsyncResult BeginGetAddonInstance(GetAddonInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAddonInstance.</param>
        /// 
        /// <returns>Returns a  GetAddonInstanceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonInstance">REST API Reference for GetAddonInstance Operation</seealso>
        GetAddonInstanceResponse EndGetAddonInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAddonSubscription


        /// <summary>
        /// Gets detailed information about an Add On subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddonSubscription service method.</param>
        /// 
        /// <returns>The response from the GetAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonSubscription">REST API Reference for GetAddonSubscription Operation</seealso>
        GetAddonSubscriptionResponse GetAddonSubscription(GetAddonSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAddonSubscription operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAddonSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonSubscription">REST API Reference for GetAddonSubscription Operation</seealso>
        IAsyncResult BeginGetAddonSubscription(GetAddonSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAddonSubscription.</param>
        /// 
        /// <returns>Returns a  GetAddonSubscriptionResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonSubscription">REST API Reference for GetAddonSubscription Operation</seealso>
        GetAddonSubscriptionResponse EndGetAddonSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  GetArchive


        /// <summary>
        /// Retrieves the full details and current state of a specified email archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchive service method.</param>
        /// 
        /// <returns>The response from the GetArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchive">REST API Reference for GetArchive Operation</seealso>
        GetArchiveResponse GetArchive(GetArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchive operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchive">REST API Reference for GetArchive Operation</seealso>
        IAsyncResult BeginGetArchive(GetArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchive.</param>
        /// 
        /// <returns>Returns a  GetArchiveResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchive">REST API Reference for GetArchive Operation</seealso>
        GetArchiveResponse EndGetArchive(IAsyncResult asyncResult);

        #endregion
        
        #region  GetArchiveExport


        /// <summary>
        /// Retrieves the details and current status of a specific email archive export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveExport service method.</param>
        /// 
        /// <returns>The response from the GetArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveExport">REST API Reference for GetArchiveExport Operation</seealso>
        GetArchiveExportResponse GetArchiveExport(GetArchiveExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveExport operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchiveExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveExport">REST API Reference for GetArchiveExport Operation</seealso>
        IAsyncResult BeginGetArchiveExport(GetArchiveExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchiveExport.</param>
        /// 
        /// <returns>Returns a  GetArchiveExportResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveExport">REST API Reference for GetArchiveExport Operation</seealso>
        GetArchiveExportResponse EndGetArchiveExport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetArchiveMessage


        /// <summary>
        /// Returns a pre-signed URL that provides temporary download access to the specific email
        /// message stored in the archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessage service method.</param>
        /// 
        /// <returns>The response from the GetArchiveMessage service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessage">REST API Reference for GetArchiveMessage Operation</seealso>
        GetArchiveMessageResponse GetArchiveMessage(GetArchiveMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchiveMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessage operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchiveMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessage">REST API Reference for GetArchiveMessage Operation</seealso>
        IAsyncResult BeginGetArchiveMessage(GetArchiveMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchiveMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchiveMessage.</param>
        /// 
        /// <returns>Returns a  GetArchiveMessageResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessage">REST API Reference for GetArchiveMessage Operation</seealso>
        GetArchiveMessageResponse EndGetArchiveMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetArchiveMessageContent


        /// <summary>
        /// Returns the textual content of a specific email message stored in the archive. Attachments
        /// are not included.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessageContent service method.</param>
        /// 
        /// <returns>The response from the GetArchiveMessageContent service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessageContent">REST API Reference for GetArchiveMessageContent Operation</seealso>
        GetArchiveMessageContentResponse GetArchiveMessageContent(GetArchiveMessageContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchiveMessageContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessageContent operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchiveMessageContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessageContent">REST API Reference for GetArchiveMessageContent Operation</seealso>
        IAsyncResult BeginGetArchiveMessageContent(GetArchiveMessageContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchiveMessageContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchiveMessageContent.</param>
        /// 
        /// <returns>Returns a  GetArchiveMessageContentResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessageContent">REST API Reference for GetArchiveMessageContent Operation</seealso>
        GetArchiveMessageContentResponse EndGetArchiveMessageContent(IAsyncResult asyncResult);

        #endregion
        
        #region  GetArchiveSearch


        /// <summary>
        /// Retrieves the details and current status of a specific email archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearch service method.</param>
        /// 
        /// <returns>The response from the GetArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearch">REST API Reference for GetArchiveSearch Operation</seealso>
        GetArchiveSearchResponse GetArchiveSearch(GetArchiveSearchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearch operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchiveSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearch">REST API Reference for GetArchiveSearch Operation</seealso>
        IAsyncResult BeginGetArchiveSearch(GetArchiveSearchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchiveSearch.</param>
        /// 
        /// <returns>Returns a  GetArchiveSearchResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearch">REST API Reference for GetArchiveSearch Operation</seealso>
        GetArchiveSearchResponse EndGetArchiveSearch(IAsyncResult asyncResult);

        #endregion
        
        #region  GetArchiveSearchResults


        /// <summary>
        /// Returns the results of a completed email archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearchResults service method.</param>
        /// 
        /// <returns>The response from the GetArchiveSearchResults service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearchResults">REST API Reference for GetArchiveSearchResults Operation</seealso>
        GetArchiveSearchResultsResponse GetArchiveSearchResults(GetArchiveSearchResultsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchiveSearchResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearchResults operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchiveSearchResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearchResults">REST API Reference for GetArchiveSearchResults Operation</seealso>
        IAsyncResult BeginGetArchiveSearchResults(GetArchiveSearchResultsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchiveSearchResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchiveSearchResults.</param>
        /// 
        /// <returns>Returns a  GetArchiveSearchResultsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearchResults">REST API Reference for GetArchiveSearchResults Operation</seealso>
        GetArchiveSearchResultsResponse EndGetArchiveSearchResults(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIngressPoint


        /// <summary>
        /// Fetch ingress endpoint resource attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngressPoint service method.</param>
        /// 
        /// <returns>The response from the GetIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetIngressPoint">REST API Reference for GetIngressPoint Operation</seealso>
        GetIngressPointResponse GetIngressPoint(GetIngressPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIngressPoint operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIngressPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetIngressPoint">REST API Reference for GetIngressPoint Operation</seealso>
        IAsyncResult BeginGetIngressPoint(GetIngressPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIngressPoint.</param>
        /// 
        /// <returns>Returns a  GetIngressPointResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetIngressPoint">REST API Reference for GetIngressPoint Operation</seealso>
        GetIngressPointResponse EndGetIngressPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRelay


        /// <summary>
        /// Fetch the relay resource and it's attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelay service method.</param>
        /// 
        /// <returns>The response from the GetRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRelay">REST API Reference for GetRelay Operation</seealso>
        GetRelayResponse GetRelay(GetRelayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelay operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRelay">REST API Reference for GetRelay Operation</seealso>
        IAsyncResult BeginGetRelay(GetRelayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelay.</param>
        /// 
        /// <returns>Returns a  GetRelayResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRelay">REST API Reference for GetRelay Operation</seealso>
        GetRelayResponse EndGetRelay(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRuleSet


        /// <summary>
        /// Fetch attributes of a rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleSet service method.</param>
        /// 
        /// <returns>The response from the GetRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRuleSet">REST API Reference for GetRuleSet Operation</seealso>
        GetRuleSetResponse GetRuleSet(GetRuleSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRuleSet operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRuleSet">REST API Reference for GetRuleSet Operation</seealso>
        IAsyncResult BeginGetRuleSet(GetRuleSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRuleSet.</param>
        /// 
        /// <returns>Returns a  GetRuleSetResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRuleSet">REST API Reference for GetRuleSet Operation</seealso>
        GetRuleSetResponse EndGetRuleSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrafficPolicy


        /// <summary>
        /// Fetch attributes of a traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        GetTrafficPolicyResponse GetTrafficPolicy(GetTrafficPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrafficPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        IAsyncResult BeginGetTrafficPolicy(GetTrafficPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrafficPolicy.</param>
        /// 
        /// <returns>Returns a  GetTrafficPolicyResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        GetTrafficPolicyResponse EndGetTrafficPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAddonInstances


        /// <summary>
        /// Lists all Add On instances in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddonInstances service method.</param>
        /// 
        /// <returns>The response from the ListAddonInstances service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonInstances">REST API Reference for ListAddonInstances Operation</seealso>
        ListAddonInstancesResponse ListAddonInstances(ListAddonInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAddonInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAddonInstances operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAddonInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonInstances">REST API Reference for ListAddonInstances Operation</seealso>
        IAsyncResult BeginListAddonInstances(ListAddonInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAddonInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAddonInstances.</param>
        /// 
        /// <returns>Returns a  ListAddonInstancesResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonInstances">REST API Reference for ListAddonInstances Operation</seealso>
        ListAddonInstancesResponse EndListAddonInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAddonSubscriptions


        /// <summary>
        /// Lists all Add On subscriptions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddonSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListAddonSubscriptions service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonSubscriptions">REST API Reference for ListAddonSubscriptions Operation</seealso>
        ListAddonSubscriptionsResponse ListAddonSubscriptions(ListAddonSubscriptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAddonSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAddonSubscriptions operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAddonSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonSubscriptions">REST API Reference for ListAddonSubscriptions Operation</seealso>
        IAsyncResult BeginListAddonSubscriptions(ListAddonSubscriptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAddonSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAddonSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListAddonSubscriptionsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonSubscriptions">REST API Reference for ListAddonSubscriptions Operation</seealso>
        ListAddonSubscriptionsResponse EndListAddonSubscriptions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListArchiveExports


        /// <summary>
        /// Returns a list of email archive export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveExports service method.</param>
        /// 
        /// <returns>The response from the ListArchiveExports service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveExports">REST API Reference for ListArchiveExports Operation</seealso>
        ListArchiveExportsResponse ListArchiveExports(ListArchiveExportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListArchiveExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveExports operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArchiveExports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveExports">REST API Reference for ListArchiveExports Operation</seealso>
        IAsyncResult BeginListArchiveExports(ListArchiveExportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListArchiveExports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArchiveExports.</param>
        /// 
        /// <returns>Returns a  ListArchiveExportsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveExports">REST API Reference for ListArchiveExports Operation</seealso>
        ListArchiveExportsResponse EndListArchiveExports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListArchives


        /// <summary>
        /// Returns a list of all email archives in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchives service method.</param>
        /// 
        /// <returns>The response from the ListArchives service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchives">REST API Reference for ListArchives Operation</seealso>
        ListArchivesResponse ListArchives(ListArchivesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListArchives operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArchives operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArchives
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchives">REST API Reference for ListArchives Operation</seealso>
        IAsyncResult BeginListArchives(ListArchivesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListArchives operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArchives.</param>
        /// 
        /// <returns>Returns a  ListArchivesResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchives">REST API Reference for ListArchives Operation</seealso>
        ListArchivesResponse EndListArchives(IAsyncResult asyncResult);

        #endregion
        
        #region  ListArchiveSearches


        /// <summary>
        /// Returns a list of email archive search jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveSearches service method.</param>
        /// 
        /// <returns>The response from the ListArchiveSearches service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveSearches">REST API Reference for ListArchiveSearches Operation</seealso>
        ListArchiveSearchesResponse ListArchiveSearches(ListArchiveSearchesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListArchiveSearches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveSearches operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArchiveSearches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveSearches">REST API Reference for ListArchiveSearches Operation</seealso>
        IAsyncResult BeginListArchiveSearches(ListArchiveSearchesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListArchiveSearches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArchiveSearches.</param>
        /// 
        /// <returns>Returns a  ListArchiveSearchesResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveSearches">REST API Reference for ListArchiveSearches Operation</seealso>
        ListArchiveSearchesResponse EndListArchiveSearches(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIngressPoints


        /// <summary>
        /// List all ingress endpoint resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngressPoints service method.</param>
        /// 
        /// <returns>The response from the ListIngressPoints service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListIngressPoints">REST API Reference for ListIngressPoints Operation</seealso>
        ListIngressPointsResponse ListIngressPoints(ListIngressPointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIngressPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIngressPoints operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIngressPoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListIngressPoints">REST API Reference for ListIngressPoints Operation</seealso>
        IAsyncResult BeginListIngressPoints(ListIngressPointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIngressPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIngressPoints.</param>
        /// 
        /// <returns>Returns a  ListIngressPointsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListIngressPoints">REST API Reference for ListIngressPoints Operation</seealso>
        ListIngressPointsResponse EndListIngressPoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRelays


        /// <summary>
        /// Lists all the existing relay resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelays service method.</param>
        /// 
        /// <returns>The response from the ListRelays service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRelays">REST API Reference for ListRelays Operation</seealso>
        ListRelaysResponse ListRelays(ListRelaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRelays operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRelays operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRelays
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRelays">REST API Reference for ListRelays Operation</seealso>
        IAsyncResult BeginListRelays(ListRelaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRelays operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRelays.</param>
        /// 
        /// <returns>Returns a  ListRelaysResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRelays">REST API Reference for ListRelays Operation</seealso>
        ListRelaysResponse EndListRelays(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRuleSets


        /// <summary>
        /// List rule sets for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleSets service method.</param>
        /// 
        /// <returns>The response from the ListRuleSets service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRuleSets">REST API Reference for ListRuleSets Operation</seealso>
        ListRuleSetsResponse ListRuleSets(ListRuleSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleSets operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuleSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRuleSets">REST API Reference for ListRuleSets Operation</seealso>
        IAsyncResult BeginListRuleSets(ListRuleSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleSets.</param>
        /// 
        /// <returns>Returns a  ListRuleSetsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRuleSets">REST API Reference for ListRuleSets Operation</seealso>
        ListRuleSetsResponse EndListRuleSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves the list of tags (keys and values) assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrafficPolicies


        /// <summary>
        /// List traffic policy resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicies service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        ListTrafficPoliciesResponse ListTrafficPolicies(ListTrafficPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrafficPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        IAsyncResult BeginListTrafficPolicies(ListTrafficPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrafficPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrafficPolicies.</param>
        /// 
        /// <returns>Returns a  ListTrafficPoliciesResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        ListTrafficPoliciesResponse EndListTrafficPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  StartArchiveExport


        /// <summary>
        /// Initiates an export of emails from the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveExport service method.</param>
        /// 
        /// <returns>The response from the StartArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveExport">REST API Reference for StartArchiveExport Operation</seealso>
        StartArchiveExportResponse StartArchiveExport(StartArchiveExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveExport operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartArchiveExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveExport">REST API Reference for StartArchiveExport Operation</seealso>
        IAsyncResult BeginStartArchiveExport(StartArchiveExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartArchiveExport.</param>
        /// 
        /// <returns>Returns a  StartArchiveExportResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveExport">REST API Reference for StartArchiveExport Operation</seealso>
        StartArchiveExportResponse EndStartArchiveExport(IAsyncResult asyncResult);

        #endregion
        
        #region  StartArchiveSearch


        /// <summary>
        /// Initiates a search across emails in the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveSearch service method.</param>
        /// 
        /// <returns>The response from the StartArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveSearch">REST API Reference for StartArchiveSearch Operation</seealso>
        StartArchiveSearchResponse StartArchiveSearch(StartArchiveSearchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveSearch operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartArchiveSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveSearch">REST API Reference for StartArchiveSearch Operation</seealso>
        IAsyncResult BeginStartArchiveSearch(StartArchiveSearchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartArchiveSearch.</param>
        /// 
        /// <returns>Returns a  StartArchiveSearchResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveSearch">REST API Reference for StartArchiveSearch Operation</seealso>
        StartArchiveSearchResponse EndStartArchiveSearch(IAsyncResult asyncResult);

        #endregion
        
        #region  StopArchiveExport


        /// <summary>
        /// Stops an in-progress export of emails from an archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveExport service method.</param>
        /// 
        /// <returns>The response from the StopArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveExport">REST API Reference for StopArchiveExport Operation</seealso>
        StopArchiveExportResponse StopArchiveExport(StopArchiveExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveExport operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopArchiveExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveExport">REST API Reference for StopArchiveExport Operation</seealso>
        IAsyncResult BeginStopArchiveExport(StopArchiveExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopArchiveExport.</param>
        /// 
        /// <returns>Returns a  StopArchiveExportResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveExport">REST API Reference for StopArchiveExport Operation</seealso>
        StopArchiveExportResponse EndStopArchiveExport(IAsyncResult asyncResult);

        #endregion
        
        #region  StopArchiveSearch


        /// <summary>
        /// Stops an in-progress archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveSearch service method.</param>
        /// 
        /// <returns>The response from the StopArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveSearch">REST API Reference for StopArchiveSearch Operation</seealso>
        StopArchiveSearchResponse StopArchiveSearch(StopArchiveSearchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveSearch operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopArchiveSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveSearch">REST API Reference for StopArchiveSearch Operation</seealso>
        IAsyncResult BeginStopArchiveSearch(StopArchiveSearchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopArchiveSearch.</param>
        /// 
        /// <returns>Returns a  StopArchiveSearchResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveSearch">REST API Reference for StopArchiveSearch Operation</seealso>
        StopArchiveSearchResponse EndStopArchiveSearch(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags (keys and values) to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove one or more tags (keys and values) from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateArchive


        /// <summary>
        /// Updates the attributes of an existing email archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchive service method.</param>
        /// 
        /// <returns>The response from the UpdateArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        UpdateArchiveResponse UpdateArchive(UpdateArchiveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchive operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        IAsyncResult BeginUpdateArchive(UpdateArchiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateArchive.</param>
        /// 
        /// <returns>Returns a  UpdateArchiveResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        UpdateArchiveResponse EndUpdateArchive(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIngressPoint


        /// <summary>
        /// Update attributes of a provisioned ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIngressPoint service method.</param>
        /// 
        /// <returns>The response from the UpdateIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateIngressPoint">REST API Reference for UpdateIngressPoint Operation</seealso>
        UpdateIngressPointResponse UpdateIngressPoint(UpdateIngressPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIngressPoint operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIngressPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateIngressPoint">REST API Reference for UpdateIngressPoint Operation</seealso>
        IAsyncResult BeginUpdateIngressPoint(UpdateIngressPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIngressPoint.</param>
        /// 
        /// <returns>Returns a  UpdateIngressPointResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateIngressPoint">REST API Reference for UpdateIngressPoint Operation</seealso>
        UpdateIngressPointResponse EndUpdateIngressPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRelay


        /// <summary>
        /// Updates the attributes of an existing relay resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelay service method.</param>
        /// 
        /// <returns>The response from the UpdateRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRelay">REST API Reference for UpdateRelay Operation</seealso>
        UpdateRelayResponse UpdateRelay(UpdateRelayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRelay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelay operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRelay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRelay">REST API Reference for UpdateRelay Operation</seealso>
        IAsyncResult BeginUpdateRelay(UpdateRelayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRelay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRelay.</param>
        /// 
        /// <returns>Returns a  UpdateRelayResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRelay">REST API Reference for UpdateRelay Operation</seealso>
        UpdateRelayResponse EndUpdateRelay(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRuleSet


        /// <summary>
        /// Update attributes of an already provisioned rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleSet service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRuleSet">REST API Reference for UpdateRuleSet Operation</seealso>
        UpdateRuleSetResponse UpdateRuleSet(UpdateRuleSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleSet operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRuleSet">REST API Reference for UpdateRuleSet Operation</seealso>
        IAsyncResult BeginUpdateRuleSet(UpdateRuleSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleSet.</param>
        /// 
        /// <returns>Returns a  UpdateRuleSetResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRuleSet">REST API Reference for UpdateRuleSet Operation</seealso>
        UpdateRuleSetResponse EndUpdateRuleSet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTrafficPolicy


        /// <summary>
        /// Update attributes of an already provisioned traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateTrafficPolicy">REST API Reference for UpdateTrafficPolicy Operation</seealso>
        UpdateTrafficPolicyResponse UpdateTrafficPolicy(UpdateTrafficPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicy operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrafficPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateTrafficPolicy">REST API Reference for UpdateTrafficPolicy Operation</seealso>
        IAsyncResult BeginUpdateTrafficPolicy(UpdateTrafficPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrafficPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateTrafficPolicyResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateTrafficPolicy">REST API Reference for UpdateTrafficPolicy Operation</seealso>
        UpdateTrafficPolicyResponse EndUpdateTrafficPolicy(IAsyncResult asyncResult);

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