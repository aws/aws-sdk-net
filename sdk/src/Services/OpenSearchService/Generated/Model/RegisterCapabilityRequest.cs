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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterCapability operation.
    /// Registers a capability for an OpenSearch UI application. Use this operation to enable
    /// specific capabilities, such as AI features, for a given application. The capability
    /// configuration defines the type and settings of the capability to register. For more
    /// information about the AI features, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/application-ai-assistant.html">Agentic
    /// AI for OpenSearch UI</a>.
    /// </summary>
    public partial class RegisterCapabilityRequest : AmazonOpenSearchServiceRequest
    {
        private string _applicationId;
        private CapabilityBaseRequestConfig _capabilityConfig;
        private string _capabilityName;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the OpenSearch UI application to register the capability
        /// for.
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
        /// Gets and sets the property CapabilityConfig. 
        /// <para>
        /// The configuration settings for the capability being registered. This includes capability-specific
        /// settings such as AI configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapabilityBaseRequestConfig CapabilityConfig
        {
            get { return this._capabilityConfig; }
            set { this._capabilityConfig = value; }
        }

        // Check to see if CapabilityConfig property is set
        internal bool IsSetCapabilityConfig()
        {
            return this._capabilityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CapabilityName. 
        /// <para>
        /// The name of the capability to register. Must be between 3 and 30 characters and contain
        /// only alphanumeric characters and hyphens. This identifies the type of capability being
        /// enabled for the application. For registering AI Assistant capability, use <c>ai-capability</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=30)]
        public string CapabilityName
        {
            get { return this._capabilityName; }
            set { this._capabilityName = value; }
        }

        // Check to see if CapabilityName property is set
        internal bool IsSetCapabilityName()
        {
            return this._capabilityName != null;
        }

    }
}