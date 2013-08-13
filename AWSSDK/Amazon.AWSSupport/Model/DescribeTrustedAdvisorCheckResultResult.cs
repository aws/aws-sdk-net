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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Returns the objects or data listed below if successful. Otherwise, returns an error.</para>
    /// </summary>
    public class DescribeTrustedAdvisorCheckResultResult
    {
        
        private TrustedAdvisorCheckResult result;

        /// <summary>
        /// Returns a <a href="API_TrustedAdvisorCheckResult.html" title="TrustedAdvisorCheckResult">TrustedAdvisorCheckResult</a> object.
        ///  
        /// </summary>
        public TrustedAdvisorCheckResult Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        /// <summary>
        /// Sets the Result property
        /// </summary>
        /// <param name="result">The value to set for the Result property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTrustedAdvisorCheckResultResult WithResult(TrustedAdvisorCheckResult result)
        {
            this.result = result;
            return this;
        }
            

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this.result != null;
        }
    }
}
