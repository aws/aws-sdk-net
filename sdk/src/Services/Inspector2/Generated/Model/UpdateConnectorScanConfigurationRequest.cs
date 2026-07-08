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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnectorScanConfiguration operation.
    /// Updates scan configuration settings for resources associated with an Amazon Web Services
    /// Config connector.
    /// </summary>
    public partial class UpdateConnectorScanConfigurationRequest : AmazonInspector2Request
    {
        private string _awsConfigConnectorArn;
        private ConnectorScanConfiguration _scanConfiguration;

        /// <summary>
        /// Gets and sets the property AwsConfigConnectorArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Config connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AwsConfigConnectorArn
        {
            get { return this._awsConfigConnectorArn; }
            set { this._awsConfigConnectorArn = value; }
        }

        // Check to see if AwsConfigConnectorArn property is set
        internal bool IsSetAwsConfigConnectorArn()
        {
            return this._awsConfigConnectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScanConfiguration. 
        /// <para>
        /// The scan configuration settings to apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorScanConfiguration ScanConfiguration
        {
            get { return this._scanConfiguration; }
            set { this._scanConfiguration = value; }
        }

        // Check to see if ScanConfiguration property is set
        internal bool IsSetScanConfiguration()
        {
            return this._scanConfiguration != null;
        }

    }
}