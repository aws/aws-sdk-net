/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateVolumePermissionModifications
    {
        
        private List<CreateVolumePermission> add = new List<CreateVolumePermission>();
        private List<CreateVolumePermission> remove = new List<CreateVolumePermission>();


        /// <summary>
        /// Adds a specific AWS account ID or group to a volume's list of create volume permissions.
        ///  
        /// </summary>
        public List<CreateVolumePermission> Add
        {
            get { return this.add; }
            set { this.add = value; }
        }

        // Check to see if Add property is set
        internal bool IsSetAdd()
        {
            return this.add.Count > 0;
        }

        /// <summary>
        /// Removes a specific AWS account ID or group from a volume's list of create volume permissions.
        ///  
        /// </summary>
        public List<CreateVolumePermission> Remove
        {
            get { return this.remove; }
            set { this.remove = value; }
        }

        // Check to see if Remove property is set
        internal bool IsSetRemove()
        {
            return this.remove.Count > 0;
        }
    }
}
