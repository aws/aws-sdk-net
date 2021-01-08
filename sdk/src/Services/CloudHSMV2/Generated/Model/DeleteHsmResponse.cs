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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// This is the response object from the DeleteHsm operation.
    /// </summary>
    public partial class DeleteHsmResponse : AmazonWebServiceResponse
    {
        private string _hsmId;

        /// <summary>
        /// Gets and sets the property HsmId. 
        /// <para>
        /// The identifier (ID) of the HSM that was deleted.
        /// </para>
        /// </summary>
        public string HsmId
        {
            get { return this._hsmId; }
            set { this._hsmId = value; }
        }

        // Check to see if HsmId property is set
        internal bool IsSetHsmId()
        {
            return this._hsmId != null;
        }

    }
}