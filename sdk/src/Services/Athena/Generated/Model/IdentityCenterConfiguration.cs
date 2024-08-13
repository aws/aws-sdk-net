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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Specifies whether the workgroup is IAM Identity Center supported.
    /// </summary>
    public partial class IdentityCenterConfiguration
    {
        private bool? _enableIdentityCenter;
        private string _identityCenterInstanceArn;

        /// <summary>
        /// Gets and sets the property EnableIdentityCenter. 
        /// <para>
        /// Specifies whether the workgroup is IAM Identity Center supported.
        /// </para>
        /// </summary>
        public bool? EnableIdentityCenter
        {
            get { return this._enableIdentityCenter; }
            set { this._enableIdentityCenter = value; }
        }

        // Check to see if EnableIdentityCenter property is set
        internal bool IsSetEnableIdentityCenter()
        {
            return this._enableIdentityCenter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceArn. 
        /// <para>
        /// The IAM Identity Center instance ARN that the workgroup associates to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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