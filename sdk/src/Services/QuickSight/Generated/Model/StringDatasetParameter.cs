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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A string parameter for a dataset.
    /// </summary>
    public partial class StringDatasetParameter
    {
        private StringDatasetParameterDefaultValues _defaultValues;
        private string _id;
        private string _name;
        private DatasetParameterValueType _valueType;

        /// <summary>
        /// Gets and sets the property DefaultValues. 
        /// <para>
        /// A list of default values for a given string dataset parameter type. This structure
        /// only accepts static values.
        /// </para>
        /// </summary>
        public StringDatasetParameterDefaultValues DefaultValues
        {
            get { return this._defaultValues; }
            set { this._defaultValues = value; }
        }

        // Check to see if DefaultValues property is set
        internal bool IsSetDefaultValues()
        {
            return this._defaultValues != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An identifier for the string parameter that is created in the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// The name of the string parameter that is created in the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property ValueType. 
        /// <para>
        /// The value type of the dataset parameter. Valid values are <c>single value</c> or <c>multi
        /// value</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetParameterValueType ValueType
        {
            get { return this._valueType; }
            set { this._valueType = value; }
        }

        // Check to see if ValueType property is set
        internal bool IsSetValueType()
        {
            return this._valueType != null;
        }

    }
}