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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para>A complex type that contains identifying information about the health check.</para>
    /// </summary>
    public class HealthCheck
    {
        
        private string id;
        private string callerReference;
        private HealthCheckConfig healthCheckConfig;

        /// <summary>
        /// The ID of the specified health check.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HealthCheck WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// A unique string that identifies the request to create the health check.
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
        public HealthCheck WithCallerReference(string callerReference)
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
        /// A complex type that contains the health check configuration.
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
        public HealthCheck WithHealthCheckConfig(HealthCheckConfig healthCheckConfig)
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
