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
    /// The result of a <c>GetCapability</c> request. Contains details about the capability.
    /// </summary>
    public partial class GetCapabilityResponse : AmazonWebServiceResponse
    {
        private string _applicationId;
        private CapabilityExtendedResponseConfig _capabilityConfig;
        private string _capabilityName;
        private List<CapabilityFailure> _failures = AWSConfigs.InitializeCollections ? new List<CapabilityFailure>() : null;
        private CapabilityStatus _status;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the OpenSearch UI application.
        /// </para>
        /// </summary>
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
        /// The configuration settings for the capability, including capability-specific settings
        /// such as AI configuration.
        /// </para>
        /// </summary>
        public CapabilityExtendedResponseConfig CapabilityConfig
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
        /// The name of the capability.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=30)]
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

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// A list of failures associated with the capability, if any. Each failure includes a
        /// reason and details about what went wrong.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapabilityFailure> Failures
        {
            get { return this._failures; }
            set { this._failures = value; }
        }

        // Check to see if Failures property is set
        internal bool IsSetFailures()
        {
            return this._failures != null && (this._failures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the capability. Possible values: <c>creating</c>, <c>create_failed</c>,
        /// <c>active</c>, <c>updating</c>, <c>update_failed</c>, <c>deleting</c>, <c>delete_failed</c>.
        /// </para>
        /// </summary>
        public CapabilityStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}