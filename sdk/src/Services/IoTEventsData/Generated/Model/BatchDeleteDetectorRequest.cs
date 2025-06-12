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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDeleteDetector operation.
    /// Deletes one or more detectors that were created. When a detector is deleted, its state
    /// will be cleared and the detector will be removed from the list of detectors. The deleted
    /// detector will no longer appear if referenced in the <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_iotevents-data_ListDetectors.html">ListDetectors</a>
    /// API call.
    /// </summary>
    public partial class BatchDeleteDetectorRequest : AmazonIoTEventsDataRequest
    {
        private List<DeleteDetectorRequest> _detectors = AWSConfigs.InitializeCollections ? new List<DeleteDetectorRequest>() : null;

        /// <summary>
        /// Gets and sets the property Detectors. 
        /// <para>
        /// The list of one or more detectors to be deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<DeleteDetectorRequest> Detectors
        {
            get { return this._detectors; }
            set { this._detectors = value; }
        }

        // Check to see if Detectors property is set
        internal bool IsSetDetectors()
        {
            return this._detectors != null && (this._detectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}