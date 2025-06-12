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
    /// A complex type that contains list information for the resource record set.
    /// </summary>
    public partial class ListResourceRecordSetsResponse : AmazonWebServiceResponse
    {
        private List<ResourceRecordSet> _resourceRecordSets = AWSConfigs.InitializeCollections ? new List<ResourceRecordSet>() : null;
        private bool? _isTruncated;
        private string _nextRecordName;
        private RRType _nextRecordType;
        private string _nextRecordIdentifier;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property ResourceRecordSets. 
        /// <para>
        /// Information about multiple resource record sets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResourceRecordSet> ResourceRecordSets
        {
            get { return this._resourceRecordSets; }
            set { this._resourceRecordSets = value; }
        }

        // Check to see if ResourceRecordSets property is set
        internal bool IsSetResourceRecordSets()
        {
            return this._resourceRecordSets != null && (this._resourceRecordSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether more resource record sets remain to be listed. If your
        /// results were truncated, you can make a follow-up pagination request by using the <c>NextRecordName</c>
        /// element.
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
        /// Gets and sets the property NextRecordName. 
        /// <para>
        /// If the results were truncated, the name of the next record in the list.
        /// </para>
        ///  
        /// <para>
        /// This element is present only if <c>IsTruncated</c> is true. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string NextRecordName
        {
            get { return this._nextRecordName; }
            set { this._nextRecordName = value; }
        }

        // Check to see if NextRecordName property is set
        internal bool IsSetNextRecordName()
        {
            return this._nextRecordName != null;
        }

        /// <summary>
        /// Gets and sets the property NextRecordType. 
        /// <para>
        /// If the results were truncated, the type of the next record in the list.
        /// </para>
        ///  
        /// <para>
        /// This element is present only if <c>IsTruncated</c> is true. 
        /// </para>
        /// </summary>
        public RRType NextRecordType
        {
            get { return this._nextRecordType; }
            set { this._nextRecordType = value; }
        }

        // Check to see if NextRecordType property is set
        internal bool IsSetNextRecordType()
        {
            return this._nextRecordType != null;
        }

        /// <summary>
        /// Gets and sets the property NextRecordIdentifier. 
        /// <para>
        ///  <i>Resource record sets that have a routing policy other than simple:</i> If results
        /// were truncated for a given DNS name and type, the value of <c>SetIdentifier</c> for
        /// the next resource record set that has the current DNS name and type.
        /// </para>
        ///  
        /// <para>
        /// For information about routing policies, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html">Choosing
        /// a Routing Policy</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string NextRecordIdentifier
        {
            get { return this._nextRecordIdentifier; }
            set { this._nextRecordIdentifier = value; }
        }

        // Check to see if NextRecordIdentifier property is set
        internal bool IsSetNextRecordIdentifier()
        {
            return this._nextRecordIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of records you requested.
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