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
    /// Information about the automation option based on a rule category for a single select
    /// question.
    /// </summary>
    public partial class SingleSelectQuestionRuleCategoryAutomation
    {
        private string _category;
        private SingleSelectQuestionRuleCategoryAutomationCondition _condition;
        private string _optionRefId;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        ///  The category name, as defined in Rules.
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
        /// The condition to apply for the automation option. If the condition is <c>PRESENT</c>,
        /// then the option is applied when the contact data includes the category. Similarly,
        /// if the condition is <c>NOT_PRESENT</c>, then the option is applied when the contact
        /// data does not include the category.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SingleSelectQuestionRuleCategoryAutomationCondition Condition
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
        /// Gets and sets the property OptionRefId. 
        /// <para>
        /// The identifier of the answer option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string OptionRefId
        {
            get { return this._optionRefId; }
            set { this._optionRefId = value; }
        }

        // Check to see if OptionRefId property is set
        internal bool IsSetOptionRefId()
        {
            return this._optionRefId != null;
        }

    }
}