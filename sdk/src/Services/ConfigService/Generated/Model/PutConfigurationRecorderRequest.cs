/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfigurationRecorder operation.
    /// Creates a new configuration recorder to record the selected resource configurations.
    /// 
    ///  
    /// <para>
    /// You can use this action to change the role <code>roleARN</code> or the <code>recordingGroup</code>
    /// of an existing recorder. To change the role, call the action on the existing configuration
    /// recorder and specify a role.
    /// </para>
    ///  <note> 
    /// <para>
    /// Currently, you can specify only one configuration recorder per region in your account.
    /// </para>
    ///  
    /// <para>
    /// If <code>ConfigurationRecorder</code> does not have the <b>recordingGroup</b> parameter
    /// specified, the default is to record all supported resource types.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutConfigurationRecorderRequest : AmazonConfigServiceRequest
    {
        private ConfigurationRecorder _configurationRecorder;

        /// <summary>
        /// Gets and sets the property ConfigurationRecorder. 
        /// <para>
        /// The configuration recorder object that records each configuration change made to the
        /// resources.
        /// </para>
        /// </summary>
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