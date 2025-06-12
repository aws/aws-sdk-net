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
    /// The structure that stores the configuration details of a dataview.
    /// </summary>
    public partial class KxDataviewConfiguration
    {
        private string _changesetId;
        private string _dataviewName;
        private string _dataviewVersionId;
        private List<KxDataviewSegmentConfiguration> _segmentConfigurations = AWSConfigs.InitializeCollections ? new List<KxDataviewSegmentConfiguration>() : null;

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
        /// Gets and sets the property DataviewName. 
        /// <para>
        ///  The unique identifier of the dataview.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string DataviewName
        {
            get { return this._dataviewName; }
            set { this._dataviewName = value; }
        }

        // Check to see if DataviewName property is set
        internal bool IsSetDataviewName()
        {
            return this._dataviewName != null;
        }

        /// <summary>
        /// Gets and sets the property DataviewVersionId. 
        /// <para>
        ///  The version of the dataview corresponding to a given changeset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string DataviewVersionId
        {
            get { return this._dataviewVersionId; }
            set { this._dataviewVersionId = value; }
        }

        // Check to see if DataviewVersionId property is set
        internal bool IsSetDataviewVersionId()
        {
            return this._dataviewVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentConfigurations. 
        /// <para>
        ///  The db path and volume configuration for the segmented database.
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

    }
}