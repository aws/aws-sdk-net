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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines the Amazon Cognito user group that is part of a work team.
    /// </summary>
    public partial class MemberDefinition
    {
        private CognitoMemberDefinition _cognitoMemberDefinition;

        /// <summary>
        /// Gets and sets the property CognitoMemberDefinition. 
        /// <para>
        /// The Amazon Cognito user group that is part of the work team.
        /// </para>
        /// </summary>
        public CognitoMemberDefinition CognitoMemberDefinition
        {
            get { return this._cognitoMemberDefinition; }
            set { this._cognitoMemberDefinition = value; }
        }

        // Check to see if CognitoMemberDefinition property is set
        internal bool IsSetCognitoMemberDefinition()
        {
            return this._cognitoMemberDefinition != null;
        }

    }
}