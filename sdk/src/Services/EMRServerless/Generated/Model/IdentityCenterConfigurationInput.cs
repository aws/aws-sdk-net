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
    /// Specifies the IAM Identity Center configuration used to enable or disable trusted
    /// identity propagation. When provided, this configuration determines how the application
    /// interacts with IAM Identity Center for user authentication and access control.
    /// </summary>
    public partial class IdentityCenterConfigurationInput
    {
        private string _identityCenterInstanceArn;

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceArn. 
        /// <para>
        /// The ARN of the IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1024)]
        public string IdentityCenterInstanceArn
        {
            get { return this._identityCenterInstanceArn; }
            set { this._identityCenterInstanceArn = value; }
        }

        // Check to see if IdentityCenterInstanceArn property is set
        internal bool IsSetIdentityCenterInstanceArn()
        {
            return this._identityCenterInstanceArn != null;
        }

    }
}