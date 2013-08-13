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
    /// <para>A complex type that contain information about the specified hosted zone.</para>
    /// </summary>
    public class HostedZone
    {
        
        private string id;
        private string name;
        private string callerReference;
        private HostedZoneConfig config;
        private long? resourceRecordSetCount;

        /// <summary>
        /// The ID of the specified hosted zone.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32</description>
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
        public HostedZone WithId(string id)
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
        /// The name of the domain. This must be a fully-specified domain, for example, www.example.com. The trailing dot is optional; Route 53 assumes
        /// that the domain name is fully qualified. This means that Route 53 treats www.example.com (without a trailing dot) and www.example.com. (with
        /// a trailing dot) as identical. This is the name you have registered with your DNS registrar. You should ask your registrar to change the
        /// authoritative name servers for your domain to the set of <c>NameServers</c> elements returned in <c>DelegationSet</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HostedZone WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// A unique string that identifies the request to create the hosted zone.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
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
        public HostedZone WithCallerReference(string callerReference)
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
        /// A complex type that contains the <c>Comment</c> element.
        ///  
        /// </summary>
        public HostedZoneConfig Config
        {
            get { return this.config; }
            set { this.config = value; }
        }

        /// <summary>
        /// Sets the Config property
        /// </summary>
        /// <param name="config">The value to set for the Config property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HostedZone WithConfig(HostedZoneConfig config)
        {
            this.config = config;
            return this;
        }
            

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this.config != null;
        }

        /// <summary>
        /// Total number of resource record sets in the hosted zone.
        ///  
        /// </summary>
        public long ResourceRecordSetCount
        {
            get { return this.resourceRecordSetCount ?? default(long); }
            set { this.resourceRecordSetCount = value; }
        }

        /// <summary>
        /// Sets the ResourceRecordSetCount property
        /// </summary>
        /// <param name="resourceRecordSetCount">The value to set for the ResourceRecordSetCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HostedZone WithResourceRecordSetCount(long resourceRecordSetCount)
        {
            this.resourceRecordSetCount = resourceRecordSetCount;
            return this;
        }
            

        // Check to see if ResourceRecordSetCount property is set
        internal bool IsSetResourceRecordSetCount()
        {
            return this.resourceRecordSetCount.HasValue;
        }
    }
}
