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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMultiplexProgram operation. Create a new
    /// program in the multiplex.
    /// </summary>
    public partial class CreateMultiplexProgramRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property MultiplexId. ID of the multiplex where the program is to
        /// be created.
        /// </summary>
        [AWSProperty(Required = true)]
        public string MultiplexId { get; set; }

        /// <summary>
        /// Checks to see if the MultiplexId property is set.
        /// </summary>
        internal bool IsSetMultiplexId() => this.MultiplexId != null;

        /// <summary>
        /// Gets and sets the property MultiplexProgramSettings. The settings for this multiplex
        /// program.
        /// </summary>
        [AWSProperty(Required = true)]
        public MultiplexProgramSettings MultiplexProgramSettings { get; set; }

        /// <summary>
        /// Checks to see if the MultiplexProgramSettings property is set.
        /// </summary>
        internal bool IsSetMultiplexProgramSettings() => this.MultiplexProgramSettings != null;

        /// <summary>
        /// Gets and sets the property ProgramName. Name of multiplex program.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProgramName { get; set; }

        /// <summary>
        /// Checks to see if the ProgramName property is set.
        /// </summary>
        internal bool IsSetProgramName() => this.ProgramName != null;

        /// <summary>
        /// Gets and sets the property RequestId. Unique request ID. This prevents retries from
        /// creating multiple resources.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;
    }
}
