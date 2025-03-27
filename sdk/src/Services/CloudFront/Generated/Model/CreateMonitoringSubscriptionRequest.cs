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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMonitoringSubscription operation.
    /// Enables or disables additional Amazon CloudWatch metrics for the specified CloudFront
    /// distribution. The additional metrics incur an additional cost.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/viewing-cloudfront-metrics.html#monitoring-console.distributions-additional">Viewing
    /// additional CloudFront distribution metrics</a> in the <i>Amazon CloudFront Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateMonitoringSubscriptionRequest : AmazonCloudFrontRequest
    {
        private string _distributionId;
        private MonitoringSubscription _monitoringSubscription;

        /// <summary>
        /// Gets and sets the property DistributionId. 
        /// <para>
        /// The ID of the distribution that you are enabling metrics for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DistributionId
        {
            get { return this._distributionId; }
            set { this._distributionId = value; }
        }

        // Check to see if DistributionId property is set
        internal bool IsSetDistributionId()
        {
            return this._distributionId != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringSubscription. 
        /// <para>
        /// A monitoring subscription. This structure contains information about whether additional
        /// CloudWatch metrics are enabled for a given CloudFront distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringSubscription MonitoringSubscription
        {
            get { return this._monitoringSubscription; }
            set { this._monitoringSubscription = value; }
        }

        // Check to see if MonitoringSubscription property is set
        internal bool IsSetMonitoringSubscription()
        {
            return this._monitoringSubscription != null;
        }

    }
}