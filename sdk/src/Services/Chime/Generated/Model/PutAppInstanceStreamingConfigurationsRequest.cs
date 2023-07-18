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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the PutAppInstanceStreamingConfigurations operation.
    /// The data streaming configurations of an <code>AppInstance</code>.
    /// 
    ///  <important> 
    /// <para>
    ///  <b>This API is is no longer supported and will not be updated.</b> We recommend using
    /// the latest version, <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_messaging-chime_PutMessagingStreamingConfigurations.html">PutMessagingStreamingConfigurations</a>,
    /// in the Amazon Chime SDK.
    /// </para>
    ///  
    /// <para>
    /// Using the latest version requires migrating to a dedicated namespace. For more information,
    /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/migrate-from-chm-namespace.html">Migrating
    /// from the Amazon Chime namespace</a> in the <i>Amazon Chime SDK Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutAppInstanceStreamingConfigurationsRequest : AmazonChimeRequest
    {
        private string _appInstanceArn;
        private List<AppInstanceStreamingConfiguration> _appInstanceStreamingConfigurations = new List<AppInstanceStreamingConfiguration>();

        /// <summary>
        /// Gets and sets the property AppInstanceArn. 
        /// <para>
        /// The ARN of the <code>AppInstance</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string AppInstanceArn
        {
            get { return this._appInstanceArn; }
            set { this._appInstanceArn = value; }
        }

        // Check to see if AppInstanceArn property is set
        internal bool IsSetAppInstanceArn()
        {
            return this._appInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppInstanceStreamingConfigurations. 
        /// <para>
        /// The streaming configurations set for an <code>AppInstance</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<AppInstanceStreamingConfiguration> AppInstanceStreamingConfigurations
        {
            get { return this._appInstanceStreamingConfigurations; }
            set { this._appInstanceStreamingConfigurations = value; }
        }

        // Check to see if AppInstanceStreamingConfigurations property is set
        internal bool IsSetAppInstanceStreamingConfigurations()
        {
            return this._appInstanceStreamingConfigurations != null && this._appInstanceStreamingConfigurations.Count > 0; 
        }

    }
}