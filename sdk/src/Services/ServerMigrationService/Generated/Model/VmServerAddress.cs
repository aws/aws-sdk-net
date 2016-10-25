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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Object representing a server's location
    /// </summary>
    public partial class VmServerAddress
    {
        private string _vmId;
        private string _vmManagerId;

        /// <summary>
        /// Gets and sets the property VmId.
        /// </summary>
        public string VmId
        {
            get { return this._vmId; }
            set { this._vmId = value; }
        }

        // Check to see if VmId property is set
        internal bool IsSetVmId()
        {
            return this._vmId != null;
        }

        /// <summary>
        /// Gets and sets the property VmManagerId.
        /// </summary>
        public string VmManagerId
        {
            get { return this._vmManagerId; }
            set { this._vmManagerId = value; }
        }

        // Check to see if VmManagerId property is set
        internal bool IsSetVmManagerId()
        {
            return this._vmManagerId != null;
        }

    }
}