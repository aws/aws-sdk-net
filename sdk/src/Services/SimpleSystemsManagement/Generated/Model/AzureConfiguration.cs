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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The access details and targets for connecting to a Microsoft Azure tenant, including
    /// the application registration used for authentication and the subscriptions to target.
    /// </summary>
    public partial class AzureConfiguration
    {
        private string _applicationDisplayName;
        private string _applicationId;
        private ConfigurationTargets _targets;
        private string _tenantDisplayName;
        private string _tenantId;

        /// <summary>
        /// Gets and sets the property ApplicationDisplayName. 
        /// <para>
        /// The display name of the Azure application registration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ApplicationDisplayName
        {
            get { return this._applicationDisplayName; }
            set { this._applicationDisplayName = value; }
        }

        // Check to see if ApplicationDisplayName property is set
        internal bool IsSetApplicationDisplayName()
        {
            return this._applicationDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the Azure application registration used for authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property Targets. 
        /// <para>
        /// The target Azure subscriptions for the cloud connector.
        /// </para>
        /// </summary>
        public ConfigurationTargets Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null;
        }

        /// <summary>
        /// Gets and sets the property TenantDisplayName. 
        /// <para>
        /// The display name of the Azure tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string TenantDisplayName
        {
            get { return this._tenantDisplayName; }
            set { this._tenantDisplayName = value; }
        }

        // Check to see if TenantDisplayName property is set
        internal bool IsSetTenantDisplayName()
        {
            return this._tenantDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The ID of the Azure tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TenantId
        {
            get { return this._tenantId; }
            set { this._tenantId = value; }
        }

        // Check to see if TenantId property is set
        internal bool IsSetTenantId()
        {
            return this._tenantId != null;
        }

    }
}