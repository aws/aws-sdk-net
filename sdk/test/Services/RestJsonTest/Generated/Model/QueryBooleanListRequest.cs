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
    /// Container for the parameters to the QueryBooleanList operation.
    /// Handles query string lists of boolean
    /// </summary>
    public partial class QueryBooleanListRequest : AmazonRestJsonTestRequest
    {
        private List<bool> _queryBooleanList = AWSConfigs.InitializeCollections ? new List<bool>() : null;

        /// <summary>
        /// Gets and sets the property QueryBooleanList.
        /// </summary>
        public List<bool> QueryBooleanList
        {
            get { return this._queryBooleanList; }
            set { this._queryBooleanList = value; }
        }

        // Check to see if QueryBooleanList property is set
        internal bool IsSetQueryBooleanList()
        {
            return this._queryBooleanList != null && (this._queryBooleanList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}