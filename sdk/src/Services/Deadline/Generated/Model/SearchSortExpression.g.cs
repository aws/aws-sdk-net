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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property FieldSort. Options for sorting by a field.
        /// </summary>
        public FieldSortExpression FieldSort { get; set; }

        /// <summary>
        /// Checks to see if the FieldSort property is set.
        /// </summary>
        internal bool IsSetFieldSort() => this.FieldSort != null;

        /// <summary>
        /// Gets and sets the property ParameterSort. Options for sorting by a parameter.
        /// </summary>
        public ParameterSortExpression ParameterSort { get; set; }

        /// <summary>
        /// Checks to see if the ParameterSort property is set.
        /// </summary>
        internal bool IsSetParameterSort() => this.ParameterSort != null;

        /// <summary>
        /// Gets and sets the property UserJobsFirst. Options for sorting a particular user's
        /// jobs first.
        /// </summary>
        public UserJobsFirst UserJobsFirst { get; set; }

        /// <summary>
        /// Checks to see if the UserJobsFirst property is set.
        /// </summary>
        internal bool IsSetUserJobsFirst() => this.UserJobsFirst != null;
    }
}
