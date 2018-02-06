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
    /// Container for the parameters to the UpdateClassifier operation.
    /// Modifies an existing classifier (a <code>GrokClassifier</code>, <code>XMLClassifier</code>,
    /// or <code>JsonClassifier</code>, depending on which field is present).
    /// </summary>
    public partial class UpdateClassifierRequest : AmazonGlueRequest
    {
        private UpdateGrokClassifierRequest _grokClassifier;
        private UpdateJsonClassifierRequest _jsonClassifier;
        private UpdateXMLClassifierRequest _xmlClassifier;

        /// <summary>
        /// Gets and sets the property GrokClassifier. 
        /// <para>
        /// A <code>GrokClassifier</code> object with updated fields.
        /// </para>
        /// </summary>
        public UpdateGrokClassifierRequest GrokClassifier
        {
            get { return this._grokClassifier; }
            set { this._grokClassifier = value; }
        }

        // Check to see if GrokClassifier property is set
        internal bool IsSetGrokClassifier()
        {
            return this._grokClassifier != null;
        }

        /// <summary>
        /// Gets and sets the property JsonClassifier. 
        /// <para>
        /// A <code>JsonClassifier</code> object with updated fields.
        /// </para>
        /// </summary>
        public UpdateJsonClassifierRequest JsonClassifier
        {
            get { return this._jsonClassifier; }
            set { this._jsonClassifier = value; }
        }

        // Check to see if JsonClassifier property is set
        internal bool IsSetJsonClassifier()
        {
            return this._jsonClassifier != null;
        }

        /// <summary>
        /// Gets and sets the property XMLClassifier. 
        /// <para>
        /// An <code>XMLClassifier</code> object with updated fields.
        /// </para>
        /// </summary>
        public UpdateXMLClassifierRequest XMLClassifier
        {
            get { return this._xmlClassifier; }
            set { this._xmlClassifier = value; }
        }

        // Check to see if XMLClassifier property is set
        internal bool IsSetXMLClassifier()
        {
            return this._xmlClassifier != null;
        }

    }
}