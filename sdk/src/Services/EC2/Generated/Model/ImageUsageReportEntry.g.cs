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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// A single entry in an image usage report, detailing how an image is being used by a
    /// specific Amazon Web Services account and resource type.
    /// </summary>
    public partial class ImageUsageReportEntry
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the account that uses the image.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the image.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property ReportCreationTime. 
        /// <para>
        /// The date and time the report creation was initiated.
        /// </para>
        /// </summary>
        public DateTime? ReportCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the ReportCreationTime property is set.
        /// </summary>
        internal bool IsSetReportCreationTime() => this.ReportCreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The ID of the report.
        /// </para>
        /// </summary>
        public string ReportId { get; set; }

        /// <summary>
        /// Checks to see if the ReportId property is set.
        /// </summary>
        internal bool IsSetReportId() => this.ReportId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource (<c>ec2:Instance</c> | <c>ec2:LaunchTemplate</c> | <c>imagebuilder:ImageRecipe</c>
        /// | <c>imagebuilder:ContainerRecipe</c>).
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property UsageCount. 
        /// <para>
        /// The number of times resources of this type reference this image in the account.
        /// </para>
        /// </summary>
        public long? UsageCount { get; set; }

        /// <summary>
        /// Checks to see if the UsageCount property is set.
        /// </summary>
        internal bool IsSetUsageCount() => this.UsageCount.HasValue;
    }
}
