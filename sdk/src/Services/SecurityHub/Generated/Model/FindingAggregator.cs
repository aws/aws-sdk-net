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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A finding aggregator is a Security Hub resource that specifies cross-Region aggregation
    /// settings, including the home Region and any linked Regions.
    /// </summary>
    public partial class FindingAggregator
    {
        private string _findingAggregatorArn;

        /// <summary>
        /// Gets and sets the property FindingAggregatorArn. 
        /// <para>
        /// The ARN of the finding aggregator. You use the finding aggregator ARN to retrieve
        /// details for, update, and delete the finding aggregator.
        /// </para>
        /// </summary>
        public string FindingAggregatorArn
        {
            get { return this._findingAggregatorArn; }
            set { this._findingAggregatorArn = value; }
        }

        // Check to see if FindingAggregatorArn property is set
        internal bool IsSetFindingAggregatorArn()
        {
            return this._findingAggregatorArn != null;
        }

    }
}