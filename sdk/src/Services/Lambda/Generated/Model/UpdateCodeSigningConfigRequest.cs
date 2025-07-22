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
    /// Container for the parameters to the UpdateCodeSigningConfig operation.
    /// Update the code signing configuration. Changes to the code signing configuration take
    /// effect the next time a user tries to deploy a code package to the function.
    /// </summary>
    public partial class UpdateCodeSigningConfigRequest : AmazonLambdaRequest
    {
        private AllowedPublishers _allowedPublishers;
        private string _codeSigningConfigArn;
        private CodeSigningPolicies _codeSigningPolicies;
        private string _description;

        /// <summary>
        /// Gets and sets the property AllowedPublishers. 
        /// <para>
        /// Signing profiles for this code signing configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CodeSigningConfigArn. 
        /// <para>
        /// The The Amazon Resource Name (ARN) of the code signing configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public string CodeSigningConfigArn
        {
            get { return this._codeSigningConfigArn; }
            set { this._codeSigningConfigArn = value; }
        }

        // Check to see if CodeSigningConfigArn property is set
        internal bool IsSetCodeSigningConfigArn()
        {
            return this._codeSigningConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property CodeSigningPolicies. 
        /// <para>
        /// The code signing policy.
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

    }
}