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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Hash
    /// </summary>
    public partial class Hash
    {
        private string _sha256;

        /// <summary>
        /// Gets and sets the property Sha256. 
        /// <para>
        ///  The SHA-256 hash value.
        /// </para>
        /// </summary>
        public string Sha256
        {
            get { return this._sha256; }
            set { this._sha256 = value; }
        }

        // Check to see if Sha256 property is set
        internal bool IsSetSha256()
        {
            return this._sha256 != null;
        }

    }
}