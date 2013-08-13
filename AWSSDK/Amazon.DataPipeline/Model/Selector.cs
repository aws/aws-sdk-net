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
    /// <para>A comparision that is used to determine whether a query should return this object.</para>
    /// </summary>
    public class Selector
    {
        
        private string fieldName;
        private Operator operatorValue;

        /// <summary>
        /// The name of the field that the operator will be applied to. The field name is the "key" portion of the field definition in the pipeline
        /// definition syntax that is used by the AWS Data Pipeline API. If the field is not set on the object, the condition fails.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string FieldName
        {
            get { return this.fieldName; }
            set { this.fieldName = value; }
        }

        /// <summary>
        /// Sets the FieldName property
        /// </summary>
        /// <param name="fieldName">The value to set for the FieldName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Selector WithFieldName(string fieldName)
        {
            this.fieldName = fieldName;
            return this;
        }
            

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this.fieldName != null;
        }

        /// <summary>
        /// Contains a logical operation for comparing the value of a field with a specified value.
        ///  
        /// </summary>
        public Operator Operator
        {
            get { return this.operatorValue; }
            set { this.operatorValue = value; }
        }

        /// <summary>
        /// Sets the Operator property
        /// </summary>
        /// <param name="operatorValue">The value to set for the Operator property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Selector WithOperator(Operator operatorValue)
        {
            this.operatorValue = operatorValue;
            return this;
        }
            

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this.operatorValue != null;
        }
    }
}
