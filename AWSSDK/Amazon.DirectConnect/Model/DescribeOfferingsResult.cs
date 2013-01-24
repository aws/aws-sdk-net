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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para> A structure containing a list of offerings. </para>
    /// </summary>
    public class DescribeOfferingsResult  
    {
        
        private List<Offering> offerings = new List<Offering>();

        /// <summary>
        /// A list of offerings.
        ///  
        /// </summary>
        public List<Offering> Offerings
        {
            get { return this.offerings; }
            set { this.offerings = value; }
        }
        /// <summary>
        /// Adds elements to the Offerings collection
        /// </summary>
        /// <param name="offerings">The values to add to the Offerings collection </param>
        /// <returns>this instance</returns>
        public DescribeOfferingsResult WithOfferings(params Offering[] offerings)
        {
            foreach (Offering element in offerings)
            {
                this.offerings.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Offerings collection
        /// </summary>
        /// <param name="offerings">The values to add to the Offerings collection </param>
        /// <returns>this instance</returns>
        public DescribeOfferingsResult WithOfferings(IEnumerable<Offering> offerings)
        {
            foreach (Offering element in offerings)
            {
                this.offerings.Add(element);
            }

            return this;
        }

        // Check to see if Offerings property is set
        internal bool IsSetOfferings()
        {
            return this.offerings.Count > 0;       
        }
    }
}
