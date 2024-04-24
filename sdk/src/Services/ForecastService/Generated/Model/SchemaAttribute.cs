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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// An attribute of a schema, which defines a dataset field. A schema attribute is required
    /// for every field in a dataset. The <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_Schema.html">Schema</a>
    /// object contains an array of <c>SchemaAttribute</c> objects.
    /// </summary>
    public partial class SchemaAttribute
    {
        private string _attributeName;
        private AttributeType _attributeType;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the dataset field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeType. 
        /// <para>
        /// The data type of the field.
        /// </para>
        ///  
        /// <para>
        /// For a related time series dataset, other than date, item_id, and forecast dimensions
        /// attributes, all attributes should be of numerical type (integer/float).
        /// </para>
        /// </summary>
        public AttributeType AttributeType
        {
            get { return this._attributeType; }
            set { this._attributeType = value; }
        }

        // Check to see if AttributeType property is set
        internal bool IsSetAttributeType()
        {
            return this._attributeType != null;
        }

    }
}