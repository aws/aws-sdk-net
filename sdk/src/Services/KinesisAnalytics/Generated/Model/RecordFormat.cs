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
    /// Describes the record format and relevant mapping information that should be applied
    /// to schematize the records on the stream.
    /// </summary>
    public partial class RecordFormat
    {
        private MappingParameters _mappingParameters;
        private RecordFormatType _recordFormatType;

        /// <summary>
        /// Gets and sets the property MappingParameters.
        /// </summary>
        public MappingParameters MappingParameters
        {
            get { return this._mappingParameters; }
            set { this._mappingParameters = value; }
        }

        // Check to see if MappingParameters property is set
        internal bool IsSetMappingParameters()
        {
            return this._mappingParameters != null;
        }

        /// <summary>
        /// Gets and sets the property RecordFormatType. 
        /// <para>
        /// The type of record format.
        /// </para>
        /// </summary>
        public RecordFormatType RecordFormatType
        {
            get { return this._recordFormatType; }
            set { this._recordFormatType = value; }
        }

        // Check to see if RecordFormatType property is set
        internal bool IsSetRecordFormatType()
        {
            return this._recordFormatType != null;
        }

    }
}