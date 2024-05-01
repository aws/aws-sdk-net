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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object which contains <c>ReplacementTemplateData</c> to be used for a specific
    /// <c>BulkEmailEntry</c>.
    /// </summary>
    public partial class ReplacementTemplate
    {
        private string _replacementTemplateData;

        /// <summary>
        /// Gets and sets the property ReplacementTemplateData. 
        /// <para>
        /// A list of replacement values to apply to the template. This parameter is a JSON object,
        /// typically consisting of key-value pairs in which the keys correspond to replacement
        /// tags in the email template.
        /// </para>
        /// </summary>
        [AWSProperty(Max=262144)]
        public string ReplacementTemplateData
        {
            get { return this._replacementTemplateData; }
            set { this._replacementTemplateData = value; }
        }

        // Check to see if ReplacementTemplateData property is set
        internal bool IsSetReplacementTemplateData()
        {
            return this._replacementTemplateData != null;
        }

    }
}