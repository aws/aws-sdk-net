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
    /// Ancillary Source Settings
    /// </summary>
    public partial class AncillarySourceSettings
    {
        private int? _sourceAncillaryChannelNumber;

        /// <summary>
        /// Gets and sets the property SourceAncillaryChannelNumber. Specifies the number (1 to
        /// 4) of the captions channel you want to extract from the ancillary captions. If you
        /// plan to convert the ancillary captions to another format, complete this field. If
        /// you plan to choose Embedded as the captions destination in the output (to pass through
        /// all the channels in the ancillary captions), leave this field blank because MediaLive
        /// ignores the field.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public int? SourceAncillaryChannelNumber
        {
            get { return this._sourceAncillaryChannelNumber; }
            set { this._sourceAncillaryChannelNumber = value; }
        }

        // Check to see if SourceAncillaryChannelNumber property is set
        internal bool IsSetSourceAncillaryChannelNumber()
        {
            return this._sourceAncillaryChannelNumber.HasValue; 
        }

    }
}