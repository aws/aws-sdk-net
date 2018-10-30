/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// This is the response object from the BatchSuspendUser operation.
    /// </summary>
    public partial class BatchSuspendUserResponse : AmazonWebServiceResponse
    {
        private List<UserError> _userErrors = new List<UserError>();

        /// <summary>
        /// Gets and sets the property UserErrors. 
        /// <para>
        /// If the <a>BatchSuspendUser</a> action fails for one or more of the user IDs in the
        /// request, a list of the user IDs is returned, along with error codes and error messages.
        /// </para>
        /// </summary>
        public List<UserError> UserErrors
        {
            get { return this._userErrors; }
            set { this._userErrors = value; }
        }

        // Check to see if UserErrors property is set
        internal bool IsSetUserErrors()
        {
            return this._userErrors != null && this._userErrors.Count > 0; 
        }

    }
}