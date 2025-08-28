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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The progress report for the import job.
    /// </summary>
    public partial class JobProgressReport
    {
        private double? _throughput;
        private long? _totalNumberOfFilesReadWithCustomerError;
        private long? _totalNumberOfImportedFiles;
        private long? _totalNumberOfResourcesImported;
        private long? _totalNumberOfResourcesScanned;
        private long? _totalNumberOfResourcesWithCustomerError;
        private long? _totalNumberOfScannedFiles;
        private double? _totalSizeOfScannedFilesInMB;

        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The transaction rate the import job is processed at.
        /// </para>
        /// </summary>
        public double? Throughput
        {
            get { return this._throughput; }
            set { this._throughput = value; }
        }

        // Check to see if Throughput property is set
        internal bool IsSetThroughput()
        {
            return this._throughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfFilesReadWithCustomerError. 
        /// <para>
        /// The number of files that failed to be read from the S3 input bucket due to customer
        /// error.
        /// </para>
        /// </summary>
        public long? TotalNumberOfFilesReadWithCustomerError
        {
            get { return this._totalNumberOfFilesReadWithCustomerError; }
            set { this._totalNumberOfFilesReadWithCustomerError = value; }
        }

        // Check to see if TotalNumberOfFilesReadWithCustomerError property is set
        internal bool IsSetTotalNumberOfFilesReadWithCustomerError()
        {
            return this._totalNumberOfFilesReadWithCustomerError.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfImportedFiles. 
        /// <para>
        /// The number of files imported.
        /// </para>
        /// </summary>
        public long? TotalNumberOfImportedFiles
        {
            get { return this._totalNumberOfImportedFiles; }
            set { this._totalNumberOfImportedFiles = value; }
        }

        // Check to see if TotalNumberOfImportedFiles property is set
        internal bool IsSetTotalNumberOfImportedFiles()
        {
            return this._totalNumberOfImportedFiles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfResourcesImported. 
        /// <para>
        /// The number of resources imported.
        /// </para>
        /// </summary>
        public long? TotalNumberOfResourcesImported
        {
            get { return this._totalNumberOfResourcesImported; }
            set { this._totalNumberOfResourcesImported = value; }
        }

        // Check to see if TotalNumberOfResourcesImported property is set
        internal bool IsSetTotalNumberOfResourcesImported()
        {
            return this._totalNumberOfResourcesImported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfResourcesScanned. 
        /// <para>
        /// The number of resources scanned from the S3 input bucket.
        /// </para>
        /// </summary>
        public long? TotalNumberOfResourcesScanned
        {
            get { return this._totalNumberOfResourcesScanned; }
            set { this._totalNumberOfResourcesScanned = value; }
        }

        // Check to see if TotalNumberOfResourcesScanned property is set
        internal bool IsSetTotalNumberOfResourcesScanned()
        {
            return this._totalNumberOfResourcesScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfResourcesWithCustomerError. 
        /// <para>
        /// The number of resources that failed due to customer error.
        /// </para>
        /// </summary>
        public long? TotalNumberOfResourcesWithCustomerError
        {
            get { return this._totalNumberOfResourcesWithCustomerError; }
            set { this._totalNumberOfResourcesWithCustomerError = value; }
        }

        // Check to see if TotalNumberOfResourcesWithCustomerError property is set
        internal bool IsSetTotalNumberOfResourcesWithCustomerError()
        {
            return this._totalNumberOfResourcesWithCustomerError.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfScannedFiles. 
        /// <para>
        /// The number of files scanned from the S3 input bucket.
        /// </para>
        /// </summary>
        public long? TotalNumberOfScannedFiles
        {
            get { return this._totalNumberOfScannedFiles; }
            set { this._totalNumberOfScannedFiles = value; }
        }

        // Check to see if TotalNumberOfScannedFiles property is set
        internal bool IsSetTotalNumberOfScannedFiles()
        {
            return this._totalNumberOfScannedFiles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSizeOfScannedFilesInMB. 
        /// <para>
        /// The size (in MB) of files scanned from the S3 input bucket.
        /// </para>
        /// </summary>
        public double? TotalSizeOfScannedFilesInMB
        {
            get { return this._totalSizeOfScannedFilesInMB; }
            set { this._totalSizeOfScannedFilesInMB = value; }
        }

        // Check to see if TotalSizeOfScannedFilesInMB property is set
        internal bool IsSetTotalSizeOfScannedFilesInMB()
        {
            return this._totalSizeOfScannedFilesInMB.HasValue; 
        }

    }
}