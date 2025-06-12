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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The active version of the dataview that is currently in use by this cluster.
    /// </summary>
    public partial class KxDataviewActiveVersion
    {
        private List<string> _attachedClusters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _changesetId;
        private DateTime? _createdTimestamp;
        private List<KxDataviewSegmentConfiguration> _segmentConfigurations = AWSConfigs.InitializeCollections ? new List<KxDataviewSegmentConfiguration>() : null;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property AttachedClusters. 
        /// <para>
        ///  The list of clusters that are currently using this dataview. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttachedClusters
        {
            get { return this._attachedClusters; }
            set { this._attachedClusters = value; }
        }

        // Check to see if AttachedClusters property is set
        internal bool IsSetAttachedClusters()
        {
            return this._attachedClusters != null && (this._attachedClusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChangesetId. 
        /// <para>
        /// A unique identifier for the changeset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string ChangesetId
        {
            get { return this._changesetId; }
            set { this._changesetId = value; }
        }

        // Check to see if ChangesetId property is set
        internal bool IsSetChangesetId()
        {
            return this._changesetId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        ///  The timestamp at which the dataview version was active. The value is determined as
        /// epoch time in milliseconds. For example, the value for Monday, November 1, 2021 12:00:00
        /// PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentConfigurations. 
        /// <para>
        ///  The configuration that contains the database path of the data that you want to place
        /// on each selected volume. Each segment must have a unique database path for each volume.
        /// If you do not explicitly specify any database path for a volume, they are accessible
        /// from the cluster through the default S3/object store segment. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<KxDataviewSegmentConfiguration> SegmentConfigurations
        {
            get { return this._segmentConfigurations; }
            set { this._segmentConfigurations = value; }
        }

        // Check to see if SegmentConfigurations property is set
        internal bool IsSetSegmentConfigurations()
        {
            return this._segmentConfigurations != null && (this._segmentConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        ///  A unique identifier of the active version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}