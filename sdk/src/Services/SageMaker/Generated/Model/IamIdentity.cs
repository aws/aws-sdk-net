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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The IAM Identity details associated with the user. These details are associated with
    /// model package groups, model packages and project entities only.
    /// </summary>
    public partial class IamIdentity
    {
        private string _arn;
        private string _principalId;
        private string _sourceIdentity;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM identity.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The ID of the principal that assumes the IAM identity.
        /// </para>
        /// </summary>
        public string PrincipalId
        {
            get { return this._principalId; }
            set { this._principalId = value; }
        }

        // Check to see if PrincipalId property is set
        internal bool IsSetPrincipalId()
        {
            return this._principalId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIdentity. 
        /// <para>
        /// The person or application which assumes the IAM identity.
        /// </para>
        /// </summary>
        public string SourceIdentity
        {
            get { return this._sourceIdentity; }
            set { this._sourceIdentity = value; }
        }

        // Check to see if SourceIdentity property is set
        internal bool IsSetSourceIdentity()
        {
            return this._sourceIdentity != null;
        }

    }
}