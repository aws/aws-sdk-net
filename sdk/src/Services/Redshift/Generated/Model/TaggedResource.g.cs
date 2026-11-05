/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// A tag and its associated resource.
    /// </summary>
    public partial class TaggedResource
    {
        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The Amazon Resource Name (ARN) with which the tag is associated, for example: <c>arn:aws:redshift:us-east-2:123456789:cluster:t1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource with which the tag is associated. Valid resource types are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Cluster
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CIDR/IP
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EC2 security group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Snapshot
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cluster security group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Subnet group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HSM connection
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HSM certificate
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Parameter group
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about Amazon Redshift resource types and constructing ARNs, go
        /// to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-overview.html#redshift-iam-access-control-specify-actions">Constructing
        /// an Amazon Redshift Amazon Resource Name (ARN)</a> in the Amazon Redshift Cluster Management
        /// Guide. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Tag. 
        /// <para>
        /// The tag for the resource.
        /// </para>
        /// </summary>
        public Tag Tag { get; set; }

        /// <summary>
        /// Checks to see if the Tag property is set.
        /// </summary>
        internal bool IsSetTag() => this.Tag != null;
    }
}
