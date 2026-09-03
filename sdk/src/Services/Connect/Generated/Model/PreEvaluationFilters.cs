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
    /// The pre-evaluation filters for a rule, that restrict a rule to be applied to only
    /// certain resources based on the resource's attributes, such as tags assigned to a contact.
    /// The pre-evaluation filters are applied even before rule conditions are evaluated and
    /// are used to enforce tag-based-access-control while applying rules.
    /// </summary>
    public partial class PreEvaluationFilters
    {
        private List<PreEvaluationFilter> _andConditions = AWSConfigs.InitializeCollections ? new List<PreEvaluationFilter>() : null;

        /// <summary>
        /// Gets and sets the property AndConditions. 
        /// <para>
        /// A list of conditions that the rule evaluates together using AND logic. All conditions
        /// must be met for the event to be evaluated by the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PreEvaluationFilter> AndConditions
        {
            get { return this._andConditions; }
            set { this._andConditions = value; }
        }

        // Check to see if AndConditions property is set
        internal bool IsSetAndConditions()
        {
            return this._andConditions != null && (this._andConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}