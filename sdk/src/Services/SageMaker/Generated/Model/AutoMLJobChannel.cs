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

#pragma warning disable CS0612,CS0618,CS1570
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
        /// The default value is <c>training</c>. Channels for <c>training</c> and <c>validation</c>
        /// must share the same <c>ContentType</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// The type of channel defaults to <c>training</c> for the time-series forecasting problem
        /// type.
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
        /// the compression type <c>Gzip</c> for <c>S3Prefix</c> inputs on tabular data only.
        /// For all other inputs, the compression type should be <c>None</c>. If no compression
        /// type is provided, we default to <c>None</c>.
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
        /// For tabular problem types: <c>text/csv;header=present</c> or <c>x-application/vnd.amazon+parquet</c>.
        /// The default value is <c>text/csv;header=present</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For image classification: <c>image/png</c>, <c>image/jpeg</c>, or <c>image/*</c>.
        /// The default value is <c>image/*</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For text classification: <c>text/csv;header=present</c> or <c>x-application/vnd.amazon+parquet</c>.
        /// The default value is <c>text/csv;header=present</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For time-series forecasting: <c>text/csv;header=present</c> or <c>x-application/vnd.amazon+parquet</c>.
        /// The default value is <c>text/csv;header=present</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For text generation (LLMs fine-tuning): <c>text/csv;header=present</c> or <c>x-application/vnd.amazon+parquet</c>.
        /// The default value is <c>text/csv;header=present</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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