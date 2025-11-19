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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// This is the response object from the CreatePortal operation.
    /// </summary>
    public partial class CreatePortalResponse : AmazonWebServiceResponse
    {
        private Authorization _authorization;
        private EndpointConfigurationResponse _endpointConfiguration;
        private List<string> _includedPortalProductArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastModified;
        private DateTime? _lastPublished;
        private string _lastPublishedDescription;
        private string _portalArn;
        private PortalContent _portalContent;
        private string _portalId;
        private PublishStatus _publishStatus;
        private string _rumAppMonitorName;
        private StatusException _statusException;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Authorization. 
        /// <para>
        /// The authorization for the portal. Supports Cognito-based user authentication or no
        /// authentication.
        /// </para>
        /// </summary>
        public Authorization Authorization
        {
            get { return this._authorization; }
            set { this._authorization = value; }
        }

        // Check to see if Authorization property is set
        internal bool IsSetAuthorization()
        {
            return this._authorization != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The endpoint configuration.
        /// </para>
        /// </summary>
        public EndpointConfigurationResponse EndpointConfiguration
        {
            get { return this._endpointConfiguration; }
            set { this._endpointConfiguration = value; }
        }

        // Check to see if EndpointConfiguration property is set
        internal bool IsSetEndpointConfiguration()
        {
            return this._endpointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedPortalProductArns. 
        /// <para>
        /// The ARNs of the portal products included in the portal.
        /// </para>
        /// </summary>
        public List<string> IncludedPortalProductArns
        {
            get { return this._includedPortalProductArns; }
            set { this._includedPortalProductArns = value; }
        }

        // Check to see if IncludedPortalProductArns property is set
        internal bool IsSetIncludedPortalProductArns()
        {
            return this._includedPortalProductArns != null && (this._includedPortalProductArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The timestamp when the portal configuration was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModified
        {
            get { return this._lastModified.GetValueOrDefault(); }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastPublished. 
        /// <para>
        /// The timestamp when the portal was last published.
        /// </para>
        /// </summary>
        public DateTime LastPublished
        {
            get { return this._lastPublished.GetValueOrDefault(); }
            set { this._lastPublished = value; }
        }

        // Check to see if LastPublished property is set
        internal bool IsSetLastPublished()
        {
            return this._lastPublished.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastPublishedDescription. 
        /// <para>
        /// A user-written description of the changes made in the last published version of the
        /// portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LastPublishedDescription
        {
            get { return this._lastPublishedDescription; }
            set { this._lastPublishedDescription = value; }
        }

        // Check to see if LastPublishedDescription property is set
        internal bool IsSetLastPublishedDescription()
        {
            return this._lastPublishedDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PortalArn. 
        /// <para>
        /// The ARN of the portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PortalArn
        {
            get { return this._portalArn; }
            set { this._portalArn = value; }
        }

        // Check to see if PortalArn property is set
        internal bool IsSetPortalArn()
        {
            return this._portalArn != null;
        }

        /// <summary>
        /// Gets and sets the property PortalContent. 
        /// <para>
        /// The name, description, and theme for the portal.
        /// </para>
        /// </summary>
        public PortalContent PortalContent
        {
            get { return this._portalContent; }
            set { this._portalContent = value; }
        }

        // Check to see if PortalContent property is set
        internal bool IsSetPortalContent()
        {
            return this._portalContent != null;
        }

        /// <summary>
        /// Gets and sets the property PortalId. 
        /// <para>
        /// The portal identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=30)]
        public string PortalId
        {
            get { return this._portalId; }
            set { this._portalId = value; }
        }

        // Check to see if PortalId property is set
        internal bool IsSetPortalId()
        {
            return this._portalId != null;
        }

        /// <summary>
        /// Gets and sets the property PublishStatus. 
        /// <para>
        /// The current publishing status of the portal.
        /// </para>
        /// </summary>
        public PublishStatus PublishStatus
        {
            get { return this._publishStatus; }
            set { this._publishStatus = value; }
        }

        // Check to see if PublishStatus property is set
        internal bool IsSetPublishStatus()
        {
            return this._publishStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RumAppMonitorName. 
        /// <para>
        /// The name of the Amazon CloudWatch RUM app monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string RumAppMonitorName
        {
            get { return this._rumAppMonitorName; }
            set { this._rumAppMonitorName = value; }
        }

        // Check to see if RumAppMonitorName property is set
        internal bool IsSetRumAppMonitorName()
        {
            return this._rumAppMonitorName != null;
        }

        /// <summary>
        /// Gets and sets the property StatusException. 
        /// <para>
        /// Error information for failed portal operations. Contains details about any issues
        /// encountered during portal creation or publishing.
        /// </para>
        /// </summary>
        public StatusException StatusException
        {
            get { return this._statusException; }
            set { this._statusException = value; }
        }

        // Check to see if StatusException property is set
        internal bool IsSetStatusException()
        {
            return this._statusException != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The collection of tags. Each tag element is associated with a given resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}