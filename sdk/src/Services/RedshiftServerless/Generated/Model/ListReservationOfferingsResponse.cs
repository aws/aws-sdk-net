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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// This is the response object from the ListReservationOfferings operation.
    /// </summary>
    public partial class ListReservationOfferingsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ReservationOffering> _reservationOfferingsList = AWSConfigs.InitializeCollections ? new List<ReservationOffering>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationOfferingsList. 
        /// <para>
        /// The returned list of reservation offerings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ReservationOffering> ReservationOfferingsList
        {
            get { return this._reservationOfferingsList; }
            set { this._reservationOfferingsList = value; }
        }

        // Check to see if ReservationOfferingsList property is set
        internal bool IsSetReservationOfferingsList()
        {
            return this._reservationOfferingsList != null && (this._reservationOfferingsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}