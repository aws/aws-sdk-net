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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Container for the parameters to the StartStudioSSOConfigurationRepair operation.
    /// Repairs the SSO configuration for a given studio.
    /// 
    ///  
    /// <para>
    /// If the studio has a valid AWS SSO configuration currently associated with it, this
    /// operation will fail with a validation error.
    /// </para>
    ///  
    /// <para>
    /// If the studio does not have a valid AWS SSO configuration currently associated with
    /// it, then a new AWS SSO application is created for the studio and the studio is changed
    /// to the READY state.
    /// </para>
    ///  
    /// <para>
    /// After the AWS SSO application is repaired, you must use the Amazon Nimble Studio console
    /// to add administrators and users to your studio.
    /// </para>
    /// </summary>
    public partial class StartStudioSSOConfigurationRepairRequest : AmazonNimbleStudioRequest
    {
        private string _clientToken;
        private string _studioId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// To make an idempotent API request using one of these actions, specify a client token
        /// in the request. You should not reuse the same client token for other API requests.
        /// If you retry a request that completed successfully using the same client token and
        /// the same parameters, the retry succeeds without performing any further actions. If
        /// you retry a successful request using the same client token, but one or more of the
        /// parameters are different, the retry fails with a ValidationException error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The studio ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StudioId
        {
            get { return this._studioId; }
            set { this._studioId = value; }
        }

        // Check to see if StudioId property is set
        internal bool IsSetStudioId()
        {
            return this._studioId != null;
        }

    }
}