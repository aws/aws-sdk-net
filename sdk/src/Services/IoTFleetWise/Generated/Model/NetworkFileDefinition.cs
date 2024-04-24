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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Specifications for defining a vehicle network.
    /// </summary>
    public partial class NetworkFileDefinition
    {
        private CanDbcDefinition _canDbc;

        /// <summary>
        /// Gets and sets the property CanDbc. 
        /// <para>
        /// Information, including CAN DBC files, about the configurations used to create a decoder
        /// manifest.
        /// </para>
        /// </summary>
        public CanDbcDefinition CanDbc
        {
            get { return this._canDbc; }
            set { this._canDbc = value; }
        }

        // Check to see if CanDbc property is set
        internal bool IsSetCanDbc()
        {
            return this._canDbc != null;
        }

    }
}