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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMessagingStreamingConfigurations operation.
    /// Deletes the streaming configurations for an <code>AppInstance</code>. For more information,
    /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/streaming-export.html">Streaming
    /// messaging data</a> in the <i>Amazon Chime SDK Developer Guide</i>.
    /// </summary>
    public partial class DeleteMessagingStreamingConfigurationsRequest : AmazonChimeSDKMessagingRequest
    {
        private string _appInstanceArn;

        /// <summary>
        /// Gets and sets the property AppInstanceArn. 
        /// <para>
        /// The ARN of the streaming configurations being deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string AppInstanceArn
        {
            get { return this._appInstanceArn; }
            set { this._appInstanceArn = value; }
        }

        // Check to see if AppInstanceArn property is set
        internal bool IsSetAppInstanceArn()
        {
            return this._appInstanceArn != null;
        }

    }
}