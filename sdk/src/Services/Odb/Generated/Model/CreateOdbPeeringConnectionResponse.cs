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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// This is the response object from the CreateOdbPeeringConnection operation.
    /// </summary>
    public partial class CreateOdbPeeringConnectionResponse : AmazonWebServiceResponse
    {
        private string _displayName;
        private string _odbPeeringConnectionId;
        private ResourceStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the ODB peering connection.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property OdbPeeringConnectionId. 
        /// <para>
        /// The unique identifier of the ODB peering connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OdbPeeringConnectionId
        {
            get { return this._odbPeeringConnectionId; }
            set { this._odbPeeringConnectionId = value; }
        }

        // Check to see if OdbPeeringConnectionId property is set
        internal bool IsSetOdbPeeringConnectionId()
        {
            return this._odbPeeringConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ODB peering connection.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>provisioning | active | terminating | terminated | failed</c> 
        /// </para>
        /// </summary>
        public ResourceStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the ODB peering connection.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}