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
    /// A data source used for training or inference that is in addition to the input dataset
    /// or model data.
    /// </summary>
    public partial class AdditionalS3DataSource
    {
        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// The type of compression used for an additional data source used in inference or training.
        /// Specify <c>None</c> if your additional data source is not compressed.
        /// </para>
        /// </summary>
        public CompressionType CompressionType { get; set; }

        /// <summary>
        /// Checks to see if the CompressionType property is set.
        /// </summary>
        internal bool IsSetCompressionType() => this.CompressionType != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The ETag associated with S3 URI.
        /// </para>
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property S3DataType. 
        /// <para>
        /// The data type of the additional data source that you specify for use in inference
        /// or training. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AdditionalS3DataSourceDataType S3DataType { get; set; }

        /// <summary>
        /// Checks to see if the S3DataType property is set.
        /// </summary>
        internal bool IsSetS3DataType() => this.S3DataType != null;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The uniform resource identifier (URI) used to identify an additional data source used
        /// in inference or training.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string S3Uri { get; set; }

        /// <summary>
        /// Checks to see if the S3Uri property is set.
        /// </summary>
        internal bool IsSetS3Uri() => this.S3Uri != null;
    }
}
