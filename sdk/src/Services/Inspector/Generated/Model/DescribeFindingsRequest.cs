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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFindings operation.
    /// Describes the findings that are specified by the ARNs of the findings.
    /// </summary>
    public partial class DescribeFindingsRequest : AmazonInspectorRequest
    {
        private List<string> _findingArns = new List<string>();
        private Locale _locale;

        /// <summary>
        /// Gets and sets the property FindingArns. 
        /// <para>
        /// The ARN that specifies the finding that you want to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> FindingArns
        {
            get { return this._findingArns; }
            set { this._findingArns = value; }
        }

        // Check to see if FindingArns property is set
        internal bool IsSetFindingArns()
        {
            return this._findingArns != null && this._findingArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale into which you want to translate a finding description, recommendation,
        /// and the short description that identifies the finding.
        /// </para>
        /// </summary>
        public Locale Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

    }
}