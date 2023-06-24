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
    /// The option that determines the hierarchy of any <code>DateTime</code> fields.
    /// </summary>
    public partial class DateTimeHierarchy
    {
        private List<DrillDownFilter> _drillDownFilters = new List<DrillDownFilter>();
        private string _hierarchyId;

        /// <summary>
        /// Gets and sets the property DrillDownFilters. 
        /// <para>
        /// The option that determines the drill down filters for the <code>DateTime</code> hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<DrillDownFilter> DrillDownFilters
        {
            get { return this._drillDownFilters; }
            set { this._drillDownFilters = value; }
        }

        // Check to see if DrillDownFilters property is set
        internal bool IsSetDrillDownFilters()
        {
            return this._drillDownFilters != null && this._drillDownFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HierarchyId. 
        /// <para>
        /// The hierarchy ID of the <code>DateTime</code> hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string HierarchyId
        {
            get { return this._hierarchyId; }
            set { this._hierarchyId = value; }
        }

        // Check to see if HierarchyId property is set
        internal bool IsSetHierarchyId()
        {
            return this._hierarchyId != null;
        }

    }
}