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
    /// Class for MetricsTagPredicate
    /// <para>The tag used when evaluating a metrics filter.</para>
    /// </summary>
    public sealed class AnalyticsTagPredicate : AnalyticsFilterPredicate
    {
        private readonly Tag tag;

        /// <summary>
        /// Constructs an instance of AnalyticsTagPredicate
        /// </summary>
        /// <param name="tag"></param>
        public AnalyticsTagPredicate(Tag tag)
        {
            this.tag = tag;
        }

        /// <summary>
        /// The tag to use for the predicate
        /// </summary>
        public Tag Tag
        {
            get { return this.tag; }
        }

        internal override void Accept(IAnalyticsPredicateVisitor analyticsPredicateVisitor)
        {
            analyticsPredicateVisitor.visit(this);
        }
    }
}
