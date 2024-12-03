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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// This is the response object from the DisableOrganizationsRootSessions operation.
    /// </summary>
    public partial class DisableOrganizationsRootSessionsResponse : AmazonWebServiceResponse
    {
        private List<string> _enabledFeatures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property EnabledFeatures. 
        /// <para>
        /// The features you have enabled for centralized root access of member accounts in your
        /// organization.
        /// </para>
        /// </summary>
        public List<string> EnabledFeatures
        {
            get { return this._enabledFeatures; }
            set { this._enabledFeatures = value; }
        }

        // Check to see if EnabledFeatures property is set
        internal bool IsSetEnabledFeatures()
        {
            return this._enabledFeatures != null && (this._enabledFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The unique identifier (ID) of an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Max=34)]
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