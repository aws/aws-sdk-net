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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetStatement operation.
    /// </summary>
    public partial class GetStatementResponse : AmazonWebServiceResponse
    {
        private Statement _statement;

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        /// Returns the statement.
        /// </para>
        /// </summary>
        public Statement Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

    }
}