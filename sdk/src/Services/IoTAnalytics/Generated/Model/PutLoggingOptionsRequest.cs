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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the PutLoggingOptions operation.
    /// Sets or updates the IoT Analytics logging options.
    /// 
    ///  
    /// <para>
    /// If you update the value of any <c>loggingOptions</c> field, it takes up to one minute
    /// for the change to take effect. Also, if you change the policy attached to the role
    /// you specified in the <c>roleArn</c> field (for example, to correct an invalid policy),
    /// it takes up to five minutes for that change to take effect. 
    /// </para>
    /// </summary>
    public partial class PutLoggingOptionsRequest : AmazonIoTAnalyticsRequest
    {
        private LoggingOptions _loggingOptions;

        /// <summary>
        /// Gets and sets the property LoggingOptions. 
        /// <para>
        /// The new values of the IoT Analytics logging options.
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