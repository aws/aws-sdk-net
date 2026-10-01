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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// This is the response object from the GetDeliverabilityTestReport operation.
    /// </summary>
    public partial class GetDeliverabilityTestReportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeliverabilityTestReport. 
        /// <para>
        /// An object that contains the results of the predictive inbox placement test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeliverabilityTestReport DeliverabilityTestReport { get; set; }

        /// <summary>
        /// Checks to see if the DeliverabilityTestReport property is set.
        /// </summary>
        internal bool IsSetDeliverabilityTestReport() => this.DeliverabilityTestReport != null;

        /// <summary>
        /// Gets and sets the property IspPlacements. 
        /// <para>
        /// An object that describes how the test email was handled by several email providers,
        /// including Gmail, Hotmail, Yahoo, AOL, and others.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<IspPlacement> IspPlacements { get; set; } = AWSConfigs.InitializeCollections ? new List<IspPlacement>() : null;

        /// <summary>
        /// Checks to see if the IspPlacements property is set.
        /// </summary>
        internal bool IsSetIspPlacements() => this.IspPlacements != null && (this.IspPlacements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An object that contains the message that you sent when you performed this predictive
        /// inbox placement test.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property OverallPlacement. 
        /// <para>
        /// An object that specifies how many test messages that were sent during the predictive
        /// inbox placement test were delivered to recipients' inboxes, how many were sent to
        /// recipients' spam folders, and how many weren't delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PlacementStatistics OverallPlacement { get; set; }

        /// <summary>
        /// Checks to see if the OverallPlacement property is set.
        /// </summary>
        internal bool IsSetOverallPlacement() => this.OverallPlacement != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects that define the tags (keys and values) that are associated with
        /// the predictive inbox placement test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
