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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// A request to apply a service update
    /// </summary>
    public partial class ServiceUpdateRequest
    {
        private string _serviceUpdateNameToApply;

        /// <summary>
        /// Gets and sets the property ServiceUpdateNameToApply. 
        /// <para>
        /// The unique ID of the service update
        /// </para>
        /// </summary>
        public string ServiceUpdateNameToApply
        {
            get { return this._serviceUpdateNameToApply; }
            set { this._serviceUpdateNameToApply = value; }
        }

        // Check to see if ServiceUpdateNameToApply property is set
        internal bool IsSetServiceUpdateNameToApply()
        {
            return this._serviceUpdateNameToApply != null;
        }

    }
}