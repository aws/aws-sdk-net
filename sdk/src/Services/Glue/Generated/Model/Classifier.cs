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
    /// Classifiers are written in Python and triggered during a Crawl Task. You can write
    /// your own Classifiers to best categorize your data sources and specify the appropriate
    /// schemas to use for them. A Classifier first checks whether a given file is in a format
    /// it can handle, and then, if so, creates a schema in the form of a <code>StructType</code>
    /// object that matches that data format.
    /// </summary>
    public partial class Classifier
    {
        private GrokClassifier _grokClassifier;

        /// <summary>
        /// Gets and sets the property GrokClassifier. 
        /// <para>
        /// A GrokClassifier object.
        /// </para>
        /// </summary>
        public GrokClassifier GrokClassifier
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