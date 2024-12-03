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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The DataIntegrationFlow transformation parameters.
    /// </summary>
    public partial class DataIntegrationFlowTransformation
    {
        private DataIntegrationFlowSQLTransformationConfiguration _sqlTransformation;
        private DataIntegrationFlowTransformationType _transformationType;

        /// <summary>
        /// Gets and sets the property SqlTransformation. 
        /// <para>
        /// The SQL DataIntegrationFlow transformation configuration.
        /// </para>
        /// </summary>
        public DataIntegrationFlowSQLTransformationConfiguration SqlTransformation
        {
            get { return this._sqlTransformation; }
            set { this._sqlTransformation = value; }
        }

        // Check to see if SqlTransformation property is set
        internal bool IsSetSqlTransformation()
        {
            return this._sqlTransformation != null;
        }

        /// <summary>
        /// Gets and sets the property TransformationType. 
        /// <para>
        /// The DataIntegrationFlow transformation type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataIntegrationFlowTransformationType TransformationType
        {
            get { return this._transformationType; }
            set { this._transformationType = value; }
        }

        // Check to see if TransformationType property is set
        internal bool IsSetTransformationType()
        {
            return this._transformationType != null;
        }

    }
}