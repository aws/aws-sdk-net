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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Endpoint user specific custom userAttributes
    /// </summary>
    public partial class EndpointUser
    {
        private Dictionary<string, List<string>> _userAttributes = new Dictionary<string, List<string>>();
        private string _userId;

        /// <summary>
        /// Gets and sets the property UserAttributes. Custom attributes that describe an end
        /// user by associating a name with an array of values. For example, an attribute named
        /// "interests" might have the values ["science", "politics", "travel"]. You can use these
        /// attributes as selection criteria when you create a segment of users to engage with
        /// a messaging campaign.The following characters are not recommended in attribute names:
        /// # : ? \ /. The Amazon Pinpoint console does not display attributes that include these
        /// characters in the name. This limitation does not apply to attribute values.
        /// </summary>
        public Dictionary<string, List<string>> UserAttributes
        {
            get { return this._userAttributes; }
            set { this._userAttributes = value; }
        }

        // Check to see if UserAttributes property is set
        internal bool IsSetUserAttributes()
        {
            return this._userAttributes != null && this._userAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserId. The unique ID of the user.
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}