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
    /// This is the response object from the CreateMonitoringSubscription operation.
    /// </summary>
    public partial class CreateMonitoringSubscriptionResponse : AmazonWebServiceResponse
    {
        private MonitoringSubscription _monitoringSubscription;

        /// <summary>
        /// Gets and sets the property MonitoringSubscription. 
        /// <para>
        /// A monitoring subscription. This structure contains information about whether additional
        /// CloudWatch metrics are enabled for a given CloudFront distribution.
        /// </para>
        /// </summary>
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