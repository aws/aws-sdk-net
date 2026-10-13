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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the RemoveTargets operation. Removes the specified
    /// targets from the specified rule. When the rule is triggered, those targets are no
    /// longer be invoked. <note> <para> A successful execution of <c>RemoveTargets</c> doesn't
    /// guarantee all targets are removed from the rule, it means that the target(s) listed
    /// in the request are removed. </para> </note> <para> When you remove a target, when
    /// the associated rule triggers, removed targets might continue to be invoked. Allow
    /// a short period of time for changes to take effect. </para> <para> This action can
    /// partially fail if too many requests are made at the same time. If that happens, <c>FailedEntryCount</c>
    /// is non-zero in the response and each entry in <c>FailedEntries</c> provides the ID
    /// of the failed target and the error code. </para> <para> The maximum number of entries
    /// per request is 10. </para>
    /// </summary>
    public partial class RemoveTargetsRequest : AmazonEventBridgeRequest
    {
        /// <summary>
        /// Gets and sets the property EventBusName. 
        /// <para>
        /// The name or ARN of the event bus associated with the rule. If you omit this, the default
        /// event bus is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string EventBusName { get; set; }

        /// <summary>
        /// Checks to see if the EventBusName property is set.
        /// </summary>
        internal bool IsSetEventBusName() => this.EventBusName != null;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// If this is a managed rule, created by an Amazon Web Services service on your behalf,
        /// you must specify <c>Force</c> as <c>True</c> to remove targets. This parameter is
        /// ignored for rules that are not managed rules. You can check whether a rule is a managed
        /// rule by using <c>DescribeRule</c> or <c>ListRules</c> and checking the <c>ManagedBy</c>
        /// field of the response.
        /// </para>
        /// </summary>
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        /// The IDs of the targets to remove from the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<string> Ids { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Ids property is set.
        /// </summary>
        internal bool IsSetIds() => this.Ids != null && (this.Ids.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Rule { get; set; }

        /// <summary>
        /// Checks to see if the Rule property is set.
        /// </summary>
        internal bool IsSetRule() => this.Rule != null;
    }
}
