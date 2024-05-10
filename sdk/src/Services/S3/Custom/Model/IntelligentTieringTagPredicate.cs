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
    /// <para>All of these tags must exist in the object's tag set in order for the configuration to apply.</para>
    /// </summary>
    public sealed class IntelligentTieringTagPredicate : IntelligentTieringFilterPredicate
	{
        private readonly Tag tag;

        /// <summary>
        /// Construct an IntelligentTieringTagPredicate
        /// </summary>
        /// <param name="tag"></param>
        public IntelligentTieringTagPredicate(Tag tag)
        {
            this.tag = tag;
        }

        /// <summary>
        /// The tag used for the predicate.
        /// </summary>
        public Tag Tag
        {
            get { return this.tag; }
        }

        internal override void Accept(IIntelligentTieringPredicateVisitor intelligentTieiringPredicateVisitor)
        {
            intelligentTieiringPredicateVisitor.Visit(this);
        }
    }
}
