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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the GetConfigurationProfile operation.
    /// Retrieve information about a configuration profile.
    /// </summary>
    public partial class GetConfigurationProfileRequest : AmazonAppConfigRequest
    {
        private string _applicationId;
        private string _configurationProfileId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application that includes the configuration profile you want to get.
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
        /// Gets and sets the property ConfigurationProfileId. 
        /// <para>
        /// The ID of the configuration profile you want to get.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationProfileId
        {
            get { return this._configurationProfileId; }
            set { this._configurationProfileId = value; }
        }

        // Check to see if ConfigurationProfileId property is set
        internal bool IsSetConfigurationProfileId()
        {
            return this._configurationProfileId != null;
        }

    }
}