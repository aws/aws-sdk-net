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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        private EnableHybridValues _enableHybrid;
        private ExistCondition _policyExistsCondition;
        private string _policyHashCondition;
        private string _policyInJson;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property EnableHybrid. 
        /// <para>
        /// Allows you to specify if you want to use both resource-level and account/catalog-level
        /// resource policies. A resource-level policy is a policy attached to an individual resource
        /// such as a database or a table.
        /// </para>
        ///  
        /// <para>
        /// The default value of <code>NO</code> indicates that resource-level policies cannot
        /// co-exist with an account-level policy. A value of <code>YES</code> means the use of
        /// both resource-level and account/catalog-level resource policies is allowed.
        /// </para>
        /// </summary>
        public EnableHybridValues EnableHybrid
        {
            get { return this._enableHybrid; }
            set { this._enableHybrid = value; }
        }

        // Check to see if EnableHybrid property is set
        internal bool IsSetEnableHybrid()
        {
            return this._enableHybrid != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyExistsCondition. 
        /// <para>
        /// A value of <code>MUST_EXIST</code> is used to update a policy. A value of <code>NOT_EXIST</code>
        /// is used to create a new policy. If a value of <code>NONE</code> or a null value is
        /// used, the call will not depend on the existence of a policy.
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
        /// The hash value returned when the previous policy was set using <code>PutResourcePolicy</code>.
        /// Its purpose is to prevent concurrent modifications of a policy. Do not use this parameter
        /// if no previous policy has been set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        [AWSProperty(Required=true, Min=2, Max=10240)]
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

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the AWS Glue resource for the resource policy to be set. For more information
        /// about AWS Glue resource ARNs, see the <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-api-common.html#aws-glue-api-regex-aws-glue-arn-id">AWS
        /// Glue ARN string pattern</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10240)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}