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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the StartBlueprintRun operation.
    /// Starts a new run of the specified blueprint.
    /// </summary>
    public partial class StartBlueprintRunRequest : AmazonGlueRequest
    {
        private string _blueprintName;
        private string _parameters;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property BlueprintName. 
        /// <para>
        /// The name of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string BlueprintName
        {
            get { return this._blueprintName; }
            set { this._blueprintName = value; }
        }

        // Check to see if BlueprintName property is set
        internal bool IsSetBlueprintName()
        {
            return this._blueprintName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Specifies the parameters as a <c>BlueprintParameters</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// Specifies the IAM role used to create the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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

    }
}