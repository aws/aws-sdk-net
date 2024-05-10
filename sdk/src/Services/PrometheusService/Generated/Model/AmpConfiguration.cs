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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// The <c>AmpConfiguration</c> structure defines the Amazon Managed Service for Prometheus
    /// instance a scraper should send metrics to.
    /// </summary>
    public partial class AmpConfiguration
    {
        private string _workspaceArn;

        /// <summary>
        /// Gets and sets the property WorkspaceArn. 
        /// <para>
        /// ARN of the Amazon Managed Service for Prometheus workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkspaceArn
        {
            get { return this._workspaceArn; }
            set { this._workspaceArn = value; }
        }

        // Check to see if WorkspaceArn property is set
        internal bool IsSetWorkspaceArn()
        {
            return this._workspaceArn != null;
        }

    }
}