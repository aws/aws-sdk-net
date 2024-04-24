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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
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
namespace Amazon.QueryProtocol.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class StructureListMember
    {
        private string _a;
        private string _b;

        /// <summary>
        /// Gets and sets the property A.
        /// </summary>
        public string A
        {
            get { return this._a; }
            set { this._a = value; }
        }

        // Check to see if A property is set
        internal bool IsSetA()
        {
            return this._a != null;
        }

        /// <summary>
        /// Gets and sets the property B.
        /// </summary>
        public string B
        {
            get { return this._b; }
            set { this._b = value; }
        }

        // Check to see if B property is set
        internal bool IsSetB()
        {
            return this._b != null;
        }

    }
}