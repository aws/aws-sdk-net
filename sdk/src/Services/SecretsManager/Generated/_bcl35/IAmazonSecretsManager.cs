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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SecretsManager.Model;

namespace Amazon.SecretsManager
{
    /// <summary>
    /// Interface for accessing SecretsManager
    ///
    /// Amazon Web Services Secrets Manager 
    /// <para>
    /// Amazon Web Services Secrets Manager provides a service to enable you to store, manage,
    /// and retrieve, secrets.
    /// </para>
    ///  
    /// <para>
    /// This guide provides descriptions of the Secrets Manager API. For more information
    /// about using this service, see the <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/introduction.html">Amazon
    /// Web Services Secrets Manager User Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>API Version</b> 
    /// </para>
    ///  
    /// <para>
    /// This version of the Secrets Manager API Reference documents the Secrets Manager API
    /// version 2017-10-17.
    /// </para>
    ///  
    /// <para>
    ///  <b>Support and Feedback for Amazon Web Services Secrets Manager</b> 
    /// </para>
    ///  
    /// <para>
    /// We welcome your feedback. Send your comments to <a href="mailto:awssecretsmanager-feedback@amazon.com">awssecretsmanager-feedback@amazon.com</a>,
    /// or post your feedback and questions in the <a href="http://forums.aws.amazon.com/forum.jspa?forumID=296">Amazon
    /// Web Services Secrets Manager Discussion Forum</a>. For more information about the
    /// Amazon Web Services Discussion Forums, see <a href="http://forums.aws.amazon.com/help.jspa">Forums
    /// Help</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Logging API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Secrets Manager supports Amazon Web Services CloudTrail, a service
    /// that records Amazon Web Services API calls for your Amazon Web Services account and
    /// delivers log files to an Amazon S3 bucket. By using information that's collected by
    /// Amazon Web Services CloudTrail, you can determine the requests successfully made to
    /// Secrets Manager, who made the request, when it was made, and so on. For more about
    /// Amazon Web Services Secrets Manager and support for Amazon Web Services CloudTrail,
    /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/monitoring.html#monitoring_cloudtrail">Logging
    /// Amazon Web Services Secrets Manager Events with Amazon Web Services CloudTrail</a>
    /// in the <i>Amazon Web Services Secrets Manager User Guide</i>. To learn more about
    /// CloudTrail, including enabling it and find your log files, see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/what_is_cloud_trail_top_level.html">Amazon
    /// Web Services CloudTrail User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonSecretsManager : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISecretsManagerPaginatorFactory Paginators { get; }
#endif


        
        #region  CancelRotateSecret


