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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the CreateOpsMetadata operation.
    /// </summary>
    public partial class CreateOpsMetadataResponse : AmazonWebServiceResponse
    {
        private string _opsMetadataArn;

        /// <summary>
        /// Gets and sets the property OpsMetadataArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OpsMetadata Object or blob created by the call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string OpsMetadataArn
        {
            get { return this._opsMetadataArn; }
            set { this._opsMetadataArn = value; }
        }

        // Check to see if OpsMetadataArn property is set
        internal bool IsSetOpsMetadataArn()
        {
            return this._opsMetadataArn != null;
        }

    }
}