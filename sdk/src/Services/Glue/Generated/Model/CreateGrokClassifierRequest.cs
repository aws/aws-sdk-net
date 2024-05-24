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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a <c>grok</c> classifier for <c>CreateClassifier</c> to create.
    /// </summary>
    public partial class CreateGrokClassifierRequest
    {
        private string _classification;
        private string _customPatterns;
        private string _grokPattern;
        private string _name;

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// An identifier of the data format that the classifier matches, such as Twitter, JSON,
        /// Omniture logs, Amazon CloudWatch Logs, and so on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Classification
        {
            get { return this._classification; }
            set { this._classification = value; }
        }

        // Check to see if Classification property is set
        internal bool IsSetClassification()
        {
            return this._classification != null;
        }

        /// <summary>
        /// Gets and sets the property CustomPatterns. 
        /// <para>
        /// Optional custom grok patterns used by this classifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16000)]
        public string CustomPatterns
        {
            get { return this._customPatterns; }
            set { this._customPatterns = value; }
        }

        // Check to see if CustomPatterns property is set
        internal bool IsSetCustomPatterns()
        {
            return this._customPatterns != null;
        }

        /// <summary>
        /// Gets and sets the property GrokPattern. 
        /// <para>
        /// The grok pattern used by this classifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string GrokPattern
        {
            get { return this._grokPattern; }
            set { this._grokPattern = value; }
        }

        // Check to see if GrokPattern property is set
        internal bool IsSetGrokPattern()
        {
            return this._grokPattern != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new classifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}