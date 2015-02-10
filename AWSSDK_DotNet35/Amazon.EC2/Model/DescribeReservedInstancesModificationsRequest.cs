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

/*
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Describes the modifications made to your Reserved Instances. If no parameter is specified,
    /// information about all your Reserved Instances modification requests is returned. If
    /// a modification ID is specified, only information about the specific modification is
    /// returned.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
    /// Reserved Instances</a> in the Amazon Elastic Compute Cloud User Guide for Linux.
    /// </para>
    /// </summary>
    public partial class DescribeReservedInstancesModificationsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private string _nextToken;
        private List<string> _reservedInstancesModificationIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>client-token</code> - The idempotency token for the modification request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>create-date</code> - The time when the modification request was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>effective-date</code> - The time when the modification becomes effective.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>modification-result.reserved-instances-id</code> - The ID for the Reserved Instances
        /// created as part of the modification request. This ID is only available when the status
        /// of the modification is <code>fulfilled</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>modification-result.target-configuration.availability-zone</code> - The Availability
        /// Zone for the new Reserved Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>modification-result.target-configuration.instance-count </code> - The number
        /// of new Reserved Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>modification-result.target-configuration.instance-type</code> - The instance
        /// type of the new Reserved Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>modification-result.target-configuration.platform</code> - The network platform
        /// of the new Reserved Instances (<code>EC2-Classic</code> | <code>EC2-VPC</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>reserved-instances-id</code> - The ID of the Reserved Instances modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>reserved-instances-modification-id</code> - The ID of the modification request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>status</code> - The status of the Reserved Instances modification request (<code>processing</code>
        /// | <code>fulfilled</code> | <code>failed</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>status-message</code> - The reason for the status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>update-date</code> - The time when the modification request was last updated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of data.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesModificationIds. 
        /// <para>
        /// IDs for the submitted modification request.
        /// </para>
        /// </summary>
        public List<string> ReservedInstancesModificationIds
        {
            get { return this._reservedInstancesModificationIds; }
            set { this._reservedInstancesModificationIds = value; }
        }

        // Check to see if ReservedInstancesModificationIds property is set
        internal bool IsSetReservedInstancesModificationIds()
        {
            return this._reservedInstancesModificationIds != null && this._reservedInstancesModificationIds.Count > 0; 
        }

    }
}