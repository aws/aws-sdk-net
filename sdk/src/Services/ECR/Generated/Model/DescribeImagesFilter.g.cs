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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object representing a filter on a <a>DescribeImages</a> operation.
    /// </summary>
    public partial class DescribeImagesFilter
    {
        /// <summary>
        /// Gets and sets the property ImageStatus. 
        /// <para>
        /// The image status with which to filter your <a>DescribeImages</a> results. Valid values
        /// are <c>ACTIVE</c>, <c>ARCHIVED</c>, and <c>ACTIVATING</c>. If not specified, only
        /// images with <c>ACTIVE</c> status are returned.
        /// </para>
        /// </summary>
        public ImageStatusFilter ImageStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImageStatus property is set.
        /// </summary>
        internal bool IsSetImageStatus() => this.ImageStatus != null;

        /// <summary>
        /// Gets and sets the property TagStatus. 
        /// <para>
        /// The tag status with which to filter your <a>DescribeImages</a> results. You can filter
        /// results based on whether they are <c>TAGGED</c> or <c>UNTAGGED</c>.
        /// </para>
        /// </summary>
        public TagStatus TagStatus { get; set; }

        /// <summary>
        /// Checks to see if the TagStatus property is set.
        /// </summary>
        internal bool IsSetTagStatus() => this.TagStatus != null;
    }
}
