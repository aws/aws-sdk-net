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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// A validator provides a syntactic or semantic check to ensure the configuration that
    /// you want to deploy functions as intended. To validate your application configuration
    /// data, you provide a schema or an Amazon Web Services Lambda function that runs against
    /// the configuration. The configuration deployment or update can only proceed when the
    /// configuration data is valid.
    /// </summary>
    public partial class Validator
    {
        private string _content;
        private ValidatorType _type;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Either the JSON Schema content or the Amazon Resource Name (ARN) of an Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=32768)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// AppConfig supports validators of type <code>JSON_SCHEMA</code> and <code>LAMBDA</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidatorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}