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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a field in an entity schema for REST connector data sources, specifying the
    /// field name and data type.
    /// </summary>
    public partial class FieldDefinition
    {
        private FieldDataType _fieldDataType;
        private string _name;

        /// <summary>
        /// Gets and sets the property FieldDataType. 
        /// <para>
        /// The data type of the field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldDataType FieldDataType
        {
            get { return this._fieldDataType; }
            set { this._fieldDataType = value; }
        }

        // Check to see if FieldDataType property is set
        internal bool IsSetFieldDataType()
        {
            return this._fieldDataType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the field in the entity schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}