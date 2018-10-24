/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// The values that indicate whether a pin is always required (YES), never required (NO),
    /// or OPTIONAL.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If YES, Alexa will always ask for a meeting pin.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If NO, Alexa will never ask for a meeting pin.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If OPTIONAL, Alexa will ask if you have a meeting pin and if the customer responds
    /// with yes, it will ask for the meeting pin.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class MeetingSetting
    {
        private RequirePin _requirePin;

        /// <summary>
        /// Gets and sets the property RequirePin. 
        /// <para>
        /// The values that indicate whether the pin is always required.
        /// </para>
        /// </summary>
        public RequirePin RequirePin
        {
            get { return this._requirePin; }
            set { this._requirePin = value; }
        }

        // Check to see if RequirePin property is set
        internal bool IsSetRequirePin()
        {
            return this._requirePin != null;
        }

    }
}