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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSecurityGroups operation.
    /// <para> The DescribeSecurityGroups operation returns information about security groups that you own. </para> <para> If you specify security
    /// group names, information about those security group is returned. Otherwise, information for all security group is returned. If you specify a
    /// group that does not exist, a fault is returned. </para>
    /// </summary>
    public partial class DescribeSecurityGroupsRequest : AmazonEC2Request
    {
        private List<string> groupNames = new List<string>();
        private List<string> groupIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// An optional list of group names that specify the Amazon EC2 security groups to describe.
        ///  
        /// </summary>
        public List<string> GroupNames
        {
            get { return this.groupNames; }
            set { this.groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this.groupNames.Count > 0;
        }
        public List<string> GroupIds
        {
            get { return this.groupIds; }
            set { this.groupIds = value; }
        }

        // Check to see if GroupIds property is set
        internal bool IsSetGroupIds()
        {
            return this.groupIds.Count > 0;
        }

        /// <summary>
        /// A list of filters used to match properties for SecurityGroups. For a complete reference to the available filter keys for this operation, see
        /// the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
