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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
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
        private Dictionary<string, float> _appliedWeights = AWSConfigs.InitializeCollections ? new Dictionary<string, float>() : null;
        private string _arn;
        private List<AutoshiftInResource> _autoshifts = AWSConfigs.InitializeCollections ? new List<AutoshiftInResource>() : null;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private ZonalAutoshiftStatus _practiceRunStatus;
        private ZonalAutoshiftStatus _zonalAutoshiftStatus;
        private List<ZonalShiftInResource> _zonalShifts = AWSConfigs.InitializeCollections ? new List<ZonalShiftInResource>() : null;

        /// <summary>
        /// Gets and sets the property AppliedWeights. 
        /// <para>
        /// A collection of key-value pairs that indicate whether resources are active in Availability
        /// Zones or not. The key name is the Availability Zone where the resource is deployed.
        /// The value is 1 or 0.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, float> AppliedWeights
        {
            get { return this._appliedWeights; }
            set { this._appliedWeights = value; }
        }

        // Check to see if AppliedWeights property is set
        internal bool IsSetAppliedWeights()
        {
            return this._appliedWeights != null && (this._appliedWeights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the managed resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Autoshifts. 
        /// <para>
        /// An array of the autoshifts that have been completed for a resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoshiftInResource> Autoshifts
        {
            get { return this._autoshifts; }
            set { this._autoshifts = value; }
        }

        // Check to see if Autoshifts property is set
        internal bool IsSetAutoshifts()
        {
            return this._autoshifts != null && (this._autoshifts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones that a resource is deployed in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        public ZonalAutoshiftStatus PracticeRunStatus
        {
            get { return this._practiceRunStatus; }
            set { this._practiceRunStatus = value; }
        }

        // Check to see if PracticeRunStatus property is set
        internal bool IsSetPracticeRunStatus()
        {
            return this._practiceRunStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ZonalAutoshiftStatus. 
        /// <para>
        /// The status of autoshift for a resource. When you configure zonal autoshift for a resource,
        /// you can set the value of the status to <c>ENABLED</c> or <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public ZonalAutoshiftStatus ZonalAutoshiftStatus
        {
            get { return this._zonalAutoshiftStatus; }
            set { this._zonalAutoshiftStatus = value; }
        }

        // Check to see if ZonalAutoshiftStatus property is set
        internal bool IsSetZonalAutoshiftStatus()
        {
            return this._zonalAutoshiftStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ZonalShifts. 
        /// <para>
        /// An array of the zonal shifts for a resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ZonalShiftInResource> ZonalShifts
        {
            get { return this._zonalShifts; }
            set { this._zonalShifts = value; }
        }

        // Check to see if ZonalShifts property is set
        internal bool IsSetZonalShifts()
        {
            return this._zonalShifts != null && (this._zonalShifts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}