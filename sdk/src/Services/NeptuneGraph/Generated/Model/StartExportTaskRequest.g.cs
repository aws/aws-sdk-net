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

namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Container for the parameters to the StartExportTask operation. Export data from an
    /// existing Neptune Analytics graph to Amazon S3. The graph state should be <c>AVAILABLE</c>.
    /// </summary>
    public partial class StartExportTaskRequest : AmazonNeptuneGraphRequest
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon S3 URI where data will be exported to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property ExportFilter. 
        /// <para>
        /// The export filter of the export task.
        /// </para>
        /// </summary>
        public ExportFilter ExportFilter { get; set; }

        /// <summary>
        /// Checks to see if the ExportFilter property is set.
        /// </summary>
        internal bool IsSetExportFilter() => this.ExportFilter != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property GraphIdentifier. 
        /// <para>
        /// The source graph identifier of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GraphIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GraphIdentifier property is set.
        /// </summary>
        internal bool IsSetGraphIdentifier() => this.GraphIdentifier != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The KMS key identifier of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property ParquetType. 
        /// <para>
        /// The parquet type of the export task.
        /// </para>
        /// </summary>
        public ParquetType ParquetType { get; set; }

        /// <summary>
        /// Checks to see if the ParquetType property is set.
        /// </summary>
        internal bool IsSetParquetType() => this.ParquetType != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that will allow data to be exported to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be applied to the export task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
