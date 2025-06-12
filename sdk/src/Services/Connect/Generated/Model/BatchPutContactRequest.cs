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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the BatchPutContact operation.
    /// <note> 
    /// <para>
    /// Only the Amazon Connect outbound campaigns service principal is allowed to assume
    /// a role in your account and call this API.
    /// </para>
    ///  </note> 
    /// <para>
    /// Allows you to create a batch of contacts in Amazon Connect. The outbound campaigns
    /// capability ingests dial requests via the <a href="https://docs.aws.amazon.com/connect-outbound/latest/APIReference/API_PutDialRequestBatch.html">PutDialRequestBatch</a>
    /// API. It then uses BatchPutContact to create contacts corresponding to those dial requests.
    /// If agents are available, the dial requests are dialed out, which results in a voice
    /// call. The resulting voice call uses the same contactId that was created by BatchPutContact.
    /// 
    /// </para>
    /// </summary>
    public partial class BatchPutContactRequest : AmazonConnectRequest
    {
        private string _clientToken;
        private List<ContactDataRequest> _contactDataRequestList = AWSConfigs.InitializeCollections ? new List<ContactDataRequest>() : null;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContactDataRequestList. 
        /// <para>
        /// List of individual contact requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<ContactDataRequest> ContactDataRequestList
        {
            get { return this._contactDataRequestList; }
            set { this._contactDataRequestList = value; }
        }

        // Check to see if ContactDataRequestList property is set
        internal bool IsSetContactDataRequestList()
        {
            return this._contactDataRequestList != null && (this._contactDataRequestList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}