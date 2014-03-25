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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The result of a <c>DescribeExpressions</c> request. Contains the expressions configured for the domain specified in the
    /// request.</para>
    /// </summary>
    public partial class DescribeExpressionsResult
    {
        
        private List<ExpressionStatus> expressions = new List<ExpressionStatus>();

        /// <summary>
        /// The expressions configured for the domain.
        ///  
        /// </summary>
        public List<ExpressionStatus> Expressions
        {
            get { return this.expressions; }
            set { this.expressions = value; }
        }
        /// <summary>
        /// Adds elements to the Expressions collection
        /// </summary>
        /// <param name="expressions">The values to add to the Expressions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeExpressionsResult WithExpressions(params ExpressionStatus[] expressions)
        {
            foreach (ExpressionStatus element in expressions)
            {
                this.expressions.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Expressions collection
        /// </summary>
        /// <param name="expressions">The values to add to the Expressions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeExpressionsResult WithExpressions(IEnumerable<ExpressionStatus> expressions)
        {
            foreach (ExpressionStatus element in expressions)
            {
                this.expressions.Add(element);
            }

            return this;
        }

        // Check to see if Expressions property is set
        internal bool IsSetExpressions()
        {
            return this.expressions.Count > 0;
        }
    }
}
