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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// A description of the identity.
    /// </summary>
    public partial class DescribeIdentityResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationDate;
        private string _identityId;
        private DateTime? _lastModifiedDate;
        private List<string> _logins = new List<string>();

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// Date on which the identity was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityId. 
        /// <para>
        /// A unique identifier in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
        public string IdentityId
        {
            get { return this._identityId; }
            set { this._identityId = value; }
        }

        // Check to see if IdentityId property is set
        internal bool IsSetIdentityId()
        {
            return this._identityId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Date on which the identity was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Logins. 
        /// <para>
        /// The provider names.
        /// </para>
        /// </summary>
        public List<string> Logins
        {
            get { return this._logins; }
            set { this._logins = value; }
        }

        // Check to see if Logins property is set
        internal bool IsSetLogins()
        {
            return this._logins != null && this._logins.Count > 0; 
        }

    }
}