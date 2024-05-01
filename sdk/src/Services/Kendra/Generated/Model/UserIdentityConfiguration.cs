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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for the identifiers of your users.
    /// </summary>
    public partial class UserIdentityConfiguration
    {
        private string _identityAttributeName;

        /// <summary>
        /// Gets and sets the property IdentityAttributeName. 
        /// <para>
        /// The IAM Identity Center field name that contains the identifiers of your users, such
        /// as their emails. This is used for <a href="https://docs.aws.amazon.com/kendra/latest/dg/user-context-filter.html">user
        /// context filtering</a> and for granting access to your Amazon Kendra experience. You
        /// must set up IAM Identity Center with Amazon Kendra. You must include your users and
        /// groups in your Access Control List when you ingest documents into your index. For
        /// more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/getting-started-aws-sso.html">Getting
        /// started with an IAM Identity Center identity source</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string IdentityAttributeName
        {
            get { return this._identityAttributeName; }
            set { this._identityAttributeName = value; }
        }

        // Check to see if IdentityAttributeName property is set
        internal bool IsSetIdentityAttributeName()
        {
            return this._identityAttributeName != null;
        }

    }
}