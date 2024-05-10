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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about compute hardware assets.
    /// </summary>
    public partial class ComputeAttributes
    {
        private string _hostId;
        private List<string> _instanceFamilies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ComputeAssetState _state;

        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        ///  The host ID of the Dedicated Host on the asset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string HostId
        {
            get { return this._hostId; }
            set { this._hostId = value; }
        }

        // Check to see if HostId property is set
        internal bool IsSetHostId()
        {
            return this._hostId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFamilies. 
        /// <para>
        /// A list of the names of instance families that are currently associated with a given
        /// asset.
        /// </para>
        /// </summary>
        public List<string> InstanceFamilies
        {
            get { return this._instanceFamilies; }
            set { this._instanceFamilies = value; }
        }

        // Check to see if InstanceFamilies property is set
        internal bool IsSetInstanceFamilies()
        {
            return this._instanceFamilies != null && (this._instanceFamilies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACTIVE - The asset is available and can provide capacity for new compute resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ISOLATED - The asset is undergoing maintenance and can't provide capacity for new
        /// compute resources. Existing compute resources on the asset are not affected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RETIRING - The underlying hardware for the asset is degraded. Capacity for new compute
        /// resources is reduced. Amazon Web Services sends notifications for resources that must
        /// be stopped before the asset can be replaced.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ComputeAssetState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}