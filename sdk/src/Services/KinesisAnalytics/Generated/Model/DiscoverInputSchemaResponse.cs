/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DiscoverInputSchemaResponse : AmazonWebServiceResponse
    {
        private SourceSchema _inputSchema;
        private List<List<string>> _parsedInputRecords = new List<List<string>>();
        private List<string> _processedInputRecords = new List<string>();
        private List<string> _rawInputRecords = new List<string>();

        /// <summary>
        /// Gets and sets the property InputSchema. 
        /// <para>
        /// Schema inferred from the streaming source. It identifies the format of the data in
        /// the streaming source and how each data element maps to corresponding columns in the
        /// in-application stream that you can create.
        /// </para>
        /// </summary>
        public SourceSchema InputSchema
        {
            get { return this._inputSchema; }
            set { this._inputSchema = value; }
        }

        // Check to see if InputSchema property is set
        internal bool IsSetInputSchema()
        {
            return this._inputSchema != null;
        }

        /// <summary>
        /// Gets and sets the property ParsedInputRecords. 
        /// <para>
        /// An array of elements, where each element corresponds to a row in a stream record (a
        /// stream record can have more than one row).
        /// </para>
        /// </summary>
        public List<List<string>> ParsedInputRecords
        {
            get { return this._parsedInputRecords; }
            set { this._parsedInputRecords = value; }
        }

        // Check to see if ParsedInputRecords property is set
        internal bool IsSetParsedInputRecords()
        {
            return this._parsedInputRecords != null && this._parsedInputRecords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProcessedInputRecords. 
        /// <para>
        /// Stream data that was modified by the processor specified in the <code>InputProcessingConfiguration</code>
        /// parameter.
        /// </para>
        /// </summary>
        public List<string> ProcessedInputRecords
        {
            get { return this._processedInputRecords; }
            set { this._processedInputRecords = value; }
        }

        // Check to see if ProcessedInputRecords property is set
        internal bool IsSetProcessedInputRecords()
        {
            return this._processedInputRecords != null && this._processedInputRecords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RawInputRecords. 
        /// <para>
        /// Raw stream data that was sampled to infer the schema.
        /// </para>
        /// </summary>
        public List<string> RawInputRecords
        {
            get { return this._rawInputRecords; }
            set { this._rawInputRecords = value; }
        }

        // Check to see if RawInputRecords property is set
        internal bool IsSetRawInputRecords()
        {
            return this._rawInputRecords != null && this._rawInputRecords.Count > 0; 
        }

    }
}