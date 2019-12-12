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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class LaunchPermissionConfiguration
    {
        private List<string> _userGroups = new List<string>();
        private List<string> _userIds = new List<string>();

        /// <summary>
        /// Gets and sets the property UserGroups. 
        /// <para>
        ///  
        /// </para>
        /// </summary>
        public List<string> UserGroups
        {
            get { return this._userGroups; }
            set { this._userGroups = value; }
        }

        // Check to see if UserGroups property is set
        internal bool IsSetUserGroups()
        {
            return this._userGroups != null && this._userGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        ///  
        /// </para>
        /// </summary>
        public List<string> UserIds
        {
            get { return this._userIds; }
            set { this._userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this._userIds != null && this._userIds.Count > 0; 
        }

    }
}