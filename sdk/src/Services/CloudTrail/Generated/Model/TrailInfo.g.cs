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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Information about a CloudTrail trail, including the trail's name, home Region, and
    /// Amazon Resource Name (ARN).
    /// </summary>
    public partial class TrailInfo
    {
        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The Amazon Web Services Region in which a trail was created.
        /// </para>
        /// </summary>
        public string HomeRegion { get; set; }

        /// <summary>
        /// Checks to see if the HomeRegion property is set.
        /// </summary>
        internal bool IsSetHomeRegion() => this.HomeRegion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a trail.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TrailARN. 
        /// <para>
        /// The ARN of a trail.
        /// </para>
        /// </summary>
        public string TrailARN { get; set; }

        /// <summary>
        /// Checks to see if the TrailARN property is set.
        /// </summary>
        internal bool IsSetTrailARN() => this.TrailARN != null;
    }
}
