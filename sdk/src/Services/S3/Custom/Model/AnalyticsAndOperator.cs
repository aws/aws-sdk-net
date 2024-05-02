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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.S3.Model.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Class for AnalyticsAndOperator
    /// <para>A conjunction (logical AND) of predicates, which is used in evaluating a metrics filter. 
    /// The operator must have at least two predicates, and an object must match all of the predicates 
    /// in order for the filter to apply.</para>
    /// </summary>
    /// Note: The current implementation restricts the usage to atmost one AnalyticsPrefixPredicate
    /// and any number of AnalyticsTagPredicates.
    public sealed class AnalyticsAndOperator : AnalyticsNAryOperator
    {
        /// <summary>
        /// Constructs an instance of AnalyticsAndOperator
        /// </summary>
        /// <param name="operands"></param>
        public AnalyticsAndOperator(List<AnalyticsFilterPredicate> operands) :
            base(operands)
        { }

        internal override void Accept(IAnalyticsPredicateVisitor analyticsPredicateVisitor)
        {
            analyticsPredicateVisitor.visit(this);
        }
    }
}
