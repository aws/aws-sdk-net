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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Contains validation parameters.
    /// </summary>
    public partial class UserDataValidationParameters
    {
        private ScriptType _scriptType;
        private Source _source;

        /// <summary>
        /// Gets and sets the property ScriptType. 
        /// <para>
        /// The type of validation script.
        /// </para>
        /// </summary>
        public ScriptType ScriptType
        {
            get { return this._scriptType; }
            set { this._scriptType = value; }
        }

        // Check to see if ScriptType property is set
        internal bool IsSetScriptType()
        {
            return this._scriptType != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The location of the validation script.
        /// </para>
        /// </summary>
        public Source Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}