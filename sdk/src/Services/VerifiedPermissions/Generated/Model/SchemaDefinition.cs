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
    /// Contains a list of principal types, resource types, and actions that can be specified
    /// in policies stored in the same policy store. If the validation mode for the policy
    /// store is set to <c>STRICT</c>, then policies that can't be validated by this schema
    /// are rejected by Verified Permissions and can't be stored in the policy store.
    /// </summary>
    public partial class SchemaDefinition
    {
        private string _cedarJson;

        /// <summary>
        /// Gets and sets the property CedarJson. 
        /// <para>
        /// A JSON string representation of the schema supported by applications that use this
        /// policy store. To delete the schema, run <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_PutSchema.html">PutSchema</a>
        /// with <c>{}</c> for this parameter. For more information, see <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/userguide/schema.html">Policy
        /// store schema</a> in the <i>Amazon Verified Permissions User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public string CedarJson
        {
            get { return this._cedarJson; }
            set { this._cedarJson = value; }
        }

        // Check to see if CedarJson property is set
        internal bool IsSetCedarJson()
        {
            return this._cedarJson != null;
        }

    }
}