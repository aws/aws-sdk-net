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
    /// Container for the parameters to the UpdateCallAnalyticsCategory operation.
    /// Updates the specified Call Analytics category with new rules. Note that the <code>UpdateCallAnalyticsCategory</code>
    /// operation overwrites all existing rules contained in the specified category. You cannot
    /// append additional rules onto an existing category.
    /// 
    ///  
    /// <para>
    /// To create a new category, see .
    /// </para>
    /// </summary>
    public partial class UpdateCallAnalyticsCategoryRequest : AmazonTranscribeServiceRequest
    {
        private string _categoryName;
        private List<Rule> _rules = new List<Rule>();

        /// <summary>
        /// Gets and sets the property CategoryName. 
        /// <para>
        /// The name of the Call Analytics category you want to update. Category names are case
        /// sensitive.
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
        /// The rules used for the updated Call Analytics category. The rules you provide in this
        /// field replace the ones that are currently being used in the specified category.
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