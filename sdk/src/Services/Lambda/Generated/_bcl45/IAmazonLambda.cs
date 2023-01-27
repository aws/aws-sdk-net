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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Lambda.Model;

namespace Amazon.Lambda
{
    /// <summary>
    /// Interface for accessing Lambda
    ///
    /// Lambda 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// Lambda is a compute service that lets you run code without provisioning or managing
    /// servers. Lambda runs your code on a high-availability compute infrastructure and performs
    /// all of the administration of the compute resources, including server and operating
    /// system maintenance, capacity provisioning and automatic scaling, code monitoring and
    /// logging. With Lambda, you can run code for virtually any type of application or backend
    /// service. For more information about the Lambda service, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/welcome.html">What
    /// is Lambda</a> in the <b>Lambda Developer Guide</b>.
    /// </para>
    ///  
    /// <para>
    /// The <i>Lambda API Reference</i> provides information about each of the API methods,
    /// including details about the parameters in each API request and response. 
    /// </para>
    ///   
    /// <para>
    /// You can use Software Development Kits (SDKs), Integrated Development Environment (IDE)
    /// Toolkits, and command line tools to access the API. For installation instructions,
    /// see <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>. 
    /// </para>
    ///  
    /// <para>
    /// For a list of Region-specific endpoints that Lambda supports, see <a href="https://docs.aws.amazon.com/general/latest/gr/lambda-service.html/">Lambda
    /// endpoints and quotas </a> in the <i>Amazon Web Services General Reference.</i>. 
    /// </para>
    ///  
    /// <para>
    /// When making the API calls, you will need to authenticate your request by providing
    /// a signature. Lambda supports signature version 4. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 signing process</a> in the <i>Amazon Web Services General Reference.</i>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>CA certificates</b> 
    /// </para>
    ///  
    /// <para>
    /// Because Amazon Web Services SDKs use the CA certificates from your computer, changes
    /// to the certificates on the Amazon Web Services servers can cause connection failures
    /// when you attempt to use an SDK. You can prevent these failures by keeping your computer's
    /// CA certificates and operating system up-to-date. If you encounter this issue in a
    /// corporate environment and do not manage your own computer, you might need to ask an
    /// administrator to assist with the update process. The following list shows minimum
    /// operating system and Java versions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Microsoft Windows versions that have updates from January 2005 or later installed
    /// contain at least one of the required CAs in their trust list. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Mac OS X 10.4 with Java for Mac OS X 10.4 Release 5 (February 2007), Mac OS X 10.5
    /// (October 2007), and later versions contain at least one of the required CAs in their
    /// trust list. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Red Hat Enterprise Linux 5 (March 2007), 6, and 7 and CentOS 5, 6, and 7 all contain
    /// at least one of the required CAs in their default trusted CA list. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Java 1.4.2_12 (May 2006), 5 Update 2 (March 2005), and all later versions, including
    /// Java 6 (December 2006), 7, and 8, contain at least one of the required CAs in their
    /// default trusted CA list. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When accessing the Lambda management console or Lambda API endpoints, whether through
    /// browsers or programmatically, you will need to ensure your client machines support
    /// any of the following CAs: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon Root CA 1
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Starfield Services Root Certificate Authority - G2
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Starfield Class 2 Certification Authority
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Root certificates from the first two authorities are available from <a href="https://www.amazontrust.com/repository/">Amazon
    /// trust services</a>, but keeping your computer up-to-date is the more straightforward
    /// solution. To learn more about ACM-provided certificates, see <a href="http://aws.amazon.com/certificate-manager/faqs/#certificates">Amazon
    /// Web Services Certificate Manager FAQs.</a> 
    /// </para>
    /// </summary>
    public partial interface IAmazonLambda : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILambdaPaginatorFactory Paginators { get; }

        
        #region  AddLayerVersionPermission


        /// <summary>
        /// Adds permissions to the resource-based policy of a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. Use this action to grant layer usage permission to other accounts. You
        /// can grant permission to a single account, all accounts in an organization, or all
        /// Amazon Web Services accounts. 
        /// 
        ///  
        /// <para>
        /// To revoke permission, call <a>RemoveLayerVersionPermission</a> with the statement
        /// ID that you specified when you added it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddLayerVersionPermission service method.</param>
        /// 
        /// <returns>The response from the AddLayerVersionPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PolicyLengthExceededException">
        /// The permissions policy for the resource is too large. For more information, see <a
        /// href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddLayerVersionPermission">REST API Reference for AddLayerVersionPermission Operation</seealso>
        AddLayerVersionPermissionResponse AddLayerVersionPermission(AddLayerVersionPermissionRequest request);



