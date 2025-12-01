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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the ListEntitySecurityProfiles operation.
    /// </summary>
    public partial class ListEntitySecurityProfilesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SecurityProfileItem> _securityProfiles = AWSConfigs.InitializeCollections ? new List<SecurityProfileItem>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2500)]
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
        /// Gets and sets the property SecurityProfiles. 
        /// <para>
        ///  List of Security Profile Object. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<SecurityProfileItem> SecurityProfiles
        {
            get { return this._securityProfiles; }
            set { this._securityProfiles = value; }
        }

        // Check to see if SecurityProfiles property is set
        internal bool IsSetSecurityProfiles()
        {
            return this._securityProfiles != null && (this._securityProfiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}