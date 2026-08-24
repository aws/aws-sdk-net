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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Typed content structure for a context. Contains application-specific fields that describe
    /// the environment used during recommendation generation.
    /// </summary>
    public partial class ContextContent
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _additionalContext;
        private string _applicationOverview;
        private ApplicationType _applicationType;
        private string _architectureOverview;
        private List<string> _awsServices = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Criticality _criticality;
        private string _industry;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ContextResourceTag> _resourceTags = AWSConfigs.InitializeCollections ? new List<ContextResourceTag>() : null;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The Amazon Web Services account IDs associated with this application context.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AdditionalContext. 
        /// <para>
        /// Additional context not captured by other fields.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=10000)]
        public string AdditionalContext
        {
            get { return this._additionalContext; }
            set { this._additionalContext = value; }
        }

        // Check to see if AdditionalContext property is set
        internal bool IsSetAdditionalContext()
        {
            return this._additionalContext != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationOverview. 
        /// <para>
        /// A free-form overview of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=10000)]
        public string ApplicationOverview
        {
            get { return this._applicationOverview; }
            set { this._applicationOverview = value; }
        }

        // Check to see if ApplicationOverview property is set
        internal bool IsSetApplicationOverview()
        {
            return this._applicationOverview != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// The type of the application.
        /// </para>
        /// </summary>
        public ApplicationType ApplicationType
        {
            get { return this._applicationType; }
            set { this._applicationType = value; }
        }

        // Check to see if ApplicationType property is set
        internal bool IsSetApplicationType()
        {
            return this._applicationType != null;
        }

        /// <summary>
        /// Gets and sets the property ArchitectureOverview. 
        /// <para>
        /// A free-form description of the application architecture.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=10000)]
        public string ArchitectureOverview
        {
            get { return this._architectureOverview; }
            set { this._architectureOverview = value; }
        }

        // Check to see if ArchitectureOverview property is set
        internal bool IsSetArchitectureOverview()
        {
            return this._architectureOverview != null;
        }

        /// <summary>
        /// Gets and sets the property AwsServices. 
        /// <para>
        /// The Amazon Web Services services used by this application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public List<string> AwsServices
        {
            get { return this._awsServices; }
            set { this._awsServices = value; }
        }

        // Check to see if AwsServices property is set
        internal bool IsSetAwsServices()
        {
            return this._awsServices != null && (this._awsServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        /// The business criticality of the application.
        /// </para>
        /// </summary>
        public Criticality Criticality
        {
            get { return this._criticality; }
            set { this._criticality = value; }
        }

        // Check to see if Criticality property is set
        internal bool IsSetCriticality()
        {
            return this._criticality != null;
        }

        /// <summary>
        /// Gets and sets the property Industry. 
        /// <para>
        /// The industry vertical for this application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public string Industry
        {
            get { return this._industry; }
            set { this._industry = value; }
        }

        // Check to see if Industry property is set
        internal bool IsSetIndustry()
        {
            return this._industry != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Amazon Web Services Regions where this application operates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// Resource tags used to scope this application context.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<ContextResourceTag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The Amazon Web Services resource types relevant to this application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1500)]
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}