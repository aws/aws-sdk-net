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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Describes the resource type and its ID preference for the user's Amazon Web Services
    /// account, in the current Amazon Web Services Region.
    /// </summary>
    public partial class ResourceIdPreference
    {
        private ResourceIdType _resourceIdType;
        private List<string> _resources = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceIdType. 
        /// <para>
        /// Identifies the EFS resource ID preference, either <c>LONG_ID</c> (17 characters) or
        /// <c>SHORT_ID</c> (8 characters).
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
        /// Identifies the Amazon EFS resources to which the ID preference setting applies, <c>FILE_SYSTEM</c>
        /// and <c>MOUNT_TARGET</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}