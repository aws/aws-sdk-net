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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
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
namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// High-level information about an AppInstanceBot.
    /// </summary>
    public partial class AppInstanceBotSummary
    {
        private string _appInstanceBotArn;
        private string _metadata;
        private string _name;

        /// <summary>
        /// Gets and sets the property AppInstanceBotArn. 
        /// <para>
        /// The ARN of the AppInstanceBot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1600)]
        public string AppInstanceBotArn
        {
            get { return this._appInstanceBotArn; }
            set { this._appInstanceBotArn = value; }
        }

        // Check to see if AppInstanceBotArn property is set
        internal bool IsSetAppInstanceBotArn()
        {
            return this._appInstanceBotArn != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata of the AppInstanceBot.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AppInstanceBox.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}