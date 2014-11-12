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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// The <code>TerminationPolicyTypes</code> data type.
    /// </summary>
    public partial class DescribeTerminationPolicyTypesResult
    {
        private List<string> _terminationPolicyTypes = new List<string>();


        /// <summary>
        /// Gets and sets the property TerminationPolicyTypes. 
        /// <para>
        ///          Termination policies supported by Auto Scaling. They are:         <code>OldestInstance</code>,
        /// <code>OldestLaunchConfiguration</code>, <code>NewestInstance</code>, <code>ClosestToNextInstanceHour</code>,
        ///          <code>Default</code>     
        /// </para>
        /// </summary>
        public List<string> TerminationPolicyTypes
        {
            get { return this._terminationPolicyTypes; }
            set { this._terminationPolicyTypes = value; }
        }

        /// <summary>
        /// Sets the TerminationPolicyTypes property
        /// </summary>
        /// <param name="terminationPolicyTypes">The values to add to the TerminationPolicyTypes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTerminationPolicyTypesResult WithTerminationPolicyTypes(params string[] terminationPolicyTypes)
        {
            foreach (var element in terminationPolicyTypes)
            {
                this._terminationPolicyTypes.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the TerminationPolicyTypes property
        /// </summary>
        /// <param name="terminationPolicyTypes">The values to add to the TerminationPolicyTypes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTerminationPolicyTypesResult WithTerminationPolicyTypes(IEnumerable<string> terminationPolicyTypes)
        {
            foreach (var element in terminationPolicyTypes)
            {
                this._terminationPolicyTypes.Add(element);
            }
            return this;
        }
        // Check to see if TerminationPolicyTypes property is set
        internal bool IsSetTerminationPolicyTypes()
        {
            return this._terminationPolicyTypes != null && this._terminationPolicyTypes.Count > 0; 
        }

    }
}