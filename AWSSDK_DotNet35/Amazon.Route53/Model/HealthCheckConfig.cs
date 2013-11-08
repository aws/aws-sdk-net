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
    /// <para>A complex type that contains the health check configuration.</para>
    /// </summary>
    public class HealthCheckConfig
    {
        
        private string iPAddress;
        private int? port;
        private HealthCheckType type;
        private string resourcePath;
        private string fullyQualifiedDomainName;

        /// <summary>
        /// IP Address of the instance being checked.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 15</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string IPAddress
        {
            get { return this.iPAddress; }
            set { this.iPAddress = value; }
        }

        // Check to see if IPAddress property is set
        internal bool IsSetIPAddress()
        {
            return this.iPAddress != null;
        }

        /// <summary>
        /// Port on which connection will be opened to the instance to health check. For HTTP this defaults to 80 if the port is not specified.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 65535</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this.port ?? default(int); }
            set { this.port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;
        }

        /// <summary>
        /// The type of health check to be performed. Currently supported protocols are TCP and HTTP.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>HTTP, TCP</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public HealthCheckType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }

        /// <summary>
        /// Path to ping on the instance to check the health. Required only for HTTP health checks, HTTP request is issued to the instance on the given
        /// port and path.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ResourcePath
        {
            get { return this.resourcePath; }
            set { this.resourcePath = value; }
        }

        // Check to see if ResourcePath property is set
        internal bool IsSetResourcePath()
        {
            return this.resourcePath != null;
        }

        /// <summary>
        /// Fully qualified domain name of the instance to be health checked.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string FullyQualifiedDomainName
        {
            get { return this.fullyQualifiedDomainName; }
            set { this.fullyQualifiedDomainName = value; }
        }

        // Check to see if FullyQualifiedDomainName property is set
        internal bool IsSetFullyQualifiedDomainName()
        {
            return this.fullyQualifiedDomainName != null;
        }
    }
}
