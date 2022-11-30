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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomain operation.
    /// Updates the default settings for new user profiles in the domain.
    /// </summary>
    public partial class UpdateDomainRequest : AmazonSageMakerRequest
    {
        private DefaultSpaceSettings _defaultSpaceSettings;
        private UserSettings _defaultUserSettings;
        private string _domainId;
        private DomainSettingsForUpdate _domainSettingsForUpdate;

        /// <summary>
        /// Gets and sets the property DefaultSpaceSettings. 
        /// <para>
        /// The default settings used to create a space within the Domain.
        /// </para>
        /// </summary>
        public DefaultSpaceSettings DefaultSpaceSettings
        {
            get { return this._defaultSpaceSettings; }
            set { this._defaultSpaceSettings = value; }
        }

        // Check to see if DefaultSpaceSettings property is set
        internal bool IsSetDefaultSpaceSettings()
        {
            return this._defaultSpaceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultUserSettings. 
        /// <para>
        /// A collection of settings.
        /// </para>
        /// </summary>
        public UserSettings DefaultUserSettings
        {
            get { return this._defaultUserSettings; }
            set { this._defaultUserSettings = value; }
        }

        // Check to see if DefaultUserSettings property is set
        internal bool IsSetDefaultUserSettings()
        {
            return this._defaultUserSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the domain to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainSettingsForUpdate. 
        /// <para>
        /// A collection of <code>DomainSettings</code> configuration values to update.
        /// </para>
        /// </summary>
        public DomainSettingsForUpdate DomainSettingsForUpdate
        {
            get { return this._domainSettingsForUpdate; }
            set { this._domainSettingsForUpdate = value; }
        }

        // Check to see if DomainSettingsForUpdate property is set
        internal bool IsSetDomainSettingsForUpdate()
        {
            return this._domainSettingsForUpdate != null;
        }

    }
}