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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains configurations for authentication to Amazon Redshift Serverless.
    /// </summary>
    public partial class RedshiftServerlessConfiguration
    {
        private RedshiftServerlessAuthConfiguration _authConfiguration;
        private string _workgroupArn;

        /// <summary>
        /// Gets and sets the property AuthConfiguration. 
        /// <para>
        /// Specifies configurations for authentication to an Amazon Redshift provisioned data
        /// warehouse.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RedshiftServerlessAuthConfiguration AuthConfiguration
        {
            get { return this._authConfiguration; }
            set { this._authConfiguration = value; }
        }

        // Check to see if AuthConfiguration property is set
        internal bool IsSetAuthConfiguration()
        {
            return this._authConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkgroupArn. 
        /// <para>
        /// The ARN of the Amazon Redshift workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkgroupArn
        {
            get { return this._workgroupArn; }
            set { this._workgroupArn = value; }
        }

        // Check to see if WorkgroupArn property is set
        internal bool IsSetWorkgroupArn()
        {
            return this._workgroupArn != null;
        }

    }
}