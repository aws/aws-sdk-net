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
    /// An object that contains the latest status details for an edge agent's recorder and
    /// uploader jobs. Use this information to determine the current health of an edge agent.
    /// </summary>
    public partial class EdgeAgentStatus
    {
        private LastRecorderStatus _lastRecorderStatus;
        private LastUploaderStatus _lastUploaderStatus;

        /// <summary>
        /// Gets and sets the property LastRecorderStatus. 
        /// <para>
        /// The latest status of a stream’s edge recording job.
        /// </para>
        /// </summary>
        public LastRecorderStatus LastRecorderStatus
        {
            get { return this._lastRecorderStatus; }
            set { this._lastRecorderStatus = value; }
        }

        // Check to see if LastRecorderStatus property is set
        internal bool IsSetLastRecorderStatus()
        {
            return this._lastRecorderStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUploaderStatus. 
        /// <para>
        /// The latest status of a stream’s edge to cloud uploader job.
        /// </para>
        /// </summary>
        public LastUploaderStatus LastUploaderStatus
        {
            get { return this._lastUploaderStatus; }
            set { this._lastUploaderStatus = value; }
        }

        // Check to see if LastUploaderStatus property is set
        internal bool IsSetLastUploaderStatus()
        {
            return this._lastUploaderStatus != null;
        }

    }
}