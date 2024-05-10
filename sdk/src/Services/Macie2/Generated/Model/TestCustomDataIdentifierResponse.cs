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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the TestCustomDataIdentifier operation.
    /// </summary>
    public partial class TestCustomDataIdentifierResponse : AmazonWebServiceResponse
    {
        private int? _matchCount;

        /// <summary>
        /// Gets and sets the property MatchCount. 
        /// <para>
        /// The number of occurrences of sample text that matched the criteria specified by the
        /// custom data identifier.
        /// </para>
        /// </summary>
        public int? MatchCount
        {
            get { return this._matchCount; }
            set { this._matchCount = value; }
        }

        // Check to see if MatchCount property is set
        internal bool IsSetMatchCount()
        {
            return this._matchCount.HasValue; 
        }

    }
}