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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourceConfig operation.
    /// Records the configuration state for the resource provided in the request. The configuration
    /// state of a resource is represented in Config as Configuration Items. Once this API
    /// records the configuration item, you can retrieve the list of configuration items for
    /// the custom resource type using existing Config APIs. 
    /// 
    ///  <note> 
    /// <para>
    /// The custom resource type must be registered with CloudFormation. This API accepts
    /// the configuration item registered with CloudFormation.
    /// </para>
    ///  
    /// <para>
    /// When you call this API, Config only stores configuration state of the resource provided
    /// in the request. This API does not change or remediate the configuration of the resource.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Write-only schema properites are not recorded as part of the published configuration
    /// item.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutResourceConfigRequest : AmazonConfigServiceRequest
    {
        private string _configuration;
        private string _resourceId;
        private string _resourceName;
        private string _resourceType;
        private string _schemaVersionId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration object of the resource in valid JSON format. It must match the schema
        /// registered with CloudFormation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The configuration JSON must not exceed 64 KB.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Unique identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=768)]
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
        /// Name of the resource.
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource. The custom resource type must be registered with CloudFormation.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot use the organization names “amzn”, “amazon”, “alexa”, “custom” with custom
        /// resource types. It is the first part of the ResourceType up to the first ::.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=196)]
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

        /// <summary>
        /// Gets and sets the property SchemaVersionId. 
        /// <para>
        /// Version of the schema registered for the ResourceType in CloudFormation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string SchemaVersionId
        {
            get { return this._schemaVersionId; }
            set { this._schemaVersionId = value; }
        }

        // Check to see if SchemaVersionId property is set
        internal bool IsSetSchemaVersionId()
        {
            return this._schemaVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is not to be confused with the Amazon Web Services-wide tag feature for
        /// Amazon Web Services resources. Tags for <c>PutResourceConfig</c> are tags that you
        /// supply for the configuration items of your custom resources.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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