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
    /// Container for the parameters to the GetQuestionSet operation. Retrieves information
    /// about the specified question set at one version. By default, GetQuestionSet returns
    /// the DRAFT version. To retrieve a published version, specify questionSetVersion.
    /// </summary>
    public partial class GetQuestionSetRequest : AmazonElementalInferenceRequest
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the question set to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property QuestionSetVersion. 
        /// <para>
        /// The version of the question set to retrieve: DRAFT or the number of a published version.
        /// If you don't specify a version, Elemental Inference returns DRAFT. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string QuestionSetVersion { get; set; }

        /// <summary>
        /// Checks to see if the QuestionSetVersion property is set.
        /// </summary>
        internal bool IsSetQuestionSetVersion() => this.QuestionSetVersion != null;
    }
}
