/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHealthCheck operation.
    /// Creates a new health check.
    /// 
    ///  
    /// <para>
    /// To create a new health check, send a <code>POST</code> request to the <code>/2013-04-01/healthcheck</code>
    /// resource. The request body must include an XML document with a <code>CreateHealthCheckRequest</code>
    /// element. The response returns the <code>CreateHealthCheckResponse</code> element,
    /// containing the health check ID specified when adding health check to a resource record
    /// set. For information about adding health checks to resource record sets, see <a>ResourceRecordSet$HealthCheckId</a>
    /// in <a>ChangeResourceRecordSets</a>. 
    /// </para>
    ///  
    /// <para>
    /// If you are registering Amazon EC2 instances with an Elastic Load Balancing (ELB) load
    /// balancer, do not create Amazon Route 53 health checks for the Amazon EC2 instances.
    /// When you register an Amazon EC2 instance with a load balancer, you configure settings
    /// for an ELB health check, which performs a similar function to an Amazon Route 53 health
    /// check.
    /// </para>
    ///  
    /// <para>
    /// You can associate health checks with failover resource record sets in a private hosted
    /// zone. Note the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon Route 53 health checkers are outside the VPC. To check the health of an endpoint
    /// within a VPC by IP address, you must assign a public IP address to the instance in
    /// the VPC.
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
    /// a CloudWatch metric that checks the status of the Amazon EC2 <code>StatusCheckFailed</code>
    /// metric, add an alarm to the metric, and then create a health check that is based on
    /// the state of the alarm. For information about creating CloudWatch metrics and alarms
    /// by using the CloudWatch console, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/WhatIsCloudWatch.html">Amazon
    /// CloudWatch Developer Guide</a>.
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
        /// A unique string that identifies the request and that allows failed <code>CreateHealthCheck</code>
        /// requests to be retried without the risk of executing the operation twice. You must
        /// use a unique <code>CallerReference</code> string every time you create a health check.
        /// </para>
        /// </summary>
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
        /// A complex type that contains the response to a <code>CreateHealthCheck</code> request.
        /// 
        /// </para>
        /// </summary>
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