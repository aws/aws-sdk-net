/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListHostedZones operation. Retrieves a list of
    /// the public and private hosted zones that are associated with the current Amazon Web
    /// Services account. The response includes a <c>HostedZones</c> child element for each
    /// hosted zone. <para> Amazon Route 53 returns a maximum of 100 items in each response.
    /// If you have a lot of hosted zones, you can use the <c>maxitems</c> parameter to list
    /// them in groups of up to 100. </para>
    /// </summary>
    public partial class ListHostedZonesRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ListHostedZonesRequest() { }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If the value of <c>IsTruncated</c> in the previous response was <c>true</c>, you have
        /// more hosted zones. To get more hosted zones, submit another <c>ListHostedZones</c>
        /// request. 
        /// </para>
        ///  
        /// <para>
        /// For the value of <c>marker</c>, specify the value of <c>NextMarker</c> from the previous
        /// response, which is the ID of the first hosted zone that Amazon Route 53 will return
        /// if you submit another request.
        /// </para>
        ///  
        /// <para>
        /// If the value of <c>IsTruncated</c> in the previous response was <c>false</c>, there
        /// are no more hosted zones to get.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// (Optional) The maximum number of hosted zones that you want Amazon Route 53 to return.
        /// If you have more than <c>maxitems</c> hosted zones, the value of <c>IsTruncated</c>
        /// in the response is <c>true</c>, and the value of <c>NextMarker</c> is the hosted zone
        /// ID of the first hosted zone that Route 53 will return if you submit another request.
        /// </para>
        /// </summary>
        public string MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems != null;

        /// <summary>
        /// Gets and sets the property DelegationSetId. 
        /// <para>
        /// If you're using reusable delegation sets and you want to list all of the hosted zones
        /// that are associated with a reusable delegation set, specify the ID of that reusable
        /// delegation set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string DelegationSetId { get; set; }

        /// <summary>
        /// Checks to see if the DelegationSetId property is set.
        /// </summary>
        internal bool IsSetDelegationSetId() => this.DelegationSetId != null;

        /// <summary>
        /// Gets and sets the property HostedZoneType. 
        /// <para>
        ///  (Optional) Specifies if the hosted zone is private. 
        /// </para>
        /// </summary>
        public HostedZoneType HostedZoneType { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneType property is set.
        /// </summary>
        internal bool IsSetHostedZoneType() => this.HostedZoneType != null;
    }
}
