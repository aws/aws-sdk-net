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
using Amazon.S3.Model.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// <para>A container for specifying S3 Intelligent-Tiering filters. 
    /// The filters determine the subset of objects to which the rule applies.</para>
    /// </summary>
    public sealed class IntelligentTieringAndOperator : IntelligentTieringNAryOperator
    {
        /// <summary>
        /// Construct an instance of IntelligentTieringAndOperator
        /// </summary>
        /// <param name="operands"></param>
        public IntelligentTieringAndOperator(List<IntelligentTieringFilterPredicate> operands) :
            base(operands)
        { }

        internal override void Accept(IIntelligentTieringPredicateVisitor intelligentTieringPredicateVisitor)
        {
            intelligentTieringPredicateVisitor.Visit(this);
        }
    }
}
