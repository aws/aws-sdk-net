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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains a description of an evaluation error.
    /// 
    ///  
    /// <para>
    /// This data type is used as a request parameter in the <a href="https://docs.aws.amazon.com/amazon-verified-permissions/latest/APIReference/API_IsAuthorized.html">IsAuthorized</a>
    /// and <a href="https://docs.aws.amazon.com/amazon-verified-permissions/latest/APIReference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>
    /// operations.
    /// </para>
    /// </summary>
    public partial class EvaluationErrorItem
    {
        private string _errorDescription;

        /// <summary>
        /// Gets and sets the property ErrorDescription. 
        /// <para>
        /// The error description.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ErrorDescription
        {
            get { return this._errorDescription; }
            set { this._errorDescription = value; }
        }

        // Check to see if ErrorDescription property is set
        internal bool IsSetErrorDescription()
        {
            return this._errorDescription != null;
        }

    }
}