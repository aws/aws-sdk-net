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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// The supported source types from which logs and events are collected in Amazon Security
    /// Lake. For a list of supported Amazon Web Services services, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/internal-sources.html">Amazon
    /// Security Lake User Guide</a>.
    /// </summary>
    public partial class LogSourceResource
    {
        private AwsLogSourceResource _awsLogSource;
        private CustomLogSourceResource _customLogSource;

        /// <summary>
        /// Gets and sets the property AwsLogSource. 
        /// <para>
        /// Amazon Security Lake supports log and event collection for natively supported Amazon
        /// Web Services services. For more information, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/internal-sources.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
        /// </summary>
        public AwsLogSourceResource AwsLogSource
        {
            get { return this._awsLogSource; }
            set { this._awsLogSource = value; }
        }

        // Check to see if AwsLogSource property is set
        internal bool IsSetAwsLogSource()
        {
            return this._awsLogSource != null;
        }

        /// <summary>
        /// Gets and sets the property CustomLogSource. 
        /// <para>
        /// Amazon Security Lake supports custom source types. For more information, see the <a
        /// href="https://docs.aws.amazon.com/security-lake/latest/userguide/custom-sources.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
        /// </summary>
        public CustomLogSourceResource CustomLogSource
        {
            get { return this._customLogSource; }
            set { this._customLogSource = value; }
        }

        // Check to see if CustomLogSource property is set
        internal bool IsSetCustomLogSource()
        {
            return this._customLogSource != null;
        }

    }
}