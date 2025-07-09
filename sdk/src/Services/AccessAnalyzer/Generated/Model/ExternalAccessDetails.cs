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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about an external access finding.
    /// </summary>
    public partial class ExternalAccessDetails
    {
        private List<string> _action = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _condition = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _isPublic;
        private Dictionary<string, string> _principal = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ResourceControlPolicyRestriction _resourceControlPolicyRestriction;
        private List<FindingSource> _sources = AWSConfigs.InitializeCollections ? new List<FindingSource>() : null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action in the analyzed policy statement that an external principal has permission
        /// to use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null && (this._action.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The condition in the analyzed policy statement that resulted in an external access
        /// finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null && (this._condition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsPublic. 
        /// <para>
        /// Specifies whether the external access finding is public.
        /// </para>
        /// </summary>
        public bool? IsPublic
        {
            get { return this._isPublic; }
            set { this._isPublic = value; }
        }

        // Check to see if IsPublic property is set
        internal bool IsSetIsPublic()
        {
            return this._isPublic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The external principal that has access to a resource within the zone of trust.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null && (this._principal.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceControlPolicyRestriction. 
        /// <para>
        /// The type of restriction applied to the finding by the resource owner with an Organizations
        /// resource control policy (RCP).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>APPLICABLE</c>: There is an RCP present in the organization but IAM Access Analyzer
        /// does not include it in the evaluation of effective permissions. For example, if <c>s3:DeleteObject</c>
        /// is blocked by the RCP and the restriction is <c>APPLICABLE</c>, then <c>s3:DeleteObject</c>
        /// would still be included in the list of actions for the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_TO_EVALUATE_RCP</c>: There was an error evaluating the RCP.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_APPLICABLE</c>: There was no RCP present in the organization, or there was
        /// no RCP applicable to the resource. For example, the resource being analyzed is an
        /// Amazon RDS snapshot and there is an RCP in the organization, but the RCP only impacts
        /// Amazon S3 buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPLIED</c>: This restriction is not currently available for external access findings.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceControlPolicyRestriction ResourceControlPolicyRestriction
        {
            get { return this._resourceControlPolicyRestriction; }
            set { this._resourceControlPolicyRestriction = value; }
        }

        // Check to see if ResourceControlPolicyRestriction property is set
        internal bool IsSetResourceControlPolicyRestriction()
        {
            return this._resourceControlPolicyRestriction != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The sources of the external access finding. This indicates how the access that generated
        /// the finding is granted. It is populated for Amazon S3 bucket findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FindingSource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}