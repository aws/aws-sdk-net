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
    /// The string to evaluate in a string condition expression.
    /// </summary>
    public partial class RuleStringToEvaluate
    {
        private Analysis _analysis;
        private RuleStringEmailAttribute _attribute;
        private string _mimeHeaderAttribute;

        /// <summary>
        /// Gets and sets the property Analysis. 
        /// <para>
        /// The Add On ARN and its returned value to evaluate in a string condition expression.
        /// </para>
        /// </summary>
        public Analysis Analysis
        {
            get { return this._analysis; }
            set { this._analysis = value; }
        }

        // Check to see if Analysis property is set
        internal bool IsSetAnalysis()
        {
            return this._analysis != null;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The email attribute to evaluate in a string condition expression.
        /// </para>
        /// </summary>
        public RuleStringEmailAttribute Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property MimeHeaderAttribute. 
        /// <para>
        /// The email MIME X-Header attribute to evaluate in a string condition expression.
        /// </para>
        /// </summary>
        public string MimeHeaderAttribute
        {
            get { return this._mimeHeaderAttribute; }
            set { this._mimeHeaderAttribute = value; }
        }

        // Check to see if MimeHeaderAttribute property is set
        internal bool IsSetMimeHeaderAttribute()
        {
            return this._mimeHeaderAttribute != null;
        }

    }
}