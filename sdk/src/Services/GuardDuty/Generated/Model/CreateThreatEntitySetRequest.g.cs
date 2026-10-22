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
    /// Container for the parameters to the CreateThreatEntitySet operation. Creates a new
    /// threat entity set. In a threat entity set, you can provide known malicious threat
    /// entities for your Amazon Web Services environment. GuardDuty generates findings based
    /// on the entries in the threat entity sets. Only users of the administrator account
    /// can manage entity sets, which automatically apply to member accounts.
    /// </summary>
    public partial class CreateThreatEntitySetRequest : AmazonGuardDutyRequest
    {
        /// <summary>
        /// Gets and sets the property Activate. 
        /// <para>
        /// A boolean value that indicates whether GuardDuty should start using the uploaded threat
        /// entity set to generate findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Activate { get; set; }

        /// <summary>
        /// Checks to see if the Activate property is set.
        /// </summary>
        internal bool IsSetActivate() => this.Activate.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for the create request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the detector of the GuardDuty account for which you want to create
        /// a threat entity set.
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
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the file that contains the threat entity set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public ThreatEntitySetFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The URI of the file that contains the threat entity set. The format of the <c>Location</c>
        /// URL must be a valid Amazon S3 URL format. Invalid URL formats will result in an error,
        /// regardless of whether you activate the entity set or not. For more information about
        /// format of the location URLs, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty-lists-create-activate.html">Format
        /// of location URL under Step 2: Adding trusted or threat intelligence data</a> in the
        /// <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-friendly name to identify the threat entity set.
        /// </para>
        ///  
        /// <para>
        /// The name of your list can include lowercase letters, uppercase letters, numbers, dash
        /// (-), and underscore (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be added to a new threat entity set resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
