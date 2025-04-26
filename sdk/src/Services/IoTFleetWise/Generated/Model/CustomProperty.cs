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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Represents a member of the complex data structure. The data type of the property can
    /// be either primitive or another <c>struct</c>.
    /// </summary>
    public partial class CustomProperty
    {
        private string _comment;
        private NodeDataEncoding _dataEncoding;
        private NodeDataType _dataType;
        private string _deprecationMessage;
        private string _description;
        private string _fullyQualifiedName;
        private string _structFullyQualifiedName;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment in addition to the description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property DataEncoding. 
        /// <para>
        /// Indicates whether the property is binary data.
        /// </para>
        /// </summary>
        public NodeDataEncoding DataEncoding
        {
            get { return this._dataEncoding; }
            set { this._dataEncoding = value; }
        }

        // Check to see if DataEncoding property is set
        internal bool IsSetDataEncoding()
        {
            return this._dataEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type for the custom property. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NodeDataType DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property DeprecationMessage. 
        /// <para>
        /// The deprecation message for the node or the branch that was moved or deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DeprecationMessage
        {
            get { return this._deprecationMessage; }
            set { this._deprecationMessage = value; }
        }

        // Check to see if DeprecationMessage property is set
        internal bool IsSetDeprecationMessage()
        {
            return this._deprecationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the custom property.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FullyQualifiedName. 
        /// <para>
        /// The fully qualified name of the custom property. For example, the fully qualified
        /// name of a custom property might be <c>ComplexDataTypes.VehicleDataTypes.SVMCamera.FPS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
        public string FullyQualifiedName
        {
            get { return this._fullyQualifiedName; }
            set { this._fullyQualifiedName = value; }
        }

        // Check to see if FullyQualifiedName property is set
        internal bool IsSetFullyQualifiedName()
        {
            return this._fullyQualifiedName != null;
        }

        /// <summary>
        /// Gets and sets the property StructFullyQualifiedName. 
        /// <para>
        /// The fully qualified name of the struct node for the custom property if the data type
        /// of the custom property is <c>Struct</c> or <c>StructArray</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
        public string StructFullyQualifiedName
        {
            get { return this._structFullyQualifiedName; }
            set { this._structFullyQualifiedName = value; }
        }

        // Check to see if StructFullyQualifiedName property is set
        internal bool IsSetStructFullyQualifiedName()
        {
            return this._structFullyQualifiedName != null;
        }

    }
}