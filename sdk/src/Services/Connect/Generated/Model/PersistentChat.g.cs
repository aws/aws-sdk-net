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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Enable persistent chats. For more information about enabling persistent chat, and
    /// for example use cases and how to configure for them, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
    /// persistent chat</a>.
    /// </summary>
    public partial class PersistentChat
    {
        /// <summary>
        /// Gets and sets the property RehydrationType. 
        /// <para>
        /// The contactId that is used for rehydration depends on the rehydration type. RehydrationType
        /// is required for persistent chat. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENTIRE_PAST_SESSION</c>: Rehydrates a chat from the most recently terminated past
        /// chat contact of the specified past ended chat session. To use this type, provide the
        /// <c>initialContactId</c> of the past ended chat session in the <c>sourceContactId</c>
        /// field. In this type, Connect Customer determines the most recent chat contact on the
        /// specified chat session that has ended, and uses it to start a persistent chat. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FROM_SEGMENT</c>: Rehydrates a chat from the past chat contact that is specified
        /// in the <c>sourceContactId</c> field. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The actual contactId used for rehydration is provided in the response of this API.
        /// 
        /// </para>
        /// </summary>
        public RehydrationType RehydrationType { get; set; }

        /// <summary>
        /// Checks to see if the RehydrationType property is set.
        /// </summary>
        internal bool IsSetRehydrationType() => this.RehydrationType != null;

        /// <summary>
        /// Gets and sets the property SourceContactId. 
        /// <para>
        /// The contactId from which a persistent chat session must be started.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SourceContactId { get; set; }

        /// <summary>
        /// Checks to see if the SourceContactId property is set.
        /// </summary>
        internal bool IsSetSourceContactId() => this.SourceContactId != null;
    }
}
