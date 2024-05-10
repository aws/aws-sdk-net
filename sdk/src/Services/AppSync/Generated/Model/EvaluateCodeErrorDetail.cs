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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Contains the list of errors from a code evaluation response.
    /// </summary>
    public partial class EvaluateCodeErrorDetail
    {
        private List<CodeError> _codeErrors = AWSConfigs.InitializeCollections ? new List<CodeError>() : null;
        private string _message;

        /// <summary>
        /// Gets and sets the property CodeErrors. 
        /// <para>
        /// Contains the list of <c>CodeError</c> objects.
        /// </para>
        /// </summary>
        public List<CodeError> CodeErrors
        {
            get { return this._codeErrors; }
            set { this._codeErrors = value; }
        }

        // Check to see if CodeErrors property is set
        internal bool IsSetCodeErrors()
        {
            return this._codeErrors != null && (this._codeErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The error payload.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}