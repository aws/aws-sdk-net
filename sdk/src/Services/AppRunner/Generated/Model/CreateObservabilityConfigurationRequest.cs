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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the CreateObservabilityConfiguration operation.
    /// Create an App Runner observability configuration resource. App Runner requires this
    /// resource when you create or update App Runner services and you want to enable non-default
    /// observability features. You can share an observability configuration across multiple
    /// services.
    /// 
    ///  
    /// <para>
    /// Create multiple revisions of a configuration by calling this action multiple times
    /// using the same <c>ObservabilityConfigurationName</c>. The call returns incremental
    /// <c>ObservabilityConfigurationRevision</c> values. When you create a service and configure
    /// an observability configuration resource, the service uses the latest active revision
    /// of the observability configuration by default. You can optionally configure the service
    /// to use a specific revision.
    /// </para>
    ///  
    /// <para>
    /// The observability configuration resource is designed to configure multiple features
    /// (currently one feature, tracing). This action takes optional parameters that describe
    /// the configuration of these features (currently one parameter, <c>TraceConfiguration</c>).
    /// If you don't specify a feature parameter, App Runner doesn't enable the feature.
    /// </para>
    /// </summary>
    public partial class CreateObservabilityConfigurationRequest : AmazonAppRunnerRequest
    {
        private string _observabilityConfigurationName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TraceConfiguration _traceConfiguration;

        /// <summary>
        /// Gets and sets the property ObservabilityConfigurationName. 
        /// <para>
        /// A name for the observability configuration. When you use it for the first time in
        /// an Amazon Web Services Region, App Runner creates revision number <c>1</c> of this
        /// name. When you use the same name in subsequent calls, App Runner creates incremental
        /// revisions of the configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// The name <c>DefaultConfiguration</c> is reserved. You can't use it to create a new
        /// observability configuration, and you can't create a revision of it.
        /// </para>
        ///  
        /// <para>
        /// When you want to use your own observability configuration for your App Runner service,
        /// <i>create a configuration with a different name</i>, and then provide it when you
        /// create or update your service.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=32)]
        public string ObservabilityConfigurationName
        {
            get { return this._observabilityConfigurationName; }
            set { this._observabilityConfigurationName = value; }
        }

        // Check to see if ObservabilityConfigurationName property is set
        internal bool IsSetObservabilityConfigurationName()
        {
            return this._observabilityConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of metadata items that you can associate with your observability configuration
        /// resource. A tag is a key-value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TraceConfiguration. 
        /// <para>
        /// The configuration of the tracing feature within this observability configuration.
        /// If you don't specify it, App Runner doesn't enable tracing.
        /// </para>
        /// </summary>
        public TraceConfiguration TraceConfiguration
        {
            get { return this._traceConfiguration; }
            set { this._traceConfiguration = value; }
        }

        // Check to see if TraceConfiguration property is set
        internal bool IsSetTraceConfiguration()
        {
            return this._traceConfiguration != null;
        }

    }
}