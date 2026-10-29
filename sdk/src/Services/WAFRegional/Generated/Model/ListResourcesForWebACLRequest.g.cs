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

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourcesForWebACL operation. <note> <para>
    /// This is <b>AWS WAF Classic Regional</b> documentation. For more information, see <a
    /// href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide. </para> <para> <b>For the latest version of
    /// AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. </para> </note> <para> Returns an array of resources
    /// associated with the specified web ACL. </para>
    /// </summary>
    public partial class ListResourcesForWebACLRequest : AmazonWAFRegionalRequest
    {
        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to list, either an application load balancer or Amazon API Gateway.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property WebACLId. 
        /// <para>
        /// The unique identifier (ID) of the web ACL for which to list the associated resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string WebACLId { get; set; }

        /// <summary>
        /// Checks to see if the WebACLId property is set.
        /// </summary>
        internal bool IsSetWebACLId() => this.WebACLId != null;
    }
}
