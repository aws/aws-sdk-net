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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// <b>This data type is used with the Amazon GameLift Servers FleetIQ and game server
    /// groups.</b> 
    /// 
    ///  
    /// <para>
    ///  Filters which game servers may be claimed when calling <c>ClaimGameServer</c>. 
    /// </para>
    /// </summary>
    public partial class ClaimFilterOption
    {
        private List<string> _instanceStatuses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property InstanceStatuses. 
        /// <para>
        /// List of instance statuses that game servers may be claimed on. If provided, the list
        /// must contain the <c>ACTIVE</c> status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceStatuses
        {
            get { return this._instanceStatuses; }
            set { this._instanceStatuses = value; }
        }

        // Check to see if InstanceStatuses property is set
        internal bool IsSetInstanceStatuses()
        {
            return this._instanceStatuses != null && (this._instanceStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}