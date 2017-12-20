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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStream operation.
    /// Creates a stream for delivering one or more large files in chunks over MQTT. A stream
    /// transports data bytes in chunks or blocks packaged as MQTT messages from a source
    /// like S3. You can have one or more files associated with a stream. The total size of
    /// a file associated with the stream cannot exceed more than 2 MB. The stream will be
    /// created with version 0. If a stream is created with the same streamID as a stream
    /// that existed and was deleted within last 90 days, we will resurrect that old stream
    /// by incrementing the version by 1.
    /// </summary>
    public partial class CreateStreamRequest : AmazonIoTRequest
    {
        private string _description;
        private List<StreamFile> _files = new List<StreamFile>();
        private string _roleArn;
        private string _streamId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the stream.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Files. 
        /// <para>
        /// The files to stream.
        /// </para>
        /// </summary>
        public List<StreamFile> Files
        {
            get { return this._files; }
            set { this._files = value; }
        }

        // Check to see if Files property is set
        internal bool IsSetFiles()
        {
            return this._files != null && this._files.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An IAM role that allows the IoT service principal assumes to access your S3 files.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// The stream ID.
        /// </para>
        /// </summary>
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

    }
}