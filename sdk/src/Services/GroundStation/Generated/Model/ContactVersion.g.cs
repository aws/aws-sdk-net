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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Version information for a contact.
    /// </summary>
    public partial class ContactVersion
    {
        /// <summary>
        /// Gets and sets the property Activated. 
        /// <para>
        /// Time the contact version was activated in UTC. A version is activated when it becomes
        /// the current active version of the contact.
        /// </para>
        /// </summary>
        public DateTime? Activated { get; set; }

        /// <summary>
        /// Checks to see if the Activated property is set.
        /// </summary>
        internal bool IsSetActivated() => this.Activated.HasValue;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// Time the contact version was created in UTC.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property FailureCodes. 
        /// <para>
        /// List of failure codes for the contact version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureCodes property is set.
        /// </summary>
        internal bool IsSetFailureCodes() => this.FailureCodes != null && (this.FailureCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Failure message for the contact version.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// Time the contact version was last updated in UTC.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the contact version.
        /// </para>
        /// </summary>
        public VersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Superseded. 
        /// <para>
        /// Time the contact version was superseded in UTC. A version is superseded when a newer
        /// version becomes active.
        /// </para>
        /// </summary>
        public DateTime? Superseded { get; set; }

        /// <summary>
        /// Checks to see if the Superseded property is set.
        /// </summary>
        internal bool IsSetSuperseded() => this.Superseded.HasValue;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID of a contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public int? VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId.HasValue;
    }
}
