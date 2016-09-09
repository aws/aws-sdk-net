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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Represents the response from the server to the request to get the header information
    /// for the .csv file for the user import job.
    /// </summary>
    public partial class GetCSVHeaderResponse : AmazonWebServiceResponse
    {
        private List<string> _csvHeader = new List<string>();
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property CSVHeader. 
        /// <para>
        /// The header information for the .csv file for the user import job.
        /// </para>
        /// </summary>
        public List<string> CSVHeader
        {
            get { return this._csvHeader; }
            set { this._csvHeader = value; }
        }

        // Check to see if CSVHeader property is set
        internal bool IsSetCSVHeader()
        {
            return this._csvHeader != null && this._csvHeader.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID for the user pool that the users are to be imported into.
        /// </para>
        /// </summary>
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}