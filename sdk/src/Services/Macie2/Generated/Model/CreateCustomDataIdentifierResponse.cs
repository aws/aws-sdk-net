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
    /// This is the response object from the CreateCustomDataIdentifier operation.
    /// </summary>
    public partial class CreateCustomDataIdentifierResponse : AmazonWebServiceResponse
    {
        private string _customDataIdentifierId;

        /// <summary>
        /// Gets and sets the property CustomDataIdentifierId. 
        /// <para>
        /// The unique identifier for the custom data identifier that was created.
        /// </para>
        /// </summary>
        public string CustomDataIdentifierId
        {
            get { return this._customDataIdentifierId; }
            set { this._customDataIdentifierId = value; }
        }

        // Check to see if CustomDataIdentifierId property is set
        internal bool IsSetCustomDataIdentifierId()
        {
            return this._customDataIdentifierId != null;
        }

    }
}