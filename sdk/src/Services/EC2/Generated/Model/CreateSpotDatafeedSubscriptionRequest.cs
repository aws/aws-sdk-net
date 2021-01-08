/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSpotDatafeedSubscription operation.
    /// Creates a data feed for Spot Instances, enabling you to view Spot Instance usage logs.
    /// You can create one data feed per AWS account. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
    /// Instance data feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
    /// </summary>
    public partial class CreateSpotDatafeedSubscriptionRequest : AmazonEC2Request
    {
        private string _bucket;
        private string _prefix;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateSpotDatafeedSubscriptionRequest() { }

        /// <summary>
        /// Instantiates CreateSpotDatafeedSubscriptionRequest with the parameterized properties
        /// </summary>
        /// <param name="bucket">The name of the Amazon S3 bucket in which to store the Spot Instance data feed. For more information about bucket names, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html#bucketnamingrules">Rules for bucket naming</a> in the <i>Amazon S3 Developer Guide</i>.</param>
        public CreateSpotDatafeedSubscriptionRequest(string bucket)
        {
            _bucket = bucket;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket in which to store the Spot Instance data feed. For
        /// more information about bucket names, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html#bucketnamingrules">Rules
        /// for bucket naming</a> in the <i>Amazon S3 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix for the data feed file names.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}