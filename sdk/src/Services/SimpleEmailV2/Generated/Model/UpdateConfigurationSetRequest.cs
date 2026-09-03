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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConfigurationSet operation.
    /// Updates an existing configuration set.
    /// 
    ///  
    /// <para>
    /// This operation performs a partial update. Only the attributes that you include in
    /// the request are updated; any omitted attribute is left unchanged.
    /// </para>
    /// </summary>
    public partial class UpdateConfigurationSetRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _configurationSetName;
        private MessageSecurityOptions _messageSecurityOptions;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property MessageSecurityOptions. 
        /// <para>
        /// The security options that apply to the MIME message itself for messages sent with
        /// the configuration set.
        /// </para>
        /// </summary>
        public MessageSecurityOptions MessageSecurityOptions
        {
            get { return this._messageSecurityOptions; }
            set { this._messageSecurityOptions = value; }
        }

        // Check to see if MessageSecurityOptions property is set
        internal bool IsSetMessageSecurityOptions()
        {
            return this._messageSecurityOptions != null;
        }

    }
}