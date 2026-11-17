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
    /// An option in a yesNoPerOption question or a chooseOne question.
    /// </summary>
    public partial class QuestionOption
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the option. The name must be unique among the options of the question.
        /// The name can be up to 64 characters. It must start with a letter or an underscore,
        /// and can contain only the letters A-Z and a-z, the digits 0-9, and underscores. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text of the option. The text must be unique among the options of the question,
        /// ignoring case. The text can be up to 16 bytes, encoded in UTF-8. It can contain the
        /// same characters as the text of a question. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
