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
    /// Details about a <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html">Code
    /// signing configuration</a>.
    /// </summary>
    public partial class CodeSigningConfig
    {
        private AllowedPublishers _allowedPublishers;
        private string _codeSigningConfigArn;
        private string _codeSigningConfigId;
        private CodeSigningPolicies _codeSigningPolicies;
        private string _description;
        private string _lastModified;

        /// <summary>
        /// Gets and sets the property AllowedPublishers. 
        /// <para>
        /// List of allowed publishers.
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
        /// Gets and sets the property CodeSigningConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Code signing configuration.
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
        /// Gets and sets the property CodeSigningConfigId. 
        /// <para>
        /// Unique identifer for the Code signing configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CodeSigningConfigId
        {
            get { return this._codeSigningConfigId; }
            set { this._codeSigningConfigId = value; }
        }

        // Check to see if CodeSigningConfigId property is set
        internal bool IsSetCodeSigningConfigId()
        {
            return this._codeSigningConfigId != null;
        }

        /// <summary>
        /// Gets and sets the property CodeSigningPolicies. 
        /// <para>
        /// The code signing policy controls the validation failure action for signature mismatch
        /// or expiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Code signing configuration description.
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
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that the Code signing configuration was last modified, in ISO-8601
        /// format (YYYY-MM-DDThh:mm:ss.sTZD). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified != null;
        }

    }
}