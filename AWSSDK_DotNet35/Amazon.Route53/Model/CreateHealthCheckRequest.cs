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
    /// This action creates a new health check.
    /// 
    ///  
    /// <para>
    ///  To create a new health check, send a <code>POST</code> request to the <code>2013-04-01/healthcheck</code>
    /// resource. The request body must include an XML document with a <code>CreateHealthCheckRequest</code>
    /// element. The response returns the <code>CreateHealthCheckResponse</code> element that
    /// contains metadata about the health check.
    /// </para>
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
        /// <code>CallerReference</code> can be any unique string; you might choose to use a string
        /// that identifies your project.
        /// </para>
        ///  
        /// <para>
        /// Valid characters are any Unicode code points that are legal in an XML 1.0 document.
        /// The UTF-8 encoding of the value must be less than 128 bytes.
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
        /// A complex type that contains health check configuration.
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