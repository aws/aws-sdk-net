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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// This is the response object from the DescribeQueryLoggingConfiguration operation.
    /// </summary>
    public partial class DescribeQueryLoggingConfigurationResponse : AmazonWebServiceResponse
    {
        private QueryLoggingConfigurationMetadata _queryLoggingConfiguration;

        /// <summary>
        /// Gets and sets the property QueryLoggingConfiguration. 
        /// <para>
        /// The detailed information about the query logging configuration for the specified workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryLoggingConfigurationMetadata QueryLoggingConfiguration
        {
            get { return this._queryLoggingConfiguration; }
            set { this._queryLoggingConfiguration = value; }
        }

        // Check to see if QueryLoggingConfiguration property is set
        internal bool IsSetQueryLoggingConfiguration()
        {
            return this._queryLoggingConfiguration != null;
        }

    }
}