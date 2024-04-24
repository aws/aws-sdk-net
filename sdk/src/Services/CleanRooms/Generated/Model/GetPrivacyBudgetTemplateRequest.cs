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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the GetPrivacyBudgetTemplate operation.
    /// Returns details for a specified privacy budget template.
    /// </summary>
    public partial class GetPrivacyBudgetTemplateRequest : AmazonCleanRoomsRequest
    {
        private string _membershipIdentifier;
        private string _privacyBudgetTemplateIdentifier;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for one of your memberships for a collaboration. The privacy budget
        /// template is retrieved from the collaboration that this membership belongs to. Accepts
        /// a membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PrivacyBudgetTemplateIdentifier. 
        /// <para>
        /// A unique identifier for your privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PrivacyBudgetTemplateIdentifier
        {
            get { return this._privacyBudgetTemplateIdentifier; }
            set { this._privacyBudgetTemplateIdentifier = value; }
        }

        // Check to see if PrivacyBudgetTemplateIdentifier property is set
        internal bool IsSetPrivacyBudgetTemplateIdentifier()
        {
            return this._privacyBudgetTemplateIdentifier != null;
        }

    }
}