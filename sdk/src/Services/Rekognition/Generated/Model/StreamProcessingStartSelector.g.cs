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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is a required parameter for label detection stream processors and should not
    /// be used to start a face search stream processor.
    /// </summary>
    public partial class StreamProcessingStartSelector
    {
        /// <summary>
        /// Gets and sets the property KVSStreamStartSelector. 
        /// <para>
        ///  Specifies the starting point in the stream to start processing. This can be done
        /// with a producer timestamp or a fragment number in a Kinesis stream. 
        /// </para>
        /// </summary>
        public KinesisVideoStreamStartSelector KVSStreamStartSelector { get; set; }

        /// <summary>
        /// Checks to see if the KVSStreamStartSelector property is set.
        /// </summary>
        internal bool IsSetKVSStreamStartSelector() => this.KVSStreamStartSelector != null;
    }
}
