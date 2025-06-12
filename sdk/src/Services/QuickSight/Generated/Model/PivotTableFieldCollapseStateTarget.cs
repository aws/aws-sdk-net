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
    /// The target of a pivot table field collapse state.
    /// </summary>
    public partial class PivotTableFieldCollapseStateTarget
    {
        private List<DataPathValue> _fieldDataPathValues = AWSConfigs.InitializeCollections ? new List<DataPathValue>() : null;
        private string _fieldId;

        /// <summary>
        /// Gets and sets the property FieldDataPathValues. 
        /// <para>
        /// The data path of the pivot table's header. Used to set the collapse state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=20)]
        public List<DataPathValue> FieldDataPathValues
        {
            get { return this._fieldDataPathValues; }
            set { this._fieldDataPathValues = value; }
        }

        // Check to see if FieldDataPathValues property is set
        internal bool IsSetFieldDataPathValues()
        {
            return this._fieldDataPathValues != null && (this._fieldDataPathValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field ID of the pivot table that the collapse state needs to be set to.
        /// </para>
        /// </summary>
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

    }
}