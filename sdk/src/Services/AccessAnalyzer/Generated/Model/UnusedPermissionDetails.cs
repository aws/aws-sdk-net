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
    /// Contains information about an unused access finding for a permission. IAM Access Analyzer
    /// charges for unused access analysis based on the number of IAM roles and users analyzed
    /// per month. For more details on pricing, see <a href="https://aws.amazon.com/iam/access-analyzer/pricing">IAM
    /// Access Analyzer pricing</a>.
    /// </summary>
    public partial class UnusedPermissionDetails
    {
        private List<UnusedAction> _actions = AWSConfigs.InitializeCollections ? new List<UnusedAction>() : null;
        private DateTime? _lastAccessed;
        private string _serviceNamespace;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of unused actions for which the unused access finding was generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnusedAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastAccessed. 
        /// <para>
        /// The time at which the permission was last accessed.
        /// </para>
        /// </summary>
        public DateTime? LastAccessed
        {
            get { return this._lastAccessed; }
            set { this._lastAccessed = value; }
        }

        // Check to see if LastAccessed property is set
        internal bool IsSetLastAccessed()
        {
            return this._lastAccessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the Amazon Web Services service that contains the unused actions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceNamespace
        {
            get { return this._serviceNamespace; }
            set { this._serviceNamespace = value; }
        }

        // Check to see if ServiceNamespace property is set
        internal bool IsSetServiceNamespace()
        {
            return this._serviceNamespace != null;
        }

    }
}