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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the SetLoggingOptions operation.
    /// Sets the logging options.
    /// 
    ///  
    /// <para>
    /// NOTE: use of this command is not recommended. Use <c>SetV2LoggingOptions</c> instead.
    /// </para>
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SetLoggingOptions</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class SetLoggingOptionsRequest : AmazonIoTRequest
    {
        private LoggingOptionsPayload _loggingOptionsPayload;

        /// <summary>
        /// Gets and sets the property LoggingOptionsPayload. 
        /// <para>
        /// The logging options payload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LoggingOptionsPayload LoggingOptionsPayload
        {
            get { return this._loggingOptionsPayload; }
            set { this._loggingOptionsPayload = value; }
        }

        // Check to see if LoggingOptionsPayload property is set
        internal bool IsSetLoggingOptionsPayload()
        {
            return this._loggingOptionsPayload != null;
        }

    }
}