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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a launch permission modification.
    /// </summary>
    public partial class LaunchPermissionModifications
    {
        private List<LaunchPermission> _add = new List<LaunchPermission>();
        private List<LaunchPermission> _remove = new List<LaunchPermission>();

        /// <summary>
        /// Gets and sets the property Add. 
        /// <para>
        /// The AWS account ID to add to the list of launch permissions for the AMI.
        /// </para>
        /// </summary>
        public List<LaunchPermission> Add
        {
            get { return this._add; }
            set { this._add = value; }
        }

        // Check to see if Add property is set
        internal bool IsSetAdd()
        {
            return this._add != null && this._add.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Remove. 
        /// <para>
        /// The AWS account ID to remove from the list of launch permissions for the AMI.
        /// </para>
        /// </summary>
        public List<LaunchPermission> Remove
        {
            get { return this._remove; }
            set { this._remove = value; }
        }

        // Check to see if Remove property is set
        internal bool IsSetRemove()
        {
            return this._remove != null && this._remove.Count > 0; 
        }

    }
}