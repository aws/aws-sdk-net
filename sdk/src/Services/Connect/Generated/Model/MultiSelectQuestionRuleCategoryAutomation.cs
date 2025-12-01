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
    /// Automation rule for multi-select questions based on rule categories.
    /// </summary>
    public partial class MultiSelectQuestionRuleCategoryAutomation
    {
        private string _category;
        private MultiSelectQuestionRuleCategoryAutomationCondition _condition;
        private List<string> _optionRefIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category name for this automation rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The condition for this automation rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MultiSelectQuestionRuleCategoryAutomationCondition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property OptionRefIds. 
        /// <para>
        /// Reference IDs of options for this automation rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> OptionRefIds
        {
            get { return this._optionRefIds; }
            set { this._optionRefIds = value; }
        }

        // Check to see if OptionRefIds property is set
        internal bool IsSetOptionRefIds()
        {
            return this._optionRefIds != null && (this._optionRefIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}