        /// <summary>
        /// Adds permissions to the resource-based policy of a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. Use this action to grant layer usage permission to other accounts. You
        /// can grant permission to a single account, all accounts in an organization, or all
        /// Amazon Web Services accounts. 
        /// 
        ///  
        /// <para>
        /// To revoke permission, call <a>RemoveLayerVersionPermission</a> with the statement
        /// ID that you specified when you added it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddLayerVersionPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddLayerVersionPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PolicyLengthExceededException">
        /// The permissions policy for the resource is too large. For more information, see <a
        /// href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddLayerVersionPermission">REST API Reference for AddLayerVersionPermission Operation</seealso>
        Task<AddLayerVersionPermissionResponse> AddLayerVersionPermissionAsync(AddLayerVersionPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddPermission


        /// <summary>
        /// Grants an Amazon Web Service, Amazon Web Services account, or Amazon Web Services
        /// organization permission to use a function. You can apply the policy at the function
        /// level, or specify a qualifier to restrict access to a single version or alias. If
        /// you use a qualifier, the invoker must use the full Amazon Resource Name (ARN) of that
        /// version or alias to invoke the function. Note: Lambda does not support adding policies
        /// to version $LATEST.
        /// 
        ///  
        /// <para>
        /// To grant permission to another account, specify the account ID as the <code>Principal</code>.
        /// To grant permission to an organization defined in Organizations, specify the organization
        /// ID as the <code>PrincipalOrgID</code>. For Amazon Web Services, the principal is a
        /// domain-style identifier that the service defines, such as <code>s3.amazonaws.com</code>
        /// or <code>sns.amazonaws.com</code>. For Amazon Web Services, you can also specify the
        /// ARN of the associated resource as the <code>SourceArn</code>. If you grant permission
        /// to a service principal without specifying the source, other accounts could potentially
        /// configure resources in their account to invoke your Lambda function.
        /// </para>
        ///  
        /// <para>
        /// This operation adds a statement to a resource-based permissions policy for the function.
        /// For more information about function policies, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">Using
        /// resource-based policies for Lambda</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PolicyLengthExceededException">
        /// The permissions policy for the resource is too large. For more information, see <a
        /// href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        AddPermissionResponse AddPermission(AddPermissionRequest request);



        /// <summary>
        /// Grants an Amazon Web Service, Amazon Web Services account, or Amazon Web Services
        /// organization permission to use a function. You can apply the policy at the function
        /// level, or specify a qualifier to restrict access to a single version or alias. If
        /// you use a qualifier, the invoker must use the full Amazon Resource Name (ARN) of that
        /// version or alias to invoke the function. Note: Lambda does not support adding policies
        /// to version $LATEST.
        /// 
        ///  
        /// <para>
        /// To grant permission to another account, specify the account ID as the <code>Principal</code>.
        /// To grant permission to an organization defined in Organizations, specify the organization
        /// ID as the <code>PrincipalOrgID</code>. For Amazon Web Services, the principal is a
        /// domain-style identifier that the service defines, such as <code>s3.amazonaws.com</code>
        /// or <code>sns.amazonaws.com</code>. For Amazon Web Services, you can also specify the
        /// ARN of the associated resource as the <code>SourceArn</code>. If you grant permission
        /// to a service principal without specifying the source, other accounts could potentially
        /// configure resources in their account to invoke your Lambda function.
        /// </para>
        ///  
        /// <para>
        /// This operation adds a statement to a resource-based permissions policy for the function.
        /// For more information about function policies, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">Using
        /// resource-based policies for Lambda</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PolicyLengthExceededException">
        /// The permissions policy for the resource is too large. For more information, see <a
        /// href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAlias


        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html">alias</a>
        /// for a Lambda function version. Use aliases to provide clients with a function identifier
        /// that you can update to invoke a different version.
        /// 
        ///  
        /// <para>
        /// You can also map an alias to split invocation requests between two versions. Use the
        /// <code>RoutingConfig</code> parameter to specify a second version and the percentage
        /// of invocation requests that it receives.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        CreateAliasResponse CreateAlias(CreateAliasRequest request);



        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html">alias</a>
        /// for a Lambda function version. Use aliases to provide clients with a function identifier
        /// that you can update to invoke a different version.
        /// 
        ///  
        /// <para>
        /// You can also map an alias to split invocation requests between two versions. Use the
        /// <code>RoutingConfig</code> parameter to specify a second version and the percentage
        /// of invocation requests that it receives.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCodeSigningConfig


        /// <summary>
        /// Creates a code signing configuration. A <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html">code
        /// signing configuration</a> defines a list of allowed signing profiles and defines the
        /// code-signing validation policy (action to be taken if deployment validation checks
        /// fail).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the CreateCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateCodeSigningConfig">REST API Reference for CreateCodeSigningConfig Operation</seealso>
        CreateCodeSigningConfigResponse CreateCodeSigningConfig(CreateCodeSigningConfigRequest request);



        /// <summary>
        /// Creates a code signing configuration. A <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html">code
        /// signing configuration</a> defines a list of allowed signing profiles and defines the
        /// code-signing validation policy (action to be taken if deployment validation checks
        /// fail).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSigningConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateCodeSigningConfig">REST API Reference for CreateCodeSigningConfig Operation</seealso>
        Task<CreateCodeSigningConfigResponse> CreateCodeSigningConfigAsync(CreateCodeSigningConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEventSourceMapping


        /// <summary>
        /// Creates a mapping between an event source and an Lambda function. Lambda reads items
        /// from the event source and invokes the function.
        /// 
        ///  
        /// <para>
        /// For details about how to configure different event sources, see the following topics.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-dynamodb-eventsourcemapping">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-eventsourcemapping">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-eventsource">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-eventsourcemapping">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html"> Amazon MSK</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/kafka-smaa.html"> Apache Kafka</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following error handling options are available only for stream sources (DynamoDB
        /// and Kinesis):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BisectBatchOnFunctionError</code> – If the function returns an error, split
        /// the batch in two and retry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationConfig</code> – Send discarded records to an Amazon SQS queue or
        /// Amazon SNS topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRecordAgeInSeconds</code> – Discard records older than the specified
        /// age. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRetryAttempts</code> – Discard records after the specified number of
        /// retries. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ParallelizationFactor</code> – Process multiple batches from each shard concurrently.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about which configuration parameters apply to each event source, see
        /// the following topics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-ddb-params">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-params">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#services-sqs-params">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-params">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#services-msk-parms">
        /// Amazon MSK</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kafka.html#services-kafka-parms">
        /// Apache Kafka</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the CreateEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateEventSourceMapping">REST API Reference for CreateEventSourceMapping Operation</seealso>
        CreateEventSourceMappingResponse CreateEventSourceMapping(CreateEventSourceMappingRequest request);



        /// <summary>
        /// Creates a mapping between an event source and an Lambda function. Lambda reads items
        /// from the event source and invokes the function.
        /// 
        ///  
        /// <para>
        /// For details about how to configure different event sources, see the following topics.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-dynamodb-eventsourcemapping">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-eventsourcemapping">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-eventsource">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-eventsourcemapping">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html"> Amazon MSK</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/kafka-smaa.html"> Apache Kafka</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following error handling options are available only for stream sources (DynamoDB
        /// and Kinesis):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BisectBatchOnFunctionError</code> – If the function returns an error, split
        /// the batch in two and retry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationConfig</code> – Send discarded records to an Amazon SQS queue or
        /// Amazon SNS topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRecordAgeInSeconds</code> – Discard records older than the specified
        /// age. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRetryAttempts</code> – Discard records after the specified number of
        /// retries. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ParallelizationFactor</code> – Process multiple batches from each shard concurrently.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about which configuration parameters apply to each event source, see
        /// the following topics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-ddb-params">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-params">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#services-sqs-params">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-params">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#services-msk-parms">
        /// Amazon MSK</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kafka.html#services-kafka-parms">
        /// Apache Kafka</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSourceMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateEventSourceMapping">REST API Reference for CreateEventSourceMapping Operation</seealso>
        Task<CreateEventSourceMappingResponse> CreateEventSourceMappingAsync(CreateEventSourceMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFunction


        /// <summary>
        /// Creates a Lambda function. To create a function, you need a <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-package.html">deployment
        /// package</a> and an <a href="https://docs.aws.amazon.com/lambda/latest/dg/intro-permission-model.html#lambda-intro-execution-role">execution
        /// role</a>. The deployment package is a .zip file archive or container image that contains
        /// your function code. The execution role grants the function permission to use Amazon
        /// Web Services, such as Amazon CloudWatch Logs for log streaming and X-Ray for request
        /// tracing.
        /// 
        ///  
        /// <para>
        /// If the deployment package is a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-images.html">container
        /// image</a>, then you set the package type to <code>Image</code>. For a container image,
        /// the code property must include the URI of a container image in the Amazon ECR registry.
        /// You do not need to specify the handler and runtime properties.
        /// </para>
        ///  
        /// <para>
        /// If the deployment package is a <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-package.html#gettingstarted-package-zip">.zip
        /// file archive</a>, then you set the package type to <code>Zip</code>. For a .zip file
        /// archive, the code property specifies the location of the .zip file. You must also
        /// specify the handler and runtime properties. The code in the deployment package must
        /// be compatible with the target instruction set architecture of the function (<code>x86-64</code>
        /// or <code>arm64</code>). If you do not specify the architecture, then the default value
        /// is <code>x86-64</code>.
        /// </para>
        ///  
        /// <para>
        /// When you create a function, Lambda provisions an instance of the function and its
        /// supporting resources. If your function connects to a VPC, this process can take a
        /// minute or so. During this time, you can't invoke or modify the function. The <code>State</code>,
        /// <code>StateReason</code>, and <code>StateReasonCode</code> fields in the response
        /// from <a>GetFunctionConfiguration</a> indicate when the function is ready to invoke.
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">Lambda
        /// function states</a>.
        /// </para>
        ///  
        /// <para>
        /// A function has an unpublished version, and can have published versions and aliases.
        /// The unpublished version changes when you update your function's code and configuration.
        /// A published version is a snapshot of your function code and configuration that can't
        /// be changed. An alias is a named resource that maps to a version, and can be changed
        /// to map to a different version. Use the <code>Publish</code> parameter to create version
        /// <code>1</code> of your function from its initial configuration.
        /// </para>
        ///  
        /// <para>
        /// The other parameters let you configure version-specific and function-level settings.
        /// You can modify version-specific settings later with <a>UpdateFunctionConfiguration</a>.
        /// Function-level settings apply to both the unpublished and published versions of the
        /// function, and include tags (<a>TagResource</a>) and per-function concurrency limits
        /// (<a>PutFunctionConcurrency</a>).
        /// </para>
        ///  
        /// <para>
        /// You can use code signing if your deployment package is a .zip file archive. To enable
        /// code signing for this function, specify the ARN of a code-signing configuration. When
        /// a user attempts to deploy a code package with <a>UpdateFunctionCode</a>, Lambda checks
        /// that the code package has a valid signature from a trusted publisher. The code-signing
        /// configuration includes set of signing profiles, which define the trusted publishers
        /// for this function.
        /// </para>
        ///  
        /// <para>
        /// If another Amazon Web Services account or an Amazon Web Service invokes your function,
        /// use <a>AddPermission</a> to grant permission by creating a resource-based Identity
        /// and Access Management (IAM) policy. You can grant permissions at the function level,
        /// on a version, or on an alias.
        /// </para>
        ///  
        /// <para>
        /// To invoke your function directly, use <a>Invoke</a>. To invoke your function in response
        /// to events in other Amazon Web Services, create an event source mapping (<a>CreateEventSourceMapping</a>),
        /// or configure a function trigger in the other service. For more information, see <a
        /// href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-invocation.html">Invoking
        /// Lambda functions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction service method.</param>
        /// 
        /// <returns>The response from the CreateFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeVerificationFailedException">
        /// The code signature failed one or more of the validation checks for signature mismatch
        /// or expiry, and the code signing policy is set to ENFORCE. Lambda blocks the deployment.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidCodeSignatureException">
        /// The code signature failed the integrity check. If the integrity check fails, then
        /// Lambda blocks deployment, even if the code signing policy is set to WARN.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        CreateFunctionResponse CreateFunction(CreateFunctionRequest request);



        /// <summary>
        /// Creates a Lambda function. To create a function, you need a <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-package.html">deployment
        /// package</a> and an <a href="https://docs.aws.amazon.com/lambda/latest/dg/intro-permission-model.html#lambda-intro-execution-role">execution
        /// role</a>. The deployment package is a .zip file archive or container image that contains
        /// your function code. The execution role grants the function permission to use Amazon
        /// Web Services, such as Amazon CloudWatch Logs for log streaming and X-Ray for request
        /// tracing.
        /// 
        ///  
        /// <para>
        /// If the deployment package is a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-images.html">container
        /// image</a>, then you set the package type to <code>Image</code>. For a container image,
        /// the code property must include the URI of a container image in the Amazon ECR registry.
        /// You do not need to specify the handler and runtime properties.
        /// </para>
        ///  
        /// <para>
        /// If the deployment package is a <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-package.html#gettingstarted-package-zip">.zip
        /// file archive</a>, then you set the package type to <code>Zip</code>. For a .zip file
        /// archive, the code property specifies the location of the .zip file. You must also
        /// specify the handler and runtime properties. The code in the deployment package must
        /// be compatible with the target instruction set architecture of the function (<code>x86-64</code>
        /// or <code>arm64</code>). If you do not specify the architecture, then the default value
        /// is <code>x86-64</code>.
        /// </para>
        ///  
        /// <para>
        /// When you create a function, Lambda provisions an instance of the function and its
        /// supporting resources. If your function connects to a VPC, this process can take a
        /// minute or so. During this time, you can't invoke or modify the function. The <code>State</code>,
        /// <code>StateReason</code>, and <code>StateReasonCode</code> fields in the response
        /// from <a>GetFunctionConfiguration</a> indicate when the function is ready to invoke.
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">Lambda
        /// function states</a>.
        /// </para>
        ///  
        /// <para>
        /// A function has an unpublished version, and can have published versions and aliases.
        /// The unpublished version changes when you update your function's code and configuration.
        /// A published version is a snapshot of your function code and configuration that can't
        /// be changed. An alias is a named resource that maps to a version, and can be changed
        /// to map to a different version. Use the <code>Publish</code> parameter to create version
        /// <code>1</code> of your function from its initial configuration.
        /// </para>
        ///  
        /// <para>
        /// The other parameters let you configure version-specific and function-level settings.
        /// You can modify version-specific settings later with <a>UpdateFunctionConfiguration</a>.
        /// Function-level settings apply to both the unpublished and published versions of the
        /// function, and include tags (<a>TagResource</a>) and per-function concurrency limits
        /// (<a>PutFunctionConcurrency</a>).
        /// </para>
        ///  
        /// <para>
        /// You can use code signing if your deployment package is a .zip file archive. To enable
        /// code signing for this function, specify the ARN of a code-signing configuration. When
        /// a user attempts to deploy a code package with <a>UpdateFunctionCode</a>, Lambda checks
        /// that the code package has a valid signature from a trusted publisher. The code-signing
        /// configuration includes set of signing profiles, which define the trusted publishers
        /// for this function.
        /// </para>
        ///  
        /// <para>
        /// If another Amazon Web Services account or an Amazon Web Service invokes your function,
        /// use <a>AddPermission</a> to grant permission by creating a resource-based Identity
        /// and Access Management (IAM) policy. You can grant permissions at the function level,
        /// on a version, or on an alias.
        /// </para>
        ///  
        /// <para>
        /// To invoke your function directly, use <a>Invoke</a>. To invoke your function in response
        /// to events in other Amazon Web Services, create an event source mapping (<a>CreateEventSourceMapping</a>),
        /// or configure a function trigger in the other service. For more information, see <a
        /// href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-invocation.html">Invoking
        /// Lambda functions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeVerificationFailedException">
        /// The code signature failed one or more of the validation checks for signature mismatch
        /// or expiry, and the code signing policy is set to ENFORCE. Lambda blocks the deployment.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidCodeSignatureException">
        /// The code signature failed the integrity check. If the integrity check fails, then
        /// Lambda blocks deployment, even if the code signing policy is set to WARN.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        Task<CreateFunctionResponse> CreateFunctionAsync(CreateFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFunctionUrlConfig


        /// <summary>
        /// Creates a Lambda function URL with the specified configuration parameters. A function
        /// URL is a dedicated HTTP(S) endpoint that you can use to invoke your function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionUrlConfig service method.</param>
        /// 
        /// <returns>The response from the CreateFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunctionUrlConfig">REST API Reference for CreateFunctionUrlConfig Operation</seealso>
        CreateFunctionUrlConfigResponse CreateFunctionUrlConfig(CreateFunctionUrlConfigRequest request);



        /// <summary>
        /// Creates a Lambda function URL with the specified configuration parameters. A function
        /// URL is a dedicated HTTP(S) endpoint that you can use to invoke your function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionUrlConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunctionUrlConfig">REST API Reference for CreateFunctionUrlConfig Operation</seealso>
        Task<CreateFunctionUrlConfigResponse> CreateFunctionUrlConfigAsync(CreateFunctionUrlConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Deletes a Lambda function <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html">alias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        DeleteAliasResponse DeleteAlias(DeleteAliasRequest request);



        /// <summary>
        /// Deletes a Lambda function <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html">alias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCodeSigningConfig


        /// <summary>
        /// Deletes the code signing configuration. You can delete the code signing configuration
        /// only if no function is using it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteCodeSigningConfig">REST API Reference for DeleteCodeSigningConfig Operation</seealso>
        DeleteCodeSigningConfigResponse DeleteCodeSigningConfig(DeleteCodeSigningConfigRequest request);



        /// <summary>
        /// Deletes the code signing configuration. You can delete the code signing configuration
        /// only if no function is using it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSigningConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteCodeSigningConfig">REST API Reference for DeleteCodeSigningConfig Operation</seealso>
        Task<DeleteCodeSigningConfigResponse> DeleteCodeSigningConfigAsync(DeleteCodeSigningConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEventSourceMapping


        /// <summary>
        /// Deletes an <a href="https://docs.aws.amazon.com/lambda/latest/dg/intro-invocation-modes.html">event
        /// source mapping</a>. You can get the identifier of a mapping from the output of <a>ListEventSourceMappings</a>.
        /// 
        ///  
        /// <para>
        /// When you delete an event source mapping, it enters a <code>Deleting</code> state and
        /// might not be completely deleted for several seconds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example, you tried to
        /// update an event source mapping in the CREATING state, or you tried to delete an event
        /// source mapping currently UPDATING.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteEventSourceMapping">REST API Reference for DeleteEventSourceMapping Operation</seealso>
        DeleteEventSourceMappingResponse DeleteEventSourceMapping(DeleteEventSourceMappingRequest request);



        /// <summary>
        /// Deletes an <a href="https://docs.aws.amazon.com/lambda/latest/dg/intro-invocation-modes.html">event
        /// source mapping</a>. You can get the identifier of a mapping from the output of <a>ListEventSourceMappings</a>.
        /// 
        ///  
        /// <para>
        /// When you delete an event source mapping, it enters a <code>Deleting</code> state and
        /// might not be completely deleted for several seconds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSourceMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example, you tried to
        /// update an event source mapping in the CREATING state, or you tried to delete an event
        /// source mapping currently UPDATING.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteEventSourceMapping">REST API Reference for DeleteEventSourceMapping Operation</seealso>
        Task<DeleteEventSourceMappingResponse> DeleteEventSourceMappingAsync(DeleteEventSourceMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFunction


        /// <summary>
        /// Deletes a Lambda function. To delete a specific function version, use the <code>Qualifier</code>
        /// parameter. Otherwise, all versions and aliases are deleted.
        /// 
        ///  
        /// <para>
        /// To delete Lambda event source mappings that invoke a function, use <a>DeleteEventSourceMapping</a>.
        /// For Amazon Web Services and resources that invoke your function directly, delete the
        /// trigger in the service where you originally configured it.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function or version. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> – <code>my-function</code> (name-only), <code>my-function:1</code> (with version). </li> <li>  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        DeleteFunctionResponse DeleteFunction(string functionName);

        /// <summary>
        /// Deletes a Lambda function. To delete a specific function version, use the <code>Qualifier</code>
        /// parameter. Otherwise, all versions and aliases are deleted.
        /// 
        ///  
        /// <para>
        /// To delete Lambda event source mappings that invoke a function, use <a>DeleteEventSourceMapping</a>.
        /// For Amazon Web Services and resources that invoke your function directly, delete the
        /// trigger in the service where you originally configured it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request);


        /// <summary>
        /// Deletes a Lambda function. To delete a specific function version, use the <code>Qualifier</code>
        /// parameter. Otherwise, all versions and aliases are deleted.
        /// 
        ///  
        /// <para>
        /// To delete Lambda event source mappings that invoke a function, use <a>DeleteEventSourceMapping</a>.
        /// For Amazon Web Services and resources that invoke your function directly, delete the
        /// trigger in the service where you originally configured it.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function or version. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> – <code>my-function</code> (name-only), <code>my-function:1</code> (with version). </li> <li>  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        Task<DeleteFunctionResponse> DeleteFunctionAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes a Lambda function. To delete a specific function version, use the <code>Qualifier</code>
        /// parameter. Otherwise, all versions and aliases are deleted.
        /// 
        ///  
        /// <para>
        /// To delete Lambda event source mappings that invoke a function, use <a>DeleteEventSourceMapping</a>.
        /// For Amazon Web Services and resources that invoke your function directly, delete the
        /// trigger in the service where you originally configured it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFunctionCodeSigningConfig


        /// <summary>
        /// Removes the code signing configuration from the function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteFunctionCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionCodeSigningConfig">REST API Reference for DeleteFunctionCodeSigningConfig Operation</seealso>
        DeleteFunctionCodeSigningConfigResponse DeleteFunctionCodeSigningConfig(DeleteFunctionCodeSigningConfigRequest request);



        /// <summary>
        /// Removes the code signing configuration from the function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionCodeSigningConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFunctionCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionCodeSigningConfig">REST API Reference for DeleteFunctionCodeSigningConfig Operation</seealso>
        Task<DeleteFunctionCodeSigningConfigResponse> DeleteFunctionCodeSigningConfigAsync(DeleteFunctionCodeSigningConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFunctionConcurrency


        /// <summary>
        /// Removes a concurrent execution limit from a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionConcurrency service method.</param>
        /// 
        /// <returns>The response from the DeleteFunctionConcurrency service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionConcurrency">REST API Reference for DeleteFunctionConcurrency Operation</seealso>
        DeleteFunctionConcurrencyResponse DeleteFunctionConcurrency(DeleteFunctionConcurrencyRequest request);



        /// <summary>
        /// Removes a concurrent execution limit from a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionConcurrency service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFunctionConcurrency service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionConcurrency">REST API Reference for DeleteFunctionConcurrency Operation</seealso>
        Task<DeleteFunctionConcurrencyResponse> DeleteFunctionConcurrencyAsync(DeleteFunctionConcurrencyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFunctionEventInvokeConfig


        /// <summary>
        /// Deletes the configuration for asynchronous invocation for a function, version, or
        /// alias.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionEventInvokeConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionEventInvokeConfig">REST API Reference for DeleteFunctionEventInvokeConfig Operation</seealso>
        DeleteFunctionEventInvokeConfigResponse DeleteFunctionEventInvokeConfig(DeleteFunctionEventInvokeConfigRequest request);



        /// <summary>
        /// Deletes the configuration for asynchronous invocation for a function, version, or
        /// alias.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionEventInvokeConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionEventInvokeConfig">REST API Reference for DeleteFunctionEventInvokeConfig Operation</seealso>
        Task<DeleteFunctionEventInvokeConfigResponse> DeleteFunctionEventInvokeConfigAsync(DeleteFunctionEventInvokeConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFunctionUrlConfig


        /// <summary>
        /// Deletes a Lambda function URL. When you delete a function URL, you can't recover it.
        /// Creating a new function URL results in a different URL address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionUrlConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionUrlConfig">REST API Reference for DeleteFunctionUrlConfig Operation</seealso>
        DeleteFunctionUrlConfigResponse DeleteFunctionUrlConfig(DeleteFunctionUrlConfigRequest request);



        /// <summary>
        /// Deletes a Lambda function URL. When you delete a function URL, you can't recover it.
        /// Creating a new function URL results in a different URL address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionUrlConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionUrlConfig">REST API Reference for DeleteFunctionUrlConfig Operation</seealso>
        Task<DeleteFunctionUrlConfigResponse> DeleteFunctionUrlConfigAsync(DeleteFunctionUrlConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLayerVersion


        /// <summary>
        /// Deletes a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. Deleted versions can no longer be viewed or added to functions. To avoid
        /// breaking functions, a copy of the version remains in Lambda until no functions refer
        /// to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayerVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteLayerVersion">REST API Reference for DeleteLayerVersion Operation</seealso>
        DeleteLayerVersionResponse DeleteLayerVersion(DeleteLayerVersionRequest request);



        /// <summary>
        /// Deletes a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. Deleted versions can no longer be viewed or added to functions. To avoid
        /// breaking functions, a copy of the version remains in Lambda until no functions refer
        /// to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayerVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteLayerVersion">REST API Reference for DeleteLayerVersion Operation</seealso>
        Task<DeleteLayerVersionResponse> DeleteLayerVersionAsync(DeleteLayerVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteProvisionedConcurrencyConfig


        /// <summary>
        /// Deletes the provisioned concurrency configuration for a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedConcurrencyConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisionedConcurrencyConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteProvisionedConcurrencyConfig">REST API Reference for DeleteProvisionedConcurrencyConfig Operation</seealso>
        DeleteProvisionedConcurrencyConfigResponse DeleteProvisionedConcurrencyConfig(DeleteProvisionedConcurrencyConfigRequest request);



        /// <summary>
        /// Deletes the provisioned concurrency configuration for a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedConcurrencyConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProvisionedConcurrencyConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteProvisionedConcurrencyConfig">REST API Reference for DeleteProvisionedConcurrencyConfig Operation</seealso>
        Task<DeleteProvisionedConcurrencyConfigResponse> DeleteProvisionedConcurrencyConfigAsync(DeleteProvisionedConcurrencyConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAccountSettings


        /// <summary>
        /// Retrieves details about your account's <a href="https://docs.aws.amazon.com/lambda/latest/dg/limits.html">limits</a>
        /// and usage in an Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request);



        /// <summary>
        /// Retrieves details about your account's <a href="https://docs.aws.amazon.com/lambda/latest/dg/limits.html">limits</a>
        /// and usage in an Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAlias


        /// <summary>
        /// Returns details about a Lambda function <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html">alias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlias service method.</param>
        /// 
        /// <returns>The response from the GetAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAlias">REST API Reference for GetAlias Operation</seealso>
        GetAliasResponse GetAlias(GetAliasRequest request);



        /// <summary>
        /// Returns details about a Lambda function <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html">alias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAlias">REST API Reference for GetAlias Operation</seealso>
        Task<GetAliasResponse> GetAliasAsync(GetAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCodeSigningConfig


        /// <summary>
        /// Returns information about the specified code signing configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the GetCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetCodeSigningConfig">REST API Reference for GetCodeSigningConfig Operation</seealso>
        GetCodeSigningConfigResponse GetCodeSigningConfig(GetCodeSigningConfigRequest request);



        /// <summary>
        /// Returns information about the specified code signing configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSigningConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetCodeSigningConfig">REST API Reference for GetCodeSigningConfig Operation</seealso>
        Task<GetCodeSigningConfigResponse> GetCodeSigningConfigAsync(GetCodeSigningConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEventSourceMapping


        /// <summary>
        /// Returns details about an event source mapping. You can get the identifier of a mapping
        /// from the output of <a>ListEventSourceMappings</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the GetEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetEventSourceMapping">REST API Reference for GetEventSourceMapping Operation</seealso>
        GetEventSourceMappingResponse GetEventSourceMapping(GetEventSourceMappingRequest request);



        /// <summary>
        /// Returns details about an event source mapping. You can get the identifier of a mapping
        /// from the output of <a>ListEventSourceMappings</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventSourceMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetEventSourceMapping">REST API Reference for GetEventSourceMapping Operation</seealso>
        Task<GetEventSourceMappingResponse> GetEventSourceMappingAsync(GetEventSourceMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFunction


        /// <summary>
        /// Returns information about the function or function version, with a link to download
        /// the deployment package that's valid for 10 minutes. If you specify a function version,
        /// only details that are specific to that version are returned.
        /// </summary>
        /// <param name="functionName">The name of the Lambda function, version, or alias. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> – <code>my-function</code> (name-only), <code>my-function:v1</code> (with alias). </li> <li>  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        GetFunctionResponse GetFunction(string functionName);

        /// <summary>
        /// Returns information about the function or function version, with a link to download
        /// the deployment package that's valid for 10 minutes. If you specify a function version,
        /// only details that are specific to that version are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        GetFunctionResponse GetFunction(GetFunctionRequest request);


        /// <summary>
        /// Returns information about the function or function version, with a link to download
        /// the deployment package that's valid for 10 minutes. If you specify a function version,
        /// only details that are specific to that version are returned.
        /// </summary>
        /// <param name="functionName">The name of the Lambda function, version, or alias. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> – <code>my-function</code> (name-only), <code>my-function:v1</code> (with alias). </li> <li>  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        Task<GetFunctionResponse> GetFunctionAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns information about the function or function version, with a link to download
        /// the deployment package that's valid for 10 minutes. If you specify a function version,
        /// only details that are specific to that version are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        Task<GetFunctionResponse> GetFunctionAsync(GetFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFunctionCodeSigningConfig


        /// <summary>
        /// Returns the code signing configuration for the specified function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the GetFunctionCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionCodeSigningConfig">REST API Reference for GetFunctionCodeSigningConfig Operation</seealso>
        GetFunctionCodeSigningConfigResponse GetFunctionCodeSigningConfig(GetFunctionCodeSigningConfigRequest request);



        /// <summary>
        /// Returns the code signing configuration for the specified function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionCodeSigningConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunctionCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionCodeSigningConfig">REST API Reference for GetFunctionCodeSigningConfig Operation</seealso>
        Task<GetFunctionCodeSigningConfigResponse> GetFunctionCodeSigningConfigAsync(GetFunctionCodeSigningConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFunctionConcurrency


        /// <summary>
        /// Returns details about the reserved concurrency configuration for a function. To set
        /// a concurrency limit for a function, use <a>PutFunctionConcurrency</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConcurrency service method.</param>
        /// 
        /// <returns>The response from the GetFunctionConcurrency service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConcurrency">REST API Reference for GetFunctionConcurrency Operation</seealso>
        GetFunctionConcurrencyResponse GetFunctionConcurrency(GetFunctionConcurrencyRequest request);



        /// <summary>
        /// Returns details about the reserved concurrency configuration for a function. To set
        /// a concurrency limit for a function, use <a>PutFunctionConcurrency</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConcurrency service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunctionConcurrency service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConcurrency">REST API Reference for GetFunctionConcurrency Operation</seealso>
        Task<GetFunctionConcurrencyResponse> GetFunctionConcurrencyAsync(GetFunctionConcurrencyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFunctionConfiguration


        /// <summary>
        /// Returns the version-specific settings of a Lambda function or version. The output
        /// includes only options that can vary between versions of a function. To modify these
        /// settings, use <a>UpdateFunctionConfiguration</a>.
        /// 
        ///  
        /// <para>
        /// To get all of a function's details, including function-level settings, use <a>GetFunction</a>.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function, version, or alias. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> – <code>my-function</code> (name-only), <code>my-function:v1</code> (with alias). </li> <li>  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// 
        /// <returns>The response from the GetFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        GetFunctionConfigurationResponse GetFunctionConfiguration(string functionName);

        /// <summary>
        /// Returns the version-specific settings of a Lambda function or version. The output
        /// includes only options that can vary between versions of a function. To modify these
        /// settings, use <a>UpdateFunctionConfiguration</a>.
        /// 
        ///  
        /// <para>
        /// To get all of a function's details, including function-level settings, use <a>GetFunction</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        GetFunctionConfigurationResponse GetFunctionConfiguration(GetFunctionConfigurationRequest request);


        /// <summary>
        /// Returns the version-specific settings of a Lambda function or version. The output
        /// includes only options that can vary between versions of a function. To modify these
        /// settings, use <a>UpdateFunctionConfiguration</a>.
        /// 
        ///  
        /// <para>
        /// To get all of a function's details, including function-level settings, use <a>GetFunction</a>.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function, version, or alias. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> – <code>my-function</code> (name-only), <code>my-function:v1</code> (with alias). </li> <li>  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        Task<GetFunctionConfigurationResponse> GetFunctionConfigurationAsync(string functionName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns the version-specific settings of a Lambda function or version. The output
        /// includes only options that can vary between versions of a function. To modify these
        /// settings, use <a>UpdateFunctionConfiguration</a>.
        /// 
        ///  
        /// <para>
        /// To get all of a function's details, including function-level settings, use <a>GetFunction</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        Task<GetFunctionConfigurationResponse> GetFunctionConfigurationAsync(GetFunctionConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFunctionEventInvokeConfig


        /// <summary>
        /// Retrieves the configuration for asynchronous invocation for a function, version, or
        /// alias.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionEventInvokeConfig service method.</param>
        /// 
        /// <returns>The response from the GetFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionEventInvokeConfig">REST API Reference for GetFunctionEventInvokeConfig Operation</seealso>
        GetFunctionEventInvokeConfigResponse GetFunctionEventInvokeConfig(GetFunctionEventInvokeConfigRequest request);



        /// <summary>
        /// Retrieves the configuration for asynchronous invocation for a function, version, or
        /// alias.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionEventInvokeConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionEventInvokeConfig">REST API Reference for GetFunctionEventInvokeConfig Operation</seealso>
        Task<GetFunctionEventInvokeConfigResponse> GetFunctionEventInvokeConfigAsync(GetFunctionEventInvokeConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFunctionUrlConfig


        /// <summary>
        /// Returns details about a Lambda function URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionUrlConfig service method.</param>
        /// 
        /// <returns>The response from the GetFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionUrlConfig">REST API Reference for GetFunctionUrlConfig Operation</seealso>
        GetFunctionUrlConfigResponse GetFunctionUrlConfig(GetFunctionUrlConfigRequest request);



        /// <summary>
        /// Returns details about a Lambda function URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionUrlConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionUrlConfig">REST API Reference for GetFunctionUrlConfig Operation</seealso>
        Task<GetFunctionUrlConfigResponse> GetFunctionUrlConfigAsync(GetFunctionUrlConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLayerVersion


        /// <summary>
        /// Returns information about a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>, with a link to download the layer archive that's valid for 10 minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersion service method.</param>
        /// 
        /// <returns>The response from the GetLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersion">REST API Reference for GetLayerVersion Operation</seealso>
        GetLayerVersionResponse GetLayerVersion(GetLayerVersionRequest request);



        /// <summary>
        /// Returns information about a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>, with a link to download the layer archive that's valid for 10 minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersion">REST API Reference for GetLayerVersion Operation</seealso>
        Task<GetLayerVersionResponse> GetLayerVersionAsync(GetLayerVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLayerVersionByArn


        /// <summary>
        /// Returns information about a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>, with a link to download the layer archive that's valid for 10 minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersionByArn service method.</param>
        /// 
        /// <returns>The response from the GetLayerVersionByArn service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionByArn">REST API Reference for GetLayerVersionByArn Operation</seealso>
        GetLayerVersionByArnResponse GetLayerVersionByArn(GetLayerVersionByArnRequest request);



        /// <summary>
        /// Returns information about a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>, with a link to download the layer archive that's valid for 10 minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersionByArn service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLayerVersionByArn service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionByArn">REST API Reference for GetLayerVersionByArn Operation</seealso>
        Task<GetLayerVersionByArnResponse> GetLayerVersionByArnAsync(GetLayerVersionByArnRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLayerVersionPolicy


        /// <summary>
        /// Returns the permission policy for a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. For more information, see <a>AddLayerVersionPermission</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersionPolicy service method.</param>
        /// 
        /// <returns>The response from the GetLayerVersionPolicy service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionPolicy">REST API Reference for GetLayerVersionPolicy Operation</seealso>
        GetLayerVersionPolicyResponse GetLayerVersionPolicy(GetLayerVersionPolicyRequest request);



        /// <summary>
        /// Returns the permission policy for a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. For more information, see <a>AddLayerVersionPermission</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLayerVersionPolicy service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionPolicy">REST API Reference for GetLayerVersionPolicy Operation</seealso>
        Task<GetLayerVersionPolicyResponse> GetLayerVersionPolicyAsync(GetLayerVersionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Returns the <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">resource-based
        /// IAM policy</a> for a function, version, or alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(GetPolicyRequest request);



        /// <summary>
        /// Returns the <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">resource-based
        /// IAM policy</a> for a function, version, or alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetProvisionedConcurrencyConfig


        /// <summary>
        /// Retrieves the provisioned concurrency configuration for a function's alias or version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedConcurrencyConfig service method.</param>
        /// 
        /// <returns>The response from the GetProvisionedConcurrencyConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ProvisionedConcurrencyConfigNotFoundException">
        /// The specified configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetProvisionedConcurrencyConfig">REST API Reference for GetProvisionedConcurrencyConfig Operation</seealso>
        GetProvisionedConcurrencyConfigResponse GetProvisionedConcurrencyConfig(GetProvisionedConcurrencyConfigRequest request);



        /// <summary>
        /// Retrieves the provisioned concurrency configuration for a function's alias or version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedConcurrencyConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProvisionedConcurrencyConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ProvisionedConcurrencyConfigNotFoundException">
        /// The specified configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetProvisionedConcurrencyConfig">REST API Reference for GetProvisionedConcurrencyConfig Operation</seealso>
        Task<GetProvisionedConcurrencyConfigResponse> GetProvisionedConcurrencyConfigAsync(GetProvisionedConcurrencyConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRuntimeManagementConfig


        /// <summary>
        /// Retrieves the runtime management configuration for a function's version. If the runtime
        /// update mode is <b>Manual</b>, this includes the ARN of the runtime version and the
        /// runtime update mode. If the runtime update mode is <b>Auto</b> or <b>Function update</b>,
        /// this includes the runtime update mode and <code>null</code> is returned for the ARN.
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/runtimes-update.html">Runtime
        /// updates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuntimeManagementConfig service method.</param>
        /// 
        /// <returns>The response from the GetRuntimeManagementConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetRuntimeManagementConfig">REST API Reference for GetRuntimeManagementConfig Operation</seealso>
        GetRuntimeManagementConfigResponse GetRuntimeManagementConfig(GetRuntimeManagementConfigRequest request);



        /// <summary>
        /// Retrieves the runtime management configuration for a function's version. If the runtime
        /// update mode is <b>Manual</b>, this includes the ARN of the runtime version and the
        /// runtime update mode. If the runtime update mode is <b>Auto</b> or <b>Function update</b>,
        /// this includes the runtime update mode and <code>null</code> is returned for the ARN.
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/runtimes-update.html">Runtime
        /// updates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuntimeManagementConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRuntimeManagementConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetRuntimeManagementConfig">REST API Reference for GetRuntimeManagementConfig Operation</seealso>
        Task<GetRuntimeManagementConfigResponse> GetRuntimeManagementConfigAsync(GetRuntimeManagementConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Invoke


        /// <summary>
        /// Invokes a Lambda function. You can invoke a function synchronously (and wait for the
        /// response), or asynchronously. To invoke a function asynchronously, set <code>InvocationType</code>
        /// to <code>Event</code>.
        /// 
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-sync.html">synchronous
        /// invocation</a>, details about the function response, including errors, are included
        /// in the response body and headers. For either invocation type, you can find more information
        /// in the <a href="https://docs.aws.amazon.com/lambda/latest/dg/monitoring-functions.html">execution
        /// log</a> and <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-x-ray.html">trace</a>.
        /// </para>
        ///  
        /// <para>
        /// When an error occurs, your function may be invoked multiple times. Retry behavior
        /// varies by error type, client, event source, and invocation type. For example, if you
        /// invoke a function asynchronously and it returns an error, Lambda executes the function
        /// up to two more times. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-retries.html">Error
        /// handling and automatic retries in Lambda</a>.
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html">asynchronous
        /// invocation</a>, Lambda adds events to a queue before sending them to your function.
        /// If your function does not have enough capacity to keep up with the queue, events may
        /// be lost. Occasionally, your function may receive the same event multiple times, even
        /// if no error occurs. To retain events that were not processed, configure your function
        /// with a <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-dlq">dead-letter
        /// queue</a>.
        /// </para>
        ///  
        /// <para>
        /// The status code in the API response doesn't reflect function errors. Error codes are
        /// reserved for errors that prevent your function from executing, such as permissions
        /// errors, <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">quota</a>
        /// errors, or issues with your function's code and configuration. For example, Lambda
        /// returns <code>TooManyRequestsException</code> if running the function would cause
        /// you to exceed a concurrency limit at either the account level (<code>ConcurrentInvocationLimitExceeded</code>)
        /// or function level (<code>ReservedFunctionConcurrentInvocationLimitExceeded</code>).
        /// </para>
        ///  
        /// <para>
        /// For functions with a long timeout, your client might disconnect during synchronous
        /// invocation while it waits for a response. Configure your HTTP client, SDK, firewall,
        /// proxy, or operating system to allow for long connections with timeout or keep-alive
        /// settings.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/list_awslambda.html">lambda:InvokeFunction</a>
        /// action. For details on how to set up permissions for cross-account invocations, see
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html#permissions-resource-xaccountinvoke">Granting
        /// function access to other accounts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Invoke service method.</param>
        /// 
        /// <returns>The response from the Invoke service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.EC2AccessDeniedException">
        /// Need additional permissions to configure VPC settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EC2ThrottledException">
        /// Amazon EC2 throttled Lambda during Lambda function initialization using the execution
        /// role provided for the function.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EC2UnexpectedException">
        /// Lambda received an unexpected Amazon EC2 client exception while setting up for the
        /// Lambda function.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSIOException">
        /// An error occurred when reading from or writing to a connected file system.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSMountConnectivityException">
        /// The Lambda function couldn't make a network connection to the configured file system.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSMountFailureException">
        /// The Lambda function couldn't mount the configured file system due to a permission
        /// or configuration issue.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSMountTimeoutException">
        /// The Lambda function made a network connection to the configured file system, but the
        /// mount operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ENILimitReachedException">
        /// Lambda couldn't create an elastic network interface in the VPC, specified as part
        /// of Lambda function configuration, because the limit for network interfaces has been
        /// reached. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRequestContentException">
        /// The request body could not be parsed as JSON.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRuntimeException">
        /// The runtime or runtime version specified is not supported.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidSecurityGroupIDException">
        /// The security group ID provided in the Lambda function VPC configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidSubnetIDException">
        /// The subnet ID provided in the Lambda function VPC configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidZipFileException">
        /// Lambda could not unzip the deployment package.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSAccessDeniedException">
        /// Lambda couldn't decrypt the environment variables because KMS access was denied. Check
        /// the Lambda function's KMS permissions.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSDisabledException">
        /// Lambda couldn't decrypt the environment variables because the KMS key used is disabled.
        /// Check the Lambda function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSInvalidStateException">
        /// Lambda couldn't decrypt the environment variables because the state of the KMS key
        /// used is not valid for Decrypt. Check the function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSNotFoundException">
        /// Lambda couldn't decrypt the environment variables because the KMS key was not found.
        /// Check the function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.RequestTooLargeException">
        /// The request payload exceeded the <code>Invoke</code> request body JSON input quota.
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotReadyException">
        /// The function is inactive and its VPC connection is no longer available. Wait for the
        /// VPC connection to reestablish and try again.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SnapStartException">
        /// The <code>afterRestore()</code> <a href="https://docs.aws.amazon.com/lambda/latest/dg/snapstart-runtime-hooks.html">runtime
        /// hook</a> encountered an error. For more information, check the Amazon CloudWatch logs.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SnapStartNotReadyException">
        /// Lambda is initializing your function. You can invoke the function when the <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">function
        /// state</a> becomes <code>Active</code>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SnapStartTimeoutException">
        /// Lambda couldn't restore the snapshot within the timeout limit.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SubnetIPAddressLimitReachedException">
        /// Lambda couldn't set up VPC access for the Lambda function because one or more configured
        /// subnets has no available IP addresses.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.UnsupportedMediaTypeException">
        /// The content type of the <code>Invoke</code> request body is not JSON.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/Invoke">REST API Reference for Invoke Operation</seealso>
        InvokeResponse Invoke(InvokeRequest request);



        /// <summary>
        /// Invokes a Lambda function. You can invoke a function synchronously (and wait for the
        /// response), or asynchronously. To invoke a function asynchronously, set <code>InvocationType</code>
        /// to <code>Event</code>.
        /// 
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-sync.html">synchronous
        /// invocation</a>, details about the function response, including errors, are included
        /// in the response body and headers. For either invocation type, you can find more information
        /// in the <a href="https://docs.aws.amazon.com/lambda/latest/dg/monitoring-functions.html">execution
        /// log</a> and <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-x-ray.html">trace</a>.
        /// </para>
        ///  
        /// <para>
        /// When an error occurs, your function may be invoked multiple times. Retry behavior
        /// varies by error type, client, event source, and invocation type. For example, if you
        /// invoke a function asynchronously and it returns an error, Lambda executes the function
        /// up to two more times. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-retries.html">Error
        /// handling and automatic retries in Lambda</a>.
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html">asynchronous
        /// invocation</a>, Lambda adds events to a queue before sending them to your function.
        /// If your function does not have enough capacity to keep up with the queue, events may
        /// be lost. Occasionally, your function may receive the same event multiple times, even
        /// if no error occurs. To retain events that were not processed, configure your function
        /// with a <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-dlq">dead-letter
        /// queue</a>.
        /// </para>
        ///  
        /// <para>
        /// The status code in the API response doesn't reflect function errors. Error codes are
        /// reserved for errors that prevent your function from executing, such as permissions
        /// errors, <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">quota</a>
        /// errors, or issues with your function's code and configuration. For example, Lambda
        /// returns <code>TooManyRequestsException</code> if running the function would cause
        /// you to exceed a concurrency limit at either the account level (<code>ConcurrentInvocationLimitExceeded</code>)
        /// or function level (<code>ReservedFunctionConcurrentInvocationLimitExceeded</code>).
        /// </para>
        ///  
        /// <para>
        /// For functions with a long timeout, your client might disconnect during synchronous
        /// invocation while it waits for a response. Configure your HTTP client, SDK, firewall,
        /// proxy, or operating system to allow for long connections with timeout or keep-alive
        /// settings.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/list_awslambda.html">lambda:InvokeFunction</a>
        /// action. For details on how to set up permissions for cross-account invocations, see
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html#permissions-resource-xaccountinvoke">Granting
        /// function access to other accounts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Invoke service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Invoke service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.EC2AccessDeniedException">
        /// Need additional permissions to configure VPC settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EC2ThrottledException">
        /// Amazon EC2 throttled Lambda during Lambda function initialization using the execution
        /// role provided for the function.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EC2UnexpectedException">
        /// Lambda received an unexpected Amazon EC2 client exception while setting up for the
        /// Lambda function.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSIOException">
        /// An error occurred when reading from or writing to a connected file system.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSMountConnectivityException">
        /// The Lambda function couldn't make a network connection to the configured file system.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSMountFailureException">
        /// The Lambda function couldn't mount the configured file system due to a permission
        /// or configuration issue.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSMountTimeoutException">
        /// The Lambda function made a network connection to the configured file system, but the
        /// mount operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ENILimitReachedException">
        /// Lambda couldn't create an elastic network interface in the VPC, specified as part
        /// of Lambda function configuration, because the limit for network interfaces has been
        /// reached. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRequestContentException">
        /// The request body could not be parsed as JSON.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRuntimeException">
        /// The runtime or runtime version specified is not supported.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidSecurityGroupIDException">
        /// The security group ID provided in the Lambda function VPC configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidSubnetIDException">
        /// The subnet ID provided in the Lambda function VPC configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidZipFileException">
        /// Lambda could not unzip the deployment package.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSAccessDeniedException">
        /// Lambda couldn't decrypt the environment variables because KMS access was denied. Check
        /// the Lambda function's KMS permissions.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSDisabledException">
        /// Lambda couldn't decrypt the environment variables because the KMS key used is disabled.
        /// Check the Lambda function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSInvalidStateException">
        /// Lambda couldn't decrypt the environment variables because the state of the KMS key
        /// used is not valid for Decrypt. Check the function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSNotFoundException">
        /// Lambda couldn't decrypt the environment variables because the KMS key was not found.
        /// Check the function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.RequestTooLargeException">
        /// The request payload exceeded the <code>Invoke</code> request body JSON input quota.
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotReadyException">
        /// The function is inactive and its VPC connection is no longer available. Wait for the
        /// VPC connection to reestablish and try again.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SnapStartException">
        /// The <code>afterRestore()</code> <a href="https://docs.aws.amazon.com/lambda/latest/dg/snapstart-runtime-hooks.html">runtime
        /// hook</a> encountered an error. For more information, check the Amazon CloudWatch logs.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SnapStartNotReadyException">
        /// Lambda is initializing your function. You can invoke the function when the <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">function
        /// state</a> becomes <code>Active</code>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SnapStartTimeoutException">
        /// Lambda couldn't restore the snapshot within the timeout limit.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SubnetIPAddressLimitReachedException">
        /// Lambda couldn't set up VPC access for the Lambda function because one or more configured
        /// subnets has no available IP addresses.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.UnsupportedMediaTypeException">
        /// The content type of the <code>Invoke</code> request body is not JSON.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/Invoke">REST API Reference for Invoke Operation</seealso>
        Task<InvokeResponse> InvokeAsync(InvokeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InvokeAsync


        /// <summary>
        /// <important> 
        /// <para>
        /// For asynchronous function invocation, use <a>Invoke</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Invokes a function asynchronously.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync service method.</param>
        /// 
        /// <returns>The response from the InvokeAsync service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidRequestContentException">
        /// The request body could not be parsed as JSON.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRuntimeException">
        /// The runtime or runtime version specified is not supported.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/InvokeAsync">REST API Reference for InvokeAsync Operation</seealso>
        [Obsolete("For .NET 3.5/4.5, API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// For asynchronous function invocation, use <a>Invoke</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Invokes a function asynchronously.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeAsync service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidRequestContentException">
        /// The request body could not be parsed as JSON.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRuntimeException">
        /// The runtime or runtime version specified is not supported.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/InvokeAsync">REST API Reference for InvokeAsync Operation</seealso>
        [Obsolete("For .NET 3.5/4.5, API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html">aliases</a>
        /// for a Lambda function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListAliases">REST API Reference for ListAliases Operation</seealso>
        ListAliasesResponse ListAliases(ListAliasesRequest request);



        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html">aliases</a>
        /// for a Lambda function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListAliases">REST API Reference for ListAliases Operation</seealso>
        Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCodeSigningConfigs


        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuring-codesigning.html">code
        /// signing configurations</a>. A request returns up to 10,000 configurations per call.
        /// You can use the <code>MaxItems</code> parameter to return fewer configurations per
        /// call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSigningConfigs service method.</param>
        /// 
        /// <returns>The response from the ListCodeSigningConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListCodeSigningConfigs">REST API Reference for ListCodeSigningConfigs Operation</seealso>
        ListCodeSigningConfigsResponse ListCodeSigningConfigs(ListCodeSigningConfigsRequest request);



        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuring-codesigning.html">code
        /// signing configurations</a>. A request returns up to 10,000 configurations per call.
        /// You can use the <code>MaxItems</code> parameter to return fewer configurations per
        /// call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSigningConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeSigningConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListCodeSigningConfigs">REST API Reference for ListCodeSigningConfigs Operation</seealso>
        Task<ListCodeSigningConfigsResponse> ListCodeSigningConfigsAsync(ListCodeSigningConfigsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEventSourceMappings


        /// <summary>
        /// Lists event source mappings. Specify an <code>EventSourceArn</code> to show only event
        /// source mappings for a single event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSourceMappings service method.</param>
        /// 
        /// <returns>The response from the ListEventSourceMappings service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListEventSourceMappings">REST API Reference for ListEventSourceMappings Operation</seealso>
        ListEventSourceMappingsResponse ListEventSourceMappings(ListEventSourceMappingsRequest request);



        /// <summary>
        /// Lists event source mappings. Specify an <code>EventSourceArn</code> to show only event
        /// source mappings for a single event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSourceMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventSourceMappings service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListEventSourceMappings">REST API Reference for ListEventSourceMappings Operation</seealso>
        Task<ListEventSourceMappingsResponse> ListEventSourceMappingsAsync(ListEventSourceMappingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFunctionEventInvokeConfigs


        /// <summary>
        /// Retrieves a list of configurations for asynchronous invocation for a function.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionEventInvokeConfigs service method.</param>
        /// 
        /// <returns>The response from the ListFunctionEventInvokeConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionEventInvokeConfigs">REST API Reference for ListFunctionEventInvokeConfigs Operation</seealso>
        ListFunctionEventInvokeConfigsResponse ListFunctionEventInvokeConfigs(ListFunctionEventInvokeConfigsRequest request);



        /// <summary>
        /// Retrieves a list of configurations for asynchronous invocation for a function.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionEventInvokeConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFunctionEventInvokeConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionEventInvokeConfigs">REST API Reference for ListFunctionEventInvokeConfigs Operation</seealso>
        Task<ListFunctionEventInvokeConfigsResponse> ListFunctionEventInvokeConfigsAsync(ListFunctionEventInvokeConfigsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFunctions


        /// <summary>
        /// Returns a list of Lambda functions, with the version-specific configuration of each.
        /// Lambda returns up to 50 functions per call.
        /// 
        ///  
        /// <para>
        /// Set <code>FunctionVersion</code> to <code>ALL</code> to include all published versions
        /// of each function in addition to the unpublished version.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>ListFunctions</code> operation returns a subset of the <a>FunctionConfiguration</a>
        /// fields. To get the additional fields (State, StateReasonCode, StateReason, LastUpdateStatus,
        /// LastUpdateStatusReason, LastUpdateStatusReasonCode, RuntimeVersionConfig) for a function
        /// or version, use <a>GetFunction</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        ListFunctionsResponse ListFunctions();

        /// <summary>
        /// Returns a list of Lambda functions, with the version-specific configuration of each.
        /// Lambda returns up to 50 functions per call.
        /// 
        ///  
        /// <para>
        /// Set <code>FunctionVersion</code> to <code>ALL</code> to include all published versions
        /// of each function in addition to the unpublished version.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>ListFunctions</code> operation returns a subset of the <a>FunctionConfiguration</a>
        /// fields. To get the additional fields (State, StateReasonCode, StateReason, LastUpdateStatus,
        /// LastUpdateStatusReason, LastUpdateStatusReasonCode, RuntimeVersionConfig) for a function
        /// or version, use <a>GetFunction</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        ListFunctionsResponse ListFunctions(ListFunctionsRequest request);


        /// <summary>
        /// Returns a list of Lambda functions, with the version-specific configuration of each.
        /// Lambda returns up to 50 functions per call.
        /// 
        ///  
        /// <para>
        /// Set <code>FunctionVersion</code> to <code>ALL</code> to include all published versions
        /// of each function in addition to the unpublished version.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>ListFunctions</code> operation returns a subset of the <a>FunctionConfiguration</a>
        /// fields. To get the additional fields (State, StateReasonCode, StateReason, LastUpdateStatus,
        /// LastUpdateStatusReason, LastUpdateStatusReasonCode, RuntimeVersionConfig) for a function
        /// or version, use <a>GetFunction</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        Task<ListFunctionsResponse> ListFunctionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns a list of Lambda functions, with the version-specific configuration of each.
        /// Lambda returns up to 50 functions per call.
        /// 
        ///  
        /// <para>
        /// Set <code>FunctionVersion</code> to <code>ALL</code> to include all published versions
        /// of each function in addition to the unpublished version.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>ListFunctions</code> operation returns a subset of the <a>FunctionConfiguration</a>
        /// fields. To get the additional fields (State, StateReasonCode, StateReason, LastUpdateStatus,
        /// LastUpdateStatusReason, LastUpdateStatusReasonCode, RuntimeVersionConfig) for a function
        /// or version, use <a>GetFunction</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFunctionsByCodeSigningConfig


        /// <summary>
        /// List the functions that use the specified code signing configuration. You can use
        /// this method prior to deleting a code signing configuration, to verify that no functions
        /// are using it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionsByCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the ListFunctionsByCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionsByCodeSigningConfig">REST API Reference for ListFunctionsByCodeSigningConfig Operation</seealso>
        ListFunctionsByCodeSigningConfigResponse ListFunctionsByCodeSigningConfig(ListFunctionsByCodeSigningConfigRequest request);



        /// <summary>
        /// List the functions that use the specified code signing configuration. You can use
        /// this method prior to deleting a code signing configuration, to verify that no functions
        /// are using it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionsByCodeSigningConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFunctionsByCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionsByCodeSigningConfig">REST API Reference for ListFunctionsByCodeSigningConfig Operation</seealso>
        Task<ListFunctionsByCodeSigningConfigResponse> ListFunctionsByCodeSigningConfigAsync(ListFunctionsByCodeSigningConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFunctionUrlConfigs


        /// <summary>
        /// Returns a list of Lambda function URLs for the specified function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionUrlConfigs service method.</param>
        /// 
        /// <returns>The response from the ListFunctionUrlConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionUrlConfigs">REST API Reference for ListFunctionUrlConfigs Operation</seealso>
        ListFunctionUrlConfigsResponse ListFunctionUrlConfigs(ListFunctionUrlConfigsRequest request);



        /// <summary>
        /// Returns a list of Lambda function URLs for the specified function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionUrlConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFunctionUrlConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionUrlConfigs">REST API Reference for ListFunctionUrlConfigs Operation</seealso>
        Task<ListFunctionUrlConfigsResponse> ListFunctionUrlConfigsAsync(ListFunctionUrlConfigsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLayers


        /// <summary>
        /// Lists <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-layers.html">Lambda
        /// layers</a> and shows information about the latest version of each. Specify a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
        /// identifier</a> to list only layers that indicate that they're compatible with that
        /// runtime. Specify a compatible architecture to include only layers that are compatible
        /// with that <a href="https://docs.aws.amazon.com/lambda/latest/dg/foundation-arch.html">instruction
        /// set architecture</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayers service method.</param>
        /// 
        /// <returns>The response from the ListLayers service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayers">REST API Reference for ListLayers Operation</seealso>
        ListLayersResponse ListLayers(ListLayersRequest request);



        /// <summary>
        /// Lists <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-layers.html">Lambda
        /// layers</a> and shows information about the latest version of each. Specify a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
        /// identifier</a> to list only layers that indicate that they're compatible with that
        /// runtime. Specify a compatible architecture to include only layers that are compatible
        /// with that <a href="https://docs.aws.amazon.com/lambda/latest/dg/foundation-arch.html">instruction
        /// set architecture</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLayers service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayers">REST API Reference for ListLayers Operation</seealso>
        Task<ListLayersResponse> ListLayersAsync(ListLayersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLayerVersions


        /// <summary>
        /// Lists the versions of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. Versions that have been deleted aren't listed. Specify a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
        /// identifier</a> to list only versions that indicate that they're compatible with that
        /// runtime. Specify a compatible architecture to include only layer versions that are
        /// compatible with that architecture.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayerVersions service method.</param>
        /// 
        /// <returns>The response from the ListLayerVersions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayerVersions">REST API Reference for ListLayerVersions Operation</seealso>
        ListLayerVersionsResponse ListLayerVersions(ListLayerVersionsRequest request);



        /// <summary>
        /// Lists the versions of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. Versions that have been deleted aren't listed. Specify a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
        /// identifier</a> to list only versions that indicate that they're compatible with that
        /// runtime. Specify a compatible architecture to include only layer versions that are
        /// compatible with that architecture.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayerVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLayerVersions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayerVersions">REST API Reference for ListLayerVersions Operation</seealso>
        Task<ListLayerVersionsResponse> ListLayerVersionsAsync(ListLayerVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProvisionedConcurrencyConfigs


        /// <summary>
        /// Retrieves a list of provisioned concurrency configurations for a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedConcurrencyConfigs service method.</param>
        /// 
        /// <returns>The response from the ListProvisionedConcurrencyConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListProvisionedConcurrencyConfigs">REST API Reference for ListProvisionedConcurrencyConfigs Operation</seealso>
        ListProvisionedConcurrencyConfigsResponse ListProvisionedConcurrencyConfigs(ListProvisionedConcurrencyConfigsRequest request);



        /// <summary>
        /// Retrieves a list of provisioned concurrency configurations for a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedConcurrencyConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProvisionedConcurrencyConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListProvisionedConcurrencyConfigs">REST API Reference for ListProvisionedConcurrencyConfigs Operation</seealso>
        Task<ListProvisionedConcurrencyConfigsResponse> ListProvisionedConcurrencyConfigsAsync(ListProvisionedConcurrencyConfigsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Returns a function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>.
        /// You can also view tags with <a>GetFunction</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);



        /// <summary>
        /// Returns a function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>.
        /// You can also view tags with <a>GetFunction</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVersionsByFunction


        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">versions</a>,
        /// with the version-specific configuration of each. Lambda returns up to 50 versions
        /// per call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersionsByFunction service method.</param>
        /// 
        /// <returns>The response from the ListVersionsByFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListVersionsByFunction">REST API Reference for ListVersionsByFunction Operation</seealso>
        ListVersionsByFunctionResponse ListVersionsByFunction(ListVersionsByFunctionRequest request);



        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">versions</a>,
        /// with the version-specific configuration of each. Lambda returns up to 50 versions
        /// per call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersionsByFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersionsByFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListVersionsByFunction">REST API Reference for ListVersionsByFunction Operation</seealso>
        Task<ListVersionsByFunctionResponse> ListVersionsByFunctionAsync(ListVersionsByFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PublishLayerVersion


        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a> from a ZIP archive. Each time you call <code>PublishLayerVersion</code>
        /// with the same layer name, a new version is created.
        /// 
        ///  
        /// <para>
        /// Add layers to your function with <a>CreateFunction</a> or <a>UpdateFunctionConfiguration</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishLayerVersion service method.</param>
        /// 
        /// <returns>The response from the PublishLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishLayerVersion">REST API Reference for PublishLayerVersion Operation</seealso>
        PublishLayerVersionResponse PublishLayerVersion(PublishLayerVersionRequest request);



        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a> from a ZIP archive. Each time you call <code>PublishLayerVersion</code>
        /// with the same layer name, a new version is created.
        /// 
        ///  
        /// <para>
        /// Add layers to your function with <a>CreateFunction</a> or <a>UpdateFunctionConfiguration</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishLayerVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishLayerVersion">REST API Reference for PublishLayerVersion Operation</seealso>
        Task<PublishLayerVersionResponse> PublishLayerVersionAsync(PublishLayerVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PublishVersion


        /// <summary>
        /// Creates a <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">version</a>
        /// from the current code and configuration of a function. Use versions to create a snapshot
        /// of your function code and configuration that doesn't change.
        /// 
        ///  
        /// <para>
        /// Lambda doesn't publish a version if the function's configuration and code haven't
        /// changed since the last version. Use <a>UpdateFunctionCode</a> or <a>UpdateFunctionConfiguration</a>
        /// to update the function before publishing a version.
        /// </para>
        ///  
        /// <para>
        /// Clients can invoke versions directly or with an alias. To create an alias, use <a>CreateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishVersion service method.</param>
        /// 
        /// <returns>The response from the PublishVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishVersion">REST API Reference for PublishVersion Operation</seealso>
        PublishVersionResponse PublishVersion(PublishVersionRequest request);



        /// <summary>
        /// Creates a <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">version</a>
        /// from the current code and configuration of a function. Use versions to create a snapshot
        /// of your function code and configuration that doesn't change.
        /// 
        ///  
        /// <para>
        /// Lambda doesn't publish a version if the function's configuration and code haven't
        /// changed since the last version. Use <a>UpdateFunctionCode</a> or <a>UpdateFunctionConfiguration</a>
        /// to update the function before publishing a version.
        /// </para>
        ///  
        /// <para>
        /// Clients can invoke versions directly or with an alias. To create an alias, use <a>CreateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishVersion">REST API Reference for PublishVersion Operation</seealso>
        Task<PublishVersionResponse> PublishVersionAsync(PublishVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutFunctionCodeSigningConfig


        /// <summary>
        /// Update the code signing configuration for the function. Changes to the code signing
        /// configuration take effect the next time a user tries to deploy a code package to the
        /// function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the PutFunctionCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionCodeSigningConfig">REST API Reference for PutFunctionCodeSigningConfig Operation</seealso>
        PutFunctionCodeSigningConfigResponse PutFunctionCodeSigningConfig(PutFunctionCodeSigningConfigRequest request);



        /// <summary>
        /// Update the code signing configuration for the function. Changes to the code signing
        /// configuration take effect the next time a user tries to deploy a code package to the
        /// function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionCodeSigningConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFunctionCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionCodeSigningConfig">REST API Reference for PutFunctionCodeSigningConfig Operation</seealso>
        Task<PutFunctionCodeSigningConfigResponse> PutFunctionCodeSigningConfigAsync(PutFunctionCodeSigningConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutFunctionConcurrency


        /// <summary>
        /// Sets the maximum number of simultaneous executions for a function, and reserves capacity
        /// for that concurrency level.
        /// 
        ///  
        /// <para>
        /// Concurrency settings apply to the function as a whole, including all published versions
        /// and the unpublished version. Reserving concurrency both ensures that your function
        /// has capacity to process the specified number of events simultaneously, and prevents
        /// it from scaling beyond that level. Use <a>GetFunction</a> to see the current setting
        /// for a function.
        /// </para>
        ///  
        /// <para>
        /// Use <a>GetAccountSettings</a> to see your Regional concurrency limit. You can reserve
        /// concurrency for as many functions as you like, as long as you leave at least 100 simultaneous
        /// executions unreserved for functions that aren't configured with a per-function limit.
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-scaling.html">Lambda
        /// function scaling</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionConcurrency service method.</param>
        /// 
        /// <returns>The response from the PutFunctionConcurrency service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionConcurrency">REST API Reference for PutFunctionConcurrency Operation</seealso>
        PutFunctionConcurrencyResponse PutFunctionConcurrency(PutFunctionConcurrencyRequest request);



        /// <summary>
        /// Sets the maximum number of simultaneous executions for a function, and reserves capacity
        /// for that concurrency level.
        /// 
        ///  
        /// <para>
        /// Concurrency settings apply to the function as a whole, including all published versions
        /// and the unpublished version. Reserving concurrency both ensures that your function
        /// has capacity to process the specified number of events simultaneously, and prevents
        /// it from scaling beyond that level. Use <a>GetFunction</a> to see the current setting
        /// for a function.
        /// </para>
        ///  
        /// <para>
        /// Use <a>GetAccountSettings</a> to see your Regional concurrency limit. You can reserve
        /// concurrency for as many functions as you like, as long as you leave at least 100 simultaneous
        /// executions unreserved for functions that aren't configured with a per-function limit.
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-scaling.html">Lambda
        /// function scaling</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionConcurrency service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFunctionConcurrency service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionConcurrency">REST API Reference for PutFunctionConcurrency Operation</seealso>
        Task<PutFunctionConcurrencyResponse> PutFunctionConcurrencyAsync(PutFunctionConcurrencyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutFunctionEventInvokeConfig


        /// <summary>
        /// Configures options for <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html">asynchronous
        /// invocation</a> on a function, version, or alias. If a configuration already exists
        /// for a function, version, or alias, this operation overwrites it. If you exclude any
        /// settings, they are removed. To set one option without affecting existing settings
        /// for other options, use <a>UpdateFunctionEventInvokeConfig</a>.
        /// 
        ///  
        /// <para>
        /// By default, Lambda retries an asynchronous invocation twice if the function returns
        /// an error. It retains events in a queue for up to six hours. When an event fails all
        /// processing attempts or stays in the asynchronous invocation queue for too long, Lambda
        /// discards it. To retain discarded events, configure a dead-letter queue with <a>UpdateFunctionConfiguration</a>.
        /// </para>
        ///  
        /// <para>
        /// To send an invocation record to a queue, topic, function, or event bus, specify a
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-async-destinations">destination</a>.
        /// You can configure separate destinations for successful invocations (on-success) and
        /// events that fail all processing attempts (on-failure). You can configure destinations
        /// in addition to or instead of a dead-letter queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionEventInvokeConfig service method.</param>
        /// 
        /// <returns>The response from the PutFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionEventInvokeConfig">REST API Reference for PutFunctionEventInvokeConfig Operation</seealso>
        PutFunctionEventInvokeConfigResponse PutFunctionEventInvokeConfig(PutFunctionEventInvokeConfigRequest request);



        /// <summary>
        /// Configures options for <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html">asynchronous
        /// invocation</a> on a function, version, or alias. If a configuration already exists
        /// for a function, version, or alias, this operation overwrites it. If you exclude any
        /// settings, they are removed. To set one option without affecting existing settings
        /// for other options, use <a>UpdateFunctionEventInvokeConfig</a>.
        /// 
        ///  
        /// <para>
        /// By default, Lambda retries an asynchronous invocation twice if the function returns
        /// an error. It retains events in a queue for up to six hours. When an event fails all
        /// processing attempts or stays in the asynchronous invocation queue for too long, Lambda
        /// discards it. To retain discarded events, configure a dead-letter queue with <a>UpdateFunctionConfiguration</a>.
        /// </para>
        ///  
        /// <para>
        /// To send an invocation record to a queue, topic, function, or event bus, specify a
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-async-destinations">destination</a>.
        /// You can configure separate destinations for successful invocations (on-success) and
        /// events that fail all processing attempts (on-failure). You can configure destinations
        /// in addition to or instead of a dead-letter queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionEventInvokeConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionEventInvokeConfig">REST API Reference for PutFunctionEventInvokeConfig Operation</seealso>
        Task<PutFunctionEventInvokeConfigResponse> PutFunctionEventInvokeConfigAsync(PutFunctionEventInvokeConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutProvisionedConcurrencyConfig


        /// <summary>
        /// Adds a provisioned concurrency configuration to a function's alias or version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProvisionedConcurrencyConfig service method.</param>
        /// 
        /// <returns>The response from the PutProvisionedConcurrencyConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutProvisionedConcurrencyConfig">REST API Reference for PutProvisionedConcurrencyConfig Operation</seealso>
        PutProvisionedConcurrencyConfigResponse PutProvisionedConcurrencyConfig(PutProvisionedConcurrencyConfigRequest request);



        /// <summary>
        /// Adds a provisioned concurrency configuration to a function's alias or version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProvisionedConcurrencyConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutProvisionedConcurrencyConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutProvisionedConcurrencyConfig">REST API Reference for PutProvisionedConcurrencyConfig Operation</seealso>
        Task<PutProvisionedConcurrencyConfigResponse> PutProvisionedConcurrencyConfigAsync(PutProvisionedConcurrencyConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRuntimeManagementConfig


        /// <summary>
        /// Sets the runtime management configuration for a function's version. For more information,
        /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/runtimes-update.html">Runtime
        /// updates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRuntimeManagementConfig service method.</param>
        /// 
        /// <returns>The response from the PutRuntimeManagementConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutRuntimeManagementConfig">REST API Reference for PutRuntimeManagementConfig Operation</seealso>
        PutRuntimeManagementConfigResponse PutRuntimeManagementConfig(PutRuntimeManagementConfigRequest request);



        /// <summary>
        /// Sets the runtime management configuration for a function's version. For more information,
        /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/runtimes-update.html">Runtime
        /// updates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRuntimeManagementConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRuntimeManagementConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutRuntimeManagementConfig">REST API Reference for PutRuntimeManagementConfig Operation</seealso>
        Task<PutRuntimeManagementConfigResponse> PutRuntimeManagementConfigAsync(PutRuntimeManagementConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveLayerVersionPermission


        /// <summary>
        /// Removes a statement from the permissions policy for a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. For more information, see <a>AddLayerVersionPermission</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveLayerVersionPermission service method.</param>
        /// 
        /// <returns>The response from the RemoveLayerVersionPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemoveLayerVersionPermission">REST API Reference for RemoveLayerVersionPermission Operation</seealso>
        RemoveLayerVersionPermissionResponse RemoveLayerVersionPermission(RemoveLayerVersionPermissionRequest request);



        /// <summary>
        /// Removes a statement from the permissions policy for a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. For more information, see <a>AddLayerVersionPermission</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveLayerVersionPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveLayerVersionPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemoveLayerVersionPermission">REST API Reference for RemoveLayerVersionPermission Operation</seealso>
        Task<RemoveLayerVersionPermissionResponse> RemoveLayerVersionPermissionAsync(RemoveLayerVersionPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemovePermission


        /// <summary>
        /// Revokes function-use permission from an Amazon Web Service or another Amazon Web Services
        /// account. You can get the ID of the statement from the output of <a>GetPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);



        /// <summary>
        /// Revokes function-use permission from an Amazon Web Service or another Amazon Web Services
        /// account. You can get the ID of the statement from the output of <a>GetPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds <a href="https://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>
        /// to a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds <a href="https://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>
        /// to a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes <a href="https://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>
        /// from a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes <a href="https://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>
        /// from a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAlias


        /// <summary>
        /// Updates the configuration of a Lambda function <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html">alias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        UpdateAliasResponse UpdateAlias(UpdateAliasRequest request);



        /// <summary>
        /// Updates the configuration of a Lambda function <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-aliases.html">alias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCodeSigningConfig


        /// <summary>
        /// Update the code signing configuration. Changes to the code signing configuration take
        /// effect the next time a user tries to deploy a code package to the function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateCodeSigningConfig">REST API Reference for UpdateCodeSigningConfig Operation</seealso>
        UpdateCodeSigningConfigResponse UpdateCodeSigningConfig(UpdateCodeSigningConfigRequest request);



        /// <summary>
        /// Update the code signing configuration. Changes to the code signing configuration take
        /// effect the next time a user tries to deploy a code package to the function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSigningConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateCodeSigningConfig">REST API Reference for UpdateCodeSigningConfig Operation</seealso>
        Task<UpdateCodeSigningConfigResponse> UpdateCodeSigningConfigAsync(UpdateCodeSigningConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEventSourceMapping


        /// <summary>
        /// Updates an event source mapping. You can change the function that Lambda invokes,
        /// or pause invocation and resume later from the same location.
        /// 
        ///  
        /// <para>
        /// For details about how to configure different event sources, see the following topics.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-dynamodb-eventsourcemapping">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-eventsourcemapping">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-eventsource">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-eventsourcemapping">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html"> Amazon MSK</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/kafka-smaa.html"> Apache Kafka</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following error handling options are available only for stream sources (DynamoDB
        /// and Kinesis):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BisectBatchOnFunctionError</code> – If the function returns an error, split
        /// the batch in two and retry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationConfig</code> – Send discarded records to an Amazon SQS queue or
        /// Amazon SNS topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRecordAgeInSeconds</code> – Discard records older than the specified
        /// age. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRetryAttempts</code> – Discard records after the specified number of
        /// retries. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ParallelizationFactor</code> – Process multiple batches from each shard concurrently.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about which configuration parameters apply to each event source, see
        /// the following topics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-ddb-params">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-params">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#services-sqs-params">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-params">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#services-msk-parms">
        /// Amazon MSK</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kafka.html#services-kafka-parms">
        /// Apache Kafka</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example, you tried to
        /// update an event source mapping in the CREATING state, or you tried to delete an event
        /// source mapping currently UPDATING.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateEventSourceMapping">REST API Reference for UpdateEventSourceMapping Operation</seealso>
        UpdateEventSourceMappingResponse UpdateEventSourceMapping(UpdateEventSourceMappingRequest request);



        /// <summary>
        /// Updates an event source mapping. You can change the function that Lambda invokes,
        /// or pause invocation and resume later from the same location.
        /// 
        ///  
        /// <para>
        /// For details about how to configure different event sources, see the following topics.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-dynamodb-eventsourcemapping">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-eventsourcemapping">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-eventsource">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-eventsourcemapping">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html"> Amazon MSK</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/kafka-smaa.html"> Apache Kafka</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following error handling options are available only for stream sources (DynamoDB
        /// and Kinesis):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BisectBatchOnFunctionError</code> – If the function returns an error, split
        /// the batch in two and retry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationConfig</code> – Send discarded records to an Amazon SQS queue or
        /// Amazon SNS topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRecordAgeInSeconds</code> – Discard records older than the specified
        /// age. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRetryAttempts</code> – Discard records after the specified number of
        /// retries. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ParallelizationFactor</code> – Process multiple batches from each shard concurrently.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about which configuration parameters apply to each event source, see
        /// the following topics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-ddb-params">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-params">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#services-sqs-params">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-params">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#services-msk-parms">
        /// Amazon MSK</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kafka.html#services-kafka-parms">
        /// Apache Kafka</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSourceMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example, you tried to
        /// update an event source mapping in the CREATING state, or you tried to delete an event
        /// source mapping currently UPDATING.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateEventSourceMapping">REST API Reference for UpdateEventSourceMapping Operation</seealso>
        Task<UpdateEventSourceMappingResponse> UpdateEventSourceMappingAsync(UpdateEventSourceMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFunctionCode


        /// <summary>
        /// Updates a Lambda function's code. If code signing is enabled for the function, the
        /// code package must be signed by a trusted publisher. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html">Configuring
        /// code signing for Lambda</a>.
        /// 
        ///  
        /// <para>
        /// If the function's package type is <code>Image</code>, then you must specify the code
        /// package in <code>ImageUri</code> as the URI of a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-images.html">container
        /// image</a> in the Amazon ECR registry.
        /// </para>
        ///  
        /// <para>
        /// If the function's package type is <code>Zip</code>, then you must specify the deployment
        /// package as a <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-package.html#gettingstarted-package-zip">.zip
        /// file archive</a>. Enter the Amazon S3 bucket and key of the code .zip file location.
        /// You can also provide the function code inline using the <code>ZipFile</code> field.
        /// </para>
        ///  
        /// <para>
        /// The code in the deployment package must be compatible with the target instruction
        /// set architecture of the function (<code>x86-64</code> or <code>arm64</code>).
        /// </para>
        ///  
        /// <para>
        /// The function's code is locked when you publish a version. You can't modify the code
        /// of a published version, only the unpublished version.
        /// </para>
        ///  <note> 
        /// <para>
        /// For a function defined as a container image, Lambda resolves the image tag to an image
        /// digest. In Amazon ECR, if you update the image tag to a new image, Lambda does not
        /// automatically update the function.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionCode service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionCode service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeVerificationFailedException">
        /// The code signature failed one or more of the validation checks for signature mismatch
        /// or expiry, and the code signing policy is set to ENFORCE. Lambda blocks the deployment.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidCodeSignatureException">
        /// The code signature failed the integrity check. If the integrity check fails, then
        /// Lambda blocks deployment, even if the code signing policy is set to WARN.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionCode">REST API Reference for UpdateFunctionCode Operation</seealso>
        UpdateFunctionCodeResponse UpdateFunctionCode(UpdateFunctionCodeRequest request);



        /// <summary>
        /// Updates a Lambda function's code. If code signing is enabled for the function, the
        /// code package must be signed by a trusted publisher. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html">Configuring
        /// code signing for Lambda</a>.
        /// 
        ///  
        /// <para>
        /// If the function's package type is <code>Image</code>, then you must specify the code
        /// package in <code>ImageUri</code> as the URI of a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-images.html">container
        /// image</a> in the Amazon ECR registry.
        /// </para>
        ///  
        /// <para>
        /// If the function's package type is <code>Zip</code>, then you must specify the deployment
        /// package as a <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-package.html#gettingstarted-package-zip">.zip
        /// file archive</a>. Enter the Amazon S3 bucket and key of the code .zip file location.
        /// You can also provide the function code inline using the <code>ZipFile</code> field.
        /// </para>
        ///  
        /// <para>
        /// The code in the deployment package must be compatible with the target instruction
        /// set architecture of the function (<code>x86-64</code> or <code>arm64</code>).
        /// </para>
        ///  
        /// <para>
        /// The function's code is locked when you publish a version. You can't modify the code
        /// of a published version, only the unpublished version.
        /// </para>
        ///  <note> 
        /// <para>
        /// For a function defined as a container image, Lambda resolves the image tag to an image
        /// digest. In Amazon ECR, if you update the image tag to a new image, Lambda does not
        /// automatically update the function.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFunctionCode service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeVerificationFailedException">
        /// The code signature failed one or more of the validation checks for signature mismatch
        /// or expiry, and the code signing policy is set to ENFORCE. Lambda blocks the deployment.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidCodeSignatureException">
        /// The code signature failed the integrity check. If the integrity check fails, then
        /// Lambda blocks deployment, even if the code signing policy is set to WARN.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionCode">REST API Reference for UpdateFunctionCode Operation</seealso>
        Task<UpdateFunctionCodeResponse> UpdateFunctionCodeAsync(UpdateFunctionCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFunctionConfiguration


        /// <summary>
        /// Modify the version-specific settings of a Lambda function.
        /// 
        ///  
        /// <para>
        /// When you update a function, Lambda provisions an instance of the function and its
        /// supporting resources. If your function connects to a VPC, this process can take a
        /// minute. During this time, you can't modify the function, but you can still invoke
        /// it. The <code>LastUpdateStatus</code>, <code>LastUpdateStatusReason</code>, and <code>LastUpdateStatusReasonCode</code>
        /// fields in the response from <a>GetFunctionConfiguration</a> indicate when the update
        /// is complete and the function is processing events with the new configuration. For
        /// more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">Lambda
        /// function states</a>.
        /// </para>
        ///  
        /// <para>
        /// These settings can vary between versions of a function and are locked when you publish
        /// a version. You can't modify the configuration of a published version, only the unpublished
        /// version.
        /// </para>
        ///  
        /// <para>
        /// To configure function concurrency, use <a>PutFunctionConcurrency</a>. To grant invoke
        /// permissions to an Amazon Web Services account or Amazon Web Service, use <a>AddPermission</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeVerificationFailedException">
        /// The code signature failed one or more of the validation checks for signature mismatch
        /// or expiry, and the code signing policy is set to ENFORCE. Lambda blocks the deployment.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidCodeSignatureException">
        /// The code signature failed the integrity check. If the integrity check fails, then
        /// Lambda blocks deployment, even if the code signing policy is set to WARN.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionConfiguration">REST API Reference for UpdateFunctionConfiguration Operation</seealso>
        UpdateFunctionConfigurationResponse UpdateFunctionConfiguration(UpdateFunctionConfigurationRequest request);



        /// <summary>
        /// Modify the version-specific settings of a Lambda function.
        /// 
        ///  
        /// <para>
        /// When you update a function, Lambda provisions an instance of the function and its
        /// supporting resources. If your function connects to a VPC, this process can take a
        /// minute. During this time, you can't modify the function, but you can still invoke
        /// it. The <code>LastUpdateStatus</code>, <code>LastUpdateStatusReason</code>, and <code>LastUpdateStatusReasonCode</code>
        /// fields in the response from <a>GetFunctionConfiguration</a> indicate when the update
        /// is complete and the function is processing events with the new configuration. For
        /// more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">Lambda
        /// function states</a>.
        /// </para>
        ///  
        /// <para>
        /// These settings can vary between versions of a function and are locked when you publish
        /// a version. You can't modify the configuration of a published version, only the unpublished
        /// version.
        /// </para>
        ///  
        /// <para>
        /// To configure function concurrency, use <a>PutFunctionConcurrency</a>. To grant invoke
        /// permissions to an Amazon Web Services account or Amazon Web Service, use <a>AddPermission</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeVerificationFailedException">
        /// The code signature failed one or more of the validation checks for signature mismatch
        /// or expiry, and the code signing policy is set to ENFORCE. Lambda blocks the deployment.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidCodeSignatureException">
        /// The code signature failed the integrity check. If the integrity check fails, then
        /// Lambda blocks deployment, even if the code signing policy is set to WARN.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionConfiguration">REST API Reference for UpdateFunctionConfiguration Operation</seealso>
        Task<UpdateFunctionConfigurationResponse> UpdateFunctionConfigurationAsync(UpdateFunctionConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFunctionEventInvokeConfig


        /// <summary>
        /// Updates the configuration for asynchronous invocation for a function, version, or
        /// alias.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionEventInvokeConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionEventInvokeConfig">REST API Reference for UpdateFunctionEventInvokeConfig Operation</seealso>
        UpdateFunctionEventInvokeConfigResponse UpdateFunctionEventInvokeConfig(UpdateFunctionEventInvokeConfigRequest request);



        /// <summary>
        /// Updates the configuration for asynchronous invocation for a function, version, or
        /// alias.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionEventInvokeConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionEventInvokeConfig">REST API Reference for UpdateFunctionEventInvokeConfig Operation</seealso>
        Task<UpdateFunctionEventInvokeConfigResponse> UpdateFunctionEventInvokeConfigAsync(UpdateFunctionEventInvokeConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFunctionUrlConfig


        /// <summary>
        /// Updates the configuration for a Lambda function URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionUrlConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionUrlConfig">REST API Reference for UpdateFunctionUrlConfig Operation</seealso>
        UpdateFunctionUrlConfigResponse UpdateFunctionUrlConfig(UpdateFunctionUrlConfigRequest request);



        /// <summary>
        /// Updates the configuration for a Lambda function URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionUrlConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionUrlConfig">REST API Reference for UpdateFunctionUrlConfig Operation</seealso>
        Task<UpdateFunctionUrlConfigResponse> UpdateFunctionUrlConfigAsync(UpdateFunctionUrlConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}