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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Configures the solutions' response sorting that enables partners to order solutions
    /// based on specified attributes.
    /// </summary>
    public partial class SolutionSort
    {
        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Specifies the attribute to sort by, such as <c>Name</c>, <c>CreatedDate</c>, or <c>Status</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SolutionSortName SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies the sorting order, either <c>Ascending</c> or <c>Descending</c>. The default
        /// is <c>Descending</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
