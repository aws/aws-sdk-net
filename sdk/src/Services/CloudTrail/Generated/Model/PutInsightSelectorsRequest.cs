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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the PutInsightSelectors operation.
    /// Lets you enable Insights event logging by specifying the Insights selectors that you
    /// want to enable on an existing trail. You also use <code>PutInsightSelectors</code>
    /// to turn off Insights event logging, by passing an empty list of insight types. In
    /// this release, only <code>ApiCallRateInsight</code> is supported as an Insights selector.
    /// </summary>
    public partial class PutInsightSelectorsRequest : AmazonCloudTrailRequest
    {
        private List<InsightSelector> _insightSelectors = new List<InsightSelector>();
        private string _trailName;

        /// <summary>
        /// Gets and sets the property InsightSelectors. 
        /// <para>
        /// A JSON string that contains the insight types you want to log on a trail. In this
        /// release, only <code>ApiCallRateInsight</code> is supported as an insight type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InsightSelector> InsightSelectors
        {
            get { return this._insightSelectors; }
            set { this._insightSelectors = value; }
        }

        // Check to see if InsightSelectors property is set
        internal bool IsSetInsightSelectors()
        {
            return this._insightSelectors != null && this._insightSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrailName. 
        /// <para>
        /// The name of the CloudTrail trail for which you want to change or add Insights selectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrailName
        {
            get { return this._trailName; }
            set { this._trailName = value; }
        }

        // Check to see if TrailName property is set
        internal bool IsSetTrailName()
        {
            return this._trailName != null;
        }

    }
}