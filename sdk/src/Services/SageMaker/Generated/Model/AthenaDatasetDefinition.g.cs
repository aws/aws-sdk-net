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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration for Athena Dataset Definition input.
    /// </summary>
    public partial class AthenaDatasetDefinition
    {
        /// <summary>
        /// Gets and sets the property Catalog.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property Database.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// Amazon SageMaker uses to encrypt data generated from an Athena query execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property OutputCompression.
        /// </summary>
        public AthenaResultCompressionType OutputCompression { get; set; }

        /// <summary>
        /// Checks to see if the OutputCompression property is set.
        /// </summary>
        internal bool IsSetOutputCompression() => this.OutputCompression != null;

        /// <summary>
        /// Gets and sets the property OutputFormat.
        /// </summary>
        [AWSProperty(Required = true)]
        public AthenaResultFormat OutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormat property is set.
        /// </summary>
        internal bool IsSetOutputFormat() => this.OutputFormat != null;

        /// <summary>
        /// Gets and sets the property OutputS3Uri. 
        /// <para>
        /// The location in Amazon S3 where Athena query results are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string OutputS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Uri property is set.
        /// </summary>
        internal bool IsSetOutputS3Uri() => this.OutputS3Uri != null;

        /// <summary>
        /// Gets and sets the property QueryString.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property WorkGroup.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string WorkGroup { get; set; }

        /// <summary>
        /// Checks to see if the WorkGroup property is set.
        /// </summary>
        internal bool IsSetWorkGroup() => this.WorkGroup != null;
    }
}
