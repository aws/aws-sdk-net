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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration settings for the SageMaker Partner AI App.
    /// </summary>
    public partial class PartnerAppConfig
    {
        private List<string> _adminUsers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _arguments = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _assignedGroupPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<RoleGroupAssignment> _roleGroupAssignments = AWSConfigs.InitializeCollections ? new List<RoleGroupAssignment>() : null;

        /// <summary>
        /// Gets and sets the property AdminUsers. 
        /// <para>
        /// The list of users that are given admin access to the SageMaker Partner AI App.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> AdminUsers
        {
            get { return this._adminUsers; }
            set { this._adminUsers = value; }
        }

        // Check to see if AdminUsers property is set
        internal bool IsSetAdminUsers()
        {
            return this._adminUsers != null && (this._adminUsers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// This is a map of required inputs for a SageMaker Partner AI App. Based on the application
        /// type, the map is populated with a key and value pair that is specific to the user
        /// and application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public Dictionary<string, string> Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return this._arguments != null && (this._arguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssignedGroupPatterns. 
        /// <para>
        /// A list of Amazon Web Services IAM Identity Center group patterns that can access the
        /// SageMaker Partner AI App. Group names support wildcard matching using <c>*</c>. An
        /// empty list indicates the app will not use Identity Center group features. All groups
        /// specified in <c>RoleGroupAssignments</c> must match patterns in this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> AssignedGroupPatterns
        {
            get { return this._assignedGroupPatterns; }
            set { this._assignedGroupPatterns = value; }
        }

        // Check to see if AssignedGroupPatterns property is set
        internal bool IsSetAssignedGroupPatterns()
        {
            return this._assignedGroupPatterns != null && (this._assignedGroupPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleGroupAssignments. 
        /// <para>
        /// A map of in-app roles to Amazon Web Services IAM Identity Center group patterns. Groups
        /// assigned to specific roles receive those permissions, while groups in <c>AssignedGroupPatterns</c>
        /// but not in this map receive default in-app role depending on app type. Group patterns
        /// support wildcard matching using <c>*</c>. Currently supported by Fiddler version 1.3
        /// and later with roles: <c>ORG_MEMBER</c> (default) and <c>ORG_ADMIN</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<RoleGroupAssignment> RoleGroupAssignments
        {
            get { return this._roleGroupAssignments; }
            set { this._roleGroupAssignments = value; }
        }

        // Check to see if RoleGroupAssignments property is set
        internal bool IsSetRoleGroupAssignments()
        {
            return this._roleGroupAssignments != null && (this._roleGroupAssignments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}