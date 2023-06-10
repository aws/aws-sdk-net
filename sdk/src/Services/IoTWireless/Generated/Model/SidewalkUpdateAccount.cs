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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Sidewalk update.
    /// </summary>
    public partial class SidewalkUpdateAccount
    {
        private string _appServerPrivateKey;

        /// <summary>
        /// Gets and sets the property AppServerPrivateKey. 
        /// <para>
        /// The new Sidewalk application server private key.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string AppServerPrivateKey
        {
            get { return this._appServerPrivateKey; }
            set { this._appServerPrivateKey = value; }
        }

        // Check to see if AppServerPrivateKey property is set
        internal bool IsSetAppServerPrivateKey()
        {
            return this._appServerPrivateKey != null;
        }

    }
}