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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the GetIamPortalLoginUrl operation.
    /// </summary>
    public partial class GetIamPortalLoginUrlResponse : AmazonWebServiceResponse
    {
        private string _authCodeUrl;
        private string _userProfileId;

        /// <summary>
        /// Gets and sets the property AuthCodeUrl. 
        /// <para>
        /// The data portal URL of the specified Amazon DataZone domain.
        /// </para>
        /// </summary>
        public string AuthCodeUrl
        {
            get { return this._authCodeUrl; }
            set { this._authCodeUrl = value; }
        }

        // Check to see if AuthCodeUrl property is set
        internal bool IsSetAuthCodeUrl()
        {
            return this._authCodeUrl != null;
        }

        /// <summary>
        /// Gets and sets the property UserProfileId. 
        /// <para>
        /// The ID of the user profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserProfileId
        {
            get { return this._userProfileId; }
            set { this._userProfileId = value; }
        }

        // Check to see if UserProfileId property is set
        internal bool IsSetUserProfileId()
        {
            return this._userProfileId != null;
        }

    }
}