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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// This structure describes the filtering of columns in a table based on a filter condition.
    /// </summary>
    public partial class FilterCondition
    {
        private ComparisonOperator _comparisonOperator;
        private FieldNameString _field;
        private List<string> _stringValueList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The comparison operator used in the filter condition.
        /// </para>
        /// </summary>
        public ComparisonOperator ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The field to filter in the filter condition.
        /// </para>
        /// </summary>
        public FieldNameString Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property StringValueList. 
        /// <para>
        /// A string with values used in evaluating the filter condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StringValueList
        {
            get { return this._stringValueList; }
            set { this._stringValueList = value; }
        }

        // Check to see if StringValueList property is set
        internal bool IsSetStringValueList()
        {
            return this._stringValueList != null && (this._stringValueList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}