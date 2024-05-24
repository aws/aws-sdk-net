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
    /// Stores resolved attributes specific to the problem type of an AutoML job V2.
    /// </summary>
    public partial class AutoMLProblemTypeResolvedAttributes
    {
        private TabularResolvedAttributes _tabularResolvedAttributes;
        private TextGenerationResolvedAttributes _textGenerationResolvedAttributes;

        /// <summary>
        /// Gets and sets the property TabularResolvedAttributes. 
        /// <para>
        /// The resolved attributes for the tabular problem type.
        /// </para>
        /// </summary>
        public TabularResolvedAttributes TabularResolvedAttributes
        {
            get { return this._tabularResolvedAttributes; }
            set { this._tabularResolvedAttributes = value; }
        }

        // Check to see if TabularResolvedAttributes property is set
        internal bool IsSetTabularResolvedAttributes()
        {
            return this._tabularResolvedAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property TextGenerationResolvedAttributes. 
        /// <para>
        /// The resolved attributes for the text generation problem type.
        /// </para>
        /// </summary>
        public TextGenerationResolvedAttributes TextGenerationResolvedAttributes
        {
            get { return this._textGenerationResolvedAttributes; }
            set { this._textGenerationResolvedAttributes = value; }
        }

        // Check to see if TextGenerationResolvedAttributes property is set
        internal bool IsSetTextGenerationResolvedAttributes()
        {
            return this._textGenerationResolvedAttributes != null;
        }

    }
}