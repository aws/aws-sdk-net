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
    /// An object that represents the metadata and configuration settings for the Storage
    /// Gateway service Tape Gateway type on an Amazon Web Services Snow Family device.
    /// </summary>
    public partial class TGWOnDeviceServiceConfiguration
    {
        private int? _storageLimit;
        private StorageUnit _storageUnit;

        /// <summary>
        /// Gets and sets the property StorageLimit. 
        /// <para>
        /// The maximum number of virtual tapes to store on one Snow Family device. Due to physical
        /// resource limitations, this value must be set to 80 for Snowball Edge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? StorageLimit
        {
            get { return this._storageLimit; }
            set { this._storageLimit = value; }
        }

        // Check to see if StorageLimit property is set
        internal bool IsSetStorageLimit()
        {
            return this._storageLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageUnit. 
        /// <para>
        /// The scale unit of the virtual tapes on the device.
        /// </para>
        /// </summary>
        public StorageUnit StorageUnit
        {
            get { return this._storageUnit; }
            set { this._storageUnit = value; }
        }

        // Check to see if StorageUnit property is set
        internal bool IsSetStorageUnit()
        {
            return this._storageUnit != null;
        }

    }
}