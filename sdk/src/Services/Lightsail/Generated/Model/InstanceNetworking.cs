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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes monthly data transfer rates and port information for an instance.
    /// </summary>
    public partial class InstanceNetworking
    {
        private MonthlyTransfer _monthlyTransfer;
        private List<InstancePortInfo> _ports = AWSConfigs.InitializeCollections ? new List<InstancePortInfo>() : null;

        /// <summary>
        /// Gets and sets the property MonthlyTransfer. 
        /// <para>
        /// The amount of data in GB allocated for monthly data transfers.
        /// </para>
        /// </summary>
        public MonthlyTransfer MonthlyTransfer
        {
            get { return this._monthlyTransfer; }
            set { this._monthlyTransfer = value; }
        }

        // Check to see if MonthlyTransfer property is set
        internal bool IsSetMonthlyTransfer()
        {
            return this._monthlyTransfer != null;
        }

        /// <summary>
        /// Gets and sets the property Ports. 
        /// <para>
        /// An array of key-value pairs containing information about the ports on the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstancePortInfo> Ports
        {
            get { return this._ports; }
            set { this._ports = value; }
        }

        // Check to see if Ports property is set
        internal bool IsSetPorts()
        {
            return this._ports != null && (this._ports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}