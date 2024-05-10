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
    /// This is the response object from the FlattenedXmlMapWithXmlName operation.
    /// </summary>
    public partial class FlattenedXmlMapWithXmlNameResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _myMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property MyMap.
        /// </summary>
        public Dictionary<string, string> MyMap
        {
            get { return this._myMap; }
            set { this._myMap = value; }
        }

        // Check to see if MyMap property is set
        internal bool IsSetMyMap()
        {
            return this._myMap != null && (this._myMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}