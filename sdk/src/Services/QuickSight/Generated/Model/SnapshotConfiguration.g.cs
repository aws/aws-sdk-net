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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Describes the configuration of the dashboard snapshot.
    /// </summary>
    public partial class SnapshotConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationConfiguration. 
        /// <para>
        /// A structure that contains information on the Amazon S3 bucket that the generated snapshot
        /// is stored in.
        /// </para>
        /// </summary>
        public SnapshotDestinationConfiguration DestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetDestinationConfiguration() => this.DestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property FileGroups. 
        /// <para>
        /// A list of <c>SnapshotJobResultFileGroup</c> objects that contain information about
        /// the snapshot that is generated. This list can hold a maximum of 6 <c>FileGroup</c>
        /// configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 7)]
        public List<SnapshotFileGroup> FileGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<SnapshotFileGroup>() : null;

        /// <summary>
        /// Checks to see if the FileGroups property is set.
        /// </summary>
        internal bool IsSetFileGroups() => this.FileGroups != null && (this.FileGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Parameters.
        /// </summary>
        public Parameters Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;
    }
}
