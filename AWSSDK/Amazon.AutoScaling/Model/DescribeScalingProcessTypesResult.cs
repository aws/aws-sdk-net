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
    /// The output of the <a>DescribeScalingProcessTypes</a> action.
    /// </summary>
    public partial class DescribeScalingProcessTypesResult
    {
        private List<ProcessType> _processes = new List<ProcessType>();


        /// <summary>
        /// Gets and sets the property Processes. 
        /// <para>
        ///             A list of <a>ProcessType</a> names.        
        /// </para>
        /// </summary>
        public List<ProcessType> Processes
        {
            get { return this._processes; }
            set { this._processes = value; }
        }

        /// <summary>
        /// Sets the Processes property
        /// </summary>
        /// <param name="processes">The values to add to the Processes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeScalingProcessTypesResult WithProcesses(params ProcessType[] processes)
        {
            foreach (var element in processes)
            {
                this._processes.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Processes property
        /// </summary>
        /// <param name="processes">The values to add to the Processes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeScalingProcessTypesResult WithProcesses(IEnumerable<ProcessType> processes)
        {
            foreach (var element in processes)
            {
                this._processes.Add(element);
            }
            return this;
        }
        // Check to see if Processes property is set
        internal bool IsSetProcesses()
        {
            return this._processes != null && this._processes.Count > 0; 
        }

    }
}