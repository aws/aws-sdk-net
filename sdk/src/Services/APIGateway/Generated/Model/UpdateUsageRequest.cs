/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUsage operation.
    /// Grants a temporary extension to the remaining quota of a usage plan associated with
    /// a specified API key.
    /// </summary>
    public partial class UpdateUsageRequest : AmazonAPIGatewayRequest
    {
        private string _keyId;
        private List<PatchOperation> _patchOperations = new List<PatchOperation>();
        private string _usagePlanId;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// [Required] The identifier of the API key associated with the usage plan in which a
        /// temporary extension is granted to the remaining quota.
        /// </para>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property PatchOperations. 
        /// <para>
        /// A list of update operations to be applied to the specified resource and in the order
        /// specified in this list.
        /// </para>
        /// </summary>
        public List<PatchOperation> PatchOperations
        {
            get { return this._patchOperations; }
            set { this._patchOperations = value; }
        }

        // Check to see if PatchOperations property is set
        internal bool IsSetPatchOperations()
        {
            return this._patchOperations != null && this._patchOperations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UsagePlanId. 
        /// <para>
        /// [Required] The Id of the usage plan associated with the usage data.
        /// </para>
        /// </summary>
        public string UsagePlanId
        {
            get { return this._usagePlanId; }
            set { this._usagePlanId = value; }
        }

        // Check to see if UsagePlanId property is set
        internal bool IsSetUsagePlanId()
        {
            return this._usagePlanId != null;
        }

    }
}