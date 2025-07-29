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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Describes IAM federation options for an OpenSearch Serverless security configuration
    /// in the form of a key-value map. These options define how OpenSearch Serverless integrates
    /// with external identity providers using federation.
    /// </summary>
    public partial class IamFederationConfigOptions
    {
        private string _groupAttribute;
        private string _userAttribute;

        /// <summary>
        /// Gets and sets the property GroupAttribute. 
        /// <para>
        /// The group attribute for this IAM federation integration. This attribute is used to
        /// map identity provider groups to OpenSearch Serverless permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string GroupAttribute
        {
            get { return this._groupAttribute; }
            set { this._groupAttribute = value; }
        }

        // Check to see if GroupAttribute property is set
        internal bool IsSetGroupAttribute()
        {
            return this._groupAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property UserAttribute. 
        /// <para>
        /// The user attribute for this IAM federation integration. This attribute is used to
        /// identify users in the federated authentication process.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string UserAttribute
        {
            get { return this._userAttribute; }
            set { this._userAttribute = value; }
        }

        // Check to see if UserAttribute property is set
        internal bool IsSetUserAttribute()
        {
            return this._userAttribute != null;
        }

    }
}