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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Gives a detailed description of failed messages in the batch.
    /// </summary>
    public partial class BatchResultErrorEntry
    {
        private string _code;
        private string _id;
        private string _message;
        private bool? _senderFault;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// An error code representing why the action failed on this entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The <c>Id</c> of an entry in a batch request
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message explaining why the action failed on this entry.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property SenderFault. 
        /// <para>
        /// Specifies whether the error happened due to the caller of the batch API action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? SenderFault
        {
            get { return this._senderFault; }
            set { this._senderFault = value; }
        }

        // Check to see if SenderFault property is set
        internal bool IsSetSenderFault()
        {
            return this._senderFault.HasValue; 
        }

    }
}