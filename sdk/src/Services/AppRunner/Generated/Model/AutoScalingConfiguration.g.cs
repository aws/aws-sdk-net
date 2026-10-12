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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes an App Runner automatic scaling configuration resource.
    /// 
    ///  
    /// <para>
    /// A higher <c>MinSize</c> increases the spread of your App Runner service over more
    /// Availability Zones in the Amazon Web Services Region. The tradeoff is a higher minimal
    /// cost.
    /// </para>
    ///  
    /// <para>
    /// A lower <c>MaxSize</c> controls your cost. The tradeoff is lower responsiveness during
    /// peak demand.
    /// </para>
    ///  
    /// <para>
    /// Multiple revisions of a configuration might have the same <c>AutoScalingConfigurationName</c>
    /// and different <c>AutoScalingConfigurationRevision</c> values.
    /// </para>
    /// </summary>
    public partial class AutoScalingConfiguration
    {
        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this auto scaling configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string AutoScalingConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingConfigurationArn property is set.
        /// </summary>
        internal bool IsSetAutoScalingConfigurationArn() => this.AutoScalingConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationName. 
        /// <para>
        /// The customer-provided auto scaling configuration name. It can be used in multiple
        /// revisions of a configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 32)]
        public string AutoScalingConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingConfigurationName property is set.
        /// </summary>
        internal bool IsSetAutoScalingConfigurationName() => this.AutoScalingConfigurationName != null;

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationRevision. 
        /// <para>
        /// The revision of this auto scaling configuration. It's unique among all the active
        /// configurations (<c>"Status": "ACTIVE"</c>) that share the same <c>AutoScalingConfigurationName</c>.
        /// </para>
        /// </summary>
        public int? AutoScalingConfigurationRevision { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingConfigurationRevision property is set.
        /// </summary>
        internal bool IsSetAutoScalingConfigurationRevision() => this.AutoScalingConfigurationRevision.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the auto scaling configuration was created. It's in Unix time stamp
        /// format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeletedAt. 
        /// <para>
        /// The time when the auto scaling configuration was deleted. It's in Unix time stamp
        /// format.
        /// </para>
        /// </summary>
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Checks to see if the DeletedAt property is set.
        /// </summary>
        internal bool IsSetDeletedAt() => this.DeletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property HasAssociatedService. 
        /// <para>
        /// Indicates if this auto scaling configuration has an App Runner service associated
        /// with it. A value of <c>true</c> indicates one or more services are associated. A value
        /// of <c>false</c> indicates no services are associated.
        /// </para>
        /// </summary>
        public bool? HasAssociatedService { get; set; }

        /// <summary>
        /// Checks to see if the HasAssociatedService property is set.
        /// </summary>
        internal bool IsSetHasAssociatedService() => this.HasAssociatedService.HasValue;

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Indicates if this auto scaling configuration should be used as the default for a new
        /// App Runner service that does not have an auto scaling configuration ARN specified
        /// during creation. Each account can have only one default <c>AutoScalingConfiguration</c>
        /// per region. The default <c>AutoScalingConfiguration</c> can be any revision under
        /// the same <c>AutoScalingConfigurationName</c>.
        /// </para>
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

        /// <summary>
        /// Gets and sets the property Latest. 
        /// <para>
        /// It's set to <c>true</c> for the configuration with the highest <c>Revision</c> among
        /// all configurations that share the same <c>AutoScalingConfigurationName</c>. It's set
        /// to <c>false</c> otherwise.
        /// </para>
        /// </summary>
        public bool? Latest { get; set; }

        /// <summary>
        /// Checks to see if the Latest property is set.
        /// </summary>
        internal bool IsSetLatest() => this.Latest.HasValue;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of concurrent requests that an instance processes. If the number
        /// of concurrent requests exceeds this limit, App Runner scales the service up.
        /// </para>
        /// </summary>
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency.HasValue;

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum number of instances that a service scales up to. At most <c>MaxSize</c>
        /// instances actively serve traffic for your service.
        /// </para>
        /// </summary>
        public int? MaxSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxSize property is set.
        /// </summary>
        internal bool IsSetMaxSize() => this.MaxSize.HasValue;

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum number of instances that App Runner provisions for a service. The service
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
        /// </summary>
        public int? MinSize { get; set; }

        /// <summary>
        /// Checks to see if the MinSize property is set.
        /// </summary>
        internal bool IsSetMinSize() => this.MinSize.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the auto scaling configuration. If the status of a configuration
        /// revision is <c>INACTIVE</c>, it was deleted and can't be used. Inactive configuration
        /// revisions are permanently removed some time after they are deleted.
        /// </para>
        /// </summary>
        public AutoScalingConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
