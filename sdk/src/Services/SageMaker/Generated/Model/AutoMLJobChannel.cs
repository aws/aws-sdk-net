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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A channel is a named input source that training algorithms can consume. This channel
    /// is used for AutoML jobs V2 (jobs created by calling <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJobV2.html">CreateAutoMLJobV2</a>).
    /// </summary>
    public partial class AutoMLJobChannel
    {
        private AutoMLChannelType _channelType;
        private CompressionType _compressionType;
        private string _contentType;
        private AutoMLDataSource _dataSource;

        /// <summary>
        /// Gets and sets the property ChannelType. 
        /// <para>
        /// The type of channel. Defines whether the data are used for training or validation.
        /// The default value is <code>training</code>. Channels for <code>training</code> and
        /// <code>validation</code> must share the same <code>ContentType</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// The type of channel defaults to <code>training</code> for the time-series forecasting
        /// problem type.
        /// </para>
        ///  </note>
        /// </summary>
        public AutoMLChannelType ChannelType
        {
            get { return this._channelType; }
            set { this._channelType = value; }
        }

        // Check to see if ChannelType property is set
        internal bool IsSetChannelType()
        {
            return this._channelType != null;
        }

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// The allowed compression types depend on the input format and problem type. We allow
        /// the compression type <code>Gzip</code> for <code>S3Prefix</code> inputs on tabular
        /// data only. For all other inputs, the compression type should be <code>None</code>.
        /// If no compression type is provided, we default to <code>None</code>.
        /// </para>
        /// </summary>
        public CompressionType CompressionType
        {
            get { return this._compressionType; }
            set { this._compressionType = value; }
        }

        // Check to see if CompressionType property is set
        internal bool IsSetCompressionType()
        {
            return this._compressionType != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the data from the input source. The following are the allowed
        /// content types for different problems:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For tabular problem types: <code>text/csv;header=present</code> or <code>x-application/vnd.amazon+parquet</code>.
        /// The default value is <code>text/csv;header=present</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For image classification: <code>image/png</code>, <code>image/jpeg</code>, or <code>image/*</code>.
        /// The default value is <code>image/*</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For text classification: <code>text/csv;header=present</code> or <code>x-application/vnd.amazon+parquet</code>.
        /// The default value is <code>text/csv;header=present</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For time-series forecasting: <code>text/csv;header=present</code> or <code>x-application/vnd.amazon+parquet</code>.
        /// The default value is <code>text/csv;header=present</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data source for an AutoML channel (Required).
        /// </para>
        /// </summary>
        public AutoMLDataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

    }
}