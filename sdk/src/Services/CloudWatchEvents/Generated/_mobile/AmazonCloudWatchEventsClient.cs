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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudWatchEvents.Model;
using Amazon.CloudWatchEvents.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatchEvents
{
    /// <summary>
    /// Implementation for accessing CloudWatchEvents
    ///
    /// Amazon CloudWatch Events helps you to respond to state changes in your AWS resources.
    /// When your resources change state, they automatically send events into an event stream.
    /// You can create rules that match selected events in the stream and route them to targets
    /// to take action. You can also use rules to take action on a pre-determined schedule.
    /// For example, you can configure rules to:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Automatically invoke an AWS Lambda function to update DNS entries when an event notifies
    /// you that Amazon EC2 instance enters the running state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Direct specific API records from CloudTrail to an Amazon Kinesis stream for detailed
    /// analysis of potential security or availability risks.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Periodically invoke a built-in target to create a snapshot of an Amazon EBS volume.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about the features of Amazon CloudWatch Events, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events">Amazon
    /// CloudWatch Events User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudWatchEventsClient : AmazonServiceClient, IAmazonCloudWatchEvents
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with the credentials loaded from the application's
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
        public AmazonCloudWatchEventsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchEventsConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with the credentials loaded from the application's
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
        public AmazonCloudWatchEventsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchEventsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudWatchEventsClient Configuration Object</param>
        public AmazonCloudWatchEventsClient(AmazonCloudWatchEventsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudWatchEventsClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudWatchEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchEventsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudWatchEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Credentials and an
        /// AmazonCloudWatchEventsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudWatchEventsClient Configuration Object</param>
        public AmazonCloudWatchEventsClient(AWSCredentials credentials, AmazonCloudWatchEventsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchEventsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchEventsClient Configuration Object</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchEventsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudWatchEventsClient Configuration Object</param>
        public AmazonCloudWatchEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudWatchEventsConfig clientConfig)
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

        
        #region  DeleteRule

        internal virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var marshaller = DeleteRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleRequest,DeleteRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleRequest,DeleteRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventBus

        internal virtual DescribeEventBusResponse DescribeEventBus(DescribeEventBusRequest request)
        {
            var marshaller = DescribeEventBusRequestMarshaller.Instance;
            var unmarshaller = DescribeEventBusResponseUnmarshaller.Instance;

            return Invoke<DescribeEventBusRequest,DescribeEventBusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventBus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventBus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        public virtual Task<DescribeEventBusResponse> DescribeEventBusAsync(DescribeEventBusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEventBusRequestMarshaller.Instance;
            var unmarshaller = DescribeEventBusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventBusRequest,DescribeEventBusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRule

        internal virtual DescribeRuleResponse DescribeRule(DescribeRuleRequest request)
        {
            var marshaller = DescribeRuleRequestMarshaller.Instance;
            var unmarshaller = DescribeRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleRequest,DescribeRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        public virtual Task<DescribeRuleResponse> DescribeRuleAsync(DescribeRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRuleRequestMarshaller.Instance;
            var unmarshaller = DescribeRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRuleRequest,DescribeRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableRule

        internal virtual DisableRuleResponse DisableRule(DisableRuleRequest request)
        {
            var marshaller = DisableRuleRequestMarshaller.Instance;
            var unmarshaller = DisableRuleResponseUnmarshaller.Instance;

            return Invoke<DisableRuleRequest,DisableRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        public virtual Task<DisableRuleResponse> DisableRuleAsync(DisableRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableRuleRequestMarshaller.Instance;
            var unmarshaller = DisableRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DisableRuleRequest,DisableRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableRule

        internal virtual EnableRuleResponse EnableRule(EnableRuleRequest request)
        {
            var marshaller = EnableRuleRequestMarshaller.Instance;
            var unmarshaller = EnableRuleResponseUnmarshaller.Instance;

            return Invoke<EnableRuleRequest,EnableRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        public virtual Task<EnableRuleResponse> EnableRuleAsync(EnableRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableRuleRequestMarshaller.Instance;
            var unmarshaller = EnableRuleResponseUnmarshaller.Instance;

            return InvokeAsync<EnableRuleRequest,EnableRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRuleNamesByTarget

        internal virtual ListRuleNamesByTargetResponse ListRuleNamesByTarget(ListRuleNamesByTargetRequest request)
        {
            var marshaller = ListRuleNamesByTargetRequestMarshaller.Instance;
            var unmarshaller = ListRuleNamesByTargetResponseUnmarshaller.Instance;

            return Invoke<ListRuleNamesByTargetRequest,ListRuleNamesByTargetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleNamesByTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleNamesByTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        public virtual Task<ListRuleNamesByTargetResponse> ListRuleNamesByTargetAsync(ListRuleNamesByTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRuleNamesByTargetRequestMarshaller.Instance;
            var unmarshaller = ListRuleNamesByTargetResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuleNamesByTargetRequest,ListRuleNamesByTargetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRules

        internal virtual ListRulesResponse ListRules()
        {
            return ListRules(new ListRulesRequest());
        }
        internal virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var marshaller = ListRulesRequestMarshaller.Instance;
            var unmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesRequest,ListRulesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists your Amazon CloudWatch Events rules. You can either list all the rules or you
        /// can provide a prefix to match to the rule names.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual Task<ListRulesResponse> ListRulesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListRulesAsync(new ListRulesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRulesRequestMarshaller.Instance;
            var unmarshaller = ListRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRulesRequest,ListRulesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTargetsByRule

        internal virtual ListTargetsByRuleResponse ListTargetsByRule(ListTargetsByRuleRequest request)
        {
            var marshaller = ListTargetsByRuleRequestMarshaller.Instance;
            var unmarshaller = ListTargetsByRuleResponseUnmarshaller.Instance;

            return Invoke<ListTargetsByRuleRequest,ListTargetsByRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetsByRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsByRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        public virtual Task<ListTargetsByRuleResponse> ListTargetsByRuleAsync(ListTargetsByRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTargetsByRuleRequestMarshaller.Instance;
            var unmarshaller = ListTargetsByRuleResponseUnmarshaller.Instance;

            return InvokeAsync<ListTargetsByRuleRequest,ListTargetsByRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutEvents

        internal virtual PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var marshaller = PutEventsRequestMarshaller.Instance;
            var unmarshaller = PutEventsResponseUnmarshaller.Instance;

            return Invoke<PutEventsRequest,PutEventsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutEventsRequestMarshaller.Instance;
            var unmarshaller = PutEventsResponseUnmarshaller.Instance;

            return InvokeAsync<PutEventsRequest,PutEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutPermission

        internal virtual PutPermissionResponse PutPermission(PutPermissionRequest request)
        {
            var marshaller = PutPermissionRequestMarshaller.Instance;
            var unmarshaller = PutPermissionResponseUnmarshaller.Instance;

            return Invoke<PutPermissionRequest,PutPermissionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        public virtual Task<PutPermissionResponse> PutPermissionAsync(PutPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutPermissionRequestMarshaller.Instance;
            var unmarshaller = PutPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<PutPermissionRequest,PutPermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutRule

        internal virtual PutRuleResponse PutRule(PutRuleRequest request)
        {
            var marshaller = PutRuleRequestMarshaller.Instance;
            var unmarshaller = PutRuleResponseUnmarshaller.Instance;

            return Invoke<PutRuleRequest,PutRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        public virtual Task<PutRuleResponse> PutRuleAsync(PutRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutRuleRequestMarshaller.Instance;
            var unmarshaller = PutRuleResponseUnmarshaller.Instance;

            return InvokeAsync<PutRuleRequest,PutRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutTargets

        internal virtual PutTargetsResponse PutTargets(PutTargetsRequest request)
        {
            var marshaller = PutTargetsRequestMarshaller.Instance;
            var unmarshaller = PutTargetsResponseUnmarshaller.Instance;

            return Invoke<PutTargetsRequest,PutTargetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        public virtual Task<PutTargetsResponse> PutTargetsAsync(PutTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutTargetsRequestMarshaller.Instance;
            var unmarshaller = PutTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<PutTargetsRequest,PutTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemovePermission

        internal virtual RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var marshaller = RemovePermissionRequestMarshaller.Instance;
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return Invoke<RemovePermissionRequest,RemovePermissionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemovePermissionRequestMarshaller.Instance;
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<RemovePermissionRequest,RemovePermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTargets

        internal virtual RemoveTargetsResponse RemoveTargets(RemoveTargetsRequest request)
        {
            var marshaller = RemoveTargetsRequestMarshaller.Instance;
            var unmarshaller = RemoveTargetsResponseUnmarshaller.Instance;

            return Invoke<RemoveTargetsRequest,RemoveTargetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        public virtual Task<RemoveTargetsResponse> RemoveTargetsAsync(RemoveTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveTargetsRequestMarshaller.Instance;
            var unmarshaller = RemoveTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTargetsRequest,RemoveTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TestEventPattern

        internal virtual TestEventPatternResponse TestEventPattern(TestEventPatternRequest request)
        {
            var marshaller = TestEventPatternRequestMarshaller.Instance;
            var unmarshaller = TestEventPatternResponseUnmarshaller.Instance;

            return Invoke<TestEventPatternRequest,TestEventPatternResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TestEventPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestEventPattern operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        public virtual Task<TestEventPatternResponse> TestEventPatternAsync(TestEventPatternRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TestEventPatternRequestMarshaller.Instance;
            var unmarshaller = TestEventPatternResponseUnmarshaller.Instance;

            return InvokeAsync<TestEventPatternRequest,TestEventPatternResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}