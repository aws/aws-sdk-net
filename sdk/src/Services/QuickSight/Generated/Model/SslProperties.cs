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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Secure Socket Layer (SSL) properties that apply when QuickSight connects to your underlying
    /// data source.
    /// </summary>
    public partial class SslProperties
    {
        private bool? _disableSsl;

        /// <summary>
        /// Gets and sets the property DisableSsl. 
        /// <para>
        /// A Boolean option to control whether SSL should be disabled.
        /// </para>
        /// </summary>
        public bool? DisableSsl
        {
            get { return this._disableSsl; }
            set { this._disableSsl = value; }
        }

        // Check to see if DisableSsl property is set
        internal bool IsSetDisableSsl()
        {
            return this._disableSsl.HasValue; 
        }

    }
}