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
    /// Multiplex Program Input Destination Settings for outputting a Channel to a Multiplex
    /// </summary>
    public partial class MultiplexProgramChannelDestinationSettings
    {
        private string _multiplexId;
        private string _programName;

        /// <summary>
        /// Gets and sets the property MultiplexId. The ID of the Multiplex that the encoder is
        /// providing output to. You do not need to specify the individual inputs to the Multiplex;
        /// MediaLive will handle the connection of the two MediaLive pipelines to the two Multiplex
        /// instances.The Multiplex must be in the same region as the Channel.
        /// </summary>
        [AWSProperty(Min=1)]
        public string MultiplexId
        {
            get { return this._multiplexId; }
            set { this._multiplexId = value; }
        }

        // Check to see if MultiplexId property is set
        internal bool IsSetMultiplexId()
        {
            return this._multiplexId != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramName. The program name of the Multiplex program
        /// that the encoder is providing output to.
        /// </summary>
        [AWSProperty(Min=1)]
        public string ProgramName
        {
            get { return this._programName; }
            set { this._programName = value; }
        }

        // Check to see if ProgramName property is set
        internal bool IsSetProgramName()
        {
            return this._programName != null;
        }

    }
}