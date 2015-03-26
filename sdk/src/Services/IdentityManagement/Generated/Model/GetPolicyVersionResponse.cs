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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetPolicyVersionResponse : AmazonWebServiceResponse
    {
        private PolicyVersion _policyVersion;

        /// <summary>
        /// Gets and sets the property PolicyVersion. 
        /// <para>
        /// Information about the policy version.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policy versions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        public PolicyVersion PolicyVersion
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