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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// The response from updating an integration.
    /// </summary>
    public partial class UpdateIntegrationResponse : AmazonWebServiceResponse
    {
        private Integration _integration;

        /// <summary>
        /// Gets and sets the property Integration. 
        /// <para>
        /// The details of the updated integration. This is the same object returned by GetIntegration
        /// and CreateIntegration. Populated on a successful update; absent only if the post-update
        /// read-back of the resource did not complete.
        /// </para>
        /// </summary>
        public Integration Integration
        {
            get { return this._integration; }
            set { this._integration = value; }
        }

        // Check to see if Integration property is set
        internal bool IsSetIntegration()
        {
            return this._integration != null;
        }

    }
}