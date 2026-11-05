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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information about a schema conversion action.
    /// </summary>
    public partial class SchemaConversionRequest
    {
        /// <summary>
        /// Gets and sets the property Error.
        /// </summary>
        public ErrorDetails Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property ExportSqlDetails. 
        /// <para>
        /// The Amazon S3 location of the ZIP archive that contains the exported data definition
        /// language (DDL) scripts.
        /// </para>
        ///  <note> 
        /// <para>
        /// DMS populates this field only for the <c>DescribeMetadataModelExportsAsScript</c>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        public ExportSqlDetails ExportSqlDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExportSqlDetails property is set.
        /// </summary>
        internal bool IsSetExportSqlDetails() => this.ExportSqlDetails != null;

        /// <summary>
        /// Gets and sets the property MigrationProjectArn. 
        /// <para>
        /// The migration project ARN.
        /// </para>
        /// </summary>
        public string MigrationProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the MigrationProjectArn property is set.
        /// </summary>
        internal bool IsSetMigrationProjectArn() => this.MigrationProjectArn != null;

        /// <summary>
        /// Gets and sets the property Progress.
        /// </summary>
        public Progress Progress { get; set; }

        /// <summary>
        /// Checks to see if the Progress property is set.
        /// </summary>
        internal bool IsSetProgress() => this.Progress != null;

        /// <summary>
        /// Gets and sets the property RequestIdentifier. 
        /// <para>
        /// The identifier for the schema conversion action.
        /// </para>
        /// </summary>
        public string RequestIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RequestIdentifier property is set.
        /// </summary>
        internal bool IsSetRequestIdentifier() => this.RequestIdentifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The schema conversion operation status. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RECEIVED</c> – The operation is received but not yet queued for processing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> – The operation is queued or actively running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> – The operation completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The operation did not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELING</c> – The operation is being canceled. The operation might still succeed
        /// or fail before cancellation takes effect.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELED</c> – The operation was canceled before completion.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
