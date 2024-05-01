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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// An object that represents the service or services on the Snow Family device that your
    /// transferred data will be exported from or imported into. Amazon Web Services Snow
    /// Family supports Amazon S3 and NFS (Network File System).
    /// </summary>
    public partial class TargetOnDeviceService
    {
        private DeviceServiceName _serviceName;
        private TransferOption _transferOption;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// Specifies the name of the service on the Snow Family device that your transferred
        /// data will be exported from or imported into.
        /// </para>
        /// </summary>
        public DeviceServiceName ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property TransferOption. 
        /// <para>
        /// Specifies whether the data is being imported or exported. You can import or export
        /// the data, or use it locally on the device.
        /// </para>
        /// </summary>
        public TransferOption TransferOption
        {
            get { return this._transferOption; }
            set { this._transferOption = value; }
        }

        // Check to see if TransferOption property is set
        internal bool IsSetTransferOption()
        {
            return this._transferOption != null;
        }

    }
}