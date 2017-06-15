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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the state of the bitstream generation process for an Amazon FPGA image (AFI).
    /// </summary>
    public partial class FpgaImageState
    {
        private FpgaImageStateCode _code;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The state. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>pending</code> - AFI bitstream generation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>available</code> - The AFI is available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>failed</code> - AFI bitstream generation failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>unavailable</code> - The AFI is no longer available for use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FpgaImageStateCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If the state is <code>failed</code>, this is the error message.
        /// </para>
        /// </summary>
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

    }
}