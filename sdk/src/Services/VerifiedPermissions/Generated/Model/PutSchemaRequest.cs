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
    /// Container for the parameters to the PutSchema operation.
    /// Creates or updates the policy schema in the specified policy store. The schema is
    /// used to validate any Cedar policies and policy templates submitted to the policy store.
    /// Any changes to the schema validate only policies and templates submitted after the
    /// schema change. Existing policies and templates are not re-evaluated against the changed
    /// schema. If you later update a policy, then it is evaluated against the new schema
    /// at that time.
    /// 
    ///  <note> 
    /// <para>
    /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
    /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
    /// through the service and be visible in the results of other Verified Permissions operations.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutSchemaRequest : AmazonVerifiedPermissionsRequest
    {
        private SchemaDefinition _definition;
        private string _policyStoreId;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// Specifies the definition of the schema to be stored. The schema definition must be
        /// written in Cedar schema JSON.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaDefinition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the ID of the policy store in which to place the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string PolicyStoreId
        {
            get { return this._policyStoreId; }
            set { this._policyStoreId = value; }
        }

        // Check to see if PolicyStoreId property is set
        internal bool IsSetPolicyStoreId()
        {
            return this._policyStoreId != null;
        }

    }
}