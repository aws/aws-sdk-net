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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// The stream processor settings that you want to update. <c>ConnectedHome</c> settings
    /// can be updated to detect different labels with a different minimum confidence.
    /// </summary>
    public partial class StreamProcessorSettingsForUpdate
    {
        private ConnectedHomeSettingsForUpdate _connectedHomeForUpdate;

        /// <summary>
        /// Gets and sets the property ConnectedHomeForUpdate. 
        /// <para>
        ///  The label detection settings you want to use for your stream processor. 
        /// </para>
        /// </summary>
        public ConnectedHomeSettingsForUpdate ConnectedHomeForUpdate
        {
            get { return this._connectedHomeForUpdate; }
            set { this._connectedHomeForUpdate = value; }
        }

        // Check to see if ConnectedHomeForUpdate property is set
        internal bool IsSetConnectedHomeForUpdate()
        {
            return this._connectedHomeForUpdate != null;
        }

    }
}