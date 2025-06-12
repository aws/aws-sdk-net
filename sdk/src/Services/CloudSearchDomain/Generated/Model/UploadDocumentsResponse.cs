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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
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
    /// Contains the response to an <c>UploadDocuments</c> request.
    /// </summary>
    public partial class UploadDocumentsResponse : AmazonWebServiceResponse
    {
        private long? _adds;
        private long? _deletes;
        private string _status;
        private List<DocumentServiceWarning> _warnings = AWSConfigs.InitializeCollections ? new List<DocumentServiceWarning>() : null;

        /// <summary>
        /// Gets and sets the property Adds. 
        /// <para>
        /// The number of documents that were added to the search domain.
        /// </para>
        /// </summary>
        public long? Adds
        {
            get { return this._adds; }
            set { this._adds = value; }
        }

        // Check to see if Adds property is set
        internal bool IsSetAdds()
        {
            return this._adds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Deletes. 
        /// <para>
        /// The number of documents that were deleted from the search domain.
        /// </para>
        /// </summary>
        public long? Deletes
        {
            get { return this._deletes; }
            set { this._deletes = value; }
        }

        // Check to see if Deletes property is set
        internal bool IsSetDeletes()
        {
            return this._deletes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of an <c>UploadDocumentsRequest</c>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// Any warnings returned by the document service about the documents being uploaded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentServiceWarning> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && (this._warnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}