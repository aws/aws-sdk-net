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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// This is the response object from the GetLogDeliveryConfiguration operation.
    /// </summary>
    public partial class GetLogDeliveryConfigurationResponse : AmazonWebServiceResponse
    {
        private LogDeliveryConfigurationType _logDeliveryConfiguration;

        /// <summary>
        /// Gets and sets the property LogDeliveryConfiguration. 
        /// <para>
        /// The logging configuration of the requested user pool. Includes types of logs configured
        /// and their destinations.
        /// </para>
        /// </summary>
        public LogDeliveryConfigurationType LogDeliveryConfiguration
        {
            get { return this._logDeliveryConfiguration; }
            set { this._logDeliveryConfiguration = value; }
        }

        // Check to see if LogDeliveryConfiguration property is set
        internal bool IsSetLogDeliveryConfiguration()
        {
            return this._logDeliveryConfiguration != null;
        }

    }
}