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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// A summary of a centralization rule's key properties and status.
    /// </summary>
    public partial class CentralizationRuleSummary
    {
        private string _createdRegion;
        private long? _createdTimeStamp;
        private string _creatorAccountId;
        private string _destinationAccountId;
        private string _destinationRegion;
        private CentralizationFailureReason _failureReason;
        private long? _lastUpdateTimeStamp;
        private string _ruleArn;
        private RuleHealth _ruleHealth;
        private string _ruleName;

        /// <summary>
        /// Gets and sets the property CreatedRegion. 
        /// <para>
        /// The Amazon Web Services region where the organization centralization rule was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string CreatedRegion
        {
            get { return this._createdRegion; }
            set { this._createdRegion = value; }
        }

        // Check to see if CreatedRegion property is set
        internal bool IsSetCreatedRegion()
        {
            return this._createdRegion != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        /// The timestamp when the organization centralization rule was created.
        /// </para>
        /// </summary>
        public long? CreatedTimeStamp
        {
            get { return this._createdTimeStamp; }
            set { this._createdTimeStamp = value; }
        }

        // Check to see if CreatedTimeStamp property is set
        internal bool IsSetCreatedTimeStamp()
        {
            return this._createdTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The Amazon Web Services Account that created the organization centralization rule.
        /// </para>
        /// </summary>
        public string CreatorAccountId
        {
            get { return this._creatorAccountId; }
            set { this._creatorAccountId = value; }
        }

        // Check to see if CreatorAccountId property is set
        internal bool IsSetCreatorAccountId()
        {
            return this._creatorAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationAccountId. 
        /// <para>
        /// The primary destination account of the organization centralization rule.
        /// </para>
        /// </summary>
        public string DestinationAccountId
        {
            get { return this._destinationAccountId; }
            set { this._destinationAccountId = value; }
        }

        // Check to see if DestinationAccountId property is set
        internal bool IsSetDestinationAccountId()
        {
            return this._destinationAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The primary destination region of the organization centralization rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why an organization centralization rule is marked UNHEALTHY.
        /// </para>
        /// </summary>
        public CentralizationFailureReason FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTimeStamp. 
        /// <para>
        /// The timestamp when the organization centralization rule was last updated.
        /// </para>
        /// </summary>
        public long? LastUpdateTimeStamp
        {
            get { return this._lastUpdateTimeStamp; }
            set { this._lastUpdateTimeStamp = value; }
        }

        // Check to see if LastUpdateTimeStamp property is set
        internal bool IsSetLastUpdateTimeStamp()
        {
            return this._lastUpdateTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the organization centralization rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string RuleArn
        {
            get { return this._ruleArn; }
            set { this._ruleArn = value; }
        }

        // Check to see if RuleArn property is set
        internal bool IsSetRuleArn()
        {
            return this._ruleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RuleHealth. 
        /// <para>
        /// The health status of the organization centralization rule.
        /// </para>
        /// </summary>
        public RuleHealth RuleHealth
        {
            get { return this._ruleHealth; }
            set { this._ruleHealth = value; }
        }

        // Check to see if RuleHealth property is set
        internal bool IsSetRuleHealth()
        {
            return this._ruleHealth != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the organization centralization rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

    }
}