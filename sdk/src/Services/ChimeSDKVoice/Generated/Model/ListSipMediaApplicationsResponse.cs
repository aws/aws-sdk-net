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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// This is the response object from the ListSipMediaApplications operation.
    /// </summary>
    public partial class ListSipMediaApplicationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SipMediaApplication> _sipMediaApplications = new List<SipMediaApplication>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to return the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=65535)]
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

        /// <summary>
        /// Gets and sets the property SipMediaApplications. 
        /// <para>
        /// The list of SIP media applications and application details.
        /// </para>
        /// </summary>
        public List<SipMediaApplication> SipMediaApplications
        {
            get { return this._sipMediaApplications; }
            set { this._sipMediaApplications = value; }
        }

        // Check to see if SipMediaApplications property is set
        internal bool IsSetSipMediaApplications()
        {
            return this._sipMediaApplications != null && this._sipMediaApplications.Count > 0; 
        }

    }
}