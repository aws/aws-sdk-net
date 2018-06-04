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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A channel is a named input source that training algorithms can consume.
    /// </summary>
    public partial class Channel
    {
        private string _channelName;
        private CompressionType _compressionType;
        private string _contentType;
        private DataSource _dataSource;
        private RecordWrapper _recordWrapperType;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel. 
        /// </para>
        /// </summary>
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// If training data is compressed, the compression type. The default value is <code>None</code>.
        /// <code>CompressionType</code> is used only in Pipe input mode. In File mode, leave
        /// this field unset or set it to None.
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
        /// The MIME type of the data.
        /// </para>
        /// </summary>
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
        /// The location of the channel data.
        /// </para>
        /// </summary>
        public DataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property RecordWrapperType.  
        /// <para>
        /// Specify RecordIO as the value when input data is in raw format but the training algorithm
        /// requires the RecordIO format, in which case, Amazon SageMaker wraps each individual
        /// S3 object in a RecordIO record. If the input data is already in RecordIO format, you
        /// don't need to set this attribute. For more information, see <a href="https://mxnet.incubator.apache.org/how_to/recordio.html?highlight=im2rec">Create
        /// a Dataset Using RecordIO</a>. 
        /// </para>
        ///  
        /// <para>
        /// In FILE mode, leave this field unset or set it to None.
        /// </para>
        /// </summary>
        public RecordWrapper RecordWrapperType
        {
            get { return this._recordWrapperType; }
            set { this._recordWrapperType = value; }
        }

        // Check to see if RecordWrapperType property is set
        internal bool IsSetRecordWrapperType()
        {
            return this._recordWrapperType != null;
        }

    }
}