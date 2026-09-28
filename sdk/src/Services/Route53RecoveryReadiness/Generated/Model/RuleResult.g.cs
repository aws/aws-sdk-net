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

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// The result of a successful Rule request, with status for an individual rule.
    /// </summary>
    public partial class RuleResult
    {
        /// <summary>
        /// Gets and sets the property LastCheckedTimestamp. 
        /// <para>
        /// The time the resource was last checked for readiness, in ISO-8601 format, UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastCheckedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastCheckedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastCheckedTimestamp() => this.LastCheckedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// Details about the resource's readiness.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Message> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<Message>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Readiness. 
        /// <para>
        /// The readiness at rule level.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Readiness Readiness { get; set; }

        /// <summary>
        /// Checks to see if the Readiness property is set.
        /// </summary>
        internal bool IsSetReadiness() => this.Readiness != null;

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The identifier of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RuleId { get; set; }

        /// <summary>
        /// Checks to see if the RuleId property is set.
        /// </summary>
        internal bool IsSetRuleId() => this.RuleId != null;
    }
}
