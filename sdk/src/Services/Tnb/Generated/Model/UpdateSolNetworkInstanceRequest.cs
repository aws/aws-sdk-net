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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSolNetworkInstance operation.
    /// Update a network instance.
    /// 
    ///  
    /// <para>
    /// A network instance is a single network created in Amazon Web Services TNB that can
    /// be deployed and on which life-cycle operations (like terminate, update, and delete)
    /// can be performed.
    /// </para>
    /// </summary>
    public partial class UpdateSolNetworkInstanceRequest : AmazonTnbRequest
    {
        private UpdateSolNetworkModify _modifyVnfInfoData;
        private string _nsInstanceId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private UpdateSolNetworkType _updateType;

        /// <summary>
        /// Gets and sets the property ModifyVnfInfoData. 
        /// <para>
        /// Identifies the network function information parameters and/or the configurable properties
        /// of the network function to be modified.
        /// </para>
        /// </summary>
        public UpdateSolNetworkModify ModifyVnfInfoData
        {
            get { return this._modifyVnfInfoData; }
            set { this._modifyVnfInfoData = value; }
        }

        // Check to see if ModifyVnfInfoData property is set
        internal bool IsSetModifyVnfInfoData()
        {
            return this._modifyVnfInfoData != null;
        }

        /// <summary>
        /// Gets and sets the property NsInstanceId. 
        /// <para>
        /// ID of the network instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsInstanceId
        {
            get { return this._nsInstanceId; }
            set { this._nsInstanceId = value; }
        }

        // Check to see if NsInstanceId property is set
        internal bool IsSetNsInstanceId()
        {
            return this._nsInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value. When you use this API, the tags are transferred to
        /// the network operation that is created. Use tags to search and filter your resources
        /// or track your Amazon Web Services costs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
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
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// The type of update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateSolNetworkType UpdateType
        {
            get { return this._updateType; }
            set { this._updateType = value; }
        }

        // Check to see if UpdateType property is set
        internal bool IsSetUpdateType()
        {
            return this._updateType != null;
        }

    }
}