/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Creates the datafeed for Spot Instances, enabling you to view Spot Instance usage logs.
    /// You can create one data feed per account.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateSpotDatafeedSubscriptionRequest
    {    
        private string bucketField;
        private string prefixField;

        /// <summary>
        /// The Amazon S3 bucket in which to store the Spot Instance datafeed.
        /// Constraints: Must be a valid bucket assocaited with your account.
        /// </summary>
        [XmlElementAttribute(ElementName = "Bucket")]
        public string Bucket
        {
            get { return this.bucketField; }
            set { this.bucketField = value; }
        }

        /// <summary>
        /// Sets the Amazon S3 bucket in which to store the Spot Instance datafeed.
        /// </summary>
        /// <param name="bucket">
        /// The Amazon S3 bucket in which to store the Spot Instance datafeed.
        /// </param>
        /// <returns>this instance</returns>
        public CreateSpotDatafeedSubscriptionRequest WithBucket(string bucket)
        {
            this.bucketField = bucket;
            return this;
        }

        /// <summary>
        /// Checks if Bucket property is set
        /// </summary>
        /// <returns>true if Bucket property is set</returns>
        public bool IsSetBucket()
        {
            return this.bucketField != null;
        }

        /// <summary>
        /// Prefix that is prepended to datafeed files.
        /// </summary>
        [XmlElementAttribute(ElementName = "Prefix")]
        public string Prefix
        {
            get { return this.prefixField; }
            set { this.prefixField = value; }
        }

        /// <summary>
        /// Sets the prefix that is prepended to datafeed files.
        /// </summary>
        /// <param name="prefix">Prefix that is prepended to datafeed files.</param>
        /// <returns>this instance</returns>
        public CreateSpotDatafeedSubscriptionRequest WithPrefix(string prefix)
        {
            this.prefixField = prefix;
            return this;
        }

        /// <summary>
        /// Checks if Prefix property is set
        /// </summary>
        /// <returns>true if Prefix property is set</returns>
        public bool IsSetPrefix()
        {
            return this.prefixField != null;
        }

    }
}
