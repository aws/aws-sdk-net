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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The provider schema attribute.
    /// </summary>
    public partial class ProviderSchemaAttribute
    {
        private string _fieldName;
        private bool? _hashing;
        private string _subType;
        private SchemaAttributeType _type;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The field name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property Hashing. 
        /// <para>
        /// The hashing attribute of the provider schema.
        /// </para>
        /// </summary>
        public bool Hashing
        {
            get { return this._hashing.GetValueOrDefault(); }
            set { this._hashing = value; }
        }

        // Check to see if Hashing property is set
        internal bool IsSetHashing()
        {
            return this._hashing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubType. 
        /// <para>
        /// The sub type of the provider schema attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string SubType
        {
            get { return this._subType; }
            set { this._subType = value; }
        }

        // Check to see if SubType property is set
        internal bool IsSetSubType()
        {
            return this._subType != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the provider schema attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaAttributeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}