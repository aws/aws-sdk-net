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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Contains details regarding the supported field type and the operators that can be
    /// applied for filtering.
    /// </summary>
    public partial class FieldTypeDetails
    {
        private string _fieldType;
        private List<string> _filterOperators = new List<string>();
        private List<string> _supportedValues = new List<string>();

        /// <summary>
        /// Gets and sets the property FieldType. 
        /// <para>
        ///  The type of field, such as string, integer, date, and so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FieldType
        {
            get { return this._fieldType; }
            set { this._fieldType = value; }
        }

        // Check to see if FieldType property is set
        internal bool IsSetFieldType()
        {
            return this._fieldType != null;
        }

        /// <summary>
        /// Gets and sets the property FilterOperators. 
        /// <para>
        ///  The list of operators supported by a field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> FilterOperators
        {
            get { return this._filterOperators; }
            set { this._filterOperators = value; }
        }

        // Check to see if FilterOperators property is set
        internal bool IsSetFilterOperators()
        {
            return this._filterOperators != null && this._filterOperators.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedValues. 
        /// <para>
        ///  The list of values that a field can contain. For example, a Boolean <code>fieldType</code>
        /// can have two values: "true" and "false". 
        /// </para>
        /// </summary>
        public List<string> SupportedValues
        {
            get { return this._supportedValues; }
            set { this._supportedValues = value; }
        }

        // Check to see if SupportedValues property is set
        internal bool IsSetSupportedValues()
        {
            return this._supportedValues != null && this._supportedValues.Count > 0; 
        }

    }
}