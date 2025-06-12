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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the NotifyWorkers operation.
    /// The <c>NotifyWorkers</c> operation sends an email to one or more Workers that you
    /// specify with the Worker ID. You can specify up to 100 Worker IDs to send the same
    /// message with a single call to the NotifyWorkers operation. The NotifyWorkers operation
    /// will send a notification email to a Worker only if you have previously approved or
    /// rejected work from the Worker.
    /// </summary>
    public partial class NotifyWorkersRequest : AmazonMTurkRequest
    {
        private string _messageText;
        private string _subject;
        private List<string> _workerIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MessageText. 
        /// <para>
        /// The text of the email message to send. Can include up to 4,096 characters
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MessageText
        {
            get { return this._messageText; }
            set { this._messageText = value; }
        }

        // Check to see if MessageText property is set
        internal bool IsSetMessageText()
        {
            return this._messageText != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line of the email message to send. Can include up to 200 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerIds. 
        /// <para>
        /// A list of Worker IDs you wish to notify. You can notify upto 100 Workers at a time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> WorkerIds
        {
            get { return this._workerIds; }
            set { this._workerIds = value; }
        }

        // Check to see if WorkerIds property is set
        internal bool IsSetWorkerIds()
        {
            return this._workerIds != null && (this._workerIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}