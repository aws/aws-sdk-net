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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Amazon Web Services Glue properties patch of a connection.
    /// </summary>
    public partial class GluePropertiesPatch
    {
        private GlueConnectionPatch _glueConnectionInput;

        /// <summary>
        /// Gets and sets the property GlueConnectionInput. 
        /// <para>
        /// The Amazon Web Services Glue properties patch of a connection.
        /// </para>
        /// </summary>
        public GlueConnectionPatch GlueConnectionInput
        {
            get { return this._glueConnectionInput; }
            set { this._glueConnectionInput = value; }
        }

        // Check to see if GlueConnectionInput property is set
        internal bool IsSetGlueConnectionInput()
        {
            return this._glueConnectionInput != null;
        }

    }
}