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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the StartBatchDeleteConfigurationTask operation.
    /// Takes a list of configurationId as input and starts an asynchronous deletion task
    /// to remove the configurationItems. Returns a unique deletion task identifier.
    /// </summary>
    public partial class StartBatchDeleteConfigurationTaskRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<string> _configurationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DeletionConfigurationItemType _configurationType;

        /// <summary>
        /// Gets and sets the property ConfigurationIds. 
        /// <para>
        ///  The list of configuration IDs that will be deleted by the task. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ConfigurationIds
        {
            get { return this._configurationIds; }
            set { this._configurationIds = value; }
        }

        // Check to see if ConfigurationIds property is set
        internal bool IsSetConfigurationIds()
        {
            return this._configurationIds != null && (this._configurationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        ///  The type of configuration item to delete. Supported types are: SERVER. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeletionConfigurationItemType ConfigurationType
        {
            get { return this._configurationType; }
            set { this._configurationType = value; }
        }

        // Check to see if ConfigurationType property is set
        internal bool IsSetConfigurationType()
        {
            return this._configurationType != null;
        }

    }
}