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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Contains the output from the DescribeReservedNodeOfferings action. </para>
    /// </summary>
    public class DescribeReservedNodeOfferingsResult
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

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public DescribeReservedNodeOfferingsResult WithMarker(string marker)
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
        /// A list of reserved node offerings.
        ///  
        /// </summary>
        public List<ReservedNodeOffering> ReservedNodeOfferings
        {
            get { return this.reservedNodeOfferings; }
            set { this.reservedNodeOfferings = value; }
        }
        /// <summary>
        /// Adds elements to the ReservedNodeOfferings collection
        /// </summary>
        /// <param name="reservedNodeOfferings">The values to add to the ReservedNodeOfferings collection </param>
        /// <returns>this instance</returns>
        public DescribeReservedNodeOfferingsResult WithReservedNodeOfferings(params ReservedNodeOffering[] reservedNodeOfferings)
        {
            foreach (ReservedNodeOffering element in reservedNodeOfferings)
            {
                this.reservedNodeOfferings.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ReservedNodeOfferings collection
        /// </summary>
        /// <param name="reservedNodeOfferings">The values to add to the ReservedNodeOfferings collection </param>
        /// <returns>this instance</returns>
        public DescribeReservedNodeOfferingsResult WithReservedNodeOfferings(IEnumerable<ReservedNodeOffering> reservedNodeOfferings)
        {
            foreach (ReservedNodeOffering element in reservedNodeOfferings)
            {
                this.reservedNodeOfferings.Add(element);
            }

            return this;
        }

        // Check to see if ReservedNodeOfferings property is set
        internal bool IsSetReservedNodeOfferings()
        {
            return this.reservedNodeOfferings.Count > 0;
        }
    }
}
