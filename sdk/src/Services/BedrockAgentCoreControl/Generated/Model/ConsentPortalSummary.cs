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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Summary information about a consent portal.
    /// </summary>
    public partial class ConsentPortalSummary
    {
        private string _consentPortalArn;
        private string _consentPortalId;
        private DateTime? _createdAt;
        private string _description;
        private string _name;
        private string _portalUrl;
        private List<ConsentPortalSource> _sources = AWSConfigs.InitializeCollections ? new List<ConsentPortalSource>() : null;
        private ConsentPortalStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ConsentPortalArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the consent portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConsentPortalArn
        {
            get { return this._consentPortalArn; }
            set { this._consentPortalArn = value; }
        }

        // Check to see if ConsentPortalArn property is set
        internal bool IsSetConsentPortalArn()
        {
            return this._consentPortalArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConsentPortalId. 
        /// <para>
        /// The unique identifier of the consent portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConsentPortalId
        {
            get { return this._consentPortalId; }
            set { this._consentPortalId = value; }
        }

        // Check to see if ConsentPortalId property is set
        internal bool IsSetConsentPortalId()
        {
            return this._consentPortalId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp for when the consent portal was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the consent portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the consent portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PortalUrl. 
        /// <para>
        /// The URL used to access the consent portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string PortalUrl
        {
            get { return this._portalUrl; }
            set { this._portalUrl = value; }
        }

        // Check to see if PortalUrl property is set
        internal bool IsSetPortalUrl()
        {
            return this._portalUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The resources served by the consent portal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<ConsentPortalSource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the consent portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConsentPortalStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp for when the consent portal was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}