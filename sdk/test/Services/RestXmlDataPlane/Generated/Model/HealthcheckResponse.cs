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
 * Do not modify this file. This file is generated from the restxmldataplane-1999-12-31.normal.json service model.
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
namespace Amazon.RestXmlDataPlane.Model
{
    /// <summary>
    /// This is the response object from the Healthcheck operation.
    /// </summary>
    public partial class HealthcheckResponse : AmazonWebServiceResponse
    {
        private string _ok;

        /// <summary>
        /// Gets and sets the property Ok.
        /// </summary>
        public string Ok
        {
            get { return this._ok; }
            set { this._ok = value; }
        }

        // Check to see if Ok property is set
        internal bool IsSetOk()
        {
            return this._ok != null;
        }

    }
}