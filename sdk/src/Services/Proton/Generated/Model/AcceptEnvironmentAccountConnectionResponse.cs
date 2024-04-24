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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
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
namespace Amazon.Proton.Model
{
    /// <summary>
    /// This is the response object from the AcceptEnvironmentAccountConnection operation.
    /// </summary>
    public partial class AcceptEnvironmentAccountConnectionResponse : AmazonWebServiceResponse
    {
        private EnvironmentAccountConnection _environmentAccountConnection;

        /// <summary>
        /// Gets and sets the property EnvironmentAccountConnection. 
        /// <para>
        /// The environment account connection data that's returned by Proton.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnvironmentAccountConnection EnvironmentAccountConnection
        {
            get { return this._environmentAccountConnection; }
            set { this._environmentAccountConnection = value; }
        }

        // Check to see if EnvironmentAccountConnection property is set
        internal bool IsSetEnvironmentAccountConnection()
        {
            return this._environmentAccountConnection != null;
        }

    }
}