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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGroup operation.
    /// Creates a new group.
    /// 
    ///         
    /// <para>
    /// For information about the number of groups you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
    /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
    /// </para>
    /// </summary>
    public partial class CreateGroupRequest : AmazonWebServiceRequest
    {
        private string _groupName;
        private string _path;


        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// Name of the group to create. Do not include the path in this value.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }


        /// <summary>
        /// Sets the GroupName property
        /// </summary>
        /// <param name="groupName">The value to set for the GroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateGroupRequest WithGroupName(string groupName)
        {
            this._groupName = groupName;
            return this;
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }


        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the group. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        ///         
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/).
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }


        /// <summary>
        /// Sets the Path property
        /// </summary>
        /// <param name="path">The value to set for the Path property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateGroupRequest WithPath(string path)
        {
            this._path = path;
            return this;
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}