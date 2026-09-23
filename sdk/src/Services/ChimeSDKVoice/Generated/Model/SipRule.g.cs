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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The details of a SIP rule, including name, triggers, and target applications. An AWS
    /// account can have multiple SIP rules.
    /// </summary>
    public partial class SipRule
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the SIP rule was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// Indicates whether the SIP rule is enabled or disabled. You must disable a rule before
        /// you can delete it.
        /// </para>
        /// </summary>
        public bool? Disabled { get; set; }

        /// <summary>
        /// Checks to see if the Disabled property is set.
        /// </summary>
        internal bool IsSetDisabled() => this.Disabled.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A SIP rule's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SipRuleId. 
        /// <para>
        /// A SIP rule's ID.
        /// </para>
        /// </summary>
        public string SipRuleId { get; set; }

        /// <summary>
        /// Checks to see if the SipRuleId property is set.
        /// </summary>
        internal bool IsSetSipRuleId() => this.SipRuleId != null;

        /// <summary>
        /// Gets and sets the property TargetApplications. 
        /// <para>
        /// The target SIP media application and other details, such as priority and AWS Region,
        /// to be specified in the SIP rule. Only one SIP rule per AWS Region can be provided.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public List<SipRuleTargetApplication> TargetApplications { get; set; } = AWSConfigs.InitializeCollections ? new List<SipRuleTargetApplication>() : null;

        /// <summary>
        /// Checks to see if the TargetApplications property is set.
        /// </summary>
        internal bool IsSetTargetApplications() => this.TargetApplications != null && (this.TargetApplications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TriggerType. 
        /// <para>
        /// The type of trigger set for a SIP rule, either a phone number or a URI request host
        /// name.
        /// </para>
        /// </summary>
        public SipRuleTriggerType TriggerType { get; set; }

        /// <summary>
        /// Checks to see if the TriggerType property is set.
        /// </summary>
        internal bool IsSetTriggerType() => this.TriggerType != null;

        /// <summary>
        /// Gets and sets the property TriggerValue. 
        /// <para>
        /// The value set for a SIP rule's trigger type. Either a phone number or a URI hostname.
        /// </para>
        /// </summary>
        public string TriggerValue { get; set; }

        /// <summary>
        /// Checks to see if the TriggerValue property is set.
        /// </summary>
        internal bool IsSetTriggerValue() => this.TriggerValue != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which the SIP rule was updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;
    }
}
