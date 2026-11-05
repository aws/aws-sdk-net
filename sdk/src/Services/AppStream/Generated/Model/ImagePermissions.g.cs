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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes the permissions for an image.
    /// </summary>
    public partial class ImagePermissions
    {
        /// <summary>
        /// Gets and sets the property AllowFleet. 
        /// <para>
        /// Indicates whether the image can be used for a fleet.
        /// </para>
        /// </summary>
        public bool? AllowFleet { get; set; }

        /// <summary>
        /// Checks to see if the AllowFleet property is set.
        /// </summary>
        internal bool IsSetAllowFleet() => this.AllowFleet.HasValue;

        /// <summary>
        /// Gets and sets the property AllowImageBuilder. 
        /// <para>
        /// Indicates whether the image can be used for an image builder.
        /// </para>
        /// </summary>
        public bool? AllowImageBuilder { get; set; }

        /// <summary>
        /// Checks to see if the AllowImageBuilder property is set.
        /// </summary>
        internal bool IsSetAllowImageBuilder() => this.AllowImageBuilder.HasValue;
    }
}
