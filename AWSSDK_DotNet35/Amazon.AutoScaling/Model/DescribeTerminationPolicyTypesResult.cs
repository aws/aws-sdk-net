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
using Amazon.Runtime;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para>The <c>TerminationPolicyTypes</c> data type.</para>
    /// </summary>
    public partial class DescribeTerminationPolicyTypesResult : AmazonWebServiceResponse
    {
        
        private List<string> terminationPolicyTypes = new List<string>();

        /// <summary>
        /// Termination policies supported by Auto Scaling. They are: <c>OldestInstance</c>, <c>OldestLaunchConfiguration</c>, <c>NewestInstance</c>,
        /// <c>ClosestToNextInstanceHour</c>, <c>Default</c>
        ///  
        /// </summary>
        public List<string> TerminationPolicyTypes
        {
            get { return this.terminationPolicyTypes; }
            set { this.terminationPolicyTypes = value; }
        }

        // Check to see if TerminationPolicyTypes property is set
        internal bool IsSetTerminationPolicyTypes()
        {
            return this.terminationPolicyTypes.Count > 0;
        }
    }
}
