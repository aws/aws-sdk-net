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
    /// Container for the parameters to the CreateSpotDatafeedSubscription operation.
    /// <para>Creates a datafeed for Spot Instances, enabling you to view Spot Instance usage logs. You can create one data feed per AWS account.
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the
    /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CreateSpotDatafeedSubscriptionRequest : AmazonEC2Request
    {
        private string bucket;
        private string prefix;


        /// <summary>
        /// The Amazon S3 bucket in which to store the Spot Instance datafeed. Constraints: Must be a valid bucket associated with your AWS account.
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
        /// A prefix for the datafeed file names.
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

    }
}
    
