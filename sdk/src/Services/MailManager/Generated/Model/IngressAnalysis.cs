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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The Add On ARN and its returned value that is evaluated in a policy statement's conditional
    /// expression to either deny or block the incoming email.
    /// </summary>
    public partial class IngressAnalysis
    {
        private string _analyzer;
        private string _resultField;

        /// <summary>
        /// Gets and sets the property Analyzer. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Add On.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Analyzer
        {
            get { return this._analyzer; }
            set { this._analyzer = value; }
        }

        // Check to see if Analyzer property is set
        internal bool IsSetAnalyzer()
        {
            return this._analyzer != null;
        }

        /// <summary>
        /// Gets and sets the property ResultField. 
        /// <para>
        /// The returned value from an Add On.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResultField
        {
            get { return this._resultField; }
            set { this._resultField = value; }
        }

        // Check to see if ResultField property is set
        internal bool IsSetResultField()
        {
            return this._resultField != null;
        }

    }
}