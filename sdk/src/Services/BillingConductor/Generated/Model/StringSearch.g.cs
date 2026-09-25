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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A structure that defines string search parameters.
    /// </summary>
    public partial class StringSearch
    {
        /// <summary>
        /// Gets and sets the property SearchOption. 
        /// <para>
        ///  The search option to be applied when performing the string search. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SearchOption SearchOption { get; set; }

        /// <summary>
        /// Checks to see if the SearchOption property is set.
        /// </summary>
        internal bool IsSetSearchOption() => this.SearchOption != null;

        /// <summary>
        /// Gets and sets the property SearchValue. 
        /// <para>
        ///  The value to search for within the specified string field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string SearchValue { get; set; }

        /// <summary>
        /// Checks to see if the SearchValue property is set.
        /// </summary>
        internal bool IsSetSearchValue() => this.SearchValue != null;
    }
}
