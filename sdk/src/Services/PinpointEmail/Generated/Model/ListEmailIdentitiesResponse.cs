/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// A list of all of the identities that you've attempted to verify for use with Amazon
    /// Pinpoint, regardless of whether or not those identities were successfully verified.
    /// </summary>
    public partial class ListEmailIdentitiesResponse : AmazonWebServiceResponse
    {
        private List<IdentityInfo> _emailIdentities = new List<IdentityInfo>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EmailIdentities. 
        /// <para>
        /// An array that includes all of the identities associated with your Amazon Pinpoint
        /// account.
        /// </para>
        /// </summary>
        public List<IdentityInfo> EmailIdentities
        {
            get { return this._emailIdentities; }
            set { this._emailIdentities = value; }
        }

        // Check to see if EmailIdentities property is set
        internal bool IsSetEmailIdentities()
        {
            return this._emailIdentities != null && this._emailIdentities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there are additional configuration sets to list. To view
        /// additional configuration sets, issue another request to <code>ListEmailIdentities</code>,
        /// and pass this token in the <code>NextToken</code> parameter.
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