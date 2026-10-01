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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Contains information about an incremental training data channel that was used to create
    /// a trained model. This structure provides details about the base model and channel
    /// configuration used during incremental training.
    /// </summary>
    public partial class IncrementalTrainingDataChannelOutput
    {
        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the incremental training data channel that was used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the base trained model that was used for incremental training.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property VersionIdentifier. 
        /// <para>
        /// The version identifier of the trained model that was used for incremental training.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string VersionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the VersionIdentifier property is set.
        /// </summary>
        internal bool IsSetVersionIdentifier() => this.VersionIdentifier != null;
    }
}
