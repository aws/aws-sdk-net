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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Information about an import task created for an individual Sidewalk device.
    /// </summary>
    public partial class SidewalkSingleStartImportInfo
    {
        private string _sidewalkManufacturingSn;

        /// <summary>
        /// Gets and sets the property SidewalkManufacturingSn. 
        /// <para>
        /// The Sidewalk manufacturing serial number (SMSN) of the device added to the import
        /// task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string SidewalkManufacturingSn
        {
            get { return this._sidewalkManufacturingSn; }
            set { this._sidewalkManufacturingSn = value; }
        }

        // Check to see if SidewalkManufacturingSn property is set
        internal bool IsSetSidewalkManufacturingSn()
        {
            return this._sidewalkManufacturingSn != null;
        }

    }
}