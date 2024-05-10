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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about a session that was created for an entity that performed
    /// an action by using temporary security credentials.
    /// </summary>
    public partial class SessionContext
    {
        private SessionContextAttributes _attributes;
        private SessionIssuer _sessionIssuer;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The date and time when the credentials were issued, and whether the credentials were
        /// authenticated with a multi-factor authentication (MFA) device.
        /// </para>
        /// </summary>
        public SessionContextAttributes Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null;
        }

        /// <summary>
        /// Gets and sets the property SessionIssuer. 
        /// <para>
        /// The source and type of credentials that were issued to the entity.
        /// </para>
        /// </summary>
        public SessionIssuer SessionIssuer
        {
            get { return this._sessionIssuer; }
            set { this._sessionIssuer = value; }
        }

        // Check to see if SessionIssuer property is set
        internal bool IsSetSessionIssuer()
        {
            return this._sessionIssuer != null;
        }

    }
}