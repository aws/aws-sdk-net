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
    /// The question sets that you ask Elemental Inference about the media in a contextual
    /// metadata output. You must specify at least one of shot or scene. They can reference
    /// the same version of the same question set.
    /// </summary>
    public partial class CustomQuestionsConfig
    {
        /// <summary>
        /// Gets and sets the property Scene. 
        /// <para>
        /// The version of a question set to ask Elemental Inference about each scene.
        /// </para>
        /// </summary>
        public QuestionSetReference Scene { get; set; }

        /// <summary>
        /// Checks to see if the Scene property is set.
        /// </summary>
        internal bool IsSetScene() => this.Scene != null;

        /// <summary>
        /// Gets and sets the property Shot. 
        /// <para>
        /// The version of a question set to ask Elemental Inference about each shot.
        /// </para>
        /// </summary>
        public QuestionSetReference Shot { get; set; }

        /// <summary>
        /// Checks to see if the Shot property is set.
        /// </summary>
        internal bool IsSetShot() => this.Shot != null;
    }
}
