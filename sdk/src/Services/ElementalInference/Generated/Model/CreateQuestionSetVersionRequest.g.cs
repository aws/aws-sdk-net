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
    /// Container for the parameters to the CreateQuestionSetVersion operation. Publishes
    /// the DRAFT version of the specified question set as a new version. The new version
    /// has the same name and questions as DRAFT, and you can't change it. DRAFT doesn't change,
    /// so you can continue to update it. <para> Version numbers start at 1, and each new
    /// version has the next number. Elemental Inference never reuses a version number, even
    /// after you delete that version. </para> <para> If DRAFT hasn't changed since the latest
    /// published version, Elemental Inference doesn't create a version. Instead, it returns
    /// the latest version. A change to the name of the question set counts as a change to
    /// DRAFT. </para> <para> A question set can have a limited number of versions. If the
    /// question set already has the maximum number of versions, Elemental Inference returns
    /// ServiceQuotaExceededException. To free space for a new version, delete a version that
    /// you no longer need, or create a new question set. </para>
    /// </summary>
    public partial class CreateQuestionSetVersionRequest : AmazonElementalInferenceRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the new version. You can't change the description after Elemental
        /// Inference publishes the version. If DRAFT hasn't changed since the latest version,
        /// Elemental Inference ignores this value and returns the latest version with its existing
        /// description. 
        /// </para>
        ///  
        /// <para>
        /// The description can be up to 256 characters. It can contain the letters A-Z and a-z,
        /// the digits 0-9, underscores, spaces, and the following characters: <c>- . ' , @ :
        /// ;</c>. 
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
        /// The ID of the question set whose DRAFT version you want to publish.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Sha256. 
        /// <para>
        /// The SHA-256 hash of the DRAFT version that you want to publish, as returned by GetQuestionSet
        /// or UpdateQuestionSet. If you specify this value, Elemental Inference publishes DRAFT
        /// only if its current hash matches. If it doesn't match, because DRAFT changed after
        /// you retrieved it, the request fails with ConflictException. 
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this value, Elemental Inference publishes DRAFT as it is when
        /// it receives the request. 
        /// </para>
        /// </summary>
        public string Sha256 { get; set; }

        /// <summary>
        /// Checks to see if the Sha256 property is set.
        /// </summary>
        internal bool IsSetSha256() => this.Sha256 != null;
    }
}
