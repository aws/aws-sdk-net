/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStar.Model
{
    /// <summary>
    /// The toolchain template file provided with the project request. AWS CodeStar uses the
    /// template to provision the toolchain stack in AWS CloudFormation.
    /// </summary>
    public partial class Toolchain
    {
        private string _roleArn;
        private ToolchainSource _source;
        private Dictionary<string, string> _stackParameters = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The service role ARN for AWS CodeStar to use for the toolchain template during stack
        /// provisioning.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon S3 location where the toolchain template file provided with the project
        /// request is stored. AWS CodeStar retrieves the file during project creation.
        /// </para>
        /// </summary>
        public ToolchainSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property StackParameters. 
        /// <para>
        /// The list of parameter overrides to be passed into the toolchain template during stack
        /// provisioning, if any.
        /// </para>
        /// </summary>
        public Dictionary<string, string> StackParameters
        {
            get { return this._stackParameters; }
            set { this._stackParameters = value; }
        }

        // Check to see if StackParameters property is set
        internal bool IsSetStackParameters()
        {
            return this._stackParameters != null && this._stackParameters.Count > 0; 
        }

    }
}