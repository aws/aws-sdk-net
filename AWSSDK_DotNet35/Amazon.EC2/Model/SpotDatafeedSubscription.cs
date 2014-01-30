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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes the datafeed for a Spot Instance.</para>
    /// </summary>
    public class SpotDatafeedSubscription
    {
        
        private string ownerId;
        private string bucket;
        private string prefix;
        private DatafeedSubscriptionState state;
        private SpotInstanceStateFault fault;


        /// <summary>
        /// The AWS account ID of the account.
        ///  
        /// </summary>
        public string OwnerId
        {
            get { return this.ownerId; }
            set { this.ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this.ownerId != null;
        }

        /// <summary>
        /// The Amazon S3 bucket where the Spot Instance datafeed is located.
        ///  
        /// </summary>
        public string Bucket
        {
            get { return this.bucket; }
            set { this.bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this.bucket != null;
        }

        /// <summary>
        /// The prefix that is prepended to datafeed files.
        ///  
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this.prefix != null;
        }

        /// <summary>
        /// The state of the Spot Instance datafeed subscription.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Active, Inactive</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public DatafeedSubscriptionState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// The fault codes for the Spot Instance request, if any.
        ///  
        /// </summary>
        public SpotInstanceStateFault Fault
        {
            get { return this.fault; }
            set { this.fault = value; }
        }

        // Check to see if Fault property is set
        internal bool IsSetFault()
        {
            return this.fault != null;
        }
    }
}
