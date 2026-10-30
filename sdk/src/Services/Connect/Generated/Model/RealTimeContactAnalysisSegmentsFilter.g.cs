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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// A filter that restricts the segments returned by <c>ListRealtimeContactAnalysisSegmentsV2</c>.
    /// It currently supports filtering category segments by the tags on the rules that create
    /// them, which enforces tag-based access control on the categories a caller can view.
    /// </summary>
    public partial class RealTimeContactAnalysisSegmentsFilter
    {
        /// <summary>
        /// Gets and sets the property CategoriesAttributeFilter. 
        /// <para>
        /// A filter applied to category segments based on the tags of the rules that create the
        /// matched categories. This filter applies only when <c>SegmentTypes</c> includes <c>Categories</c>.
        /// </para>
        /// </summary>
        public CategoriesAttributeFilter CategoriesAttributeFilter { get; set; }

        /// <summary>
        /// Checks to see if the CategoriesAttributeFilter property is set.
        /// </summary>
        internal bool IsSetCategoriesAttributeFilter() => this.CategoriesAttributeFilter != null;
    }
}
