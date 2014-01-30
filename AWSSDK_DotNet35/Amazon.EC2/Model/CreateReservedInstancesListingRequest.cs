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
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReservedInstancesListing operation.
    /// <para>Creates a listing for Amazon EC2 Reserved Instances to be sold in the Reserved Instance Marketplace. You can submit one Reserved
    /// Instance listing at a time.</para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
    /// Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CreateReservedInstancesListingRequest : AmazonEC2Request
    {
        private string reservedInstancesId;
        private int? instanceCount;
        private List<PriceScheduleSpecification> priceSchedules = new List<PriceScheduleSpecification>();
        private string clientToken;


        /// <summary>
        /// The ID of the active Reserved Instance.
        ///  
        /// </summary>
        public string ReservedInstancesId
        {
            get { return this.reservedInstancesId; }
            set { this.reservedInstancesId = value; }
        }

        // Check to see if ReservedInstancesId property is set
        internal bool IsSetReservedInstancesId()
        {
            return this.reservedInstancesId != null;
        }

        /// <summary>
        /// The number of instances that are a part of a Reserved Instance account to be listed in the Reserved Instance Marketplace. This number should
        /// be less than or equal to the instance count associated with the Reserved Instance ID specified in this call.
        ///  
        /// </summary>
        public int InstanceCount
        {
            get { return this.instanceCount ?? default(int); }
            set { this.instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this.instanceCount.HasValue;
        }

        /// <summary>
        /// A list specifying the price of the Reserved Instance for each month remaining in the Reserved Instance term.
        ///  
        /// </summary>
        public List<PriceScheduleSpecification> PriceSchedules
        {
            get { return this.priceSchedules; }
            set { this.priceSchedules = value; }
        }

        // Check to see if PriceSchedules property is set
        internal bool IsSetPriceSchedules()
        {
            return this.priceSchedules.Count > 0;
        }

        /// <summary>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of your listings. This helps avoid duplicate listings. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">Ensuring Idempotency</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i>.
        ///  
        /// </summary>
        public string ClientToken
        {
            get { return this.clientToken; }
            set { this.clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this.clientToken != null;
        }

    }
}
    
