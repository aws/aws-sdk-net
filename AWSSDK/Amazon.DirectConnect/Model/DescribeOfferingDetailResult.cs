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
    /// <para> Detailed information about an offering, including basic offering information plus order steps. </para>
    /// </summary>
    public class DescribeOfferingDetailResult  
    {
        
        private string offeringId;
        private string region;
        private string location;
        private string offeringName;
        private string description;
        private string bandwidth;
        private List<ConnectionCost> connectionCosts = new List<ConnectionCost>();
        private List<OfferingOrderStep> orderSteps = new List<OfferingOrderStep>();

        /// <summary>
        /// The ID of the offering. Example: us-west-1_EqSV5_1G Default: None
        ///  
        /// </summary>
        public string OfferingId
        {
            get { return this.offeringId; }
            set { this.offeringId = value; }
        }

        /// <summary>
        /// Sets the OfferingId property
        /// </summary>
        /// <param name="offeringId">The value to set for the OfferingId property </param>
        /// <returns>this instance</returns>
        public DescribeOfferingDetailResult WithOfferingId(string offeringId)
        {
            this.offeringId = offeringId;
            return this;
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

        /// <summary>
        /// Sets the Region property
        /// </summary>
        /// <param name="region">The value to set for the Region property </param>
        /// <returns>this instance</returns>
        public DescribeOfferingDetailResult WithRegion(string region)
        {
            this.region = region;
            return this;
        }
            

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;       
        }

        /// <summary>
        /// The AWS Direct Connect location where the offering is located. Example: EqSV5 Default: None
        ///  
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        /// <summary>
        /// Sets the Location property
        /// </summary>
        /// <param name="location">The value to set for the Location property </param>
        /// <returns>this instance</returns>
        public DescribeOfferingDetailResult WithLocation(string location)
        {
            this.location = location;
            return this;
        }
            

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;       
        }
        public string OfferingName
        {
            get { return this.offeringName; }
            set { this.offeringName = value; }
        }

        /// <summary>
        /// Sets the OfferingName property
        /// </summary>
        /// <param name="offeringName">The value to set for the OfferingName property </param>
        /// <returns>this instance</returns>
        public DescribeOfferingDetailResult WithOfferingName(string offeringName)
        {
            this.offeringName = offeringName;
            return this;
        }
            

        // Check to see if OfferingName property is set
        internal bool IsSetOfferingName()
        {
            return this.offeringName != null;       
        }

        /// <summary>
        /// Description of the offering. Example: "<i>1Gbps Cross Connect in us-east-1 via Equinix</i>" Default: None
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public DescribeOfferingDetailResult WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;       
        }

        /// <summary>
        /// Bandwidth of the connection. Example: 1Gpbs Default: None
        ///  
        /// </summary>
        public string Bandwidth
        {
            get { return this.bandwidth; }
            set { this.bandwidth = value; }
        }

        /// <summary>
        /// Sets the Bandwidth property
        /// </summary>
        /// <param name="bandwidth">The value to set for the Bandwidth property </param>
        /// <returns>this instance</returns>
        public DescribeOfferingDetailResult WithBandwidth(string bandwidth)
        {
            this.bandwidth = bandwidth;
            return this;
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
        /// <summary>
        /// Adds elements to the ConnectionCosts collection
        /// </summary>
        /// <param name="connectionCosts">The values to add to the ConnectionCosts collection </param>
        /// <returns>this instance</returns>
        public DescribeOfferingDetailResult WithConnectionCosts(params ConnectionCost[] connectionCosts)
        {
            foreach (ConnectionCost element in connectionCosts)
            {
                this.connectionCosts.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ConnectionCosts collection
        /// </summary>
        /// <param name="connectionCosts">The values to add to the ConnectionCosts collection </param>
        /// <returns>this instance</returns>
        public DescribeOfferingDetailResult WithConnectionCosts(IEnumerable<ConnectionCost> connectionCosts)
        {
            foreach (ConnectionCost element in connectionCosts)
            {
                this.connectionCosts.Add(element);
            }

            return this;
        }

        // Check to see if ConnectionCosts property is set
        internal bool IsSetConnectionCosts()
        {
            return this.connectionCosts.Count > 0;       
        }

        /// <summary>
        /// A list of connection order steps.
        ///  
        /// </summary>
        public List<OfferingOrderStep> OrderSteps
        {
            get { return this.orderSteps; }
            set { this.orderSteps = value; }
        }
        /// <summary>
        /// Adds elements to the OrderSteps collection
        /// </summary>
        /// <param name="orderSteps">The values to add to the OrderSteps collection </param>
        /// <returns>this instance</returns>
        public DescribeOfferingDetailResult WithOrderSteps(params OfferingOrderStep[] orderSteps)
        {
            foreach (OfferingOrderStep element in orderSteps)
            {
                this.orderSteps.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the OrderSteps collection
        /// </summary>
        /// <param name="orderSteps">The values to add to the OrderSteps collection </param>
        /// <returns>this instance</returns>
        public DescribeOfferingDetailResult WithOrderSteps(IEnumerable<OfferingOrderStep> orderSteps)
        {
            foreach (OfferingOrderStep element in orderSteps)
            {
                this.orderSteps.Add(element);
            }

            return this;
        }

        // Check to see if OrderSteps property is set
        internal bool IsSetOrderSteps()
        {
            return this.orderSteps.Count > 0;       
        }
    }
}
