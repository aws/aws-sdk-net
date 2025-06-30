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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Container for the parameters to the GetTransformerJob operation.
    /// Returns the details of the transformer run, based on the Transformer job ID.
    /// 
    ///  <note> 
    /// <para>
    /// If 30 days have elapsed since your transformer job was started, the system deletes
    /// it. So, if you run <c>GetTransformerJob</c> and supply a <c>transformerId</c> and
    /// <c>transformerJobId</c> for a job that was started more than 30 days previously, you
    /// receive a 404 response.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetTransformerJobRequest : AmazonB2biRequest
    {
        private string _transformerId;
        private string _transformerJobId;

        /// <summary>
        /// Gets and sets the property TransformerId. 
        /// <para>
        /// Specifies the system-assigned unique identifier for the transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TransformerId
        {
            get { return this._transformerId; }
            set { this._transformerId = value; }
        }

        // Check to see if TransformerId property is set
        internal bool IsSetTransformerId()
        {
            return this._transformerId != null;
        }

        /// <summary>
        /// Gets and sets the property TransformerJobId. 
        /// <para>
        /// Specifies the unique, system-generated identifier for a transformer run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=25, Max=25)]
        public string TransformerJobId
        {
            get { return this._transformerJobId; }
            set { this._transformerJobId = value; }
        }

        // Check to see if TransformerJobId property is set
        internal bool IsSetTransformerJobId()
        {
            return this._transformerJobId != null;
        }

    }
}