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
    /// This is the response object from the CreateVocabulary operation.
    /// </summary>
    public partial class CreateVocabularyResponse : AmazonWebServiceResponse
    {
        private VocabularyState _state;
        private string _vocabularyArn;
        private string _vocabularyId;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the custom vocabulary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VocabularyState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom vocabulary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VocabularyArn
        {
            get { return this._vocabularyArn; }
            set { this._vocabularyArn = value; }
        }

        // Check to see if VocabularyArn property is set
        internal bool IsSetVocabularyArn()
        {
            return this._vocabularyArn != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyId. 
        /// <para>
        /// The identifier of the custom vocabulary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string VocabularyId
        {
            get { return this._vocabularyId; }
            set { this._vocabularyId = value; }
        }

        // Check to see if VocabularyId property is set
        internal bool IsSetVocabularyId()
        {
            return this._vocabularyId != null;
        }

    }
}