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
    /// Container for the parameters to the CreatePrivacyBudgetTemplate operation.
    /// Creates a privacy budget template for a specified collaboration. Each collaboration
    /// can have only one privacy budget template. If you need to change the privacy budget
    /// template, use the <a>UpdatePrivacyBudgetTemplate</a> operation.
    /// </summary>
    public partial class CreatePrivacyBudgetTemplateRequest : AmazonCleanRoomsRequest
    {
        private PrivacyBudgetTemplateAutoRefresh _autoRefresh;
        private string _membershipIdentifier;
        private PrivacyBudgetTemplateParametersInput _parameters;
        private PrivacyBudgetType _privacyBudgetType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AutoRefresh. 
        /// <para>
        /// How often the privacy budget refreshes.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you plan to regularly bring new data into the collaboration, you can use <c>CALENDAR_MONTH</c>
        /// to automatically get a new privacy budget for the collaboration every calendar month.
        /// Choosing this option allows arbitrary amounts of information to be revealed about
        /// rows of the data when repeatedly queries across refreshes. Avoid choosing this if
        /// the same rows will be repeatedly queried between privacy budget refreshes.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivacyBudgetTemplateAutoRefresh AutoRefresh
        {
            get { return this._autoRefresh; }
            set { this._autoRefresh = value; }
        }

        // Check to see if AutoRefresh property is set
        internal bool IsSetAutoRefresh()
        {
            return this._autoRefresh != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for one of your memberships for a collaboration. The privacy budget
        /// template is created in the collaboration that this membership belongs to. Accepts
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
        /// Specifies your parameters for the privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivacyBudgetTemplateParametersInput Parameters
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional label that you can assign to a resource when you create it. Each tag consists
        /// of a key and an optional value, both of which you define. When you use tagging, you
        /// can also use tag-based access control in IAM policies to control access to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}