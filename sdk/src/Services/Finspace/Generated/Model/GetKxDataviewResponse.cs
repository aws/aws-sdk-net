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
    /// This is the response object from the GetKxDataview operation.
    /// </summary>
    public partial class GetKxDataviewResponse : AmazonWebServiceResponse
    {
        private List<KxDataviewActiveVersion> _activeVersions = AWSConfigs.InitializeCollections ? new List<KxDataviewActiveVersion>() : null;
        private bool? _autoUpdate;
        private string _availabilityZoneId;
        private KxAzMode _azMode;
        private string _changesetId;
        private DateTime? _createdTimestamp;
        private string _databaseName;
        private string _dataviewName;
        private string _description;
        private string _environmentId;
        private DateTime? _lastModifiedTimestamp;
        private bool? _readWrite;
        private List<KxDataviewSegmentConfiguration> _segmentConfigurations = AWSConfigs.InitializeCollections ? new List<KxDataviewSegmentConfiguration>() : null;
        private KxDataviewStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property ActiveVersions. 
        /// <para>
        ///  The current active changeset versions of the database on the given dataview. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KxDataviewActiveVersion> ActiveVersions
        {
            get { return this._activeVersions; }
            set { this._activeVersions = value; }
        }

        // Check to see if ActiveVersions property is set
        internal bool IsSetActiveVersions()
        {
            return this._activeVersions != null && (this._activeVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoUpdate. 
        /// <para>
        /// The option to specify whether you want to apply all the future additions and corrections
        /// automatically to the dataview when new changesets are ingested. The default value
        /// is false.
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
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp at which the dataview was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000.
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        ///  The name of the database where you created the dataview.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
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
        /// A unique identifier for the kdb environment, from where you want to retrieve the dataview
        /// details.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        ///  The last time that the dataview was updated in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000. 
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp; }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadWrite. 
        /// <para>
        /// Returns True if the dataview is created as writeable and False otherwise. 
        /// </para>
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of dataview creation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> – The dataview creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> – The dataview is in the process of being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> – The dataview is active.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KxDataviewStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  The error message when a failed state occurs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}