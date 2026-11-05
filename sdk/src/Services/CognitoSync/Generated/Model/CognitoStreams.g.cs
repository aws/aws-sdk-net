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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// Configuration options for configure Cognito streams.
    /// </summary>
    public partial class CognitoStreams
    {
        /// <summary>
        /// Gets and sets the property RoleArn. The ARN of the role Amazon Cognito can assume
        /// in order to publish to the stream. This role must grant access to Amazon Cognito (cognito-sync)
        /// to invoke PutRecord on your Cognito stream.
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StreamName. The name of the Cognito stream to receive updates.
        /// This stream must be in the developers account and in the same region as the identity
        /// pool.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

        /// <summary>
        /// Gets and sets the property StreamingStatus. Status of the Cognito streams. Valid values
        /// are: 
        /// <para>
        /// ENABLED - Streaming of updates to identity pool is enabled.
        /// </para>
        ///  
        /// <para>
        /// DISABLED - Streaming of updates to identity pool is disabled. Bulk publish will also
        /// fail if StreamingStatus is DISABLED.
        /// </para>
        /// </summary>
        public StreamingStatus StreamingStatus { get; set; }

        /// <summary>
        /// Checks to see if the StreamingStatus property is set.
        /// </summary>
        internal bool IsSetStreamingStatus() => this.StreamingStatus != null;
    }
}
