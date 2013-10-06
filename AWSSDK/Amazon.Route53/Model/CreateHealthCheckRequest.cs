/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> This action creates a new health check.</para> <para> To create a new health check, send a <c>POST</c> request to the
    /// <c>2012-12-12/healthcheck</c> resource. The request body must include an XML document with a <c>CreateHealthCheckRequest</c> element. The
    /// response returns the <c>CreateHealthCheckResponse</c> element that contains metadata about the health check.</para>
    /// </summary>
    /// <seealso cref="Amazon.Route53.AmazonRoute53.CreateHealthCheck"/>
    public class CreateHealthCheckRequest : AmazonWebServiceRequest
    {
        private string callerReference;
        private HealthCheckConfig healthCheckConfig;

        /// <summary>
        /// A unique string that identifies the request and that allows failed <c>CreateHealthCheck</c> requests to be retried without the risk of
        /// executing the operation twice. You must use a unique <c>CallerReference</c> string every time you create a health check.
        /// <c>CallerReference</c> can be any unique string; you might choose to use a string that identifies your project. Valid characters are any
        /// Unicode code points that are legal in an XML 1.0 document. The UTF-8 encoding of the value must be less than 128 bytes.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CallerReference
        {
            get { return this.callerReference; }
            set { this.callerReference = value; }
        }

        /// <summary>
        /// Sets the CallerReference property
        /// </summary>
        /// <param name="callerReference">The value to set for the CallerReference property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateHealthCheckRequest WithCallerReference(string callerReference)
        {
            this.callerReference = callerReference;
            return this;
        }
            

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this.callerReference != null;
        }

        /// <summary>
        /// A complex type that contains health check configuration.
        ///  
        /// </summary>
        public HealthCheckConfig HealthCheckConfig
        {
            get { return this.healthCheckConfig; }
            set { this.healthCheckConfig = value; }
        }

        /// <summary>
        /// Sets the HealthCheckConfig property
        /// </summary>
        /// <param name="healthCheckConfig">The value to set for the HealthCheckConfig property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateHealthCheckRequest WithHealthCheckConfig(HealthCheckConfig healthCheckConfig)
        {
            this.healthCheckConfig = healthCheckConfig;
            return this;
        }
            

        // Check to see if HealthCheckConfig property is set
        internal bool IsSetHealthCheckConfig()
        {
            return this.healthCheckConfig != null;
        }
    }
}
    
