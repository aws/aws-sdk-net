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
    /// A single entry in an image usage report, detailing how an image is being used by a
    /// specific Amazon Web Services account and resource type.
    /// </summary>
    public partial class ImageUsageReportEntry
    {
        private string _accountId;
        private string _imageId;
        private DateTime? _reportCreationTime;
        private string _reportId;
        private string _resourceType;
        private long? _usageCount;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the account that uses the image.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the image.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property ReportCreationTime. 
        /// <para>
        /// The date and time the report creation was initiated.
        /// </para>
        /// </summary>
        public DateTime? ReportCreationTime
        {
            get { return this._reportCreationTime; }
            set { this._reportCreationTime = value; }
        }

        // Check to see if ReportCreationTime property is set
        internal bool IsSetReportCreationTime()
        {
            return this._reportCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The ID of the report.
        /// </para>
        /// </summary>
        public string ReportId
        {
            get { return this._reportId; }
            set { this._reportId = value; }
        }

        // Check to see if ReportId property is set
        internal bool IsSetReportId()
        {
            return this._reportId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource (<c>ec2:Instance</c> or <c>ec2:LaunchTemplate</c>).
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
        /// Gets and sets the property UsageCount. 
        /// <para>
        /// The number of times resources of this type reference this image in the account.
        /// </para>
        /// </summary>
        public long? UsageCount
        {
            get { return this._usageCount; }
            set { this._usageCount = value; }
        }

        // Check to see if UsageCount property is set
        internal bool IsSetUsageCount()
        {
            return this._usageCount.HasValue; 
        }

    }
}