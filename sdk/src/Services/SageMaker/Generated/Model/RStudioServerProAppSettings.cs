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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A collection of settings that configure user interaction with the <c>RStudioServerPro</c>
    /// app.
    /// </summary>
    public partial class RStudioServerProAppSettings
    {
        private RStudioServerProAccessStatus _accessStatus;
        private RStudioServerProUserGroup _userGroup;

        /// <summary>
        /// Gets and sets the property AccessStatus. 
        /// <para>
        /// Indicates whether the current user has access to the <c>RStudioServerPro</c> app.
        /// </para>
        /// </summary>
        public RStudioServerProAccessStatus AccessStatus
        {
            get { return this._accessStatus; }
            set { this._accessStatus = value; }
        }

        // Check to see if AccessStatus property is set
        internal bool IsSetAccessStatus()
        {
            return this._accessStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UserGroup. 
        /// <para>
        /// The level of permissions that the user has within the <c>RStudioServerPro</c> app.
        /// This value defaults to `User`. The `Admin` value allows the user access to the RStudio
        /// Administrative Dashboard.
        /// </para>
        /// </summary>
        public RStudioServerProUserGroup UserGroup
        {
            get { return this._userGroup; }
            set { this._userGroup = value; }
        }

        // Check to see if UserGroup property is set
        internal bool IsSetUserGroup()
        {
            return this._userGroup != null;
        }

    }
}