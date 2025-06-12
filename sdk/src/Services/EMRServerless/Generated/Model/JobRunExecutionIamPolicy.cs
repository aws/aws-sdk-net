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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Optional IAM policy. The resulting job IAM role permissions will be an intersection
    /// of the policies passed and the policy associated with your job execution role.
    /// </summary>
    public partial class JobRunExecutionIamPolicy
    {
        private string _policy;
        private List<string> _policyArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// An IAM inline policy to use as an execution IAM policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArns. 
        /// <para>
        /// A list of Amazon Resource Names (ARNs) to use as an execution IAM policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> PolicyArns
        {
            get { return this._policyArns; }
            set { this._policyArns = value; }
        }

        // Check to see if PolicyArns property is set
        internal bool IsSetPolicyArns()
        {
            return this._policyArns != null && (this._policyArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}