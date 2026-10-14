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

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains additional details for a handshake.
    /// </summary>
    public partial class HandshakeResource
    {
        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// An array of <c>HandshakeResource</c> objects. When needed, contains additional details
        /// for a handshake. For example, the email address for the sender.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HandshakeResource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<HandshakeResource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of information being passed, specifying how the value is to be interpreted
        /// by the other party:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ACCOUNT</b>: ID for an Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ORGANIZATION</b>: ID for an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EMAIL</b>: Email address for the recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OWNER_EMAIL</b>: Email address for the sender.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OWNER_NAME</b>: Name of the sender.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>NOTES</b>: Additional text included by the sender for the recipient.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HandshakeResourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Additional information for the handshake. The format of the value string must match
        /// the requirements of the specified type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
