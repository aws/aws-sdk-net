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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The keyword to search for in AWS CloudTrail logs.
    /// </summary>
    public partial class SourceKeyword
    {
        private KeywordInputType _keywordInputType;
        private string _keywordValue;

        /// <summary>
        /// Gets and sets the property KeywordInputType. 
        /// <para>
        ///  The method of input for the specified keyword. 
        /// </para>
        /// </summary>
        public KeywordInputType KeywordInputType
        {
            get { return this._keywordInputType; }
            set { this._keywordInputType = value; }
        }

        // Check to see if KeywordInputType property is set
        internal bool IsSetKeywordInputType()
        {
            return this._keywordInputType != null;
        }

        /// <summary>
        /// Gets and sets the property KeywordValue. 
        /// <para>
        ///  The value of the keyword used to search AWS CloudTrail logs when mapping a control
        /// data source. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string KeywordValue
        {
            get { return this._keywordValue; }
            set { this._keywordValue = value; }
        }

        // Check to see if KeywordValue property is set
        internal bool IsSetKeywordValue()
        {
            return this._keywordValue != null;
        }

    }
}