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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a physical resource. A physical resource is a resource that exists in your
    /// account. It can be identified using an Amazon Resource Name (ARN) or an Resilience
    /// Hub-native identifier.
    /// </summary>
    public partial class PhysicalResource
    {
        private Dictionary<string, List<string>> _additionalInfo = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private List<AppComponent> _appComponents = AWSConfigs.InitializeCollections ? new List<AppComponent>() : null;
        private bool? _excluded;
        private LogicalResourceId _logicalResourceId;
        private string _parentResourceName;
        private PhysicalResourceId _physicalResourceId;
        private string _resourceName;
        private string _resourceType;
        private ResourceSourceType _sourceType;

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Additional configuration parameters for an Resilience Hub application. If you want
        /// to implement <c>additionalInfo</c> through the Resilience Hub console rather than
        /// using an API call, see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/app-config-param.html">Configure
        /// the application configuration parameters</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, this parameter accepts a key-value mapping (in a string format) of only
        /// one failover region and one associated account.
        /// </para>
        ///  
        /// <para>
        /// Key: <c>"failover-regions"</c> 
        /// </para>
        ///  
        /// <para>
        /// Value: <c>"[{"region":"&lt;REGION&gt;", "accounts":[{"id":"&lt;ACCOUNT_ID&gt;"}]}]"</c>
        /// 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null && (this._additionalInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AppComponents. 
        /// <para>
        /// The application components that belong to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AppComponent> AppComponents
        {
            get { return this._appComponents; }
            set { this._appComponents = value; }
        }

        // Check to see if AppComponents property is set
        internal bool IsSetAppComponents()
        {
            return this._appComponents != null && (this._appComponents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Excluded. 
        /// <para>
        /// Indicates if a resource is included or excluded from the assessment.
        /// </para>
        /// </summary>
        public bool? Excluded
        {
            get { return this._excluded; }
            set { this._excluded = value; }
        }

        // Check to see if Excluded property is set
        internal bool IsSetExcluded()
        {
            return this._excluded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// Logical identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LogicalResourceId LogicalResourceId
        {
            get { return this._logicalResourceId; }
            set { this._logicalResourceId = value; }
        }

        // Check to see if LogicalResourceId property is set
        internal bool IsSetLogicalResourceId()
        {
            return this._logicalResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ParentResourceName. 
        /// <para>
        /// Name of the parent resource.
        /// </para>
        /// </summary>
        public string ParentResourceName
        {
            get { return this._parentResourceName; }
            set { this._parentResourceName = value; }
        }

        // Check to see if ParentResourceName property is set
        internal bool IsSetParentResourceName()
        {
            return this._parentResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// Identifier of the physical resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PhysicalResourceId PhysicalResourceId
        {
            get { return this._physicalResourceId; }
            set { this._physicalResourceId = value; }
        }

        // Check to see if PhysicalResourceId property is set
        internal bool IsSetPhysicalResourceId()
        {
            return this._physicalResourceId != null;
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Type of resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Type of input source.
        /// </para>
        /// </summary>
        public ResourceSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}