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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePool operation.
    /// Deletes an existing pool. Deleting a pool disassociates all origination identities
    /// from that pool.
    /// 
    ///  
    /// <para>
    /// If the pool status isn't active or if deletion protection is enabled, an error is
    /// returned.
    /// </para>
    ///  
    /// <para>
    /// A pool is a collection of phone numbers and SenderIds. A pool can include one or more
    /// phone numbers and SenderIds that are associated with your Amazon Web Services account.
    /// </para>
    /// </summary>
    public partial class DeletePoolRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _poolId;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The PoolId or PoolArn of the pool to delete. You can use <a>DescribePools</a> to find
        /// the values for PoolId and PoolArn .
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared AWS End User Messaging SMS and Voice resource then you must
        /// use the full Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

    }
}