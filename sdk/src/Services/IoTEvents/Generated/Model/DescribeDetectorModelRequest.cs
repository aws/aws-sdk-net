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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDetectorModel operation.
    /// Describes a detector model. If the <c>version</c> parameter is not specified, information
    /// about the latest version is returned.
    /// </summary>
    public partial class DescribeDetectorModelRequest : AmazonIoTEventsRequest
    {
        private string _detectorModelName;
        private string _detectorModelVersion;

        /// <summary>
        /// Gets and sets the property DetectorModelName. 
        /// <para>
        /// The name of the detector model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DetectorModelName
        {
            get { return this._detectorModelName; }
            set { this._detectorModelName = value; }
        }

        // Check to see if DetectorModelName property is set
        internal bool IsSetDetectorModelName()
        {
            return this._detectorModelName != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorModelVersion. 
        /// <para>
        /// The version of the detector model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DetectorModelVersion
        {
            get { return this._detectorModelVersion; }
            set { this._detectorModelVersion = value; }
        }

        // Check to see if DetectorModelVersion property is set
        internal bool IsSetDetectorModelVersion()
        {
            return this._detectorModelVersion != null;
        }

    }
}