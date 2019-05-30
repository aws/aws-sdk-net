/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDetectorModel operation.
    /// Updates a detector model. Detectors (instances) spawned by the previous version will
    /// be deleted and re-created as new inputs arrive.
    /// </summary>
    public partial class UpdateDetectorModelRequest : AmazonIoTEventsRequest
    {
        private DetectorModelDefinition _detectorModelDefinition;
        private string _detectorModelDescription;
        private string _detectorModelName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DetectorModelDefinition. 
        /// <para>
        /// Information that defines how a detector operates.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property DetectorModelDescription. 
        /// <para>
        /// A brief description of the detector model.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// The name of the detector model to be updated.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants permission to AWS IoT Events to perform its operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}