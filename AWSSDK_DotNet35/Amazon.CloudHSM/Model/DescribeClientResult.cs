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
    public partial class DescribeClientResult : AmazonWebServiceResponse
    {
        private string _certificate;
        private string _clientArn;
        private List<string> _hAPartitionGroupList = new List<string>();
        private string _label;
        private string _lastModifiedTimestamp;
        private List<string> _partitionList = new List<string>();
        private string _state;
        private string _stateDetails;

        /// <summary>
        /// Gets and sets the property Certificate.
        /// </summary>
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property ClientArn.
        /// </summary>
        public string ClientArn
        {
            get { return this._clientArn; }
            set { this._clientArn = value; }
        }

        // Check to see if ClientArn property is set
        internal bool IsSetClientArn()
        {
            return this._clientArn != null;
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