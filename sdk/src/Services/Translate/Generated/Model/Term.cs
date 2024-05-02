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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
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
namespace Amazon.Translate.Model
{
    /// <summary>
    /// The term being translated by the custom terminology.
    /// </summary>
    public partial class Term
    {
        private string _sourceText;
        private string _targetText;

        /// <summary>
        /// Gets and sets the property SourceText. 
        /// <para>
        /// The source text of the term being translated by the custom terminology.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string SourceText
        {
            get { return this._sourceText; }
            set { this._sourceText = value; }
        }

        // Check to see if SourceText property is set
        internal bool IsSetSourceText()
        {
            return this._sourceText != null;
        }

        /// <summary>
        /// Gets and sets the property TargetText. 
        /// <para>
        /// The target text of the term being translated by the custom terminology.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string TargetText
        {
            get { return this._targetText; }
            set { this._targetText = value; }
        }

        // Check to see if TargetText property is set
        internal bool IsSetTargetText()
        {
            return this._targetText != null;
        }

    }
}