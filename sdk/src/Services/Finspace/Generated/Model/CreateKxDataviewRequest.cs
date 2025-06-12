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
    /// Container for the parameters to the CreateKxDataview operation.
    /// Creates a snapshot of kdb database with tiered storage capabilities and a pre-warmed
    /// cache, ready for mounting on kdb clusters. Dataviews are only available for clusters
    /// running on a scaling group. They are not supported on dedicated clusters.
    /// </summary>
    public partial class CreateKxDataviewRequest : AmazonFinspaceRequest
    {
        private bool? _autoUpdate;
        private string _availabilityZoneId;
        private KxAzMode _azMode;
        private string _changesetId;
        private string _clientToken;
        private string _databaseName;
        private string _dataviewName;
        private string _description;
        private string _environmentId;
        private bool? _readWrite;
        private List<KxDataviewSegmentConfiguration> _segmentConfigurations = AWSConfigs.InitializeCollections ? new List<KxDataviewSegmentConfiguration>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AutoUpdate. 
        /// <para>
        /// The option to specify whether you want to apply all the future additions and corrections
        /// automatically to the dataview, when you ingest new changesets. The default value is
        /// false.
        /// </para>
        /// </summary>
        public bool? AutoUpdate
        {
            get { return this._autoUpdate; }
            set { this._autoUpdate = value; }
        }

        // Check to see if AutoUpdate property is set
        internal bool IsSetAutoUpdate()
        {
            return this._autoUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        ///  The identifier of the availability zones. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=12)]
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property AzMode. 
        /// <para>
        /// The number of availability zones you want to assign per volume. Currently, FinSpace
        /// only supports <c>SINGLE</c> for volumes. This places dataview in a single AZ.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KxAzMode AzMode
        {
            get { return this._azMode; }
            set { this._azMode = value; }
        }

        // Check to see if AzMode property is set
        internal bool IsSetAzMode()
        {
            return this._azMode != null;
        }

        /// <summary>
        /// Gets and sets the property ChangesetId. 
        /// <para>
        ///  A unique identifier of the changeset that you want to use to ingest data. 
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
        ///  The name of the database where you want to create a dataview. 
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
        /// A unique identifier for the dataview.
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
        /// A description of the dataview.
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
        /// A unique identifier for the kdb environment, where you want to create the dataview.
        /// 
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
        /// Gets and sets the property ReadWrite. 
        /// <para>
        ///  The option to specify whether you want to make the dataview writable to perform database
        /// maintenance. The following are some considerations related to writable dataviews.&#x2028;&#x2028;
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot create partial writable dataviews. When you create writeable dataviews
        /// you must provide the entire database path.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot perform updates on a writeable dataview. Hence, <c>autoUpdate</c> must
        /// be set as <b>False</b> if <c>readWrite</c> is <b>True</b> for a dataview.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must also use a unique volume for creating a writeable dataview. So, if you choose
        /// a volume that is already in use by another dataview, the dataview creation fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Once you create a dataview as writeable, you cannot change it to read-only. So, you
        /// cannot update the <c>readWrite</c> parameter later.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? ReadWrite
        {
            get { return this._readWrite; }
            set { this._readWrite = value; }
        }

        // Check to see if ReadWrite property is set
        internal bool IsSetReadWrite()
        {
            return this._readWrite.HasValue; 
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of key-value pairs to label the dataview. You can add up to 50 tags to a dataview.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}