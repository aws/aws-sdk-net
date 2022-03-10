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
    /// Creates a call analytics category. Amazon Transcribe applies the conditions specified
    /// by your call analytics categories to your call analytics jobs. For each analytics
    /// category, you must create between 1 and 20 rules. For example, you can create a 'greeting'
    /// category with a rule that flags calls in which your agent does not use a specified
    /// phrase (for example: "Please note this call may be recorded.") in the first 15 seconds
    /// of the call. When you start a call analytics job, Amazon Transcribe applies all your
    /// existing call analytics categories to that job.
    /// </summary>
    public partial class CreateCallAnalyticsCategoryRequest : AmazonTranscribeServiceRequest
    {
        private string _categoryName;
        private List<Rule> _rules = new List<Rule>();

        /// <summary>
        /// Gets and sets the property CategoryName. 
        /// <para>
        /// A unique name, chosen by you, for your call analytics category. For example, <code>sentiment-positive-last30seconds</code>.
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
        /// Rules make up a call analytics category. When creating a call analytics category,
        /// you must create between 1 and 20 rules for your category. For each rule, you specify
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