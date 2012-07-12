/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        private string type;
        private string setIdentifier;
        private long? weight;
        private string region;
        private long? tTL;
        private List<ResourceRecord> resourceRecords = new List<ResourceRecord>();
        private AliasTarget aliasTarget;

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

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public ResourceRecordSet WithName(string name)
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
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        public ResourceRecordSet WithType(string type)
        {
            this.type = type;
            return this;
        }
            

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;       
        }

        /// <summary>
        /// <i>Weighted resource record sets or Regional resource record sets only:</i> An identifier that differentiates among multiple resource record
        /// sets that have the same combination of DNS name and type.
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

        /// <summary>
        /// Sets the SetIdentifier property
        /// </summary>
        /// <param name="setIdentifier">The value to set for the SetIdentifier property </param>
        /// <returns>this instance</returns>
        public ResourceRecordSet WithSetIdentifier(string setIdentifier)
        {
            this.setIdentifier = setIdentifier;
            return this;
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

        /// <summary>
        /// Sets the Weight property
        /// </summary>
        /// <param name="weight">The value to set for the Weight property </param>
        /// <returns>this instance</returns>
        public ResourceRecordSet WithWeight(long weight)
        {
            this.weight = weight;
            return this;
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
        ///         <description>us-east-1, us-west-1, us-west-2, eu-west-1, ap-southeast-1, ap-northeast-1, sa-east-1</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        /// <summary>
        /// Sets the Region property
        /// </summary>
        /// <param name="region">The value to set for the Region property </param>
        /// <returns>this instance</returns>
        public ResourceRecordSet WithRegion(string region)
        {
            this.region = region;
            return this;
        }
            

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;       
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

        /// <summary>
        /// Sets the TTL property
        /// </summary>
        /// <param name="tTL">The value to set for the TTL property </param>
        /// <returns>this instance</returns>
        public ResourceRecordSet WithTTL(long tTL)
        {
            this.tTL = tTL;
            return this;
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
        /// <summary>
        /// Adds elements to the ResourceRecords collection
        /// </summary>
        /// <param name="resourceRecords">The values to add to the ResourceRecords collection </param>
        /// <returns>this instance</returns>
        public ResourceRecordSet WithResourceRecords(params ResourceRecord[] resourceRecords)
        {
            foreach (ResourceRecord element in resourceRecords)
            {
                this.resourceRecords.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ResourceRecords collection
        /// </summary>
        /// <param name="resourceRecords">The values to add to the ResourceRecords collection </param>
        /// <returns>this instance</returns>
        public ResourceRecordSet WithResourceRecords(IEnumerable<ResourceRecord> resourceRecords)
        {
            foreach (ResourceRecord element in resourceRecords)
            {
                this.resourceRecords.Add(element);
            }

            return this;
        }

        // Check to see if ResourceRecords property is set
        internal bool IsSetResourceRecords()
        {
            return this.resourceRecords.Count > 0;       
        }

        /// <summary>
        /// <i>Alias resource record sets only:</i> Information about the Elastic Load Balancing LoadBalancer to which you are redirecting traffic.
        ///  
        /// </summary>
        public AliasTarget AliasTarget
        {
            get { return this.aliasTarget; }
            set { this.aliasTarget = value; }
        }

        /// <summary>
        /// Sets the AliasTarget property
        /// </summary>
        /// <param name="aliasTarget">The value to set for the AliasTarget property </param>
        /// <returns>this instance</returns>
        public ResourceRecordSet WithAliasTarget(AliasTarget aliasTarget)
        {
            this.aliasTarget = aliasTarget;
            return this;
        }
            

        // Check to see if AliasTarget property is set
        internal bool IsSetAliasTarget()
        {
            return this.aliasTarget != null;       
        }
    }
}
