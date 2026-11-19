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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// This is the response object from the UpdateQuestionSet operation.
    /// </summary>
    public partial class UpdateQuestionSetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the question set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ChooseOne. 
        /// <para>
        /// The chooseOne questions in this version. Elemental Inference doesn't return this property
        /// if the version has no chooseOne questions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<ChooseOneQuestion> ChooseOne { get; set; } = AWSConfigs.InitializeCollections ? new List<ChooseOneQuestion>() : null;

        /// <summary>
        /// Checks to see if the ChooseOne property is set.
        /// </summary>
        internal bool IsSetChooseOne() => this.ChooseOne != null && (this.ChooseOne.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the version. Elemental Inference doesn't return this property for
        /// UpdateQuestionSet, because the DRAFT version has no description. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the question set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The number of the highest version that you have published for this question set, even
        /// if you have since deleted that version. Elemental Inference doesn't return this property
        /// if you haven't published a version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersion property is set.
        /// </summary>
        internal bool IsSetLatestVersion() => this.LatestVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated or original name of the question set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// A list of feed IDs that reference the DRAFT version of the question set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> References { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the References property is set.
        /// </summary>
        internal bool IsSetReferences() => this.References != null && (this.References.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sha256. 
        /// <para>
        /// The SHA-256 hash of the DRAFT version after the update, as 64 lowercase hexadecimal
        /// characters. The hash covers the name of the question set and its questions, so it
        /// changes when you rename the question set. You can specify this value in a CreateQuestionSetVersion
        /// request, so that Elemental Inference publishes DRAFT only if it hasn't changed since
        /// this update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Sha256 { get; set; }

        /// <summary>
        /// Checks to see if the Sha256 property is set.
        /// </summary>
        internal bool IsSetSha256() => this.Sha256 != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags associated with the question set.
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version that this response describes. For UpdateQuestionSet, the version is always
        /// DRAFT. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property YesNo. 
        /// <para>
        /// The yesNo questions in this version. Elemental Inference doesn't return this property
        /// if the version has no yesNo questions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<YesNoQuestion> YesNo { get; set; } = AWSConfigs.InitializeCollections ? new List<YesNoQuestion>() : null;

        /// <summary>
        /// Checks to see if the YesNo property is set.
        /// </summary>
        internal bool IsSetYesNo() => this.YesNo != null && (this.YesNo.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property YesNoPerOption. 
        /// <para>
        /// The yesNoPerOption questions in this version. Elemental Inference doesn't return this
        /// property if the version has no yesNoPerOption questions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<YesNoPerOptionQuestion> YesNoPerOption { get; set; } = AWSConfigs.InitializeCollections ? new List<YesNoPerOptionQuestion>() : null;

        /// <summary>
        /// Checks to see if the YesNoPerOption property is set.
        /// </summary>
        internal bool IsSetYesNoPerOption() => this.YesNoPerOption != null && (this.YesNoPerOption.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
