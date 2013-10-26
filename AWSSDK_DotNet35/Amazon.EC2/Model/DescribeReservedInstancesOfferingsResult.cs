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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> The result of describing Reserved Instance offerings. </para>
    /// </summary>
    public partial class DescribeReservedInstancesOfferingsResult : AmazonWebServiceResponse
    {
        
        private List<ReservedInstancesOffering> reservedInstancesOfferings = new List<ReservedInstancesOffering>();
        private string nextToken;


        /// <summary>
        /// The list of described Reserved Instance offerings.
        ///  
        /// </summary>
        public List<ReservedInstancesOffering> ReservedInstancesOfferings
        {
            get { return this.reservedInstancesOfferings; }
            set { this.reservedInstancesOfferings = value; }
        }

        // Check to see if ReservedInstancesOfferings property is set
        internal bool IsSetReservedInstancesOfferings()
        {
            return this.reservedInstancesOfferings.Count > 0;
        }
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
