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

#pragma warning disable CS0612,CS0618,CS1570
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
    ///  
    /// <para>
    /// The maximum number of entries per request is 10.
    /// </para>
    ///  <note> 
    /// <para>
    /// Each rule can have up to five (5) targets associated with it at one time.
    /// </para>
    ///  </note> 
    /// <para>
    /// For a list of services you can configure as targets for events, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-targets.html">EventBridge
    /// targets</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
    /// </para>
    ///  
    /// <para>
    /// Creating rules with built-in targets is supported only in the Amazon Web Services
    /// Management Console. The built-in targets are:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Amazon EBS CreateSnapshot API call</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Amazon EC2 RebootInstances API call</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Amazon EC2 StopInstances API call</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Amazon EC2 TerminateInstances API call</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For some target types, <c>PutTargets</c> provides target-specific parameters. If the
    /// target is a Kinesis data stream, you can optionally specify which shard the event
    /// goes to by using the <c>KinesisParameters</c> argument. To invoke a command on multiple
    /// EC2 instances with one rule, you can use the <c>RunCommandParameters</c> field.
    /// </para>
    ///  
    /// <para>
    /// To be able to make API calls against the resources that you own, Amazon EventBridge
    /// needs the appropriate permissions: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For Lambda and Amazon SNS resources, EventBridge relies on resource-based policies.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For EC2 instances, Kinesis Data Streams, Step Functions state machines and API Gateway
    /// APIs, EventBridge relies on IAM roles that you specify in the <c>RoleARN</c> argument
    /// in <c>PutTargets</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/auth-and-access-control-eventbridge.html">Authentication
    /// and Access Control</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
    /// </para>
    ///  
    /// <para>
    /// If another Amazon Web Services account is in the same region and has granted you permission
    /// (using <c>PutPermission</c>), you can send events to that account. Set that account's
    /// event bus as a target of the rules in your account. To send the matched events to
    /// the other account, specify that account's event bus as the <c>Arn</c> value when you
    /// run <c>PutTargets</c>. If your account sends events to another account, your account
    /// is charged for each sent event. Each event sent to another account is charged as a
    /// custom event. The account receiving the event is not charged. For more information,
    /// see <a href="http://aws.amazon.com/eventbridge/pricing/">Amazon EventBridge Pricing</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <c>Input</c>, <c>InputPath</c>, and <c>InputTransformer</c> are not available with
    /// <c>PutTarget</c> if the target is an event bus of a different Amazon Web Services
    /// account.
    /// </para>
    ///  </note> 
    /// <para>
    /// If you are setting the event bus of another account as the target, and that account
    /// granted permission to your account through an organization instead of directly by
    /// the account ID, then you must specify a <c>RoleArn</c> with proper permissions in
    /// the <c>Target</c> structure. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
    /// and Receiving Events Between Amazon Web Services Accounts</a> in the <i>Amazon EventBridge
    /// User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you have an IAM role on a cross-account event bus target, a <c>PutTargets</c> call
    /// without a role on the same target (same <c>Id</c> and <c>Arn</c>) will not remove
    /// the role.
    /// </para>
    ///  </note> 
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
    /// If <b>InputPath</b> is specified in the form of JSONPath (for example, <c>$.detail</c>),
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
    /// When you specify <c>InputPath</c> or <c>InputTransformer</c>, you must use JSON dot
    /// notation, not bracket notation.
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
    /// that happens, <c>FailedEntryCount</c> is non-zero in the response and each entry in
    /// <c>FailedEntries</c> provides the ID of the failed target and the error code.
    /// </para>
    /// </summary>
    public partial class PutTargetsRequest : AmazonEventBridgeRequest
    {
        private string _eventBusName;
        private string _rule;
        private List<Target> _targets = AWSConfigs.InitializeCollections ? new List<Target>() : null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._targets != null && (this._targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}