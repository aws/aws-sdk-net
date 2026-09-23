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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// The out-of-sync reasons for a resource, or a marker indicating that the details are
    /// not visible. Exactly one member is set.
    /// </summary>
    public partial class OutOfSyncReasonsView
    {
        private NotVisibleMarker _notVisible;
        private Dictionary<string, FirewallSyncReason> _reasons = AWSConfigs.InitializeCollections ? new Dictionary<string, FirewallSyncReason>() : null;

        /// <summary>
        /// Gets and sets the property NotVisible. 
        /// <para>
        /// Indicates that the details are not visible because of cross-account restrictions.
        /// </para>
        /// </summary>
        public NotVisibleMarker NotVisible
        {
            get { return this._notVisible; }
            set { this._notVisible = value; }
        }

        // Check to see if NotVisible property is set
        internal bool IsSetNotVisible()
        {
            return this._notVisible != null;
        }

        /// <summary>
        /// Gets and sets the property Reasons. 
        /// <para>
        /// The out-of-sync reasons, keyed by firewall type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, FirewallSyncReason> Reasons
        {
            get { return this._reasons; }
            set { this._reasons = value; }
        }

        // Check to see if Reasons property is set
        internal bool IsSetReasons()
        {
            return this._reasons != null && (this._reasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}