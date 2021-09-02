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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Describes the resource type and its ID preference for the user's Amazon Web Services
    /// account, in the current Amazon Web Services Region.
    /// </summary>
    public partial class ResourceIdPreference
    {
        private ResourceIdType _resourceIdType;
        private List<string> _resources = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceIdType. 
        /// <para>
        /// Identifies the EFS resource ID preference, either <code>LONG_ID</code> (17 characters)
        /// or <code>SHORT_ID</code> (8 characters).
        /// </para>
        /// </summary>
        public ResourceIdType ResourceIdType
        {
            get { return this._resourceIdType; }
            set { this._resourceIdType = value; }
        }

        // Check to see if ResourceIdType property is set
        internal bool IsSetResourceIdType()
        {
            return this._resourceIdType != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Identifies the Amazon EFS resources to which the ID preference setting applies, <code>FILE_SYSTEM</code>
        /// and <code>MOUNT_TARGET</code>.
        /// </para>
        /// </summary>
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

    }
}