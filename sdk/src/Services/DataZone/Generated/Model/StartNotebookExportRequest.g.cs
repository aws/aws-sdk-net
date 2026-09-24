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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the StartNotebookExport operation. Starts a notebook
    /// export in Amazon SageMaker Unified Studio. This operation exports a notebook to a
    /// specified file format and stores the output in Amazon Simple Storage Service.
    /// </summary>
    public partial class StartNotebookExportRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request. This field
        /// is automatically populated if not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon SageMaker Unified Studio domain in which to export the
        /// notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The file format for the notebook export. Valid values are <c>PDF</c> and <c>IPYNB</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileFormat FileFormat { get; set; }

        /// <summary>
        /// Checks to see if the FileFormat property is set.
        /// </summary>
        internal bool IsSetFileFormat() => this.FileFormat != null;

        /// <summary>
        /// Gets and sets the property NotebookIdentifier. 
        /// <para>
        /// The identifier of the notebook to export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NotebookIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the NotebookIdentifier property is set.
        /// </summary>
        internal bool IsSetNotebookIdentifier() => this.NotebookIdentifier != null;

        /// <summary>
        /// Gets and sets the property OwningProjectIdentifier. 
        /// <para>
        /// The identifier of the project that owns the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwningProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetOwningProjectIdentifier() => this.OwningProjectIdentifier != null;
    }
}
