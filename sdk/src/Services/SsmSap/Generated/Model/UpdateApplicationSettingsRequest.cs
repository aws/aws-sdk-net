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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplicationSettings operation.
    /// Updates the settings of an application registered with AWS Systems Manager for SAP.
    /// </summary>
    public partial class UpdateApplicationSettingsRequest : AmazonSsmSapRequest
    {
        private string _applicationId;
        private List<ApplicationCredential> _credentialsToAddOrUpdate = new List<ApplicationCredential>();
        private List<ApplicationCredential> _credentialsToRemove = new List<ApplicationCredential>();

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialsToAddOrUpdate. 
        /// <para>
        /// The credentials to be added or updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<ApplicationCredential> CredentialsToAddOrUpdate
        {
            get { return this._credentialsToAddOrUpdate; }
            set { this._credentialsToAddOrUpdate = value; }
        }

        // Check to see if CredentialsToAddOrUpdate property is set
        internal bool IsSetCredentialsToAddOrUpdate()
        {
            return this._credentialsToAddOrUpdate != null && this._credentialsToAddOrUpdate.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CredentialsToRemove. 
        /// <para>
        /// The credentials to be removed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<ApplicationCredential> CredentialsToRemove
        {
            get { return this._credentialsToRemove; }
            set { this._credentialsToRemove = value; }
        }

        // Check to see if CredentialsToRemove property is set
        internal bool IsSetCredentialsToRemove()
        {
            return this._credentialsToRemove != null && this._credentialsToRemove.Count > 0; 
        }

    }
}