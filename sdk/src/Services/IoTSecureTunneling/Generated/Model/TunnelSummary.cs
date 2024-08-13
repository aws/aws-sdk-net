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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
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
namespace Amazon.IoTSecureTunneling.Model
{
    /// <summary>
    /// Information about the tunnel.
    /// </summary>
    public partial class TunnelSummary
    {
        private DateTime? _createdAt;
        private string _description;
        private DateTime? _lastUpdatedAt;
        private TunnelStatus _status;
        private string _tunnelArn;
        private string _tunnelId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the tunnel was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the tunnel.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time the tunnel was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a tunnel. Valid values are: Open and Closed.
        /// </para>
        /// </summary>
        public TunnelStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelArn. 
        /// <para>
        /// The Amazon Resource Name of the tunnel. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string TunnelArn
        {
            get { return this._tunnelArn; }
            set { this._tunnelArn = value; }
        }

        // Check to see if TunnelArn property is set
        internal bool IsSetTunnelArn()
        {
            return this._tunnelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelId. 
        /// <para>
        /// The unique alpha-numeric identifier for the tunnel.
        /// </para>
        /// </summary>
        public string TunnelId
        {
            get { return this._tunnelId; }
            set { this._tunnelId = value; }
        }

        // Check to see if TunnelId property is set
        internal bool IsSetTunnelId()
        {
            return this._tunnelId != null;
        }

    }
}