/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetRelationalDatabaseLogStreams operation.
    /// </summary>
    public partial class GetRelationalDatabaseLogStreamsResponse : AmazonWebServiceResponse
    {
        private List<string> _logStreams = new List<string>();

        /// <summary>
        /// Gets and sets the property LogStreams. 
        /// <para>
        /// An object describing the result of your get relational database log streams request.
        /// </para>
        /// </summary>
        public List<string> LogStreams
        {
            get { return this._logStreams; }
            set { this._logStreams = value; }
        }

        // Check to see if LogStreams property is set
        internal bool IsSetLogStreams()
        {
            return this._logStreams != null && this._logStreams.Count > 0; 
        }

    }
}