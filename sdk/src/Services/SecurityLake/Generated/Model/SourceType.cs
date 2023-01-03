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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// The supported source types from which logs and events are collected in Amazon Security
    /// Lake. For the list of supported Amazon Web Services, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/internal-sources.html">Amazon
    /// Security Lake User Guide</a>.
    /// </summary>
    public partial class SourceType
    {
        private AwsLogSourceType _awsSourceType;
        private string _customSourceType;

        /// <summary>
        /// Gets and sets the property AwsSourceType. 
        /// <para>
        /// Amazon Security Lake supports log and event collection for natively supported Amazon
        /// Web Services. 
        /// </para>
        /// </summary>
        public AwsLogSourceType AwsSourceType
        {
            get { return this._awsSourceType; }
            set { this._awsSourceType = value; }
        }

        // Check to see if AwsSourceType property is set
        internal bool IsSetAwsSourceType()
        {
            return this._awsSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property CustomSourceType. 
        /// <para>
        /// Amazon Security Lake supports custom source types. For a detailed list, see the Amazon
        /// Security Lake User Guide.
        /// </para>
        /// </summary>
        public string CustomSourceType
        {
            get { return this._customSourceType; }
            set { this._customSourceType = value; }
        }

        // Check to see if CustomSourceType property is set
        internal bool IsSetCustomSourceType()
        {
            return this._customSourceType != null;
        }

    }
}