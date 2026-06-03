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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// This is the response object from the GetWhatsAppFlow operation.
    /// </summary>
    public partial class GetWhatsAppFlowResponse : AmazonWebServiceResponse
    {
        private MetaFlowApplicationInfo _application;
        private List<string> _categories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _dataApiVersion;
        private string _endpointUri;
        private string _flowId;
        private string _flowName;
        private string _flowStatus;
        private MetaFlowHealthStatus _healthStatus;
        private string _jsonVersion;
        private MetaFlowPreviewInfo _preview;
        private List<string> _validationErrors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MetaFlowWhatsAppBusinessAccountInfo _whatsAppBusinessAccount;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// The Meta application information associated with this Flow.
        /// </para>
        /// </summary>
        public MetaFlowApplicationInfo Application
        {
            get { return this._application; }
            set { this._application = value; }
        }

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this._application != null;
        }

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The categories that classify the business purpose of the Flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=9)]
        public List<string> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataApiVersion. 
        /// <para>
        /// The data API version for data exchange endpoint Flows.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string DataApiVersion
        {
            get { return this._dataApiVersion; }
            set { this._dataApiVersion = value; }
        }

        // Check to see if DataApiVersion property is set
        internal bool IsSetDataApiVersion()
        {
            return this._dataApiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointUri. 
        /// <para>
        /// The endpoint URI for data exchange Flows, if configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EndpointUri
        {
            get { return this._endpointUri; }
            set { this._endpointUri = value; }
        }

        // Check to see if EndpointUri property is set
        internal bool IsSetEndpointUri()
        {
            return this._endpointUri != null;
        }

        /// <summary>
        /// Gets and sets the property FlowId. 
        /// <para>
        /// The unique identifier of the Flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string FlowId
        {
            get { return this._flowId; }
            set { this._flowId = value; }
        }

        // Check to see if FlowId property is set
        internal bool IsSetFlowId()
        {
            return this._flowId != null;
        }

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        /// The name of the Flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string FlowName
        {
            get { return this._flowName; }
            set { this._flowName = value; }
        }

        // Check to see if FlowName property is set
        internal bool IsSetFlowName()
        {
            return this._flowName != null;
        }

        /// <summary>
        /// Gets and sets the property FlowStatus. 
        /// <para>
        /// The lifecycle status of the Flow. Valid values are DRAFT, PUBLISHED, DEPRECATED, BLOCKED,
        /// and THROTTLED.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string FlowStatus
        {
            get { return this._flowStatus; }
            set { this._flowStatus = value; }
        }

        // Check to see if FlowStatus property is set
        internal bool IsSetFlowStatus()
        {
            return this._flowStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status information for this Flow from Meta.
        /// </para>
        /// </summary>
        public MetaFlowHealthStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property JsonVersion. 
        /// <para>
        /// The version of the Flow JSON schema used by this Flow (for example, 7.3).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string JsonVersion
        {
            get { return this._jsonVersion; }
            set { this._jsonVersion = value; }
        }

        // Check to see if JsonVersion property is set
        internal bool IsSetJsonVersion()
        {
            return this._jsonVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Preview. 
        /// <para>
        /// The preview URL and its expiration timestamp for testing the Flow.
        /// </para>
        /// </summary>
        public MetaFlowPreviewInfo Preview
        {
            get { return this._preview; }
            set { this._preview = value; }
        }

        // Check to see if Preview property is set
        internal bool IsSetPreview()
        {
            return this._preview != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationErrors. 
        /// <para>
        /// A list of validation errors from Meta, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValidationErrors
        {
            get { return this._validationErrors; }
            set { this._validationErrors = value; }
        }

        // Check to see if ValidationErrors property is set
        internal bool IsSetValidationErrors()
        {
            return this._validationErrors != null && (this._validationErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WhatsAppBusinessAccount. 
        /// <para>
        /// The WhatsApp Business Account information from Meta associated with this Flow.
        /// </para>
        /// </summary>
        public MetaFlowWhatsAppBusinessAccountInfo WhatsAppBusinessAccount
        {
            get { return this._whatsAppBusinessAccount; }
            set { this._whatsAppBusinessAccount = value; }
        }

        // Check to see if WhatsAppBusinessAccount property is set
        internal bool IsSetWhatsAppBusinessAccount()
        {
            return this._whatsAppBusinessAccount != null;
        }

    }
}