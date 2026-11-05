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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes a Fleet Advisor collector.
    /// </summary>
    public partial class CollectorResponse
    {
        /// <summary>
        /// Gets and sets the property CollectorHealthCheck.
        /// </summary>
        public CollectorHealthCheck CollectorHealthCheck { get; set; }

        /// <summary>
        /// Checks to see if the CollectorHealthCheck property is set.
        /// </summary>
        internal bool IsSetCollectorHealthCheck() => this.CollectorHealthCheck != null;

        /// <summary>
        /// Gets and sets the property CollectorName. 
        /// <para>
        /// The name of the Fleet Advisor collector .
        /// </para>
        /// </summary>
        public string CollectorName { get; set; }

        /// <summary>
        /// Checks to see if the CollectorName property is set.
        /// </summary>
        internal bool IsSetCollectorName() => this.CollectorName != null;

        /// <summary>
        /// Gets and sets the property CollectorReferencedId. 
        /// <para>
        /// The reference ID of the Fleet Advisor collector.
        /// </para>
        /// </summary>
        public string CollectorReferencedId { get; set; }

        /// <summary>
        /// Checks to see if the CollectorReferencedId property is set.
        /// </summary>
        internal bool IsSetCollectorReferencedId() => this.CollectorReferencedId != null;

        /// <summary>
        /// Gets and sets the property CollectorVersion. 
        /// <para>
        /// The version of your Fleet Advisor collector, in semantic versioning format, for example
        /// <c>1.0.2</c> 
        /// </para>
        /// </summary>
        public string CollectorVersion { get; set; }

        /// <summary>
        /// Checks to see if the CollectorVersion property is set.
        /// </summary>
        internal bool IsSetCollectorVersion() => this.CollectorVersion != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The timestamp when you created the collector, in the following format: <c>2022-01-24T19:04:02.596113Z</c>
        /// 
        /// </para>
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A summary description of the Fleet Advisor collector.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InventoryData.
        /// </summary>
        public InventoryData InventoryData { get; set; }

        /// <summary>
        /// Checks to see if the InventoryData property is set.
        /// </summary>
        internal bool IsSetInventoryData() => this.InventoryData != null;

        /// <summary>
        /// Gets and sets the property LastDataReceived. 
        /// <para>
        /// The timestamp of the last time the collector received data, in the following format:
        /// <c>2022-01-24T19:04:02.596113Z</c> 
        /// </para>
        /// </summary>
        public string LastDataReceived { get; set; }

        /// <summary>
        /// Checks to see if the LastDataReceived property is set.
        /// </summary>
        internal bool IsSetLastDataReceived() => this.LastDataReceived != null;

        /// <summary>
        /// Gets and sets the property ModifiedDate. 
        /// <para>
        /// The timestamp when DMS last modified the collector, in the following format: <c>2022-01-24T19:04:02.596113Z</c>
        /// 
        /// </para>
        /// </summary>
        public string ModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedDate property is set.
        /// </summary>
        internal bool IsSetModifiedDate() => this.ModifiedDate != null;

        /// <summary>
        /// Gets and sets the property RegisteredDate. 
        /// <para>
        /// The timestamp when DMS registered the collector, in the following format: <c>2022-01-24T19:04:02.596113Z</c>
        /// 
        /// </para>
        /// </summary>
        public string RegisteredDate { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredDate property is set.
        /// </summary>
        internal bool IsSetRegisteredDate() => this.RegisteredDate != null;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The Amazon S3 bucket that the Fleet Advisor collector uses to store inventory metadata.
        /// </para>
        /// </summary>
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The IAM role that grants permissions to access the specified Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccessRoleArn() => this.ServiceAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property VersionStatus. 
        /// <para>
        /// Whether the collector version is up to date.
        /// </para>
        /// </summary>
        public VersionStatus VersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the VersionStatus property is set.
        /// </summary>
        internal bool IsSetVersionStatus() => this.VersionStatus != null;
    }
}
