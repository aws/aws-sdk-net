/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeHAPartitionGroupResult : AmazonWebServiceResponse
    {
        private List<string> _clientList = new List<string>();
        private string _hAPartitionGroupArn;
        private string _hAPartitionGroupSerial;
        private string _label;
        private string _lastModifiedTimestamp;
        private List<string> _partitionList = new List<string>();
        private string _state;
        private string _stateDetails;

        /// <summary>
        /// Gets and sets the property ClientList.
        /// </summary>
        public List<string> ClientList
        {
            get { return this._clientList; }
            set { this._clientList = value; }
        }

        // Check to see if ClientList property is set
        internal bool IsSetClientList()
        {
            return this._clientList != null && this._clientList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HAPartitionGroupArn.
        /// </summary>
        public string HAPartitionGroupArn
        {
            get { return this._hAPartitionGroupArn; }
            set { this._hAPartitionGroupArn = value; }
        }

        // Check to see if HAPartitionGroupArn property is set
        internal bool IsSetHAPartitionGroupArn()
        {
            return this._hAPartitionGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property HAPartitionGroupSerial.
        /// </summary>
        public string HAPartitionGroupSerial
        {
            get { return this._hAPartitionGroupSerial; }
            set { this._hAPartitionGroupSerial = value; }
        }

        // Check to see if HAPartitionGroupSerial property is set
        internal bool IsSetHAPartitionGroupSerial()
        {
            return this._hAPartitionGroupSerial != null;
        }

        /// <summary>
        /// Gets and sets the property Label.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp.
        /// </summary>
        public string LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp; }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionList.
        /// </summary>
        public List<string> PartitionList
        {
            get { return this._partitionList; }
            set { this._partitionList = value; }
        }

        // Check to see if PartitionList property is set
        internal bool IsSetPartitionList()
        {
            return this._partitionList != null && this._partitionList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateDetails.
        /// </summary>
        public string StateDetails
        {
            get { return this._stateDetails; }
            set { this._stateDetails = value; }
        }

        // Check to see if StateDetails property is set
        internal bool IsSetStateDetails()
        {
            return this._stateDetails != null;
        }

    }
}