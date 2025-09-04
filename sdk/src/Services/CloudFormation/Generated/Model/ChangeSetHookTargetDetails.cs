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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Specifies target details for an activated Hook.
    /// </summary>
    public partial class ChangeSetHookTargetDetails
    {
        private ChangeSetHookResourceTargetDetails _resourceTargetDetails;
        private HookTargetType _targetType;

        /// <summary>
        /// Gets and sets the property ResourceTargetDetails. 
        /// <para>
        /// Required if <c>TargetType</c> is <c>RESOURCE</c>.
        /// </para>
        /// </summary>
        public ChangeSetHookResourceTargetDetails ResourceTargetDetails
        {
            get { return this._resourceTargetDetails; }
            set { this._resourceTargetDetails = value; }
        }

        // Check to see if ResourceTargetDetails property is set
        internal bool IsSetResourceTargetDetails()
        {
            return this._resourceTargetDetails != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The name of the type.
        /// </para>
        /// </summary>
        public HookTargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

    }
}