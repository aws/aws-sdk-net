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

namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// A complex structure for a managed resource in an Amazon Web Services account with
    /// information about zonal shifts and autoshifts.
    /// 
    ///  
    /// <para>
    /// You can start a zonal shift in ARC for a managed resource to temporarily move traffic
    /// for the resource away from an Availability Zone in an Amazon Web Services Region.
    /// You can also configure zonal autoshift for a managed resource.
    /// </para>
    ///  <note> 
    /// <para>
    /// At this time, managed resources are Amazon EC2 Auto Scaling groups, Amazon Elastic
    /// Kubernetes Service, Network Load Balancers, and Application Load Balancer.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ManagedResourceSummary
    {
        /// <summary>
        /// Gets and sets the property AppliedWeights. 
        /// <para>
        /// A collection of key-value pairs that indicate whether resources are active in Availability
        /// Zones or not. The key name is the Availability Zone where the resource is deployed.
        /// The value is 1 or 0.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, float> AppliedWeights { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, float>() : null;

        /// <summary>
        /// Checks to see if the AppliedWeights property is set.
        /// </summary>
        internal bool IsSetAppliedWeights() => this.AppliedWeights != null && (this.AppliedWeights.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the managed resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Autoshifts. 
        /// <para>
        /// An array of the autoshifts that have been completed for a resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoshiftInResource> Autoshifts { get; set; } = AWSConfigs.InitializeCollections ? new List<AutoshiftInResource>() : null;

        /// <summary>
        /// Checks to see if the Autoshifts property is set.
        /// </summary>
        internal bool IsSetAutoshifts() => this.Autoshifts != null && (this.Autoshifts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones that a resource is deployed in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PracticeRunStatus. 
        /// <para>
        /// This status tracks whether a practice run configuration exists for a resource. When
        /// you configure a practice run for a resource so that a practice run configuration exists,
        /// ARC sets this value to <c>ENABLED</c>. If a you have not configured a practice run
        /// for the resource, or delete a practice run configuration, ARC sets the value to <c>DISABLED</c>.
        /// </para>
        ///  
        /// <para>
        /// ARC updates this status; you can't set a practice run status to <c>ENABLED</c> or
        /// <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public ZonalAutoshiftStatus PracticeRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the PracticeRunStatus property is set.
        /// </summary>
        internal bool IsSetPracticeRunStatus() => this.PracticeRunStatus != null;

        /// <summary>
        /// Gets and sets the property ZonalAutoshiftStatus. 
        /// <para>
        /// The status of autoshift for a resource. When you configure zonal autoshift for a resource,
        /// you can set the value of the status to <c>ENABLED</c> or <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public ZonalAutoshiftStatus ZonalAutoshiftStatus { get; set; }

        /// <summary>
        /// Checks to see if the ZonalAutoshiftStatus property is set.
        /// </summary>
        internal bool IsSetZonalAutoshiftStatus() => this.ZonalAutoshiftStatus != null;

        /// <summary>
        /// Gets and sets the property ZonalShifts. 
        /// <para>
        /// An array of the zonal shifts for a resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ZonalShiftInResource> ZonalShifts { get; set; } = AWSConfigs.InitializeCollections ? new List<ZonalShiftInResource>() : null;

        /// <summary>
        /// Checks to see if the ZonalShifts property is set.
        /// </summary>
        internal bool IsSetZonalShifts() => this.ZonalShifts != null && (this.ZonalShifts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
