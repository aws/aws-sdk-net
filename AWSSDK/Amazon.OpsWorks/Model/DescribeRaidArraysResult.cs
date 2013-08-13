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
    /// <para>Contains the response to a <c>DescribeRaidArrays</c> request.</para>
    /// </summary>
    public class DescribeRaidArraysResult
    {
        
        private List<RaidArray> raidArrays = new List<RaidArray>();

        /// <summary>
        /// A <c>RaidArrays</c> object that describes the specified RAID arrays.
        ///  
        /// </summary>
        public List<RaidArray> RaidArrays
        {
            get { return this.raidArrays; }
            set { this.raidArrays = value; }
        }
        /// <summary>
        /// Adds elements to the RaidArrays collection
        /// </summary>
        /// <param name="raidArrays">The values to add to the RaidArrays collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeRaidArraysResult WithRaidArrays(params RaidArray[] raidArrays)
        {
            foreach (RaidArray element in raidArrays)
            {
                this.raidArrays.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the RaidArrays collection
        /// </summary>
        /// <param name="raidArrays">The values to add to the RaidArrays collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeRaidArraysResult WithRaidArrays(IEnumerable<RaidArray> raidArrays)
        {
            foreach (RaidArray element in raidArrays)
            {
                this.raidArrays.Add(element);
            }

            return this;
        }

        // Check to see if RaidArrays property is set
        internal bool IsSetRaidArrays()
        {
            return this.raidArrays.Count > 0;
        }
    }
}
