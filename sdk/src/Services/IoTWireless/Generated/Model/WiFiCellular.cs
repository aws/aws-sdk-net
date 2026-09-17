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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Configuration for WiFi and cellular location payloads. Contains the confidence level
    /// that determines the size of the uncertainty radius in the position estimate.
    /// </summary>
    public partial class WiFiCellular
    {
        private int? _confidencePercent;

        /// <summary>
        /// Gets and sets the property ConfidencePercent. 
        /// <para>
        /// The confidence level for WiFi and cellular position estimates, expressed as a percentage.
        /// This value determines the size of the confidence area or uncertainty radius for the
        /// estimated position. A higher confidence level produces a larger uncertainty radius,
        /// while a lower confidence level produces a smaller, more precise radius.
        /// </para>
        ///  
        /// <para>
        /// Valid range: 50 to 99 inclusive. If not specified, the default value of 68 is used,
        /// which corresponds to approximately one standard deviation of the normal distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=99)]
        public int? ConfidencePercent
        {
            get { return this._confidencePercent; }
            set { this._confidencePercent = value; }
        }

        // Check to see if ConfidencePercent property is set
        internal bool IsSetConfidencePercent()
        {
            return this._confidencePercent.HasValue; 
        }

    }
}