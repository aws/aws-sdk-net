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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Information about a resource.
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// Gets and sets the property Id. The resource ID, used to refer to a resource in the
        /// Lambda function configuration. Max length is 128 characters with pattern ''[a-zA-Z0-9:_-]+''.
        /// This must be unique within a Greengrass group.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. The descriptive resource name, which is displayed
        /// on the AWS IoT Greengrass console. Max length 128 characters with pattern ''[a-zA-Z0-9:_-]+''.
        /// This must be unique within a Greengrass group.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceDataContainer. A container of data for all resource
        /// types.
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceDataContainer ResourceDataContainer { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDataContainer property is set.
        /// </summary>
        internal bool IsSetResourceDataContainer() => this.ResourceDataContainer != null;
    }
}
