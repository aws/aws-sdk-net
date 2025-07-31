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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Object that defines users preferred methods of engagement.
    /// </summary>
    public partial class EngagementPreferences
    {
        private List<ContactPreference> _email = AWSConfigs.InitializeCollections ? new List<ContactPreference>() : null;
        private List<ContactPreference> _phone = AWSConfigs.InitializeCollections ? new List<ContactPreference>() : null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// A list of email-related contact preferences
        /// </para>
        /// </summary>
        public List<ContactPreference> Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null && (this._email.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phone. 
        /// <para>
        /// A list of phone-related contact preferences
        /// </para>
        /// </summary>
        public List<ContactPreference> Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }

        // Check to see if Phone property is set
        internal bool IsSetPhone()
        {
            return this._phone != null && (this._phone.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}