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
    /// The insight results returned by the GetInsightResults operation.
    /// </summary>
    public partial class InsightResults
    {
        private string _groupByAttribute;
        private string _insightArn;
        private List<InsightResultValue> _resultValues = new List<InsightResultValue>();

        /// <summary>
        /// Gets and sets the property GroupByAttribute. 
        /// <para>
        /// The attribute by which the findings are grouped for the insight's whose results are
        /// returned by the GetInsightResults operation.
        /// </para>
        /// </summary>
        public string GroupByAttribute
        {
            get { return this._groupByAttribute; }
            set { this._groupByAttribute = value; }
        }

        // Check to see if GroupByAttribute property is set
        internal bool IsSetGroupByAttribute()
        {
            return this._groupByAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property InsightArn. 
        /// <para>
        /// The ARN of the insight whose results are returned by the GetInsightResults operation.
        /// </para>
        /// </summary>
        public string InsightArn
        {
            get { return this._insightArn; }
            set { this._insightArn = value; }
        }

        // Check to see if InsightArn property is set
        internal bool IsSetInsightArn()
        {
            return this._insightArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResultValues. 
        /// <para>
        /// The list of insight result values returned by the GetInsightResults operation.
        /// </para>
        /// </summary>
        public List<InsightResultValue> ResultValues
        {
            get { return this._resultValues; }
            set { this._resultValues = value; }
        }

        // Check to see if ResultValues property is set
        internal bool IsSetResultValues()
        {
            return this._resultValues != null && this._resultValues.Count > 0; 
        }

    }
}