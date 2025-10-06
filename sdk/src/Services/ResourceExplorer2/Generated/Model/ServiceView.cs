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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Contains the configuration and properties of a Resource Explorer service view.
    /// </summary>
    public partial class ServiceView
    {
        private SearchFilter _filters;
        private List<IncludedProperty> _includedProperties = AWSConfigs.InitializeCollections ? new List<IncludedProperty>() : null;
        private string _scopeType;
        private string _serviceViewArn;
        private string _streamingAccessForService;

        /// <summary>
        /// Gets and sets the property Filters.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public SearchFilter Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedProperties. 
        /// <para>
        /// A list of additional resource properties that are included in this view for search
        /// and filtering purposes.
        /// </para>
        /// </summary>
        public List<IncludedProperty> IncludedProperties
        {
            get { return this._includedProperties; }
            set { this._includedProperties = value; }
        }

        // Check to see if IncludedProperties property is set
        internal bool IsSetIncludedProperties()
        {
            return this._includedProperties != null && (this._includedProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScopeType. 
        /// <para>
        /// The scope type of the service view, which determines what resources are included.
        /// </para>
        /// </summary>
        public string ScopeType
        {
            get { return this._scopeType; }
            set { this._scopeType = value; }
        }

        // Check to see if ScopeType property is set
        internal bool IsSetScopeType()
        {
            return this._scopeType != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceViewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service view.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceViewArn
        {
            get { return this._serviceViewArn; }
            set { this._serviceViewArn = value; }
        }

        // Check to see if ServiceViewArn property is set
        internal bool IsSetServiceViewArn()
        {
            return this._serviceViewArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingAccessForService. 
        /// <para>
        /// The Amazon Web Services service that has streaming access to this view's data.
        /// </para>
        /// </summary>
        public string StreamingAccessForService
        {
            get { return this._streamingAccessForService; }
            set { this._streamingAccessForService = value; }
        }

        // Check to see if StreamingAccessForService property is set
        internal bool IsSetStreamingAccessForService()
        {
            return this._streamingAccessForService != null;
        }

    }
}