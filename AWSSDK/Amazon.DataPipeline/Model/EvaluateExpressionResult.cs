/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>Contains the output from the EvaluateExpression action.</para>
    /// </summary>
    public class EvaluateExpressionResult
    {
        
        private string evaluatedExpression;

        /// <summary>
        /// The evaluated expression.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 20971520</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string EvaluatedExpression
        {
            get { return this.evaluatedExpression; }
            set { this.evaluatedExpression = value; }
        }

        /// <summary>
        /// Sets the EvaluatedExpression property
        /// </summary>
        /// <param name="evaluatedExpression">The value to set for the EvaluatedExpression property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EvaluateExpressionResult WithEvaluatedExpression(string evaluatedExpression)
        {
            this.evaluatedExpression = evaluatedExpression;
            return this;
        }
            

        // Check to see if EvaluatedExpression property is set
        internal bool IsSetEvaluatedExpression()
        {
            return this.evaluatedExpression != null;
        }
    }
}
