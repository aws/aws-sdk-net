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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
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
namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// Information needed to evaluate data.
    /// </summary>
    public partial class RuleEvaluation
    {
        private SimpleRuleEvaluation _simpleRuleEvaluation;

        /// <summary>
        /// Gets and sets the property SimpleRuleEvaluation. 
        /// <para>
        /// Information needed to compare two values with a comparison operator.
        /// </para>
        /// </summary>
        public SimpleRuleEvaluation SimpleRuleEvaluation
        {
            get { return this._simpleRuleEvaluation; }
            set { this._simpleRuleEvaluation = value; }
        }

        // Check to see if SimpleRuleEvaluation property is set
        internal bool IsSetSimpleRuleEvaluation()
        {
            return this._simpleRuleEvaluation != null;
        }

    }
}