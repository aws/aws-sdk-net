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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The transportable tablespace configuration used when creating an Autonomous Database.
    /// </summary>
    public partial class TransportableTablespace
    {
        private string _ttsBundleUrl;

        /// <summary>
        /// Gets and sets the property TtsBundleUrl. 
        /// <para>
        /// The URL of the transportable tablespace bundle to use when creating the Autonomous
        /// Database.
        /// </para>
        /// </summary>
        public string TtsBundleUrl
        {
            get { return this._ttsBundleUrl; }
            set { this._ttsBundleUrl = value; }
        }

        // Check to see if TtsBundleUrl property is set
        internal bool IsSetTtsBundleUrl()
        {
            return this._ttsBundleUrl != null;
        }

    }
}