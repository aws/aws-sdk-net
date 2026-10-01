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
    /// The configuration for a <c>CategoryFilter</c>.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class CategoryFilterConfiguration
    {
        /// <summary>
        /// Gets and sets the property CustomFilterConfiguration. 
        /// <para>
        /// A custom filter that filters based on a single value. This filter can be partially
        /// matched.
        /// </para>
        /// </summary>
        public CustomFilterConfiguration CustomFilterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomFilterConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomFilterConfiguration() => this.CustomFilterConfiguration != null;

        /// <summary>
        /// Gets and sets the property CustomFilterListConfiguration. 
        /// <para>
        /// A list of custom filter values. In the Quick Sight console, this filter type is called
        /// a custom filter list.
        /// </para>
        /// </summary>
        public CustomFilterListConfiguration CustomFilterListConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomFilterListConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomFilterListConfiguration() => this.CustomFilterListConfiguration != null;

        /// <summary>
        /// Gets and sets the property FilterListConfiguration. 
        /// <para>
        /// A list of filter configurations. In the Quick Sight console, this filter type is called
        /// a filter list.
        /// </para>
        /// </summary>
        public FilterListConfiguration FilterListConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FilterListConfiguration property is set.
        /// </summary>
        internal bool IsSetFilterListConfiguration() => this.FilterListConfiguration != null;
    }
}
