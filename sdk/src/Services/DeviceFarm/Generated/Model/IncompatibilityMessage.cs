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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents information about incompatibility.
    /// </summary>
    public partial class IncompatibilityMessage
    {
        private string _message;
        private DeviceAttribute _type;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the incompatibility.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16384)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of incompatibility.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ARN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FORM_FACTOR (for example, phone or tablet)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MANUFACTURER
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PLATFORM (for example, Android or iOS)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REMOTE_ACCESS_ENABLED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_VERSION
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeviceAttribute Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}