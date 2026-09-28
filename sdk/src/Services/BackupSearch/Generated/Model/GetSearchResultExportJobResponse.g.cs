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

namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// This is the response object from the GetSearchResultExportJob operation.
    /// </summary>
    public partial class GetSearchResultExportJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time that an export job completed, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CreationTime</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that an export job was created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CreationTime</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExportJobArn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) that uniquely identifies the export job.
        /// </para>
        /// </summary>
        public string ExportJobArn { get; set; }

        /// <summary>
        /// Checks to see if the ExportJobArn property is set.
        /// </summary>
        internal bool IsSetExportJobArn() => this.ExportJobArn != null;

        /// <summary>
        /// Gets and sets the property ExportJobIdentifier. 
        /// <para>
        /// This is the unique string that identifies the specified export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExportJobIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ExportJobIdentifier property is set.
        /// </summary>
        internal bool IsSetExportJobIdentifier() => this.ExportJobIdentifier != null;

        /// <summary>
        /// Gets and sets the property ExportSpecification. 
        /// <para>
        /// The export specification consists of the destination S3 bucket to which the search
        /// results were exported, along with the destination prefix.
        /// </para>
        /// </summary>
        public ExportSpecification ExportSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ExportSpecification property is set.
        /// </summary>
        internal bool IsSetExportSpecification() => this.ExportSpecification != null;

        /// <summary>
        /// Gets and sets the property SearchJobArn. 
        /// <para>
        /// The unique string that identifies the Amazon Resource Name (ARN) of the specified
        /// search job.
        /// </para>
        /// </summary>
        public string SearchJobArn { get; set; }

        /// <summary>
        /// Checks to see if the SearchJobArn property is set.
        /// </summary>
        internal bool IsSetSearchJobArn() => this.SearchJobArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This is the current status of the export job.
        /// </para>
        /// </summary>
        public ExportJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A status message is a string that is returned for search job with a status of <c>FAILED</c>,
        /// along with steps to remedy and retry the operation.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
