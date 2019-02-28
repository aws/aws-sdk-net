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
    /// This is the response object from the GetInvitationConfiguration operation.
    /// </summary>
    public partial class GetInvitationConfigurationResponse : AmazonWebServiceResponse
    {
        private string _contactEmail;
        private string _organizationName;
        private List<string> _privateSkillIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ContactEmail. 
        /// <para>
        /// The email ID of the organization or individual contact that the enrolled user can
        /// use. 
        /// </para>
        /// </summary>
        public string ContactEmail
        {
            get { return this._contactEmail; }
            set { this._contactEmail = value; }
        }

        // Check to see if ContactEmail property is set
        internal bool IsSetContactEmail()
        {
            return this._contactEmail != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationName. 
        /// <para>
        /// The name of the organization sending the enrollment invite to a user.
        /// </para>
        /// </summary>
        public string OrganizationName
        {
            get { return this._organizationName; }
            set { this._organizationName = value; }
        }

        // Check to see if OrganizationName property is set
        internal bool IsSetOrganizationName()
        {
            return this._organizationName != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateSkillIds. 
        /// <para>
        /// The list of private skill IDs that you want to recommend to the user to enable in
        /// the invitation.
        /// </para>
        /// </summary>
        public List<string> PrivateSkillIds
        {
            get { return this._privateSkillIds; }
            set { this._privateSkillIds = value; }
        }

        // Check to see if PrivateSkillIds property is set
        internal bool IsSetPrivateSkillIds()
        {
            return this._privateSkillIds != null && this._privateSkillIds.Count > 0; 
        }

    }
}