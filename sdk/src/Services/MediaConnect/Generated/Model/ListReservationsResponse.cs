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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// This is the response object from the ListReservations operation.
    /// </summary>
    public partial class ListReservationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Reservation> _reservations = AWSConfigs.InitializeCollections ? new List<Reservation>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token that identifies the batch of results that you want to see. 
        /// </para>
        ///  
        /// <para>
        /// For example, you submit a <c>ListReservations</c> request with <c>MaxResults</c> set
        /// at 5. The service returns the first batch of results (up to 5) and a <c>NextToken</c>
        /// value. To see the next batch of results, you can submit the <c>ListReservations</c>
        /// request a second time and specify the <c>NextToken</c> value.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Reservations. 
        /// <para>
        ///  A list of all reservations that have been purchased by this account in the current
        /// Amazon Web Services Region. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Reservation> Reservations
        {
            get { return this._reservations; }
            set { this._reservations = value; }
        }

        // Check to see if Reservations property is set
        internal bool IsSetReservations()
        {
            return this._reservations != null && (this._reservations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}