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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// This is the response object from the CreateHsm operation.
    /// </summary>
    public partial class CreateHsmResponse : AmazonWebServiceResponse
    {
        private Hsm _hsm;

        /// <summary>
        /// Gets and sets the property Hsm. 
        /// <para>
        /// Information about the HSM that was created.
        /// </para>
        /// </summary>
        public Hsm Hsm
        {
            get { return this._hsm; }
            set { this._hsm = value; }
        }

        // Check to see if Hsm property is set
        internal bool IsSetHsm()
        {
            return this._hsm != null;
        }

    }
}