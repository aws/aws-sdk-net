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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information about the decode <c>Config</c>.
    /// </summary>
    public partial class DecodeConfig
    {
        private string _unvalidatedjson;

        /// <summary>
        /// Gets and sets the property UnvalidatedJSON. 
        /// <para>
        /// Unvalidated JSON of a decode <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=8192)]
        public string UnvalidatedJSON
        {
            get { return this._unvalidatedjson; }
            set { this._unvalidatedjson = value; }
        }

        // Check to see if UnvalidatedJSON property is set
        internal bool IsSetUnvalidatedJSON()
        {
            return this._unvalidatedjson != null;
        }

    }
}