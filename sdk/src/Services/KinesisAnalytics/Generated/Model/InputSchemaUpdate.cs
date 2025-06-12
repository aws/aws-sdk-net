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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Describes updates for the application's input schema.
    /// </summary>
    public partial class InputSchemaUpdate
    {
        private List<RecordColumn> _recordColumnUpdates = AWSConfigs.InitializeCollections ? new List<RecordColumn>() : null;
        private string _recordEncodingUpdate;
        private RecordFormat _recordFormatUpdate;

        /// <summary>
        /// Gets and sets the property RecordColumnUpdates. 
        /// <para>
        /// A list of <c>RecordColumn</c> objects. Each object describes the mapping of the streaming
        /// source element to the corresponding column in the in-application stream. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<RecordColumn> RecordColumnUpdates
        {
            get { return this._recordColumnUpdates; }
            set { this._recordColumnUpdates = value; }
        }

        // Check to see if RecordColumnUpdates property is set
        internal bool IsSetRecordColumnUpdates()
        {
            return this._recordColumnUpdates != null && (this._recordColumnUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordEncodingUpdate. 
        /// <para>
        /// Specifies the encoding of the records in the streaming source. For example, UTF-8.
        /// </para>
        /// </summary>
        public string RecordEncodingUpdate
        {
            get { return this._recordEncodingUpdate; }
            set { this._recordEncodingUpdate = value; }
        }

        // Check to see if RecordEncodingUpdate property is set
        internal bool IsSetRecordEncodingUpdate()
        {
            return this._recordEncodingUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property RecordFormatUpdate. 
        /// <para>
        /// Specifies the format of the records on the streaming source.
        /// </para>
        /// </summary>
        public RecordFormat RecordFormatUpdate
        {
            get { return this._recordFormatUpdate; }
            set { this._recordFormatUpdate = value; }
        }

        // Check to see if RecordFormatUpdate property is set
        internal bool IsSetRecordFormatUpdate()
        {
            return this._recordFormatUpdate != null;
        }

    }
}