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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// This is the response object from the DisconnectSourceServer operation.
    /// </summary>
    public partial class DisconnectSourceServerResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DataReplicationInfo _dataReplicationInfo;
        private LastLaunchResult _lastLaunchResult;
        private LifeCycle _lifeCycle;
        private string _recoveryInstanceId;
        private SourceProperties _sourceProperties;
        private string _sourceServerID;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Source Server.
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
        /// The Data Replication Info of the Source Server.
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
        /// Gets and sets the property LastLaunchResult. 
        /// <para>
        /// The status of the last recovery launch of this Source Server.
        /// </para>
        /// </summary>
        public LastLaunchResult LastLaunchResult
        {
            get { return this._lastLaunchResult; }
            set { this._lastLaunchResult = value; }
        }

        // Check to see if LastLaunchResult property is set
        internal bool IsSetLastLaunchResult()
        {
            return this._lastLaunchResult != null;
        }

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// The lifecycle information of this Source Server.
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
        /// Gets and sets the property RecoveryInstanceId. 
        /// <para>
        /// The ID of the Recovery Instance associated with this Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=19)]
        public string RecoveryInstanceId
        {
            get { return this._recoveryInstanceId; }
            set { this._recoveryInstanceId = value; }
        }

        // Check to see if RecoveryInstanceId property is set
        internal bool IsSetRecoveryInstanceId()
        {
            return this._recoveryInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceProperties. 
        /// <para>
        /// The source properties of the Source Server.
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
        /// The ID of the Source Server.
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
        /// The tags associated with the Source Server.
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

    }
}