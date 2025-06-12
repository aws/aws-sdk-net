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
    /// Container for the parameters to the CreateAutoScalingConfiguration operation.
    /// Create an App Runner automatic scaling configuration resource. App Runner requires
    /// this resource when you create or update App Runner services and you require non-default
    /// auto scaling settings. You can share an auto scaling configuration across multiple
    /// services.
    /// 
    ///  
    /// <para>
    /// Create multiple revisions of a configuration by calling this action multiple times
    /// using the same <c>AutoScalingConfigurationName</c>. The call returns incremental <c>AutoScalingConfigurationRevision</c>
    /// values. When you create a service and configure an auto scaling configuration resource,
    /// the service uses the latest active revision of the auto scaling configuration by default.
    /// You can optionally configure the service to use a specific revision.
    /// </para>
    ///  
    /// <para>
    /// Configure a higher <c>MinSize</c> to increase the spread of your App Runner service
    /// over more Availability Zones in the Amazon Web Services Region. The tradeoff is a
    /// higher minimal cost.
    /// </para>
    ///  
    /// <para>
    /// Configure a lower <c>MaxSize</c> to control your cost. The tradeoff is lower responsiveness
    /// during peak demand.
    /// </para>
    /// </summary>
    public partial class CreateAutoScalingConfigurationRequest : AmazonAppRunnerRequest
    {
        private string _autoScalingConfigurationName;
        private int? _maxConcurrency;
        private int? _maxSize;
        private int? _minSize;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationName. 
        /// <para>
        /// A name for the auto scaling configuration. When you use it for the first time in an
        /// Amazon Web Services Region, App Runner creates revision number <c>1</c> of this name.
        /// When you use the same name in subsequent calls, App Runner creates incremental revisions
        /// of the configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// Prior to the release of <a href="https://docs.aws.amazon.com/apprunner/latest/relnotes/release-2023-09-22-auto-scale-config.html">Auto
        /// scale configuration enhancements</a>, the name <c>DefaultConfiguration</c> was reserved.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This restriction is no longer in place. You can now manage <c>DefaultConfiguration</c>
        /// the same way you manage your custom auto scaling configurations. This means you can
        /// do the following with the <c>DefaultConfiguration</c> that App Runner provides:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create new revisions of the <c>DefaultConfiguration</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete the revisions of the <c>DefaultConfiguration</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete the auto scaling configuration for which the App Runner <c>DefaultConfiguration</c>
        /// was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you delete the auto scaling configuration you can create another custom auto scaling
        /// configuration with the same <c>DefaultConfiguration</c> name. The original <c>DefaultConfiguration</c>
        /// resource provided by App Runner remains in your account unless you make changes to
        /// it.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Default: <c>100</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public int? MaxConcurrency
        {
            get { return this._maxConcurrency; }
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
        /// The maximum number of instances that your service scales up to. At most <c>MaxSize</c>
        /// instances actively serve traffic for your service.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>25</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxSize
        {
            get { return this._maxSize; }
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
        /// always has at least <c>MinSize</c> provisioned instances. Some of them actively serve
        /// traffic. The rest of them (provisioned and inactive instances) are a cost-effective
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
        /// Default: <c>1</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int? MinSize
        {
            get { return this._minSize; }
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

    }
}