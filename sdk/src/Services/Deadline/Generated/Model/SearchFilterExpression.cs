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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The type of search filter to apply.
    /// </summary>
    public partial class SearchFilterExpression
    {
        private DateTimeFilterExpression _dateTimeFilter;
        private SearchGroupedFilterExpressions _groupFilter;
        private ParameterFilterExpression _parameterFilter;
        private SearchTermFilterExpression _searchTermFilter;
        private StringFilterExpression _stringFilter;

        /// <summary>
        /// Gets and sets the property DateTimeFilter. 
        /// <para>
        /// Filters based on date and time.
        /// </para>
        /// </summary>
        public DateTimeFilterExpression DateTimeFilter
        {
            get { return this._dateTimeFilter; }
            set { this._dateTimeFilter = value; }
        }

        // Check to see if DateTimeFilter property is set
        internal bool IsSetDateTimeFilter()
        {
            return this._dateTimeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property GroupFilter. 
        /// <para>
        /// Filters by group.
        /// </para>
        /// </summary>
        public SearchGroupedFilterExpressions GroupFilter
        {
            get { return this._groupFilter; }
            set { this._groupFilter = value; }
        }

        // Check to see if GroupFilter property is set
        internal bool IsSetGroupFilter()
        {
            return this._groupFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterFilter. 
        /// <para>
        /// Filters by parameter.
        /// </para>
        /// </summary>
        public ParameterFilterExpression ParameterFilter
        {
            get { return this._parameterFilter; }
            set { this._parameterFilter = value; }
        }

        // Check to see if ParameterFilter property is set
        internal bool IsSetParameterFilter()
        {
            return this._parameterFilter != null;
        }

        /// <summary>
        /// Gets and sets the property SearchTermFilter. 
        /// <para>
        /// Filters by a specified search term.
        /// </para>
        /// </summary>
        public SearchTermFilterExpression SearchTermFilter
        {
            get { return this._searchTermFilter; }
            set { this._searchTermFilter = value; }
        }

        // Check to see if SearchTermFilter property is set
        internal bool IsSetSearchTermFilter()
        {
            return this._searchTermFilter != null;
        }

        /// <summary>
        /// Gets and sets the property StringFilter. 
        /// <para>
        /// Filters by a string.
        /// </para>
        /// </summary>
        public StringFilterExpression StringFilter
        {
            get { return this._stringFilter; }
            set { this._stringFilter = value; }
        }

        // Check to see if StringFilter property is set
        internal bool IsSetStringFilter()
        {
            return this._stringFilter != null;
        }

    }
}