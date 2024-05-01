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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The authorization method used to send messages.
    /// </summary>
    public partial class HttpAuthorization
    {
        private SigV4Authorization _sigv4;

        /// <summary>
        /// Gets and sets the property Sigv4. 
        /// <para>
        /// Use Sig V4 authorization. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 Signing Process</a>.
        /// </para>
        /// </summary>
        public SigV4Authorization Sigv4
        {
            get { return this._sigv4; }
            set { this._sigv4 = value; }
        }

        // Check to see if Sigv4 property is set
        internal bool IsSetSigv4()
        {
            return this._sigv4 != null;
        }

    }
}