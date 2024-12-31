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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The settings for what common media server data (CMSD) headers AWS Elemental MediaPackage
    /// includes in responses to the CDN.
    /// </summary>
    public partial class OutputHeaderConfiguration
    {
        private bool? _publishMQCS;

        /// <summary>
        /// Gets and sets the property PublishMQCS. 
        /// <para>
        /// When true, AWS Elemental MediaPackage includes the MQCS in responses to the CDN. This
        /// setting is valid only when <c>InputType</c> is <c>CMAF</c>.
        /// </para>
        /// </summary>
        public bool? PublishMQCS
        {
            get { return this._publishMQCS; }
            set { this._publishMQCS = value; }
        }

        // Check to see if PublishMQCS property is set
        internal bool IsSetPublishMQCS()
        {
            return this._publishMQCS.HasValue; 
        }

    }
}