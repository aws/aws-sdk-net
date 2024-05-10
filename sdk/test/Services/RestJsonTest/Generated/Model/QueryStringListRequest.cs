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
 * Do not modify this file. This file is generated from the rest-json-test-2016-04-12.normal.json service model.
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
namespace Amazon.RestJsonTest.Model
{
    /// <summary>
    /// Container for the parameters to the QueryStringList operation.
    /// Handles query string lists of string
    /// </summary>
    public partial class QueryStringListRequest : AmazonRestJsonTestRequest
    {
        private List<string> _queryStringList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property QueryStringList.
        /// </summary>
        public List<string> QueryStringList
        {
            get { return this._queryStringList; }
            set { this._queryStringList = value; }
        }

        // Check to see if QueryStringList property is set
        internal bool IsSetQueryStringList()
        {
            return this._queryStringList != null && (this._queryStringList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}