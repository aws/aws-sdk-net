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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the ListIdentities operation.
    /// Returns a list containing all of the identities (email addresses and domains) for
    /// your Amazon Web Services account in the current Amazon Web Services Region, regardless
    /// of verification status.
    /// 
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    ///  <note> 
    /// <para>
    /// It's recommended that for successive pagination calls of this API, you continue to
    /// the use the same parameter/value pairs as used in the original call, e.g., if you
    /// used <c>IdentityType=Domain</c> in the the original call and received a <c>NextToken</c>
    /// in the response, you should continue providing the <c>IdentityType=Domain</c> parameter
    /// for further <c>NextToken</c> calls; however, if you didn't provide the <c>IdentityType</c>
    /// parameter in the original call, then continue to not provide it for successive pagination
    /// calls. Using this protocol will ensure consistent results.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListIdentitiesRequest : AmazonSimpleEmailServiceRequest
    {
        private IdentityType _identityType;
        private int? _maxItems;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The type of the identities to list. Possible values are "EmailAddress" and "Domain".
        /// If this parameter is omitted, then all identities are listed.
        /// </para>
        /// </summary>
        public IdentityType IdentityType
        {
            get { return this._identityType; }
            set { this._identityType = value; }
        }

        // Check to see if IdentityType property is set
        internal bool IsSetIdentityType()
        {
            return this._identityType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of identities per page. Possible values are 1-1000 inclusive.
        /// </para>
        /// </summary>
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use for pagination.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}