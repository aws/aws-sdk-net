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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Details about a prompt router.
    /// </summary>
    public partial class PromptRouterSummary
    {
        private DateTime? _createdAt;
        private string _description;
        private PromptRouterTargetModel _fallbackModel;
        private List<PromptRouterTargetModel> _models = AWSConfigs.InitializeCollections ? new List<PromptRouterTargetModel>() : null;
        private string _promptRouterArn;
        private string _promptRouterName;
        private RoutingCriteria _routingCriteria;
        private PromptRouterStatus _status;
        private PromptRouterType _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When the router was created.
        /// </para>
        /// </summary>
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
        /// The router's description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
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
        /// Gets and sets the property FallbackModel. 
        /// <para>
        /// The router's fallback model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PromptRouterTargetModel FallbackModel
        {
            get { return this._fallbackModel; }
            set { this._fallbackModel = value; }
        }

        // Check to see if FallbackModel property is set
        internal bool IsSetFallbackModel()
        {
            return this._fallbackModel != null;
        }

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// The router's models.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PromptRouterTargetModel> Models
        {
            get { return this._models; }
            set { this._models = value; }
        }

        // Check to see if Models property is set
        internal bool IsSetModels()
        {
            return this._models != null && (this._models.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PromptRouterArn. 
        /// <para>
        /// The router's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string PromptRouterArn
        {
            get { return this._promptRouterArn; }
            set { this._promptRouterArn = value; }
        }

        // Check to see if PromptRouterArn property is set
        internal bool IsSetPromptRouterArn()
        {
            return this._promptRouterArn != null;
        }

        /// <summary>
        /// Gets and sets the property PromptRouterName. 
        /// <para>
        /// The router's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PromptRouterName
        {
            get { return this._promptRouterName; }
            set { this._promptRouterName = value; }
        }

        // Check to see if PromptRouterName property is set
        internal bool IsSetPromptRouterName()
        {
            return this._promptRouterName != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingCriteria. 
        /// <para>
        /// The router's routing criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RoutingCriteria RoutingCriteria
        {
            get { return this._routingCriteria; }
            set { this._routingCriteria = value; }
        }

        // Check to see if RoutingCriteria property is set
        internal bool IsSetRoutingCriteria()
        {
            return this._routingCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The router's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PromptRouterStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The summary's type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PromptRouterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// When the router was updated.
        /// </para>
        /// </summary>
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