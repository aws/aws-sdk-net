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
    /// An expression that defines a basic building block of conditional enablement.
    /// </summary>
    public partial class EvaluationFormItemEnablementExpression
    {
        private EvaluationFormItemSourceValuesComparator _comparator;
        private EvaluationFormItemEnablementSource _source;
        private List<EvaluationFormItemEnablementSourceValue> _values = AWSConfigs.InitializeCollections ? new List<EvaluationFormItemEnablementSourceValue>() : null;

        /// <summary>
        /// Gets and sets the property Comparator. 
        /// <para>
        /// A comparator to be used against list of values. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationFormItemSourceValuesComparator Comparator
        {
            get { return this._comparator; }
            set { this._comparator = value; }
        }

        // Check to see if Comparator property is set
        internal bool IsSetComparator()
        {
            return this._comparator != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// A source item of enablement expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationFormItemEnablementSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// A list of values from source item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<EvaluationFormItemEnablementSourceValue> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}