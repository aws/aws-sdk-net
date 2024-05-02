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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains information about updates to be applied to a policy.
    /// 
    ///  
    /// <para>
    /// This data type is used as a request parameter in the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicy.html">UpdatePolicy</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class UpdatePolicyDefinition
    {
        private UpdateStaticPolicyDefinition _static;

        /// <summary>
        /// Gets and sets the property Static. 
        /// <para>
        /// Contains details about the updates to be applied to a static policy.
        /// </para>
        /// </summary>
        public UpdateStaticPolicyDefinition Static
        {
            get { return this._static; }
            set { this._static = value; }
        }

        // Check to see if Static property is set
        internal bool IsSetStatic()
        {
            return this._static != null;
        }

    }
}