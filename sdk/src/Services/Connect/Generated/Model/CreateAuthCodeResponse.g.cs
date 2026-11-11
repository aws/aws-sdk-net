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
    /// This is the response object from the CreateAuthCode operation.
    /// </summary>
    public partial class CreateAuthCodeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthCode. 
        /// <para>
        /// The authorization code to use for establishing a session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Checks to see if the AuthCode property is set.
        /// </summary>
        internal bool IsSetAuthCode() => this.AuthCode != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier of the entity associated with the authorization code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of entity associated with the authorization code.
        /// </para>
        /// </summary>
        public AuthCodeEntityType EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session created with the authorization code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 36)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
