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
    /// The data path that needs to be sorted.
    /// </summary>
    public partial class DataPathValue
    {
        private DataPathType _dataPathType;
        private string _fieldId;
        private string _fieldValue;

        /// <summary>
        /// Gets and sets the property DataPathType. 
        /// <para>
        /// The type configuration of the field.
        /// </para>
        /// </summary>
        public DataPathType DataPathType
        {
            get { return this._dataPathType; }
            set { this._dataPathType = value; }
        }

        // Check to see if DataPathType property is set
        internal bool IsSetDataPathType()
        {
            return this._dataPathType != null;
        }

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field ID of the field that needs to be sorted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string FieldId
        {
            get { return this._fieldId; }
            set { this._fieldId = value; }
        }

        // Check to see if FieldId property is set
        internal bool IsSetFieldId()
        {
            return this._fieldId != null;
        }

        /// <summary>
        /// Gets and sets the property FieldValue. 
        /// <para>
        /// The actual value of the field that needs to be sorted.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=2048)]
        public string FieldValue
        {
            get { return this._fieldValue; }
            set { this._fieldValue = value; }
        }

        // Check to see if FieldValue property is set
        internal bool IsSetFieldValue()
        {
            return this._fieldValue != null;
        }

    }
}