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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Real-time extraction is in preview release for Amazon Connect Health and is subject
    /// to change. To request access to this feature, contact your AWS account team.
    /// 
    ///  
    /// <para>
    /// The session's checklist as of this point in the session. Each event carries every
    /// item with its current status, not only the items that changed.
    /// </para>
    /// </summary>
    public partial class MedicalScribeChecklistEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property Checklists. 
        /// <para>
        /// The checklists for the session. The list is empty when no checklist is active.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 20)]
        public List<Checklist> Checklists { get; set; } = AWSConfigs.InitializeCollections ? new List<Checklist>() : null;

        /// <summary>
        /// Checks to see if the Checklists property is set.
        /// </summary>
        internal bool IsSetChecklists() => this.Checklists != null && (this.Checklists.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotVersion. 
        /// <para>
        /// The version of this snapshot. Versions increase within a session and can skip values.
        /// Keep the snapshot with the highest version and ignore any event whose version is not
        /// higher, including after you reconnect to the session. Versions of checklist events
        /// and periodontal chart events are independent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? SnapshotVersion { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotVersion property is set.
        /// </summary>
        internal bool IsSetSnapshotVersion() => this.SnapshotVersion.HasValue;
    }
}
