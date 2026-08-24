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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the StartAgentRecommendationGeneration operation.
    /// Initiates a new recommendation generation process for the specified optimization profile.
    /// This asynchronous operation analyzes your Amazon Web Services resources and generates
    /// optimization recommendations based on the configured pillars and scope. Use GetAgentRecommendationGeneration
    /// to check status.
    /// </summary>
    public partial class StartAgentRecommendationGenerationRequest : AmazonWellArchitectedRequest
    {
        private Amazon.Runtime.Documents.Document _additionalContext;
        private string _name;
        private string _profileArn;
        private Scope _scope;
        private List<string> _types = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalContext. 
        /// <para>
        /// Optional additional context to guide the recommendation generation, such as specific
        /// business requirements or constraints.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AdditionalContext
        {
            get { return this._additionalContext; }
            set { this._additionalContext = value; }
        }

        // Check to see if AdditionalContext property is set
        internal bool IsSetAdditionalContext()
        {
            return !this._additionalContext.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional name for this generation process to help identify it in lists and logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the optimization profile to use for generating recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ProfileArn
        {
            get { return this._profileArn; }
            set { this._profileArn = value; }
        }

        // Check to see if ProfileArn property is set
        internal bool IsSetProfileArn()
        {
            return this._profileArn != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Scope configuration to focus the generation on specific pillars or goals.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// The types of recommendations to generate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && (this._types.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}