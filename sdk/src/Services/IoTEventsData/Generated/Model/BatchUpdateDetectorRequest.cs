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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateDetector operation.
    /// Updates the state, variable values, and timer settings of one or more detectors (instances)
    /// of a specified detector model.
    /// </summary>
    public partial class BatchUpdateDetectorRequest : AmazonIoTEventsDataRequest
    {
        private List<UpdateDetectorRequest> _detectors = new List<UpdateDetectorRequest>();

        /// <summary>
        /// Gets and sets the property Detectors. 
        /// <para>
        /// The list of detectors (instances) to update, along with the values to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<UpdateDetectorRequest> Detectors
        {
            get { return this._detectors; }
            set { this._detectors = value; }
        }

        // Check to see if Detectors property is set
        internal bool IsSetDetectors()
        {
            return this._detectors != null && this._detectors.Count > 0; 
        }

    }
}