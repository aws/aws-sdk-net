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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// The data type of the column.
    /// </summary>
    public partial class ColumnType
    {
        private ScalarType _scalarType;

        /// <summary>
        /// Gets and sets the property ScalarType. 
        /// <para>
        /// The allowed data types that the column has as it's value.
        /// </para>
        /// </summary>
        public ScalarType ScalarType
        {
            get { return this._scalarType; }
            set { this._scalarType = value; }
        }

        // Check to see if ScalarType property is set
        internal bool IsSetScalarType()
        {
            return this._scalarType != null;
        }

    }
}