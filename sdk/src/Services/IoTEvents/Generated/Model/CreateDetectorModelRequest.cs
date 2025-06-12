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
    /// Container for the parameters to the CreateDetectorModel operation.
    /// Creates a detector model.
    /// </summary>
    public partial class CreateDetectorModelRequest : AmazonIoTEventsRequest
    {
        private DetectorModelDefinition _detectorModelDefinition;
        private string _detectorModelDescription;
        private string _detectorModelName;
        private EvaluationMethod _evaluationMethod;
        private string _key;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DetectorModelDefinition. 
        /// <para>
        /// Information that defines how the detectors operate.
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
        /// Gets and sets the property EvaluationMethod. 
        /// <para>
        /// Information about the order in which events are evaluated and how actions are executed.
        /// 
        /// </para>
        /// </summary>
        public EvaluationMethod EvaluationMethod
        {
            get { return this._evaluationMethod; }
            set { this._evaluationMethod = value; }
        }

        // Check to see if EvaluationMethod property is set
        internal bool IsSetEvaluationMethod()
        {
            return this._evaluationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The input attribute key used to identify a device or system to create a detector (an
        /// instance of the detector model) and then to route each input received to the appropriate
        /// detector (instance). This parameter uses a JSON-path expression in the message payload
        /// of each input to specify the attribute-value pair that is used to identify the device
        /// associated with the input.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that can be used to manage the detector model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}