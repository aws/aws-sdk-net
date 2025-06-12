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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// TCP flags and masks to inspect packets for, used in stateless rules <a>MatchAttributes</a>
    /// settings.
    /// </summary>
    public partial class TCPFlagField
    {
        private List<string> _flags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _masks = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Flags. 
        /// <para>
        /// Used in conjunction with the <c>Masks</c> setting to define the flags that must be
        /// set and flags that must not be set in order for the packet to match. This setting
        /// can only specify values that are also specified in the <c>Masks</c> setting.
        /// </para>
        ///  
        /// <para>
        /// For the flags that are specified in the masks setting, the following must be true
        /// for the packet to match: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The ones that are set in this flags setting must be set in the packet. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ones that are not set in this flags setting must also not be set in the packet.
        /// 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Flags
        {
            get { return this._flags; }
            set { this._flags = value; }
        }

        // Check to see if Flags property is set
        internal bool IsSetFlags()
        {
            return this._flags != null && (this._flags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Masks. 
        /// <para>
        /// The set of flags to consider in the inspection. To inspect all flags in the valid
        /// values list, leave this with no setting.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Masks
        {
            get { return this._masks; }
            set { this._masks = value; }
        }

        // Check to see if Masks property is set
        internal bool IsSetMasks()
        {
            return this._masks != null && (this._masks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}