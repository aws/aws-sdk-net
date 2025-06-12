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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents a structure for defining parameter conditions. Supported conditions are
    /// described here: <a href="https://docs.aws.amazon.com/databrew/latest/dg/datasets.multiple-files.html#conditions.for.dynamic.datasets">Supported
    /// conditions for dynamic datasets</a> in the <i>Glue DataBrew Developer Guide</i>.
    /// </summary>
    public partial class FilterExpression
    {
        private string _expression;
        private Dictionary<string, string> _valuesMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression which includes condition names followed by substitution variables,
        /// possibly grouped and combined with other conditions. For example, "(starts_with :prefix1
        /// or starts_with :prefix2) and (ends_with :suffix1 or ends_with :suffix2)". Substitution
        /// variables should start with ':' symbol.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=1024)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property ValuesMap. 
        /// <para>
        /// The map of substitution variable names to their values used in this filter expression.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> ValuesMap
        {
            get { return this._valuesMap; }
            set { this._valuesMap = value; }
        }

        // Check to see if ValuesMap property is set
        internal bool IsSetValuesMap()
        {
            return this._valuesMap != null && (this._valuesMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}