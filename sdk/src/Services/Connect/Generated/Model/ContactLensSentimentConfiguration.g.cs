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
    /// The conversational analytics sentiment analysis configuration for a contact.
    /// </summary>
    public partial class ContactLensSentimentConfiguration
    {
        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// Specifies whether sentiment analysis is enabled for the contact. The default value
        /// is <c>Disable</c>. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Enable</c> – Sentiment analysis is performed on the contact.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Disable</c> – Sentiment analysis is not performed on the contact.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Behavior { get; set; }

        /// <summary>
        /// Checks to see if the Behavior property is set.
        /// </summary>
        internal bool IsSetBehavior() => this.Behavior != null;
    }
}
