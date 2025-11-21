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
    /// A resource type to include in the report. Associated options can also be specified
    /// if the resource type is a launch template.
    /// </summary>
    public partial class ImageUsageResourceTypeRequest
    {
        private string _resourceType;
        private List<ImageUsageResourceTypeOptionRequest> _resourceTypeOptions = AWSConfigs.InitializeCollections ? new List<ImageUsageResourceTypeOptionRequest>() : null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>ec2:Instance</c> | <c>ec2:LaunchTemplate</c> 
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTypeOptions. 
        /// <para>
        /// The options that affect the scope of the report. Valid only when <c>ResourceType</c>
        /// is <c>ec2:LaunchTemplate</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImageUsageResourceTypeOptionRequest> ResourceTypeOptions
        {
            get { return this._resourceTypeOptions; }
            set { this._resourceTypeOptions = value; }
        }

        // Check to see if ResourceTypeOptions property is set
        internal bool IsSetResourceTypeOptions()
        {
            return this._resourceTypeOptions != null && (this._resourceTypeOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}