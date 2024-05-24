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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// UpdateVTLDeviceTypeOutput
    /// </summary>
    public partial class UpdateVTLDeviceTypeResponse : AmazonWebServiceResponse
    {
        private string _vtlDeviceARN;

        /// <summary>
        /// Gets and sets the property VTLDeviceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the medium changer you have selected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string VTLDeviceARN
        {
            get { return this._vtlDeviceARN; }
            set { this._vtlDeviceARN = value; }
        }

        // Check to see if VTLDeviceARN property is set
        internal bool IsSetVTLDeviceARN()
        {
            return this._vtlDeviceARN != null;
        }

    }
}