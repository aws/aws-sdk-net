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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Details about the the configuration of the built-in <c>Amazon.QnAIntent</c>.
    /// </summary>
    public partial class QnAIntentConfiguration
    {
        private BedrockModelSpecification _bedrockModelConfiguration;
        private DataSourceConfiguration _dataSourceConfiguration;

        /// <summary>
        /// Gets and sets the property BedrockModelConfiguration.
        /// </summary>
        public BedrockModelSpecification BedrockModelConfiguration
        {
            get { return this._bedrockModelConfiguration; }
            set { this._bedrockModelConfiguration = value; }
        }

        // Check to see if BedrockModelConfiguration property is set
        internal bool IsSetBedrockModelConfiguration()
        {
            return this._bedrockModelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// Contains details about the configuration of the data source used for the <c>AMAZON.QnAIntent</c>.
        /// </para>
        /// </summary>
        public DataSourceConfiguration DataSourceConfiguration
        {
            get { return this._dataSourceConfiguration; }
            set { this._dataSourceConfiguration = value; }
        }

        // Check to see if DataSourceConfiguration property is set
        internal bool IsSetDataSourceConfiguration()
        {
            return this._dataSourceConfiguration != null;
        }

    }
}