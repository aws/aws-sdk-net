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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the GetQueryLoggingConfig operation.
    /// Gets information about a specified configuration for DNS query logging.
    /// 
    ///  
    /// <para>
    /// For more information about DNS query logs, see <a>CreateQueryLoggingConfig</a> and
    /// <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/query-logs.html">Logging
    /// DNS Queries</a>.
    /// </para>
    /// </summary>
    public partial class GetQueryLoggingConfigRequest : AmazonRoute53Request
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the configuration for DNS query logging that you want to get information
        /// about.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}