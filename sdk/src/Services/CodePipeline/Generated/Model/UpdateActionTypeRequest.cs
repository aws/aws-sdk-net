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
    /// Container for the parameters to the UpdateActionType operation.
    /// Updates an action type that was created with any supported integration model, where
    /// the action type is to be used by customers of the action type provider. Use a JSON
    /// file with the action definition and <c>UpdateActionType</c> to provide the full structure.
    /// </summary>
    public partial class UpdateActionTypeRequest : AmazonCodePipelineRequest
    {
        private ActionTypeDeclaration _actionType;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The action type definition for the action type to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionTypeDeclaration ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

    }
}