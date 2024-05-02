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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The configuration information for the session integration.
    /// </summary>
    public partial class SessionIntegrationConfiguration
    {
        private string _topicIntegrationArn;

        /// <summary>
        /// Gets and sets the property TopicIntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the integrated Amazon SNS topic used for streaming
        /// chat messages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string TopicIntegrationArn
        {
            get { return this._topicIntegrationArn; }
            set { this._topicIntegrationArn = value; }
        }

        // Check to see if TopicIntegrationArn property is set
        internal bool IsSetTopicIntegrationArn()
        {
            return this._topicIntegrationArn != null;
        }

    }
}