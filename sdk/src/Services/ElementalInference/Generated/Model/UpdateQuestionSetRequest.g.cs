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
    /// Container for the parameters to the UpdateQuestionSet operation. Updates the DRAFT
    /// version of the specified question set. UpdateQuestionSet doesn't create a version
    /// and doesn't change published versions. To publish the updated DRAFT as a new version,
    /// use CreateQuestionSetVersion. <para> UpdateQuestionSet replaces questions one type
    /// at a time. For each of yesNo, yesNoPerOption, and chooseOne: if you omit the array,
    /// DRAFT keeps its questions of that type. If you include the array, it replaces all
    /// the questions of that type in DRAFT. If you include an empty array, DRAFT no longer
    /// has questions of that type. The updated DRAFT must follow the same rules as in CreateQuestionSet,
    /// and Elemental Inference applies those rules to the questions that DRAFT keeps as well
    /// as to the questions in the request. </para> <para> Feeds that reference the DRAFT
    /// version use the updated questions. To make sure that the questions for a feed don't
    /// change, reference a published version instead. </para>
    /// </summary>
    public partial class UpdateQuestionSetRequest : AmazonElementalInferenceRequest
    {
        /// <summary>
        /// Gets and sets the property ChooseOne. 
        /// <para>
        /// An array of questions that Elemental Inference answers by choosing one of their options,
        /// to replace all the chooseOne questions in DRAFT. You can specify up to 10 chooseOne
        /// questions. If not specified, the chooseOne questions are not changed. To remove all
        /// the chooseOne questions, specify an empty array. 
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the question set to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the question set. If not specified, the name is not changed.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property YesNo. 
        /// <para>
        /// An array of questions that Elemental Inference answers with yes or no, to replace
        /// all the yesNo questions in DRAFT. You can specify up to 50 yesNo questions. If not
        /// specified, the yesNo questions are not changed. To remove all the yesNo questions,
        /// specify an empty array. 
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
        /// An array of questions that you ask about each of their options, to replace all the
        /// yesNoPerOption questions in DRAFT. You can specify up to 10 yesNoPerOption questions.
        /// If not specified, the yesNoPerOption questions are not changed. To remove all the
        /// yesNoPerOption questions, specify an empty array. 
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
