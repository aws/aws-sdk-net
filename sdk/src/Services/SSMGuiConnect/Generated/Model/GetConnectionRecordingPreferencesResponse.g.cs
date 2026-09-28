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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SSMGuiConnect.Model
{
    /// <summary>
    /// This is the response object from the GetConnectionRecordingPreferences operation.
    /// </summary>
    public partial class GetConnectionRecordingPreferencesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Service-provided idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConnectionRecordingPreferences. 
        /// <para>
        /// The set of preferences used for recording RDP connections in the requesting Amazon
        /// Web Services account and Amazon Web Services Region. This includes details such as
        /// which S3 bucket recordings are stored in.
        /// </para>
        /// </summary>
        public ConnectionRecordingPreferences ConnectionRecordingPreferences { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionRecordingPreferences property is set.
        /// </summary>
        internal bool IsSetConnectionRecordingPreferences() => this.ConnectionRecordingPreferences != null;
    }
}
