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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The client-side timestamp setting of the table.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/client-side-timestamps-how-it-works.html">How
    /// it works: Amazon Keyspaces client-side timestamps</a> in the <i>Amazon Keyspaces Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class ClientSideTimestamps
    {
        private ClientSideTimestampsStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Shows how to enable client-side timestamps settings for the specified table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClientSideTimestampsStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}