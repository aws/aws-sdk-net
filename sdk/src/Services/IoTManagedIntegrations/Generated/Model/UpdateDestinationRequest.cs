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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDestination operation.
    /// Update a destination specified by id.
    /// </summary>
    public partial class UpdateDestinationRequest : AmazonIoTManagedIntegrationsRequest
    {
        private string _deliveryDestinationArn;
        private DeliveryDestinationType _deliveryDestinationType;
        private string _description;
        private string _name;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DeliveryDestinationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer-managed destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DeliveryDestinationArn
        {
            get { return this._deliveryDestinationArn; }
            set { this._deliveryDestinationArn = value; }
        }

        // Check to see if DeliveryDestinationArn property is set
        internal bool IsSetDeliveryDestinationArn()
        {
            return this._deliveryDestinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryDestinationType. 
        /// <para>
        /// The destination type for the customer-managed destination.
        /// </para>
        /// </summary>
        public DeliveryDestinationType DeliveryDestinationType
        {
            get { return this._deliveryDestinationType; }
            set { this._deliveryDestinationType = value; }
        }

        // Check to see if DeliveryDestinationType property is set
        internal bool IsSetDeliveryDestinationType()
        {
            return this._deliveryDestinationType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the customer-managed destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the customer-managed destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the delivery destination role.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}