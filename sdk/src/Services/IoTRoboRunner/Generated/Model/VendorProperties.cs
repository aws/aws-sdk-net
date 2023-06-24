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
 * Do not modify this file. This file is generated from the iot-roborunner-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTRoboRunner.Model
{
    /// <summary>
    /// Properties of the worker that are provided by the vendor FMS.
    /// </summary>
    public partial class VendorProperties
    {
        private string _vendorAdditionalFixedProperties;
        private string _vendorAdditionalTransientProperties;
        private string _vendorWorkerId;
        private string _vendorWorkerIpAddress;

        /// <summary>
        /// Gets and sets the property VendorAdditionalFixedProperties.
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string VendorAdditionalFixedProperties
        {
            get { return this._vendorAdditionalFixedProperties; }
            set { this._vendorAdditionalFixedProperties = value; }
        }

        // Check to see if VendorAdditionalFixedProperties property is set
        internal bool IsSetVendorAdditionalFixedProperties()
        {
            return this._vendorAdditionalFixedProperties != null;
        }

        /// <summary>
        /// Gets and sets the property VendorAdditionalTransientProperties.
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string VendorAdditionalTransientProperties
        {
            get { return this._vendorAdditionalTransientProperties; }
            set { this._vendorAdditionalTransientProperties = value; }
        }

        // Check to see if VendorAdditionalTransientProperties property is set
        internal bool IsSetVendorAdditionalTransientProperties()
        {
            return this._vendorAdditionalTransientProperties != null;
        }

        /// <summary>
        /// Gets and sets the property VendorWorkerId.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string VendorWorkerId
        {
            get { return this._vendorWorkerId; }
            set { this._vendorWorkerId = value; }
        }

        // Check to see if VendorWorkerId property is set
        internal bool IsSetVendorWorkerId()
        {
            return this._vendorWorkerId != null;
        }

        /// <summary>
        /// Gets and sets the property VendorWorkerIpAddress.
        /// </summary>
        [AWSProperty(Min=1, Max=45)]
        public string VendorWorkerIpAddress
        {
            get { return this._vendorWorkerIpAddress; }
            set { this._vendorWorkerIpAddress = value; }
        }

        // Check to see if VendorWorkerIpAddress property is set
        internal bool IsSetVendorWorkerIpAddress()
        {
            return this._vendorWorkerIpAddress != null;
        }

    }
}