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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// A boolean comparison condition for metric filters.
    /// </summary>
    public partial class MetricFilterBooleanCondition
    {
        private MetricFilterBooleanConditionComparison _comparison;

        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The comparison operator. Valid values: <c>IS_TRUE</c> (matches when the field is true)
        /// | <c>IS_FALSE</c> (matches when the field is false).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricFilterBooleanConditionComparison Comparison
        {
            get { return this._comparison; }
            set { this._comparison = value; }
        }

        // Check to see if Comparison property is set
        internal bool IsSetComparison()
        {
            return this._comparison != null;
        }

    }
}