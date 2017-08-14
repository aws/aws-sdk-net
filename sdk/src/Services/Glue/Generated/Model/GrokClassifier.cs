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
    /// A classifier that uses <code>grok</code>.
    /// </summary>
    public partial class GrokClassifier
    {
        private string _classification;
        private DateTime? _creationTime;
        private string _customPatterns;
        private string _grokPattern;
        private DateTime? _lastUpdated;
        private string _name;
        private long? _version;

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// The data form that the classifier matches, such as Twitter, JSON, Omniture Logs, and
        /// so forth.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time this classifier was registered.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomPatterns. 
        /// <para>
        /// Custom grok patterns used by this classifier.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time this classifier was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the classifier.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of this classifier.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}