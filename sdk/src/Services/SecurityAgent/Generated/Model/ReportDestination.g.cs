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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Destination for publishing scan reports to an integrated document provider.
    /// </summary>
    public partial class ReportDestination
    {
        /// <summary>
        /// Gets and sets the property ContainerId. 
        /// <para>
        /// The container identifier where the report will be published.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContainerId { get; set; }

        /// <summary>
        /// Checks to see if the ContainerId property is set.
        /// </summary>
        internal bool IsSetContainerId() => this.ContainerId != null;

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The existing document identifier to update instead of creating a new document.
        /// </para>
        /// </summary>
        public string DocumentId { get; set; }

        /// <summary>
        /// Checks to see if the DocumentId property is set.
        /// </summary>
        internal bool IsSetDocumentId() => this.DocumentId != null;

        /// <summary>
        /// Gets and sets the property IntegrationId. 
        /// <para>
        /// The integration identifier for the document provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The parent document identifier under which the report will be created.
        /// </para>
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// Checks to see if the ParentId property is set.
        /// </summary>
        internal bool IsSetParentId() => this.ParentId != null;
    }
}
