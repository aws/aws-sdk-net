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
    /// Multiplex Program settings configuration.
    /// </summary>
    public partial class MultiplexProgramSettings
    {
        /// <summary>
        /// Gets and sets the property PreferredChannelPipeline. Indicates which pipeline is preferred
        /// by the multiplex for program ingest.
        /// </summary>
        public PreferredChannelPipeline PreferredChannelPipeline { get; set; }

        /// <summary>
        /// Checks to see if the PreferredChannelPipeline property is set.
        /// </summary>
        internal bool IsSetPreferredChannelPipeline() => this.PreferredChannelPipeline != null;

        /// <summary>
        /// Gets and sets the property ProgramNumber. Unique program number.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ProgramNumber { get; set; }

        /// <summary>
        /// Checks to see if the ProgramNumber property is set.
        /// </summary>
        internal bool IsSetProgramNumber() => this.ProgramNumber.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceDescriptor. Transport stream service descriptor
        /// configuration for the Multiplex program.
        /// </summary>
        public MultiplexProgramServiceDescriptor ServiceDescriptor { get; set; }

        /// <summary>
        /// Checks to see if the ServiceDescriptor property is set.
        /// </summary>
        internal bool IsSetServiceDescriptor() => this.ServiceDescriptor != null;

        /// <summary>
        /// Gets and sets the property VideoSettings. Program video settings configuration.
        /// </summary>
        public MultiplexVideoSettings VideoSettings { get; set; }

        /// <summary>
        /// Checks to see if the VideoSettings property is set.
        /// </summary>
        internal bool IsSetVideoSettings() => this.VideoSettings != null;
    }
}
