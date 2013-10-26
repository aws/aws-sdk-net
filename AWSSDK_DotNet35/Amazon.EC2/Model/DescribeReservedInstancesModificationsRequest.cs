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
    /// <para> The DescribeReservedInstancesModifications operation describes modifications made to Reserved Instances in your account. </para>
    /// </summary>
    public partial class DescribeReservedInstancesModificationsRequest : AmazonEC2Request
    {
        private List<string> reservedInstancesModificationIds = new List<string>();
        private string nextToken;
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// An optional list of Reserved Instances modification IDs to describe.
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

        /// <summary>
        /// A list of filters used to match properties for ReservedInstancesModifications. For a complete reference to the available filter keys for
        /// this operation, see the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
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
    
