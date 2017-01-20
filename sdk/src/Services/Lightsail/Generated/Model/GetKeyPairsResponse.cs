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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetKeyPairs operation.
    /// </summary>
    public partial class GetKeyPairsResponse : AmazonWebServiceResponse
    {
        private List<KeyPair> _keyPairs = new List<KeyPair>();
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property KeyPairs. 
        /// <para>
        /// An array of key-value pairs containing information about the key pairs.
        /// </para>
        /// </summary>
        public List<KeyPair> KeyPairs
        {
            get { return this._keyPairs; }
            set { this._keyPairs = value; }
        }

        // Check to see if KeyPairs property is set
        internal bool IsSetKeyPairs()
        {
            return this._keyPairs != null && this._keyPairs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// A token used for advancing to the next page of results from your get key pairs request.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}