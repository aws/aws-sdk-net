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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the PutTargets operation.
    /// Adds the specified targets to the specified rule, or updates the targets if they are
    /// already associated with the rule.
    /// 
    ///  
    /// <para>
    /// Targets are the resources that are invoked when a rule is triggered.
    /// </para>
    ///  <note> 
    /// <para>
    /// Each rule can have up to five (5) targets associated with it at one time.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can configure the following as targets for Events:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-api-destinations.html">API
    /// destination</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-api-gateway-target.html">API
    /// Gateway</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Batch job queue
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CloudWatch group
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CodeBuild project
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CodePipeline
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// EC2 <code>CreateSnapshot</code> API call
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// EC2 Image Builder
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// EC2 <code>RebootInstances</code> API call
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// EC2 <code>StopInstances</code> API call
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// EC2 <code>TerminateInstances</code> API call
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ECS task
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-cross-account.html">Event
    /// bus in a different account or Region</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-bus-to-bus.html">Event
    /// bus in the same account and Region</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Firehose delivery stream
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Glue workflow
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/incident-creation.html#incident-tracking-auto-eventbridge">Incident
    /// Manager response plan</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Inspector assessment template
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Kinesis stream
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Lambda function
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Redshift cluster
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Redshift Serverless workgroup
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// SageMaker Pipeline
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// SNS topic
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// SQS queue
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Step Functions state machine
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Systems Manager Automation
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Systems Manager OpsItem
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Systems Manager Run Command
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Creating rules with built-in targets is supported only in the Amazon Web Services
    /// Management Console. The built-in targets are <code>EC2 CreateSnapshot API call</code>,
    /// <code>EC2 RebootInstances API call</code>, <code>EC2 StopInstances API call</code>,
    /// and <code>EC2 TerminateInstances API call</code>. 
    /// </para>
    ///  
    /// <para>
    /// For some target types, <code>PutTargets</code> provides target-specific parameters.
    /// If the target is a Kinesis data stream, you can optionally specify which shard the
    /// event goes to by using the <code>KinesisParameters</code> argument. To invoke a command
    /// on multiple EC2 instances with one rule, you can use the <code>RunCommandParameters</code>
    /// field.
    /// </para>
    ///  
    /// <para>
    /// To be able to make API calls against the resources that you own, Amazon EventBridge
    /// needs the appropriate permissions. For Lambda and Amazon SNS resources, EventBridge
    /// relies on resource-based policies. For EC2 instances, Kinesis Data Streams, Step Functions
    /// state machines and API Gateway APIs, EventBridge relies on IAM roles that you specify
    /// in the <code>RoleARN</code> argument in <code>PutTargets</code>. For more information,
    /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/auth-and-access-control-eventbridge.html">Authentication
    /// and Access Control</a> in the <i>Amazon EventBridge User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If another Amazon Web Services account is in the same region and has granted you permission
    /// (using <code>PutPermission</code>), you can send events to that account. Set that
    /// account's event bus as a target of the rules in your account. To send the matched
    /// events to the other account, specify that account's event bus as the <code>Arn</code>
    /// value when you run <code>PutTargets</code>. If your account sends events to another
    /// account, your account is charged for each sent event. Each event sent to another account
    /// is charged as a custom event. The account receiving the event is not charged. For
    /// more information, see <a href="http://aws.amazon.com/eventbridge/pricing/">Amazon
    /// EventBridge Pricing</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <code>Input</code>, <code>InputPath</code>, and <code>InputTransformer</code> are
    /// not available with <code>PutTarget</code> if the target is an event bus of a different
    /// Amazon Web Services account.
    /// </para>
    ///  </note> 
    /// <para>
    /// If you are setting the event bus of another account as the target, and that account
    /// granted permission to your account through an organization instead of directly by
    /// the account ID, then you must specify a <code>RoleArn</code> with proper permissions
    /// in the <code>Target</code> structure. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
    /// and Receiving Events Between Amazon Web Services Accounts</a> in the <i>Amazon EventBridge
    /// User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about enabling cross-account events, see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutPermission.html">PutPermission</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Input</b>, <b>InputPath</b>, and <b>InputTransformer</b> are mutually exclusive
    /// and optional parameters of a target. When a rule is triggered due to a matched event:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If none of the following arguments are specified for a target, then the entire event
    /// is passed to the target in JSON format (unless the target is Amazon EC2 Run Command
    /// or Amazon ECS task, in which case nothing from the event is passed to the target).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <b>Input</b> is specified in the form of valid JSON, then the matched event is
    /// overridden with this constant.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <b>InputPath</b> is specified in the form of JSONPath (for example, <code>$.detail</code>),
    /// then only the part of the event specified in the path is passed to the target (for
    /// example, only the detail part of the event is passed).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <b>InputTransformer</b> is specified, then one or more specified JSONPaths are
    /// extracted from the event and used as values in a template that you specify as the
    /// input to the target.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When you specify <code>InputPath</code> or <code>InputTransformer</code>, you must
    /// use JSON dot notation, not bracket notation.
    /// </para>
    ///  
    /// <para>
    /// When you add targets to a rule and the associated rule triggers soon after, new or
    /// updated targets might not be immediately invoked. Allow a short period of time for
    /// changes to take effect.
    /// </para>
    ///  
    /// <para>
    /// This action can partially fail if too many requests are made at the same time. If
    /// that happens, <code>FailedEntryCount</code> is non-zero in the response and each entry
    /// in <code>FailedEntries</code> provides the ID of the failed target and the error code.
    /// </para>
    /// </summary>
    public partial class PutTargetsRequest : AmazonEventBridgeRequest
    {
        private string _eventBusName;
        private string _rule;
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Gets and sets the property EventBusName. 
        /// <para>
        /// The name or ARN of the event bus associated with the rule. If you omit this, the default
        /// event bus is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string EventBusName
        {
            get { return this._eventBusName; }
            set { this._eventBusName = value; }
        }

        // Check to see if EventBusName property is set
        internal bool IsSetEventBusName()
        {
            return this._eventBusName != null;
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets to update or add to the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

    }
}