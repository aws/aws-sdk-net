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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCallAnalyticsCategory operation.
    /// Creates a new Call Analytics category.
    /// 
    ///  
    /// <para>
    /// All categories are automatically applied to your Call Analytics transcriptions. Note
    /// that in order to apply categories to your transcriptions, you must create them before
    /// submitting your transcription request, as categories cannot be applied retroactively.
    /// </para>
    ///  
    /// <para>
    /// When creating a new category, you can use the <c>InputType</c> parameter to label
    /// the category as a <c>POST_CALL</c> or a <c>REAL_TIME</c> category. <c>POST_CALL</c>
    /// categories can only be applied to post-call transcriptions and <c>REAL_TIME</c> categories
    /// can only be applied to real-time transcriptions. If you do not include <c>InputType</c>,
    /// your category is created as a <c>POST_CALL</c> category by default.
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
    /// To learn more about Call Analytics categories, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-batch.html">Creating
    /// categories for post-call transcriptions</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-stream.html">Creating
    /// categories for real-time transcriptions</a>.
    /// </para>
    /// </summary>
    public partial class CreateCallAnalyticsCategoryRequest : AmazonTranscribeServiceRequest
    {
        private string _categoryName;
        private InputType _inputType;
        private List<Rule> _rules = AWSConfigs.InitializeCollections ? new List<Rule>() : null;

        /// <summary>
        /// Gets and sets the property CategoryName. 
        /// <para>
        /// A unique name, chosen by you, for your Call Analytics category. It's helpful to use
        /// a detailed naming system that will make sense to you in the future. For example, it's
        /// better to use <c>sentiment-positive-last30seconds</c> for a category over a generic
        /// name like <c>test-category</c>.
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
        /// Gets and sets the property InputType. 
        /// <para>
        /// Choose whether you want to create a real-time or a post-call category for your Call
        /// Analytics transcription.
        /// </para>
        ///  
        /// <para>
        /// Specifying <c>POST_CALL</c> assigns your category to post-call transcriptions; categories
        /// with this input type cannot be applied to streaming (real-time) transcriptions.
        /// </para>
        ///  
        /// <para>
        /// Specifying <c>REAL_TIME</c> assigns your category to streaming transcriptions; categories
        /// with this input type cannot be applied to post-call transcriptions.
        /// </para>
        ///  
        /// <para>
        /// If you do not include <c>InputType</c>, your category is created as a post-call category
        /// by default.
        /// </para>
        /// </summary>
        public InputType InputType
        {
            get { return this._inputType; }
            set { this._inputType = value; }
        }

        // Check to see if InputType property is set
        internal bool IsSetInputType()
        {
            return this._inputType != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// Rules define a Call Analytics category. When creating a new category, you must create
        /// between 1 and 20 rules for that category. For each rule, you specify a filter you
        /// want applied to the attributes of a call. For example, you can choose a sentiment
        /// filter that detects if a customer's sentiment was positive during the last 30 seconds
        /// of the call.
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
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}