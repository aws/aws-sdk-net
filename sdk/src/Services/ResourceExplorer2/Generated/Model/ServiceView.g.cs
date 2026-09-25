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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Filters.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public SearchFilter Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property IncludedProperties. 
        /// <para>
        /// A list of additional resource properties that are included in this view for search
        /// and filtering purposes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IncludedProperty> IncludedProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<IncludedProperty>() : null;

        /// <summary>
        /// Checks to see if the IncludedProperties property is set.
        /// </summary>
        internal bool IsSetIncludedProperties() => this.IncludedProperties != null && (this.IncludedProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScopeType. 
        /// <para>
        /// The scope type of the service view, which determines what resources are included.
        /// </para>
        /// </summary>
        public string ScopeType { get; set; }

        /// <summary>
        /// Checks to see if the ScopeType property is set.
        /// </summary>
        internal bool IsSetScopeType() => this.ScopeType != null;

        /// <summary>
        /// Gets and sets the property ServiceLinkedRecorder. 
        /// <para>
        /// Information about the service-linked recorder associated with this service view. When
        /// a service view is paired with a service-linked recorder, Resource Explorer uses the
        /// recorder's resource type list to filter search results and streaming data.
        /// </para>
        /// </summary>
        public ServiceLinkedRecorderInfo ServiceLinkedRecorder { get; set; }

        /// <summary>
        /// Checks to see if the ServiceLinkedRecorder property is set.
        /// </summary>
        internal bool IsSetServiceLinkedRecorder() => this.ServiceLinkedRecorder != null;

        /// <summary>
        /// Gets and sets the property ServiceViewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service view.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceViewArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceViewArn property is set.
        /// </summary>
        internal bool IsSetServiceViewArn() => this.ServiceViewArn != null;

        /// <summary>
        /// Gets and sets the property ServiceViewName. 
        /// <para>
        /// The name of the service view.
        /// </para>
        /// </summary>
        public string ServiceViewName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceViewName property is set.
        /// </summary>
        internal bool IsSetServiceViewName() => this.ServiceViewName != null;

        /// <summary>
        /// Gets and sets the property StreamingAccessForService. 
        /// <para>
        /// The Amazon Web Services service that has streaming access to this view's data.
        /// </para>
        /// </summary>
        public string StreamingAccessForService { get; set; }

        /// <summary>
        /// Checks to see if the StreamingAccessForService property is set.
        /// </summary>
        internal bool IsSetStreamingAccessForService() => this.StreamingAccessForService != null;
    }
}
