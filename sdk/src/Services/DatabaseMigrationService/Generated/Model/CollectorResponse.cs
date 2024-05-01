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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
        private CollectorHealthCheck _collectorHealthCheck;
        private string _collectorName;
        private string _collectorReferencedId;
        private string _collectorVersion;
        private string _createdDate;
        private string _description;
        private InventoryData _inventoryData;
        private string _lastDataReceived;
        private string _modifiedDate;
        private string _registeredDate;
        private string _s3BucketName;
        private string _serviceAccessRoleArn;
        private VersionStatus _versionStatus;

        /// <summary>
        /// Gets and sets the property CollectorHealthCheck.
        /// </summary>
        public CollectorHealthCheck CollectorHealthCheck
        {
            get { return this._collectorHealthCheck; }
            set { this._collectorHealthCheck = value; }
        }

        // Check to see if CollectorHealthCheck property is set
        internal bool IsSetCollectorHealthCheck()
        {
            return this._collectorHealthCheck != null;
        }

        /// <summary>
        /// Gets and sets the property CollectorName. 
        /// <para>
        /// The name of the Fleet Advisor collector .
        /// </para>
        /// </summary>
        public string CollectorName
        {
            get { return this._collectorName; }
            set { this._collectorName = value; }
        }

        // Check to see if CollectorName property is set
        internal bool IsSetCollectorName()
        {
            return this._collectorName != null;
        }

        /// <summary>
        /// Gets and sets the property CollectorReferencedId. 
        /// <para>
        /// The reference ID of the Fleet Advisor collector.
        /// </para>
        /// </summary>
        public string CollectorReferencedId
        {
            get { return this._collectorReferencedId; }
            set { this._collectorReferencedId = value; }
        }

        // Check to see if CollectorReferencedId property is set
        internal bool IsSetCollectorReferencedId()
        {
            return this._collectorReferencedId != null;
        }

        /// <summary>
        /// Gets and sets the property CollectorVersion. 
        /// <para>
        /// The version of your Fleet Advisor collector, in semantic versioning format, for example
        /// <c>1.0.2</c> 
        /// </para>
        /// </summary>
        public string CollectorVersion
        {
            get { return this._collectorVersion; }
            set { this._collectorVersion = value; }
        }

        // Check to see if CollectorVersion property is set
        internal bool IsSetCollectorVersion()
        {
            return this._collectorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The timestamp when you created the collector, in the following format: <c>2022-01-24T19:04:02.596113Z</c>
        /// 
        /// </para>
        /// </summary>
        public string CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A summary description of the Fleet Advisor collector.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InventoryData.
        /// </summary>
        public InventoryData InventoryData
        {
            get { return this._inventoryData; }
            set { this._inventoryData = value; }
        }

        // Check to see if InventoryData property is set
        internal bool IsSetInventoryData()
        {
            return this._inventoryData != null;
        }

        /// <summary>
        /// Gets and sets the property LastDataReceived. 
        /// <para>
        /// The timestamp of the last time the collector received data, in the following format:
        /// <c>2022-01-24T19:04:02.596113Z</c> 
        /// </para>
        /// </summary>
        public string LastDataReceived
        {
            get { return this._lastDataReceived; }
            set { this._lastDataReceived = value; }
        }

        // Check to see if LastDataReceived property is set
        internal bool IsSetLastDataReceived()
        {
            return this._lastDataReceived != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedDate. 
        /// <para>
        /// The timestamp when DMS last modified the collector, in the following format: <c>2022-01-24T19:04:02.596113Z</c>
        /// 
        /// </para>
        /// </summary>
        public string ModifiedDate
        {
            get { return this._modifiedDate; }
            set { this._modifiedDate = value; }
        }

        // Check to see if ModifiedDate property is set
        internal bool IsSetModifiedDate()
        {
            return this._modifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredDate. 
        /// <para>
        /// The timestamp when DMS registered the collector, in the following format: <c>2022-01-24T19:04:02.596113Z</c>
        /// 
        /// </para>
        /// </summary>
        public string RegisteredDate
        {
            get { return this._registeredDate; }
            set { this._registeredDate = value; }
        }

        // Check to see if RegisteredDate property is set
        internal bool IsSetRegisteredDate()
        {
            return this._registeredDate != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The Amazon S3 bucket that the Fleet Advisor collector uses to store inventory metadata.
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The IAM role that grants permissions to access the specified Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionStatus. 
        /// <para>
        /// Whether the collector version is up to date.
        /// </para>
        /// </summary>
        public VersionStatus VersionStatus
        {
            get { return this._versionStatus; }
            set { this._versionStatus = value; }
        }

        // Check to see if VersionStatus property is set
        internal bool IsSetVersionStatus()
        {
            return this._versionStatus != null;
        }

    }
}