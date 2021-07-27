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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProtection operation.
    /// Enables Shield Advanced for a specific Amazon Web Services resource. The resource
    /// can be an Amazon CloudFront distribution, Elastic Load Balancing load balancer, Global
    /// Accelerator accelerator, Elastic IP Address, or an Amazon Route 53 hosted zone.
    /// 
    ///  
    /// <para>
    /// You can add protection to only a single resource with each CreateProtection request.
    /// If you want to add protection to multiple resources at once, use the <a href="https://console.aws.amazon.com/waf/">WAF
    /// console</a>. For more information see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/getting-started-ddos.html">Getting
    /// Started with Shield Advanced</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/configure-new-protection.html">Add
    /// Shield Advanced Protection to more Amazon Web Services Resources</a>.
    /// </para>
    /// </summary>
    public partial class CreateProtectionRequest : AmazonShieldRequest
    {
        private string _name;
        private string _resourceArn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Friendly name for the <code>Protection</code> you are creating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the resource to be protected.
        /// </para>
        ///  
        /// <para>
        /// The ARN should be in one of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For an Application Load Balancer: <code>arn:aws:elasticloadbalancing:<i>region</i>:<i>account-id</i>:loadbalancer/app/<i>load-balancer-name</i>/<i>load-balancer-id</i>
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Elastic Load Balancer (Classic Load Balancer): <code>arn:aws:elasticloadbalancing:<i>region</i>:<i>account-id</i>:loadbalancer/<i>load-balancer-name</i>
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Amazon CloudFront distribution: <code>arn:aws:cloudfront::<i>account-id</i>:distribution/<i>distribution-id</i>
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Global Accelerator accelerator: <code>arn:aws:globalaccelerator::<i>account-id</i>:accelerator/<i>accelerator-id</i>
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Route 53: <code>arn:aws:route53:::hostedzone/<i>hosted-zone-id</i> </code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Elastic IP address: <code>arn:aws:ec2:<i>region</i>:<i>account-id</i>:eip-allocation/<i>allocation-id</i>
        /// </code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tag key-value pairs for the <a>Protection</a> object that is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}