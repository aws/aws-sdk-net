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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies a property- or tag-based filter condition for including or excluding Amazon
    /// Web Services resources from the query results.
    /// </summary>
    public partial class SearchResourcesCriteria
    {
        private SearchResourcesSimpleCriterion _simpleCriterion;
        private SearchResourcesTagCriterion _tagCriterion;

        /// <summary>
        /// Gets and sets the property SimpleCriterion. 
        /// <para>
        /// A property-based condition that defines a property, operator, and one or more values
        /// for including or excluding resources from the results.
        /// </para>
        /// </summary>
        public SearchResourcesSimpleCriterion SimpleCriterion
        {
            get { return this._simpleCriterion; }
            set { this._simpleCriterion = value; }
        }

        // Check to see if SimpleCriterion property is set
        internal bool IsSetSimpleCriterion()
        {
            return this._simpleCriterion != null;
        }

        /// <summary>
        /// Gets and sets the property TagCriterion. 
        /// <para>
        /// A tag-based condition that defines an operator and tag keys, tag values, or tag key
        /// and value pairs for including or excluding resources from the results.
        /// </para>
        /// </summary>
        public SearchResourcesTagCriterion TagCriterion
        {
            get { return this._tagCriterion; }
            set { this._tagCriterion = value; }
        }

        // Check to see if TagCriterion property is set
        internal bool IsSetTagCriterion()
        {
            return this._tagCriterion != null;
        }

    }
}