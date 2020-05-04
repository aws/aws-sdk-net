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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The label schema.
    /// </summary>
    public partial class LabelSchema
    {
        private string _labelKey;
        private Dictionary<string, List<string>> _labelMapper = new Dictionary<string, List<string>>();

        /// <summary>
        /// Gets and sets the property LabelKey. 
        /// <para>
        /// The label key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LabelKey
        {
            get { return this._labelKey; }
            set { this._labelKey = value; }
        }

        // Check to see if LabelKey property is set
        internal bool IsSetLabelKey()
        {
            return this._labelKey != null;
        }

        /// <summary>
        /// Gets and sets the property LabelMapper. 
        /// <para>
        /// The label mapper maps the Amazon Fraud Detector supported label to the appropriate
        /// source labels. For example, if <code>"FRAUD"</code> and <code>"LEGIT"</code> are Amazon
        /// Fraud Detector supported labels, this mapper could be: <code>{"FRAUD" =&gt; ["0"]</code>,
        /// "LEGIT" =&gt; ["1"]} or <code>{"FRAUD" =&gt; ["false"], "LEGIT" =&gt; ["true"]}</code>
        /// or <code>{"FRAUD" =&gt; ["fraud", "abuse"], "LEGIT" =&gt; ["legit", "safe"]}</code>.
        /// The value part of the mapper is a list, because you may have multiple variants for
        /// a single Amazon Fraud Detector label. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, List<string>> LabelMapper
        {
            get { return this._labelMapper; }
            set { this._labelMapper = value; }
        }

        // Check to see if LabelMapper property is set
        internal bool IsSetLabelMapper()
        {
            return this._labelMapper != null && this._labelMapper.Count > 0; 
        }

    }
}