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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for information about a configuration change happening on a domain.
    /// </summary>
    public partial class ChangeProgressDetails
    {
        /// <summary>
        /// Gets and sets the property ChangeId. 
        /// <para>
        /// The ID of the configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ChangeId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeId property is set.
        /// </summary>
        internal bool IsSetChangeId() => this.ChangeId != null;

        /// <summary>
        /// Gets and sets the property ConfigChangeStatus. 
        /// <para>
        /// The current status of the configuration change.
        /// </para>
        /// </summary>
        public ConfigChangeStatus ConfigChangeStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConfigChangeStatus property is set.
        /// </summary>
        internal bool IsSetConfigChangeStatus() => this.ConfigChangeStatus != null;

        /// <summary>
        /// Gets and sets the property InitiatedBy. 
        /// <para>
        /// The IAM principal who initiated the configuration change.
        /// </para>
        /// </summary>
        public InitiatedBy InitiatedBy { get; set; }

        /// <summary>
        /// Checks to see if the InitiatedBy property is set.
        /// </summary>
        internal bool IsSetInitiatedBy() => this.InitiatedBy != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that the configuration change was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message corresponding to the status of the configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that the configuration change was initiated, in Universal Coordinated Time
        /// (UTC).
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
