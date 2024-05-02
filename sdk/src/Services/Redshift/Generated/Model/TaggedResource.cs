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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
        private string _resourceName;
        private string _resourceType;
        private Tag _tag;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The Amazon Resource Name (ARN) with which the tag is associated, for example: <c>arn:aws:redshift:us-east-2:123456789:cluster:t1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

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
        [AWSProperty(Max=2147483647)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tag. 
        /// <para>
        /// The tag for the resource.
        /// </para>
        /// </summary>
        public Tag Tag
        {
            get { return this._tag; }
            set { this._tag = value; }
        }

        // Check to see if Tag property is set
        internal bool IsSetTag()
        {
            return this._tag != null;
        }

    }
}