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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
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
namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Contains the output of the <a>ModifyHsm</a> operation.
    /// </summary>
    public partial class ModifyHsmResponse : AmazonWebServiceResponse
    {
        private string _hsmArn;

        /// <summary>
        /// Gets and sets the property HsmArn. 
        /// <para>
        /// The ARN of the HSM.
        /// </para>
        /// </summary>
        public string HsmArn
        {
            get { return this._hsmArn; }
            set { this._hsmArn = value; }
        }

        // Check to see if HsmArn property is set
        internal bool IsSetHsmArn()
        {
            return this._hsmArn != null;
        }

    }
}