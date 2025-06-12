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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCodeSigningConfig operation.
    /// Creates a code signing configuration. A <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html">code
    /// signing configuration</a> defines a list of allowed signing profiles and defines the
    /// code-signing validation policy (action to be taken if deployment validation checks
    /// fail).
    /// </summary>
    public partial class CreateCodeSigningConfigRequest : AmazonLambdaRequest
    {
        private AllowedPublishers _allowedPublishers;
        private CodeSigningPolicies _codeSigningPolicies;
        private string _description;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedPublishers. 
        /// <para>
        /// Signing profiles for this code signing configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AllowedPublishers AllowedPublishers
        {
            get { return this._allowedPublishers; }
            set { this._allowedPublishers = value; }
        }

        // Check to see if AllowedPublishers property is set
        internal bool IsSetAllowedPublishers()
        {
            return this._allowedPublishers != null;
        }

        /// <summary>
        /// Gets and sets the property CodeSigningPolicies. 
        /// <para>
        /// The code signing policies define the actions to take if the validation checks fail.
        /// 
        /// </para>
        /// </summary>
        public CodeSigningPolicies CodeSigningPolicies
        {
            get { return this._codeSigningPolicies; }
            set { this._codeSigningPolicies = value; }
        }

        // Check to see if CodeSigningPolicies property is set
        internal bool IsSetCodeSigningPolicies()
        {
            return this._codeSigningPolicies != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Descriptive name for this code signing configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to add to the code signing configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}