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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Specifies that you want Kinesis Data Firehose to convert data from the JSON format
    /// to the Parquet or ORC format before writing it to Amazon S3. Kinesis Data Firehose
    /// uses the serializer and deserializer that you specify, in addition to the column information
    /// from the Amazon Web Services Glue table, to deserialize your input data from JSON
    /// and then serialize it to the Parquet or ORC format. For more information, see <a href="https://docs.aws.amazon.com/firehose/latest/dev/record-format-conversion.html">Kinesis
    /// Data Firehose Record Format Conversion</a>.
    /// </summary>
    public partial class DataFormatConversionConfiguration
    {
        private bool? _enabled;
        private InputFormatConfiguration _inputFormatConfiguration;
        private OutputFormatConfiguration _outputFormatConfiguration;
        private SchemaConfiguration _schemaConfiguration;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Defaults to <code>true</code>. Set it to <code>false</code> if you want to disable
        /// format conversion while preserving the configuration details.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputFormatConfiguration. 
        /// <para>
        /// Specifies the deserializer that you want Kinesis Data Firehose to use to convert the
        /// format of your data from JSON. This parameter is required if <code>Enabled</code>
        /// is set to true.
        /// </para>
        /// </summary>
        public InputFormatConfiguration InputFormatConfiguration
        {
            get { return this._inputFormatConfiguration; }
            set { this._inputFormatConfiguration = value; }
        }

        // Check to see if InputFormatConfiguration property is set
        internal bool IsSetInputFormatConfiguration()
        {
            return this._inputFormatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OutputFormatConfiguration. 
        /// <para>
        /// Specifies the serializer that you want Kinesis Data Firehose to use to convert the
        /// format of your data to the Parquet or ORC format. This parameter is required if <code>Enabled</code>
        /// is set to true.
        /// </para>
        /// </summary>
        public OutputFormatConfiguration OutputFormatConfiguration
        {
            get { return this._outputFormatConfiguration; }
            set { this._outputFormatConfiguration = value; }
        }

        // Check to see if OutputFormatConfiguration property is set
        internal bool IsSetOutputFormatConfiguration()
        {
            return this._outputFormatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaConfiguration. 
        /// <para>
        /// Specifies the Amazon Web Services Glue Data Catalog table that contains the column
        /// information. This parameter is required if <code>Enabled</code> is set to true.
        /// </para>
        /// </summary>
        public SchemaConfiguration SchemaConfiguration
        {
            get { return this._schemaConfiguration; }
            set { this._schemaConfiguration = value; }
        }

        // Check to see if SchemaConfiguration property is set
        internal bool IsSetSchemaConfiguration()
        {
            return this._schemaConfiguration != null;
        }

    }
}