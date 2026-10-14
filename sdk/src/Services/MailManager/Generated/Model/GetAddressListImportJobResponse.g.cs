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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// This is the response object from the GetAddressListImportJob operation.
    /// </summary>
    public partial class GetAddressListImportJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AddressListId. 
        /// <para>
        /// The unique identifier of the address list the import job was created for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AddressListId { get; set; }

        /// <summary>
        /// Checks to see if the AddressListId property is set.
        /// </summary>
        internal bool IsSetAddressListId() => this.AddressListId != null;

        /// <summary>
        /// Gets and sets the property CompletedTimestamp. 
        /// <para>
        /// The timestamp of when the import job was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CompletedTimestamp property is set.
        /// </summary>
        internal bool IsSetCompletedTimestamp() => this.CompletedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the import job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The reason for failure of an import job.
        /// </para>
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property FailedItemsCount. 
        /// <para>
        /// The number of input addresses that failed to be imported into the address list.
        /// </para>
        /// </summary>
        public int? FailedItemsCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedItemsCount property is set.
        /// </summary>
        internal bool IsSetFailedItemsCount() => this.FailedItemsCount.HasValue;

        /// <summary>
        /// Gets and sets the property ImportDataFormat. 
        /// <para>
        /// The format of the input for an import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImportDataFormat ImportDataFormat { get; set; }

        /// <summary>
        /// Checks to see if the ImportDataFormat property is set.
        /// </summary>
        internal bool IsSetImportDataFormat() => this.ImportDataFormat != null;

        /// <summary>
        /// Gets and sets the property ImportedItemsCount. 
        /// <para>
        /// The number of input addresses successfully imported into the address list.
        /// </para>
        /// </summary>
        public int? ImportedItemsCount { get; set; }

        /// <summary>
        /// Checks to see if the ImportedItemsCount property is set.
        /// </summary>
        internal bool IsSetImportedItemsCount() => this.ImportedItemsCount.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-friendly name for the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// The pre-signed URL target for uploading the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string PreSignedUrl { get; set; }

        /// <summary>
        /// Checks to see if the PreSignedUrl property is set.
        /// </summary>
        internal bool IsSetPreSignedUrl() => this.PreSignedUrl != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The timestamp of when the import job was started.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImportJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
