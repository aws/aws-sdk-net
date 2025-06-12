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
    /// The configuration that contains the database path of the data that you want to place
    /// on each selected volume. Each segment must have a unique database path for each volume.
    /// If you do not explicitly specify any database path for a volume, they are accessible
    /// from the cluster through the default S3/object store segment.
    /// </summary>
    public partial class KxDataviewSegmentConfiguration
    {
        private List<string> _dbPaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _onDemand;
        private string _volumeName;

        /// <summary>
        /// Gets and sets the property DbPaths. 
        /// <para>
        ///  The database path of the data that you want to place on each selected volume for
        /// the segment. Each segment must have a unique database path for each volume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public List<string> DbPaths
        {
            get { return this._dbPaths; }
            set { this._dbPaths = value; }
        }

        // Check to see if DbPaths property is set
        internal bool IsSetDbPaths()
        {
            return this._dbPaths != null && (this._dbPaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OnDemand. 
        /// <para>
        /// Enables on-demand caching on the selected database path when a particular file or
        /// a column of the database is accessed. When on demand caching is <b>True</b>, dataviews
        /// perform minimal loading of files on the filesystem as needed. When it is set to <b>False</b>,
        /// everything is cached. The default value is <b>False</b>. 
        /// </para>
        /// </summary>
        public bool? OnDemand
        {
            get { return this._onDemand; }
            set { this._onDemand = value; }
        }

        // Check to see if OnDemand property is set
        internal bool IsSetOnDemand()
        {
            return this._onDemand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeName. 
        /// <para>
        ///  The name of the volume where you want to add data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string VolumeName
        {
            get { return this._volumeName; }
            set { this._volumeName = value; }
        }

        // Check to see if VolumeName property is set
        internal bool IsSetVolumeName()
        {
            return this._volumeName != null;
        }

    }
}