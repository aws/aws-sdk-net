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
    /// <para>A complex type that contains information about the current resource record set.</para>
    /// </summary>
    public class ResourceRecordSet
    {
        
        private string name;
        private RRType type;
        private string setIdentifier;
        private long? weight;
        private ResourceRecordSetRegion region;
        private ResourceRecordSetFailover failover;
        private long? tTL;
        private List<ResourceRecord> resourceRecords = new List<ResourceRecord>();
        private AliasTarget aliasTarget;
        private string healthCheckId;

        /// <summary>
        /// The domain name of the current resource record set.
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

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The type of the current resource record set.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>SOA, A, TXT, NS, CNAME, MX, PTR, SRV, SPF, AAAA</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public RRType Type
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
        /// <i>Weighted, Regional, and Failover resource record sets only:</i> An identifier that differentiates among multiple resource record sets
        /// that have the same combination of DNS name and type.
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
        public string SetIdentifier
        {
            get { return this.setIdentifier; }
            set { this.setIdentifier = value; }
        }

        // Check to see if SetIdentifier property is set
        internal bool IsSetSetIdentifier()
        {
            return this.setIdentifier != null;
        }

        /// <summary>
        /// <i>Weighted resource record sets only:</i> Among resource record sets that have the same combination of DNS name and type, a value that
        /// determines what portion of traffic for the current resource record set is routed to the associated location.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public long Weight
        {
            get { return this.weight ?? default(long); }
            set { this.weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this.weight.HasValue;
        }

        /// <summary>
        /// <i>Regional resource record sets only:</i> Among resource record sets that have the same combination of DNS name and type, a value that
        /// specifies the AWS region for the current resource record set.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>us-east-1, us-west-1, us-west-2, eu-west-1, ap-southeast-1, ap-southeast-2, ap-northeast-1, sa-east-1</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ResourceRecordSetRegion Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;
        }

        /// <summary>
        /// <i>Failover resource record sets only:</i> Among resource record sets that have the same combination of DNS name and type, a value that
        /// indicates whether the current resource record set is a primary or secondary resource record set. A failover set may contain at most one
        /// resource record set marked as primary and one resource record set marked as secondary. A resource record set marked as primary will be
        /// returned if any of the following are true: (1) an associated health check is passing, (2) if the resource record set is an alias with the
        /// evaluate target health and at least one target resource record set is healthy, (3) both the primary and secondary resource record set are
        /// failing health checks or (4) there is no secondary resource record set. A secondary resource record set will be returned if: (1) the primary
        /// is failing a health check and either the secondary is passing a health check or has no associated health check, or (2) there is no primary
        /// resource record set. Valid values: <c>PRIMARY</c> | <c>SECONDARY</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>PRIMARY, SECONDARY</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ResourceRecordSetFailover Failover
        {
            get { return this.failover; }
            set { this.failover = value; }
        }

        // Check to see if Failover property is set
        internal bool IsSetFailover()
        {
            return this.failover != null;
        }

        /// <summary>
        /// The cache time to live for the current resource record set.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 2147483647</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public long TTL
        {
            get { return this.tTL ?? default(long); }
            set { this.tTL = value; }
        }

        // Check to see if TTL property is set
        internal bool IsSetTTL()
        {
            return this.tTL.HasValue;
        }

        /// <summary>
        /// A complex type that contains the resource records for the current resource record set.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<ResourceRecord> ResourceRecords
        {
            get { return this.resourceRecords; }
            set { this.resourceRecords = value; }
        }

        // Check to see if ResourceRecords property is set
        internal bool IsSetResourceRecords()
        {
            return this.resourceRecords.Count > 0;
        }

        /// <summary>
        /// <i>Alias resource record sets only:</i> Information about the AWS resource to which you are redirecting traffic.
        ///  
        /// </summary>
        public AliasTarget AliasTarget
        {
            get { return this.aliasTarget; }
            set { this.aliasTarget = value; }
        }

        // Check to see if AliasTarget property is set
        internal bool IsSetAliasTarget()
        {
            return this.aliasTarget != null;
        }

        /// <summary>
        /// <i>Health Check resource record sets only, not required for alias resource record sets:</i> An identifier that is used to identify health
        /// check associated with the resource record set.
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
        public string HealthCheckId
        {
            get { return this.healthCheckId; }
            set { this.healthCheckId = value; }
        }

        // Check to see if HealthCheckId property is set
        internal bool IsSetHealthCheckId()
        {
            return this.healthCheckId != null;
        }
    }
}
