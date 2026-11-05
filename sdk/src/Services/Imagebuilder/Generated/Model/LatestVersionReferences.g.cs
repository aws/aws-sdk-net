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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// A set of wildcard version ARNs that always reference the latest version of the resource.
    /// ARNs are included for the latest version overall, and for the latest versions within
    /// the same major, minor, and patch levels.
    /// </summary>
    public partial class LatestVersionReferences
    {
        /// <summary>
        /// Gets and sets the property LatestMajorVersionArn. 
        /// <para>
        /// The latest version Amazon Resource Name (ARN) with the same <c>major</c> version of
        /// the Image Builder resource.
        /// </para>
        /// </summary>
        public string LatestMajorVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the LatestMajorVersionArn property is set.
        /// </summary>
        internal bool IsSetLatestMajorVersionArn() => this.LatestMajorVersionArn != null;

        /// <summary>
        /// Gets and sets the property LatestMinorVersionArn. 
        /// <para>
        /// The latest version Amazon Resource Name (ARN) with the same <c>minor</c> version of
        /// the Image Builder resource.
        /// </para>
        /// </summary>
        public string LatestMinorVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the LatestMinorVersionArn property is set.
        /// </summary>
        internal bool IsSetLatestMinorVersionArn() => this.LatestMinorVersionArn != null;

        /// <summary>
        /// Gets and sets the property LatestPatchVersionArn. 
        /// <para>
        /// The latest version Amazon Resource Name (ARN) with the same <c>patch</c> version of
        /// the Image Builder resource.
        /// </para>
        /// </summary>
        public string LatestPatchVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the LatestPatchVersionArn property is set.
        /// </summary>
        internal bool IsSetLatestPatchVersionArn() => this.LatestPatchVersionArn != null;

        /// <summary>
        /// Gets and sets the property LatestVersionArn. 
        /// <para>
        /// The latest version Amazon Resource Name (ARN) of the Image Builder resource.
        /// </para>
        /// </summary>
        public string LatestVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionArn property is set.
        /// </summary>
        internal bool IsSetLatestVersionArn() => this.LatestVersionArn != null;
    }
}
