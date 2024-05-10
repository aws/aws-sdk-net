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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes modifications to the list of create volume permissions for a volume.
    /// </summary>
    public partial class CreateVolumePermissionModifications
    {
        private List<CreateVolumePermission> _add = AWSConfigs.InitializeCollections ? new List<CreateVolumePermission>() : null;
        private List<CreateVolumePermission> _remove = AWSConfigs.InitializeCollections ? new List<CreateVolumePermission>() : null;

        /// <summary>
        /// Gets and sets the property Add. 
        /// <para>
        /// Adds the specified Amazon Web Services account ID or group to the list.
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
            return this._add != null && (this._add.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Remove. 
        /// <para>
        /// Removes the specified Amazon Web Services account ID or group from the list.
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
            return this._remove != null && (this._remove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}