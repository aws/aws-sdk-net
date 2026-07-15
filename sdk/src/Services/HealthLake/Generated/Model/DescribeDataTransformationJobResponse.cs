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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The response from the <c>DescribeDataTransformationJob</c> operation.
    /// </summary>
    public partial class DescribeDataTransformationJobResponse : AmazonWebServiceResponse
    {
        private TransformationJobProperties _transformationJobProperties;

        /// <summary>
        /// Gets and sets the property TransformationJobProperties. 
        /// <para>
        /// The properties of the data transformation job, including status, configuration, and
        /// progress information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformationJobProperties TransformationJobProperties
        {
            get { return this._transformationJobProperties; }
            set { this._transformationJobProperties = value; }
        }

        // Check to see if TransformationJobProperties property is set
        internal bool IsSetTransformationJobProperties()
        {
            return this._transformationJobProperties != null;
        }

    }
}