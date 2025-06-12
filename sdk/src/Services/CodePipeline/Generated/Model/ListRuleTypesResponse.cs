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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// This is the response object from the ListRuleTypes operation.
    /// </summary>
    public partial class ListRuleTypesResponse : AmazonWebServiceResponse
    {
        private List<RuleType> _ruleTypes = AWSConfigs.InitializeCollections ? new List<RuleType>() : null;

        /// <summary>
        /// Gets and sets the property RuleTypes. 
        /// <para>
        /// Lists the rules that are configured for the condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RuleType> RuleTypes
        {
            get { return this._ruleTypes; }
            set { this._ruleTypes = value; }
        }

        // Check to see if RuleTypes property is set
        internal bool IsSetRuleTypes()
        {
            return this._ruleTypes != null && (this._ruleTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}