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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetHostReservationPurchasePreview operation.
    /// Preview a reservation purchase with configurations that match those of your Dedicated
    /// Host. You must have active Dedicated Hosts in your account before you purchase a reservation.
    /// 
    ///  
    /// <para>
    /// This is a preview of the <a>PurchaseHostReservation</a> action and does not result
    /// in the offering being purchased.
    /// </para>
    /// </summary>
    public partial class GetHostReservationPurchasePreviewRequest : AmazonEC2Request
    {
        private List<string> _hostIdSet = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _offeringId;

        /// <summary>
        /// Gets and sets the property HostIdSet. 
        /// <para>
        /// The IDs of the Dedicated Hosts with which the reservation is associated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> HostIdSet
        {
            get { return this._hostIdSet; }
            set { this._hostIdSet = value; }
        }

        // Check to see if HostIdSet property is set
        internal bool IsSetHostIdSet()
        {
            return this._hostIdSet != null && (this._hostIdSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The offering ID of the reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OfferingId
        {
            get { return this._offeringId; }
            set { this._offeringId = value; }
        }

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this._offeringId != null;
        }

    }
}