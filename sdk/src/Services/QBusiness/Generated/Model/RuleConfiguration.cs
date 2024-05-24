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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides configuration information about a rule.
    /// </summary>
    public partial class RuleConfiguration
    {
        private ContentBlockerRule _contentBlockerRule;
        private ContentRetrievalRule _contentRetrievalRule;

        /// <summary>
        /// Gets and sets the property ContentBlockerRule. 
        /// <para>
        /// A rule for configuring how Amazon Q Business responds when it encounters a a blocked
        /// topic.
        /// </para>
        /// </summary>
        public ContentBlockerRule ContentBlockerRule
        {
            get { return this._contentBlockerRule; }
            set { this._contentBlockerRule = value; }
        }

        // Check to see if ContentBlockerRule property is set
        internal bool IsSetContentBlockerRule()
        {
            return this._contentBlockerRule != null;
        }

        /// <summary>
        /// Gets and sets the property ContentRetrievalRule.
        /// </summary>
        public ContentRetrievalRule ContentRetrievalRule
        {
            get { return this._contentRetrievalRule; }
            set { this._contentRetrievalRule = value; }
        }

        // Check to see if ContentRetrievalRule property is set
        internal bool IsSetContentRetrievalRule()
        {
            return this._contentRetrievalRule != null;
        }

    }
}