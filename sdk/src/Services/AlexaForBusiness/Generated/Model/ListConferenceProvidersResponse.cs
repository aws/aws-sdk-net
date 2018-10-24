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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// This is the response object from the ListConferenceProviders operation.
    /// </summary>
    public partial class ListConferenceProvidersResponse : AmazonWebServiceResponse
    {
        private List<ConferenceProvider> _conferenceProviders = new List<ConferenceProvider>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConferenceProviders. 
        /// <para>
        /// The conference providers.
        /// </para>
        /// </summary>
        public List<ConferenceProvider> ConferenceProviders
        {
            get { return this._conferenceProviders; }
            set { this._conferenceProviders = value; }
        }

        // Check to see if ConferenceProviders property is set
        internal bool IsSetConferenceProviders()
        {
            return this._conferenceProviders != null && this._conferenceProviders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The tokens used for pagination.
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