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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A lineage entity connected to the starting entity(ies).
    /// </summary>
    public partial class Vertex
    {
        private string _arn;
        private LineageType _lineageType;
        private string _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lineage entity resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property LineageType. 
        /// <para>
        /// The type of resource of the lineage entity.
        /// </para>
        /// </summary>
        public LineageType LineageType
        {
            get { return this._lineageType; }
            set { this._lineageType = value; }
        }

        // Check to see if LineageType property is set
        internal bool IsSetLineageType()
        {
            return this._lineageType != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the lineage entity resource. For example: <c>DataSet</c>, <c>Model</c>,
        /// <c>Endpoint</c>, etc...
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}