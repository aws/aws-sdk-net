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
    /// The insight result values returned by the <c>GetInsightResults</c> operation.
    /// </summary>
    public partial class InsightResultValue
    {
        private int? _count;
        private string _groupByAttributeValue;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of findings returned for each <c>GroupByAttributeValue</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupByAttributeValue. 
        /// <para>
        /// The value of the attribute that the findings are grouped by for the insight whose
        /// results are returned by the <c>GetInsightResults</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupByAttributeValue
        {
            get { return this._groupByAttributeValue; }
            set { this._groupByAttributeValue = value; }
        }

        // Check to see if GroupByAttributeValue property is set
        internal bool IsSetGroupByAttributeValue()
        {
            return this._groupByAttributeValue != null;
        }

    }
}