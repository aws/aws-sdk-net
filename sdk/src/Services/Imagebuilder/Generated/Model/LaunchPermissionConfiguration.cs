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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Describes the configuration for a launch permission. The launch permission modification
    /// request is sent to the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyImageAttribute.html">Amazon
    /// EC2 ModifyImageAttribute</a> API on behalf of the user for each Region they have selected
    /// to distribute the AMI. To make an AMI public, set the launch permission authorized
    /// accounts to <c>all</c>. See the examples for making an AMI public at <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyImageAttribute.html">Amazon
    /// EC2 ModifyImageAttribute</a>.
    /// </summary>
    public partial class LaunchPermissionConfiguration
    {
        private List<string> _organizationalUnitArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _organizationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _userGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _userIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitArns. 
        /// <para>
        /// The ARN for an Organizations organizational unit (OU) that you want to share your
        /// AMI with. For more information about key concepts for Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html">Organizations
        /// terminology and concepts</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> OrganizationalUnitArns
        {
            get { return this._organizationalUnitArns; }
            set { this._organizationalUnitArns = value; }
        }

        // Check to see if OrganizationalUnitArns property is set
        internal bool IsSetOrganizationalUnitArns()
        {
            return this._organizationalUnitArns != null && (this._organizationalUnitArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrganizationArns. 
        /// <para>
        /// The ARN for an Amazon Web Services Organization that you want to share your AMI with.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_introduction.html">What
        /// is Organizations?</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> OrganizationArns
        {
            get { return this._organizationArns; }
            set { this._organizationArns = value; }
        }

        // Check to see if OrganizationArns property is set
        internal bool IsSetOrganizationArns()
        {
            return this._organizationArns != null && (this._organizationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserGroups. 
        /// <para>
        /// The name of the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserGroups
        {
            get { return this._userGroups; }
            set { this._userGroups = value; }
        }

        // Check to see if UserGroups property is set
        internal bool IsSetUserGroups()
        {
            return this._userGroups != null && (this._userGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1536)]
        public List<string> UserIds
        {
            get { return this._userIds; }
            set { this._userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this._userIds != null && (this._userIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}