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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains details about an IAM group.
    /// </summary>
    public partial class AwsIamGroupDetails
    {
        private List<AwsIamAttachedManagedPolicy> _attachedManagedPolicies = AWSConfigs.InitializeCollections ? new List<AwsIamAttachedManagedPolicy>() : null;
        private string _createDate;
        private string _groupId;
        private string _groupName;
        private List<AwsIamGroupPolicy> _groupPolicyList = AWSConfigs.InitializeCollections ? new List<AwsIamGroupPolicy>() : null;
        private string _path;

        /// <summary>
        /// Gets and sets the property AttachedManagedPolicies. 
        /// <para>
        /// A list of the managed policies that are attached to the IAM group.
        /// </para>
        /// </summary>
        public List<AwsIamAttachedManagedPolicy> AttachedManagedPolicies
        {
            get { return this._attachedManagedPolicies; }
            set { this._attachedManagedPolicies = value; }
        }

        // Check to see if AttachedManagedPolicies property is set
        internal bool IsSetAttachedManagedPolicies()
        {
            return this._attachedManagedPolicies != null && (this._attachedManagedPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// Indicates when the IAM group was created.
        /// </para>
        ///  
        /// <para>
        /// This field accepts only the specified formats. Timestamps can end with <c>Z</c> or
        /// <c>("+" / "-") time-hour [":" time-minute]</c>. The time-secfrac after seconds is
        /// limited to a maximum of 9 digits. The offset is bounded by +/-18:00. Here are valid
        /// timestamp formats with examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SSZ</c> (for example, <c>2019-01-31T23:00:00Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmmZ</c> (for example, <c>2019-01-31T23:00:00.123456789Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS+HH:MM</c> (for example, <c>2024-01-04T15:25:10+17:59</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS-HHMM</c> (for example, <c>2024-01-04T15:25:10-1759</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmm+HH:MM</c> (for example, <c>2024-01-04T15:25:10.123456789+17:59</c>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier of the IAM group.
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
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the IAM group.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property GroupPolicyList. 
        /// <para>
        /// The list of inline policies that are embedded in the group.
        /// </para>
        /// </summary>
        public List<AwsIamGroupPolicy> GroupPolicyList
        {
            get { return this._groupPolicyList; }
            set { this._groupPolicyList = value; }
        }

        // Check to see if GroupPolicyList property is set
        internal bool IsSetGroupPolicyList()
        {
            return this._groupPolicyList != null && (this._groupPolicyList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the group.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}