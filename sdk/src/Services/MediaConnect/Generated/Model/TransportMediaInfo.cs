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
    /// The metadata of the transport stream in the current flow's source.
    /// </summary>
    public partial class TransportMediaInfo
    {
        private List<TransportStreamProgram> _programs = AWSConfigs.InitializeCollections ? new List<TransportStreamProgram>() : null;

        /// <summary>
        /// Gets and sets the property Programs. 
        /// <para>
        ///  The list of transport stream programs in the current flow's source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TransportStreamProgram> Programs
        {
            get { return this._programs; }
            set { this._programs = value; }
        }

        // Check to see if Programs property is set
        internal bool IsSetPrograms()
        {
            return this._programs != null && (this._programs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}