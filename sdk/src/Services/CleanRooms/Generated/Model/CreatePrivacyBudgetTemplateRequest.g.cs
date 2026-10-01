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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreatePrivacyBudgetTemplate operation. Creates
    /// a privacy budget template for a specified collaboration. Each collaboration can have
    /// only one privacy budget template. If you need to change the privacy budget template,
    /// use the <a>UpdatePrivacyBudgetTemplate</a> operation.
    /// </summary>
    public partial class CreatePrivacyBudgetTemplateRequest : AmazonCleanRoomsRequest
    {
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
        public PrivacyBudgetTemplateAutoRefresh AutoRefresh { get; set; }

        /// <summary>
        /// Checks to see if the AutoRefresh property is set.
        /// </summary>
        internal bool IsSetAutoRefresh() => this.AutoRefresh != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for one of your memberships for a collaboration. The privacy budget
        /// template is created in the collaboration that this membership belongs to. Accepts
        /// a membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Specifies your parameters for the privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivacyBudgetTemplateParametersInput Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;

        /// <summary>
        /// Gets and sets the property PrivacyBudgetType. 
        /// <para>
        /// Specifies the type of the privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivacyBudgetType PrivacyBudgetType { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyBudgetType property is set.
        /// </summary>
        internal bool IsSetPrivacyBudgetType() => this.PrivacyBudgetType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional label that you can assign to a resource when you create it. Each tag consists
        /// of a key and an optional value, both of which you define. When you use tagging, you
        /// can also use tag-based access control in IAM policies to control access to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
