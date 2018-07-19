/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the GetReservedNodeExchangeOfferings operation.
    /// </summary>
    public partial class GetReservedNodeExchangeOfferingsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<ReservedNodeOffering> _reservedNodeOfferings = new List<ReservedNodeOffering>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional parameter that specifies the starting point for returning a set of response
        /// records. When the results of a <code>GetReservedNodeExchangeOfferings</code> request
        /// exceed the value specified in MaxRecords, Amazon Redshift returns a value in the marker
        /// field of the response. You can retrieve the next set of response records by providing
        /// the returned marker value in the marker parameter and retrying the request. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ReservedNodeOfferings. 
        /// <para>
        /// Returns an array of <a>ReservedNodeOffering</a> objects.
        /// </para>
        /// </summary>
        public List<ReservedNodeOffering> ReservedNodeOfferings
        {
            get { return this._reservedNodeOfferings; }
            set { this._reservedNodeOfferings = value; }
        }

        // Check to see if ReservedNodeOfferings property is set
        internal bool IsSetReservedNodeOfferings()
        {
            return this._reservedNodeOfferings != null && this._reservedNodeOfferings.Count > 0; 
        }

    }
}