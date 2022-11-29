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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A grouping of individual filters. Filter groups are applied to the same group of visuals.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/add-a-compound-filter.html">Adding
    /// filter conditions (group filters) with AND and OR operators</a> in the <i>Amazon QuickSight
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class FilterGroup
    {
        private CrossDatasetTypes _crossDataset;
        private string _filterGroupId;
        private List<Filter> _filters = new List<Filter>();
        private FilterScopeConfiguration _scopeConfiguration;
        private WidgetStatus _status;

        /// <summary>
        /// Gets and sets the property CrossDataset. 
        /// <para>
        /// The filter new feature which can apply filter group to all data sets. Choose one of
        /// the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALL_DATASETS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SINGLE_DATASET</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public CrossDatasetTypes CrossDataset
        {
            get { return this._crossDataset; }
            set { this._crossDataset = value; }
        }

        // Check to see if CrossDataset property is set
        internal bool IsSetCrossDataset()
        {
            return this._crossDataset != null;
        }

        /// <summary>
        /// Gets and sets the property FilterGroupId. 
        /// <para>
        /// The value that uniquely identifies a <code>FilterGroup</code> within a dashboard,
        /// template, or analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FilterGroupId
        {
            get { return this._filterGroupId; }
            set { this._filterGroupId = value; }
        }

        // Check to see if FilterGroupId property is set
        internal bool IsSetFilterGroupId()
        {
            return this._filterGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The list of filters that are present in a <code>FilterGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=20)]
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScopeConfiguration. 
        /// <para>
        /// The configuration that specifies what scope to apply to a <code>FilterGroup</code>.
        /// </para>
        ///  
        /// <para>
        /// This is a union type structure. For this structure to be valid, only one of the attributes
        /// can be defined.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterScopeConfiguration ScopeConfiguration
        {
            get { return this._scopeConfiguration; }
            set { this._scopeConfiguration = value; }
        }

        // Check to see if ScopeConfiguration property is set
        internal bool IsSetScopeConfiguration()
        {
            return this._scopeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the <code>FilterGroup</code>.
        /// </para>
        /// </summary>
        public WidgetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}