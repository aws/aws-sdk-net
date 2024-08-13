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
    /// Specifies settings that are unique to a locale. For example, you can use different
    /// Lambda function depending on the bot's locale.
    /// </summary>
    public partial class BotAliasLocaleSettings
    {
        private CodeHookSpecification _codeHookSpecification;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property CodeHookSpecification. 
        /// <para>
        /// Specifies the Lambda function that should be used in the locale.
        /// </para>
        /// </summary>
        public CodeHookSpecification CodeHookSpecification
        {
            get { return this._codeHookSpecification; }
            set { this._codeHookSpecification = value; }
        }

        // Check to see if CodeHookSpecification property is set
        internal bool IsSetCodeHookSpecification()
        {
            return this._codeHookSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Determines whether the locale is enabled for the bot. If the value is <c>false</c>,
        /// the locale isn't available for use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}