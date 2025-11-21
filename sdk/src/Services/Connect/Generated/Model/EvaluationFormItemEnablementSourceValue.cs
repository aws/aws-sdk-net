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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// An enablement expression source value.
    /// </summary>
    public partial class EvaluationFormItemEnablementSourceValue
    {
        private string _refId;
        private EvaluationFormItemEnablementSourceValueType _type;

        /// <summary>
        /// Gets and sets the property RefId. 
        /// <para>
        /// A referenceId of the source value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string RefId
        {
            get { return this._refId; }
            set { this._refId = value; }
        }

        // Check to see if RefId property is set
        internal bool IsSetRefId()
        {
            return this._refId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// A type of source item value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationFormItemEnablementSourceValueType Type
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