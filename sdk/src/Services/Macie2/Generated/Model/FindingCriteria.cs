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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies, as a map, one or more property-based conditions that filter the results
    /// of a query for findings.
    /// </summary>
    public partial class FindingCriteria
    {
        private Dictionary<string, CriterionAdditionalProperties> _criterion = new Dictionary<string, CriterionAdditionalProperties>();

        /// <summary>
        /// Gets and sets the property Criterion. 
        /// <para>
        /// A condition that specifies the property, operator, and one or more values to use to
        /// filter the results.
        /// </para>
        /// </summary>
        public Dictionary<string, CriterionAdditionalProperties> Criterion
        {
            get { return this._criterion; }
            set { this._criterion = value; }
        }

        // Check to see if Criterion property is set
        internal bool IsSetCriterion()
        {
            return this._criterion != null && this._criterion.Count > 0; 
        }

    }
}