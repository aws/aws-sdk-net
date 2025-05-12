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
    /// The ID and ID type of an artifact source.
    /// </summary>
    public partial class ArtifactSourceType
    {
        private ArtifactSourceIdType _sourceIdType;
        private string _value;

        /// <summary>
        /// Gets and sets the property SourceIdType. 
        /// <para>
        /// The type of ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ArtifactSourceIdType SourceIdType
        {
            get { return this._sourceIdType; }
            set { this._sourceIdType = value; }
        }

        // Check to see if SourceIdType property is set
        internal bool IsSetSourceIdType()
        {
            return this._sourceIdType != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}