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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OAM.Model
{
    /// <summary>
    /// Container for the parameters to the GetSink operation.
    /// Returns complete information about one monitoring account sink.
    /// 
    ///  
    /// <para>
    /// To use this operation, provide the sink ARN. To retrieve a list of sink ARNs, use
    /// <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListSinks.html">ListSinks</a>.
    /// </para>
    /// </summary>
    public partial class GetSinkRequest : AmazonOAMRequest
    {
        private string _identifier;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ARN of the sink to retrieve information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}