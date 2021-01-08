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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDimension operation.
    /// Updates the definition for a dimension. You cannot change the type of a dimension
    /// after it is created (you can delete it and recreate it).
    /// </summary>
    public partial class UpdateDimensionRequest : AmazonIoTRequest
    {
        private string _name;
        private List<string> _stringValues = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique identifier for the dimension. Choose something that describes the type and
        /// value to make it easy to remember what it does.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StringValues. 
        /// <para>
        /// Specifies the value or list of values for the dimension. For <code>TOPIC_FILTER</code>
        /// dimensions, this is a pattern used to match the MQTT topic (for example, "admin/#").
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> StringValues
        {
            get { return this._stringValues; }
            set { this._stringValues = value; }
        }

        // Check to see if StringValues property is set
        internal bool IsSetStringValues()
        {
            return this._stringValues != null && this._stringValues.Count > 0; 
        }

    }
}