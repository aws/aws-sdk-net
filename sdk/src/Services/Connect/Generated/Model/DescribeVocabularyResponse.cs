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
    /// This is the response object from the DescribeVocabulary operation.
    /// </summary>
    public partial class DescribeVocabularyResponse : AmazonWebServiceResponse
    {
        private Vocabulary _vocabulary;

        /// <summary>
        /// Gets and sets the property Vocabulary. 
        /// <para>
        /// A list of specific words that you want Contact Lens for Amazon Connect to recognize
        /// in your audio input. They are generally domain-specific words and phrases, words that
        /// Contact Lens is not recognizing, or proper nouns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Vocabulary Vocabulary
        {
            get { return this._vocabulary; }
            set { this._vocabulary = value; }
        }

        // Check to see if Vocabulary property is set
        internal bool IsSetVocabulary()
        {
            return this._vocabulary != null;
        }

    }
}