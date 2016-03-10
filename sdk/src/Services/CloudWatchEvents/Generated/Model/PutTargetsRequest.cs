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
    /// Adds target(s) to a rule. Targets are the resources that can be invoked when a rule
    /// is triggered. For example, AWS Lambda functions, Amazon Kinesis streams, and built-in
    /// targets. Updates the target(s) if they are already associated with the role. In other
    /// words, if there is already a target with the given target ID, then the target associated
    /// with that ID is updated.
    /// 
    ///  
    /// <para>
    /// In order to be able to make API calls against the resources you own, Amazon CloudWatch
    /// Events needs the appropriate permissions. For AWS Lambda and Amazon SNS resources,
    /// CloudWatch Events relies on resource-based policies. For Amazon Kinesis streams, CloudWatch
    /// Events relies on IAM roles. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/EventsTargetPermissions.html">Permissions
    /// for Sending Events to Targets</a> in the <b><i>Amazon CloudWatch Developer Guide</i></b>.
    /// </para>
    ///  
    /// <para>
    /// <b>Input</b> and <b>InputPath</b> are mutually-exclusive and optional parameters of
    /// a target. When a rule is triggered due to a matched event, if for a target:
    /// </para>
    ///  <ul> <li>Neither <b>Input</b> nor <b>InputPath</b> is specified, then the entire
    /// event is passed to the target in JSON form.</li> <li> <b>InputPath</b> is specified
    /// in the form of JSONPath (e.g. <b>$.detail</b>), then only the part of the event specified
    /// in the path is passed to the target (e.g. only the detail part of the event is passed).
    /// </li> <li> <b>Input</b> is specified in the form of a valid JSON, then the matched
    /// event is overridden with this constant.</li> </ul> 
    /// <para>
    ///  <b>Note:</b> When you add targets to a rule, when the associated rule triggers, new
    /// or updated targets might not be immediately invoked. Please allow a short period of
    /// time for changes to take effect. 
    /// </para>
    /// </summary>
    public partial class PutTargetsRequest : AmazonCloudWatchEventsRequest
    {
        private string _rule;
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The name of the rule you want to add targets to.
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
        /// List of targets you want to update or add to the rule.
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