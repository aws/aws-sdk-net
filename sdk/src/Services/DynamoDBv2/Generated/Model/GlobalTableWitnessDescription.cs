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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the properties of a witness Region in a MRSC global table.
    /// </summary>
    public partial class GlobalTableWitnessDescription
    {
        private string _regionName;
        private WitnessStatus _witnessStatus;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The name of the Amazon Web Services Region that serves as a witness for the MRSC global
        /// table.
        /// </para>
        /// </summary>
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

        /// <summary>
        /// Gets and sets the property WitnessStatus. 
        /// <para>
        /// The current status of the witness Region in the MRSC global table.
        /// </para>
        /// </summary>
        public WitnessStatus WitnessStatus
        {
            get { return this._witnessStatus; }
            set { this._witnessStatus = value; }
        }

        // Check to see if WitnessStatus property is set
        internal bool IsSetWitnessStatus()
        {
            return this._witnessStatus != null;
        }

    }
}