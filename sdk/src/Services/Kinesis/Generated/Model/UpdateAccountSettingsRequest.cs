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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccountSettings operation.
    /// Updates the account-level settings for Amazon Kinesis Data Streams.
    /// 
    ///  
    /// <para>
    /// Updating account settings is a synchronous operation. Upon receiving the request,
    /// Kinesis Data Streams will return immediately with your account’s updated settings.
    /// </para>
    ///  
    /// <para>
    ///  <b>API limits</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Certain account configurations have minimum commitment windows. Attempting to update
    /// your settings prior to the end of the minimum commitment window might have certain
    /// restrictions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This API has a call limit of 5 transactions per second (TPS) for each Amazon Web Services
    /// account. TPS over 5 will initiate the <c>LimitExceededException</c>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateAccountSettingsRequest : AmazonKinesisRequest
    {
        private MinimumThroughputBillingCommitmentInput _minimumThroughputBillingCommitment;

        /// <summary>
        /// Gets and sets the property MinimumThroughputBillingCommitment. 
        /// <para>
        /// Specifies the minimum throughput billing commitment configuration for your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MinimumThroughputBillingCommitmentInput MinimumThroughputBillingCommitment
        {
            get { return this._minimumThroughputBillingCommitment; }
            set { this._minimumThroughputBillingCommitment = value; }
        }

        // Check to see if MinimumThroughputBillingCommitment property is set
        internal bool IsSetMinimumThroughputBillingCommitment()
        {
            return this._minimumThroughputBillingCommitment != null;
        }

    }
}