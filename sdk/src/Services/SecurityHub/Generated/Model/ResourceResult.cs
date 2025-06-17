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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides comprehensive details about an Amazon Web Services resource and its associated
    /// security findings.
    /// </summary>
    public partial class ResourceResult
    {
        private string _accountId;
        private List<ResourceFindingsSummary> _findingsSummary = AWSConfigs.InitializeCollections ? new List<ResourceFindingsSummary>() : null;
        private string _region;
        private string _resourceArn;
        private ResourceCategory _resourceCategory;
        private Amazon.Runtime.Documents.Document _resourceConfig;
        private string _resourceCreationTimeDt;
        private string _resourceDetailCaptureTimeDt;
        private string _resourceId;
        private string _resourceName;
        private List<ResourceTag> _resourceTags = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property FindingsSummary. 
        /// <para>
        /// An aggregated view of security findings associated with a resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceFindingsSummary> FindingsSummary
        {
            get { return this._findingsSummary; }
            set { this._findingsSummary = value; }
        }

        // Check to see if FindingsSummary property is set
        internal bool IsSetFindingsSummary()
        {
            return this._findingsSummary != null && (this._findingsSummary.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the resource is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Specifies the ARN that uniquely identifies a resource.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCategory. 
        /// <para>
        /// The grouping where the resource belongs.
        /// </para>
        /// </summary>
        public ResourceCategory ResourceCategory
        {
            get { return this._resourceCategory; }
            set { this._resourceCategory = value; }
        }

        // Check to see if ResourceCategory property is set
        internal bool IsSetResourceCategory()
        {
            return this._resourceCategory != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The configuration details of a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document ResourceConfig
        {
            get { return this._resourceConfig; }
            set { this._resourceConfig = value; }
        }

        // Check to see if ResourceConfig property is set
        internal bool IsSetResourceConfig()
        {
            return !this._resourceConfig.IsNull();
        }

        /// <summary>
        /// Gets and sets the property ResourceCreationTimeDt. 
        /// <para>
        /// The time when the resource was created.
        /// </para>
        /// </summary>
        public string ResourceCreationTimeDt
        {
            get { return this._resourceCreationTimeDt; }
            set { this._resourceCreationTimeDt = value; }
        }

        // Check to see if ResourceCreationTimeDt property is set
        internal bool IsSetResourceCreationTimeDt()
        {
            return this._resourceCreationTimeDt != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceDetailCaptureTimeDt. 
        /// <para>
        /// The timestamp when information about the resource was captured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceDetailCaptureTimeDt
        {
            get { return this._resourceDetailCaptureTimeDt; }
            set { this._resourceDetailCaptureTimeDt = value; }
        }

        // Check to see if ResourceDetailCaptureTimeDt property is set
        internal bool IsSetResourceDetailCaptureTimeDt()
        {
            return this._resourceDetailCaptureTimeDt != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique identifier for a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource.
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The key-value pairs associated with a resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceTag> ResourceTags
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}