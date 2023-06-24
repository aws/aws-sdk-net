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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Audio Dolby EDecode
    /// </summary>
    public partial class AudioDolbyEDecode
    {
        private DolbyEProgramSelection _programSelection;

        /// <summary>
        /// Gets and sets the property ProgramSelection. Applies only to Dolby E. Enter the program
        /// ID (according to the metadata in the audio) of the Dolby E program to extract from
        /// the specified track. One program extracted per audio selector. To select multiple
        /// programs, create multiple selectors with the same Track and different Program numbers.
        /// “All channels” means to ignore the program IDs and include all the channels in this
        /// selector; useful if metadata is known to be incorrect.
        /// </summary>
        [AWSProperty(Required=true)]
        public DolbyEProgramSelection ProgramSelection
        {
            get { return this._programSelection; }
            set { this._programSelection = value; }
        }

        // Check to see if ProgramSelection property is set
        internal bool IsSetProgramSelection()
        {
            return this._programSelection != null;
        }

    }
}