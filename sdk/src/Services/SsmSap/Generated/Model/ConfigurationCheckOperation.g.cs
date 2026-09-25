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

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Represents a configuration check operation that has been executed against an application.
    /// </summary>
    public partial class ConfigurationCheckOperation
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application against which the configuration check was performed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ConfigurationCheckDescription. 
        /// <para>
        /// A description of the configuration check that was performed.
        /// </para>
        /// </summary>
        public string ConfigurationCheckDescription { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationCheckDescription property is set.
        /// </summary>
        internal bool IsSetConfigurationCheckDescription() => this.ConfigurationCheckDescription != null;

        /// <summary>
        /// Gets and sets the property ConfigurationCheckId. 
        /// <para>
        /// The unique identifier of the configuration check that was performed.
        /// </para>
        /// </summary>
        public ConfigurationCheckType ConfigurationCheckId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationCheckId property is set.
        /// </summary>
        internal bool IsSetConfigurationCheckId() => this.ConfigurationCheckId != null;

        /// <summary>
        /// Gets and sets the property ConfigurationCheckName. 
        /// <para>
        /// The name of the configuration check that was performed.
        /// </para>
        /// </summary>
        public string ConfigurationCheckName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationCheckName property is set.
        /// </summary>
        internal bool IsSetConfigurationCheckName() => this.ConfigurationCheckName != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the configuration check operation completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the configuration check operation.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RuleStatusCounts. 
        /// <para>
        /// A summary of all the rule results, showing counts for each status type.
        /// </para>
        /// </summary>
        public RuleStatusCounts RuleStatusCounts { get; set; }

        /// <summary>
        /// Checks to see if the RuleStatusCounts property is set.
        /// </summary>
        internal bool IsSetRuleStatusCounts() => this.RuleStatusCounts != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the configuration check operation started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the configuration check operation.
        /// </para>
        /// </summary>
        public OperationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message providing additional details about the status of the configuration check
        /// operation.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
