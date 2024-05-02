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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// The set of properties on a table for configuring magnetic store writes.
    /// </summary>
    public partial class MagneticStoreWriteProperties
    {
        private bool? _enableMagneticStoreWrites;
        private MagneticStoreRejectedDataLocation _magneticStoreRejectedDataLocation;

        /// <summary>
        /// Gets and sets the property EnableMagneticStoreWrites. 
        /// <para>
        /// A flag to enable magnetic store writes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? EnableMagneticStoreWrites
        {
            get { return this._enableMagneticStoreWrites; }
            set { this._enableMagneticStoreWrites = value; }
        }

        // Check to see if EnableMagneticStoreWrites property is set
        internal bool IsSetEnableMagneticStoreWrites()
        {
            return this._enableMagneticStoreWrites.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MagneticStoreRejectedDataLocation. 
        /// <para>
        /// The location to write error reports for records rejected asynchronously during magnetic
        /// store writes.
        /// </para>
        /// </summary>
        public MagneticStoreRejectedDataLocation MagneticStoreRejectedDataLocation
        {
            get { return this._magneticStoreRejectedDataLocation; }
            set { this._magneticStoreRejectedDataLocation = value; }
        }

        // Check to see if MagneticStoreRejectedDataLocation property is set
        internal bool IsSetMagneticStoreRejectedDataLocation()
        {
            return this._magneticStoreRejectedDataLocation != null;
        }

    }
}