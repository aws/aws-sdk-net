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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private PreferredChannelPipeline _preferredChannelPipeline;
        private int? _programNumber;
        private MultiplexProgramServiceDescriptor _serviceDescriptor;
        private MultiplexVideoSettings _videoSettings;

        /// <summary>
        /// Gets and sets the property PreferredChannelPipeline. Indicates which pipeline is preferred
        /// by the multiplex for program ingest.
        /// </summary>
        public PreferredChannelPipeline PreferredChannelPipeline
        {
            get { return this._preferredChannelPipeline; }
            set { this._preferredChannelPipeline = value; }
        }

        // Check to see if PreferredChannelPipeline property is set
        internal bool IsSetPreferredChannelPipeline()
        {
            return this._preferredChannelPipeline != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramNumber. Unique program number.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=65535)]
        public int? ProgramNumber
        {
            get { return this._programNumber; }
            set { this._programNumber = value; }
        }

        // Check to see if ProgramNumber property is set
        internal bool IsSetProgramNumber()
        {
            return this._programNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceDescriptor. Transport stream service descriptor
        /// configuration for the Multiplex program.
        /// </summary>
        public MultiplexProgramServiceDescriptor ServiceDescriptor
        {
            get { return this._serviceDescriptor; }
            set { this._serviceDescriptor = value; }
        }

        // Check to see if ServiceDescriptor property is set
        internal bool IsSetServiceDescriptor()
        {
            return this._serviceDescriptor != null;
        }

        /// <summary>
        /// Gets and sets the property VideoSettings. Program video settings configuration.
        /// </summary>
        public MultiplexVideoSettings VideoSettings
        {
            get { return this._videoSettings; }
            set { this._videoSettings = value; }
        }

        // Check to see if VideoSettings property is set
        internal bool IsSetVideoSettings()
        {
            return this._videoSettings != null;
        }

    }
}