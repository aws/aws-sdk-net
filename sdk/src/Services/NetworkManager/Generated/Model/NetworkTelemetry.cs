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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes the telemetry information for a resource.
    /// </summary>
    public partial class NetworkTelemetry
    {
        private string _accountId;
        private string _address;
        private string _awsRegion;
        private string _coreNetworkId;
        private ConnectionHealth _health;
        private string _registeredGatewayArn;
        private string _resourceArn;
        private string _resourceId;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string CoreNetworkId
        {
            get { return this._coreNetworkId; }
            set { this._coreNetworkId = value; }
        }

        // Check to see if CoreNetworkId property is set
        internal bool IsSetCoreNetworkId()
        {
            return this._coreNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// The connection health.
        /// </para>
        /// </summary>
        public ConnectionHealth Health
        {
            get { return this._health; }
            set { this._health = value; }
        }

        // Check to see if Health property is set
        internal bool IsSetHealth()
        {
            return this._health != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredGatewayArn. 
        /// <para>
        /// The ARN of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1500)]
        public string RegisteredGatewayArn
        {
            get { return this._registeredGatewayArn; }
            set { this._registeredGatewayArn = value; }
        }

        // Check to see if RegisteredGatewayArn property is set
        internal bool IsSetRegisteredGatewayArn()
        {
            return this._registeredGatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1500)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}