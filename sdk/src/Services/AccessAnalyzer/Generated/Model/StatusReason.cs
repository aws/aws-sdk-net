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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Provides more details about the current status of the analyzer. For example, if the
    /// creation for the analyzer fails, a <c>Failed</c> status is returned. For an analyzer
    /// with organization as the type, this failure can be due to an issue with creating the
    /// service-linked roles required in the member accounts of the Amazon Web Services organization.
    /// </summary>
    public partial class StatusReason
    {
        private ReasonCode _code;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The reason code for the current status of the analyzer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReasonCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

    }
}