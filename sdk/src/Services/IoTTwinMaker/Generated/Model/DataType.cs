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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// An object that specifies the data type of a property.
    /// </summary>
    public partial class DataType
    {
        private List<DataValue> _allowedValues = AWSConfigs.InitializeCollections ? new List<DataValue>() : null;
        private DataType _nestedType;
        private Relationship _relationship;
        private Type _type;
        private string _unitOfMeasure;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// The allowed values for this data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<DataValue> AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this._allowedValues != null && (this._allowedValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NestedType. 
        /// <para>
        /// The nested type in the data type.
        /// </para>
        /// </summary>
        public DataType NestedType
        {
            get { return this._nestedType; }
            set { this._nestedType = value; }
        }

        // Check to see if NestedType property is set
        internal bool IsSetNestedType()
        {
            return this._nestedType != null;
        }

        /// <summary>
        /// Gets and sets the property Relationship. 
        /// <para>
        /// A relationship that associates a component with another component.
        /// </para>
        /// </summary>
        public Relationship Relationship
        {
            get { return this._relationship; }
            set { this._relationship = value; }
        }

        // Check to see if Relationship property is set
        internal bool IsSetRelationship()
        {
            return this._relationship != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The underlying type of the data type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UnitOfMeasure. 
        /// <para>
        /// The unit of measure used in this data type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string UnitOfMeasure
        {
            get { return this._unitOfMeasure; }
            set { this._unitOfMeasure = value; }
        }

        // Check to see if UnitOfMeasure property is set
        internal bool IsSetUnitOfMeasure()
        {
            return this._unitOfMeasure != null;
        }

    }
}