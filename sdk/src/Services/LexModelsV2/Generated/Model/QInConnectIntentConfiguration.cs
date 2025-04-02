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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The configuration details of the Qinconnect intent.
    /// </summary>
    public partial class QInConnectIntentConfiguration
    {
        private QInConnectAssistantConfiguration _qInConnectAssistantConfiguration;

        /// <summary>
        /// Gets and sets the property QInConnectAssistantConfiguration. 
        /// <para>
        /// The Qinconnect assistant configuration details of the Qinconnect intent.
        /// </para>
        /// </summary>
        public QInConnectAssistantConfiguration QInConnectAssistantConfiguration
        {
            get { return this._qInConnectAssistantConfiguration; }
            set { this._qInConnectAssistantConfiguration = value; }
        }

        // Check to see if QInConnectAssistantConfiguration property is set
        internal bool IsSetQInConnectAssistantConfiguration()
        {
            return this._qInConnectAssistantConfiguration != null;
        }

    }
}