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
    /// Container for the parameters to the CreateUsagePlanKey operation.
    /// Creates a usage plan key for adding an existing API key to a usage plan.
    /// </summary>
    public partial class CreateUsagePlanKeyRequest : AmazonAPIGatewayRequest
    {
        private string _keyId;
        private string _keyType;
        private string _usagePlanId;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// [Required] The identifier of a <a>UsagePlanKey</a> resource for a plan customer.
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
        /// Gets and sets the property KeyType. 
        /// <para>
        /// [Required] The type of a <a>UsagePlanKey</a> resource for a plan customer.
        /// </para>
        /// </summary>
        public string KeyType
        {
            get { return this._keyType; }
            set { this._keyType = value; }
        }

        // Check to see if KeyType property is set
        internal bool IsSetKeyType()
        {
            return this._keyType != null;
        }

        /// <summary>
        /// Gets and sets the property UsagePlanId. 
        /// <para>
        /// [Required] The Id of the <a>UsagePlan</a> resource representing the usage plan containing
        /// the to-be-created <a>UsagePlanKey</a> resource representing a plan customer.
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