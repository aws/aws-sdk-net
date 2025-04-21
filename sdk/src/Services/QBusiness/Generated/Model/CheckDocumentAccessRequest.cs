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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the CheckDocumentAccess operation.
    /// Verifies if a user has access permissions for a specified document and returns the
    /// actual ACL attached to the document. Resolves user access on the document via user
    /// aliases and groups when verifying user access.
    /// </summary>
    public partial class CheckDocumentAccessRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private string _dataSourceId;
        private string _documentId;
        private string _indexId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application. This is required to identify the specific
        /// Amazon Q Business application context for the document access check.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The unique identifier of the data source. Identifies the specific data source from
        /// which the document originates. Should not be used when a document is uploaded directly
        /// with BatchPutDocument, as no dataSourceId is available or necessary. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The unique identifier of the document. Specifies which document's access permissions
        /// are being checked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1825)]
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The unique identifier of the index. Used to locate the correct index within the application
        /// where the document is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique identifier of the user. Used to check the access permissions for this specific
        /// user against the document's ACL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}