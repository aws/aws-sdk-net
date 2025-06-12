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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Defines details for the analysis rule ID mapping table.
    /// </summary>
    public partial class AnalysisRuleIdMappingTable
    {
        private List<string> _dimensionColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _joinColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<QueryConstraint> _queryConstraints = AWSConfigs.InitializeCollections ? new List<QueryConstraint>() : null;

        /// <summary>
        /// Gets and sets the property DimensionColumns. 
        /// <para>
        /// The columns that query runners are allowed to select, group by, or filter by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DimensionColumns
        {
            get { return this._dimensionColumns; }
            set { this._dimensionColumns = value; }
        }

        // Check to see if DimensionColumns property is set
        internal bool IsSetDimensionColumns()
        {
            return this._dimensionColumns != null && (this._dimensionColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JoinColumns. 
        /// <para>
        /// The columns that query runners are allowed to use in an INNER JOIN statement.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<string> JoinColumns
        {
            get { return this._joinColumns; }
            set { this._joinColumns = value; }
        }

        // Check to see if JoinColumns property is set
        internal bool IsSetJoinColumns()
        {
            return this._joinColumns != null && (this._joinColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryConstraints. 
        /// <para>
        /// The query constraints of the analysis rule ID mapping table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public List<QueryConstraint> QueryConstraints
        {
            get { return this._queryConstraints; }
            set { this._queryConstraints = value; }
        }

        // Check to see if QueryConstraints property is set
        internal bool IsSetQueryConstraints()
        {
            return this._queryConstraints != null && (this._queryConstraints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}