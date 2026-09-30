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
    /// This is the response object from the GetManagedResource operation.
    /// </summary>
    public partial class GetManagedResourceResponse : AmazonWebServiceResponse
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
        [AWSProperty(Required = true)]
        public Dictionary<string, float> AppliedWeights { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, float>() : null;

        /// <summary>
        /// Checks to see if the AppliedWeights property is set.
        /// </summary>
        internal bool IsSetAppliedWeights() => this.AppliedWeights != null && (this.AppliedWeights.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the resource.
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
        /// An array of the autoshifts that are active for the resource.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PracticeRunConfiguration. 
        /// <para>
        /// The practice run configuration for zonal autoshift that's associated with the resource.
        /// </para>
        /// </summary>
        public PracticeRunConfiguration PracticeRunConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PracticeRunConfiguration property is set.
        /// </summary>
        internal bool IsSetPracticeRunConfiguration() => this.PracticeRunConfiguration != null;

        /// <summary>
        /// Gets and sets the property ZonalAutoshiftStatus. 
        /// <para>
        /// The status for zonal autoshift for a resource. When the autoshift status is <c>ENABLED</c>,
        /// Amazon Web Services shifts traffic for a resource away from an Availability Zone,
        /// on your behalf, when Amazon Web Services determines that there's an issue in the Availability
        /// Zone that could potentially affect customers.
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
        /// The zonal shifts that are currently active for a resource. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ZonalShiftInResource> ZonalShifts { get; set; } = AWSConfigs.InitializeCollections ? new List<ZonalShiftInResource>() : null;

        /// <summary>
        /// Checks to see if the ZonalShifts property is set.
        /// </summary>
        internal bool IsSetZonalShifts() => this.ZonalShifts != null && (this.ZonalShifts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
