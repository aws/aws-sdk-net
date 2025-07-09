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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// This is the response object from the CreateScript operation.
    /// </summary>
    public partial class CreateScriptResponse : AmazonWebServiceResponse
    {
        private Script _script;

        /// <summary>
        /// Gets and sets the property Script. 
        /// <para>
        /// The newly created script record with a unique script ID and ARN. The new script's
        /// storage location reflects an Amazon S3 location: (1) If the script was uploaded from
        /// an S3 bucket under your account, the storage location reflects the information that
        /// was provided in the <i>CreateScript</i> request; (2) If the script file was uploaded
        /// from a local zip file, the storage location reflects an S3 location controls by the
        /// Amazon GameLift Servers service.
        /// </para>
        /// </summary>
        public Script Script
        {
            get { return this._script; }
            set { this._script = value; }
        }

        // Check to see if Script property is set
        internal bool IsSetScript()
        {
            return this._script != null;
        }

    }
}