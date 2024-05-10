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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the GetResolverQueryLogConfig operation.
    /// Gets information about a specified Resolver query logging configuration, such as the
    /// number of VPCs that the configuration is logging queries for and the location that
    /// logs are sent to.
    /// </summary>
    public partial class GetResolverQueryLogConfigRequest : AmazonRoute53ResolverRequest
    {
        private string _resolverQueryLogConfigId;

        /// <summary>
        /// Gets and sets the property ResolverQueryLogConfigId. 
        /// <para>
        /// The ID of the Resolver query logging configuration that you want to get information
        /// about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ResolverQueryLogConfigId
        {
            get { return this._resolverQueryLogConfigId; }
            set { this._resolverQueryLogConfigId = value; }
        }

        // Check to see if ResolverQueryLogConfigId property is set
        internal bool IsSetResolverQueryLogConfigId()
        {
            return this._resolverQueryLogConfigId != null;
        }

    }
}