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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
    /// This is the response object from the ListHostedZones operation.
    /// </summary>
    public partial class ListHostedZonesResponse : AmazonWebServiceResponse
    {
        private List<HostedZone> _hostedZones = AWSConfigs.InitializeCollections ? new List<HostedZone>() : null;
        private string _marker;
        private bool? _isTruncated;
        private string _nextMarker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property HostedZones. 
        /// <para>
        /// A complex type that contains general information about the hosted zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<HostedZone> HostedZones
        {
            get { return this._hostedZones; }
            set { this._hostedZones = value; }
        }

        // Check to see if HostedZones property is set
        internal bool IsSetHostedZones()
        {
            return this._hostedZones != null && (this._hostedZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// For the second and subsequent calls to <c>ListHostedZones</c>, <c>Marker</c> is the
        /// value that you specified for the <c>marker</c> parameter in the request that produced
        /// the current response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag indicating whether there are more hosted zones to be listed. If the response
        /// was truncated, you can get more hosted zones by submitting another <c>ListHostedZones</c>
        /// request and specifying the value of <c>NextMarker</c> in the <c>marker</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsTruncated
        {
            get { return this._isTruncated; }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If <c>IsTruncated</c> is <c>true</c>, the value of <c>NextMarker</c> identifies the
        /// first hosted zone in the next group of hosted zones. Submit another <c>ListHostedZones</c>
        /// request, and specify the value of <c>NextMarker</c> from the response in the <c>marker</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// This element is present only if <c>IsTruncated</c> is <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you specified for the <c>maxitems</c> parameter in the call to <c>ListHostedZones</c>
        /// that produced the current response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

    }
}