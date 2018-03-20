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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
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
    /// You can configure the following as targets for CloudWatch Events:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// EC2 instances
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Lambda functions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Streams in Amazon Kinesis Streams
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Delivery streams in Amazon Kinesis Firehose
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon ECS tasks
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Step Functions state machines
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Batch jobs
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Pipelines in Amazon Code Pipeline
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Inspector assessment templates
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon SNS topics
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon SQS queues, including FIFO queues
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The default event bus of another AWS account
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Note that creating rules with built-in targets is supported only in the AWS Management
    /// Console.
    /// </para>
    ///  
    /// <para>
    /// For some target types, <code>PutTargets</code> provides target-specific parameters.
    /// If the target is an Amazon Kinesis stream, you can optionally specify which shard
    /// the event goes to by using the <code>KinesisParameters</code> argument. To invoke
    /// a command on multiple EC2 instances with one rule, you can use the <code>RunCommandParameters</code>
    /// field.
    /// </para>
    ///  
    /// <para>
    /// To be able to make API calls against the resources that you own, Amazon CloudWatch
    /// Events needs the appropriate permissions. For AWS Lambda and Amazon SNS resources,
    /// CloudWatch Events relies on resource-based policies. For EC2 instances, Amazon Kinesis
    /// streams, and AWS Step Functions state machines, CloudWatch Events relies on IAM roles
    /// that you specify in the <code>RoleARN</code> argument in <code>PutTargets</code>.
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events/auth-and-access-control-cwe.html">Authentication
    /// and Access Control</a> in the <i>Amazon CloudWatch Events User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If another AWS account is in the same region and has granted you permission (using
    /// <code>PutPermission</code>), you can send events to that account by setting that account's
    /// event bus as a target of the rules in your account. To send the matched events to
    /// the other account, specify that account's event bus as the <code>Arn</code> when you
    /// run <code>PutTargets</code>. If your account sends events to another account, your
    /// account is charged for each sent event. Each event sent to antoher account is charged
    /// as a custom event. The account receiving the event is not charged. For more information
    /// on pricing, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon CloudWatch
    /// Pricing</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about enabling cross-account events, see <a>PutPermission</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Input</b>, <b>InputPath</b> and <b>InputTransformer</b> are mutually exclusive
    /// and optional parameters of a target. When a rule is triggered due to a matched event:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If none of the following arguments are specified for a target, then the entire event
    /// is passed to the target in JSON form (unless the target is Amazon EC2 Run Command
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
    /// updated targets might not be immediately invoked. Please allow a short period of time
    /// for changes to take effect.
    /// </para>
    ///  
    /// <para>
    /// This action can partially fail if too many requests are made at the same time. If
    /// that happens, <code>FailedEntryCount</code> is non-zero in the response and each entry
    /// in <code>FailedEntries</code> provides the ID of the failed target and the error code.
    /// </para>
    /// </summary>
    public partial class PutTargetsRequest : AmazonCloudWatchEventsRequest
    {
        private string _rule;
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
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