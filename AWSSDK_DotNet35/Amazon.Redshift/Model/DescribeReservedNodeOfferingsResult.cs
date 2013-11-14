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
using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Contains the output from the DescribeReservedNodeOfferings action. </para>
    /// </summary>
    public partial class DescribeReservedNodeOfferingsResult : AmazonWebServiceResponse
    {
        
        private string marker;
        private List<ReservedNodeOffering> reservedNodeOfferings = new List<ReservedNodeOffering>();


        /// <summary>
        /// An optional marker returned by a previous <a>DescribeReservedNodeOfferings</a> request to indicate the first reserved node offering that the
        /// request will return.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of reserved node offerings.
        ///  
        /// </summary>
        public List<ReservedNodeOffering> ReservedNodeOfferings
        {
            get { return this.reservedNodeOfferings; }
            set { this.reservedNodeOfferings = value; }
        }

        // Check to see if ReservedNodeOfferings property is set
        internal bool IsSetReservedNodeOfferings()
        {
            return this.reservedNodeOfferings.Count > 0;
        }
    }
}
