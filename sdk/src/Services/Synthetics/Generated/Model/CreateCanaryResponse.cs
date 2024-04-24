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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This is the response object from the CreateCanary operation.
    /// </summary>
    public partial class CreateCanaryResponse : AmazonWebServiceResponse
    {
        private Canary _canary;

        /// <summary>
        /// Gets and sets the property Canary. 
        /// <para>
        /// The full details about the canary you have created.
        /// </para>
        /// </summary>
        public Canary Canary
        {
            get { return this._canary; }
            set { this._canary = value; }
        }

        // Check to see if Canary property is set
        internal bool IsSetCanary()
        {
            return this._canary != null;
        }

    }
}