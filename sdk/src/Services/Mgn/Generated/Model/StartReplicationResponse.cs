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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// This is the response object from the StartReplication operation.
    /// </summary>
    public partial class StartReplicationResponse : AmazonWebServiceResponse
    {
        private string _applicationid;
        private string _arn;
        private DataReplicationInfo _dataReplicationInfo;
        private bool? _isArchived;
        private LaunchedInstance _launchedInstance;
        private LifeCycle _lifeCycle;
        private ReplicationType _replicationType;
        private SourceProperties _sourceProperties;
        private string _sourceServerID;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _vcenterClientID;

        /// <summary>
        /// Gets and sets the property ApplicationID. 
        /// <para>
        /// Source server application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string ApplicationID
        {
            get { return this._applicationid; }
            set { this._applicationid = value; }
        }

        // Check to see if ApplicationID property is set
        internal bool IsSetApplicationID()
        {
            return this._applicationid != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Source server ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DataReplicationInfo. 
        /// <para>
        /// Source server data replication info.
        /// </para>
        /// </summary>
        public DataReplicationInfo DataReplicationInfo
        {
            get { return this._dataReplicationInfo; }
            set { this._dataReplicationInfo = value; }
        }

        // Check to see if DataReplicationInfo property is set
        internal bool IsSetDataReplicationInfo()
        {
            return this._dataReplicationInfo != null;
        }

        /// <summary>
        /// Gets and sets the property IsArchived. 
        /// <para>
        /// Source server archived status.
        /// </para>
        /// </summary>
        public bool IsArchived
        {
            get { return this._isArchived.GetValueOrDefault(); }
            set { this._isArchived = value; }
        }

        // Check to see if IsArchived property is set
        internal bool IsSetIsArchived()
        {
            return this._isArchived.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchedInstance. 
        /// <para>
        /// Source server launched instance.
        /// </para>
        /// </summary>
        public LaunchedInstance LaunchedInstance
        {
            get { return this._launchedInstance; }
            set { this._launchedInstance = value; }
        }

        // Check to see if LaunchedInstance property is set
        internal bool IsSetLaunchedInstance()
        {
            return this._launchedInstance != null;
        }

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// Source server lifecycle state.
        /// </para>
        /// </summary>
        public LifeCycle LifeCycle
        {
            get { return this._lifeCycle; }
            set { this._lifeCycle = value; }
        }

        // Check to see if LifeCycle property is set
        internal bool IsSetLifeCycle()
        {
            return this._lifeCycle != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationType. 
        /// <para>
        /// Source server replication type.
        /// </para>
        /// </summary>
        public ReplicationType ReplicationType
        {
            get { return this._replicationType; }
            set { this._replicationType = value; }
        }

        // Check to see if ReplicationType property is set
        internal bool IsSetReplicationType()
        {
            return this._replicationType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceProperties. 
        /// <para>
        /// Source server properties.
        /// </para>
        /// </summary>
        public SourceProperties SourceProperties
        {
            get { return this._sourceProperties; }
            set { this._sourceProperties = value; }
        }

        // Check to see if SourceProperties property is set
        internal bool IsSetSourceProperties()
        {
            return this._sourceProperties != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Source server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string SourceServerID
        {
            get { return this._sourceServerID; }
            set { this._sourceServerID = value; }
        }

        // Check to see if SourceServerID property is set
        internal bool IsSetSourceServerID()
        {
            return this._sourceServerID != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Source server Tags.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VcenterClientID. 
        /// <para>
        /// Source server vCenter client id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string VcenterClientID
        {
            get { return this._vcenterClientID; }
            set { this._vcenterClientID = value; }
        }

        // Check to see if VcenterClientID property is set
        internal bool IsSetVcenterClientID()
        {
            return this._vcenterClientID != null;
        }

    }
}