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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
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
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// The database details of an Amazon RDS database.
    /// </summary>
    public partial class RDSDatabase
    {
        private string _databaseName;
        private string _instanceIdentifier;

        /// <summary>
        /// Gets and sets the property DatabaseName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceIdentifier. 
        /// <para>
        /// The ID of an RDS DB instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string InstanceIdentifier
        {
            get { return this._instanceIdentifier; }
            set { this._instanceIdentifier = value; }
        }

        // Check to see if InstanceIdentifier property is set
        internal bool IsSetInstanceIdentifier()
        {
            return this._instanceIdentifier != null;
        }

    }
}