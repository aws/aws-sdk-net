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
    /// Information about the detector model.
    /// </summary>
    public partial class DetectorModelSummary
    {
        private DateTime? _creationTime;
        private string _detectorModelDescription;
        private string _detectorModelName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the detector model was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetectorModelDescription. 
        /// <para>
        /// A brief description of the detector model.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string DetectorModelDescription
        {
            get { return this._detectorModelDescription; }
            set { this._detectorModelDescription = value; }
        }

        // Check to see if DetectorModelDescription property is set
        internal bool IsSetDetectorModelDescription()
        {
            return this._detectorModelDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorModelName. 
        /// <para>
        /// The name of the detector model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

    }
}