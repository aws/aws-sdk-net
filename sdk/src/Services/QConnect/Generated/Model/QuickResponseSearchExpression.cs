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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Information about the import job.
    /// </summary>
    public partial class QuickResponseSearchExpression
    {
        private List<QuickResponseFilterField> _filters = AWSConfigs.InitializeCollections ? new List<QuickResponseFilterField>() : null;
        private QuickResponseOrderField _orderOnField;
        private List<QuickResponseQueryField> _queries = AWSConfigs.InitializeCollections ? new List<QuickResponseQueryField>() : null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The configuration of filtering rules applied to quick response query results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<QuickResponseFilterField> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrderOnField. 
        /// <para>
        /// The quick response attribute fields on which the query results are ordered.
        /// </para>
        /// </summary>
        public QuickResponseOrderField OrderOnField
        {
            get { return this._orderOnField; }
            set { this._orderOnField = value; }
        }

        // Check to see if OrderOnField property is set
        internal bool IsSetOrderOnField()
        {
            return this._orderOnField != null;
        }

        /// <summary>
        /// Gets and sets the property Queries. 
        /// <para>
        /// The quick response query expressions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=4)]
        public List<QuickResponseQueryField> Queries
        {
            get { return this._queries; }
            set { this._queries = value; }
        }

        // Check to see if Queries property is set
        internal bool IsSetQueries()
        {
            return this._queries != null && (this._queries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}