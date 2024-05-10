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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SecretsManager.Model;
using Amazon.SecretsManager.Model.Internal.MarshallTransformations;
using Amazon.SecretsManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.SecretsManager
{
    /// <summary>
    /// <para>Implementation for accessing SecretsManager</para>
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
    /// For a list of endpoints, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/asm_access.html#endpoints">Amazon
    /// Web Services Secrets Manager endpoints</a>.
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
    public partial class AmazonSecretsManagerClient : AmazonServiceClient, IAmazonSecretsManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecretsManagerMetadata();
        private ISecretsManagerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISecretsManagerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SecretsManagerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSecretsManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecretsManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSecretsManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecretsManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSecretsManagerClient Configuration Object</param>
        public AmazonSecretsManagerClient(AmazonSecretsManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecretsManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecretsManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecretsManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSecretsManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Credentials and an
        /// AmazonSecretsManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecretsManagerClient Configuration Object</param>
        public AmazonSecretsManagerClient(AWSCredentials credentials, AmazonSecretsManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecretsManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecretsManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecretsManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecretsManagerClient Configuration Object</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecretsManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecretsManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecretsManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecretsManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSecretsManagerClient Configuration Object</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecretsManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecretsManagerEndpointResolver());
        }    
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  BatchGetSecretValue


        /// <summary>
        /// Retrieves the contents of the encrypted fields <c>SecretString</c> or <c>SecretBinary</c>
        /// for up to 20 secrets. To retrieve a single secret, call <a>GetSecretValue</a>. 
        /// 
        ///  
        /// <para>
        /// To choose which secrets to retrieve, you can specify a list of secrets by name or
        /// ARN, or you can use filters. If Secrets Manager encounters errors such as <c>AccessDeniedException</c>
        /// while attempting to retrieve any of the secrets, you can see the errors in <c>Errors</c>
        /// in the response.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates CloudTrail <c>GetSecretValue</c> log entries for each secret
        /// you request when you call this action. Do not include sensitive information in request
        /// parameters because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>secretsmanager:BatchGetSecretValue</c>, and you
        /// must have <c>secretsmanager:GetSecretValue</c> for each secret. If you use filters,
        /// you must also have <c>secretsmanager:ListSecrets</c>. If the secrets are encrypted
        /// using customer-managed keys instead of the Amazon Web Services managed key <c>aws/secretsmanager</c>,
        /// then you also need <c>kms:Decrypt</c> permissions for the keys. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSecretValue service method.</param>
        /// 
        /// <returns>The response from the BatchGetSecretValue service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.DecryptionFailureException">
        /// Secrets Manager can't decrypt the protected secret text using the provided KMS key.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/BatchGetSecretValue">REST API Reference for BatchGetSecretValue Operation</seealso>
        public virtual BatchGetSecretValueResponse BatchGetSecretValue(BatchGetSecretValueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetSecretValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSecretValueResponseUnmarshaller.Instance;

            return Invoke<BatchGetSecretValueResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the contents of the encrypted fields <c>SecretString</c> or <c>SecretBinary</c>
        /// for up to 20 secrets. To retrieve a single secret, call <a>GetSecretValue</a>. 
        /// 
        ///  
        /// <para>
        /// To choose which secrets to retrieve, you can specify a list of secrets by name or
        /// ARN, or you can use filters. If Secrets Manager encounters errors such as <c>AccessDeniedException</c>
        /// while attempting to retrieve any of the secrets, you can see the errors in <c>Errors</c>
        /// in the response.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates CloudTrail <c>GetSecretValue</c> log entries for each secret
        /// you request when you call this action. Do not include sensitive information in request
        /// parameters because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>secretsmanager:BatchGetSecretValue</c>, and you
        /// must have <c>secretsmanager:GetSecretValue</c> for each secret. If you use filters,
        /// you must also have <c>secretsmanager:ListSecrets</c>. If the secrets are encrypted
        /// using customer-managed keys instead of the Amazon Web Services managed key <c>aws/secretsmanager</c>,
        /// then you also need <c>kms:Decrypt</c> permissions for the keys. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSecretValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetSecretValue service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.DecryptionFailureException">
        /// Secrets Manager can't decrypt the protected secret text using the provided KMS key.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/BatchGetSecretValue">REST API Reference for BatchGetSecretValue Operation</seealso>
        public virtual Task<BatchGetSecretValueResponse> BatchGetSecretValueAsync(BatchGetSecretValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetSecretValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSecretValueResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetSecretValueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelRotateSecret


        /// <summary>
        /// Turns off automatic rotation, and if a rotation is currently in progress, cancels
        /// the rotation.
        /// 
        ///  
        /// <para>
        /// If you cancel a rotation in progress, it can leave the <c>VersionStage</c> labels
        /// in an unexpected state. You might need to remove the staging label <c>AWSPENDING</c>
        /// from the partially created version. You also need to determine whether to roll back
        /// to the previous version of the secret by moving the staging label <c>AWSCURRENT</c>
        /// to the version that has <c>AWSPENDING</c>. To determine which version has a specific
        /// staging label, call <a>ListSecretVersionIds</a>. Then use <a>UpdateSecretVersionStage</a>
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
        ///  <b>Required permissions: </b> <c>secretsmanager:CancelRotateSecret</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual CancelRotateSecretResponse CancelRotateSecret(CancelRotateSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelRotateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRotateSecretResponseUnmarshaller.Instance;

            return Invoke<CancelRotateSecretResponse>(request, options);
        }


        /// <summary>
        /// Turns off automatic rotation, and if a rotation is currently in progress, cancels
        /// the rotation.
        /// 
        ///  
        /// <para>
        /// If you cancel a rotation in progress, it can leave the <c>VersionStage</c> labels
        /// in an unexpected state. You might need to remove the staging label <c>AWSPENDING</c>
        /// from the partially created version. You also need to determine whether to roll back
        /// to the previous version of the secret by moving the staging label <c>AWSCURRENT</c>
        /// to the version that has <c>AWSPENDING</c>. To determine which version has a specific
        /// staging label, call <a>ListSecretVersionIds</a>. Then use <a>UpdateSecretVersionStage</a>
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
        ///  <b>Required permissions: </b> <c>secretsmanager:CancelRotateSecret</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRotateSecret service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelRotateSecretResponse> CancelRotateSecretAsync(CancelRotateSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelRotateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRotateSecretResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelRotateSecretResponse>(request, options, cancellationToken);
        }

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
        /// For secrets that use <i>managed rotation</i>, you need to create the secret through
        /// the managing service. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// Manager secrets managed by other Amazon Web Services services</a>. 
        /// </para>
        ///  
        /// <para>
        /// For information about creating a secret in the console, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/manage_create-basic-secret.html">Create
        /// a secret</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a secret, you can provide the secret value to be encrypted in either the
        /// <c>SecretString</c> parameter or the <c>SecretBinary</c> parameter, but not both.
        /// If you include <c>SecretString</c> or <c>SecretBinary</c> then Secrets Manager creates
        /// an initial secret version and automatically attaches the staging label <c>AWSCURRENT</c>
        /// to it.
        /// </para>
        ///  
        /// <para>
        /// For database credentials you want to rotate, for Secrets Manager to be able to rotate
        /// the secret, you must make sure the JSON you store in the <c>SecretString</c> matches
        /// the <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_secret_json_structure.html">JSON
        /// structure of a database secret</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an KMS encryption key, Secrets Manager uses the Amazon Web Services
        /// managed key <c>aws/secretsmanager</c>. If this key doesn't already exist in your account,
        /// then Secrets Manager creates it for you automatically. All users and roles in the
        /// Amazon Web Services account automatically have access to use <c>aws/secretsmanager</c>.
        /// Creating <c>aws/secretsmanager</c> can result in a one-time significant delay in returning
        /// the result.
        /// </para>
        ///  
        /// <para>
        /// If the secret is in a different Amazon Web Services account from the credentials calling
        /// the API, then you can't use <c>aws/secretsmanager</c> to encrypt the secret, and you
        /// must create and use a customer managed KMS key. 
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters except <c>SecretBinary</c> or
        /// <c>SecretString</c> because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>secretsmanager:CreateSecret</c>. If you include
        /// tags in the secret, you also need <c>secretsmanager:TagResource</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        ///  
        /// <para>
        /// To encrypt the secret with a KMS key other than <c>aws/secretsmanager</c>, you need
        /// <c>kms:GenerateDataKey</c> and <c>kms:Decrypt</c> permission to the key. 
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
        public virtual CreateSecretResponse CreateSecret(CreateSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecretResponseUnmarshaller.Instance;

            return Invoke<CreateSecretResponse>(request, options);
        }


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
        /// For secrets that use <i>managed rotation</i>, you need to create the secret through
        /// the managing service. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// Manager secrets managed by other Amazon Web Services services</a>. 
        /// </para>
        ///  
        /// <para>
        /// For information about creating a secret in the console, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/manage_create-basic-secret.html">Create
        /// a secret</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a secret, you can provide the secret value to be encrypted in either the
        /// <c>SecretString</c> parameter or the <c>SecretBinary</c> parameter, but not both.
        /// If you include <c>SecretString</c> or <c>SecretBinary</c> then Secrets Manager creates
        /// an initial secret version and automatically attaches the staging label <c>AWSCURRENT</c>
        /// to it.
        /// </para>
        ///  
        /// <para>
        /// For database credentials you want to rotate, for Secrets Manager to be able to rotate
        /// the secret, you must make sure the JSON you store in the <c>SecretString</c> matches
        /// the <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_secret_json_structure.html">JSON
        /// structure of a database secret</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an KMS encryption key, Secrets Manager uses the Amazon Web Services
        /// managed key <c>aws/secretsmanager</c>. If this key doesn't already exist in your account,
        /// then Secrets Manager creates it for you automatically. All users and roles in the
        /// Amazon Web Services account automatically have access to use <c>aws/secretsmanager</c>.
        /// Creating <c>aws/secretsmanager</c> can result in a one-time significant delay in returning
        /// the result.
        /// </para>
        ///  
        /// <para>
        /// If the secret is in a different Amazon Web Services account from the credentials calling
        /// the API, then you can't use <c>aws/secretsmanager</c> to encrypt the secret, and you
        /// must create and use a customer managed KMS key. 
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters except <c>SecretBinary</c> or
        /// <c>SecretString</c> because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>secretsmanager:CreateSecret</c>. If you include
        /// tags in the secret, you also need <c>secretsmanager:TagResource</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        ///  
        /// <para>
        /// To encrypt the secret with a KMS key other than <c>aws/secretsmanager</c>, you need
        /// <c>kms:GenerateDataKey</c> and <c>kms:Decrypt</c> permission to the key. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecret service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecretResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSecretResponse>(request, options, cancellationToken);
        }

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
        ///  <b>Required permissions: </b> <c>secretsmanager:DeleteResourcePolicy</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }


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
        ///  <b>Required permissions: </b> <c>secretsmanager:DeleteResourcePolicy</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecret


        /// <summary>
        /// Deletes a secret and all of its versions. You can specify a recovery window during
        /// which you can restore the secret. The minimum recovery window is 7 days. The default
        /// recovery window is 30 days. Secrets Manager attaches a <c>DeletionDate</c> stamp to
        /// the secret that specifies the end of the recovery window. At the end of the recovery
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
        /// the <c>DeletionDate</c> and cancel the deletion of the secret.
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
        ///  <b>Required permissions: </b> <c>secretsmanager:DeleteSecret</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual DeleteSecretResponse DeleteSecret(DeleteSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecretResponseUnmarshaller.Instance;

            return Invoke<DeleteSecretResponse>(request, options);
        }


        /// <summary>
        /// Deletes a secret and all of its versions. You can specify a recovery window during
        /// which you can restore the secret. The minimum recovery window is 7 days. The default
        /// recovery window is 30 days. Secrets Manager attaches a <c>DeletionDate</c> stamp to
        /// the secret that specifies the end of the recovery window. At the end of the recovery
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
        /// the <c>DeletionDate</c> and cancel the deletion of the secret.
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
        ///  <b>Required permissions: </b> <c>secretsmanager:DeleteSecret</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecret service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteSecretResponse> DeleteSecretAsync(DeleteSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecretResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSecretResponse>(request, options, cancellationToken);
        }

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
        ///  <b>Required permissions: </b> <c>secretsmanager:DescribeSecret</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual DescribeSecretResponse DescribeSecret(DescribeSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecretResponseUnmarshaller.Instance;

            return Invoke<DescribeSecretResponse>(request, options);
        }


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
        ///  <b>Required permissions: </b> <c>secretsmanager:DescribeSecret</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecret service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeSecretResponse> DescribeSecretAsync(DescribeSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecretResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSecretResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRandomPassword


        /// <summary>
        /// Generates a random password. We recommend that you specify the maximum length and
        /// include every character type that the system you are generating a password for can
        /// support. By default, Secrets Manager uses uppercase and lowercase letters, numbers,
        /// and the following characters in passwords: <c>!\"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\\]^_`{|}~</c>
        /// 
        /// 
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>secretsmanager:GetRandomPassword</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual GetRandomPasswordResponse GetRandomPassword(GetRandomPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRandomPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRandomPasswordResponseUnmarshaller.Instance;

            return Invoke<GetRandomPasswordResponse>(request, options);
        }


        /// <summary>
        /// Generates a random password. We recommend that you specify the maximum length and
        /// include every character type that the system you are generating a password for can
        /// support. By default, Secrets Manager uses uppercase and lowercase letters, numbers,
        /// and the following characters in passwords: <c>!\"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\\]^_`{|}~</c>
        /// 
        /// 
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>secretsmanager:GetRandomPassword</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRandomPassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetRandomPasswordResponse> GetRandomPasswordAsync(GetRandomPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRandomPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRandomPasswordResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRandomPasswordResponse>(request, options, cancellationToken);
        }

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
        ///  <b>Required permissions: </b> <c>secretsmanager:GetResourcePolicy</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }


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
        ///  <b>Required permissions: </b> <c>secretsmanager:GetResourcePolicy</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSecretValue


        /// <summary>
        /// Retrieves the contents of the encrypted fields <c>SecretString</c> or <c>SecretBinary</c>
        /// from the specified version of a secret, whichever contains content.
        /// 
        ///  
        /// <para>
        /// To retrieve the values for a group of secrets, call <a>BatchGetSecretValue</a>.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you cache your secret values by using client-side caching. Caching
        /// secrets improves speed and reduces your costs. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieving-secrets.html">Cache
        /// secrets for your applications</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the previous version of a secret, use <c>VersionStage</c> and specify
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
        ///  <b>Required permissions: </b> <c>secretsmanager:GetSecretValue</c>. If the secret
        /// is encrypted using a customer-managed key instead of the Amazon Web Services managed
        /// key <c>aws/secretsmanager</c>, then you also need <c>kms:Decrypt</c> permissions for
        /// that key. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual GetSecretValueResponse GetSecretValue(GetSecretValueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecretValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecretValueResponseUnmarshaller.Instance;

            return Invoke<GetSecretValueResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the contents of the encrypted fields <c>SecretString</c> or <c>SecretBinary</c>
        /// from the specified version of a secret, whichever contains content.
        /// 
        ///  
        /// <para>
        /// To retrieve the values for a group of secrets, call <a>BatchGetSecretValue</a>.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you cache your secret values by using client-side caching. Caching
        /// secrets improves speed and reduces your costs. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieving-secrets.html">Cache
        /// secrets for your applications</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the previous version of a secret, use <c>VersionStage</c> and specify
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
        ///  <b>Required permissions: </b> <c>secretsmanager:GetSecretValue</c>. If the secret
        /// is encrypted using a customer-managed key instead of the Amazon Web Services managed
        /// key <c>aws/secretsmanager</c>, then you also need <c>kms:Decrypt</c> permissions for
        /// that key. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecretValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetSecretValueResponse> GetSecretValueAsync(GetSecretValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecretValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecretValueResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSecretValueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSecrets


        /// <summary>
        /// Lists the secrets that are stored by Secrets Manager in the Amazon Web Services account,
        /// not including secrets that are marked for deletion. To see secrets marked for deletion,
        /// use the Secrets Manager console.
        /// 
        ///  
        /// <para>
        /// All Secrets Manager operations are eventually consistent. ListSecrets might not reflect
        /// changes from the last five minutes. You can get more recent information for a specific
        /// secret by calling <a>DescribeSecret</a>.
        /// </para>
        ///  
        /// <para>
        /// To list the versions of a secret, use <a>ListSecretVersionIds</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the values for the secrets, call <a>BatchGetSecretValue</a> or <a>GetSecretValue</a>.
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
        ///  <b>Required permissions: </b> <c>secretsmanager:ListSecrets</c>. For more information,
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
        /// The <c>NextToken</c> value is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecrets">REST API Reference for ListSecrets Operation</seealso>
        public virtual ListSecretsResponse ListSecrets(ListSecretsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecretsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecretsResponseUnmarshaller.Instance;

            return Invoke<ListSecretsResponse>(request, options);
        }


        /// <summary>
        /// Lists the secrets that are stored by Secrets Manager in the Amazon Web Services account,
        /// not including secrets that are marked for deletion. To see secrets marked for deletion,
        /// use the Secrets Manager console.
        /// 
        ///  
        /// <para>
        /// All Secrets Manager operations are eventually consistent. ListSecrets might not reflect
        /// changes from the last five minutes. You can get more recent information for a specific
        /// secret by calling <a>DescribeSecret</a>.
        /// </para>
        ///  
        /// <para>
        /// To list the versions of a secret, use <a>ListSecretVersionIds</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the values for the secrets, call <a>BatchGetSecretValue</a> or <a>GetSecretValue</a>.
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
        ///  <b>Required permissions: </b> <c>secretsmanager:ListSecrets</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecrets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecrets service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecrets">REST API Reference for ListSecrets Operation</seealso>
        public virtual Task<ListSecretsResponse> ListSecretsAsync(ListSecretsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecretsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecretsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSecretsResponse>(request, options, cancellationToken);
        }

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
        ///  <b>Required permissions: </b> <c>secretsmanager:ListSecretVersionIds</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        /// The <c>NextToken</c> value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecretVersionIds">REST API Reference for ListSecretVersionIds Operation</seealso>
        public virtual ListSecretVersionIdsResponse ListSecretVersionIds(ListSecretVersionIdsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecretVersionIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecretVersionIdsResponseUnmarshaller.Instance;

            return Invoke<ListSecretVersionIdsResponse>(request, options);
        }


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
        ///  <b>Required permissions: </b> <c>secretsmanager:ListSecretVersionIds</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecretVersionIds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecretVersionIds service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// The parameter name or value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecretVersionIds">REST API Reference for ListSecretVersionIds Operation</seealso>
        public virtual Task<ListSecretVersionIdsResponse> ListSecretVersionIdsAsync(ListSecretVersionIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecretVersionIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecretVersionIdsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSecretVersionIdsResponse>(request, options, cancellationToken);
        }

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
        ///  <b>Required permissions: </b> <c>secretsmanager:PutResourcePolicy</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        /// The <c>BlockPublicPolicy</c> parameter is set to true, and the resource policy did
        /// not prevent broad access to the secret.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }


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
        ///  <b>Required permissions: </b> <c>secretsmanager:PutResourcePolicy</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The <c>BlockPublicPolicy</c> parameter is set to true, and the resource policy did
        /// not prevent broad access to the secret.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// Secrets Manager can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSecretValue


        /// <summary>
        /// Creates a new version with a new encrypted secret value and attaches it to the secret.
        /// The version can contain a new <c>SecretString</c> value or a new <c>SecretBinary</c>
        /// value. 
        /// 
        ///  
        /// <para>
        /// We recommend you avoid calling <c>PutSecretValue</c> at a sustained rate of more than
        /// once every 10 minutes. When you update the secret value, Secrets Manager creates a
        /// new version of the secret. Secrets Manager removes outdated versions when there are
        /// more than 100, but it does not remove versions created less than 24 hours ago. If
        /// you call <c>PutSecretValue</c> more than once every 10 minutes, you create more versions
        /// than Secrets Manager removes, and you will reach the quota for secret versions.
        /// </para>
        ///  
        /// <para>
        /// You can specify the staging labels to attach to the new version in <c>VersionStages</c>.
        /// If you don't include <c>VersionStages</c>, then Secrets Manager automatically moves
        /// the staging label <c>AWSCURRENT</c> to this version. If this operation creates the
        /// first version for the secret, then Secrets Manager automatically attaches the staging
        /// label <c>AWSCURRENT</c> to it. If this operation moves the staging label <c>AWSCURRENT</c>
        /// from another version to this version, then Secrets Manager also automatically moves
        /// the staging label <c>AWSPREVIOUS</c> to the version that <c>AWSCURRENT</c> was removed
        /// from.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent. If you call this operation with a <c>ClientRequestToken</c>
        /// that matches an existing version's VersionId, and you specify the same secret data,
        /// the operation succeeds but does nothing. However, if the secret data is different,
        /// then the operation fails because you can't modify an existing version; you can only
        /// create new ones.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters except <c>SecretBinary</c> or
        /// <c>SecretString</c> because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>secretsmanager:PutSecretValue</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual PutSecretValueResponse PutSecretValue(PutSecretValueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSecretValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSecretValueResponseUnmarshaller.Instance;

            return Invoke<PutSecretValueResponse>(request, options);
        }


        /// <summary>
        /// Creates a new version with a new encrypted secret value and attaches it to the secret.
        /// The version can contain a new <c>SecretString</c> value or a new <c>SecretBinary</c>
        /// value. 
        /// 
        ///  
        /// <para>
        /// We recommend you avoid calling <c>PutSecretValue</c> at a sustained rate of more than
        /// once every 10 minutes. When you update the secret value, Secrets Manager creates a
        /// new version of the secret. Secrets Manager removes outdated versions when there are
        /// more than 100, but it does not remove versions created less than 24 hours ago. If
        /// you call <c>PutSecretValue</c> more than once every 10 minutes, you create more versions
        /// than Secrets Manager removes, and you will reach the quota for secret versions.
        /// </para>
        ///  
        /// <para>
        /// You can specify the staging labels to attach to the new version in <c>VersionStages</c>.
        /// If you don't include <c>VersionStages</c>, then Secrets Manager automatically moves
        /// the staging label <c>AWSCURRENT</c> to this version. If this operation creates the
        /// first version for the secret, then Secrets Manager automatically attaches the staging
        /// label <c>AWSCURRENT</c> to it. If this operation moves the staging label <c>AWSCURRENT</c>
        /// from another version to this version, then Secrets Manager also automatically moves
        /// the staging label <c>AWSPREVIOUS</c> to the version that <c>AWSCURRENT</c> was removed
        /// from.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent. If you call this operation with a <c>ClientRequestToken</c>
        /// that matches an existing version's VersionId, and you specify the same secret data,
        /// the operation succeeds but does nothing. However, if the secret data is different,
        /// then the operation fails because you can't modify an existing version; you can only
        /// create new ones.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters except <c>SecretBinary</c> or
        /// <c>SecretString</c> because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>secretsmanager:PutSecretValue</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSecretValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<PutSecretValueResponse> PutSecretValueAsync(PutSecretValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSecretValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSecretValueResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutSecretValueResponse>(request, options, cancellationToken);
        }

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
        ///  <b>Required permissions: </b> <c>secretsmanager:RemoveRegionsFromReplication</c>.
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
        public virtual RemoveRegionsFromReplicationResponse RemoveRegionsFromReplication(RemoveRegionsFromReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRegionsFromReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRegionsFromReplicationResponseUnmarshaller.Instance;

            return Invoke<RemoveRegionsFromReplicationResponse>(request, options);
        }


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
        ///  <b>Required permissions: </b> <c>secretsmanager:RemoveRegionsFromReplication</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRegionsFromReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RemoveRegionsFromReplicationResponse> RemoveRegionsFromReplicationAsync(RemoveRegionsFromReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRegionsFromReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRegionsFromReplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveRegionsFromReplicationResponse>(request, options, cancellationToken);
        }

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
        ///  <b>Required permissions: </b> <c>secretsmanager:ReplicateSecretToRegions</c>. If
        /// the primary secret is encrypted with a KMS key other than <c>aws/secretsmanager</c>,
        /// you also need <c>kms:Decrypt</c> permission to the key. To encrypt the replicated
        /// secret with a KMS key other than <c>aws/secretsmanager</c>, you need <c>kms:GenerateDataKey</c>
        /// and <c>kms:Encrypt</c> to the key. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual ReplicateSecretToRegionsResponse ReplicateSecretToRegions(ReplicateSecretToRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplicateSecretToRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplicateSecretToRegionsResponseUnmarshaller.Instance;

            return Invoke<ReplicateSecretToRegionsResponse>(request, options);
        }


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
        ///  <b>Required permissions: </b> <c>secretsmanager:ReplicateSecretToRegions</c>. If
        /// the primary secret is encrypted with a KMS key other than <c>aws/secretsmanager</c>,
        /// you also need <c>kms:Decrypt</c> permission to the key. To encrypt the replicated
        /// secret with a KMS key other than <c>aws/secretsmanager</c>, you need <c>kms:GenerateDataKey</c>
        /// and <c>kms:Encrypt</c> to the key. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplicateSecretToRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ReplicateSecretToRegionsResponse> ReplicateSecretToRegionsAsync(ReplicateSecretToRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplicateSecretToRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplicateSecretToRegionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReplicateSecretToRegionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreSecret


        /// <summary>
        /// Cancels the scheduled deletion of a secret by removing the <c>DeletedDate</c> time
        /// stamp. You can access a secret again after it has been restored.
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
        ///  <b>Required permissions: </b> <c>secretsmanager:RestoreSecret</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual RestoreSecretResponse RestoreSecret(RestoreSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreSecretResponseUnmarshaller.Instance;

            return Invoke<RestoreSecretResponse>(request, options);
        }


        /// <summary>
        /// Cancels the scheduled deletion of a secret by removing the <c>DeletedDate</c> time
        /// stamp. You can access a secret again after it has been restored.
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
        ///  <b>Required permissions: </b> <c>secretsmanager:RestoreSecret</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreSecret service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RestoreSecretResponse> RestoreSecretAsync(RestoreSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreSecretResponseUnmarshaller.Instance;
            
            return InvokeAsync<RestoreSecretResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RotateSecret


        /// <summary>
        /// Configures and starts the asynchronous process of rotating the secret. For information
        /// about rotation, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotating-secrets.html">Rotate
        /// secrets</a> in the <i>Secrets Manager User Guide</i>. If you include the configuration
        /// parameters, the operation sets the values for the secret and then immediately starts
        /// a rotation. If you don't include the configuration parameters, the operation starts
        /// a rotation with the values already stored in the secret. 
        /// 
        ///  
        /// <para>
        /// When rotation is successful, the <c>AWSPENDING</c> staging label might be attached
        /// to the same version as the <c>AWSCURRENT</c> version, or it might not be attached
        /// to any version. If the <c>AWSPENDING</c> staging label is present but not attached
        /// to the same version as <c>AWSCURRENT</c>, then any later invocation of <c>RotateSecret</c>
        /// assumes that a previous rotation request is still in progress and returns an error.
        /// When rotation is unsuccessful, the <c>AWSPENDING</c> staging label might be attached
        /// to an empty secret version. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/troubleshoot_rotation.html">Troubleshoot
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
        ///  <b>Required permissions: </b> <c>secretsmanager:RotateSecret</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. You also need <c>lambda:InvokeFunction</c>
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
        public virtual RotateSecretResponse RotateSecret(RotateSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateSecretResponseUnmarshaller.Instance;

            return Invoke<RotateSecretResponse>(request, options);
        }


        /// <summary>
        /// Configures and starts the asynchronous process of rotating the secret. For information
        /// about rotation, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotating-secrets.html">Rotate
        /// secrets</a> in the <i>Secrets Manager User Guide</i>. If you include the configuration
        /// parameters, the operation sets the values for the secret and then immediately starts
        /// a rotation. If you don't include the configuration parameters, the operation starts
        /// a rotation with the values already stored in the secret. 
        /// 
        ///  
        /// <para>
        /// When rotation is successful, the <c>AWSPENDING</c> staging label might be attached
        /// to the same version as the <c>AWSCURRENT</c> version, or it might not be attached
        /// to any version. If the <c>AWSPENDING</c> staging label is present but not attached
        /// to the same version as <c>AWSCURRENT</c>, then any later invocation of <c>RotateSecret</c>
        /// assumes that a previous rotation request is still in progress and returns an error.
        /// When rotation is unsuccessful, the <c>AWSPENDING</c> staging label might be attached
        /// to an empty secret version. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/troubleshoot_rotation.html">Troubleshoot
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
        ///  <b>Required permissions: </b> <c>secretsmanager:RotateSecret</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. You also need <c>lambda:InvokeFunction</c>
        /// permissions on the rotation function. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotating-secrets-required-permissions-function.html">
        /// Permissions for rotation</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateSecret service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RotateSecretResponse> RotateSecretAsync(RotateSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateSecretResponseUnmarshaller.Instance;
            
            return InvokeAsync<RotateSecretResponse>(request, options, cancellationToken);
        }

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
        ///  <b>Required permissions: </b> <c>secretsmanager:StopReplicationToReplica</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual StopReplicationToReplicaResponse StopReplicationToReplica(StopReplicationToReplicaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopReplicationToReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationToReplicaResponseUnmarshaller.Instance;

            return Invoke<StopReplicationToReplicaResponse>(request, options);
        }


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
        ///  <b>Required permissions: </b> <c>secretsmanager:StopReplicationToReplica</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationToReplica service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StopReplicationToReplicaResponse> StopReplicationToReplicaAsync(StopReplicationToReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopReplicationToReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationToReplicaResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopReplicationToReplicaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Attaches tags to a secret. Tags consist of a key name and a value. Tags are part of
        /// the secret's metadata. They are not associated with specific versions of the secret.
        /// This operation appends tags to the existing list of tags.
        /// 
        ///  
        /// <para>
        /// For tag quotas and naming restrictions, see <a href="https://docs.aws.amazon.com/general/latest/gr/arg.html#taged-reference-quotas">Service
        /// quotas for Tagging</a> in the <i>Amazon Web Services General Reference guide</i>.
        /// </para>
        ///  <important> 
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
        ///  <b>Required permissions: </b> <c>secretsmanager:TagResource</c>. For more information,
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Attaches tags to a secret. Tags consist of a key name and a value. Tags are part of
        /// the secret's metadata. They are not associated with specific versions of the secret.
        /// This operation appends tags to the existing list of tags.
        /// 
        ///  
        /// <para>
        /// For tag quotas and naming restrictions, see <a href="https://docs.aws.amazon.com/general/latest/gr/arg.html#taged-reference-quotas">Service
        /// quotas for Tagging</a> in the <i>Amazon Web Services General Reference guide</i>.
        /// </para>
        ///  <important> 
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
        ///  <b>Required permissions: </b> <c>secretsmanager:TagResource</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

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
        ///  <b>Required permissions: </b> <c>secretsmanager:UntagResource</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


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
        ///  <b>Required permissions: </b> <c>secretsmanager:UntagResource</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

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
        /// To change a secret so that it is managed by another service, you need to recreate
        /// the secret in that service. See <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// Manager secrets managed by other Amazon Web Services services</a>.
        /// </para>
        ///  
        /// <para>
        /// We recommend you avoid calling <c>UpdateSecret</c> at a sustained rate of more than
        /// once every 10 minutes. When you call <c>UpdateSecret</c> to update the secret value,
        /// Secrets Manager creates a new version of the secret. Secrets Manager removes outdated
        /// versions when there are more than 100, but it does not remove versions created less
        /// than 24 hours ago. If you update the secret value more than once every 10 minutes,
        /// you create more versions than Secrets Manager removes, and you will reach the quota
        /// for secret versions.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>SecretString</c> or <c>SecretBinary</c> to create a new secret version,
        /// Secrets Manager automatically moves the staging label <c>AWSCURRENT</c> to the new
        /// version. Then it attaches the label <c>AWSPREVIOUS</c> to the version that <c>AWSCURRENT</c>
        /// was removed from.
        /// </para>
        ///  
        /// <para>
        /// If you call this operation with a <c>ClientRequestToken</c> that matches an existing
        /// version's <c>VersionId</c>, the operation results in an error. You can't modify an
        /// existing version, you can only create a new version. To remove a version, remove all
        /// staging labels from it. See <a>UpdateSecretVersionStage</a>.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters except <c>SecretBinary</c> or
        /// <c>SecretString</c> because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>secretsmanager:UpdateSecret</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. If you use a customer managed key, you
        /// must also have <c>kms:GenerateDataKey</c>, <c>kms:Encrypt</c>, and <c>kms:Decrypt</c>
        /// permissions on the key. If you change the KMS key and you don't have <c>kms:Encrypt</c>
        /// permission to the new key, Secrets Manager does not re-ecrypt existing secret versions
        /// with the new key. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/security-encryption.html">
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
        public virtual UpdateSecretResponse UpdateSecret(UpdateSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecretResponseUnmarshaller.Instance;

            return Invoke<UpdateSecretResponse>(request, options);
        }


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
        /// To change a secret so that it is managed by another service, you need to recreate
        /// the secret in that service. See <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// Manager secrets managed by other Amazon Web Services services</a>.
        /// </para>
        ///  
        /// <para>
        /// We recommend you avoid calling <c>UpdateSecret</c> at a sustained rate of more than
        /// once every 10 minutes. When you call <c>UpdateSecret</c> to update the secret value,
        /// Secrets Manager creates a new version of the secret. Secrets Manager removes outdated
        /// versions when there are more than 100, but it does not remove versions created less
        /// than 24 hours ago. If you update the secret value more than once every 10 minutes,
        /// you create more versions than Secrets Manager removes, and you will reach the quota
        /// for secret versions.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>SecretString</c> or <c>SecretBinary</c> to create a new secret version,
        /// Secrets Manager automatically moves the staging label <c>AWSCURRENT</c> to the new
        /// version. Then it attaches the label <c>AWSPREVIOUS</c> to the version that <c>AWSCURRENT</c>
        /// was removed from.
        /// </para>
        ///  
        /// <para>
        /// If you call this operation with a <c>ClientRequestToken</c> that matches an existing
        /// version's <c>VersionId</c>, the operation results in an error. You can't modify an
        /// existing version, you can only create a new version. To remove a version, remove all
        /// staging labels from it. See <a>UpdateSecretVersionStage</a>.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
        /// include sensitive information in request parameters except <c>SecretBinary</c> or
        /// <c>SecretString</c> because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
        /// Secrets Manager events with CloudTrail</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>secretsmanager:UpdateSecret</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. If you use a customer managed key, you
        /// must also have <c>kms:GenerateDataKey</c>, <c>kms:Encrypt</c>, and <c>kms:Decrypt</c>
        /// permissions on the key. If you change the KMS key and you don't have <c>kms:Encrypt</c>
        /// permission to the new key, Secrets Manager does not re-ecrypt existing secret versions
        /// with the new key. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/security-encryption.html">
        /// Secret encryption and decryption</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecret service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateSecretResponse> UpdateSecretAsync(UpdateSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecretResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSecretResponse>(request, options, cancellationToken);
        }

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
        /// The staging labels that you specify in the <c>VersionStage</c> parameter are added
        /// to the existing list of staging labels for the version. 
        /// </para>
        ///  
        /// <para>
        /// You can move the <c>AWSCURRENT</c> staging label to this version by including it in
        /// this call.
        /// </para>
        ///  <note> 
        /// <para>
        /// Whenever you move <c>AWSCURRENT</c>, Secrets Manager automatically moves the label
        /// <c>AWSPREVIOUS</c> to the version that <c>AWSCURRENT</c> was removed from.
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
        ///  <b>Required permissions: </b> <c>secretsmanager:UpdateSecretVersionStage</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
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
        public virtual UpdateSecretVersionStageResponse UpdateSecretVersionStage(UpdateSecretVersionStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecretVersionStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecretVersionStageResponseUnmarshaller.Instance;

            return Invoke<UpdateSecretVersionStageResponse>(request, options);
        }


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
        /// The staging labels that you specify in the <c>VersionStage</c> parameter are added
        /// to the existing list of staging labels for the version. 
        /// </para>
        ///  
        /// <para>
        /// You can move the <c>AWSCURRENT</c> staging label to this version by including it in
        /// this call.
        /// </para>
        ///  <note> 
        /// <para>
        /// Whenever you move <c>AWSCURRENT</c>, Secrets Manager automatically moves the label
        /// <c>AWSPREVIOUS</c> to the version that <c>AWSCURRENT</c> was removed from.
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
        ///  <b>Required permissions: </b> <c>secretsmanager:UpdateSecretVersionStage</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecretVersionStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateSecretVersionStageResponse> UpdateSecretVersionStageAsync(UpdateSecretVersionStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecretVersionStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecretVersionStageResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSecretVersionStageResponse>(request, options, cancellationToken);
        }

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
        ///  <b>Required permissions: </b> <c>secretsmanager:ValidateResourcePolicy</c> and <c>secretsmanager:PutResourcePolicy</c>.
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
        public virtual ValidateResourcePolicyResponse ValidateResourcePolicy(ValidateResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<ValidateResourcePolicyResponse>(request, options);
        }


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
        ///  <b>Required permissions: </b> <c>secretsmanager:ValidateResourcePolicy</c> and <c>secretsmanager:PutResourcePolicy</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
        /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
        /// and access control in Secrets Manager</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ValidateResourcePolicyResponse> ValidateResourcePolicyAsync(ValidateResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<ValidateResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonSecretsManagerEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}