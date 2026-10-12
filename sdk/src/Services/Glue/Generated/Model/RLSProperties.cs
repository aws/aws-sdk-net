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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure that describes the default row-level security policy of a table.
    /// </summary>
    public partial class RLSProperties
    {
        private string _defaultRLSPolicy;

        /// <summary>
        /// Gets and sets the property DefaultRLSPolicy. 
        /// <para>
        /// The name of the default row-level security policy applied to the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DefaultRLSPolicy
        {
            get { return this._defaultRLSPolicy; }
            set { this._defaultRLSPolicy = value; }
        }

        // Check to see if DefaultRLSPolicy property is set
        internal bool IsSetDefaultRLSPolicy()
        {
            return this._defaultRLSPolicy != null;
        }

    }
}