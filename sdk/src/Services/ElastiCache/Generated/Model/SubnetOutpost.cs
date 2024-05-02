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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The ID of the outpost subnet.
    /// </summary>
    public partial class SubnetOutpost
    {
        private string _subnetOutpostArn;

        /// <summary>
        /// Gets and sets the property SubnetOutpostArn. 
        /// <para>
        /// The outpost ARN of the subnet.
        /// </para>
        /// </summary>
        public string SubnetOutpostArn
        {
            get { return this._subnetOutpostArn; }
            set { this._subnetOutpostArn = value; }
        }

        // Check to see if SubnetOutpostArn property is set
        internal bool IsSetSubnetOutpostArn()
        {
            return this._subnetOutpostArn != null;
        }

    }
}