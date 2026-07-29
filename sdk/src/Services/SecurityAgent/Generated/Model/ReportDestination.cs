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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Destination for publishing scan reports to an integrated document provider.
    /// </summary>
    public partial class ReportDestination
    {
        private string _containerId;
        private string _documentId;
        private string _integrationId;
        private string _parentId;

        /// <summary>
        /// Gets and sets the property ContainerId. 
        /// <para>
        /// The container identifier where the report will be published.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContainerId
        {
            get { return this._containerId; }
            set { this._containerId = value; }
        }

        // Check to see if ContainerId property is set
        internal bool IsSetContainerId()
        {
            return this._containerId != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The existing document identifier to update instead of creating a new document.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IntegrationId. 
        /// <para>
        /// The integration identifier for the document provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IntegrationId
        {
            get { return this._integrationId; }
            set { this._integrationId = value; }
        }

        // Check to see if IntegrationId property is set
        internal bool IsSetIntegrationId()
        {
            return this._integrationId != null;
        }

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The parent document identifier under which the report will be created.
        /// </para>
        /// </summary>
        public string ParentId
        {
            get { return this._parentId; }
            set { this._parentId = value; }
        }

        // Check to see if ParentId property is set
        internal bool IsSetParentId()
        {
            return this._parentId != null;
        }

    }
}