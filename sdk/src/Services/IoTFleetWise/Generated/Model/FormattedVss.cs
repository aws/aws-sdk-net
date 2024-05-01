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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// <a href="https://www.w3.org/auto/wg/wiki/Vehicle_Signal_Specification_(VSS)/Vehicle_Data_Spec">Vehicle
    /// Signal Specification (VSS)</a> is a precise language used to describe and model signals
    /// in vehicle networks. The JSON file collects signal specificiations in a VSS format.
    /// </summary>
    public partial class FormattedVss
    {
        private string _vssJson;

        /// <summary>
        /// Gets and sets the property VssJson. 
        /// <para>
        /// Provides the VSS in JSON format.
        /// </para>
        /// </summary>
        public string VssJson
        {
            get { return this._vssJson; }
            set { this._vssJson = value; }
        }

        // Check to see if VssJson property is set
        internal bool IsSetVssJson()
        {
            return this._vssJson != null;
        }

    }
}