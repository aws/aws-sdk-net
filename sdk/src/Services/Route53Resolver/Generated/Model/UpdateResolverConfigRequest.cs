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
    /// Container for the parameters to the UpdateResolverConfig operation.
    /// Updates the behavior configuration of Route 53 Resolver behavior for a single VPC
    /// from Amazon Virtual Private Cloud.
    /// </summary>
    public partial class UpdateResolverConfigRequest : AmazonRoute53ResolverRequest
    {
        private AutodefinedReverseFlag _autodefinedReverseFlag;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property AutodefinedReverseFlag. 
        /// <para>
        /// Indicates whether or not the Resolver will create autodefined rules for reverse DNS
        /// lookups. This is enabled by default. Disabling this option will also affect EC2-Classic
        /// instances using ClassicLink. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon EC2 guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// We are retiring EC2-Classic on August 15, 2022. We recommend that you migrate from
        /// EC2-Classic to a VPC. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
        /// from EC2-Classic to a VPC</a> in the <i>Amazon EC2 guide</i> and the blog <a href="http://aws.amazon.com/blogs/aws/ec2-classic-is-retiring-heres-how-to-prepare/">EC2-Classic
        /// Networking is Retiring – Here’s How to Prepare</a>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// It can take some time for the status change to be completed.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutodefinedReverseFlag AutodefinedReverseFlag
        {
            get { return this._autodefinedReverseFlag; }
            set { this._autodefinedReverseFlag = value; }
        }

        // Check to see if AutodefinedReverseFlag property is set
        internal bool IsSetAutodefinedReverseFlag()
        {
            return this._autodefinedReverseFlag != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Resource ID of the Amazon VPC that you want to update the Resolver configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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