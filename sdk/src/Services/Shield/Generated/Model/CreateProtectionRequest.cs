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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProtection operation.
    /// Enables Shield Advanced for a specific Amazon Web Services resource. The resource
    /// can be an Amazon CloudFront distribution, Amazon Route 53 hosted zone, Global Accelerator
    /// standard accelerator, Elastic IP Address, Application Load Balancer, or a Classic
    /// Load Balancer. You can protect Amazon EC2 instances and Network Load Balancers by
    /// association with protected Amazon EC2 Elastic IP addresses.
    /// 
    ///  
    /// <para>
    /// You can add protection to only a single resource with each <c>CreateProtection</c>
    /// request. You can add protection to multiple resources at once through the Shield Advanced
    /// console at <a href="https://console.aws.amazon.com/wafv2/shieldv2#/">https://console.aws.amazon.com/wafv2/shieldv2#/</a>.
    /// For more information see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/getting-started-ddos.html">Getting
    /// Started with Shield Advanced</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/configure-new-protection.html">Adding
    /// Shield Advanced protection to Amazon Web Services resources</a>.
    /// </para>
    /// </summary>
    public partial class CreateProtectionRequest : AmazonShieldRequest
    {
        private string _name;
        private string _resourceArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Friendly name for the <c>Protection</c> you are creating.
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
        /// For an Application Load Balancer: <c>arn:aws:elasticloadbalancing:<i>region</i>:<i>account-id</i>:loadbalancer/app/<i>load-balancer-name</i>/<i>load-balancer-id</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Elastic Load Balancer (Classic Load Balancer): <c>arn:aws:elasticloadbalancing:<i>region</i>:<i>account-id</i>:loadbalancer/<i>load-balancer-name</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Amazon CloudFront distribution: <c>arn:aws:cloudfront::<i>account-id</i>:distribution/<i>distribution-id</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Global Accelerator standard accelerator: <c>arn:aws:globalaccelerator::<i>account-id</i>:accelerator/<i>accelerator-id</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Route 53: <c>arn:aws:route53:::hostedzone/<i>hosted-zone-id</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Elastic IP address: <c>arn:aws:ec2:<i>region</i>:<i>account-id</i>:eip-allocation/<i>allocation-id</i>
        /// </c> 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}