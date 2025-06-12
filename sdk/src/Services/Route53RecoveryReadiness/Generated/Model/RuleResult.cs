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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
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
        private DateTime? _lastCheckedTimestamp;
        private List<Message> _messages = AWSConfigs.InitializeCollections ? new List<Message>() : null;
        private Readiness _readiness;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property LastCheckedTimestamp. 
        /// <para>
        /// The time the resource was last checked for readiness, in ISO-8601 format, UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastCheckedTimestamp
        {
            get { return this._lastCheckedTimestamp; }
            set { this._lastCheckedTimestamp = value; }
        }

        // Check to see if LastCheckedTimestamp property is set
        internal bool IsSetLastCheckedTimestamp()
        {
            return this._lastCheckedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// Details about the resource's readiness.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Message> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Readiness. 
        /// <para>
        /// The readiness at rule level.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Readiness Readiness
        {
            get { return this._readiness; }
            set { this._readiness = value; }
        }

        // Check to see if Readiness property is set
        internal bool IsSetReadiness()
        {
            return this._readiness != null;
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The identifier of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

    }
}