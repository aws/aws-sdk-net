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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// This is the response object from the GetStreamingSessionBackup operation.
    /// </summary>
    public partial class GetStreamingSessionBackupResponse : AmazonWebServiceResponse
    {
        private StreamingSessionBackup _streamingSessionBackup;

        /// <summary>
        /// Gets and sets the property StreamingSessionBackup. 
        /// <para>
        /// Information about the streaming session backup.
        /// </para>
        /// </summary>
        public StreamingSessionBackup StreamingSessionBackup
        {
            get { return this._streamingSessionBackup; }
            set { this._streamingSessionBackup = value; }
        }

        // Check to see if StreamingSessionBackup property is set
        internal bool IsSetStreamingSessionBackup()
        {
            return this._streamingSessionBackup != null;
        }

    }
}