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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
    /// Container for the parameters to the CreateIpGroup operation.
    /// Creates an IP access control group.
    /// 
    ///  
    /// <para>
    /// An IP access control group provides you with the ability to control the IP addresses
    /// from which users are allowed to access their WorkSpaces. To specify the CIDR address
    /// ranges, add rules to your IP access control group and then associate the group with
    /// your directory. You can add rules when you create the group or at any time using <a>AuthorizeIpRules</a>.
    /// </para>
    ///  
    /// <para>
    /// There is a default IP access control group associated with your directory. If you
    /// don't associate an IP access control group with your directory, the default group
    /// is used. The default group includes a default rule that allows users to access their
    /// WorkSpaces from anywhere. You cannot modify the default IP access control group for
    /// your directory.
    /// </para>
    /// </summary>
    public partial class CreateIpGroupRequest : AmazonWorkSpacesRequest
    {
        private string _groupDesc;
        private string _groupName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<IpRuleItem> _userRules = AWSConfigs.InitializeCollections ? new List<IpRuleItem>() : null;

        /// <summary>
        /// Gets and sets the property GroupDesc. 
        /// <para>
        /// The description of the group.
        /// </para>
        /// </summary>
        public string GroupDesc
        {
            get { return this._groupDesc; }
            set { this._groupDesc = value; }
        }

        // Check to see if GroupDesc property is set
        internal bool IsSetGroupDesc()
        {
            return this._groupDesc != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags. Each WorkSpaces resource can have a maximum of 50 tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserRules. 
        /// <para>
        /// The rules to add to the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpRuleItem> UserRules
        {
            get { return this._userRules; }
            set { this._userRules = value; }
        }

        // Check to see if UserRules property is set
        internal bool IsSetUserRules()
        {
            return this._userRules != null && (this._userRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}