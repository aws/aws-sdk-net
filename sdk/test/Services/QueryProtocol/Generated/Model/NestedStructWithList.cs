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
    public partial class NestedStructWithList
    {
        private List<string> _listArg = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ListArg.
        /// </summary>
        public List<string> ListArg
        {
            get { return this._listArg; }
            set { this._listArg = value; }
        }

        // Check to see if ListArg property is set
        internal bool IsSetListArg()
        {
            return this._listArg != null && (this._listArg.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}