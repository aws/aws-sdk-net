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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// The error in server analysis.
    /// </summary>
    public partial class ServerError
    {
        private ServerErrorCategory _serverErrorCategory;

        /// <summary>
        /// Gets and sets the property ServerErrorCategory. 
        /// <para>
        /// The error category of server analysis.
        /// </para>
        /// </summary>
        public ServerErrorCategory ServerErrorCategory
        {
            get { return this._serverErrorCategory; }
            set { this._serverErrorCategory = value; }
        }

        // Check to see if ServerErrorCategory property is set
        internal bool IsSetServerErrorCategory()
        {
            return this._serverErrorCategory != null;
        }

    }
}