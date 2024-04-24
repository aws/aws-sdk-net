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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
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
namespace Amazon.MQ.Model
{
    /// <summary>
    /// The replication details of the data replication-enabled broker. Only returned if dataReplicationMode
    /// or pendingDataReplicationMode is set to CRDR.
    /// </summary>
    public partial class DataReplicationMetadataOutput
    {
        private DataReplicationCounterpart _dataReplicationCounterpart;
        private string _dataReplicationRole;

        /// <summary>
        /// Gets and sets the property DataReplicationCounterpart. 
        /// <para>
        /// Describes the replica/primary broker. Only returned if this broker is currently set
        /// as a primary or replica in the broker's dataReplicationRole property.
        /// </para>
        /// </summary>
        public DataReplicationCounterpart DataReplicationCounterpart
        {
            get { return this._dataReplicationCounterpart; }
            set { this._dataReplicationCounterpart = value; }
        }

        // Check to see if DataReplicationCounterpart property is set
        internal bool IsSetDataReplicationCounterpart()
        {
            return this._dataReplicationCounterpart != null;
        }

        /// <summary>
        /// Gets and sets the property DataReplicationRole. 
        /// <para>
        /// Defines the role of this broker in a data replication pair. When a replica broker
        /// is promoted to primary, this role is interchanged.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataReplicationRole
        {
            get { return this._dataReplicationRole; }
            set { this._dataReplicationRole = value; }
        }

        // Check to see if DataReplicationRole property is set
        internal bool IsSetDataReplicationRole()
        {
            return this._dataReplicationRole != null;
        }

    }
}