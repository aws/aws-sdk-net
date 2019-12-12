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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// <important> 
    /// <para>
    ///  <i> <b>Cost Category is in preview release for AWS Billing and Cost Management and
    /// is subject to change. Your use of Cost Categories is subject to the Beta Service Participation
    /// terms of the <a href="https://aws.amazon.com/service-terms/">AWS Service Terms</a>
    /// (Section 1.10).</b> </i> 
    /// </para>
    ///  </important> 
    /// <para>
    /// Rules are processed in order. If there are multiple rules that match the line item,
    /// then the first rule to match is used to determine that Cost Category value.
    /// </para>
    /// </summary>
    public partial class CostCategoryRule
    {
        private Expression _rule;
        private string _value;

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// An <a href="http://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object used to categorize costs. This supports dimensions, Tags, and nested expressions.
        /// Currently the only dimensions supported is <code>LINKED_ACCOUNT</code>.
        /// </para>
        ///  
        /// <para>
        /// Root level <code>OR</code> is not supported. We recommend you create a separate rule
        /// instead.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Expression Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

        /// <summary>
        /// Gets and sets the property Value.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}