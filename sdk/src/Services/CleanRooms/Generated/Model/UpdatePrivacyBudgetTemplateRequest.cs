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
    /// Container for the parameters to the UpdatePrivacyBudgetTemplate operation.
    /// Updates the privacy budget template for the specified collaboration.
    /// </summary>
    public partial class UpdatePrivacyBudgetTemplateRequest : AmazonCleanRoomsRequest
    {
        private string _membershipIdentifier;
        private PrivacyBudgetTemplateUpdateParameters _parameters;
        private string _privacyBudgetTemplateIdentifier;
        private PrivacyBudgetType _privacyBudgetType;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for one of your memberships for a collaboration. The privacy budget
        /// template is updated in the collaboration that this membership belongs to. Accepts
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Specifies the epsilon and noise parameters for the privacy budget template.
        /// </para>
        /// </summary>
        public PrivacyBudgetTemplateUpdateParameters Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

        /// <summary>
        /// Gets and sets the property PrivacyBudgetTemplateIdentifier. 
        /// <para>
        /// A unique identifier for your privacy budget template that you want to update.
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

        /// <summary>
        /// Gets and sets the property PrivacyBudgetType. 
        /// <para>
        /// Specifies the type of the privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivacyBudgetType PrivacyBudgetType
        {
            get { return this._privacyBudgetType; }
            set { this._privacyBudgetType = value; }
        }

        // Check to see if PrivacyBudgetType property is set
        internal bool IsSetPrivacyBudgetType()
        {
            return this._privacyBudgetType != null;
        }

    }
}