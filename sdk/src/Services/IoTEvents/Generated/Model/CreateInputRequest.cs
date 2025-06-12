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
    /// Container for the parameters to the CreateInput operation.
    /// Creates an input.
    /// </summary>
    public partial class CreateInputRequest : AmazonIoTEventsRequest
    {
        private InputDefinition _inputDefinition;
        private string _inputDescription;
        private string _inputName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property InputDefinition. 
        /// <para>
        /// The definition of the input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputDefinition InputDefinition
        {
            get { return this._inputDefinition; }
            set { this._inputDefinition = value; }
        }

        // Check to see if InputDefinition property is set
        internal bool IsSetInputDefinition()
        {
            return this._inputDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property InputDescription. 
        /// <para>
        /// A brief description of the input.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string InputDescription
        {
            get { return this._inputDescription; }
            set { this._inputDescription = value; }
        }

        // Check to see if InputDescription property is set
        internal bool IsSetInputDescription()
        {
            return this._inputDescription != null;
        }

        /// <summary>
        /// Gets and sets the property InputName. 
        /// <para>
        /// The name you want to give to the input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string InputName
        {
            get { return this._inputName; }
            set { this._inputName = value; }
        }

        // Check to see if InputName property is set
        internal bool IsSetInputName()
        {
            return this._inputName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that can be used to manage the input.
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