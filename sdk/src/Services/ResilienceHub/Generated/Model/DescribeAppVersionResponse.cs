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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeAppVersion operation.
    /// </summary>
    public partial class DescribeAppVersionResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, List<string>> _additionalInfo = new Dictionary<string, List<string>>();
        private string _appArn;
        private string _appVersion;

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Additional configuration parameters for an Resilience Hub application. If you want
        /// to implement <code>additionalInfo</code> through the Resilience Hub console rather
        /// than using an API call, see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/app-config-param.html">Configure
        /// the application configuration parameters</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, this parameter supports only failover region and account.
        /// </para>
        ///  </note>
        /// </summary>
        public Dictionary<string, List<string>> AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null && this._additionalInfo.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:app/<code>app-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i> guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The Resilience Hub application version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppVersion
        {
            get { return this._appVersion; }
            set { this._appVersion = value; }
        }

        // Check to see if AppVersion property is set
        internal bool IsSetAppVersion()
        {
            return this._appVersion != null;
        }

    }
}