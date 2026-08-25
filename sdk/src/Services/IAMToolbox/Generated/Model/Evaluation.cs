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
 * Do not modify this file. This file is generated from the iam-toolbox-2018-05-10.normal.json service model.
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
namespace Amazon.IAMToolbox.Model
{
    /// <summary>
    /// Represents an individual evaluation for a single action and resource pair. This includes
    /// the context, the resulting effect, and any policies that matched.
    /// </summary>
    public partial class Evaluation
    {
        private string _action;
        private Dictionary<string, Amazon.Runtime.Documents.Document> _context = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;
        private EvaluatedEffect _evaluatedEffect;
        private List<MatchedPolicy> _matchedPolicies = AWSConfigs.InitializeCollections ? new List<MatchedPolicy>() : null;
        private string _resource;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action evaluated for this request (for example, <c>iam:PassRole</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// The context keys and values specific to this evaluation. These are applied on top
        /// of the request context.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Amazon.Runtime.Documents.Document> Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null && (this._context.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluatedEffect. 
        /// <para>
        /// The result of the evaluation. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOW</c> - The action was allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPLICIT_DENY</c> - The action was explicitly denied by a policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPLICIT_DENY</c> - The action was denied because no policy allowed it.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EvaluatedEffect EvaluatedEffect
        {
            get { return this._evaluatedEffect; }
            set { this._evaluatedEffect = value; }
        }

        // Check to see if EvaluatedEffect property is set
        internal bool IsSetEvaluatedEffect()
        {
            return this._evaluatedEffect != null;
        }

        /// <summary>
        /// Gets and sets the property MatchedPolicies. 
        /// <para>
        /// The policies that matched during evaluation of this action and resource. An implicit
        /// denial produces no matched policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MatchedPolicy> MatchedPolicies
        {
            get { return this._matchedPolicies; }
            set { this._matchedPolicies = value; }
        }

        // Check to see if MatchedPolicies property is set
        internal bool IsSetMatchedPolicies()
        {
            return this._matchedPolicies != null && (this._matchedPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource that the action targeted. This is typically a resource ARN, but can be
        /// a wildcard ARN that matches multiple resources, or empty for actions that are not
        /// resource-specific.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}