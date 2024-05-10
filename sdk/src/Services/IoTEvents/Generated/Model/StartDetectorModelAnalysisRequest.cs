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
    /// Container for the parameters to the StartDetectorModelAnalysis operation.
    /// Performs an analysis of your detector model. For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-analyze-api.html">Troubleshooting
    /// a detector model</a> in the <i>AWS IoT Events Developer Guide</i>.
    /// </summary>
    public partial class StartDetectorModelAnalysisRequest : AmazonIoTEventsRequest
    {
        private DetectorModelDefinition _detectorModelDefinition;

        /// <summary>
        /// Gets and sets the property DetectorModelDefinition.
        /// </summary>
        [AWSProperty(Required=true)]
        public DetectorModelDefinition DetectorModelDefinition
        {
            get { return this._detectorModelDefinition; }
            set { this._detectorModelDefinition = value; }
        }

        // Check to see if DetectorModelDefinition property is set
        internal bool IsSetDetectorModelDefinition()
        {
            return this._detectorModelDefinition != null;
        }

    }
}