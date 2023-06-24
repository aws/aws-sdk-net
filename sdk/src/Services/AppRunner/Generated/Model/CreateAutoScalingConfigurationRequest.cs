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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAutoScalingConfiguration operation.
    /// Create an App Runner automatic scaling configuration resource. App Runner requires
    /// this resource when you create or update App Runner services and you require non-default
    /// auto scaling settings. You can share an auto scaling configuration across multiple
    /// services.
    /// 
    ///  
    /// <para>
    /// Create multiple revisions of a configuration by calling this action multiple times
    /// using the same <code>AutoScalingConfigurationName</code>. The call returns incremental
    /// <code>AutoScalingConfigurationRevision</code> values. When you create a service and
    /// configure an auto scaling configuration resource, the service uses the latest active
    /// revision of the auto scaling configuration by default. You can optionally configure
    /// the service to use a specific revision.
    /// </para>
    ///  
    /// <para>
    /// Configure a higher <code>MinSize</code> to increase the spread of your App Runner
    /// service over more Availability Zones in the Amazon Web Services Region. The tradeoff
    /// is a higher minimal cost.
    /// </para>
    ///  
    /// <para>
    /// Configure a lower <code>MaxSize</code> to control your cost. The tradeoff is lower
    /// responsiveness during peak demand.
    /// </para>
    /// </summary>
    public partial class CreateAutoScalingConfigurationRequest : AmazonAppRunnerRequest
    {
        private string _autoScalingConfigurationName;
        private int? _maxConcurrency;
        private int? _maxSize;
        private int? _minSize;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationName. 
        /// <para>
        /// A name for the auto scaling configuration. When you use it for the first time in an
        /// Amazon Web Services Region, App Runner creates revision number <code>1</code> of this
        /// name. When you use the same name in subsequent calls, App Runner creates incremental
        /// revisions of the configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// The name <code>DefaultConfiguration</code> is reserved (it's the configuration that
        /// App Runner uses if you don't provide a custome one). You can't use it to create a
        /// new auto scaling configuration, and you can't create a revision of it.
        /// </para>
        ///  
        /// <para>
        /// When you want to use your own auto scaling configuration for your App Runner service,
        /// <i>create a configuration with a different name</i>, and then provide it when you
        /// create or update your service.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=32)]
        public string AutoScalingConfigurationName
        {
            get { return this._autoScalingConfigurationName; }
            set { this._autoScalingConfigurationName = value; }
        }

        // Check to see if AutoScalingConfigurationName property is set
        internal bool IsSetAutoScalingConfigurationName()
        {
            return this._autoScalingConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of concurrent requests that you want an instance to process. If
        /// the number of concurrent requests exceeds this limit, App Runner scales up your service.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>100</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public int MaxConcurrency
        {
            get { return this._maxConcurrency.GetValueOrDefault(); }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum number of instances that your service scales up to. At most <code>MaxSize</code>
        /// instances actively serve traffic for your service.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>25</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum number of instances that App Runner provisions for your service. The service
        /// always has at least <code>MinSize</code> provisioned instances. Some of them actively
        /// serve traffic. The rest of them (provisioned and inactive instances) are a cost-effective
        /// compute capacity reserve and are ready to be quickly activated. You pay for memory
        /// usage of all the provisioned instances. You pay for CPU usage of only the active subset.
        /// </para>
        ///  
        /// <para>
        /// App Runner temporarily doubles the number of provisioned instances during deployments,
        /// to maintain the same capacity for both old and new code.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>1</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of metadata items that you can associate with your auto scaling configuration
        /// resource. A tag is a key-value pair.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}