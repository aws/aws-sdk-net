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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
    /// Contains additional data that is needed to process a handshake.
    /// </summary>
    public partial class HandshakeResource
    {
        private List<HandshakeResource> _resources = AWSConfigs.InitializeCollections ? new List<HandshakeResource>() : null;
        private HandshakeResourceType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// When needed, contains an additional array of <c>HandshakeResource</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HandshakeResource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of information being passed, specifying how the value is to be interpreted
        /// by the other party:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACCOUNT</c> - Specifies an Amazon Web Services account ID number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ORGANIZATION</c> - Specifies an organization ID number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EMAIL</c> - Specifies the email address that is associated with the account that
        /// receives the handshake. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OWNER_EMAIL</c> - Specifies the email address associated with the management account.
        /// Included as information about an organization. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OWNER_NAME</c> - Specifies the name associated with the management account. Included
        /// as information about an organization. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOTES</c> - Additional text provided by the handshake initiator and intended for
        /// the recipient to read.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HandshakeResourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The information that is passed to the other party in the handshake. The format of
        /// the value string must match the requirements of the specified type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}