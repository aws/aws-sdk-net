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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteStream operation.
    /// Deletes a Kinesis video stream and the data contained in the stream. 
    /// 
    ///  
    /// <para>
    /// This method marks the stream for deletion, and makes the data in the stream inaccessible
    /// immediately.
    /// </para>
    ///  
    /// <para>
    ///  
    /// </para>
    ///  
    /// <para>
    ///  To ensure that you have the latest version of the stream before deleting it, you
    /// can specify the stream version. Kinesis Video Streams assigns a version to each stream.
    /// When you update a stream, Kinesis Video Streams assigns a new version number. To get
    /// the latest stream version, use the <code>DescribeStream</code> API. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <code>KinesisVideo:DeleteStream</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class DeleteStreamRequest : AmazonKinesisVideoRequest
    {
        private string _currentVersion;
        private string _streamARN;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// Optional: The version of the stream that you want to delete. 
        /// </para>
        ///  
        /// <para>
        /// Specify the version as a safeguard to ensure that your are deleting the correct stream.
        /// To get the stream version, use the <code>DescribeStream</code> API.
        /// </para>
        ///  
        /// <para>
        /// If not specified, only the <code>CreationTime</code> is checked before deleting the
        /// stream.
        /// </para>
        /// </summary>
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream that you want to delete. 
        /// </para>
        /// </summary>
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

    }
}