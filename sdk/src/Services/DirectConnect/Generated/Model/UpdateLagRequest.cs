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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLag operation.
    /// Updates the attributes of the specified link aggregation group (LAG).
    /// 
    ///  
    /// <para>
    /// You can update the following attributes:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The name of the LAG.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The value for the minimum number of connections that must be operational for the LAG
    /// itself to be operational. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When you create a LAG, the default value for the minimum number of operational connections
    /// is zero (0). If you update this value and the number of operational connections falls
    /// below the specified value, the LAG automatically goes down to avoid over-utilization
    /// of the remaining connections. Adjust this value with care, as it could force the LAG
    /// down if it is set higher than the current number of operational connections.
    /// </para>
    /// </summary>
    public partial class UpdateLagRequest : AmazonDirectConnectRequest
    {
        private string _lagId;
        private string _lagName;
        private int? _minimumLinks;

        /// <summary>
        /// Gets and sets the property LagId. 
        /// <para>
        /// The ID of the LAG.
        /// </para>
        /// </summary>
        public string LagId
        {
            get { return this._lagId; }
            set { this._lagId = value; }
        }

        // Check to see if LagId property is set
        internal bool IsSetLagId()
        {
            return this._lagId != null;
        }

        /// <summary>
        /// Gets and sets the property LagName. 
        /// <para>
        /// The name of the LAG.
        /// </para>
        /// </summary>
        public string LagName
        {
            get { return this._lagName; }
            set { this._lagName = value; }
        }

        // Check to see if LagName property is set
        internal bool IsSetLagName()
        {
            return this._lagName != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumLinks. 
        /// <para>
        /// The minimum number of physical connections that must be operational for the LAG itself
        /// to be operational.
        /// </para>
        /// </summary>
        public int MinimumLinks
        {
            get { return this._minimumLinks.GetValueOrDefault(); }
            set { this._minimumLinks = value; }
        }

        // Check to see if MinimumLinks property is set
        internal bool IsSetMinimumLinks()
        {
            return this._minimumLinks.HasValue; 
        }

    }
}