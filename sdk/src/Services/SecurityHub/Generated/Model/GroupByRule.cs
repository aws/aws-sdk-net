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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Defines the how the finding attribute should be grouped.
    /// </summary>
    public partial class GroupByRule
    {
        private OcsfFindingFilters _filters;
        private GroupByField _groupByField;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The criteria used to select which security findings should be included in the grouping
        /// operation.
        /// </para>
        /// </summary>
        public OcsfFindingFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property GroupByField. 
        /// <para>
        /// The attribute by which filtered findings should be grouped.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GroupByField GroupByField
        {
            get { return this._groupByField; }
            set { this._groupByField = value; }
        }

        // Check to see if GroupByField property is set
        internal bool IsSetGroupByField()
        {
            return this._groupByField != null;
        }

    }
}