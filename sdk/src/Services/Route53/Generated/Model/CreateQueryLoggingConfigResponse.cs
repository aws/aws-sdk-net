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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// This is the response object from the CreateQueryLoggingConfig operation.
    /// </summary>
    public partial class CreateQueryLoggingConfigResponse : AmazonWebServiceResponse
    {
        private QueryLoggingConfig _queryLoggingConfig;
        private string _location;

        /// <summary>
        /// Gets and sets the property QueryLoggingConfig. 
        /// <para>
        /// A complex type that contains the ID for a query logging configuration, the ID of the
        /// hosted zone that you want to log queries for, and the ARN for the log group that you
        /// want Amazon Route 53 to send query logs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryLoggingConfig QueryLoggingConfig
        {
            get { return this._queryLoggingConfig; }
            set { this._queryLoggingConfig = value; }
        }

        // Check to see if QueryLoggingConfig property is set
        internal bool IsSetQueryLoggingConfig()
        {
            return this._queryLoggingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The unique URL representing the new query logging configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}