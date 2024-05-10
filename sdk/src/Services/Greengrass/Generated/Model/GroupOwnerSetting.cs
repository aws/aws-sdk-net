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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Group owner related settings for local resources.
    /// </summary>
    public partial class GroupOwnerSetting
    {
        private bool? _autoAddGroupOwner;
        private string _groupOwner;

        /// <summary>
        /// Gets and sets the property AutoAddGroupOwner. If true, AWS IoT Greengrass automatically
        /// adds the specified Linux OS group owner of the resource to the Lambda process privileges.
        /// Thus the Lambda process will have the file access permissions of the added Linux group.
        /// </summary>
        public bool? AutoAddGroupOwner
        {
            get { return this._autoAddGroupOwner; }
            set { this._autoAddGroupOwner = value; }
        }

        // Check to see if AutoAddGroupOwner property is set
        internal bool IsSetAutoAddGroupOwner()
        {
            return this._autoAddGroupOwner.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupOwner. The name of the Linux OS group whose privileges
        /// will be added to the Lambda process. This field is optional.
        /// </summary>
        public string GroupOwner
        {
            get { return this._groupOwner; }
            set { this._groupOwner = value; }
        }

        // Check to see if GroupOwner property is set
        internal bool IsSetGroupOwner()
        {
            return this._groupOwner != null;
        }

    }
}