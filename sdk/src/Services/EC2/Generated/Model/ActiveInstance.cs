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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a running instance in a Spot Fleet.
    /// </summary>
    public partial class ActiveInstance
    {
        private InstanceHealthStatus _instanceHealth;
        private string _instanceId;
        private string _instanceType;
        private string _spotInstanceRequestId;

        /// <summary>
        /// Gets and sets the property InstanceHealth. 
        /// <para>
        /// The health status of the instance. If the status of either the instance status check
        /// or the system status check is <c>impaired</c>, the health status of the instance is
        /// <c>unhealthy</c>. Otherwise, the health status is <c>healthy</c>.
        /// </para>
        /// </summary>
        public InstanceHealthStatus InstanceHealth
        {
            get { return this._instanceHealth; }
            set { this._instanceHealth = value; }
        }

        // Check to see if InstanceHealth property is set
        internal bool IsSetInstanceHealth()
        {
            return this._instanceHealth != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property SpotInstanceRequestId. 
        /// <para>
        /// The ID of the Spot Instance request.
        /// </para>
        /// </summary>
        public string SpotInstanceRequestId
        {
            get { return this._spotInstanceRequestId; }
            set { this._spotInstanceRequestId = value; }
        }

        // Check to see if SpotInstanceRequestId property is set
        internal bool IsSetSpotInstanceRequestId()
        {
            return this._spotInstanceRequestId != null;
        }

    }
}