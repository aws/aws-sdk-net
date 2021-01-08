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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetConferenceProvider operation.
    /// </summary>
    public partial class GetConferenceProviderResponse : AmazonWebServiceResponse
    {
        private ConferenceProvider _conferenceProvider;

        /// <summary>
        /// Gets and sets the property ConferenceProvider. 
        /// <para>
        /// The conference provider.
        /// </para>
        /// </summary>
        public ConferenceProvider ConferenceProvider
        {
            get { return this._conferenceProvider; }
            set { this._conferenceProvider = value; }
        }

        // Check to see if ConferenceProvider property is set
        internal bool IsSetConferenceProvider()
        {
            return this._conferenceProvider != null;
        }

    }
}