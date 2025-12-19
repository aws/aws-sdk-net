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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Container for the parameters to the BatchLookupUserUname operation.
    /// Looks up multiple user usernames from their unique username hashes (unames). This
    /// operation allows you to retrieve the email addresses associated with a list of username
    /// hashes.
    /// </summary>
    public partial class BatchLookupUserUnameRequest : AmazonWickrRequest
    {
        private string _clientToken;
        private string _networkId;
        private List<string> _unames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for this request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return !string.IsNullOrEmpty(this._clientToken);
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network where the users will be looked up.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=8)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property Unames. 
        /// <para>
        /// A list of username hashes (unames) to look up. Each uname is a unique identifier for
        /// a user's username. Maximum 50 unames per batch request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Unames
        {
            get { return this._unames; }
            set { this._unames = value; }
        }

        // Check to see if Unames property is set
        internal bool IsSetUnames()
        {
            return this._unames != null && (this._unames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}