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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteEdgeConfiguration operation.
    /// An asynchronous API that deletes a stream’s existing edge configuration, as well as
    /// the corresponding media from the Edge Agent.
    /// 
    ///  
    /// <para>
    /// When you invoke this API, the sync status is set to <c>DELETING</c>. A deletion process
    /// starts, in which active edge jobs are stopped and all media is deleted from the edge
    /// device. The time to delete varies, depending on the total amount of stored media.
    /// If the deletion process fails, the sync status changes to <c>DELETE_FAILED</c>. You
    /// will need to re-try the deletion.
    /// </para>
    ///  
    /// <para>
    /// When the deletion process has completed successfully, the edge configuration is no
    /// longer accessible.
    /// </para>
    /// </summary>
    public partial class DeleteEdgeConfigurationRequest : AmazonKinesisVideoRequest
    {
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream. Specify either the <c>StreamName</c>
        /// or the <c>StreamARN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream from which to delete the edge configuration. Specify either
        /// the <c>StreamName</c> or the <c>StreamARN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}