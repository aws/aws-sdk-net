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
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
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
    /// Describes modifications to the permissions for a volume.
    /// </summary>
    public partial class CreateVolumePermissionModifications
    {
        private List<CreateVolumePermission> _add = new List<CreateVolumePermission>();
        private List<CreateVolumePermission> _remove = new List<CreateVolumePermission>();

        /// <summary>
        /// Gets and sets the property Add. 
        /// <para>
        /// Adds a specific AWS account ID or group to a volume's list of create volume permissions.
        /// </para>
        /// </summary>
        public List<CreateVolumePermission> Add
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
        /// Removes a specific AWS account ID or group from a volume's list of create volume permissions.
        /// </para>
        /// </summary>
        public List<CreateVolumePermission> Remove
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