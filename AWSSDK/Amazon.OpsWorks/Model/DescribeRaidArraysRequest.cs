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
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRaidArrays operation.
    /// <para>Describe an instance's RAID arrays.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeRaidArrays"/>
    public class DescribeRaidArraysRequest : AmazonWebServiceRequest
    {
        private string instanceId;
        private List<string> raidArrayIds = new List<string>();

        /// <summary>
        /// The instance ID. If you use this parameter, <c>DescribeRaidArrays</c> returns descriptions of the RAID arrays associated with the specified
        /// instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeRaidArraysRequest WithInstanceId(string instanceId)
        {
            this.instanceId = instanceId;
            return this;
        }
            

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// An array of RAID array IDs. If you use this parameter, <c>DescribeRaidArrays</c> returns descriptions of the specified arrays. Otherwise, it
        /// returns a description of every array.
        ///  
        /// </summary>
        public List<string> RaidArrayIds
        {
            get { return this.raidArrayIds; }
            set { this.raidArrayIds = value; }
        }
        /// <summary>
        /// Adds elements to the RaidArrayIds collection
        /// </summary>
        /// <param name="raidArrayIds">The values to add to the RaidArrayIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeRaidArraysRequest WithRaidArrayIds(params string[] raidArrayIds)
        {
            foreach (string element in raidArrayIds)
            {
                this.raidArrayIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the RaidArrayIds collection
        /// </summary>
        /// <param name="raidArrayIds">The values to add to the RaidArrayIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeRaidArraysRequest WithRaidArrayIds(IEnumerable<string> raidArrayIds)
        {
            foreach (string element in raidArrayIds)
            {
                this.raidArrayIds.Add(element);
            }

            return this;
        }

        // Check to see if RaidArrayIds property is set
        internal bool IsSetRaidArrayIds()
        {
            return this.raidArrayIds.Count > 0;
        }
    }
}
    
