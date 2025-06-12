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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
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
namespace Amazon.SQS.Model
{
    /// <summary>
    /// For each message in the batch, the response contains a <c> <a>DeleteMessageBatchResultEntry</a>
    /// </c> tag if the message is deleted or a <c> <a>BatchResultErrorEntry</a> </c> tag
    /// if the message can't be deleted.
    /// </summary>
    public partial class DeleteMessageBatchResponse : AmazonWebServiceResponse
    {
        private List<BatchResultErrorEntry> _failed = AWSConfigs.InitializeCollections ? new List<BatchResultErrorEntry>() : null;
        private List<DeleteMessageBatchResultEntry> _successful = AWSConfigs.InitializeCollections ? new List<DeleteMessageBatchResultEntry>() : null;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// A list of <c> <a>BatchResultErrorEntry</a> </c> items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchResultErrorEntry> Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed != null && (this._failed.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Successful. 
        /// <para>
        /// A list of <c> <a>DeleteMessageBatchResultEntry</a> </c> items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DeleteMessageBatchResultEntry> Successful
        {
            get { return this._successful; }
            set { this._successful = value; }
        }

        // Check to see if Successful property is set
        internal bool IsSetSuccessful()
        {
            return this._successful != null && (this._successful.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}