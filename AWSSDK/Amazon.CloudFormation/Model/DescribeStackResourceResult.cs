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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The output for a DescribeStackResource action.</para>
    /// </summary>
    public class DescribeStackResourceResult
    {
        
        private StackResourceDetail stackResourceDetail;

        /// <summary>
        /// A <c>StackResourceDetail</c> structure containing the description of the specified resource in the specified stack.
        ///  
        /// </summary>
        public StackResourceDetail StackResourceDetail
        {
            get { return this.stackResourceDetail; }
            set { this.stackResourceDetail = value; }
        }

        /// <summary>
        /// Sets the StackResourceDetail property
        /// </summary>
        /// <param name="stackResourceDetail">The value to set for the StackResourceDetail property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStackResourceResult WithStackResourceDetail(StackResourceDetail stackResourceDetail)
        {
            this.stackResourceDetail = stackResourceDetail;
            return this;
        }
            

        // Check to see if StackResourceDetail property is set
        internal bool IsSetStackResourceDetail()
        {
            return this.stackResourceDetail != null;
        }
    }
}
