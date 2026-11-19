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
    /// Container for the parameters to the CreateQuestionSet operation. Creates a question
    /// set. Use a question set to get answers about content that's specific to your business,
    /// in addition to the built-in contextual metadata classifications. A question set contains
    /// your own questions. You ask Elemental Inference these questions about each shot or
    /// scene of the media in a contextual metadata output, and Elemental Inference answers
    /// each question with scores. To use a question set, reference it in the customQuestions
    /// property of the contextual metadata configuration of a feed output. <para> CreateQuestionSet
    /// creates the question set with a DRAFT version that contains the questions in the request.
    /// To change DRAFT, use UpdateQuestionSet. To publish DRAFT as a numbered version, use
    /// CreateQuestionSetVersion. You can't change a published version. </para> <para> A question
    /// set can contain the following types of questions. You must specify at least one question.
    /// </para> <ul> <li> <para> yesNo – Elemental Inference answers yes or no. </para> </li>
    /// <li> <para> yesNoPerOption – Elemental Inference answers yes or no for each option.
    /// </para> </li> <li> <para> chooseOne – Elemental Inference chooses one of the options.
    /// </para> </li> </ul> <para> A version can contain up to 100 scored items, where each
    /// yesNo question, each option of a yesNoPerOption question, and each chooseOne question
    /// counts as one item. The name of each question must be unique across all three types.
    /// </para>
    /// </summary>
    public partial class CreateQuestionSetRequest : AmazonElementalInferenceRequest
    {
        /// <summary>
        /// Gets and sets the property ChooseOne. 
        /// <para>
        /// An array of questions that Elemental Inference answers by choosing one of their options.
        /// You can specify up to 10 chooseOne questions. An empty array is the same as omitting
        /// this property. 
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-friendly name for this question set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional tags to associate with the question set. You can also add tags later, using
        /// TagResource. 
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
        /// Gets and sets the property YesNo. 
        /// <para>
        /// An array of questions that Elemental Inference answers with yes or no. You can specify
        /// up to 50 yesNo questions. An empty array is the same as omitting this property. 
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
        /// An array of questions that you ask about each of their options. Elemental Inference
        /// answers yes or no for each option. You can specify up to 10 yesNoPerOption questions.
        /// An empty array is the same as omitting this property. 
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
