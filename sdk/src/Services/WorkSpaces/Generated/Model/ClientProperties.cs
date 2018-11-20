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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes an Amazon WorkSpaces client.
    /// </summary>
    public partial class ClientProperties
    {
        private ReconnectEnum _reconnectEnabled;

        /// <summary>
        /// Gets and sets the property ReconnectEnabled. 
        /// <para>
        /// Specifies whether users can cache their credentials on the Amazon WorkSpaces client.
        /// When enabled, users can choose to reconnect to their WorkSpaces without re-entering
        /// their credentials. 
        /// </para>
        /// </summary>
        public ReconnectEnum ReconnectEnabled
        {
            get { return this._reconnectEnabled; }
            set { this._reconnectEnabled = value; }
        }

        // Check to see if ReconnectEnabled property is set
        internal bool IsSetReconnectEnabled()
        {
            return this._reconnectEnabled != null;
        }

    }
}