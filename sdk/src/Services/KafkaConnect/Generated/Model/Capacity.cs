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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Information about the capacity of the connector, whether it is auto scaled or provisioned.
    /// </summary>
    public partial class Capacity
    {
        private AutoScaling _autoScaling;
        private ProvisionedCapacity _provisionedCapacity;

        /// <summary>
        /// Gets and sets the property AutoScaling. 
        /// <para>
        /// Information about the auto scaling parameters for the connector.
        /// </para>
        /// </summary>
        public AutoScaling AutoScaling
        {
            get { return this._autoScaling; }
            set { this._autoScaling = value; }
        }

        // Check to see if AutoScaling property is set
        internal bool IsSetAutoScaling()
        {
            return this._autoScaling != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedCapacity. 
        /// <para>
        /// Details about a fixed capacity allocated to a connector.
        /// </para>
        /// </summary>
        public ProvisionedCapacity ProvisionedCapacity
        {
            get { return this._provisionedCapacity; }
            set { this._provisionedCapacity = value; }
        }

        // Check to see if ProvisionedCapacity property is set
        internal bool IsSetProvisionedCapacity()
        {
            return this._provisionedCapacity != null;
        }

    }
}