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
    /// Container for the parameters to the CreateMultiplexProgram operation.
    /// Create a new program in the multiplex.
    /// </summary>
    public partial class CreateMultiplexProgramRequest : AmazonMediaLiveRequest
    {
        private string _multiplexId;
        private MultiplexProgramSettings _multiplexProgramSettings;
        private string _programName;
        private string _requestId;

        /// <summary>
        /// Gets and sets the property MultiplexId. ID of the multiplex where the program is to
        /// be created.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MultiplexProgramSettings. The settings for this multiplex
        /// program.
        /// </summary>
        [AWSProperty(Required=true)]
        public MultiplexProgramSettings MultiplexProgramSettings
        {
            get { return this._multiplexProgramSettings; }
            set { this._multiplexProgramSettings = value; }
        }

        // Check to see if MultiplexProgramSettings property is set
        internal bool IsSetMultiplexProgramSettings()
        {
            return this._multiplexProgramSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramName. Name of multiplex program.
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property RequestId. Unique request ID. This prevents retries from
        /// creating multipleresources.
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

    }
}