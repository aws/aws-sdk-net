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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetDisk operation.
    /// </summary>
    public partial class GetDiskResponse : AmazonWebServiceResponse
    {
        private Disk _disk;

        /// <summary>
        /// Gets and sets the property Disk. 
        /// <para>
        /// An object containing information about the disk.
        /// </para>
        /// </summary>
        public Disk Disk
        {
            get { return this._disk; }
            set { this._disk = value; }
        }

        // Check to see if Disk property is set
        internal bool IsSetDisk()
        {
            return this._disk != null;
        }

    }
}