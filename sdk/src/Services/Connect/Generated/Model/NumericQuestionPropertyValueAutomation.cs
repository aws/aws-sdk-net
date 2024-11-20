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
    /// Information about the property value used in automation of a numeric questions. Label
    /// values are associated with minimum and maximum values for the numeric question.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Sentiment scores have a minimum value of -5 and maximum value of 5.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Duration labels, such as <c>NON_TALK_TIME</c>, <c>CONTACT_DURATION</c>, <c>AGENT_INTERACTION_DURATION</c>,
    /// <c>CUSTOMER_HOLD_TIME</c> have a minimum value of 0 and maximum value of 63072000.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Percentages have a minimum value of 0 and maximum value of 100. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>NUMBER_OF_INTERRUPTIONS</c> has a minimum value of 0 and maximum value of 1000.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class NumericQuestionPropertyValueAutomation
    {
        private NumericQuestionPropertyAutomationLabel _label;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The property label of the automation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NumericQuestionPropertyAutomationLabel Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

    }
}