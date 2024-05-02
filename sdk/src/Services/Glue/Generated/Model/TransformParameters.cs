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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The algorithm-specific parameters that are associated with the machine learning transform.
    /// </summary>
    public partial class TransformParameters
    {
        private FindMatchesParameters _findMatchesParameters;
        private TransformType _transformType;

        /// <summary>
        /// Gets and sets the property FindMatchesParameters. 
        /// <para>
        /// The parameters for the find matches algorithm.
        /// </para>
        /// </summary>
        public FindMatchesParameters FindMatchesParameters
        {
            get { return this._findMatchesParameters; }
            set { this._findMatchesParameters = value; }
        }

        // Check to see if FindMatchesParameters property is set
        internal bool IsSetFindMatchesParameters()
        {
            return this._findMatchesParameters != null;
        }

        /// <summary>
        /// Gets and sets the property TransformType. 
        /// <para>
        /// The type of machine learning transform.
        /// </para>
        ///  
        /// <para>
        /// For information about the types of machine learning transforms, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job-machine-learning-transform.html">Creating
        /// Machine Learning Transforms</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformType TransformType
        {
            get { return this._transformType; }
            set { this._transformType = value; }
        }

        // Check to see if TransformType property is set
        internal bool IsSetTransformType()
        {
            return this._transformType != null;
        }

    }
}