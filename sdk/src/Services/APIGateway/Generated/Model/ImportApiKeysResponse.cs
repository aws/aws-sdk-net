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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// The identifier of an <a>ApiKey</a> used in a <a>UsagePlan</a>.
    /// </summary>
    public partial class ImportApiKeysResponse : AmazonWebServiceResponse
    {
        private List<string> _ids = new List<string>();
        private List<string> _warnings = new List<string>();

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        /// A list of all the <a>ApiKey</a> identifiers.
        /// </para>
        /// </summary>
        public List<string> Ids
        {
            get { return this._ids; }
            set { this._ids = value; }
        }

        // Check to see if Ids property is set
        internal bool IsSetIds()
        {
            return this._ids != null && this._ids.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// A list of warning messages.
        /// </para>
        /// </summary>
        public List<string> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && this._warnings.Count > 0; 
        }

    }
}