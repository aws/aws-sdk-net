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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Information about a serialization/deserialization program (SerDe) which serves as
    /// an extractor and loader.
    /// </summary>
    public partial class SerDeInfo
    {
        private string _name;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private string _serializationLibrary;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the SerDe.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of initialization parameters for the SerDe, in key-value form.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SerializationLibrary. 
        /// <para>
        /// Usually the class that implements the SerDe. An example is: <code>org.apache.hadoop.hive.serde2.columnar.ColumnarSerDe</code>.
        /// </para>
        /// </summary>
        public string SerializationLibrary
        {
            get { return this._serializationLibrary; }
            set { this._serializationLibrary = value; }
        }

        // Check to see if SerializationLibrary property is set
        internal bool IsSetSerializationLibrary()
        {
            return this._serializationLibrary != null;
        }

    }
}