        /// <summary>
        /// Turns off automatic rotation, and if a rotation is currently in progress, cancels
        /// the rotation.
        /// 
        ///  
        /// <para>
        /// If you cancel a rotation in progress, it can leave the <code>VersionStage</code> labels
        /// in an unexpected state. You might need to remove the staging label <code>AWSPENDING</code>
        /// from the partially created version. You also need to determine whether to roll back
        /// to the previous version of the secret by moving the staging label <code>AWSCURRENT</code>
        /// to the version that has <code>AWSPENDING</code>. To determine which version has a
        /// specific staging label, call <a>ListSecretVersionIds</a>. Then use <a>UpdateSecretVersionStage</a>
        /// to change staging labels. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotate-secrets_how.html">How
        /// rotation works</a>.
        /// </para>
        ///  
        /// <para>
        /// To turn on automatic rotation again, call <a>RotateSecret</a>.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:CancelRotateSecret</code>. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRotateSecret service method.</param>
        /// 
        /// <returns>The response from the CancelRotateSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/CancelRotateSecret">REST API Reference for CancelRotateSecret Operation</seealso>
        CancelRotateSecretResponse CancelRotateSecret(CancelRotateSecretRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelRotateSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelRotateSecret operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelRotateSecret
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/CancelRotateSecret">REST API Reference for CancelRotateSecret Operation</seealso>
        IAsyncResult BeginCancelRotateSecret(CancelRotateSecretRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelRotateSecret operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelRotateSecret.</param>
        /// 
        /// <returns>Returns a  CancelRotateSecretResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/CancelRotateSecret">REST API Reference for CancelRotateSecret Operation</seealso>
        CancelRotateSecretResponse EndCancelRotateSecret(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSecret


        /// <summary>
        /// Creates a new secret. A <i>secret</i> can be a password, a set of credentials such
        /// as a user name and password, an OAuth token, or other secret information that you
        /// store in an encrypted form in Secrets Manager. The secret also includes the connection
        /// information to access a database or other service, which Secrets Manager doesn't encrypt.
        /// A secret in Secrets Manager consists of both the protected secret data and the important
        /// information needed to manage the secret.
        /// 
        ///  
        /// <para>
        /// For information about creating a secret in the console, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/manage_create-basic-secret.html">Create
        /// a secret</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a secret, you can provide the secret value to be encrypted in either the
        /// <code>SecretString</code> parameter or the <code>SecretBinary</code> parameter, but
        /// not both. If you include <code>SecretString</code> or <code>SecretBinary</code> then
        /// Secrets Manager creates an initial secret version and automatically attaches the staging
        /// label <code>AWSCURRENT</code> to it.
        /// </para>
        ///  
        /// <para>
        /// For database credentials you want to rotate, for Secrets Manager to be able to rotate
        /// the secret, you must make sure the JSON you store in the <code>SecretString</code>
        /// matches the <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_secret_json_structure.html">JSON
        /// structure of a database secret</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an KMS encryption key, Secrets Manager uses the Amazon Web Services
        /// managed key <code>aws/secretsmanager</code>. If this key doesn't already exist in
        /// your account, then Secrets Manager creates it for you automatically. All users and
        /// roles in the Amazon Web Services account automatically have access to use <code>aws/secretsmanager</code>.
        /// Creating <code>aws/secretsmanager</code> can result in a one-time significant delay
        /// in returning the result.
        /// </para>
        ///  
        /// <para>
        /// If the secret is in a different Amazon Web Services account from the credentials calling
        /// the API, then you can't use <code>aws/secretsmanager</code> to encrypt the secret,
        /// and you must create and use a customer managed KMS key. 
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters except <code>SecretBinary</code>
        /// or <code>SecretString</code> because it might be logged. For more information, see
        /// <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:CreateSecret</code>. If you include
        /// tags in the secret, you also need <code>secretsmanager:TagResource</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        ///  
        /// <para>
        /// To encrypt the secret with a KMS key other than <code>aws/secretsmanager</code>, you
        /// need <code>kms:GenerateDataKey</code> and <code>kms:Decrypt</code> permission to the
        /// key. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecret service method.</param>
        /// 
        /// <returns>The response from the CreateSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.DecryptionFailureException">
        /// Secrets Manager can't decrypt the protected secret text using the provided KMS key.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.EncryptionFailureException">
        /// Secrets Manager can't encrypt the protected secret text using the provided KMS key.
        /// Check that the KMS key is available, enabled, and not in an invalid state. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a>.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.LimitExceededException">
        /// The request failed because it would exceed one of the Secrets Manager quotas.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.MalformedPolicyDocumentException">
        /// The resource policy has syntax errors.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.PreconditionNotMetException">
        /// The request failed because you did not complete all the prerequisite steps.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceExistsException">
        /// A resource with the ID you requested already exists.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/CreateSecret">REST API Reference for CreateSecret Operation</seealso>
        CreateSecretResponse CreateSecret(CreateSecretRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecret operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSecret
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/CreateSecret">REST API Reference for CreateSecret Operation</seealso>
        IAsyncResult BeginCreateSecret(CreateSecretRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSecret operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecret.</param>
        /// 
        /// <returns>Returns a  CreateSecretResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/CreateSecret">REST API Reference for CreateSecret Operation</seealso>
        CreateSecretResponse EndCreateSecret(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the resource-based permission policy attached to the secret. To attach a policy
        /// to a secret, use <a>PutResourcePolicy</a>.
        /// 
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:DeleteResourcePolicy</code>. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSecret


        /// <summary>
        /// Deletes a secret and all of its versions. You can specify a recovery window during
        /// which you can restore the secret. The minimum recovery window is 7 days. The default
        /// recovery window is 30 days. Secrets Manager attaches a <code>DeletionDate</code> stamp
        /// to the secret that specifies the end of the recovery window. At the end of the recovery
        /// window, Secrets Manager deletes the secret permanently.
        /// 
        ///  
        /// <para>
        /// You can't delete a primary secret that is replicated to other Regions. You must first
        /// delete the replicas using <a>RemoveRegionsFromReplication</a>, and then delete the
        /// primary secret. When you delete a replica, it is deleted immediately.
        /// </para>
        ///  
        /// <para>
        /// You can't directly delete a version of a secret. Instead, you remove all staging labels
        /// from the version using <a>UpdateSecretVersionStage</a>. This marks the version as
        /// deprecated, and then Secrets Manager can automatically delete the version in the background.
        /// </para>
        ///  
        /// <para>
        /// To determine whether an application still uses a secret, you can create an Amazon
        /// CloudWatch alarm to alert you to any attempts to access a secret during the recovery
        /// window. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/monitoring_cloudwatch_deleted-secrets.html">
        /// Monitor secrets scheduled for deletion</a>.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager performs the permanent secret deletion at the end of the waiting period
        /// as a background task with low priority. There is no guarantee of a specific time after
        /// the recovery window for the permanent delete to occur.
        /// </para>
        ///  
        /// <para>
        /// At any time before recovery window ends, you can use <a>RestoreSecret</a> to remove
        /// the <code>DeletionDate</code> and cancel the deletion of the secret.
        /// </para>
        ///  
        /// <para>
        /// When a secret is scheduled for deletion, you cannot retrieve the secret value. You
        /// must first cancel the deletion with <a>RestoreSecret</a> and then you can retrieve
        /// the secret.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:DeleteSecret</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecret service method.</param>
        /// 
        /// <returns>The response from the DeleteSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DeleteSecret">REST API Reference for DeleteSecret Operation</seealso>
        DeleteSecretResponse DeleteSecret(DeleteSecretRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecret operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSecret
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DeleteSecret">REST API Reference for DeleteSecret Operation</seealso>
        IAsyncResult BeginDeleteSecret(DeleteSecretRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSecret operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecret.</param>
        /// 
        /// <returns>Returns a  DeleteSecretResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DeleteSecret">REST API Reference for DeleteSecret Operation</seealso>
        DeleteSecretResponse EndDeleteSecret(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSecret


        /// <summary>
        /// Retrieves the details of a secret. It does not include the encrypted secret value.
        /// Secrets Manager only returns fields that have a value in the response. 
        /// 
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:DescribeSecret</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecret service method.</param>
        /// 
        /// <returns>The response from the DescribeSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DescribeSecret">REST API Reference for DescribeSecret Operation</seealso>
        DescribeSecretResponse DescribeSecret(DescribeSecretRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecret operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSecret
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DescribeSecret">REST API Reference for DescribeSecret Operation</seealso>
        IAsyncResult BeginDescribeSecret(DescribeSecretRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSecret operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecret.</param>
        /// 
        /// <returns>Returns a  DescribeSecretResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DescribeSecret">REST API Reference for DescribeSecret Operation</seealso>
        DescribeSecretResponse EndDescribeSecret(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRandomPassword


        /// <summary>
        /// Generates a random password. We recommend that you specify the maximum length and
        /// include every character type that the system you are generating a password for can
        /// support.
        /// 
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:GetRandomPassword</code>. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRandomPassword service method.</param>
        /// 
        /// <returns>The response from the GetRandomPassword service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetRandomPassword">REST API Reference for GetRandomPassword Operation</seealso>
        GetRandomPasswordResponse GetRandomPassword(GetRandomPasswordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRandomPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRandomPassword operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRandomPassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetRandomPassword">REST API Reference for GetRandomPassword Operation</seealso>
        IAsyncResult BeginGetRandomPassword(GetRandomPasswordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRandomPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRandomPassword.</param>
        /// 
        /// <returns>Returns a  GetRandomPasswordResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetRandomPassword">REST API Reference for GetRandomPassword Operation</seealso>
        GetRandomPasswordResponse EndGetRandomPassword(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves the JSON text of the resource-based policy document attached to the secret.
        /// For more information about permissions policies attached to a secret, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_resource-policies.html">Permissions
        /// policies attached to a secret</a>.
        /// 
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:GetResourcePolicy</code>. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSecretValue


        /// <summary>
        /// Retrieves the contents of the encrypted fields <code>SecretString</code> or <code>SecretBinary</code>
        /// from the specified version of a secret, whichever contains content.
        /// 
        ///  
        /// <para>
        /// We recommend that you cache your secret values by using client-side caching. Caching
        /// secrets improves speed and reduces your costs. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieving-secrets.html">Cache
        /// secrets for your applications</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the previous version of a secret, use <code>VersionStage</code> and specify
        /// AWSPREVIOUS. To revert to the previous version of a secret, call <a href="https://docs.aws.amazon.com/cli/latest/reference/secretsmanager/update-secret-version-stage.html">UpdateSecretVersionStage</a>.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:GetSecretValue</code>. If the
        /// secret is encrypted using a customer-managed key instead of the Amazon Web Services
        /// managed key <code>aws/secretsmanager</code>, then you also need <code>kms:Decrypt</code>
        /// permissions for that key. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecretValue service method.</param>
        /// 
        /// <returns>The response from the GetSecretValue service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.DecryptionFailureException">
        /// Secrets Manager can't decrypt the protected secret text using the provided KMS key.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetSecretValue">REST API Reference for GetSecretValue Operation</seealso>
        GetSecretValueResponse GetSecretValue(GetSecretValueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSecretValue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSecretValue operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSecretValue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetSecretValue">REST API Reference for GetSecretValue Operation</seealso>
        IAsyncResult BeginGetSecretValue(GetSecretValueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSecretValue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSecretValue.</param>
        /// 
        /// <returns>Returns a  GetSecretValueResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetSecretValue">REST API Reference for GetSecretValue Operation</seealso>
        GetSecretValueResponse EndGetSecretValue(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSecrets


        /// <summary>
        /// Lists the secrets that are stored by Secrets Manager in the Amazon Web Services account,
        /// not including secrets that are marked for deletion. To see secrets marked for deletion,
        /// use the Secrets Manager console.
        /// 
        ///  
        /// <para>
        /// ListSecrets is eventually consistent, however it might not reflect changes from the
        /// last five minutes. To get the latest information for a specific secret, use <a>DescribeSecret</a>.
        /// </para>
        ///  
        /// <para>
        /// To list the versions of a secret, use <a>ListSecretVersionIds</a>.
        /// </para>
        ///  
        /// <para>
        /// To get the secret value from <code>SecretString</code> or <code>SecretBinary</code>,
        /// call <a>GetSecretValue</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about finding secrets in the console, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/manage_search-secret.html">Find
        /// secrets in Secrets Manager</a>.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:ListSecrets</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecrets service method.</param>
        /// 
        /// <returns>The response from the ListSecrets service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecrets">REST API Reference for ListSecrets Operation</seealso>
        ListSecretsResponse ListSecrets(ListSecretsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecrets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecrets operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecrets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecrets">REST API Reference for ListSecrets Operation</seealso>
        IAsyncResult BeginListSecrets(ListSecretsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecrets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecrets.</param>
        /// 
        /// <returns>Returns a  ListSecretsResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecrets">REST API Reference for ListSecrets Operation</seealso>
        ListSecretsResponse EndListSecrets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSecretVersionIds


        /// <summary>
        /// Lists the versions of a secret. Secrets Manager uses staging labels to indicate the
        /// different versions of a secret. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/getting-started.html#term_version">
        /// Secrets Manager concepts: Versions</a>.
        /// 
        ///  
        /// <para>
        /// To list the secrets in the account, use <a>ListSecrets</a>.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:ListSecretVersionIds</code>. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecretVersionIds service method.</param>
        /// 
        /// <returns>The response from the ListSecretVersionIds service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecretVersionIds">REST API Reference for ListSecretVersionIds Operation</seealso>
        ListSecretVersionIdsResponse ListSecretVersionIds(ListSecretVersionIdsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecretVersionIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecretVersionIds operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecretVersionIds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecretVersionIds">REST API Reference for ListSecretVersionIds Operation</seealso>
        IAsyncResult BeginListSecretVersionIds(ListSecretVersionIdsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecretVersionIds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecretVersionIds.</param>
        /// 
        /// <returns>Returns a  ListSecretVersionIdsResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecretVersionIds">REST API Reference for ListSecretVersionIds Operation</seealso>
        ListSecretVersionIdsResponse EndListSecretVersionIds(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Attaches a resource-based permission policy to a secret. A resource-based policy is
        /// optional. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control for Secrets Manager</a> 
        /// 
        ///  
        /// <para>
        /// For information about attaching a policy in the console, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_resource-based-policies.html">Attach
        /// a permissions policy to a secret</a>.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:PutResourcePolicy</code>. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.MalformedPolicyDocumentException">
        /// The resource policy has syntax errors.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.PublicPolicyException">
        /// The <code>BlockPublicPolicy</code> parameter is set to true, and the resource policy
        /// did not prevent broad access to the secret.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutSecretValue


        /// <summary>
        /// Creates a new version with a new encrypted secret value and attaches it to the secret.
        /// The version can contain a new <code>SecretString</code> value or a new <code>SecretBinary</code>
        /// value. 
        /// 
        ///  
        /// <para>
        /// We recommend you avoid calling <code>PutSecretValue</code> at a sustained rate of
        /// more than once every 10 minutes. When you update the secret value, Secrets Manager
        /// creates a new version of the secret. Secrets Manager removes outdated versions when
        /// there are more than 100, but it does not remove versions created less than 24 hours
        /// ago. If you call <code>PutSecretValue</code> more than once every 10 minutes, you
        /// create more versions than Secrets Manager removes, and you will reach the quota for
        /// secret versions.
        /// </para>
        ///  
        /// <para>
        /// You can specify the staging labels to attach to the new version in <code>VersionStages</code>.
        /// If you don't include <code>VersionStages</code>, then Secrets Manager automatically
        /// moves the staging label <code>AWSCURRENT</code> to this version. If this operation
        /// creates the first version for the secret, then Secrets Manager automatically attaches
        /// the staging label <code>AWSCURRENT</code> to it. If this operation moves the staging
        /// label <code>AWSCURRENT</code> from another version to this version, then Secrets Manager
        /// also automatically moves the staging label <code>AWSPREVIOUS</code> to the version
        /// that <code>AWSCURRENT</code> was removed from.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent. If you call this operation with a <code>ClientRequestToken</code>
        /// that matches an existing version's VersionId, and you specify the same secret data,
        /// the operation succeeds but does nothing. However, if the secret data is different,
        /// then the operation fails because you can't modify an existing version; you can only
        /// create new ones.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters except <code>SecretBinary</code>
        /// or <code>SecretString</code> because it might be logged. For more information, see
        /// <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:PutSecretValue</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSecretValue service method.</param>
        /// 
        /// <returns>The response from the PutSecretValue service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.DecryptionFailureException">
        /// Secrets Manager can't decrypt the protected secret text using the provided KMS key.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.EncryptionFailureException">
        /// Secrets Manager can't encrypt the protected secret text using the provided KMS key.
        /// Check that the KMS key is available, enabled, and not in an invalid state. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a>.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.LimitExceededException">
        /// The request failed because it would exceed one of the Secrets Manager quotas.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceExistsException">
        /// A resource with the ID you requested already exists.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutSecretValue">REST API Reference for PutSecretValue Operation</seealso>
        PutSecretValueResponse PutSecretValue(PutSecretValueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutSecretValue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSecretValue operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSecretValue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutSecretValue">REST API Reference for PutSecretValue Operation</seealso>
        IAsyncResult BeginPutSecretValue(PutSecretValueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutSecretValue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSecretValue.</param>
        /// 
        /// <returns>Returns a  PutSecretValueResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutSecretValue">REST API Reference for PutSecretValue Operation</seealso>
        PutSecretValueResponse EndPutSecretValue(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveRegionsFromReplication


        /// <summary>
        /// For a secret that is replicated to other Regions, deletes the secret replicas from
        /// the Regions you specify.
        /// 
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:RemoveRegionsFromReplication</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRegionsFromReplication service method.</param>
        /// 
        /// <returns>The response from the RemoveRegionsFromReplication service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RemoveRegionsFromReplication">REST API Reference for RemoveRegionsFromReplication Operation</seealso>
        RemoveRegionsFromReplicationResponse RemoveRegionsFromReplication(RemoveRegionsFromReplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRegionsFromReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRegionsFromReplication operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveRegionsFromReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RemoveRegionsFromReplication">REST API Reference for RemoveRegionsFromReplication Operation</seealso>
        IAsyncResult BeginRemoveRegionsFromReplication(RemoveRegionsFromReplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveRegionsFromReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRegionsFromReplication.</param>
        /// 
        /// <returns>Returns a  RemoveRegionsFromReplicationResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RemoveRegionsFromReplication">REST API Reference for RemoveRegionsFromReplication Operation</seealso>
        RemoveRegionsFromReplicationResponse EndRemoveRegionsFromReplication(IAsyncResult asyncResult);

        #endregion
        
        #region  ReplicateSecretToRegions


        /// <summary>
        /// Replicates the secret to a new Regions. See <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/create-manage-multi-region-secrets.html">Multi-Region
        /// secrets</a>.
        /// 
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:ReplicateSecretToRegions</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplicateSecretToRegions service method.</param>
        /// 
        /// <returns>The response from the ReplicateSecretToRegions service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ReplicateSecretToRegions">REST API Reference for ReplicateSecretToRegions Operation</seealso>
        ReplicateSecretToRegionsResponse ReplicateSecretToRegions(ReplicateSecretToRegionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplicateSecretToRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplicateSecretToRegions operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplicateSecretToRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ReplicateSecretToRegions">REST API Reference for ReplicateSecretToRegions Operation</seealso>
        IAsyncResult BeginReplicateSecretToRegions(ReplicateSecretToRegionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReplicateSecretToRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplicateSecretToRegions.</param>
        /// 
        /// <returns>Returns a  ReplicateSecretToRegionsResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ReplicateSecretToRegions">REST API Reference for ReplicateSecretToRegions Operation</seealso>
        ReplicateSecretToRegionsResponse EndReplicateSecretToRegions(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreSecret


        /// <summary>
        /// Cancels the scheduled deletion of a secret by removing the <code>DeletedDate</code>
        /// time stamp. You can access a secret again after it has been restored.
        /// 
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:RestoreSecret</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreSecret service method.</param>
        /// 
        /// <returns>The response from the RestoreSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RestoreSecret">REST API Reference for RestoreSecret Operation</seealso>
        RestoreSecretResponse RestoreSecret(RestoreSecretRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreSecret operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreSecret
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RestoreSecret">REST API Reference for RestoreSecret Operation</seealso>
        IAsyncResult BeginRestoreSecret(RestoreSecretRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreSecret operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreSecret.</param>
        /// 
        /// <returns>Returns a  RestoreSecretResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RestoreSecret">REST API Reference for RestoreSecret Operation</seealso>
        RestoreSecretResponse EndRestoreSecret(IAsyncResult asyncResult);

        #endregion
        
        #region  RotateSecret


        /// <summary>
        /// Configures and starts the asynchronous process of rotating the secret. For more information
        /// about rotation, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotating-secrets.html">Rotate
        /// secrets</a>.
        /// 
        ///  
        /// <para>
        /// If you include the configuration parameters, the operation sets the values for the
        /// secret and then immediately starts a rotation. If you don't include the configuration
        /// parameters, the operation starts a rotation with the values already stored in the
        /// secret. 
        /// </para>
        ///  
        /// <para>
        /// For database credentials you want to rotate, for Secrets Manager to be able to rotate
        /// the secret, you must make sure the secret value is in the <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_secret_json_structure.html">
        /// JSON structure of a database secret</a>. In particular, if you want to use the <a
        /// href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotating-secrets_strategies.html#rotating-secrets-two-users">
        /// alternating users strategy</a>, your secret must contain the ARN of a superuser secret.
        /// </para>
        ///  
        /// <para>
        /// To configure rotation, you also need the ARN of an Amazon Web Services Lambda function
        /// and the schedule for the rotation. The Lambda rotation function creates a new version
        /// of the secret and creates or updates the credentials on the database or service to
        /// match. After testing the new credentials, the function marks the new secret version
        /// with the staging label <code>AWSCURRENT</code>. Then anyone who retrieves the secret
        /// gets the new version. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotate-secrets_how.html">How
        /// rotation works</a>.
        /// </para>
        ///  
        /// <para>
        /// You can create the Lambda rotation function based on the <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_available-rotation-templates.html">rotation
        /// function templates</a> that Secrets Manager provides. Choose a template that matches
        /// your <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotating-secrets_strategies.html">Rotation
        /// strategy</a>.
        /// </para>
        ///  
        /// <para>
        /// When rotation is successful, the <code>AWSPENDING</code> staging label might be attached
        /// to the same version as the <code>AWSCURRENT</code> version, or it might not be attached
        /// to any version. If the <code>AWSPENDING</code> staging label is present but not attached
        /// to the same version as <code>AWSCURRENT</code>, then any later invocation of <code>RotateSecret</code>
        /// assumes that a previous rotation request is still in progress and returns an error.
        /// </para>
        ///  
        /// <para>
        /// When rotation is unsuccessful, the <code>AWSPENDING</code> staging label might be
        /// attached to an empty secret version. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/troubleshoot_rotation.html">Troubleshoot
        /// rotation</a> in the <i>Secrets Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:RotateSecret</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. You also need <code>lambda:InvokeFunction</code>
        /// permissions on the rotation function. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotating-secrets-required-permissions-function.html">
        /// Permissions for rotation</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateSecret service method.</param>
        /// 
        /// <returns>The response from the RotateSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RotateSecret">REST API Reference for RotateSecret Operation</seealso>
        RotateSecretResponse RotateSecret(RotateSecretRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RotateSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateSecret operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRotateSecret
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RotateSecret">REST API Reference for RotateSecret Operation</seealso>
        IAsyncResult BeginRotateSecret(RotateSecretRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RotateSecret operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRotateSecret.</param>
        /// 
        /// <returns>Returns a  RotateSecretResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RotateSecret">REST API Reference for RotateSecret Operation</seealso>
        RotateSecretResponse EndRotateSecret(IAsyncResult asyncResult);

        #endregion
        
        #region  StopReplicationToReplica


        /// <summary>
        /// Removes the link between the replica secret and the primary secret and promotes the
        /// replica to a primary secret in the replica Region.
        /// 
        ///  
        /// <para>
        /// You must call this operation from the Region in which you want to promote the replica
        /// to a primary secret.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:StopReplicationToReplica</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationToReplica service method.</param>
        /// 
        /// <returns>The response from the StopReplicationToReplica service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/StopReplicationToReplica">REST API Reference for StopReplicationToReplica Operation</seealso>
        StopReplicationToReplicaResponse StopReplicationToReplica(StopReplicationToReplicaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopReplicationToReplica operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationToReplica operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopReplicationToReplica
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/StopReplicationToReplica">REST API Reference for StopReplicationToReplica Operation</seealso>
        IAsyncResult BeginStopReplicationToReplica(StopReplicationToReplicaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopReplicationToReplica operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopReplicationToReplica.</param>
        /// 
        /// <returns>Returns a  StopReplicationToReplicaResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/StopReplicationToReplica">REST API Reference for StopReplicationToReplica Operation</seealso>
        StopReplicationToReplicaResponse EndStopReplicationToReplica(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Attaches tags to a secret. Tags consist of a key name and a value. Tags are part of
        /// the secret's metadata. They are not associated with specific versions of the secret.
        /// This operation appends tags to the existing list of tags.
        /// 
        ///  
        /// <para>
        /// The following restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per secret: 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length: 127 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length: 255 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use the <code>aws:</code> prefix in your tag names or values because Amazon
        /// Web Services reserves it for Amazon Web Services use. You can't edit or delete tag
        /// names or values with this prefix. Tags with this prefix do not count against your
        /// tags per secret limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use your tagging schema across multiple services and resources, other services
        /// might have restrictions on allowed characters. Generally allowed characters: letters,
        /// spaces, and numbers representable in UTF-8, plus the following special characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// If you use tags as part of your security strategy, then adding or removing a tag can
        /// change permissions. If successfully completing this operation would result in you
        /// losing your permissions for this secret, then the operation is blocked and returns
        /// an Access Denied error.
        /// </para>
        ///  </important> 
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:TagResource</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes specific tags from a secret.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent. If a requested tag is not attached to the secret, no
        /// error is returned and the secret metadata is unchanged.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you use tags as part of your security strategy, then removing a tag can change
        /// permissions. If successfully completing this operation would result in you losing
        /// your permissions for this secret, then the operation is blocked and returns an Access
        /// Denied error.
        /// </para>
        ///  </important> 
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:UntagResource</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSecret


        /// <summary>
        /// Modifies the details of a secret, including metadata and the secret value. To change
        /// the secret value, you can also use <a>PutSecretValue</a>.
        /// 
        ///  
        /// <para>
        /// To change the rotation configuration of a secret, use <a>RotateSecret</a> instead.
        /// </para>
        ///  
        /// <para>
        /// We recommend you avoid calling <code>UpdateSecret</code> at a sustained rate of more
        /// than once every 10 minutes. When you call <code>UpdateSecret</code> to update the
        /// secret value, Secrets Manager creates a new version of the secret. Secrets Manager
        /// removes outdated versions when there are more than 100, but it does not remove versions
        /// created less than 24 hours ago. If you update the secret value more than once every
        /// 10 minutes, you create more versions than Secrets Manager removes, and you will reach
        /// the quota for secret versions.
        /// </para>
        ///  
        /// <para>
        /// If you include <code>SecretString</code> or <code>SecretBinary</code> to create a
        /// new secret version, Secrets Manager automatically moves the staging label <code>AWSCURRENT</code>
        /// to the new version. Then it attaches the label <code>AWSPREVIOUS</code> to the version
        /// that <code>AWSCURRENT</code> was removed from.
        /// </para>
        ///  
        /// <para>
        /// If you call this operation with a <code>ClientRequestToken</code> that matches an
        /// existing version's <code>VersionId</code>, the operation results in an error. You
        /// can't modify an existing version, you can only create a new version. To remove a version,
        /// remove all staging labels from it. See <a>UpdateSecretVersionStage</a>.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters except <code>SecretBinary</code>
        /// or <code>SecretString</code> because it might be logged. For more information, see
        /// <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:UpdateSecret</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. If you use a customer managed key, you
        /// must also have <code>kms:GenerateDataKey</code> and <code>kms:Decrypt</code> permissions
        /// on the key. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/security-encryption.html">
        /// Secret encryption and decryption</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecret service method.</param>
        /// 
        /// <returns>The response from the UpdateSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.DecryptionFailureException">
        /// Secrets Manager can't decrypt the protected secret text using the provided KMS key.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.EncryptionFailureException">
        /// Secrets Manager can't encrypt the protected secret text using the provided KMS key.
        /// Check that the KMS key is available, enabled, and not in an invalid state. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a>.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.LimitExceededException">
        /// The request failed because it would exceed one of the Secrets Manager quotas.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.MalformedPolicyDocumentException">
        /// The resource policy has syntax errors.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.PreconditionNotMetException">
        /// The request failed because you did not complete all the prerequisite steps.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceExistsException">
        /// A resource with the ID you requested already exists.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UpdateSecret">REST API Reference for UpdateSecret Operation</seealso>
        UpdateSecretResponse UpdateSecret(UpdateSecretRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecret operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecret
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UpdateSecret">REST API Reference for UpdateSecret Operation</seealso>
        IAsyncResult BeginUpdateSecret(UpdateSecretRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecret operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecret.</param>
        /// 
        /// <returns>Returns a  UpdateSecretResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UpdateSecret">REST API Reference for UpdateSecret Operation</seealso>
        UpdateSecretResponse EndUpdateSecret(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSecretVersionStage


        /// <summary>
        /// Modifies the staging labels attached to a version of a secret. Secrets Manager uses
        /// staging labels to track a version as it progresses through the secret rotation process.
        /// Each staging label can be attached to only one version at a time. To add a staging
        /// label to a version when it is already attached to another version, Secrets Manager
        /// first removes it from the other version first and then attaches it to this one. For
        /// more information about versions and staging labels, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/getting-started.html#term_version">Concepts:
        /// Version</a>. 
        /// 
        ///  
        /// <para>
        /// The staging labels that you specify in the <code>VersionStage</code> parameter are
        /// added to the existing list of staging labels for the version. 
        /// </para>
        ///  
        /// <para>
        /// You can move the <code>AWSCURRENT</code> staging label to this version by including
        /// it in this call.
        /// </para>
        ///  <note> 
        /// <para>
        /// Whenever you move <code>AWSCURRENT</code>, Secrets Manager automatically moves the
        /// label <code>AWSPREVIOUS</code> to the version that <code>AWSCURRENT</code> was removed
        /// from.
        /// </para>
        ///  </note> 
        /// <para>
        /// If this action results in the last label being removed from a version, then the version
        /// is considered to be 'deprecated' and can be deleted by Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:UpdateSecretVersionStage</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecretVersionStage service method.</param>
        /// 
        /// <returns>The response from the UpdateSecretVersionStage service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.LimitExceededException">
        /// The request failed because it would exceed one of the Secrets Manager quotas.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UpdateSecretVersionStage">REST API Reference for UpdateSecretVersionStage Operation</seealso>
        UpdateSecretVersionStageResponse UpdateSecretVersionStage(UpdateSecretVersionStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecretVersionStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecretVersionStage operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecretVersionStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UpdateSecretVersionStage">REST API Reference for UpdateSecretVersionStage Operation</seealso>
        IAsyncResult BeginUpdateSecretVersionStage(UpdateSecretVersionStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecretVersionStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecretVersionStage.</param>
        /// 
        /// <returns>Returns a  UpdateSecretVersionStageResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UpdateSecretVersionStage">REST API Reference for UpdateSecretVersionStage Operation</seealso>
        UpdateSecretVersionStageResponse EndUpdateSecretVersionStage(IAsyncResult asyncResult);

        #endregion
        
        #region  ValidateResourcePolicy


        /// <summary>
        /// Validates that a resource policy does not grant a wide range of principals access
        /// to your secret. A resource-based policy is optional for secrets.
        /// 
        ///  
        /// <para>
        /// The API performs three checks when validating the policy:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sends a call to <a href="https://aws.amazon.com/blogs/security/protect-sensitive-data-in-the-cloud-with-automated-reasoning-zelkova/">Zelkova</a>,
        /// an automated reasoning engine, to ensure your resource policy does not allow broad
        /// access to your secret, for example policies that use a wildcard for the principal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Checks for correct syntax in a policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Verifies the policy does not lock out a caller.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters because it might be logged. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>secretsmanager:ValidateResourcePolicy</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the ValidateResourcePolicy service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// A parameter value is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The secret is scheduled for deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret is managed by another service, and you must use that service to update
        /// it. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.MalformedPolicyDocumentException">
        /// The resource policy has syntax errors.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ValidateResourcePolicy">REST API Reference for ValidateResourcePolicy Operation</seealso>
        ValidateResourcePolicyResponse ValidateResourcePolicy(ValidateResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateResourcePolicy operation on AmazonSecretsManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ValidateResourcePolicy">REST API Reference for ValidateResourcePolicy Operation</seealso>
        IAsyncResult BeginValidateResourcePolicy(ValidateResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateResourcePolicy.</param>
        /// 
        /// <returns>Returns a  ValidateResourcePolicyResult from SecretsManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ValidateResourcePolicy">REST API Reference for ValidateResourcePolicy Operation</seealso>
        ValidateResourcePolicyResponse EndValidateResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
    }
}