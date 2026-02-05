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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Cursor-based pagination configuration that defines how to handle pagination using
    /// cursor tokens or next page identifiers.
    /// </summary>
    public partial class CursorConfiguration
    {
        private ExtractedParameter _limitParameter;
        private ExtractedParameter _nextPage;

        /// <summary>
        /// Gets and sets the property LimitParameter. 
        /// <para>
        /// The parameter name used to specify the maximum number of results to return per page.
        /// </para>
        /// </summary>
        public ExtractedParameter LimitParameter
        {
            get { return this._limitParameter; }
            set { this._limitParameter = value; }
        }

        // Check to see if LimitParameter property is set
        internal bool IsSetLimitParameter()
        {
            return this._limitParameter != null;
        }

        /// <summary>
        /// Gets and sets the property NextPage. 
        /// <para>
        /// The parameter name or JSON path that contains the cursor or token for retrieving the
        /// next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExtractedParameter NextPage
        {
            get { return this._nextPage; }
            set { this._nextPage = value; }
        }

        // Check to see if NextPage property is set
        internal bool IsSetNextPage()
        {
            return this._nextPage != null;
        }

    }
}