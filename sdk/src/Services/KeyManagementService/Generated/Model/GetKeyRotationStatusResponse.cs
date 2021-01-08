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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the GetKeyRotationStatus operation.
    /// </summary>
    public partial class GetKeyRotationStatusResponse : AmazonWebServiceResponse
    {
        private bool? _keyRotationEnabled;

        /// <summary>
        /// Gets and sets the property KeyRotationEnabled. 
        /// <para>
        /// A Boolean value that specifies whether key rotation is enabled.
        /// </para>
        /// </summary>
        public bool KeyRotationEnabled
        {
            get { return this._keyRotationEnabled.GetValueOrDefault(); }
            set { this._keyRotationEnabled = value; }
        }

        // Check to see if KeyRotationEnabled property is set
        internal bool IsSetKeyRotationEnabled()
        {
            return this._keyRotationEnabled.HasValue; 
        }

    }
}