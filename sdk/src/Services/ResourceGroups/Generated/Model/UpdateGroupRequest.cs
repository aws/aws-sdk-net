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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
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
namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGroup operation.
    /// Updates the description for an existing group. You cannot update the name of a resource
    /// group.
    /// 
    ///  
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>resource-groups:UpdateGroup</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateGroupRequest : AmazonResourceGroupsRequest
    {
        private int? _criticality;
        private string _description;
        private string _displayName;
        private string _group;
        private string _groupName;
        private string _owner;

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        /// The critical rank of the application group on a scale of 1 to 10, with a rank of 1
        /// being the most critical, and a rank of 10 being least critical.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? Criticality
        {
            get { return this._criticality; }
            set { this._criticality = value; }
        }

        // Check to see if Criticality property is set
        internal bool IsSetCriticality()
        {
            return this._criticality.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description that you want to update the resource group with. Descriptions
        /// can contain letters, numbers, hyphens, underscores, periods, and spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the application group, which you can change at any time. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name or the ARN of the resource group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// Don't use this parameter. Use <c>Group</c> instead.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated, use Group instead.")]
        [AWSProperty(Min=1, Max=300)]
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// A name, email address or other identifier for the person or group who is considered
        /// as the owner of this application group within your organization. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

    }
}