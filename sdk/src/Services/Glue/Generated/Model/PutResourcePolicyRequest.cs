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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Sets the Data Catalog resource policy for access control.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonGlueRequest
    {
        private ExistCondition _policyExistsCondition;
        private string _policyHashCondition;
        private string _policyInJson;

        /// <summary>
        /// Gets and sets the property PolicyExistsCondition. 
        /// <para>
        /// If a value of <code>MUST_EXIST</code> is used here, the call will fail unless a policy
        /// has already been set. If a value of <code>NOT_Exist</code> is used, the call will
        /// fail if a policy has already been set. If a value of <code>NONE</code> or a null value
        /// is used, the call will not depend on the existence of a policy.
        /// </para>
        /// </summary>
        public ExistCondition PolicyExistsCondition
        {
            get { return this._policyExistsCondition; }
            set { this._policyExistsCondition = value; }
        }

        // Check to see if PolicyExistsCondition property is set
        internal bool IsSetPolicyExistsCondition()
        {
            return this._policyExistsCondition != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyHashCondition. 
        /// <para>
        /// This is the hash value returned when the previous policy was set using PutResourcePolicy.
        /// Its purpose is to prevent concurrent modifications of a policy. Do not use this parameter
        /// if no previous policy has been set.
        /// </para>
        /// </summary>
        public string PolicyHashCondition
        {
            get { return this._policyHashCondition; }
            set { this._policyHashCondition = value; }
        }

        // Check to see if PolicyHashCondition property is set
        internal bool IsSetPolicyHashCondition()
        {
            return this._policyHashCondition != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyInJson. 
        /// <para>
        /// Contains the policy document to set, in JSON format.
        /// </para>
        /// </summary>
        public string PolicyInJson
        {
            get { return this._policyInJson; }
            set { this._policyInJson = value; }
        }

        // Check to see if PolicyInJson property is set
        internal bool IsSetPolicyInJson()
        {
            return this._policyInJson != null;
        }

    }
}