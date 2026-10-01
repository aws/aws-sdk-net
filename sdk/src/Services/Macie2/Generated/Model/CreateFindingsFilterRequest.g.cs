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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFindingsFilter operation. Creates and defines
    /// the criteria and other settings for a findings filter.
    /// </summary>
    public partial class CreateFindingsFilterRequest : AmazonMacie2Request
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform on findings that match the filter criteria (findingCriteria).
        /// Valid values are: ARCHIVE, suppress (automatically archive) the findings; and, NOOP,
        /// don't perform any action on the findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingsFilterAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A custom description of the filter. The description can contain as many as 512 characters.
        /// </para>
        ///  
        /// <para>
        /// We strongly recommend that you avoid including any sensitive data in the description
        /// of a filter. Other users of your account might be able to see this description, depending
        /// on the actions that they're allowed to perform in Amazon Macie.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FindingCriteria. 
        /// <para>
        /// The criteria to use to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingCriteria FindingCriteria { get; set; }

        /// <summary>
        /// Checks to see if the FindingCriteria property is set.
        /// </summary>
        internal bool IsSetFindingCriteria() => this.FindingCriteria != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A custom name for the filter. The name must contain at least 3 characters and can
        /// contain as many as 64 characters.
        /// </para>
        ///  
        /// <para>
        /// We strongly recommend that you avoid including any sensitive data in the name of a
        /// filter. Other users of your account might be able to see this name, depending on the
        /// actions that they're allowed to perform in Amazon Macie.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position of the filter in the list of saved filters on the Amazon Macie console.
        /// This value also determines the order in which the filter is applied to findings, relative
        /// to other filters that are also applied to the findings.
        /// </para>
        /// </summary>
        public int? Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that specifies the tags to associate with the filter.
        /// </para>
        ///  
        /// <para>
        /// A findings filter can have a maximum of 50 tags. Each tag consists of a tag key and
        /// an associated tag value. The maximum length of a tag key is 128 characters. The maximum
        /// length of a tag value is 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
