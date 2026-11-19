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
    /// Container for the parameters to the DeleteQuestionSetVersion operation. Deletes a
    /// published version of the specified question set. You can't delete a version while
    /// a feed references it, including an archived feed. You can't restore a deleted version,
    /// and Elemental Inference doesn't reuse its number. <para> You can't delete the DRAFT
    /// version on its own. To delete DRAFT, delete the question set by using DeleteQuestionSet.
    /// </para> <para> Deleting a version doesn't change the latestVersion of the question
    /// set, even if you delete the highest version. </para>
    /// </summary>
    public partial class DeleteQuestionSetVersionRequest : AmazonElementalInferenceRequest
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the question set that contains the version.
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
        /// The number of the published version to delete. You can't specify DRAFT.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string QuestionSetVersion { get; set; }

        /// <summary>
        /// Checks to see if the QuestionSetVersion property is set.
        /// </summary>
        internal bool IsSetQuestionSetVersion() => this.QuestionSetVersion != null;
    }
}
