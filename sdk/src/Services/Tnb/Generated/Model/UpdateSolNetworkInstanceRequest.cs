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

#pragma warning disable CS0612,CS0618,CS1570
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
    ///  
    /// <para>
    /// Choose the <i>updateType</i> parameter to target the necessary update of the network
    /// instance.
    /// </para>
    /// </summary>
    public partial class UpdateSolNetworkInstanceRequest : AmazonTnbRequest
    {
        private UpdateSolNetworkModify _modifyVnfInfoData;
        private string _nsInstanceId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private UpdateSolNetworkServiceData _updateNs;
        private UpdateSolNetworkType _updateType;

        /// <summary>
        /// Gets and sets the property ModifyVnfInfoData. 
        /// <para>
        /// Identifies the network function information parameters and/or the configurable properties
        /// of the network function to be modified.
        /// </para>
        ///  
        /// <para>
        /// Include this property only if the update type is <c>MODIFY_VNF_INFORMATION</c>.
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
        /// of a key and an optional value. When you use this API, the tags are only applied to
        /// the network operation that is created. These tags are not applied to the network instance.
        /// Use tags to search and filter your resources or track your Amazon Web Services costs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdateNs. 
        /// <para>
        /// Identifies the network service descriptor and the configurable properties of the descriptor,
        /// to be used for the update.
        /// </para>
        ///  
        /// <para>
        /// Include this property only if the update type is <c>UPDATE_NS</c>.
        /// </para>
        /// </summary>
        public UpdateSolNetworkServiceData UpdateNs
        {
            get { return this._updateNs; }
            set { this._updateNs = value; }
        }

        // Check to see if UpdateNs property is set
        internal bool IsSetUpdateNs()
        {
            return this._updateNs != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// The type of update.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <c>MODIFY_VNF_INFORMATION</c> update type, to update a specific network function
        /// configuration, in the network instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <c>UPDATE_NS</c> update type, to update the network instance to a new network
        /// service descriptor.
        /// </para>
        ///  </li> </ul>
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