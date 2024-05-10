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
    /// Container for the parameters to the UpdateInput operation.
    /// Updates an input.
    /// </summary>
    public partial class UpdateInputRequest : AmazonIoTEventsRequest
    {
        private InputDefinition _inputDefinition;
        private string _inputDescription;
        private string _inputName;

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
        /// The name of the input you want to update.
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

    }
}