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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The structure containing the size and type of the network attached storage (NAS_1)
    /// file system volume.
    /// </summary>
    public partial class KxNAS1Configuration
    {
        private int? _size;
        private KxNAS1Type _type;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        ///  The size of the network attached storage. For storage type <c>SSD_1000</c> and <c>SSD_250</c>
        /// you can select the minimum size as 1200 GB or increments of 2400 GB. For storage type
        /// <c>HDD_12</c> you can select the minimum size as 6000 GB or increments of 6000 GB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1200)]
        public int? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of the network attached storage. 
        /// </para>
        /// </summary>
        public KxNAS1Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}