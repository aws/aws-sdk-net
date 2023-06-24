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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains a summary of a property associated with a model.
    /// </summary>
    public partial class AssetModelPropertySummary
    {
        private string _assetModelCompositeModelId;
        private PropertyDataType _dataType;
        private string _dataTypeSpec;
        private string _id;
        private string _name;
        private PropertyType _type;
        private string _unit;

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelId. 
        /// <para>
        ///  The ID of the composite model that contains the asset model property. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AssetModelCompositeModelId
        {
            get { return this._assetModelCompositeModelId; }
            set { this._assetModelCompositeModelId = value; }
        }

        // Check to see if AssetModelCompositeModelId property is set
        internal bool IsSetAssetModelCompositeModelId()
        {
            return this._assetModelCompositeModelId != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PropertyDataType DataType
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
        /// Gets and sets the property DataTypeSpec. 
        /// <para>
        /// The data type of the structure for this property. This parameter exists on properties
        /// that have the <code>STRUCT</code> data type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DataTypeSpec
        {
            get { return this._dataTypeSpec; }
            set { this._dataTypeSpec = value; }
        }

        // Check to see if DataTypeSpec property is set
        internal bool IsSetDataTypeSpec()
        {
            return this._dataTypeSpec != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property Type.
        /// </summary>
        [AWSProperty(Required=true)]
        public PropertyType Type
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
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit (such as <code>Newtons</code> or <code>RPM</code>) of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}