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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// A structure that contains information about a dependency for a canary.
    /// </summary>
    public partial class Dependency
    {
        private string _reference;
        private DependencyType _type;

        /// <summary>
        /// Gets and sets the property Reference. 
        /// <para>
        /// The dependency reference. For Lambda layers, this is the ARN of the Lambda layer.
        /// For more information about Lambda ARN format, see <a href="https://docs.aws.amazon.com/lambda/latest/api/API_Layer.html">Lambda</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Reference
        {
            get { return this._reference; }
            set { this._reference = value; }
        }

        // Check to see if Reference property is set
        internal bool IsSetReference()
        {
            return this._reference != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of dependency. Valid value is <c>LambdaLayer</c>.
        /// </para>
        /// </summary>
        public DependencyType Type
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