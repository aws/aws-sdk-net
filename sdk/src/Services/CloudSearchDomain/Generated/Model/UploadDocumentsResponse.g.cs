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

namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// This is the response object from the UploadDocuments operation.
    /// </summary>
    public partial class UploadDocumentsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Adds. 
        /// <para>
        /// The number of documents that were added to the search domain.
        /// </para>
        /// </summary>
        public long? Adds { get; set; }

        /// <summary>
        /// Checks to see if the Adds property is set.
        /// </summary>
        internal bool IsSetAdds() => this.Adds.HasValue;

        /// <summary>
        /// Gets and sets the property Deletes. 
        /// <para>
        /// The number of documents that were deleted from the search domain.
        /// </para>
        /// </summary>
        public long? Deletes { get; set; }

        /// <summary>
        /// Checks to see if the Deletes property is set.
        /// </summary>
        internal bool IsSetDeletes() => this.Deletes.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of an <c>UploadDocumentsRequest</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// Any warnings returned by the document service about the documents being uploaded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentServiceWarning> Warnings { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentServiceWarning>() : null;

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null && (this.Warnings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
