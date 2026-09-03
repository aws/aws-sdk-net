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
 * Do not modify this file. This file is generated from the iam-toolbox-2018-05-10.normal.json service model.
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
namespace Amazon.IAMToolbox.Model
{
    /// <summary>
    /// An entity that a policy is attached to, identified by its ARN.
    /// </summary>
    public partial class AttachedTo
    {
        private string _arn;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the entity that the policy is attached to. The ARN format depends on the
        /// policy type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For identity, session, and permissions boundary policies, this is the principal ARN
        /// (for example, an IAM role or user ARN).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For resource-based policies, this is the resource ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For organization control policies (SCPs and RCPs), this is the AWS Organizations ARN
        /// of the account, organizational unit, or root.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

    }
}