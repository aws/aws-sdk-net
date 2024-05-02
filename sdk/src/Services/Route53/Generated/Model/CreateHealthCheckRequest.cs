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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHealthCheck operation.
    /// Creates a new health check.
    /// 
    ///  
    /// <para>
    /// For information about adding health checks to resource record sets, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ResourceRecordSet.html#Route53-Type-ResourceRecordSet-HealthCheckId">HealthCheckId</a>
    /// in <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ChangeResourceRecordSets.html">ChangeResourceRecordSets</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>ELB Load Balancers</b> 
    /// </para>
    ///  
    /// <para>
    /// If you're registering EC2 instances with an Elastic Load Balancing (ELB) load balancer,
    /// do not create Amazon Route 53 health checks for the EC2 instances. When you register
    /// an EC2 instance with a load balancer, you configure settings for an ELB health check,
    /// which performs a similar function to a Route 53 health check.
    /// </para>
    ///  
    /// <para>
    ///  <b>Private Hosted Zones</b> 
    /// </para>
    ///  
    /// <para>
    /// You can associate health checks with failover resource record sets in a private hosted
    /// zone. Note the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Route 53 health checkers are outside the VPC. To check the health of an endpoint within
    /// a VPC by IP address, you must assign a public IP address to the instance in the VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can configure a health checker to check the health of an external resource that
    /// the instance relies on, such as a database server.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can create a CloudWatch metric, associate an alarm with the metric, and then create
    /// a health check that is based on the state of the alarm. For example, you might create
    /// a CloudWatch metric that checks the status of the Amazon EC2 <c>StatusCheckFailed</c>
    /// metric, add an alarm to the metric, and then create a health check that is based on
    /// the state of the alarm. For information about creating CloudWatch metrics and alarms
    /// by using the CloudWatch console, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/WhatIsCloudWatch.html">Amazon
    /// CloudWatch User Guide</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateHealthCheckRequest : AmazonRoute53Request
    {
        private string _callerReference;
        private HealthCheckConfig _healthCheckConfig;

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique string that identifies the request and that allows you to retry a failed
        /// <c>CreateHealthCheck</c> request without the risk of creating two identical health
        /// checks:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you send a <c>CreateHealthCheck</c> request with the same <c>CallerReference</c>
        /// and settings as a previous request, and if the health check doesn't exist, Amazon
        /// Route 53 creates the health check. If the health check does exist, Route 53 returns
        /// the settings for the existing health check.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you send a <c>CreateHealthCheck</c> request with the same <c>CallerReference</c>
        /// as a deleted health check, regardless of the settings, Route 53 returns a <c>HealthCheckAlreadyExists</c>
        /// error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you send a <c>CreateHealthCheck</c> request with the same <c>CallerReference</c>
        /// as an existing health check but with different settings, Route 53 returns a <c>HealthCheckAlreadyExists</c>
        /// error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you send a <c>CreateHealthCheck</c> request with a unique <c>CallerReference</c>
        /// but settings identical to an existing health check, Route 53 creates the health check.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Route 53 does not store the <c>CallerReference</c> for a deleted health check indefinitely.
        /// The <c>CallerReference</c> for a deleted health check will be deleted after a number
        /// of days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckConfig. 
        /// <para>
        /// A complex type that contains settings for a new health check.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HealthCheckConfig HealthCheckConfig
        {
            get { return this._healthCheckConfig; }
            set { this._healthCheckConfig = value; }
        }

        // Check to see if HealthCheckConfig property is set
        internal bool IsSetHealthCheckConfig()
        {
            return this._healthCheckConfig != null;
        }

    }
}