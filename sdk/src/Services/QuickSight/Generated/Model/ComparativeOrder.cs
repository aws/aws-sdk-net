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
    /// A structure that represents a comparative order.
    /// </summary>
    public partial class ComparativeOrder
    {
        private List<string> _specifedOrder = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private UndefinedSpecifiedValueType _treatUndefinedSpecifiedValues;
        private ColumnOrderingType _useOrdering;

        /// <summary>
        /// Gets and sets the property SpecifedOrder. 
        /// <para>
        /// The list of columns to be used in the ordering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SpecifedOrder
        {
            get { return this._specifedOrder; }
            set { this._specifedOrder = value; }
        }

        // Check to see if SpecifedOrder property is set
        internal bool IsSetSpecifedOrder()
        {
            return this._specifedOrder != null && (this._specifedOrder.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TreatUndefinedSpecifiedValues. 
        /// <para>
        /// The treat of undefined specified values. Valid values for this structure are <c>LEAST</c>
        /// and <c>MOST</c>.
        /// </para>
        /// </summary>
        public UndefinedSpecifiedValueType TreatUndefinedSpecifiedValues
        {
            get { return this._treatUndefinedSpecifiedValues; }
            set { this._treatUndefinedSpecifiedValues = value; }
        }

        // Check to see if TreatUndefinedSpecifiedValues property is set
        internal bool IsSetTreatUndefinedSpecifiedValues()
        {
            return this._treatUndefinedSpecifiedValues != null;
        }

        /// <summary>
        /// Gets and sets the property UseOrdering. 
        /// <para>
        /// The ordering type for a column. Valid values for this structure are <c>GREATER_IS_BETTER</c>,
        /// <c>LESSER_IS_BETTER</c> and <c>SPECIFIED</c>.
        /// </para>
        /// </summary>
        public ColumnOrderingType UseOrdering
        {
            get { return this._useOrdering; }
            set { this._useOrdering = value; }
        }

        // Check to see if UseOrdering property is set
        internal bool IsSetUseOrdering()
        {
            return this._useOrdering != null;
        }

    }
}