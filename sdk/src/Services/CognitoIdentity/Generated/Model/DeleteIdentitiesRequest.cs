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
    /// Container for the parameters to the DeleteIdentities operation.
    /// Deletes identities from an identity pool. You can specify a list of 1-60 identities
    /// that you want to delete.
    /// 
    ///  
    /// <para>
    /// You must use AWS Developer credentials to call this API.
    /// </para>
    /// </summary>
    public partial class DeleteIdentitiesRequest : AmazonCognitoIdentityRequest
    {
        private List<string> _identityIdsToDelete = new List<string>();

        /// <summary>
        /// Gets and sets the property IdentityIdsToDelete. 
        /// <para>
        /// A list of 1-60 identities that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public List<string> IdentityIdsToDelete
        {
            get { return this._identityIdsToDelete; }
            set { this._identityIdsToDelete = value; }
        }

        // Check to see if IdentityIdsToDelete property is set
        internal bool IsSetIdentityIdsToDelete()
        {
            return this._identityIdsToDelete != null && this._identityIdsToDelete.Count > 0; 
        }

    }
}