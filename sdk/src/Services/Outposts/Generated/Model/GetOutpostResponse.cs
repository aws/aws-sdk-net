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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// This is the response object from the GetOutpost operation.
    /// </summary>
    public partial class GetOutpostResponse : AmazonWebServiceResponse
    {
        private Outpost _outpost;

        /// <summary>
        /// Gets and sets the property Outpost.
        /// </summary>
        public Outpost Outpost
        {
            get { return this._outpost; }
            set { this._outpost = value; }
        }

        // Check to see if Outpost property is set
        internal bool IsSetOutpost()
        {
            return this._outpost != null;
        }

    }
}