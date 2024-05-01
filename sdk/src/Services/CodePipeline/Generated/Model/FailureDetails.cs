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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about failure details.
    /// </summary>
    public partial class FailureDetails
    {
        private string _externalExecutionId;
        private string _message;
        private FailureType _type;

        /// <summary>
        /// Gets and sets the property ExternalExecutionId. 
        /// <para>
        /// The external ID of the run of the action that failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1500)]
        public string ExternalExecutionId
        {
            get { return this._externalExecutionId; }
            set { this._externalExecutionId = value; }
        }

        // Check to see if ExternalExecutionId property is set
        internal bool IsSetExternalExecutionId()
        {
            return this._externalExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message about the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5000)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FailureType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}