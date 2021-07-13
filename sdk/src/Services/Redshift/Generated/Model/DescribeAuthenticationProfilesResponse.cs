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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the DescribeAuthenticationProfiles operation.
    /// </summary>
    public partial class DescribeAuthenticationProfilesResponse : AmazonWebServiceResponse
    {
        private List<AuthenticationProfile> _authenticationProfiles = new List<AuthenticationProfile>();

        /// <summary>
        /// Gets and sets the property AuthenticationProfiles. 
        /// <para>
        /// The list of authentication profiles.
        /// </para>
        /// </summary>
        public List<AuthenticationProfile> AuthenticationProfiles
        {
            get { return this._authenticationProfiles; }
            set { this._authenticationProfiles = value; }
        }

        // Check to see if AuthenticationProfiles property is set
        internal bool IsSetAuthenticationProfiles()
        {
            return this._authenticationProfiles != null && this._authenticationProfiles.Count > 0; 
        }

    }
}