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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCallAnalyticsCategory operation.
    /// Creates a new Call Analytics category.
    /// 
    ///  
    /// <para>
    /// All categories are automatically applied to your Call Analytics jobs. Note that in
    /// order to apply your categories to your jobs, you must create them before submitting
    /// your job request, as categories cannot be applied retroactively.
    /// </para>
    ///  
    /// <para>
    /// Call Analytics categories are composed of rules. For each category, you must create
    /// between 1 and 20 rules. Rules can include these parameters: , , , and .
    /// </para>
    ///  
    /// <para>
    /// To update an existing category, see .
    /// </para>
    ///  
    /// <para>
    /// To learn more about:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Call Analytics categories, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/call-analytics-create-categories.html">Creating
    /// categories</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Using rules, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/call-analytics-create-categories.html#call-analytics-create-categories-rules">Rule
    /// criteria</a> and refer to the data type
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call Analytics, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/call-analytics.html">Analyzing
    /// call center audio with Call Analytics</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateCallAnalyticsCategoryRequest : AmazonTranscribeServiceRequest
    {
        private string _categoryName;
        private List<Rule> _rules = new List<Rule>();

        /// <summary>
        /// Gets and sets the property CategoryName. 
        /// <para>
        /// A unique name, chosen by you, for your Call Analytics category. It's helpful to use
        /// a detailed naming system that will make sense to you in the future. For example, it's
        /// better to use <code>sentiment-positive-last30seconds</code> for a category over a
        /// generic name like <code>test-category</code>.
        /// </para>
        ///  
        /// <para>
        /// Category names are case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string CategoryName
        {
            get { return this._categoryName; }
            set { this._categoryName = value; }
        }

        // Check to see if CategoryName property is set
        internal bool IsSetCategoryName()
        {
            return this._categoryName != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// Rules define a Call Analytics category. When creating a new Call Analytics category,
        /// you must create between 1 and 20 rules for that category. For each rule, you specify
        /// a filter you want applied to the attributes of a call. For example, you can choose
        /// a sentiment filter that detects if a customer's sentiment was positive during the
        /// last 30 seconds of the call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

    }
}