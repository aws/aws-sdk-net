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
    /// Represents a VM server.
    /// </summary>
    public partial class VmServer
    {
        private string _vmManagerName;
        private VmManagerType _vmManagerType;
        private string _vmName;
        private string _vmPath;
        private VmServerAddress _vmServerAddress;

        /// <summary>
        /// Gets and sets the property VmManagerName. 
        /// <para>
        /// The name of the VM manager.
        /// </para>
        /// </summary>
        public string VmManagerName
        {
            get { return this._vmManagerName; }
            set { this._vmManagerName = value; }
        }

        // Check to see if VmManagerName property is set
        internal bool IsSetVmManagerName()
        {
            return this._vmManagerName != null;
        }

        /// <summary>
        /// Gets and sets the property VmManagerType. 
        /// <para>
        /// The type of VM management product.
        /// </para>
        /// </summary>
        public VmManagerType VmManagerType
        {
            get { return this._vmManagerType; }
            set { this._vmManagerType = value; }
        }

        // Check to see if VmManagerType property is set
        internal bool IsSetVmManagerType()
        {
            return this._vmManagerType != null;
        }

        /// <summary>
        /// Gets and sets the property VmName. 
        /// <para>
        /// The name of the VM.
        /// </para>
        /// </summary>
        public string VmName
        {
            get { return this._vmName; }
            set { this._vmName = value; }
        }

        // Check to see if VmName property is set
        internal bool IsSetVmName()
        {
            return this._vmName != null;
        }

        /// <summary>
        /// Gets and sets the property VmPath. 
        /// <para>
        /// The VM folder path in the vCenter Server virtual machine inventory tree.
        /// </para>
        /// </summary>
        public string VmPath
        {
            get { return this._vmPath; }
            set { this._vmPath = value; }
        }

        // Check to see if VmPath property is set
        internal bool IsSetVmPath()
        {
            return this._vmPath != null;
        }

        /// <summary>
        /// Gets and sets the property VmServerAddress. 
        /// <para>
        /// Information about the VM server location.
        /// </para>
        /// </summary>
        public VmServerAddress VmServerAddress
        {
            get { return this._vmServerAddress; }
            set { this._vmServerAddress = value; }
        }

        // Check to see if VmServerAddress property is set
        internal bool IsSetVmServerAddress()
        {
            return this._vmServerAddress != null;
        }

    }
}