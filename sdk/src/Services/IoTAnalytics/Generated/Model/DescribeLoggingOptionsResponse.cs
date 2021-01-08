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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// This is the response object from the DescribeLoggingOptions operation.
    /// </summary>
    public partial class DescribeLoggingOptionsResponse : AmazonWebServiceResponse
    {
        private LoggingOptions _loggingOptions;

        /// <summary>
        /// Gets and sets the property LoggingOptions. 
        /// <para>
        /// The current settings of the AWS IoT Analytics logging options.
        /// </para>
        /// </summary>
        public LoggingOptions LoggingOptions
        {
            get { return this._loggingOptions; }
            set { this._loggingOptions = value; }
        }

        // Check to see if LoggingOptions property is set
        internal bool IsSetLoggingOptions()
        {
            return this._loggingOptions != null;
        }

    }
}