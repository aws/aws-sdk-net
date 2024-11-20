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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
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
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Server settings that are specific to a Remote Desktop Services (RDS) license server.
    /// </summary>
    public partial class RdsSalSettings
    {
        private CredentialsProvider _rdsSalCredentialsProvider;

        /// <summary>
        /// Gets and sets the property RdsSalCredentialsProvider. 
        /// <para>
        /// The <c>CredentialsProvider</c> resource contains a reference to the credentials provider
        /// that's used for RDS license server user administration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CredentialsProvider RdsSalCredentialsProvider
        {
            get { return this._rdsSalCredentialsProvider; }
            set { this._rdsSalCredentialsProvider = value; }
        }

        // Check to see if RdsSalCredentialsProvider property is set
        internal bool IsSetRdsSalCredentialsProvider()
        {
            return this._rdsSalCredentialsProvider != null;
        }

    }
}