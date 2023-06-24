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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the BatchGetCustomDataIdentifiers operation.
    /// </summary>
    public partial class BatchGetCustomDataIdentifiersResponse : AmazonWebServiceResponse
    {
        private List<BatchGetCustomDataIdentifierSummary> _customDataIdentifiers = new List<BatchGetCustomDataIdentifierSummary>();
        private List<string> _notFoundIdentifierIds = new List<string>();

        /// <summary>
        /// Gets and sets the property CustomDataIdentifiers. 
        /// <para>
        /// An array of objects, one for each custom data identifier that matches the criteria
        /// specified in the request.
        /// </para>
        /// </summary>
        public List<BatchGetCustomDataIdentifierSummary> CustomDataIdentifiers
        {
            get { return this._customDataIdentifiers; }
            set { this._customDataIdentifiers = value; }
        }

        // Check to see if CustomDataIdentifiers property is set
        internal bool IsSetCustomDataIdentifiers()
        {
            return this._customDataIdentifiers != null && this._customDataIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotFoundIdentifierIds. 
        /// <para>
        /// An array of custom data identifier IDs, one for each custom data identifier that was
        /// specified in the request but doesn't correlate to an existing custom data identifier.
        /// </para>
        /// </summary>
        public List<string> NotFoundIdentifierIds
        {
            get { return this._notFoundIdentifierIds; }
            set { this._notFoundIdentifierIds = value; }
        }

        // Check to see if NotFoundIdentifierIds property is set
        internal bool IsSetNotFoundIdentifierIds()
        {
            return this._notFoundIdentifierIds != null && this._notFoundIdentifierIds.Count > 0; 
        }

    }
}