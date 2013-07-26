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
    /// <para> An offer to create a new connection for a specific price and terms. </para>
    /// </summary>
    public class Offering
    {
        
        private string offeringId;
        private string region;
        private string location;
        private string offeringName;
        private string description;
        private string bandwidth;
        private List<ConnectionCost> connectionCosts = new List<ConnectionCost>();

        /// <summary>
        /// The ID of the offering. Example: us-west-1_EqSV5_1G Default: None
        ///  
        /// </summary>
        public string OfferingId
        {
            get { return this.offeringId; }
            set { this.offeringId = value; }
        }

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this.offeringId != null;
        }

        /// <summary>
        /// The AWS region where the offering is located. Example: us-east-1 Default: None
        ///  
        /// </summary>
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;
        }

        /// <summary>
        /// Where the AWS Direct Connect offering is located. Example: EqSV5 Default: None
        ///  
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;
        }

        /// <summary>
        /// Name of the offering. Example: "<i>1Gbps Cross Connect in us-east-1</i>" Default: None
        ///  
        /// </summary>
        public string OfferingName
        {
            get { return this.offeringName; }
            set { this.offeringName = value; }
        }

        // Check to see if OfferingName property is set
        internal bool IsSetOfferingName()
        {
            return this.offeringName != null;
        }

        /// <summary>
        /// Description of the offering. Example: "<i>1Gbps Cross Connect in us-east-1</i>" Default: None
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// Bandwidth of the connection. Example: 1Gbps Default: None
        ///  
        /// </summary>
        public string Bandwidth
        {
            get { return this.bandwidth; }
            set { this.bandwidth = value; }
        }

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this.bandwidth != null;
        }

        /// <summary>
        /// A list of connection costs.
        ///  
        /// </summary>
        public List<ConnectionCost> ConnectionCosts
        {
            get { return this.connectionCosts; }
            set { this.connectionCosts = value; }
        }

        // Check to see if ConnectionCosts property is set
        internal bool IsSetConnectionCosts()
        {
            return this.connectionCosts.Count > 0;
        }
    }
}
