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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// A complex type that contains information about a Resolver configuration for a VPC.
    /// </summary>
    public partial class ResolverConfig
    {
        private ResolverAutodefinedReverseStatus _autodefinedReverse;
        private string _id;
        private string _ownerId;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property AutodefinedReverse. 
        /// <para>
        ///  The status of whether or not the Resolver will create autodefined rules for reverse
        /// DNS lookups. This is enabled by default. The status can be one of following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ENABLING:</b> Autodefined rules for reverse DNS lookups are being enabled but
        /// are not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ENABLED:</b> Autodefined rules for reverse DNS lookups are enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DISABLING:</b> Autodefined rules for reverse DNS lookups are being disabled but
        /// are not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DISABLED:</b> Autodefined rules for reverse DNS lookups are disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResolverAutodefinedReverseStatus AutodefinedReverse
        {
            get { return this._autodefinedReverse; }
            set { this._autodefinedReverse = value; }
        }

        // Check to see if AutodefinedReverse property is set
        internal bool IsSetAutodefinedReverse()
        {
            return this._autodefinedReverse != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID for the Resolver configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The owner account ID of the Amazon Virtual Private Cloud VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=32)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the Amazon Virtual Private Cloud VPC that you're configuring Resolver for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}