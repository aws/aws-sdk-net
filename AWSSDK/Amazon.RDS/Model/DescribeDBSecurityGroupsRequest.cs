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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBSecurityGroups operation.
    /// <para> Returns a list of <c>DBSecurityGroup</c> descriptions. If a <c>DBSecurityGroupName</c> is specified, the list will contain only the
    /// descriptions of the specified DB security group. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBSecurityGroups"/>
    public class DescribeDBSecurityGroupsRequest : AmazonWebServiceRequest
    {
        private string dBSecurityGroupName;
        private List<Filter> filters = new List<Filter>();
        private int? maxRecords;
        private string marker;

        /// <summary>
        /// The name of the DB security group to return details for.
        ///  
        /// </summary>
        public string DBSecurityGroupName
        {
            get { return this.dBSecurityGroupName; }
            set { this.dBSecurityGroupName = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroupName property
        /// </summary>
        /// <param name="dBSecurityGroupName">The value to set for the DBSecurityGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDBSecurityGroupsRequest WithDBSecurityGroupName(string dBSecurityGroupName)
        {
            this.dBSecurityGroupName = dBSecurityGroupName;
            return this;
        }
            

        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this.dBSecurityGroupName != null;
        }

        /// <summary>
        /// This parameter is not currently supported.
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }
        /// <summary>
        /// Adds elements to the Filters collection
        /// </summary>
        /// <param name="filters">The values to add to the Filters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDBSecurityGroupsRequest WithFilters(params Filter[] filters)
        {
            foreach (Filter element in filters)
            {
                this.filters.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Filters collection
        /// </summary>
        /// <param name="filters">The values to add to the Filters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDBSecurityGroupsRequest WithFilters(IEnumerable<Filter> filters)
        {
            foreach (Filter element in filters)
            {
                this.filters.Add(element);
            }

            return this;
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more records exist than the specified <c>MaxRecords</c> value, a pagination
        /// token called a marker is included in the response so that the remaining results may be retrieved. Default: 100 Constraints: minimum 20,
        /// maximum 100
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDBSecurityGroupsRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// An optional pagination token provided by a previous DescribeDBSecurityGroups request. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by <c>MaxRecords</c>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDBSecurityGroupsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
    
