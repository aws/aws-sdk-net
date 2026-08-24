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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The properties used to update an existing Git connection, such as the CodeConnections
    /// ARN or the default branch.
    /// </summary>
    public partial class GitPropertiesPatch
    {
        private string _codeConnectionArn;
        private string _defaultBranch;

        /// <summary>
        /// Gets and sets the property CodeConnectionArn. 
        /// <para>
        /// The ARN of the CodeConnections connection used to connect to the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string CodeConnectionArn
        {
            get { return this._codeConnectionArn; }
            set { this._codeConnectionArn = value; }
        }

        // Check to see if CodeConnectionArn property is set
        internal bool IsSetCodeConnectionArn()
        {
            return this._codeConnectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultBranch. 
        /// <para>
        /// The default branch of the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DefaultBranch
        {
            get { return this._defaultBranch; }
            set { this._defaultBranch = value; }
        }

        // Check to see if DefaultBranch property is set
        internal bool IsSetDefaultBranch()
        {
            return this._defaultBranch != null;
        }

    }
}