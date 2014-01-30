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
    /// Container for the parameters to the DescribeReservedInstancesModifications operation.
    /// <para>Describes the modifications made to your Reserved Instances. If no parameter is specified, information about all your Reserved
    /// Instances modification requests is returned. If a modification ID is specified, only information about the specific modification is
    /// returned.</para>
    /// </summary>
    public partial class DescribeReservedInstancesModificationsRequest : AmazonEC2Request
    {
        private List<string> reservedInstancesModificationIds = new List<string>();
        private string nextToken;
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// IDs for the submitted modification request.
        ///  
        /// </summary>
        public List<string> ReservedInstancesModificationIds
        {
            get { return this.reservedInstancesModificationIds; }
            set { this.reservedInstancesModificationIds = value; }
        }

        // Check to see if ReservedInstancesModificationIds property is set
        internal bool IsSetReservedInstancesModificationIds()
        {
            return this.reservedInstancesModificationIds.Count > 0;
        }

        /// <summary>
        /// The token for the next page of data.
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

        /// <summary>
        /// One or more filters. <ul> <li> <c>client-token</c> - The idempotency token for the modification request. </li> <li> <c>create-date</c> - The
        /// time when the modification request was created. </li> <li> <c>effective-date</c> - The time when the modification becomes effective. </li>
        /// <li> <c>modification-result.reserved-instances-id</c> - The ID for the Reserved Instances created as part of the modification request. This
        /// ID is only available when the status of the modification is <c>fulfilled</c>. </li> <li>
        /// <c>modification-result.target-configuration.availability-zone</c> - The Availability Zone for the new Reserved Instances. </li> <li>
        /// <c>modification-result.target-configuration.instance-count </c> - The number of new Reserved Instances. </li> <li>
        /// <c>modification-result.target-configuration.instance-type</c> - The instance type of the new Reserved Instances. </li> <li>
        /// <c>modification-result.target-configuration.platform</c> - The network platform of the new Reserved Instances (<c>EC2-Classic</c> |
        /// <c>EC2-VPC</c>). </li> <li> <c>reserved-instances-id</c> - The ID of the Reserved Instances modified. </li> <li>
        /// <c>reserved-instances-modification-id</c> - The ID of the modification request. </li> <li> <c>status</c> - The status of the Reserved
        /// Instances modification request (<c>processing</c> | <c>fulfilled</c> | <c>failed</c>). </li> <li> <c>status-message</c> - The reason for the
        /// status. </li> <li> <c>update-date</c> - The time when the modification request was last updated. </li> </ul>
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
    
