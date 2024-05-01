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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Provides configuration information for the AMAZON.KendraSearchIntent intent. When
    /// you use this intent, Amazon Lex searches the specified Amazon Kendra index and returns
    /// documents from the index that match the user's utterance. For more information, see
    /// <a href="http://docs.aws.amazon.com/lex/latest/dg/built-in-intent-kendra-search.html">
    /// AMAZON.KendraSearchIntent</a>.
    /// </summary>
    public partial class KendraConfiguration
    {
        private string _kendraIndex;
        private string _queryFilterString;
        private string _role;

        /// <summary>
        /// Gets and sets the property KendraIndex. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Kendra index that you want the AMAZON.KendraSearchIntent
        /// intent to search. The index must be in the same account and Region as the Amazon Lex
        /// bot. If the Amazon Kendra index does not exist, you get an exception when you call
        /// the <c>PutIntent</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string KendraIndex
        {
            get { return this._kendraIndex; }
            set { this._kendraIndex = value; }
        }

        // Check to see if KendraIndex property is set
        internal bool IsSetKendraIndex()
        {
            return this._kendraIndex != null;
        }

        /// <summary>
        /// Gets and sets the property QueryFilterString. 
        /// <para>
        /// A query filter that Amazon Lex sends to Amazon Kendra to filter the response from
        /// the query. The filter is in the format defined by Amazon Kendra. For more information,
        /// see <a href="http://docs.aws.amazon.com/kendra/latest/dg/filtering.html">Filtering
        /// queries</a>.
        /// </para>
        ///  
        /// <para>
        /// You can override this filter string with a new filter string at runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public string QueryFilterString
        {
            get { return this._queryFilterString; }
            set { this._queryFilterString = value; }
        }

        // Check to see if QueryFilterString property is set
        internal bool IsSetQueryFilterString()
        {
            return this._queryFilterString != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that has permission to search the Amazon
        /// Kendra index. The role must be in the same account and Region as the Amazon Lex bot.
        /// If the role does not exist, you get an exception when you call the <c>PutIntent</c>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

    }
}