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
    /// Container for the parameters to the AssociateSkillWithUsers operation.
    /// Makes a private skill available for enrolled users to enable on their devices.
    /// </summary>
    public partial class AssociateSkillWithUsersRequest : AmazonAlexaForBusinessRequest
    {
        private string _organizationArn;
        private string _skillId;

        /// <summary>
        /// Gets and sets the property OrganizationArn. 
        /// <para>
        /// The ARN of the organization.
        /// </para>
        /// </summary>
        public string OrganizationArn
        {
            get { return this._organizationArn; }
            set { this._organizationArn = value; }
        }

        // Check to see if OrganizationArn property is set
        internal bool IsSetOrganizationArn()
        {
            return this._organizationArn != null;
        }

        /// <summary>
        /// Gets and sets the property SkillId. 
        /// <para>
        /// The private skill ID you want to make available to enrolled users.&gt;
        /// </para>
        /// </summary>
        public string SkillId
        {
            get { return this._skillId; }
            set { this._skillId = value; }
        }

        // Check to see if SkillId property is set
        internal bool IsSetSkillId()
        {
            return this._skillId != null;
        }

    }
}