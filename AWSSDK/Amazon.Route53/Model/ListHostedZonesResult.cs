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
    /// <para> A complex type that contains the response for the request.</para>
    /// </summary>
    public class ListHostedZonesResult
    {
        
        private List<HostedZone> hostedZones = new List<HostedZone>();
        private string marker;
        private bool? isTruncated;
        private string nextMarker;
        private string maxItems;

        /// <summary>
        /// A complex type that contains information about the hosted zones associated with the current AWS account.
        ///  
        /// </summary>
        public List<HostedZone> HostedZones
        {
            get { return this.hostedZones; }
            set { this.hostedZones = value; }
        }
        /// <summary>
        /// Adds elements to the HostedZones collection
        /// </summary>
        /// <param name="hostedZones">The values to add to the HostedZones collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListHostedZonesResult WithHostedZones(params HostedZone[] hostedZones)
        {
            foreach (HostedZone element in hostedZones)
            {
                this.hostedZones.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the HostedZones collection
        /// </summary>
        /// <param name="hostedZones">The values to add to the HostedZones collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListHostedZonesResult WithHostedZones(IEnumerable<HostedZone> hostedZones)
        {
            foreach (HostedZone element in hostedZones)
            {
                this.hostedZones.Add(element);
            }

            return this;
        }

        // Check to see if HostedZones property is set
        internal bool IsSetHostedZones()
        {
            return this.hostedZones.Count > 0;
        }

        /// <summary>
        /// If the request returned more than one page of results, submit another request and specify the value of <c>NextMarker</c> from the last
        /// response in the <c>marker</c> parameter to get the next page of results.
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
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListHostedZonesResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A flag indicating whether there are more hosted zones to be listed. If your results were truncated, you can make a follow-up request for the
        /// next page of results by using the <c>Marker</c> element. Valid Values: <c>true</c> | <c>false</c>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListHostedZonesResult WithIsTruncated(bool isTruncated)
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
        /// Indicates where to continue listing hosted zones. If <a>ListHostedZonesResponse$IsTruncated</a> is <c>true</c>, make another request to
        /// <c>ListHostedZones</c> and include the value of the <c>NextMarker</c> element in the <c>Marker</c> element to get the next page of results.
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
        public string NextMarker
        {
            get { return this.nextMarker; }
            set { this.nextMarker = value; }
        }

        /// <summary>
        /// Sets the NextMarker property
        /// </summary>
        /// <param name="nextMarker">The value to set for the NextMarker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListHostedZonesResult WithNextMarker(string nextMarker)
        {
            this.nextMarker = nextMarker;
            return this;
        }
            

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this.nextMarker != null;
        }

        /// <summary>
        /// The maximum number of hosted zones to be included in the response body. If the number of hosted zones associated with this AWS account
        /// exceeds <c>MaxItems</c>, the value of <a>ListHostedZonesResponse$IsTruncated</a> in the response is <c>true</c>. Call <c>ListHostedZones</c>
        /// again and specify the value of <a>ListHostedZonesResponse$NextMarker</a> in the <a>ListHostedZonesRequest$Marker</a> element to get the next
        /// page of results.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListHostedZonesResult WithMaxItems(string maxItems)
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
