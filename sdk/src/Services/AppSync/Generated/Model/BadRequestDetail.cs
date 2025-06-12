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
    /// Provides further details for the reason behind the bad request. For reason type <c>CODE_ERROR</c>,
    /// the detail will contain a list of code errors.
    /// </summary>
    public partial class BadRequestDetail
    {
        private List<CodeError> _codeErrors = AWSConfigs.InitializeCollections ? new List<CodeError>() : null;

        /// <summary>
        /// Gets and sets the property CodeErrors. 
        /// <para>
        /// Contains the list of errors in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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

    }
}