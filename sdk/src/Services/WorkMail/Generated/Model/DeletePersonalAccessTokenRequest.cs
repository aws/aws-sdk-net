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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePersonalAccessToken operation.
    /// Deletes the Personal Access Token from the provided WorkMail Organization.
    /// </summary>
    public partial class DeletePersonalAccessTokenRequest : AmazonWorkMailRequest
    {
        private string _organizationId;
        private string _personalAccessTokenId;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        ///  The Organization ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property PersonalAccessTokenId. 
        /// <para>
        ///  The Personal Access Token ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PersonalAccessTokenId
        {
            get { return this._personalAccessTokenId; }
            set { this._personalAccessTokenId = value; }
        }

        // Check to see if PersonalAccessTokenId property is set
        internal bool IsSetPersonalAccessTokenId()
        {
            return this._personalAccessTokenId != null;
        }

    }
}