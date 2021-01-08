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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteOrganization operation.
    /// Deletes an Amazon WorkMail organization and all underlying AWS resources managed by
    /// Amazon WorkMail as part of the organization. You can choose whether to delete the
    /// associated directory. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/remove_organization.html">Removing
    /// an organization</a> in the <i>Amazon WorkMail Administrator Guide</i>.
    /// </summary>
    public partial class DeleteOrganizationRequest : AmazonWorkMailRequest
    {
        private string _clientToken;
        private bool? _deleteDirectory;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteDirectory. 
        /// <para>
        /// If true, deletes the AWS Directory Service directory associated with the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool DeleteDirectory
        {
            get { return this._deleteDirectory.GetValueOrDefault(); }
            set { this._deleteDirectory = value; }
        }

        // Check to see if DeleteDirectory property is set
        internal bool IsSetDeleteDirectory()
        {
            return this._deleteDirectory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The organization ID.
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

    }
}