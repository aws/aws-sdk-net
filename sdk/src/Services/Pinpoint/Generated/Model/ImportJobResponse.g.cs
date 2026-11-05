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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the status and settings of a job that imports endpoint
    /// definitions from one or more files. The files can be stored in an Amazon Simple Storage
    /// Service (Amazon S3) bucket or uploaded directly from a computer by using the Amazon
    /// Pinpoint console.
    /// </summary>
    public partial class ImportJobResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that's associated with the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property CompletedPieces. 
        /// <para>
        /// The number of pieces that were processed successfully (completed) by the import job,
        /// as of the time of the request.
        /// </para>
        /// </summary>
        public int? CompletedPieces { get; set; }

        /// <summary>
        /// Checks to see if the CompletedPieces property is set.
        /// </summary>
        internal bool IsSetCompletedPieces() => this.CompletedPieces.HasValue;

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the import job was completed.
        /// </para>
        /// </summary>
        public string CompletionDate { get; set; }

        /// <summary>
        /// Checks to see if the CompletionDate property is set.
        /// </summary>
        internal bool IsSetCompletionDate() => this.CompletionDate != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the import job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The resource settings that apply to the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImportJobResource Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property FailedPieces. 
        /// <para>
        /// The number of pieces that weren't processed successfully (failed) by the import job,
        /// as of the time of the request.
        /// </para>
        /// </summary>
        public int? FailedPieces { get; set; }

        /// <summary>
        /// Checks to see if the FailedPieces property is set.
        /// </summary>
        internal bool IsSetFailedPieces() => this.FailedPieces.HasValue;

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// An array of entries, one for each of the first 100 entries that weren't processed
        /// successfully (failed) by the import job, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Failures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Failures property is set.
        /// </summary>
        internal bool IsSetFailures() => this.Failures != null && (this.Failures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The status of the import job. The job status is FAILED if Amazon Pinpoint wasn't able
        /// to process one or more pieces in the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property TotalFailures. 
        /// <para>
        /// The total number of endpoint definitions that weren't processed successfully (failed)
        /// by the import job, typically because an error, such as a syntax error, occurred.
        /// </para>
        /// </summary>
        public int? TotalFailures { get; set; }

        /// <summary>
        /// Checks to see if the TotalFailures property is set.
        /// </summary>
        internal bool IsSetTotalFailures() => this.TotalFailures.HasValue;

        /// <summary>
        /// Gets and sets the property TotalPieces. 
        /// <para>
        /// The total number of pieces that must be processed to complete the import job. Each
        /// piece consists of an approximately equal portion of the endpoint definitions that
        /// are part of the import job.
        /// </para>
        /// </summary>
        public int? TotalPieces { get; set; }

        /// <summary>
        /// Checks to see if the TotalPieces property is set.
        /// </summary>
        internal bool IsSetTotalPieces() => this.TotalPieces.HasValue;

        /// <summary>
        /// Gets and sets the property TotalProcessed. 
        /// <para>
        /// The total number of endpoint definitions that were processed by the import job.
        /// </para>
        /// </summary>
        public int? TotalProcessed { get; set; }

        /// <summary>
        /// Checks to see if the TotalProcessed property is set.
        /// </summary>
        internal bool IsSetTotalProcessed() => this.TotalProcessed.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The job type. This value is IMPORT for import jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
