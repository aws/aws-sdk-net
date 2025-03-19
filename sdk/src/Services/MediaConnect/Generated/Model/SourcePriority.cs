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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The priority you want to assign to a source. You can have a primary stream and a
    /// backup stream or two equally prioritized streams.
    /// </summary>
    public partial class SourcePriority
    {
        private string _primarySource;

        /// <summary>
        /// Gets and sets the property PrimarySource. 
        /// <para>
        ///  The name of the source you choose as the primary source for this flow.
        /// </para>
        /// </summary>
        public string PrimarySource
        {
            get { return this._primarySource; }
            set { this._primarySource = value; }
        }

        // Check to see if PrimarySource property is set
        internal bool IsSetPrimarySource()
        {
            return this._primarySource != null;
        }

    }
}