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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The resolved attributes used to configure an AutoML job V2.
    /// </summary>
    public partial class AutoMLResolvedAttributes
    {
        /// <summary>
        /// Gets and sets the property AutoMLJobObjective.
        /// </summary>
        public AutoMLJobObjective AutoMLJobObjective { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobObjective property is set.
        /// </summary>
        internal bool IsSetAutoMLJobObjective() => this.AutoMLJobObjective != null;

        /// <summary>
        /// Gets and sets the property AutoMLProblemTypeResolvedAttributes. 
        /// <para>
        /// Defines the resolved attributes specific to a problem type.
        /// </para>
        /// </summary>
        public AutoMLProblemTypeResolvedAttributes AutoMLProblemTypeResolvedAttributes { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLProblemTypeResolvedAttributes property is set.
        /// </summary>
        internal bool IsSetAutoMLProblemTypeResolvedAttributes() => this.AutoMLProblemTypeResolvedAttributes != null;

        /// <summary>
        /// Gets and sets the property CompletionCriteria.
        /// </summary>
        public AutoMLJobCompletionCriteria CompletionCriteria { get; set; }

        /// <summary>
        /// Checks to see if the CompletionCriteria property is set.
        /// </summary>
        internal bool IsSetCompletionCriteria() => this.CompletionCriteria != null;
    }
}
