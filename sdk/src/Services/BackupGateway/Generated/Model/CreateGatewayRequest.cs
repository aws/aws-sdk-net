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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGateway operation.
    /// Creates a backup gateway. After you create a gateway, you can associate it with a
    /// server using the <code>AssociateGatewayToServer</code> operation.
    /// </summary>
    public partial class CreateGatewayRequest : AmazonBackupGatewayRequest
    {
        private string _activationKey;
        private string _gatewayDisplayName;
        private GatewayType _gatewayType;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ActivationKey. 
        /// <para>
        /// The activation key of the created gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string ActivationKey
        {
            get { return this._activationKey; }
            set { this._activationKey = value; }
        }

        // Check to see if ActivationKey property is set
        internal bool IsSetActivationKey()
        {
            return this._activationKey != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayDisplayName. 
        /// <para>
        /// The display name of the created gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string GatewayDisplayName
        {
            get { return this._gatewayDisplayName; }
            set { this._gatewayDisplayName = value; }
        }

        // Check to see if GatewayDisplayName property is set
        internal bool IsSetGatewayDisplayName()
        {
            return this._gatewayDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayType. 
        /// <para>
        /// The type of created gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GatewayType GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }

        // Check to see if GatewayType property is set
        internal bool IsSetGatewayType()
        {
            return this._gatewayType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags to assign to the gateway. Each tag is a key-value pair.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}