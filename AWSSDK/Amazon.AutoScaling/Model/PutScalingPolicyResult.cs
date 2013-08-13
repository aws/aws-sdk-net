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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The <c>PolicyARNType</c> data type. </para>
    /// </summary>
    public class PutScalingPolicyResult  
    {
        
        private string policyARN;

        /// <summary>
        /// A policy's Amazon Resource Name (ARN).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PolicyARN
        {
            get { return this.policyARN; }
            set { this.policyARN = value; }
        }

        /// <summary>
        /// Sets the PolicyARN property
        /// </summary>
        /// <param name="policyARN">The value to set for the PolicyARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutScalingPolicyResult WithPolicyARN(string policyARN)
        {
            this.policyARN = policyARN;
            return this;
        }
            

        // Check to see if PolicyARN property is set
        internal bool IsSetPolicyARN()
        {
            return this.policyARN != null;       
        }
    }
}
