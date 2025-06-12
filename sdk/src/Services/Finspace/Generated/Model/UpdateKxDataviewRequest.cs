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
    /// Container for the parameters to the UpdateKxDataview operation.
    /// Updates the specified dataview. The dataviews get automatically updated when any
    /// new changesets are ingested. Each update of the dataview creates a new version, including
    /// changeset details and cache configurations
    /// </summary>
    public partial class UpdateKxDataviewRequest : AmazonFinspaceRequest
    {
        private string _changesetId;
        private string _clientToken;
        private string _databaseName;
        private string _dataviewName;
        private string _description;
        private string _environmentId;
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures idempotency. This token expires in 10 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        ///  The name of the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DataviewName. 
        /// <para>
        /// The name of the dataview that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for a dataview. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique identifier for the kdb environment, where you want to update the dataview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
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

    }
}