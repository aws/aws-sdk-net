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
    /// An object that specifies information about time series property values. This object
    /// is used and consumed by the <a href="https://docs.aws.amazon.com/iot-twinmaker/latest/apireference/API_BatchPutPropertyValues.html">BatchPutPropertyValues</a>
    /// action.
    /// </summary>
    public partial class PropertyValueEntry
    {
        private EntityPropertyReference _entityPropertyReference;
        private List<PropertyValue> _propertyValues = AWSConfigs.InitializeCollections ? new List<PropertyValue>() : null;

        /// <summary>
        /// Gets and sets the property EntityPropertyReference. 
        /// <para>
        /// An object that contains information about the entity that has the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntityPropertyReference EntityPropertyReference
        {
            get { return this._entityPropertyReference; }
            set { this._entityPropertyReference = value; }
        }

        // Check to see if EntityPropertyReference property is set
        internal bool IsSetEntityPropertyReference()
        {
            return this._entityPropertyReference != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyValues. 
        /// <para>
        /// A list of objects that specify time series property values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<PropertyValue> PropertyValues
        {
            get { return this._propertyValues; }
            set { this._propertyValues = value; }
        }

        // Check to see if PropertyValues property is set
        internal bool IsSetPropertyValues()
        {
            return this._propertyValues != null && (this._propertyValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}