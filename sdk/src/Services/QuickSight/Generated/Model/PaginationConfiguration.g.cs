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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The pagination configuration for a table visual or boxplot.
    /// </summary>
    public partial class PaginationConfiguration
    {
        /// <summary>
        /// Gets and sets the property PageNumber. 
        /// <para>
        /// Indicates the page number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// Checks to see if the PageNumber property is set.
        /// </summary>
        internal bool IsSetPageNumber() => this.PageNumber.HasValue;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// Indicates how many items render in one page.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;
    }
}
