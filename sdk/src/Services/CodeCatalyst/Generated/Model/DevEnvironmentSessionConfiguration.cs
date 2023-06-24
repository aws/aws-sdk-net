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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Information about the configuration of a Dev Environment session.
    /// </summary>
    public partial class DevEnvironmentSessionConfiguration
    {
        private ExecuteCommandSessionConfiguration _executeCommandSessionConfiguration;
        private DevEnvironmentSessionType _sessionType;

        /// <summary>
        /// Gets and sets the property ExecuteCommandSessionConfiguration. 
        /// <para>
        /// Information about optional commands that will be run on the Dev Environment when the
        /// SSH session begins.
        /// </para>
        /// </summary>
        public ExecuteCommandSessionConfiguration ExecuteCommandSessionConfiguration
        {
            get { return this._executeCommandSessionConfiguration; }
            set { this._executeCommandSessionConfiguration = value; }
        }

        // Check to see if ExecuteCommandSessionConfiguration property is set
        internal bool IsSetExecuteCommandSessionConfiguration()
        {
            return this._executeCommandSessionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SessionType. 
        /// <para>
        /// The type of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DevEnvironmentSessionType SessionType
        {
            get { return this._sessionType; }
            set { this._sessionType = value; }
        }

        // Check to see if SessionType property is set
        internal bool IsSetSessionType()
        {
            return this._sessionType != null;
        }

    }
}