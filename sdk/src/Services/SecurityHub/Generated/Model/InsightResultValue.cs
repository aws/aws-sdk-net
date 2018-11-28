/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The insight result values returned by the GetInsightResults operation.
    /// </summary>
    public partial class InsightResultValue
    {
        private int? _count;
        private string _groupByAttributeValue;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of findings returned for each GroupByAttributeValue.
        /// </para>
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
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
        /// The value of the attribute by which the findings are grouped for the insight's whose
        /// results are returned by the GetInsightResults operation.
        /// </para>
        /// </summary>
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