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
    /// Container for the parameters to the DescribeServiceErrors operation.
    /// <para>Describes OpsWorks service errors.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeServiceErrors"/>
    public class DescribeServiceErrorsRequest : AmazonWebServiceRequest
    {
        private string stackId;
        private string instanceId;
        private List<string> serviceErrorIds = new List<string>();

        /// <summary>
        /// The stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        public DescribeServiceErrorsRequest WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The instance ID.
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
        public DescribeServiceErrorsRequest WithInstanceId(string instanceId)
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
        /// An array of service error IDs to be described.
        ///  
        /// </summary>
        public List<string> ServiceErrorIds
        {
            get { return this.serviceErrorIds; }
            set { this.serviceErrorIds = value; }
        }
        /// <summary>
        /// Adds elements to the ServiceErrorIds collection
        /// </summary>
        /// <param name="serviceErrorIds">The values to add to the ServiceErrorIds collection </param>
        /// <returns>this instance</returns>
        public DescribeServiceErrorsRequest WithServiceErrorIds(params string[] serviceErrorIds)
        {
            foreach (string element in serviceErrorIds)
            {
                this.serviceErrorIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ServiceErrorIds collection
        /// </summary>
        /// <param name="serviceErrorIds">The values to add to the ServiceErrorIds collection </param>
        /// <returns>this instance</returns>
        public DescribeServiceErrorsRequest WithServiceErrorIds(IEnumerable<string> serviceErrorIds)
        {
            foreach (string element in serviceErrorIds)
            {
                this.serviceErrorIds.Add(element);
            }

            return this;
        }

        // Check to see if ServiceErrorIds property is set
        internal bool IsSetServiceErrorIds()
        {
            return this.serviceErrorIds.Count > 0;
        }
    }
}
    
