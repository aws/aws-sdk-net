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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The extraction configuration that defines how data is extracted from customer interactions.
    /// </summary>
    public partial class ExtractionConfiguration
    {
        private ExtractionDefinitionNotFoundBehavior _notFoundBehavior;
        private string _promptHint;

        /// <summary>
        /// Gets and sets the property NotFoundBehavior. 
        /// <para>
        /// The behavior when the extraction cannot find the specified data in the interaction.
        /// </para>
        /// </summary>
        public ExtractionDefinitionNotFoundBehavior NotFoundBehavior
        {
            get { return this._notFoundBehavior; }
            set { this._notFoundBehavior = value; }
        }

        // Check to see if NotFoundBehavior property is set
        internal bool IsSetNotFoundBehavior()
        {
            return this._notFoundBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property PromptHint. 
        /// <para>
        /// The prompt hint that guides the extraction. This text tells the generative AI model
        /// what data to look for in the customer interaction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string PromptHint
        {
            get { return this._promptHint; }
            set { this._promptHint = value; }
        }

        // Check to see if PromptHint property is set
        internal bool IsSetPromptHint()
        {
            return this._promptHint != null;
        }

    }
}