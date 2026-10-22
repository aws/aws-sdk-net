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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIPSet operation. Updates the IPSet specified
    /// by the IPSet ID.
    /// </summary>
    public partial class UpdateIPSetRequest : AmazonGuardDutyRequest
    {
        /// <summary>
        /// Gets and sets the property Activate. 
        /// <para>
        /// The updated Boolean value that specifies whether the IPSet is active or not.
        /// </para>
        /// </summary>
        public bool? Activate { get; set; }

        /// <summary>
        /// Checks to see if the Activate property is set.
        /// </summary>
        internal bool IsSetActivate() => this.Activate.HasValue;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detectorID that specifies the GuardDuty service whose IPSet you want to update.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The Amazon Web Services account ID that owns the Amazon S3 bucket specified in the
        /// <b>location</b> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ExpectedBucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedBucketOwner property is set.
        /// </summary>
        internal bool IsSetExpectedBucketOwner() => this.ExpectedBucketOwner != null;

        /// <summary>
        /// Gets and sets the property IpSetId. 
        /// <para>
        /// The unique ID that specifies the IPSet that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpSetId { get; set; }

        /// <summary>
        /// Checks to see if the IpSetId property is set.
        /// </summary>
        internal bool IsSetIpSetId() => this.IpSetId != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The updated URI of the file that contains the IPSet. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique ID that specifies the IPSet that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
