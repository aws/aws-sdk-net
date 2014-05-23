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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeStackSummary</code> request.
    /// </summary>
    public partial class DescribeStackSummaryResult
    {
        private StackSummary _stackSummary;


        /// <summary>
        /// Gets and sets the property StackSummary. 
        /// <para>
        /// A <code>StackSummary</code> object that contains the results.
        /// </para>
        /// </summary>
        public StackSummary StackSummary
        {
            get { return this._stackSummary; }
            set { this._stackSummary = value; }
        }


        /// <summary>
        /// Sets the StackSummary property
        /// </summary>
        /// <param name="stackSummary">The value to set for the StackSummary property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStackSummaryResult WithStackSummary(StackSummary stackSummary)
        {
            this._stackSummary = stackSummary;
            return this;
        }

        // Check to see if StackSummary property is set
        internal bool IsSetStackSummary()
        {
            return this._stackSummary != null;
        }

    }
}