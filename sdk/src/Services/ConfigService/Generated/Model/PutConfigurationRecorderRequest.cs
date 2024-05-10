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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfigurationRecorder operation.
    /// Creates a new configuration recorder to record configuration changes for specified
    /// resource types.
    /// 
    ///  
    /// <para>
    /// You can also use this action to change the <c>roleARN</c> or the <c>recordingGroup</c>
    /// of an existing recorder. For more information, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/stop-start-recorder.html">
    /// <b>Managing the Configuration Recorder</b> </a> in the <i>Config Developer Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can specify only one configuration recorder for each Amazon Web Services Region
    /// for each account.
    /// </para>
    ///  
    /// <para>
    /// If the configuration recorder does not have the <c>recordingGroup</c> field specified,
    /// the default is to record all supported resource types.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutConfigurationRecorderRequest : AmazonConfigServiceRequest
    {
        private ConfigurationRecorder _configurationRecorder;

        /// <summary>
        /// Gets and sets the property ConfigurationRecorder. 
        /// <para>
        /// An object for the configuration recorder to record configuration changes for specified
        /// resource types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationRecorder ConfigurationRecorder
        {
            get { return this._configurationRecorder; }
            set { this._configurationRecorder = value; }
        }

        // Check to see if ConfigurationRecorder property is set
        internal bool IsSetConfigurationRecorder()
        {
            return this._configurationRecorder != null;
        }

    }
}