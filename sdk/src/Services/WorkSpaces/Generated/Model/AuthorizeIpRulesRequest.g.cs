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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the AuthorizeIpRules operation. Adds one or more rules
    /// to the specified IP access control group. <para> This action gives users permission
    /// to access their WorkSpaces from the CIDR address ranges specified in the rules. </para>
    /// </summary>
    public partial class AuthorizeIpRulesRequest : AmazonWorkSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property UserRules. 
        /// <para>
        /// The rules to add to the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<IpRuleItem> UserRules { get; set; } = AWSConfigs.InitializeCollections ? new List<IpRuleItem>() : null;

        /// <summary>
        /// Checks to see if the UserRules property is set.
        /// </summary>
        internal bool IsSetUserRules() => this.UserRules != null && (this.UserRules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
