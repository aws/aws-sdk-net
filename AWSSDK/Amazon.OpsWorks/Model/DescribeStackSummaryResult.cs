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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeStackSummary</c> request.</para>
    /// </summary>
    public partial class DescribeStackSummaryResult
    {
        
        private StackSummary stackSummary;

        /// <summary>
        /// A <c>StackSummary</c> object that contains the results.
        ///  
        /// </summary>
        public StackSummary StackSummary
        {
            get { return this.stackSummary; }
            set { this.stackSummary = value; }
        }

        /// <summary>
        /// Sets the StackSummary property
        /// </summary>
        /// <param name="stackSummary">The value to set for the StackSummary property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStackSummaryResult WithStackSummary(StackSummary stackSummary)
        {
            this.stackSummary = stackSummary;
            return this;
        }
            

        // Check to see if StackSummary property is set
        internal bool IsSetStackSummary()
        {
            return this.stackSummary != null;
        }
    }
}
