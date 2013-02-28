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
    /// <para>A complex type that contains information about the resource record sets that are returned by the request and information about the
    /// response.</para>
    /// </summary>
    public class ListResourceRecordSetsResult
    {
        
        private List<ResourceRecordSet> resourceRecordSets = new List<ResourceRecordSet>();
        private bool? isTruncated;
        private string nextRecordName;
        private string nextRecordType;
        private string nextRecordIdentifier;
        private string maxItems;

        /// <summary>
        /// A complex type that contains information about the resource record sets that are returned by the request.
        ///  
        /// </summary>
        public List<ResourceRecordSet> ResourceRecordSets
        {
            get { return this.resourceRecordSets; }
            set { this.resourceRecordSets = value; }
        }
        /// <summary>
        /// Adds elements to the ResourceRecordSets collection
        /// </summary>
        /// <param name="resourceRecordSets">The values to add to the ResourceRecordSets collection </param>
        /// <returns>this instance</returns>
        public ListResourceRecordSetsResult WithResourceRecordSets(params ResourceRecordSet[] resourceRecordSets)
        {
            foreach (ResourceRecordSet element in resourceRecordSets)
            {
                this.resourceRecordSets.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ResourceRecordSets collection
        /// </summary>
        /// <param name="resourceRecordSets">The values to add to the ResourceRecordSets collection </param>
        /// <returns>this instance</returns>
        public ListResourceRecordSetsResult WithResourceRecordSets(IEnumerable<ResourceRecordSet> resourceRecordSets)
        {
            foreach (ResourceRecordSet element in resourceRecordSets)
            {
                this.resourceRecordSets.Add(element);
            }

            return this;
        }

        // Check to see if ResourceRecordSets property is set
        internal bool IsSetResourceRecordSets()
        {
            return this.resourceRecordSets.Count > 0;
        }

        /// <summary>
        /// A flag that indicates whether there are more resource record sets to be listed. If your results were truncated, you can make a follow-up
        /// request for the next page of results by using the <a>ListResourceRecordSetsResponse$NextRecordName</a> element. Valid Values: <c>true</c> |
        /// <c>false</c>
        ///  
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated ?? default(bool); }
            set { this.isTruncated = value; }
        }

        /// <summary>
        /// Sets the IsTruncated property
        /// </summary>
        /// <param name="isTruncated">The value to set for the IsTruncated property </param>
        /// <returns>this instance</returns>
        public ListResourceRecordSetsResult WithIsTruncated(bool isTruncated)
        {
            this.isTruncated = isTruncated;
            return this;
        }
            

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;
        }

        /// <summary>
        /// If the results were truncated, the name of the next record in the list. This element is present only if
        /// <a>ListResourceRecordSetsResponse$IsTruncated</a> is true.
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
        public string NextRecordName
        {
            get { return this.nextRecordName; }
            set { this.nextRecordName = value; }
        }

        /// <summary>
        /// Sets the NextRecordName property
        /// </summary>
        /// <param name="nextRecordName">The value to set for the NextRecordName property </param>
        /// <returns>this instance</returns>
        public ListResourceRecordSetsResult WithNextRecordName(string nextRecordName)
        {
            this.nextRecordName = nextRecordName;
            return this;
        }
            

        // Check to see if NextRecordName property is set
        internal bool IsSetNextRecordName()
        {
            return this.nextRecordName != null;
        }

        /// <summary>
        /// If the results were truncated, the type of the next record in the list. This element is present only if
        /// <a>ListResourceRecordSetsResponse$IsTruncated</a> is true.
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
        public string NextRecordType
        {
            get { return this.nextRecordType; }
            set { this.nextRecordType = value; }
        }

        /// <summary>
        /// Sets the NextRecordType property
        /// </summary>
        /// <param name="nextRecordType">The value to set for the NextRecordType property </param>
        /// <returns>this instance</returns>
        public ListResourceRecordSetsResult WithNextRecordType(string nextRecordType)
        {
            this.nextRecordType = nextRecordType;
            return this;
        }
            

        // Check to see if NextRecordType property is set
        internal bool IsSetNextRecordType()
        {
            return this.nextRecordType != null;
        }

        /// <summary>
        /// <i>Weighted resource record sets only:</i> If results were truncated for a given DNS name and type, the value of <c>SetIdentifier</c> for
        /// the next resource record set that has the current DNS name and type.
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
        public string NextRecordIdentifier
        {
            get { return this.nextRecordIdentifier; }
            set { this.nextRecordIdentifier = value; }
        }

        /// <summary>
        /// Sets the NextRecordIdentifier property
        /// </summary>
        /// <param name="nextRecordIdentifier">The value to set for the NextRecordIdentifier property </param>
        /// <returns>this instance</returns>
        public ListResourceRecordSetsResult WithNextRecordIdentifier(string nextRecordIdentifier)
        {
            this.nextRecordIdentifier = nextRecordIdentifier;
            return this;
        }
            

        // Check to see if NextRecordIdentifier property is set
        internal bool IsSetNextRecordIdentifier()
        {
            return this.nextRecordIdentifier != null;
        }

        /// <summary>
        /// The maximum number of records you requested. The maximum value of <c>MaxItems</c> is 100.
        ///  
        /// </summary>
        public string MaxItems
        {
            get { return this.maxItems; }
            set { this.maxItems = value; }
        }

        /// <summary>
        /// Sets the MaxItems property
        /// </summary>
        /// <param name="maxItems">The value to set for the MaxItems property </param>
        /// <returns>this instance</returns>
        public ListResourceRecordSetsResult WithMaxItems(string maxItems)
        {
            this.maxItems = maxItems;
            return this;
        }
            

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this.maxItems != null;
        }
    }
}
