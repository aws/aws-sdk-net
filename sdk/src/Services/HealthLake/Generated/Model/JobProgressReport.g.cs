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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The progress report for the import job.
    /// </summary>
    public partial class JobProgressReport
    {
        /// <summary>
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The transaction rate the import job is processed at.
        /// </para>
        /// </summary>
        public double? Throughput { get; set; }

        /// <summary>
        /// Checks to see if the Throughput property is set.
        /// </summary>
        internal bool IsSetThroughput() => this.Throughput.HasValue;

        /// <summary>
        /// Gets and sets the property TotalFilesConverted. 
        /// <para>
        /// Number of CCDA files successfully transformed during the import's transformation phase.
        /// Populated only for import jobs that use the two-Step-Function (transformation + ingestion)
        /// flow; null for legacy single-SF imports and for pure FHIR imports that skip transformation.
        /// </para>
        /// </summary>
        public long? TotalFilesConverted { get; set; }

        /// <summary>
        /// Checks to see if the TotalFilesConverted property is set.
        /// </summary>
        internal bool IsSetTotalFilesConverted() => this.TotalFilesConverted.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfFilesReadWithCustomerError. 
        /// <para>
        /// The number of files that failed to be read from the Amazon S3 input bucket due to
        /// customer error.
        /// </para>
        /// </summary>
        public long? TotalNumberOfFilesReadWithCustomerError { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfFilesReadWithCustomerError property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfFilesReadWithCustomerError() => this.TotalNumberOfFilesReadWithCustomerError.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfImportedFiles. 
        /// <para>
        /// The number of files imported.
        /// </para>
        /// </summary>
        public long? TotalNumberOfImportedFiles { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfImportedFiles property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfImportedFiles() => this.TotalNumberOfImportedFiles.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfImportedNonFhirFiles. 
        /// <para>
        /// The number of non-FHIR files imported.
        /// </para>
        /// </summary>
        public long? TotalNumberOfImportedNonFhirFiles { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfImportedNonFhirFiles property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfImportedNonFhirFiles() => this.TotalNumberOfImportedNonFhirFiles.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfNonFhirFilesReadWithCustomerError. 
        /// <para>
        /// The number of non-FHIR files that failed to be read from the Amazon S3 input bucket
        /// due to customer error.
        /// </para>
        /// </summary>
        public long? TotalNumberOfNonFhirFilesReadWithCustomerError { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfNonFhirFilesReadWithCustomerError property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfNonFhirFilesReadWithCustomerError() => this.TotalNumberOfNonFhirFilesReadWithCustomerError.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfNonFhirResourcesImported. 
        /// <para>
        /// The number of non-FHIR resources imported.
        /// </para>
        /// </summary>
        public long? TotalNumberOfNonFhirResourcesImported { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfNonFhirResourcesImported property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfNonFhirResourcesImported() => this.TotalNumberOfNonFhirResourcesImported.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfNonFhirResourcesScanned. 
        /// <para>
        /// The number of non-FHIR resources scanned from the Amazon S3 input bucket.
        /// </para>
        /// </summary>
        public long? TotalNumberOfNonFhirResourcesScanned { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfNonFhirResourcesScanned property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfNonFhirResourcesScanned() => this.TotalNumberOfNonFhirResourcesScanned.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfNonFhirResourcesWithCustomerError. 
        /// <para>
        /// The number of non-FHIR resources that failed due to customer error.
        /// </para>
        /// </summary>
        public long? TotalNumberOfNonFhirResourcesWithCustomerError { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfNonFhirResourcesWithCustomerError property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfNonFhirResourcesWithCustomerError() => this.TotalNumberOfNonFhirResourcesWithCustomerError.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfResourcesImported. 
        /// <para>
        /// The number of resources imported.
        /// </para>
        /// </summary>
        public long? TotalNumberOfResourcesImported { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfResourcesImported property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfResourcesImported() => this.TotalNumberOfResourcesImported.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfResourcesScanned. 
        /// <para>
        /// The number of resources scanned from the Amazon S3 input bucket.
        /// </para>
        /// </summary>
        public long? TotalNumberOfResourcesScanned { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfResourcesScanned property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfResourcesScanned() => this.TotalNumberOfResourcesScanned.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfResourcesWithCustomerError. 
        /// <para>
        /// The number of resources that failed due to customer error.
        /// </para>
        /// </summary>
        public long? TotalNumberOfResourcesWithCustomerError { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfResourcesWithCustomerError property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfResourcesWithCustomerError() => this.TotalNumberOfResourcesWithCustomerError.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfScannedFiles. 
        /// <para>
        /// The number of files scanned from the Amazon S3 input bucket.
        /// </para>
        /// </summary>
        public long? TotalNumberOfScannedFiles { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfScannedFiles property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfScannedFiles() => this.TotalNumberOfScannedFiles.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfScannedNonFhirFiles. 
        /// <para>
        /// The number of non-FHIR files scanned from the Amazon S3 input bucket.
        /// </para>
        /// </summary>
        public long? TotalNumberOfScannedNonFhirFiles { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfScannedNonFhirFiles property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfScannedNonFhirFiles() => this.TotalNumberOfScannedNonFhirFiles.HasValue;

        /// <summary>
        /// Gets and sets the property TotalResourcesGenerated. 
        /// <para>
        /// Number of FHIR resources produced by the transformation phase. Populated only for
        /// import jobs that use the two-Step-Function flow; null for legacy single-SF imports
        /// and for pure FHIR imports.
        /// </para>
        /// </summary>
        public long? TotalResourcesGenerated { get; set; }

        /// <summary>
        /// Checks to see if the TotalResourcesGenerated property is set.
        /// </summary>
        internal bool IsSetTotalResourcesGenerated() => this.TotalResourcesGenerated.HasValue;

        /// <summary>
        /// Gets and sets the property TotalSizeOfScannedFilesInMB. 
        /// <para>
        /// The size (in MB) of files scanned from the Amazon S3 input bucket.
        /// </para>
        /// </summary>
        public double? TotalSizeOfScannedFilesInMB { get; set; }

        /// <summary>
        /// Checks to see if the TotalSizeOfScannedFilesInMB property is set.
        /// </summary>
        internal bool IsSetTotalSizeOfScannedFilesInMB() => this.TotalSizeOfScannedFilesInMB.HasValue;

        /// <summary>
        /// Gets and sets the property TotalSizeOfScannedNonFhirFilesInMB. 
        /// <para>
        /// The size (in MB) of non-FHIR files scanned from the Amazon S3 input bucket.
        /// </para>
        /// </summary>
        public double? TotalSizeOfScannedNonFhirFilesInMB { get; set; }

        /// <summary>
        /// Checks to see if the TotalSizeOfScannedNonFhirFilesInMB property is set.
        /// </summary>
        internal bool IsSetTotalSizeOfScannedNonFhirFilesInMB() => this.TotalSizeOfScannedNonFhirFilesInMB.HasValue;
    }
}
