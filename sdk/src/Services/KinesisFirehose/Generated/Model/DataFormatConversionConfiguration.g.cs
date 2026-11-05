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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Specifies that you want Firehose to convert data from the JSON format to the Parquet
    /// or ORC format before writing it to Amazon S3. Firehose uses the serializer and deserializer
    /// that you specify, in addition to the column information from the Amazon Web Services
    /// Glue table, to deserialize your input data from JSON and then serialize it to the
    /// Parquet or ORC format. For more information, see <a href="https://docs.aws.amazon.com/firehose/latest/dev/record-format-conversion.html">Firehose
    /// Record Format Conversion</a>.
    /// </summary>
    public partial class DataFormatConversionConfiguration
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Defaults to <c>true</c>. Set it to <c>false</c> if you want to disable format conversion
        /// while preserving the configuration details.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property InputFormatConfiguration. 
        /// <para>
        /// Specifies the deserializer that you want Firehose to use to convert the format of
        /// your data from JSON. This parameter is required if <c>Enabled</c> is set to true.
        /// </para>
        /// </summary>
        public InputFormatConfiguration InputFormatConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputFormatConfiguration property is set.
        /// </summary>
        internal bool IsSetInputFormatConfiguration() => this.InputFormatConfiguration != null;

        /// <summary>
        /// Gets and sets the property OutputFormatConfiguration. 
        /// <para>
        /// Specifies the serializer that you want Firehose to use to convert the format of your
        /// data to the Parquet or ORC format. This parameter is required if <c>Enabled</c> is
        /// set to true.
        /// </para>
        /// </summary>
        public OutputFormatConfiguration OutputFormatConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormatConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputFormatConfiguration() => this.OutputFormatConfiguration != null;

        /// <summary>
        /// Gets and sets the property SchemaConfiguration. 
        /// <para>
        /// Specifies the Amazon Web Services Glue Data Catalog table that contains the column
        /// information. This parameter is required if <c>Enabled</c> is set to true.
        /// </para>
        /// </summary>
        public SchemaConfiguration SchemaConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SchemaConfiguration property is set.
        /// </summary>
        internal bool IsSetSchemaConfiguration() => this.SchemaConfiguration != null;
    }
}
