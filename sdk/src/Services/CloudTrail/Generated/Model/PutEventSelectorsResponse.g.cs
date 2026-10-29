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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the PutEventSelectors operation.
    /// </summary>
    public partial class PutEventSelectorsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdvancedEventSelectors. 
        /// <para>
        /// Specifies the advanced event selectors configured for your trail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdvancedEventSelector> AdvancedEventSelectors { get; set; } = AWSConfigs.InitializeCollections ? new List<AdvancedEventSelector>() : null;

        /// <summary>
        /// Checks to see if the AdvancedEventSelectors property is set.
        /// </summary>
        internal bool IsSetAdvancedEventSelectors() => this.AdvancedEventSelectors != null && (this.AdvancedEventSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventSelectors. 
        /// <para>
        /// Specifies the event selectors configured for your trail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EventSelector> EventSelectors { get; set; } = AWSConfigs.InitializeCollections ? new List<EventSelector>() : null;

        /// <summary>
        /// Checks to see if the EventSelectors property is set.
        /// </summary>
        internal bool IsSetEventSelectors() => this.EventSelectors != null && (this.EventSelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrailARN. 
        /// <para>
        /// Specifies the ARN of the trail that was updated with event selectors. The following
        /// is the format of a trail ARN.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c> 
        /// </para>
        /// </summary>
        public string TrailARN { get; set; }

        /// <summary>
        /// Checks to see if the TrailARN property is set.
        /// </summary>
        internal bool IsSetTrailARN() => this.TrailARN != null;
    }
}
