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

namespace Amazon.EC2.Model
{
    /// <summary>Describe Instance Status Result
    /// </summary>
    public partial class DescribeInstanceStatusResult : AmazonWebServiceResponse
    {
        
        private List<InstanceStatus> instanceStatuses = new List<InstanceStatus>();
        private string nextToken;


        /// <summary>
        /// Collection of instance statuses describing the state of the requested instances.
        ///  
        /// </summary>
        public List<InstanceStatus> InstanceStatuses
        {
            get { return this.instanceStatuses; }
            set { this.instanceStatuses = value; }
        }

        // Check to see if InstanceStatuses property is set
        internal bool IsSetInstanceStatuses()
        {
            return this.instanceStatuses.Count > 0;
        }

        /// <summary>
        /// A string specifying the next paginated set of results to return.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
