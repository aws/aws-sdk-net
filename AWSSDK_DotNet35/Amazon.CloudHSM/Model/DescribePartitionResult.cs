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
    public partial class DescribePartitionResult : AmazonWebServiceResponse
    {
        private List<string> _clientList = new List<string>();
        private List<string> _hAPartitionGroupList = new List<string>();
        private string _hsmArn;
        private string _lastModifiedTimestamp;
        private string _partitionArn;
        private string _partitionLabel;
        private string _partitionSerial;
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
        /// Gets and sets the property HAPartitionGroupList.
        /// </summary>
        public List<string> HAPartitionGroupList
        {
            get { return this._hAPartitionGroupList; }
            set { this._hAPartitionGroupList = value; }
        }

        // Check to see if HAPartitionGroupList property is set
        internal bool IsSetHAPartitionGroupList()
        {
            return this._hAPartitionGroupList != null && this._hAPartitionGroupList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HsmArn.
        /// </summary>
        public string HsmArn
        {
            get { return this._hsmArn; }
            set { this._hsmArn = value; }
        }

        // Check to see if HsmArn property is set
        internal bool IsSetHsmArn()
        {
            return this._hsmArn != null;
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
        /// Gets and sets the property PartitionArn.
        /// </summary>
        public string PartitionArn
        {
            get { return this._partitionArn; }
            set { this._partitionArn = value; }
        }

        // Check to see if PartitionArn property is set
        internal bool IsSetPartitionArn()
        {
            return this._partitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionLabel.
        /// </summary>
        public string PartitionLabel
        {
            get { return this._partitionLabel; }
            set { this._partitionLabel = value; }
        }

        // Check to see if PartitionLabel property is set
        internal bool IsSetPartitionLabel()
        {
            return this._partitionLabel != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionSerial.
        /// </summary>
        public string PartitionSerial
        {
            get { return this._partitionSerial; }
            set { this._partitionSerial = value; }
        }

        // Check to see if PartitionSerial property is set
        internal bool IsSetPartitionSerial()
        {
            return this._partitionSerial != null;
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