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
    /// <para> The output of the DescribeScalingProcessTypes action. </para>
    /// </summary>
    public class DescribeScalingProcessTypesResult  
    {
        
        private List<ProcessType> processes = new List<ProcessType>();

        /// <summary>
        /// A list of <a>ProcessType</a> names.
        ///  
        /// </summary>
        public List<ProcessType> Processes
        {
            get { return this.processes; }
            set { this.processes = value; }
        }
        /// <summary>
        /// Adds elements to the Processes collection
        /// </summary>
        /// <param name="processes">The values to add to the Processes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeScalingProcessTypesResult WithProcesses(params ProcessType[] processes)
        {
            foreach (ProcessType element in processes)
            {
                this.processes.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Processes collection
        /// </summary>
        /// <param name="processes">The values to add to the Processes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeScalingProcessTypesResult WithProcesses(IEnumerable<ProcessType> processes)
        {
            foreach (ProcessType element in processes)
            {
                this.processes.Add(element);
            }

            return this;
        }

        // Check to see if Processes property is set
        internal bool IsSetProcesses()
        {
            return this.processes.Count > 0;       
        }
    }
}
