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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateExportJob operation. Creates an export job
    /// for a data source and destination. <para> You can execute this operation no more than
    /// once per second. </para>
    /// </summary>
    public partial class CreateExportJobRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property ExportDataSource. 
        /// <para>
        /// The data source for the export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportDataSource ExportDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ExportDataSource property is set.
        /// </summary>
        internal bool IsSetExportDataSource() => this.ExportDataSource != null;

        /// <summary>
        /// Gets and sets the property ExportDestination. 
        /// <para>
        /// The destination for the export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportDestination ExportDestination { get; set; }

        /// <summary>
        /// Checks to see if the ExportDestination property is set.
        /// </summary>
        internal bool IsSetExportDestination() => this.ExportDestination != null;
    }
}
