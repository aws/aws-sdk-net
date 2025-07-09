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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// Contains details for the resource that provides identities to the identity source.
    /// For example, an IAM Identity Center instance. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
    /// source</a> in the <i>Multi-party approval User Guide</i>.
    /// </summary>
    public partial class IdentitySourceParametersForList
    {
        private IamIdentityCenterForList _iamIdentityCenter;

        /// <summary>
        /// Gets and sets the property IamIdentityCenter. 
        /// <para>
        /// IAM Identity Center credentials.
        /// </para>
        /// </summary>
        public IamIdentityCenterForList IamIdentityCenter
        {
            get { return this._iamIdentityCenter; }
            set { this._iamIdentityCenter = value; }
        }

        // Check to see if IamIdentityCenter property is set
        internal bool IsSetIamIdentityCenter()
        {
            return this._iamIdentityCenter != null;
        }

    }
}