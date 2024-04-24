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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private AutoMLJobObjective _autoMLJobObjective;
        private AutoMLProblemTypeResolvedAttributes _autoMLProblemTypeResolvedAttributes;
        private AutoMLJobCompletionCriteria _completionCriteria;

        /// <summary>
        /// Gets and sets the property AutoMLJobObjective.
        /// </summary>
        public AutoMLJobObjective AutoMLJobObjective
        {
            get { return this._autoMLJobObjective; }
            set { this._autoMLJobObjective = value; }
        }

        // Check to see if AutoMLJobObjective property is set
        internal bool IsSetAutoMLJobObjective()
        {
            return this._autoMLJobObjective != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLProblemTypeResolvedAttributes. 
        /// <para>
        /// Defines the resolved attributes specific to a problem type.
        /// </para>
        /// </summary>
        public AutoMLProblemTypeResolvedAttributes AutoMLProblemTypeResolvedAttributes
        {
            get { return this._autoMLProblemTypeResolvedAttributes; }
            set { this._autoMLProblemTypeResolvedAttributes = value; }
        }

        // Check to see if AutoMLProblemTypeResolvedAttributes property is set
        internal bool IsSetAutoMLProblemTypeResolvedAttributes()
        {
            return this._autoMLProblemTypeResolvedAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionCriteria.
        /// </summary>
        public AutoMLJobCompletionCriteria CompletionCriteria
        {
            get { return this._completionCriteria; }
            set { this._completionCriteria = value; }
        }

        // Check to see if CompletionCriteria property is set
        internal bool IsSetCompletionCriteria()
        {
            return this._completionCriteria != null;
        }

    }
}