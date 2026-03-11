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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
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
namespace Amazon.DSQL.Model
{
    /// <summary>
    /// This is the response object from the GetClusterPolicy operation.
    /// </summary>
    public partial class GetClusterPolicyResponse : AmazonWebServiceResponse
    {
        private string _policy;
        private string _policyVersion;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The resource-based policy document attached to the cluster, returned as a JSON string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20480)]
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
        /// Gets and sets the property PolicyVersion. 
        /// <para>
        /// The version of the policy document. This version number is incremented each time the
        /// policy is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyVersion
        {
            get { return this._policyVersion; }
            set { this._policyVersion = value; }
        }

        // Check to see if PolicyVersion property is set
        internal bool IsSetPolicyVersion()
        {
            return this._policyVersion != null;
        }

    }
}