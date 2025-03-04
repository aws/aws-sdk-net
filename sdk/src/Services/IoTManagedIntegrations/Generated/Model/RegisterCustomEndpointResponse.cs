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
    /// This is the response object from the RegisterCustomEndpoint operation.
    /// </summary>
    public partial class RegisterCustomEndpointResponse : AmazonWebServiceResponse
    {
        private string _endpointAddress;

        /// <summary>
        /// Gets and sets the property EndpointAddress. 
        /// <para>
        /// The IoT managed integrations dedicated, custom endpoint for the device to route traffic
        /// through.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string EndpointAddress
        {
            get { return this._endpointAddress; }
            set { this._endpointAddress = value; }
        }

        // Check to see if EndpointAddress property is set
        internal bool IsSetEndpointAddress()
        {
            return this._endpointAddress != null;
        }

    }
}