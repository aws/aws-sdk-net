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
    /// The resources to search.
    /// </summary>
    public partial class SearchSortExpression
    {
        private FieldSortExpression _fieldSort;
        private ParameterSortExpression _parameterSort;
        private UserJobsFirst _userJobsFirst;

        /// <summary>
        /// Gets and sets the property FieldSort. 
        /// <para>
        /// Options for sorting by a field.
        /// </para>
        /// </summary>
        public FieldSortExpression FieldSort
        {
            get { return this._fieldSort; }
            set { this._fieldSort = value; }
        }

        // Check to see if FieldSort property is set
        internal bool IsSetFieldSort()
        {
            return this._fieldSort != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterSort. 
        /// <para>
        /// Options for sorting by a parameter.
        /// </para>
        /// </summary>
        public ParameterSortExpression ParameterSort
        {
            get { return this._parameterSort; }
            set { this._parameterSort = value; }
        }

        // Check to see if ParameterSort property is set
        internal bool IsSetParameterSort()
        {
            return this._parameterSort != null;
        }

        /// <summary>
        /// Gets and sets the property UserJobsFirst. 
        /// <para>
        /// Options for sorting a particular user's jobs first.
        /// </para>
        /// </summary>
        public UserJobsFirst UserJobsFirst
        {
            get { return this._userJobsFirst; }
            set { this._userJobsFirst = value; }
        }

        // Check to see if UserJobsFirst property is set
        internal bool IsSetUserJobsFirst()
        {
            return this._userJobsFirst != null;
        }

    }
}