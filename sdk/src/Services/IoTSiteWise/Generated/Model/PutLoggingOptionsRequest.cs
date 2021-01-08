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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the PutLoggingOptions operation.
    /// Sets logging options for AWS IoT SiteWise.
    /// </summary>
    public partial class PutLoggingOptionsRequest : AmazonIoTSiteWiseRequest
    {
        private LoggingOptions _loggingOptions;

        /// <summary>
        /// Gets and sets the property LoggingOptions. 
        /// <para>
        /// The logging options to set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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