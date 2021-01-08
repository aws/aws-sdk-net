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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetRelationalDatabase operation.
    /// </summary>
    public partial class GetRelationalDatabaseResponse : AmazonWebServiceResponse
    {
        private RelationalDatabase _relationalDatabase;

        /// <summary>
        /// Gets and sets the property RelationalDatabase. 
        /// <para>
        /// An object describing the specified database.
        /// </para>
        /// </summary>
        public RelationalDatabase RelationalDatabase
        {
            get { return this._relationalDatabase; }
            set { this._relationalDatabase = value; }
        }

        // Check to see if RelationalDatabase property is set
        internal bool IsSetRelationalDatabase()
        {
            return this._relationalDatabase != null;
        }

    }
}