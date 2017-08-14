/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateClassifier operation.
    /// Creates a <code>Classifier</code> in the user's account.
    /// </summary>
    public partial class CreateClassifierRequest : AmazonGlueRequest
    {
        private CreateGrokClassifierRequest _grokClassifier;

        /// <summary>
        /// Gets and sets the property GrokClassifier. 
        /// <para>
        /// A grok classifier to create.
        /// </para>
        /// </summary>
        public CreateGrokClassifierRequest GrokClassifier
        {
            get { return this._grokClassifier; }
            set { this._grokClassifier = value; }
        }

        // Check to see if GrokClassifier property is set
        internal bool IsSetGrokClassifier()
        {
            return this._grokClassifier != null;
        }

    }
}