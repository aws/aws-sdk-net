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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// This is the response object from the CreateConfiguredTable operation.
    /// </summary>
    public partial class CreateConfiguredTableResponse : AmazonWebServiceResponse
    {
        private ConfiguredTable _configuredTable;

        /// <summary>
        /// Gets and sets the property ConfiguredTable. 
        /// <para>
        /// The created configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfiguredTable ConfiguredTable
        {
            get { return this._configuredTable; }
            set { this._configuredTable = value; }
        }

        // Check to see if ConfiguredTable property is set
        internal bool IsSetConfiguredTable()
        {
            return this._configuredTable != null;
        }

    }
}