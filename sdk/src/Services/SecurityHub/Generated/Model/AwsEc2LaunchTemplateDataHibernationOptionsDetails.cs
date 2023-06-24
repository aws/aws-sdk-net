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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies whether your Amazon EC2 instance is configured for hibernation.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataHibernationOptionsDetails
    {
        private bool? _configured;

        /// <summary>
        /// Gets and sets the property Configured. 
        /// <para>
        ///  If you set this parameter to <code>true</code>, the instance is enabled for hibernation.
        /// 
        /// </para>
        /// </summary>
        public bool Configured
        {
            get { return this._configured.GetValueOrDefault(); }
            set { this._configured = value; }
        }

        // Check to see if Configured property is set
        internal bool IsSetConfigured()
        {
            return this._configured.HasValue; 
        }

    }
}