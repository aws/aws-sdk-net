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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the AuthorizeIpRules operation.
    /// Adds one or more rules to the specified IP access control group.
    /// 
    ///  
    /// <para>
    /// This action gives users permission to access their WorkSpaces from the CIDR address
    /// ranges specified in the rules.
    /// </para>
    /// </summary>
    public partial class AuthorizeIpRulesRequest : AmazonWorkSpacesRequest
    {
        private string _groupId;
        private List<IpRuleItem> _userRules = new List<IpRuleItem>();

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the group.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property UserRules. 
        /// <para>
        /// The rules to add to the group.
        /// </para>
        /// </summary>
        public List<IpRuleItem> UserRules
        {
            get { return this._userRules; }
            set { this._userRules = value; }
        }

        // Check to see if UserRules property is set
        internal bool IsSetUserRules()
        {
            return this._userRules != null && this._userRules.Count > 0; 
        }

    }
}